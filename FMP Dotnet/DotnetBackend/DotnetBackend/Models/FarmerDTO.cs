﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DotnetBackend.Models;

public partial class FarmerDTO
{
    public int FarmerId { get; set; }

    public string? Address { get; set; }

    public string? Email { get; set; }

    public string? Firstname { get; set; }

    public string? Lastname { get; set; }

    public string? PhoneNo { get; set; }


}