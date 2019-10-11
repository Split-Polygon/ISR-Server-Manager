// Copyright (c) Chilimeat & joemorin
// SPDX-License-Identifier: MIT License

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Text.RegularExpressions;

namespace ISRAPI
{


    public static class ServerAPI
    {
        static ServerConnection apiConnection;

        static ServerAPI() { }

        public static void Start(string pathToTheApp, string arguments)
        {
            apiConnection = new ServerConnection(pathToTheApp, arguments);
            apiConnection.OutputData += APIConnection_OutputData;

            apiConnection.Start();
        }

        #region Commands

        public static void ConsoleDirect(String msg)
        {
            apiConnection.SendToConsole(msg);
        }

        public static void MessageToAll(String msg)
        {
            apiConnection.SendToConsole("all " + msg);
        }

        public static void Exit()
        {
            apiConnection.SendToConsole("exit");
        }

        public static void ExitTimer(Int32 seconds, String msg)
        {
            apiConnection.SendToConsole("exittimer " + seconds + " " + msg);
        }

        #endregion

        #region Output Management

        public static event EventHandler<OutputEventArgs> ConsoleData;
        public static event EventHandler<OutputEventArgs> ChatData;
        public static event EventHandler<PlayerEventArgs> PlayerData;

        static readonly String chatTag = "[All] ";
        static readonly String srvDataTagPlayer = "[All]: Player ";
        static readonly String srvPlayerJoin = " joined the server";
        static readonly String srvPlayerLeave = " left the server";
        private static void APIConnection_OutputData(object sender, OutputEventArgs e)
        {
            if (e.Data == null) return;

            if (e.Data.IndexOf(chatTag) == 0)
                ChatData?.Invoke(sender, new OutputEventArgs(e.Data.Substring(chatTag.Length)));
            else if (e.Data.IndexOf(srvDataTagPlayer) == 0)
            {
                String result = e.Data.Substring(srvDataTagPlayer.Length);
                PlayerActivityEnum act = PlayerActivityEnum.Join;

                if (Regex.Match(result, "[A-Za-z0-9\\-]+" + srvPlayerJoin).Success)
                {
                    act = PlayerActivityEnum.Join;
                    result = result.Remove(result.Length - srvPlayerJoin.Length, srvPlayerJoin.Length);
                }
                if (Regex.Match(result, "[A-Za-z0-9\\-]+" + srvPlayerLeave).Success)
                {
                    act = PlayerActivityEnum.Leave;
                    result = result.Remove(result.Length - srvPlayerLeave.Length, srvPlayerLeave.Length);
                }

                PlayerData?.Invoke(sender, new PlayerEventArgs(result, act));
            }


            ConsoleData?.Invoke(sender, e);
        }

        #endregion
    }
}
