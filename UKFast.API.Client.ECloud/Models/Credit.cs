﻿using System;
using System.Collections.Generic;
using System.Text;
using UKFast.API.Client.Models;

namespace UKFast.API.Client.ECloud.Models
{
    public class Credit : ModelBase
    {
        [Newtonsoft.Json.JsonProperty("type")]
        public string Type { get; set; }

        [Newtonsoft.Json.JsonProperty("total")]
        public int Total { get; set; }

        [Newtonsoft.Json.JsonProperty("remaining")]
        public int Remaining { get; set; }
    }
}
