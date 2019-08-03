// Meeting Rooms Solution
// By @alfredomarqueza  2019

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            IEnumerable<ListViewItem.ListViewSubItemCollection> items = (listViewIntervals.Items.Cast<ListViewItem>()).Select(x => x.SubItems);

            int[][] intervals = new int[items.Count()][];

            for (int i = 0; i < items.Count(); i++)
            {
                intervals[i] = new int[2] { Convert.ToInt32(items.ElementAt(i)[0].Text), Convert.ToInt32(items.ElementAt(i)[1].Text) };
            }

            if (intervals.Count() == 0)
            {
                textBox2.Text = "No rooms needed";
            }
            else if (intervals.Count() == 1)
            {
                textBox2.Text = "1 room needed";
            }
            else
            {
                textBox2.Text = string.Format("{0} rooms needed", new RoomAllocator().MinMeetingRooms(intervals).ToString());
            }

        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            if (numericUpDownEnd.Value != 0)
            {
                string[] row = { numericUpDownStart.Value.ToString(), numericUpDownEnd.Value.ToString() };

                ListViewItem item = new ListViewItem(row);
                listViewIntervals.Items.Add(item);
            }
        }

        private void Btn_Remove_Click(object sender, EventArgs e)
        {
            if (listViewIntervals.SelectedItems.Count > 0)
            {
                listViewIntervals.Items.Remove(listViewIntervals.SelectedItems[0]);
            }
        }
    }
}
