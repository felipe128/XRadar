using MaterialSkin;
using MaterialSkin.Controls;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Resources;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlbionNetwork2D
{
    public partial class Login : MaterialForm
    {
        private string appVersion = "1201";
        private string baseURL = "https://teclandotec.com/api/login/";
        private string appLogin;
        private string appPassword;
        private string appHwid;
        public static string appExpires;
        private int appTimestamp;
        private int loginCount;
        Options options;

        public Login()
        {
            Settings.loadLanguage();
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(Settings.languageSelected);

            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, (Accent)Primary.BlueGrey500, TextShade.WHITE);
        }
        private void Login_Load(object sender, EventArgs e)
        {
            Settings.loadLoginSettings(this);
        }
        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            if (userLogin.Text.Length > 1 && passwordLogin.Text.Length > 1)
            {
                appLogin = userLogin.Text;
                appPassword = Utils.Encryption.MD5Hash(passwordLogin.Text);
                appHwid = UHWID.UHWID.SimpleUid;

                doLogin();
            }
        }

        private void throwError()
        {
            MessageBox.Show("Unknown error!\nPlease try again later or contact us on our discord.", this.Text,
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void restartApp()
        {
            #if (!DEBUG)
            Application.Restart();
            Environment.Exit(0);
            #endif
        }

        private string generateJson(bool isLogin = false)
        {
            appTimestamp = (Int32)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;

            return "{\"login\":\"" + appLogin + "\",\"password\":\"" + appPassword + "\",\"hwid\":\"" + appHwid + "\",\"version\":\"" + appVersion + "\",\"isLogin\":\"" + isLogin + "\",\"timestamp\":" + appTimestamp + "}";
        }

        private void doLogin()
        {
            string json = generateJson(true);

            WebRequest request = WebRequest.Create(baseURL + Utils.Encryption.StringToHex(Utils.Encryption.EncryptString(json)));
            request.Credentials = CredentialCache.DefaultCredentials;

            try
            {
                WebResponse response = request.GetResponse();
                using (Stream dataStream = response.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(dataStream);
                    string responseFromServer = reader.ReadToEnd();
                    dynamic jsonArray = JsonConvert.DeserializeObject(Utils.Encryption.DecryptString(Utils.Encryption.HexToString(responseFromServer)));

                    if (jsonArray != null)
                    {
                        if (jsonArray.canLogin == true && jsonArray.timestamp == appTimestamp)
                        {
                            loginCount = 0;
                            appExpires = jsonArray.expires;
                            licenseTimer.Start();

                            if(Settings.languageSelected != "EN")
                            {
                                appExpires = appExpires.Replace("days left", "dias restantes");
                                appExpires = appExpires.Replace("hours left", "horas restantes");
                            }

                            Settings.saveLoginSettings(this);
                            startRadar();
                        }
                        else
                        {
                            if(jsonArray.timestamp != appTimestamp)
                                throwError();

                            var result = MessageBox.Show((string)jsonArray.errorMessage, this.Text,
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                            if (jsonArray.link != null)
                            {
                                Process.Start((string)jsonArray.link);
                            }
                        }
                    }
                    else
                    {
                        throwError();
                    }

                    response.Close();
                }
            }
            catch (Exception)
            {
                throwError();
            }
        }

        private void startRadar()
        {
            options = new Options();
            options.Show();
            this.Hide();
        }

        private void licenseTimer_Tick(object sender, EventArgs e)
        {
            Thread t = new Thread(() =>
            {
                string json = generateJson();

                WebRequest request = WebRequest.Create(baseURL + Utils.Encryption.StringToHex(Utils.Encryption.EncryptString(json)));
                request.Credentials = CredentialCache.DefaultCredentials;

                try
                {
                    WebResponse response = request.GetResponse();
                    using (Stream dataStream = response.GetResponseStream())
                    {
                        StreamReader reader = new StreamReader(dataStream);
                        string responseFromServer = reader.ReadToEnd();
                        dynamic jsonArray = JsonConvert.DeserializeObject(Utils.Encryption.DecryptString(Utils.Encryption.HexToString(responseFromServer)));

                        if (jsonArray != null)
                        {
                            if (jsonArray.canLogin == true && jsonArray.timestamp == appTimestamp)
                            {
                                loginCount = 0;
                                appExpires = jsonArray.expires;
                            }
                            else
                            {
                                restartApp();
                            }
                        }
                        else
                        {
                            loginCount++;
                        }

                        if (loginCount >= 3)
                        {
                            restartApp();
                        }

                        response.Close();
                    }
                }
                catch (Exception)
                {
                    loginCount++;

                    if (loginCount >= 3)
                    {
                        restartApp();
                    }
                }
            });

            t.Start();
        }

        private void Login_Shown(object sender, EventArgs e)
        {
            // DEBUG = TRUE | RELEASE = FALSE
            bool debug = true;

            if (debug)
                startRadar();
        }
    }
}
