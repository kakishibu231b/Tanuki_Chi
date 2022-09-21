using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tanuki_Chi
{
    public partial class TanukiItem : Form
    {
        public TanukiItem()
        {
            InitializeComponent();
        }

        private void listViewTanukiItem_DragEnter(object sender, DragEventArgs e)
        {

        }

        /// <summary>
        /// ドラッグ＆ドロップ開始
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listViewTanukiItem_ItemDrag(object sender, ItemDragEventArgs e)
        {
            if (e.Item == null)
            {
                return;
            }

            // ドラッグ＆ドロップ先はたぬきとする。
            ListViewItem listViewItem = e.Item as ListViewItem;
            TanukiController tanukiController = Owner as TanukiController;
            foreach (TanukiView tanukiView in tanukiController.tanukiViews)
            {
                tanukiView.DoDragDrop(listViewItem, DragDropEffects.Copy);
            }
        }
    }
}
