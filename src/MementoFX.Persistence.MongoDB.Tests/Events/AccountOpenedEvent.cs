﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoFX.Persistence.MongoDB.Tests.Events
{
    public class AccountOpenedEvent : UnitTestFriendlyDomainEvent
    {
        public decimal Balance { get; set; }

        public Guid CurrentAccountId { get; set; }
    }
}
