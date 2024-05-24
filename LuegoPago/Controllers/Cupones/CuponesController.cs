using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LuegoPago.Models;
using LuegoPago.Services;
using Microsoft.AspNetCore.Mvc;

namespace LuegoPago.Controllers.Cupones
{
    public class CuponesController : ControllerBase
    {
        private readonly ICuponRepository _cuponRepository;
        public CuponesController(ICuponRepository cuponRepository)
        {
            _cuponRepository = cuponRepository;
        }
        [HttpGet]
        [Route("api/cupones")]
        public IEnumerable<Cupon> GetCupones(){
            return _cuponRepository.GetAll();
        }
        [HttpGet]
        [Route("api/cupones/{id}")]
        public Cupon Details(int id){
            return _cuponRepository.GetById(id);
        }
        
    }
}