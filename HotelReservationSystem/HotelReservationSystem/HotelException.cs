using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservationSystem
{
    public class HotelException : Exception
    {
        /// <summary>
        /// Exception types
        /// </summary>
        public enum ExceptionType
        {
            INVALID_DATE,
            INVALID_CUSTOMER_TYPE,
            INVALID_HOTEL_TYPE
        }

        ExceptionType type;


        /// <summary>
        /// Constructor of custom exception inheriting from Exception class
        /// </summary>
        /// <param name="type">Exception Type</param>
        /// <param name="message">Message to be printed in case of Exception</param>
        public HotelException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}