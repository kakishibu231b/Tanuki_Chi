namespace Tanuki_Chi
{
    partial class TanukiViewNoBgImg
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
            this.SuspendLayout();
            // 
            // timerMouseDown
            // 
            this.timerMouseDown.Interval = 5000;
            this.timerMouseDown.Tick += new System.EventHandler(this.timerMouseDown_Tick);
            // 
            // TanukiViewNoBgImg
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TanukiViewNoBgImg";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "TanukiViewNoBgImage";
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TanukiView_FormClosed);
            this.Load += new System.EventHandler(this.TanukiView_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.TanukiView_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.TanukiView_DragEnter);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.TanukiView_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TanukiView_MouseDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timerMouseDown;
    }
}