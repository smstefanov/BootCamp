using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservationSystem
{
    public class LuxuryRoom : Room
    {
        private static int roomRate = 200;
        public LuxuryRoom(string occupancy, string roomStatus, int id)
            : base(false, occupancy, roomRate, roomStatus, 3, false, id)
        { 
            if(occupancy.Equals("double"))
            {
                RoomRate = roomRate * 2;
            }
        }
    }
}
