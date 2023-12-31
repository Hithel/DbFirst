﻿using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class Team : BaseEntity
{
    public string Name { get; set; }

    public virtual ICollection<Driver> Drivers { get; set; } = new List<Driver>();
    public virtual ICollection<TeamDriver> TeamDrivers { get; set; } = new List<TeamDriver>();
}
