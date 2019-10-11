// Copyright (c) Chilimeat & joemorin
// SPDX-License-Identifier: MIT License

using System;

namespace ISR_Server_Manager.TaskManagement
{
    public interface IEventTime
    {
        DateTime LastExection { get; set; }
        Int32 NextActivity();
    }
}
