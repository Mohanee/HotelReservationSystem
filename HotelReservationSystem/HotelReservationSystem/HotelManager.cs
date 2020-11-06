﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservationSystem
{
    public class HotelManager
    {
        public List<Hotel> hotelList = new List<Hotel>();

        public void AddHotel(Hotel newHotel)
        {
            hotelList.Add(newHotel);
        }

        public void DisplayHotels()
        {
            Console.WriteLine("Name\tWeekday Rate\tWeekend Rate");
            foreach (var hotel in hotelList)
            {
                Console.WriteLine(hotel.hotelName + "\t" + hotel.weekdayRate+"\t"+hotel.weekendRate);
            }
        }
    }
}
