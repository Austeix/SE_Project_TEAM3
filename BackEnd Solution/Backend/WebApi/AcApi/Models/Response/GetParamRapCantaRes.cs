﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AcApi.Models.Response
{
    public class GetParamRapCantaRes:BaseRes
    {
        public string AgjensiaDestinacion { get; set; }

        public string NrSig { get; set; }

    }
}