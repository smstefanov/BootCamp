using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservationSystem
{
    public class DeluxRoom : Room
    {
        private static int roomRate = 100;
        public DeluxRoom(string occupancy, string roomStatus, int id)
            : base(true, occupancy, roomRate, roomStatus, 1, false, id)
        { 
            if(occupancy.Equals("double"))
            {
                RoomRate = roomRate * 2;
            }
        }
    }
}
