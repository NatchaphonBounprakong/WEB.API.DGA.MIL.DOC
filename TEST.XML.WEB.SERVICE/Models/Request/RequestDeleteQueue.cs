﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WEB.API.DGA.MIL.DOC.Models
{
    public class RequestDeleteQueue
    {
        public string MessageID { get; set; }
        public string To { get; set; }
        public string ProcessID { get; set; }
    }
}