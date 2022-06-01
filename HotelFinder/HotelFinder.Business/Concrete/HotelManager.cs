using HotelFinder.Business.Abstract;
using HotelFinder.DataAccess.Abstract;
using HotelFinder.DataAccess.Concrete;
using HotelFinder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelFinder.Business.Concrete
{
   public class HotelManager : IHotelServices
    {
        private IHotelRepository _hotelRepository;
        //burada ctora sürekli nesne örneği oluşturmaktansa injection ypatık..//
        public HotelManager()
        {
            _hotelRepository = new HotelRepository();
        }
        public Hotel CreateHotel(Hotel hotel)
        {
            return _hotelRepository.CreateHotel(hotel);
        }

        public void DeleteHote(int id)
        {
           _hotelRepository.DeleteHotel(id);
        }

        public List<Hotel> GetAllHotels()
        {
            return _hotelRepository.GetAllHotels();
        }

        public Hotel GetHotelById(int id)
        {
           // id 0 dan buyuk olması demek kayıt var demek id idenity auto increment //
            if (id > 0)
                return _hotelRepository.GetHotelByid(id);
            else
                throw new Exception("alinamadi");
        }

        public Hotel UpdateHotel(Hotel hotel)
        {
            return _hotelRepository.UpdateHotel(hotel); 
        }
    }
}
