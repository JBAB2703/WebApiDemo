﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPiDemoProject.Controllers
{
    [Route("stuff/[controller]")]
    [ApiController]
    public class EmptyController : ControllerBase
    {
    }
}