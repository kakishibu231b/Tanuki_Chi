using System;
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
        bool guestVisible = false;

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
            //Rectangle rectangle = TanukiCommon.getImageBorder(Properties.Resources.room_yuka_flooring);
            int intMargin = 10;
            rectangle = new Rectangle(rectangle.X + intMargin, rectangle.Y + intMargin, rectangle.Width - (intMargin * 2), rectangle.Height - (intMargin * 2));
            Bounds = rectangle;

            Bitmap bitmap = new Bitmap(Width, Height);
            Graphics g = Graphics.FromImage(bitmap);
            g.DrawImageUnscaled(Properties.Resources.room_yuka_tatami, 0 - rectangle.Left, 0 - rectangle.Top, rectangle.Width, rectangle.Height);
            //g.DrawImageUnscaled(Properties.Resources.room_yuka_flooring, 0 - rectangle.Left, 0 - rectangle.Top, rectangle.Width, rectangle.Height);
            pictureBoxTanuki.BackgroundImage = bitmap;

            listViewCommand.Width = bitmap.Width;


            ListView_SetItems();

            // アイテム表示間隔設定
            ListView_SetIconSpacing(listViewCommand, imageListTanukiItem.ImageSize.Width+5, imageListTanukiItem.ImageSize.Height);
        }

        /// <summary>
        /// 
        /// </summary>
        private void ListView_SetItems(string mode = "")
        {
            listViewCommand.Items.Clear();

            if(mode == "" || mode == "もどる")
            {
                listViewCommand.Items.Add("食事", "rice");
                listViewCommand.Items.Add("消灯", "futon");
                listViewCommand.Items.Add("あそび", "ahiru");
                listViewCommand.Items.Add("ステータス", "taijukei");
            }

            if (mode == "食事")
            {
                listViewCommand.Items.Add("ごはん", "rice");
                listViewCommand.Items.Add("おにく", "meat");
                listViewCommand.Items.Add("もどる");
            }

            foreach (ListViewItem item in listViewCommand.Items)
            {
                item.Font = new Font("MS UI Gothic", 16, FontStyle.Bold);
                item.ForeColor = Color.White;
            }

        }

        /// <summary>
        /// ゲスト追加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public override void TanukiView_SetGuest(TanukiModel tanukiModel)
        {
            if (imageGuest != null)
            {
                ImageAnimator.StopAnimate(imageGuest, eventHandlerImageGuest);
                imageGuest.Dispose();
                eventHandlerImageGuest = null;
            }

            if (tanukiModel == null)
            {
                guestVisible = false;
                modelGuest = null;
                modelHost.GuestName = "";
            }
            else
            {
                guestVisible = true;
                modelGuest = tanukiModel;
                modelHost.GuestName = modelGuest.FullName;
                imageGuest = modelGuest.InitImage();
                eventHandlerImageGuest = new EventHandler(TanukiView_ImageFrameChangedGuest);
            }
        }

        /// <summary>
        /// たぬき表示開始
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TanukiView_Load(object sender, EventArgs e)
        {
            // 初期表示画像取得
            Image image = modelHost.InitImage();

            // 境界取得
            tanukiRectangle = TanukiCommon.getImageBorder(image);

            // たぬき設定
            TanukiView_SetpictureBoxTanukiImage(image);
        }

        EventHandler eventHandlerImageHost;
        EventHandler eventHandlerImageGuest;

        /// <summary>
        /// たぬきイメージ設定
        /// </summary>
        /// <param name="image"></param>
        public void TanukiView_SetpictureBoxTanukiImage(Image image)
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
                ImageAnimator.StopAnimate(imageHost, eventHandlerImageHost);
                imageHost.Dispose();
                eventHandlerImageHost = null;
            }
            imageHost = image;

            // アニメーション設定
            eventHandlerImageHost = new EventHandler(TanukiView_ImageFrameChangedHost);
            ImageAnimator.Animate(imageHost, eventHandlerImageHost);
            if(imageGuest != null)
            {
                ImageAnimator.Animate(imageGuest, eventHandlerImageGuest);
            }
        }

        /// <summary>
        /// フレーム更新
        /// </summary>
        /// <param name="o"></param>
        /// <param name="e"></param>
        private void TanukiView_ImageFrameChangedHost(object o, EventArgs e)
        {
            int intWidth = imageHost.Width;
            int intHeight = imageHost.Height + imageHost.Height / 5;

            if (imageGuest != null && guestVisible)
            {
                intWidth += imageGuest.Width / 2;
            }

            Bitmap bitmap = new Bitmap(intWidth, intHeight);
            Graphics graphics = Graphics.FromImage(bitmap);
            if (imageGuest != null && guestVisible)
            {
                graphics.DrawImage(imageHost, 0, imageHost.Height / 5, imageHost.Width, imageHost.Height);
                graphics.DrawImage(imageGuest, imageHost.Width / 2, imageGuest.Height / 5, imageGuest.Width, imageGuest.Height);
            }
            else
            {
                graphics.DrawImage(imageHost, 0, imageHost.Height / 5, imageHost.Width, imageHost.Height);
            }

            if (pictureBoxTanuki.Image != null)
            {
                pictureBoxTanuki.Image.Dispose();
            }
            pictureBoxTanuki.Image = bitmap;

            graphics.Dispose();
            base.TanukiView_ImageFrameChanged(o, e);
        }

        /// <summary>
        /// フレーム更新
        /// </summary>
        /// <param name="o"></param>
        /// <param name="e"></param>
        private void TanukiView_ImageFrameChangedGuest(object o, EventArgs e)
        {
            base.TanukiView_ImageFrameChanged(o, e);
        }

        /// <summary>
        /// 再描画
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TanukiView_Paint(object sender, PaintEventArgs e)
        {
            base.TanukiView_Paint(sender, e, imageHost);
            if (imageGuest != null)
            {
                base.TanukiView_Paint(sender, e, imageGuest);
            }
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

            if (imageGuest != null)
            {
                guestVisible = true;
            }

            pictureBoxTanuki.Image.Dispose();
            Image image = modelHost.Command("");
            TanukiView_SetpictureBoxTanukiImage(image);
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
                listViewCommand.Visible = !listViewCommand.Visible;
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
                listViewCommand.Visible = !listViewCommand.Visible;
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

            ListView listView = sender as ListView;
            ListViewItem srcItem = listView.SelectedItems[0];

            string name = srcItem.Text;
            if (name == "食事")
            {
                ListView_SetItems(name);
            }
            else
            {
                timerMouseDown.Start();

                string imageKey = srcItem.ImageKey;

                if (imageKey == "Futon")
                {
                    guestVisible = false;
                }

                Image image = modelHost.Command(imageKey);
                TanukiView_SetpictureBoxTanukiImage(image);
                ListView_SetItems();
                listViewCommand.Visible = !listViewCommand.Visible;
            }
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
