﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GS1.Interfaces.Models.Events;

namespace OpenTraceability.Models.Events
{
    public class EventBusinessTransaction : IEventBusinessTransaction
    {
        public string RawType { get; set; }
        public EventBusinessTransactionType Type { get; set; }
        public string Value { get; set; }
    }
}
