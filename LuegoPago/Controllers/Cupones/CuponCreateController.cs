using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LuegoPago.Models;
using LuegoPago.Services;
using Microsoft.AspNetCore.Mvc;

namespace LuegoPago.Controllers.Cupones
{
    public class CuponCreateController : ControllerBase
    {
        private readonly ICuponRepository _cuponRepository;
        public CuponCreateController(ICuponRepository cuponRepository)
        {
            _cuponRepository = cuponRepository;
        }
        [HttpPost]
        [Route("api/cupon/create")]
        public IActionResult Create(Cupon cupon)
        {
            _cuponRepository.add(cupon);
            return Ok(cupon);
        }
    }
}