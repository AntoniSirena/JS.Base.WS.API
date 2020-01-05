﻿using JS.Base.WS.API.Controllers.Generic;
using JS.Base.WS.API.Models.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace JS.Base.WS.API.Controllers
{
    [Authorize]
    [RoutePrefix("api/systemConfiguration")]
    public class SystemConfigurationController : GenericApiController<SystemConfiguration>
    {
    }
}