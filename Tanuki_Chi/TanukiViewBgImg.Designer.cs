namespace Tanuki_Chi
{
    partial class TanukiViewBgImg
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TanukiViewBgImg));
            this.timerMouseDown = new System.Windows.Forms.Timer(this.components);
            this.imageListTanukiItem = new System.Windows.Forms.ImageList(this.components);
            this.listViewCommand = new System.Windows.Forms.ListView();
            this.pictureBoxTanuki = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTanuki)).BeginInit();
            this.SuspendLayout();
            // 
            // timerMouseDown
            // 
            this.timerMouseDown.Interval = 5000;
            this.timerMouseDown.Tick += new System.EventHandler(this.timerMouseDown_Tick);
            // 
            // imageListTanukiItem
            // 
            this.imageListTanukiItem.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListTanukiItem.ImageStream")));
            this.imageListTanukiItem.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListTanukiItem.Images.SetKeyName(0, "ahiru");
            this.imageListTanukiItem.Images.SetKeyName(1, "futon");
            this.imageListTanukiItem.Images.SetKeyName(2, "hachimi");
            this.imageListTanukiItem.Images.SetKeyName(3, "hari");
            this.imageListTanukiItem.Images.SetKeyName(4, "meat");
            this.imageListTanukiItem.Images.SetKeyName(5, "rice");
            this.imageListTanukiItem.Images.SetKeyName(6, "soft_serve");
            this.imageListTanukiItem.Images.SetKeyName(7, "taijukei");
            this.imageListTanukiItem.Images.SetKeyName(8, "ramen");
            // 
            // listViewCommand
            // 
            this.listViewCommand.AutoArrange = false;
            this.listViewCommand.BackColor = System.Drawing.SystemColors.Control;
            this.listViewCommand.BackgroundImage = global::Tanuki_Chi.Properties.Resources.pattern_shibafu;
            this.listViewCommand.BackgroundImageTiled = true;
            this.listViewCommand.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewCommand.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listViewCommand.HideSelection = false;
            this.listViewCommand.HoverSelection = true;
            this.listViewCommand.LabelWrap = false;
            this.listViewCommand.LargeImageList = this.imageListTanukiItem;
            this.listViewCommand.Location = new System.Drawing.Point(0, 360);
            this.listViewCommand.MultiSelect = false;
            this.listViewCommand.Name = "listViewCommand";
            this.listViewCommand.Scrollable = false;
            this.listViewCommand.Size = new System.Drawing.Size(500, 140);
            this.listViewCommand.SmallImageList = this.imageListTanukiItem;
            this.listViewCommand.TabIndex = 1;
            this.listViewCommand.TileSize = new System.Drawing.Size(80, 80);
            this.listViewCommand.UseCompatibleStateImageBehavior = false;
            this.listViewCommand.Visible = false;
            this.listViewCommand.DoubleClick += new System.EventHandler(this.listViewTanukiItem_DoubleClick);
            this.listViewCommand.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewTanukiItem_MouseDoubleClick);
            this.listViewCommand.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listViewTanukiItem_MouseDown);
            // 
            // pictureBoxTanuki
            // 
            this.pictureBoxTanuki.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxTanuki.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxTanuki.Name = "pictureBoxTanuki";
            this.pictureBoxTanuki.Size = new System.Drawing.Size(500, 500);
            this.pictureBoxTanuki.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxTanuki.TabIndex = 0;
            this.pictureBoxTanuki.TabStop = false;
            this.pictureBoxTanuki.Click += new System.EventHandler(this.pictureBoxTanuki_Click);
            this.pictureBoxTanuki.DoubleClick += new System.EventHandler(this.pictureBoxTanuki_DoubleClick);
            this.pictureBoxTanuki.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxTanuki_MouseDown);
            this.pictureBoxTanuki.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxTanuki_MouseMove);
            // 
            // TanukiViewBgImg
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.listViewCommand);
            this.Controls.Add(this.pictureBoxTanuki);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TanukiViewBgImg";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TanukiView";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TanukiView_FormClosed);
            this.Load += new System.EventHandler(this.TanukiView_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.TanukiView_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.TanukiView_DragEnter);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.TanukiView_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTanuki)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timerMouseDown;
        public System.Windows.Forms.PictureBox pictureBoxTanuki;
        private System.Windows.Forms.ListView listViewCommand;
        private System.Windows.Forms.ImageList imageListTanukiItem;
    }
}