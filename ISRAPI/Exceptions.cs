// Copyright (c) Chilimeat & joemorin
// SPDX-License-Identifier: MIT License

using System;
using System.Collections.Generic;
using System.Text;

namespace ISRAPI
{
    public class ProcessAlreadyStartedException : Exception
    {
        public ProcessAlreadyStartedException(string message) : base(message) { }
    }

    public class IRRunningDetachedException : Exception
    {
        public IRRunningDetachedException(string message) : base(message) { }
    }
}
