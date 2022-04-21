﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace PlaylistService.API.Controllers
{
  [Route("api/p/[controller]")]
  [ApiController]
  public class TrackController : ControllerBase
  {

    [HttpPost]
    public ActionResult TestIndboundConnection()
    {
      Console.WriteLine("--> Indbound POST # Track Service");

      return Ok("Indbound test of from Platforms Controller");
    }
  }
}
