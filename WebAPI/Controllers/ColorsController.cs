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
    public class ColorsController : ControllerBase
    {
        IColorServices _colorServices;

        public ColorsController(IColorServices colorServices)
        {
            _colorServices = colorServices;
        }
        [HttpGet("add")]
        public IActionResult Add(Color color) {
            var result = _colorServices.Added(color);
            if (result.Success)
            {
                return Ok(result);
            }
            else { return BadRequest(result); }
        }
        [HttpDelete("delete")]
        public IActionResult Delete(Color color)
        {
            var result = _colorServices.Delete(color);
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }
        [HttpPut("update")]
        public IActionResult Update(Color color)
        {
            var result = _colorServices.Update(color);
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _colorServices.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int colorId)
        {
            var result = _colorServices.GetById(colorId);
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }


    }
}
