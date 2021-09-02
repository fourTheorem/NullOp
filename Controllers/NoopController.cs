using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace NullOp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NoopController: ControllerBase
    {
        private readonly ILogger<NoopController> _logger;

        public NoopController(ILogger<NoopController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public IActionResult Reflect([FromBody] System.Text.Json.JsonElement payload)
        {
            return Ok(payload);
        }
    }
}