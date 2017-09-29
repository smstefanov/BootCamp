using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservationSystem
{
    public abstract class Room
    {
        private bool hasWifiFacility;
        private string occupancy;
        private int roomRate;
        private string roomStatus;
        private int roomType;
        private bool isRoomReserved;
        private string roomOccupant;
        private int id;
        public Room(bool hasWifiFacility, string occupancy, int roomRate, string roomStatus, int roomType, bool isRoomReserved, int id)
        {
            HasWifiFacility = hasWifiFacility;
            Occupancy = occupancy;
            RoomRate = roomRate;
            RoomStatus = roomStatus;
            RoomType = roomType;
            IsRoomReserved = isRoomReserved;
            ID=id;
        }

        public Room() : this(true, "single", 200, "vacant", 0 , false, 0) { }

        public Room(Room r) : this(r.hasWifiFacility, r.Occupancy, r.RoomRate, r.RoomStatus, r.RoomType, r.IsRoomReserved, r.ID) { }

        public bool HasWifiFacility
        {
            get
            {
                return hasWifiFacility;
            }
            set
            {
                hasWifiFacility = value;
            }
        }

        public string Occupancy
        {
            get
            {
                return occupancy;
            }
            set
            {
                if(value != null)
                {
                    occupancy = value;
                }
            }
        }
        public int RoomRate
        {
            get
            {
                return roomRate;
            }
            set
            {
                if(value != 0)
                {
                    roomRate = value;
                }
            }
        }
        public string RoomStatus
        {
            get
            {
                return roomStatus;
            }
            set
            {
                if(value != null)
                {
                    roomStatus = value;
                }
            }
        }
        public int RoomType
        {
            get
            {
                return roomType;
            }
            set
            {
                if(value!=0)
                {
                    roomType = value;
                }
            }
        }
        public bool IsRoomReserved
        {
            get
            {
                return isRoomReserved;
            }
            set
            {
                isRoomReserved = value;
            }
        }
        public string RoomOccupant
        {
            get
            {
                return roomOccupant;
            }
            set
            {
                if(value != null)
                {
                    roomOccupant = value;
                }
            }
        }
        public int ID
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public override string ToString()
        {
            return "Room (Wi-Fi: " + HasWifiFacility + " , Occupancy: " + Occupancy + " , Room rate: " + RoomRate + " , Room status: " + RoomStatus + ")"; 
        }
    }
}
