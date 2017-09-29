using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using NLog;

namespace HotelReservationSystem
{
    public class HotelSystem
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        public static void MakeAReservation(List<Room> rooms)
        {
            logger.Info("Somebody makes a reservation");
            int roomType;
            string nameOccupant;
            Console.WriteLine("Please enter your name:");
            nameOccupant = Console.ReadLine();
            Console.WriteLine("Which type of room would you like to reserve");
            Console.WriteLine("1. Delux Room.");
            Console.WriteLine("2. Super Delux Room.");
            Console.WriteLine("3. Luxury Room.");
            Console.WriteLine("Please enter a number from the menu for your choice.");
            roomType = Convert.ToInt32(Console.ReadLine());
            string occupancy;
            int daysForBookingARoom;
            string userChoiceForOccupiedRoom;
            switch (roomType)
            {
                case 1:
                    if (rooms.Any(r => r.RoomStatus.Equals("vacant") && r.RoomType == 1))
                    {
                        Console.WriteLine("Please write a \"single\" or a \"double\" occupancy would you like.");
                        occupancy = Console.ReadLine();
                        Console.WriteLine("Please enter for how many days would you book the room.");
                        daysForBookingARoom = Convert.ToInt32(Console.ReadLine());
                        if (rooms.Any(r => r.RoomStatus.Equals("vacant") && r.RoomType == 1 && r.Occupancy.Equals(occupancy)))
                        {
                            var tempRoom = rooms.First(r => r.RoomStatus.Equals("vacant") && r.RoomType == 1 && r.Occupancy.Equals(occupancy));
                            Console.WriteLine("Your room cost: " + daysForBookingARoom * tempRoom.RoomRate);
                            tempRoom.RoomStatus = "occupied";
                            tempRoom.IsRoomReserved = true;
                            tempRoom.RoomOccupant = nameOccupant;
                            using (StreamWriter sw = File.AppendText(@"D:\WriteLines.txt"))
                            {
                                sw.WriteLine(nameOccupant);
                            }
                            logger.Info(nameOccupant + " reserves room: " + tempRoom.ID + " " + tempRoom.ToString());
                            Console.WriteLine(tempRoom.ToString());
                        }
                        else
                        {
                            Console.WriteLine("All Delux rooms are occupied. Would you like to choose from another room type? - Write \"Yes\" or \"No\"");
                            userChoiceForOccupiedRoom = Console.ReadLine();
                            if (userChoiceForOccupiedRoom.Equals("Yes"))
                            {
                                MakeAReservation(rooms);
                            }
                            else
                            {
                                Console.WriteLine("Have a nice day!");
                                break;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("All Delux rooms are occupied. Would you like to choose from another room type? - Write \"Yes\" or \"No\"");
                        userChoiceForOccupiedRoom = Console.ReadLine();
                        if (userChoiceForOccupiedRoom.Equals("Yes"))
                        {
                            MakeAReservation(rooms);
                        }
                        else
                        {
                            Console.WriteLine("Have a nice day!");
                            break;
                        }
                    }
                    break;
                case 2:
                    if (rooms.Any(r => r.RoomStatus.Equals("vacant") && r.RoomType == 2))
                    {
                        Console.WriteLine("Please enter for how many days would you book the room.");
                        daysForBookingARoom = Convert.ToInt32(Console.ReadLine());
                        var tempRoom = rooms.First(r => r.RoomStatus.Equals("vacant") && r.RoomType == 2);
                        Console.WriteLine("Your room cost: " + daysForBookingARoom * tempRoom.RoomRate);
                        tempRoom.RoomStatus = "occupied";
                        tempRoom.IsRoomReserved = true;
                        tempRoom.RoomOccupant = nameOccupant;
                        using (StreamWriter sw = File.AppendText(@"D:\WriteLines.txt"))
                        {
                             sw.WriteLine(nameOccupant);
                        }
                        logger.Info(nameOccupant + " reserves room: " + tempRoom.ID + " " + tempRoom.ToString());
                        Console.WriteLine(tempRoom.ToString());
                    }
                    else
                    {
                        Console.WriteLine("All Super Delux rooms are occupied. Would you like to choose from another room type? - Write \"Yes\" or \"No\"");
                        userChoiceForOccupiedRoom = Console.ReadLine();
                        if (userChoiceForOccupiedRoom.Equals("Yes"))
                        {
                            MakeAReservation(rooms);
                        }
                        else
                        {
                            Console.WriteLine("Have a nice day!");
                            break;
                        }
                    }
                    break;
                case 3:
                    if (rooms.Any(r => r.RoomStatus.Equals("vacant") && r.RoomType == 3))
                    {
                        Console.WriteLine("Please write a \"single\" or a \"double\" occupancy would you like.");
                        occupancy = Console.ReadLine();
                        Console.WriteLine("Please enter for how many days would you book the room.");
                        daysForBookingARoom = Convert.ToInt32(Console.ReadLine());
                        if (rooms.Any(r => r.RoomStatus.Equals("vacant") && r.RoomType == 3 && r.Occupancy.Equals(occupancy)))
                        {
                            var tempRoom = rooms.First(r => r.RoomStatus.Equals("vacant") && r.RoomType == 3 && r.Occupancy.Equals(occupancy));
                            Console.WriteLine("Your room cost: " + daysForBookingARoom * tempRoom.RoomRate);
                            tempRoom.RoomStatus = "occupied";
                            tempRoom.IsRoomReserved = true;
                            tempRoom.RoomOccupant = nameOccupant;
                            using (StreamWriter sw = File.AppendText(@"D:\WriteLines.txt"))
                            {
                                sw.WriteLine(nameOccupant);
                            }
                            logger.Info(nameOccupant + " reserves room: " + tempRoom.ID + " " + tempRoom.ToString());
                            Console.WriteLine(tempRoom.ToString());
                        }
                        else
                        {
                            Console.WriteLine("All Luxury rooms are occupied. Would you like to choose from another room type? - Write \"Yes\" or \"No\"");
                            userChoiceForOccupiedRoom = Console.ReadLine();
                            if (userChoiceForOccupiedRoom.Equals("Yes"))
                            {
                                MakeAReservation(rooms);
                            }
                            else
                            {
                                Console.WriteLine("Have a nice day!");
                                break;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("All Luxury rooms are occupied. Would you like to choose from another room type? - Write \"Yes\" or \"No\"");
                        userChoiceForOccupiedRoom = Console.ReadLine();
                        if (userChoiceForOccupiedRoom.Equals("Yes"))
                        {
                            MakeAReservation(rooms);
                        }
                        else
                        {
                            Console.WriteLine("Have a nice day!");
                            break;
                        }
                    }
                    break;
            }
        }
        public static void CancelAReservation(List<Room> rooms)
        {
            string nameOccupant;
            bool isNameFound = false;
            Console.WriteLine("Please enter your name:");
            nameOccupant = Console.ReadLine();
            string tempFile = Path.GetTempFileName();
            using (StreamReader sr = File.OpenText(@"D:\WriteLines.txt"))
            {
                using (var sw = new StreamWriter(tempFile))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        if (nameOccupant.Equals(s))
                        {
                            Console.WriteLine("Your reservation is cancelled!");
                            isNameFound = true;
                            break;
                        }
                        else
                        {
                            sw.WriteLine(s);
                        }
                    }
                    if(!isNameFound)
                    {
                        Console.WriteLine("There is no reservation with this name!");
                    }                
                }
            }
            File.Delete(@"D:\WriteLines.txt");
            File.Move(tempFile, @"D:\WriteLines.txt");
        }
        public static void Main(string[] args)
        {
            List<Room> rooms = new List<Room>();
            rooms.Add(new DeluxRoom("single", "vacant", 1));
            rooms.Add(new DeluxRoom("double", "occupied",2));
            rooms.Add(new DeluxRoom("double", "vacant",3));
            rooms.Add(new LuxuryRoom("single", "occupied",4));
            rooms.Add(new LuxuryRoom("single", "vacant",5));
            rooms.Add(new LuxuryRoom("double", "vacant",6));
            rooms.Add(new SuperDeluxRoom("vacant",7));
            rooms.Add(new SuperDeluxRoom("vacant",8));
            rooms.Add(new SuperDeluxRoom("occupied",9));
            rooms.Add(new SuperDeluxRoom("occupied",10));
            
            int usersChoice;

            Console.WriteLine("Welcome to Hotel Reservation System!");
            Console.WriteLine("What would you like to do?\n");
            Console.WriteLine("1. Make a reservation.");
            Console.WriteLine("2. Cancel a reservation.");
            Console.WriteLine("3. Exit.");
            Console.WriteLine("Please enter a number from the menu for your choice.");
            usersChoice = Convert.ToInt32(Console.ReadLine());
                       
            switch (usersChoice)
            {
                case 1:
                    MakeAReservation(rooms);
                    break;
                case 2:
                     CancelAReservation(rooms);
                    break;
                case 3:
                    break;
            }
        }
    }
}
