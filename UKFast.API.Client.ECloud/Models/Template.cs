﻿using System;
using System.Collections.Generic;
using System.Text;
using UKFast.API.Client.Models;

namespace UKFast.API.Client.ECloud.Models
{
    public class Template : ModelBase
    {
        [Newtonsoft.Json.JsonProperty("name")]
        public string Name { get; set; }

        [Newtonsoft.Json.JsonProperty("cpu")]
        public int CPU { get; set; }

        [Newtonsoft.Json.JsonProperty("ram")]
        public int RAM { get; set; }

        [Newtonsoft.Json.JsonProperty("hdd")]
        public int HDD { get; set; }

        [Newtonsoft.Json.JsonProperty("hdd_disks")]
        public VirtualMachineDisk[] HDDDisks { get; set; }

        [Newtonsoft.Json.JsonProperty("platform")]
        public string Platform { get; set; }
    }
}
