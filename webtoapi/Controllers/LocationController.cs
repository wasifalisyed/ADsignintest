﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace webtoapi.Controllers
{
    public class LocationController : ApiController
    {
        //https://localhost:44375/api/location?cityName=abc
        public Models.Location GetLocation(string cityName)
        {
            return new Models.Location() { Latitude = 10, Longitude = 20 };
        }
    }
}
