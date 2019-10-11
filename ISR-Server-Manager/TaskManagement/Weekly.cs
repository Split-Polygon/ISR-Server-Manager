// Copyright (c) Chilimeat & joemorin
// SPDX-License-Identifier: MIT License

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISR_Server_Manager.TaskManagement
{
    [Flags]
    public enum DaysOfWeekenum
    {
        Sunday = 1,
        Monday = 2,
        Tuesday = 4,
        Wednesday = 8,
        Thursday = 16,
        Friday = 32,
        Saturday = 64
    }

    public class Weekly : IEventTime
    {
        public DaysOfWeekenum DaysOfWeeks { get; set; }
        public Byte Hour { get; set; }
        public Byte Minute { get; set; }

        public DateTime LastExection { get; set; }

        public Int32 NextActivity()
        {
            DateTime result = new DateTime(DateTime.Now.Year,
                                           DateTime.Now.Month,
                                           DateTime.Now.Day,
                                           Hour,
                                           Minute,
                                           0);

            if (result < DateTime.Now)
                result = result.AddDays(1);

            //result.DayOfWeek;

            return (DateTime.Now - result).Milliseconds;
        }
    }
}
