namespace AutoClick
{
    partial class AutoClick
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lv_commands = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            lbl_action = new Label();
            cb_act = new ComboBox();
            lbl_time = new Label();
            tb_time = new MaskedTextBox();
            lbl_location = new Label();
            lbl_x = new Label();
            tb_x = new TextBox();
            lbl_y = new Label();
            tb_y = new TextBox();
            bt_new = new Button();
            bt_edit = new Button();
            bt_delete = new Button();
            bt_start = new Button();
            SuspendLayout();
            // 
            // lv_commands
            // 
            lv_commands.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            lv_commands.Location = new Point(201, 12);
            lv_commands.Name = "lv_commands";
            lv_commands.Size = new Size(297, 234);
            lv_commands.TabIndex = 0;
            lv_commands.UseCompatibleStateImageBehavior = false;
            lv_commands.View = View.Details;
            lv_commands.SelectedIndexChanged += lv_commands_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Action";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Time";
            columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "X Coordinate";
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Y Coordinate";
            // 
            // lbl_action
            // 
            lbl_action.AutoSize = true;
            lbl_action.Location = new Point(12, 12);
            lbl_action.Name = "lbl_action";
            lbl_action.Size = new Size(42, 15);
            lbl_action.TabIndex = 1;
            lbl_action.Text = "Action";
            // 
            // cb_act
            // 
            cb_act.FormattingEnabled = true;
            cb_act.Items.AddRange(new object[] { "Left mouse button", "Right mouse button" });
            cb_act.Location = new Point(12, 30);
            cb_act.Name = "cb_act";
            cb_act.Size = new Size(90, 23);
            cb_act.TabIndex = 2;
            cb_act.Text = "Left mouse button";
            cb_act.SelectedIndexChanged += cb_act_SelectedIndexChanged;
            // 
            // lbl_time
            // 
            lbl_time.AutoSize = true;
            lbl_time.Location = new Point(108, 12);
            lbl_time.Name = "lbl_time";
            lbl_time.Size = new Size(73, 15);
            lbl_time.TabIndex = 3;
            lbl_time.Text = "Time (ss:ms)";
            // 
            // tb_time
            // 
            tb_time.Location = new Point(108, 30);
            tb_time.Mask = "00:00";
            tb_time.Name = "tb_time";
            tb_time.Size = new Size(87, 23);
            tb_time.TabIndex = 4;
            tb_time.Text = "0000";
            // 
            // lbl_location
            // 
            lbl_location.AutoSize = true;
            lbl_location.Location = new Point(12, 56);
            lbl_location.Name = "lbl_location";
            lbl_location.Size = new Size(53, 15);
            lbl_location.TabIndex = 5;
            lbl_location.Text = "Location";
            // 
            // lbl_x
            // 
            lbl_x.AutoSize = true;
            lbl_x.Location = new Point(12, 77);
            lbl_x.Name = "lbl_x";
            lbl_x.Size = new Size(17, 15);
            lbl_x.TabIndex = 6;
            lbl_x.Text = "X:";
            // 
            // tb_x
            // 
            tb_x.Location = new Point(35, 74);
            tb_x.Name = "tb_x";
            tb_x.Size = new Size(67, 23);
            tb_x.TabIndex = 7;
            tb_x.Text = "0";
            // 
            // lbl_y
            // 
            lbl_y.AutoSize = true;
            lbl_y.Location = new Point(108, 77);
            lbl_y.Name = "lbl_y";
            lbl_y.Size = new Size(17, 15);
            lbl_y.TabIndex = 9;
            lbl_y.Text = "Y:";
            // 
            // tb_y
            // 
            tb_y.Location = new Point(131, 74);
            tb_y.Name = "tb_y";
            tb_y.Size = new Size(64, 23);
            tb_y.TabIndex = 10;
            tb_y.Text = "0";
            // 
            // bt_new
            // 
            bt_new.Location = new Point(66, 115);
            bt_new.Name = "bt_new";
            bt_new.Size = new Size(75, 23);
            bt_new.TabIndex = 11;
            bt_new.Text = "New";
            bt_new.UseVisualStyleBackColor = true;
            bt_new.Click += bt_new_Click;
            // 
            // bt_edit
            // 
            bt_edit.Location = new Point(66, 145);
            bt_edit.Name = "bt_edit";
            bt_edit.Size = new Size(75, 23);
            bt_edit.TabIndex = 12;
            bt_edit.Text = "Edit";
            bt_edit.UseVisualStyleBackColor = true;
            bt_edit.Click += bt_edit_Click;
            // 
            // bt_delete
            // 
            bt_delete.Location = new Point(66, 174);
            bt_delete.Name = "bt_delete";
            bt_delete.Size = new Size(75, 23);
            bt_delete.TabIndex = 13;
            bt_delete.Text = "Delete";
            bt_delete.UseVisualStyleBackColor = true;
            bt_delete.Click += bt_delete_Click;
            // 
            // bt_start
            // 
            bt_start.Location = new Point(66, 203);
            bt_start.Name = "bt_start";
            bt_start.Size = new Size(75, 23);
            bt_start.TabIndex = 14;
            bt_start.Text = "Start";
            bt_start.UseVisualStyleBackColor = true;
            bt_start.Click += bt_start_Click;
            // 
            // AutoClick
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(510, 258);
            Controls.Add(bt_start);
            Controls.Add(bt_delete);
            Controls.Add(bt_edit);
            Controls.Add(bt_new);
            Controls.Add(tb_y);
            Controls.Add(lbl_y);
            Controls.Add(tb_x);
            Controls.Add(lbl_x);
            Controls.Add(lbl_location);
            Controls.Add(tb_time);
            Controls.Add(lbl_time);
            Controls.Add(cb_act);
            Controls.Add(lbl_action);
            Controls.Add(lv_commands);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AutoClick";
            Text = "AutoClick";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lv_commands;
        private Label lbl_action;
        private ComboBox cb_act;
        private Label lbl_time;
        private MaskedTextBox tb_time;
        private Label lbl_location;
        private Label lbl_x;
        private TextBox tb_x;
        private Label lbl_y;
        private TextBox tb_y;
        private Button bt_new;
        private Button bt_edit;
        private Button bt_delete;
        private Button bt_start;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
    }
}
