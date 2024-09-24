using KlusterG.AutoGui;
using KlusterG.AutoGui.InternalKeys;
using System.IO;

namespace AutoClick

{
    public partial class AutoClick : Form
    {
        int[] action = new int[4];
        string[] view = new string[4];
        public AutoClick()
        {
            InitializeComponent();
        }

        private void cb_act_SelectedIndexChanged(object sender, EventArgs e)
        {
            action[0] = cb_act.SelectedIndex;
        }

        private void bt_new_Click(object sender, EventArgs e)
        {
            set_view();
            ListViewItem lv_item = new ListViewItem(view);
            lv_commands.Items.Add(lv_item);
        }

        private void set_view()
        {
            view[0] = cb_act.Text;
            view[1] = tb_time.Text;
            view[2] = tb_x.Text;
            view[3] = tb_y.Text;
        }

        private int format_time(string s)
        {
            int time = 0;
            string[] spliter = s.Split(':');
            string to_int = spliter[0] + spliter[1] + 0;
            int.TryParse(to_int, out time);
            return time;
        }

        private void bt_edit_Click(object sender, EventArgs e)
        {
            if (lv_commands.SelectedItems.Count > 0)
            {
                lv_commands.SelectedItems[0].SubItems[0].Text = cb_act.Text;
                lv_commands.SelectedItems[0].SubItems[1].Text = tb_time.Text;
                lv_commands.SelectedItems[0].SubItems[2].Text = tb_x.Text;
                lv_commands.SelectedItems[0].SubItems[3].Text = tb_y.Text;
            }
        }

        private void lv_commands_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_commands.SelectedItems.Count > 0)
            {
                switch (lv_commands.SelectedItems[0].SubItems[0].Text)
                {
                    case "Left mouse button":
                        cb_act.SelectedIndex = 0;
                        break;
                    case "Right mouse button":
                        cb_act.SelectedIndex = 1;
                        break;
                }
                tb_time.Text = lv_commands.SelectedItems[0].SubItems[1].Text;
                tb_x.Text = lv_commands.SelectedItems[0].SubItems[2].Text;
                tb_y.Text = lv_commands.SelectedItems[0].SubItems[3].Text;
            }
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            lv_commands.SelectedItems[0].Remove();
        }

        private void bt_start_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem l in lv_commands.Items)
            {
                int wtime = format_time(l.SubItems[1].Text);
                int x = 0;
                int y = 0;
                int.TryParse(l.SubItems[2].Text, out x);
                int.TryParse(l.SubItems[3].Text, out y);
                Thread.Sleep(wtime);
                Exec.SetCursorPosition(new KlusterG.AutoGui.Mouse { X = x, Y = y});
                switch (l.SubItems[0].Text)
                {
                    case "Left mouse button":
                        Exec.MouseClick(MKeys.Left);
                        break; 
                    case "Right mouse button":
                        Exec.MouseClick(MKeys.Right);
                        break;
                }
            }
        }
    }
}