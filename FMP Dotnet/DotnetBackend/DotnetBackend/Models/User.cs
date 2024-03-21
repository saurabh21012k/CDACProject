﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace DotnetBackend.Models;

public partial class User
{
    public int UserId { get; set; }

    public string? Address { get; set; }

    public string? Email { get; set; }

    public string? Firstname { get; set; }

    public ulong? IsAdmin { get; set; }

    public string? Lastname { get; set; }

    public string? Password { get; set; }

    public string? PhoneNo { get; set; }

    [JsonIgnore]
    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
