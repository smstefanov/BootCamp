using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservationSystem
{
    public class SuperDeluxRoom : Room
    {
        public SuperDeluxRoom(string roomStatus, int id) : base(true, "single", 300, roomStatus, 2, false, id) { }
    }
}
