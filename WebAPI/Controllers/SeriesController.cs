using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeriesController : ControllerBase
    {
        private ISerieService _serieService;

        public SeriesController(ISerieService serieService)
        {
            _serieService = serieService;
        }
        

        [HttpGet(template:"getall")]
        public IActionResult GetList()
        {
            var result=_serieService.GetList();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpPost(template:"add")]
        public IActionResult Add(Serie serie)
        {
            var result = _serieService.Add(serie);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }

        [HttpPost(template: "delete")]
        public IActionResult Delete(Serie serie)
        {
            var result = _serieService.Delete(serie);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }

        [HttpPost(template: "update")]
        public IActionResult Update(Serie serie)
        {
            var result = _serieService.Update(serie);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }

    }
}
