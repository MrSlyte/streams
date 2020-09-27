using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using domain.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace streams.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StreamController : ControllerBase
    {
        private readonly IAzureVideoStreamService _service;
        public StreamController(IAzureVideoStreamService service)
        {
            _service = service;
        }

        [HttpGet("{name}")]
        public async Task<FileStreamResult> Get(string name)
        {
            var stream = await _service.GetVideoByName(name);
            return new FileStreamResult(stream, "video/mp4");
        }
    }
}
