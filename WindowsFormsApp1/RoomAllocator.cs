using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class RoomAllocator
    {
        public class Room
        {
            public List<int[]> Intervals { set; get; }
        }

        public int MinMeetingRooms(int[][] intervals)
        {
            List<Room> neededRooms = new List<Room>();

            intervals = intervals.OrderBy(x => x[0]).ToArray();

            foreach (int[] intervalToFit in intervals)
            {
                bool allocated = false;
                foreach (Room room in neededRooms)
                {
                    bool fitsInRoom = true;
                    foreach (int[] roomInterval in room.Intervals)
                    {
                        if (roomInterval[0] < intervalToFit[0] && roomInterval[1] > intervalToFit[0])
                        {
                            fitsInRoom = false;
                            break;
                        }

                        if (roomInterval[0] < intervalToFit[1] && roomInterval[1] > intervalToFit[1])
                        {
                            fitsInRoom = false;
                            break;
                        }

                        if (roomInterval[0] >= intervalToFit[0] && roomInterval[1] <= intervalToFit[1])
                        {
                            fitsInRoom = false;
                            break;
                        }
                    }

                    if (fitsInRoom)
                    {
                        allocated = true;
                        room.Intervals.Add(intervalToFit);
                        break;
                    }
                }

                if (!allocated)
                {
                    Room newRoom = new Room();
                    newRoom.Intervals = new List<int[]>();
                    newRoom.Intervals.Add(intervalToFit);
                    neededRooms.Add(newRoom);
                }
            }

            return neededRooms.Count;
        }
    }
}
