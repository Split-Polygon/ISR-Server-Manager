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
    public class ServerMessage : IActivity
    {
        public ServerMessage() { }

        public String Message { get; set; }

        public void ExecuteTask()
        {
            ServerAPI.MessageToAll(Message);
        }
    }
}
