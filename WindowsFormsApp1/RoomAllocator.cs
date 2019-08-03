using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class RoomAllocator
    {

        public int MinMeetingRooms(int[][] intervals)
        {

            int[] startTimes = intervals.Select(x => x[0]).OrderBy(x => x).ToArray();
            int[] endTimes = intervals.Select(x => x[1]).OrderBy(x=> x).ToArray();

            int minimunRooms = 0;
            int endTimeIndex = 0;

            for (int i = 0; i < startTimes.Length; i++)
            {
                minimunRooms++;

                if (startTimes[i] >= endTimes[endTimeIndex])
                {
                    minimunRooms--;
                    endTimeIndex++;
                }
            }

            return minimunRooms;
        }
    }
}
