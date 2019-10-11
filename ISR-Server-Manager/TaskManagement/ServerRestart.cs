// Copyright (c) Chilimeat & joemorin
// SPDX-License-Identifier: MIT License

using ISRAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISR_Server_Manager.TaskManagement
{
    public class ServerRestart : IActivity
    {
        public ServerRestart() { }

        public String Message { get; set; }
        public Int32 MinuteTimeout { get; set; }

        public void ExecuteTask()
        {
            ServerAPI.ExitTimer(MinuteTimeout * 60, Message);
        }
    }
}
