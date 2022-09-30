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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "食事"}, "rice", System.Drawing.Color.White, System.Drawing.SystemColors.Window, new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128))));
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "消灯"}, "futon", System.Drawing.Color.White, System.Drawing.Color.Empty, new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128))));
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "あそび"}, "ahiru", System.Drawing.Color.White, System.Drawing.Color.Empty, new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128))));
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "体調管理"}, "hari", System.Drawing.Color.White, System.Drawing.Color.Empty, new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128))));
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            "トレーニング"}, -1, System.Drawing.Color.White, System.Drawing.Color.Empty, new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128))));
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem(new string[] {
            "試合"}, -1, System.Drawing.Color.White, System.Drawing.Color.Empty, new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128))));
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem(new string[] {
            "ステータス"}, "taijukei", System.Drawing.Color.White, System.Drawing.Color.Empty, new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128))));
            this.timerMouseDown = new System.Windows.Forms.Timer(this.components);
            this.imageListTanukiItem = new System.Windows.Forms.ImageList(this.components);
            this.listViewTanukiItem = new System.Windows.Forms.ListView();
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
            // 
            // listViewTanukiItem
            // 
            this.listViewTanukiItem.AutoArrange = false;
            this.listViewTanukiItem.BackColor = System.Drawing.SystemColors.Control;
            this.listViewTanukiItem.BackgroundImage = global::Tanuki_Chi.Properties.Resources.pattern_shibafu;
            this.listViewTanukiItem.BackgroundImageTiled = true;
            this.listViewTanukiItem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewTanukiItem.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listViewTanukiItem.HideSelection = false;
            this.listViewTanukiItem.HoverSelection = true;
            listViewItem1.StateImageIndex = 0;
            listViewItem2.StateImageIndex = 0;
            this.listViewTanukiItem.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6,
            listViewItem7});
            this.listViewTanukiItem.LabelWrap = false;
            this.listViewTanukiItem.LargeImageList = this.imageListTanukiItem;
            this.listViewTanukiItem.Location = new System.Drawing.Point(0, 340);
            this.listViewTanukiItem.MultiSelect = false;
            this.listViewTanukiItem.Name = "listViewTanukiItem";
            this.listViewTanukiItem.Scrollable = false;
            this.listViewTanukiItem.Size = new System.Drawing.Size(500, 160);
            this.listViewTanukiItem.SmallImageList = this.imageListTanukiItem;
            this.listViewTanukiItem.TabIndex = 1;
            this.listViewTanukiItem.TileSize = new System.Drawing.Size(80, 80);
            this.listViewTanukiItem.UseCompatibleStateImageBehavior = false;
            this.listViewTanukiItem.Visible = false;
            this.listViewTanukiItem.DoubleClick += new System.EventHandler(this.listViewTanukiItem_DoubleClick);
            this.listViewTanukiItem.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewTanukiItem_MouseDoubleClick);
            this.listViewTanukiItem.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listViewTanukiItem_MouseDown);
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
            this.Controls.Add(this.listViewTanukiItem);
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
        private System.Windows.Forms.ListView listViewTanukiItem;
        private System.Windows.Forms.ImageList imageListTanukiItem;
    }
}