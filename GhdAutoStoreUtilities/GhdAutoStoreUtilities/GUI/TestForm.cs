using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GhdAutoStoreUtilities.GUI
{
    public partial class TestForm : Form
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static extern IntPtr SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private const int WM_CHANGEUISTATE = 0x127;
        private const int UIS_SET = 1;
        private const int UISF_HIDEFOCUS = 0x1;

        public TestForm()
        {
            InitializeComponent();
            SendMessage(this.Handle, WM_CHANGEUISTATE, MakeLong(UIS_SET, UISF_HIDEFOCUS), 0);
            listView1.Items.Add(new ListViewItem(
                new[] { "10001", "GRID1", "PORT" }));
            listView1.Items.Add(new ListViewItem(
                new[] { "10002", "GRID1", "PREPARED" }));
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

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected) e.Item.Selected = false;
        }
    }
}
