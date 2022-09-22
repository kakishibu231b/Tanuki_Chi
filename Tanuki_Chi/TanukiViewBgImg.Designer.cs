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
            this.timerMouseDown = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxTanuki = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTanuki)).BeginInit();
            this.SuspendLayout();
            // 
            // timerMouseDown
            // 
            this.timerMouseDown.Interval = 5000;
            this.timerMouseDown.Tick += new System.EventHandler(this.timerMouseDown_Tick);
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
            // 
            // TanukiViewBgImg
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.pictureBoxTanuki);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TanukiViewBgImg";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
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
    }
}