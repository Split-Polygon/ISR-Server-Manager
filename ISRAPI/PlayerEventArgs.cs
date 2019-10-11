// Copyright (c) Chilimeat & joemorin
// SPDX-License-Identifier: MIT License

using System;
using System.Collections.Generic;
using System.Text;

namespace ISRAPI
{
    public class OutputEventArgs : EventArgs
    {
        public String Data { get; set; }

        public OutputEventArgs(String data) : base()
        {
            Data = data;
        }
    }
}
