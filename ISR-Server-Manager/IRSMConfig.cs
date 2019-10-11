// Copyright (c) Chilimeat & joemorin
// SPDX-License-Identifier: MIT License

using ISR_Server_Manager.TaskManagement;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISR_Server_Manager
{
    public class IRSMConfig
    {
        #region SaveLoad Code

        public const string configFileName = "IRSMConfig.json";

        public static IRSMConfig LoadConfig()
        {
            if (File.Exists(configFileName))
            {
                return JsonConvert.DeserializeObject<IRSMConfig>(File.ReadAllText(configFileName));
            }
            else
            {
                var newConfig = new IRSMConfig();
                newConfig.InitValues();
                return newConfig;
            }
        }

        public void SaveConfig()
        {
            File.WriteAllText(configFileName, JsonConvert.SerializeObject(this));
        }

        public IRSMConfig()
        {

        }

        #endregion

        public void InitValues()
        {
            IRExePath = @"C:\Steam\IR\IR.EXE";
            ThreadMonitor = false;
            LastShutdownTime = 5;
            RestartServer = false;
            Tasks = new List<TaskEntry>();
        }

        public string IRExePath { get; set; }
        public Boolean ThreadMonitor { get; set; }
        public Int16 LastShutdownTime { get; set; }
        public Boolean RestartServer { get; set; }
        public List<TaskEntry> Tasks { get; set; }

    }
}
