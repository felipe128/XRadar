﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace AlbionRadar
{
    public static class Settings
    {
        private static bool isBeeping = false;

        public static void saveSettings(Options form)
        {
            AppSettings s = new AppSettings();

            String[] guildsList = new string[form.lbTrustGuilds.Items.Count];
            String[] allianceList = new string[form.lbTrustAlliances.Items.Count];

            form.lbTrustGuilds.Items.CopyTo(guildsList, 0);
            form.lbTrustAlliances.Items.CopyTo(allianceList, 0);

            s.trustGuilds = JsonConvert.SerializeObject(guildsList.ToArray());
            s.trustAlliances = JsonConvert.SerializeObject(allianceList.ToArray());

            s.displayOption = form.pCbDisplayOptions.Controls.OfType<MaterialSkin.Controls.MaterialRadioButton>().FirstOrDefault(r => r.Checked).Name;

            s.radarPosX = (int)form.nRadarPosX.Value;
            s.radarPosY = (int)form.nRadarPosY.Value;
            s.showRadar = form.cbShowRadar.Checked;
            s.showPlayers = form.cbShowPlayers.Checked;
            s.showMobs = form.cbShowMobs.Checked;
            s.alertSound = form.cbAlertSound.Checked;

            s.Save();

        }
        public static void loadSettings(Options form)
        {
            AppSettings s = new AppSettings();

            foreach (String guild in JsonConvert.DeserializeObject<List<string>>(s.trustGuilds))
                form.lbTrustGuilds.Items.Add(guild);

            foreach (String alliance in JsonConvert.DeserializeObject<List<string>>(s.trustAlliances))
                form.lbTrustAlliances.Items.Add(alliance);

            form.pCbDisplayOptions.Controls.OfType<MaterialSkin.Controls.MaterialRadioButton>()
                .FirstOrDefault(r => r.Name == s.displayOption).Checked = true;

            form.nRadarPosX.Value = s.radarPosX;
            form.nRadarPosY.Value = s.radarPosY;
            form.cbShowRadar.Checked = s.showRadar;
            form.cbShowPlayers.Checked = s.showPlayers;
            form.cbShowMobs.Checked = s.showMobs;
            form.cbAlertSound.Checked = s.alertSound;
        }

        public static void needBeepSound(String guild, String alliance)
        {
            AppSettings s = new AppSettings();

            List<String> guildList = JsonConvert.DeserializeObject<List<string>>(s.trustGuilds);
            List<String> AllianceList = JsonConvert.DeserializeObject<List<string>>(s.trustGuilds);

            if(s.alertSound && !isBeeping)
            {
                if (!guildList.Contains(guild) || !alliance.Contains(alliance))
                {
                    isBeeping = true;

                    new Thread(() =>
                    {
                        Console.Beep(500, 500);
                        Thread.Sleep(2000);

                        isBeeping = false;
                    }).Start();
                }
                
            }
        }
    }
}