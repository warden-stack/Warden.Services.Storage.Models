﻿using System;
using System.Collections.Generic;

namespace Warden.Services.Storage.Models.WardenChecks
{
    public class WardenIteration
    {
        public Guid Id { get; set; }
        public string WardenName { get; set; }
        public long Ordinal { get; set; }
        public DateTime StartedAt { get; set; }
        public DateTime CompletedAt { get; set; }
        public TimeSpan ExecutionTime { get; set; }
        public bool IsValid { get; set; }
        public IList<WardenCheckResult> Results { get; set; }
    }
}