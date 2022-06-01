using HotelFinder.Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelFinder.ApCore;
using HotelFinder.Business.Concrete;
using HotelFinder.Entities;

namespace HotelFinder.ApCore.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HotelsController : Controller
    {
        private IHotelServices _hotelservis;
        public HotelsController()
        {
            _hotelservis = new HotelManager();
        }
        [HttpGet]
        public List<Hotel> Get()
        {
            return _hotelservis.GetAllHotels();
        }
        [HttpGet("{id}")]
        public Hotel Get(int id)
        {
            return _hotelservis.GetHotelById(id);
        }
    }
}
