﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JS.Base.WS.API.DTO.Common
{
    public class RoleDto
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string ShortName { get; set; }
        public string Parent { get; set; }
    }
}