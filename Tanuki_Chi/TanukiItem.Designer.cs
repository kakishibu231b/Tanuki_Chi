namespace Tanuki_Chi
{
    partial class TanukiItem
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("", 0);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TanukiItem));
            this.listViewTanukiItem = new System.Windows.Forms.ListView();
            this.imageListTanukiItem = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // listViewTanukiItem
            // 
            this.listViewTanukiItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewTanukiItem.HideSelection = false;
            this.listViewTanukiItem.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listViewTanukiItem.LargeImageList = this.imageListTanukiItem;
            this.listViewTanukiItem.Location = new System.Drawing.Point(0, 0);
            this.listViewTanukiItem.Name = "listViewTanukiItem";
            this.listViewTanukiItem.Size = new System.Drawing.Size(400, 110);
            this.listViewTanukiItem.SmallImageList = this.imageListTanukiItem;
            this.listViewTanukiItem.TabIndex = 0;
            this.listViewTanukiItem.UseCompatibleStateImageBehavior = false;
            this.listViewTanukiItem.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.listViewTanukiItem_ItemDrag);
            this.listViewTanukiItem.DragEnter += new System.Windows.Forms.DragEventHandler(this.listViewTanukiItem_DragEnter);
            // 
            // imageListTanukiItem
            // 
            this.imageListTanukiItem.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListTanukiItem.ImageStream")));
            this.imageListTanukiItem.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListTanukiItem.Images.SetKeyName(0, "Rice.png");
            // 
            // TanukiItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 110);
            this.Controls.Add(this.listViewTanukiItem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TanukiItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "TanukiItem";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageListTanukiItem;
        public System.Windows.Forms.ListView listViewTanukiItem;
    }
}