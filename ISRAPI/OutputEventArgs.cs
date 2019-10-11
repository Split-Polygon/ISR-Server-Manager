// Copyright (c) Chilimeat & joemorin
// SPDX-License-Identifier: MIT License

using System;
using System.Collections.Generic;
using System.Text;

namespace ISRAPI
{
    public enum PlayerActivityEnum
    {
        Join,
        Leave
    }

    public class PlayerEventArgs : EventArgs
    {
        public String Name { get; set; }
        public PlayerActivityEnum Activity { get; set; }

        public PlayerEventArgs(String name, PlayerActivityEnum activity) : base()
        {
            Name = name;
            Activity = activity;
        }
    }
}
