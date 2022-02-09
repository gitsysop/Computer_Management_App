﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Computer_Management_App.Models
{
    public partial class Computer
    {
        [Key]
        public int Id { get; set; }
        public string ComputerName { get; set; } = null!;
        public string ComputerMac { get; set; } = null!;
        public string ComputerIp { get; set; } = null!;
        public string ComputerModel { get; set; } = null!;
        public string ComputerGroup { get; set; } = null!;
        public string ComputerLocation { get; set; } = null!;
    }
}
