﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RetailManager.Controllers
{
    [Authorize]
    public class ProductController : ApiController
    {
        public List<string> Get()
        {
            return new string[] { "value1", "value2", userId };
        }
    }
}
