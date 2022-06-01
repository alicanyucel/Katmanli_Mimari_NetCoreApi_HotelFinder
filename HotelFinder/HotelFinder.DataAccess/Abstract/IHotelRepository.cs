using HotelFinder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelFinder.DataAccess.Abstract
{
   public  interface IHotelRepository
    {
        //abstract klasorunde interfaceler vardır
        //concrete klasorunde ise interfaceler implemente edilir
        List<Hotel> GetAllHotels();
        Hotel GetHotelByid (int id);
        Hotel CreateHotel(Hotel hotel);
        Hotel UpdateHotel(Hotel hotel);
        void DeleteHotel(int id);
    }
}
