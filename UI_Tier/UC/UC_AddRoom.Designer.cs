namespace UI_Tier
{
    partial class UC_AddRoom
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label1 = new Label();
            RoomGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            label2 = new Label();
            txtRoomNo = new Guna.UI2.WinForms.Guna2TextBox();
            label7 = new Label();
            txtRoomType = new Guna.UI2.WinForms.Guna2ComboBox();
            label9 = new Label();
            txtBed = new Guna.UI2.WinForms.Guna2ComboBox();
            label10 = new Label();
            txtPrice = new Guna.UI2.WinForms.Guna2TextBox();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            btnAddRoom = new Guna.UI2.WinForms.Guna2Button();
            btnDisble = new Guna.UI2.WinForms.Guna2Button();
            btnEnable = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)RoomGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 27.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(40, 35);
            label1.Name = "label1";
            label1.Size = new Size(170, 45);
            label1.TabIndex = 0;
            label1.Text = "Add Room";
            // 
            // RoomGridView
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            RoomGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            RoomGridView.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Microsoft New Tai Lue", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            RoomGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            RoomGridView.ColumnHeadersHeight = 4;
            RoomGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Microsoft New Tai Lue", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            RoomGridView.DefaultCellStyle = dataGridViewCellStyle3;
            RoomGridView.GridColor = Color.FromArgb(231, 229, 255);
            RoomGridView.Location = new Point(40, 100);
            RoomGridView.Margin = new Padding(3, 4, 3, 4);
            RoomGridView.Name = "RoomGridView";
            RoomGridView.RowHeadersVisible = false;
            RoomGridView.Size = new Size(967, 608);
            RoomGridView.TabIndex = 1;
            RoomGridView.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            RoomGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            RoomGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            RoomGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            RoomGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            RoomGridView.ThemeStyle.BackColor = Color.White;
            RoomGridView.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            RoomGridView.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            RoomGridView.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            RoomGridView.ThemeStyle.HeaderStyle.Font = new Font("Microsoft New Tai Lue", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RoomGridView.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            RoomGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            RoomGridView.ThemeStyle.HeaderStyle.Height = 4;
            RoomGridView.ThemeStyle.ReadOnly = false;
            RoomGridView.ThemeStyle.RowsStyle.BackColor = Color.White;
            RoomGridView.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            RoomGridView.ThemeStyle.RowsStyle.Font = new Font("Microsoft New Tai Lue", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RoomGridView.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            RoomGridView.ThemeStyle.RowsStyle.Height = 25;
            RoomGridView.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            RoomGridView.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            RoomGridView.CellContentClick += RoomGridView_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft New Tai Lue", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(1078, 132);
            label2.Name = "label2";
            label2.Size = new Size(190, 35);
            label2.TabIndex = 2;
            label2.Text = "Room Number";
            // 
            // txtRoomNo
            // 
            txtRoomNo.BackColor = Color.White;
            txtRoomNo.BorderColor = Color.MediumPurple;
            txtRoomNo.BorderRadius = 15;
            txtRoomNo.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            txtRoomNo.CustomizableEdges = customizableEdges1;
            txtRoomNo.DefaultText = "";
            txtRoomNo.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtRoomNo.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtRoomNo.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtRoomNo.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtRoomNo.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtRoomNo.Font = new Font("Segoe UI", 14F);
            txtRoomNo.ForeColor = Color.Black;
            txtRoomNo.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtRoomNo.Location = new Point(1078, 171);
            txtRoomNo.Margin = new Padding(5, 4, 5, 4);
            txtRoomNo.Name = "txtRoomNo";
            txtRoomNo.PasswordChar = '\0';
            txtRoomNo.PlaceholderText = "";
            txtRoomNo.SelectedText = "";
            txtRoomNo.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtRoomNo.Size = new Size(375, 56);
            txtRoomNo.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft New Tai Lue", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(1078, 260);
            label7.Name = "label7";
            label7.Size = new Size(150, 35);
            label7.TabIndex = 8;
            label7.Text = "Room Type";
            // 
            // txtRoomType
            // 
            txtRoomType.BackColor = Color.Transparent;
            txtRoomType.BorderColor = Color.MediumPurple;
            txtRoomType.BorderRadius = 15;
            txtRoomType.CustomizableEdges = customizableEdges3;
            txtRoomType.DrawMode = DrawMode.OwnerDrawFixed;
            txtRoomType.DropDownStyle = ComboBoxStyle.DropDownList;
            txtRoomType.FocusedColor = Color.FromArgb(94, 148, 255);
            txtRoomType.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtRoomType.Font = new Font("Segoe UI", 14F);
            txtRoomType.ForeColor = Color.Black;
            txtRoomType.ItemHeight = 50;
            txtRoomType.Items.AddRange(new object[] { "AC", "Non-AC" });
            txtRoomType.Location = new Point(1078, 298);
            txtRoomType.Name = "txtRoomType";
            txtRoomType.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtRoomType.Size = new Size(375, 56);
            txtRoomType.TabIndex = 9;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft New Tai Lue", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(1078, 392);
            label9.Name = "label9";
            label9.Size = new Size(60, 35);
            label9.TabIndex = 13;
            label9.Text = "Bed";
            // 
            // txtBed
            // 
            txtBed.BackColor = Color.Transparent;
            txtBed.BorderColor = Color.MediumPurple;
            txtBed.BorderRadius = 15;
            txtBed.CustomizableEdges = customizableEdges5;
            txtBed.DrawMode = DrawMode.OwnerDrawFixed;
            txtBed.DropDownStyle = ComboBoxStyle.DropDownList;
            txtBed.FocusedColor = Color.FromArgb(94, 148, 255);
            txtBed.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtBed.Font = new Font("Segoe UI", 14F);
            txtBed.ForeColor = Color.Black;
            txtBed.ItemHeight = 50;
            txtBed.Items.AddRange(new object[] { "Single", "Double", "Triple" });
            txtBed.Location = new Point(1078, 430);
            txtBed.Name = "txtBed";
            txtBed.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtBed.Size = new Size(375, 56);
            txtBed.TabIndex = 14;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft New Tai Lue", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(1078, 524);
            label10.Name = "label10";
            label10.Size = new Size(72, 35);
            label10.TabIndex = 15;
            label10.Text = "Price";
            // 
            // txtPrice
            // 
            txtPrice.BorderColor = Color.MediumPurple;
            txtPrice.BorderRadius = 15;
            txtPrice.CustomizableEdges = customizableEdges7;
            txtPrice.DefaultText = "";
            txtPrice.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtPrice.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtPrice.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtPrice.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtPrice.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPrice.Font = new Font("Segoe UI", 14F);
            txtPrice.ForeColor = Color.Black;
            txtPrice.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPrice.Location = new Point(1078, 563);
            txtPrice.Margin = new Padding(5, 4, 5, 4);
            txtPrice.Name = "txtPrice";
            txtPrice.PasswordChar = '\0';
            txtPrice.PlaceholderText = "";
            txtPrice.SelectedText = "";
            txtPrice.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtPrice.Size = new Size(375, 56);
            txtPrice.TabIndex = 16;
            txtPrice.TextChanged += guna2TextBox2_TextChanged;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 30;
            guna2Elipse1.TargetControl = this;
            // 
            // btnAddRoom
            // 
            btnAddRoom.BackColor = Color.White;
            btnAddRoom.BorderRadius = 15;
            btnAddRoom.Cursor = Cursors.Hand;
            btnAddRoom.CustomizableEdges = customizableEdges13;
            btnAddRoom.DisabledState.BorderColor = Color.DarkGray;
            btnAddRoom.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAddRoom.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAddRoom.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAddRoom.FillColor = Color.SlateBlue;
            btnAddRoom.Font = new Font("Franklin Gothic Medium", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddRoom.ForeColor = Color.White;
            btnAddRoom.HoverState.FillColor = Color.DarkSlateBlue;
            btnAddRoom.HoverState.ForeColor = Color.White;
            btnAddRoom.Location = new Point(1078, 653);
            btnAddRoom.Name = "btnAddRoom";
            btnAddRoom.ShadowDecoration.CustomizableEdges = customizableEdges14;
            btnAddRoom.Size = new Size(104, 55);
            btnAddRoom.TabIndex = 17;
            btnAddRoom.Text = "Add";
            btnAddRoom.Click += btnAddRoom_Click;
            // 
            // btnDisble
            // 
            btnDisble.BackColor = Color.White;
            btnDisble.BorderRadius = 15;
            btnDisble.Cursor = Cursors.Hand;
            btnDisble.CustomizableEdges = customizableEdges11;
            btnDisble.DisabledState.BorderColor = Color.DarkGray;
            btnDisble.DisabledState.CustomBorderColor = Color.DarkGray;
            btnDisble.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnDisble.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnDisble.FillColor = Color.SlateBlue;
            btnDisble.Font = new Font("Franklin Gothic Medium", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDisble.ForeColor = Color.White;
            btnDisble.HoverState.FillColor = Color.DarkSlateBlue;
            btnDisble.HoverState.ForeColor = Color.White;
            btnDisble.Location = new Point(1323, 653);
            btnDisble.Name = "btnDisble";
            btnDisble.ShadowDecoration.CustomizableEdges = customizableEdges12;
            btnDisble.Size = new Size(130, 55);
            btnDisble.TabIndex = 18;
            btnDisble.Text = "Disable";
            btnDisble.Click += btnDisable_Click;
            // 
            // btnEnable
            // 
            btnEnable.BackColor = Color.White;
            btnEnable.BorderRadius = 15;
            btnEnable.Cursor = Cursors.Hand;
            btnEnable.CustomizableEdges = customizableEdges9;
            btnEnable.DisabledState.BorderColor = Color.DarkGray;
            btnEnable.DisabledState.CustomBorderColor = Color.DarkGray;
            btnEnable.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnEnable.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnEnable.FillColor = Color.SlateBlue;
            btnEnable.Font = new Font("Franklin Gothic Medium", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEnable.ForeColor = Color.White;
            btnEnable.HoverState.FillColor = Color.DarkSlateBlue;
            btnEnable.HoverState.ForeColor = Color.White;
            btnEnable.Location = new Point(1196, 653);
            btnEnable.Name = "btnEnable";
            btnEnable.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnEnable.Size = new Size(112, 55);
            btnEnable.TabIndex = 19;
            btnEnable.Text = "Enable";
            btnEnable.Click += btnEnable_Click;
            // 
            // UC_AddRoom
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(btnEnable);
            Controls.Add(btnDisble);
            Controls.Add(btnAddRoom);
            Controls.Add(txtPrice);
            Controls.Add(label10);
            Controls.Add(txtBed);
            Controls.Add(label9);
            Controls.Add(txtRoomType);
            Controls.Add(label7);
            Controls.Add(txtRoomNo);
            Controls.Add(label2);
            Controls.Add(RoomGridView);
            Controls.Add(label1);
            Font = new Font("Microsoft New Tai Lue", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UC_AddRoom";
            Size = new Size(1491, 787);
            Load += UC_AddRoom_Load;
            Leave += UC_AddRoom_Leave;
            ((System.ComponentModel.ISupportInitialize)RoomGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView RoomGridView;
        private Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtRoomNo;
        private Label label7;
        private Guna.UI2.WinForms.Guna2ComboBox txtRoomType;
        private Label label9;
        private Guna.UI2.WinForms.Guna2ComboBox txtBed;
        private Label label10;
        private Guna.UI2.WinForms.Guna2TextBox txtPrice;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button btnAddRoom;
        private Guna.UI2.WinForms.Guna2Button btnDisble;
        private Guna.UI2.WinForms.Guna2Button btnEnable;
    }
}
