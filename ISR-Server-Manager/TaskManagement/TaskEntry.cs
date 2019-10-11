// Copyright (c) Chilimeat & joemorin
// SPDX-License-Identifier: MIT License

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISR_Server_Manager.TaskManagement
{
    public enum OccurrenceTypeEnum
    {
        Daily,
        Weekly
    }

    public class TaskEntry
    {
        public IEventTime EventTime { get; set; }
        public IActivity Activity { get; set; }
    }   
}
