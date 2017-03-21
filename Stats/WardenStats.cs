﻿using System;
using System.Collections.Generic;

namespace Warden.Services.Storage.Models.Stats
{
    public class WardenStats
    {
        public Guid OrganizationId { get; set; }
        public string WardenName { get; set; }
        public bool Enabled { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public double TotalUptime { get; set; }
        public double TotalDowntime { get; set; }
        public double TotalIterations { get; set; }
        public double TotalValidIterations { get; set; }
        public double TotalInvalidIterations { get; set; }
        public IList<WatcherStats> Watchers { get; set; } = new List<WatcherStats>();
    }
}