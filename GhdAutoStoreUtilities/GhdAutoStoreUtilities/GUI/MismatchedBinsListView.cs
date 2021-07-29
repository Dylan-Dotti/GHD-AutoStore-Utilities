using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace GhdAutoStoreUtilities.GUI
{
    public partial class MismatchedBinsListView : UserControl
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static extern IntPtr SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private const int WM_CHANGEUISTATE = 0x127;
        private const int UIS_SET = 1;
        private const int UISF_HIDEFOCUS = 0x1;

        public MismatchedBinsListView()
        {
            InitializeComponent();
            SendMessage(Handle, WM_CHANGEUISTATE, MakeLong(UIS_SET, UISF_HIDEFOCUS), 0);
            listView1.Items.Add(new ListViewItem(
                new[] { "10001", "GRID1", "PORT" }));
            listView1.Items.Add(new ListViewItem(
                new[] { "10002", "GRID1", "PREPARED" }));
            UpdateColumnSizes();
        }

        public void AddRow(MismatchedBinLocation bin)
        {
            ListViewItem item = new ListViewItem(
                new[] { bin.BinID, bin.SynqLocation, bin.ASLocation });
            listView1.Items.Add(item);
        }

        public void Clear()
        {
            listView1.Items.Clear();
        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected) e.Item.Selected = false;
        }

        private void MismatchedBinsListView_SizeChanged(object sender, EventArgs e)
        {
            UpdateColumnSizes();
        }

        private void UpdateColumnSizes()
        {
            foreach (ColumnHeader column in listView1.Columns)
            {
                column.Width = Convert.ToInt32(
                    Math.Round((float)listView1.Width / listView1.Columns.Count));
            }
        }

        private int MakeLong(int wLow, int wHigh)
        {
            int low = (int)IntLoWord(wLow);
            short high = IntLoWord(wHigh);
            int product = 0x10000 * (int)high;
            int mkLong = (int)(low | product);
            return mkLong;
        }

        private short IntLoWord(int word)
        {
            return (short)(word & short.MaxValue);
        }
    }
}
