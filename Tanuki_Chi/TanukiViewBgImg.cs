﻿using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Tanuki_Chi
{
    public partial class TanukiViewBgImg : TanukiView
    {
        Image imageHost;
        Image imageGuest;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        private TanukiViewBgImg() : base()
        {
            InitializeComponent();
        }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public TanukiViewBgImg(TanukiModel model, Form owner) : base(model, owner)
        {
            InitializeComponent();

            // 境界取得
            Rectangle rectangle = TanukiCommon.getImageBorder(Properties.Resources.room_yuka_tatami);
            int intMargin = 10;
            rectangle = new Rectangle(rectangle.X + intMargin, rectangle.Y + intMargin, rectangle.Width - (intMargin * 2), rectangle.Height - (intMargin * 2));
            Bounds = rectangle;

            Bitmap bitmap = new Bitmap(Width, Height);
            Graphics g = Graphics.FromImage(bitmap);
            g.DrawImageUnscaled(Properties.Resources.room_yuka_tatami, 0 - rectangle.Left, 0 - rectangle.Top, rectangle.Width, rectangle.Height);
            pictureBoxTanuki.BackgroundImage = bitmap;

            // アイテム表示間隔設定
            ListView_SetIconSpacing(listViewTanukiItem, imageListTanukiItem.ImageSize.Width, imageListTanukiItem.ImageSize.Height);
            
        }

        /// <summary>
        /// たぬき表示開始
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TanukiView_Load(object sender, EventArgs e)
        {
            // 初期表示画像取得
            Image image = model.InitImage();

            // 境界取得
            tanukiRectangle = TanukiCommon.getImageBorder(image);

            // 背景設定
            TanukiView_SetpictureBoxTanukiImage(image, Properties.Resources.HaruUrara_Dance_Smiling);
        }

        /// <summary>
        /// たぬきイメージ設定
        /// </summary>
        /// <param name="image"></param>
        public void TanukiView_SetpictureBoxTanukiImage(Image image, Image guest = null)
        {
            if (pictureBoxTanuki != null && pictureBoxTanuki.Equals(image))
            {
                return;
            }

            if (pictureBoxTanuki.Image != null && pictureBoxTanuki.Image.Equals(image))
            {
                return;
            }

            if(imageHost != null)
            {
                imageHost.Dispose();
            }
            imageHost = image;

            if (imageGuest != null)
            {
                imageGuest.Dispose();
            }
            imageGuest = guest;

            // 初期表示画像を貼り付ける。
            //pictureBoxTanuki.Image = image;

            // アニメーション設定
            ImageAnimator.Animate(imageHost, new EventHandler(base.TanukiView_ImageFrameChanged));
            ImageAnimator.Animate(imageGuest, new EventHandler(base.TanukiView_ImageFrameChanged));
        }

        //int frameCountHost = 0;
        //int frameCountGuest = 0;

        /// <summary>
        /// 再描画
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TanukiView_Paint(object sender, PaintEventArgs e)
        {
            int intWidth = imageHost.Width;
            int intHeight = imageHost.Height + imageHost.Height/5;

            if (imageGuest != null)
            {
                intWidth += imageGuest.Width;
                intHeight += imageGuest.Height;
            }

            Bitmap bitmap = new Bitmap(intWidth, intHeight);
            Graphics graphics = Graphics.FromImage(bitmap);

            //FrameDimension frameDimensionHost = new FrameDimension(imageHost.FrameDimensionsList[0]);
            //FrameDimension frameDimensionGuest = new FrameDimension(imageGuest.FrameDimensionsList[0]);

            //imageHost.SelectActiveFrame(frameDimensionHost, frameCountHost++);
            //imageGuest.SelectActiveFrame(frameDimensionGuest, frameCountGuest++);

            //if(frameCountHost >= imageHost.GetFrameCount(frameDimensionHost))
            //{
            //    frameCountHost = 0;
            //}
            //if (frameCountGuest >= imageHost.GetFrameCount(frameDimensionGuest))
            //{
            //    frameCountGuest = 0;
            //}

            if (imageGuest == null)
            {
                graphics.DrawImage(imageHost, 0, imageHost.Height / 5, imageHost.Width, imageHost.Height);
            }
            else
            {
                graphics.DrawImage(imageHost, 0, imageHost.Height / 5, imageHost.Width, imageHost.Height);
                graphics.DrawImage(imageGuest, imageHost.Width / 2, imageGuest.Height / 5, imageGuest.Width, imageGuest.Height);
            }

            if (pictureBoxTanuki.Image != null)
            {
                pictureBoxTanuki.Image.Dispose();
            }
            pictureBoxTanuki.Image = bitmap;

            base.TanukiView_Paint(sender, e, imageHost);
            base.TanukiView_Paint(sender, e, imageGuest);

            graphics.Dispose();
        }

        /// <summary>
        /// マウスクリック
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxTanuki_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 時間切れ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerMouseDown_Tick(object sender, EventArgs e)
        {
            timerMouseDown.Stop();

            pictureBoxTanuki.Image.Dispose();
            Image image = model.Command("");
            TanukiView_SetpictureBoxTanukiImage(image, Properties.Resources.HaruUrara_Dance_Smiling);
        }

        /// <summary>
        /// ドラッグ＆ドロップ開始
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TanukiView_DragEnter(object sender, DragEventArgs e)
        {

        }

        /// <summary>
        /// ドラッグ＆ドロップ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TanukiView_DragDrop(object sender, DragEventArgs e)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TanukiView_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        /// <summary>
        /// マウス押下時マウス位置
        /// </summary>
        Point pointMoseDown;

        /// <summary>
        /// マウス押下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxTanuki_MouseDown(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                pointMoseDown = e.Location;
            }
            if ((e.Button & MouseButtons.Right) == MouseButtons.Right)
            {
                listViewTanukiItem.Visible = !listViewTanukiItem.Visible;
            }
        }

        /// <summary>
        /// マウス押下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listViewTanukiItem_MouseDown(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Right) == MouseButtons.Right)
            {
                listViewTanukiItem.Visible = !listViewTanukiItem.Visible;
            }
        }

        /// <summary>
        /// マウス移動
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxTanuki_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                Left += e.X - pointMoseDown.X;
                Top += e.Y - pointMoseDown.Y;
            }
        }

        /// <summary>
        /// アイテムダブルクリック
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listViewTanukiItem_DoubleClick(object sender, EventArgs e)
        {
        }

        private void listViewTanukiItem_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (timerMouseDown.Enabled)
            {
                timerMouseDown.Stop();
                timerMouseDown.Start();
                return;
            }

            timerMouseDown.Start();

            ListView listView = sender as ListView;
            ListViewItem srcItem = listView.SelectedItems[0];
            string imageKey = srcItem.ImageKey;
            Image image = model.Command(imageKey);
            TanukiView_SetpictureBoxTanukiImage(image);
            listViewTanukiItem.Visible = !listViewTanukiItem.Visible;
        }

        /// <summary>
        /// アイテム表示間隔設定
        /// </summary>
        /// <param name="listview"></param>
        /// <param name="cx"></param>
        /// <param name="cy"></param>
        public void ListView_SetIconSpacing(ListView listview, int cx, int cy)
        {
            const int LVM_FIRST = 0x1000;
            const int LVM_SETICONSPACING = LVM_FIRST + 53;
            int lParam = cy << 16 | cx;

            IntPtr result = SendMessage(
                new HandleRef(listview, listview.Handle),
                LVM_SETICONSPACING,
                IntPtr.Zero,
                (IntPtr)lParam);

            // 設定前の値
            int previousX = (int)result & 0x0000FFFF;
            int previousY = (int)result >> 16;
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr SendMessage(HandleRef hWnd, int msg, IntPtr wParam, IntPtr lParam);

        private void pictureBoxTanuki_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}
