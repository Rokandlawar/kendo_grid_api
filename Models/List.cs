﻿using System;
using System.Collections.Generic;

namespace kendo_grid_api.Models
{
    public partial class List
    {
        public int Id { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
        public DateTime? ExpireAt { get; set; }
    }
}
