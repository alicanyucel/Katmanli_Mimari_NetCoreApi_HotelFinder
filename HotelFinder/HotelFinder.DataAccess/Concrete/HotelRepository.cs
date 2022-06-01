using HotelFinder.DataAccess.Abstract;
using HotelFinder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelFinder.DataAccess.Concrete
{
    public class HotelRepository : IHotelRepository
    {
        public HotelDbContext hoteldbcontext;

        public HotelRepository()
        {
            hoteldbcontext = new HotelDbContext();
        }

        public Hotel CreateHotel(Hotel hotel)
        {
           
            hoteldbcontext.Hotels.Add(hotel);
            hoteldbcontext.SaveChanges();
            return hotel;
        }

        public void DeleteHotel(int id)
        {
           
                var deletedhotel = GetHotelByid(id);
                hoteldbcontext.Hotels.Remove(deletedhotel);
                hoteldbcontext.SaveChanges();
        }

        public List<Hotel> GetAllHotels()
        {
           
                return hoteldbcontext.Hotels.ToList();
        }

        public Hotel GetHotelByid(int id)
        {
            
                return hoteldbcontext.Hotels.Find(id);
        }

        public Hotel UpdateHotel(Hotel hotel)
        {
            
                hoteldbcontext.Hotels.Update(hotel);
                return hotel;
        }
    }
}

