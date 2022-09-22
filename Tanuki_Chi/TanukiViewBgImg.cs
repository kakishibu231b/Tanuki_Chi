using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tanuki_Chi
{
    public partial class TanukiViewBgImg : TanukiView
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        private TanukiViewBgImg()
        {
            InitializeComponent();
        }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public TanukiViewBgImg(TanukiModel model, Form owner)
        {
            InitializeComponent();
            this.model = model;
            this.Owner = owner;

            // 境界取得
            Rectangle rectangle = TanukiCommon.getImageBorder(Properties.Resources.room_yuka_tatami);
            rectangle = new Rectangle(rectangle.X + 10, rectangle.Y + 10, rectangle.Width - 20, rectangle.Height - 20);
            Bounds = rectangle;

            Bitmap bitmap = new Bitmap(Width, Height);
            Graphics g = Graphics.FromImage(bitmap);
            g.DrawImageUnscaled(Properties.Resources.room_yuka_tatami, 0 - rectangle.Left, 0 - rectangle.Top, rectangle.Width, rectangle.Height);
            pictureBoxTanuki.BackgroundImage = bitmap;
        }
        
        /// <summary>
        /// 起動
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
            TanukiView_SetBackgroundImage(image);
        }

        /// <summary>
        /// 背景画像設定
        /// </summary>
        /// <param name="image"></param>
        public void TanukiView_SetBackgroundImage(Image image)
        {
            if (pictureBoxTanuki != null && pictureBoxTanuki.Equals(image))
            {
                return;
            }

            // 初期表示画像を貼り付ける。
            pictureBoxTanuki.Image = image;

            // アニメーション設定
            ImageAnimator.Animate(pictureBoxTanuki.Image, new EventHandler(TanukiView_ImageFrameChanged));
        }

        /// <summary>
        /// 初期位置取得
        /// </summary>
        /// <param name="image"></param>
        /// <returns></returns>
        public Point getInitLocation(Rectangle rectangle)
        {
            int screen_width = Screen.PrimaryScreen.WorkingArea.Width;
            int screen_height = Screen.PrimaryScreen.WorkingArea.Height;

            // マージン10pixel
            Point point = new Point(screen_width - rectangle.Right - 10, screen_height - rectangle.Bottom);

            TanukiController tanukiController = Owner as TanukiController;
            foreach (TanukiViewBgImg view in tanukiController.tanukiViews)
            {
                if (view == this)
                {
                    break;
                }

                if (view.pictureBoxTanuki.Image == null)
                {
                    continue;
                }

                Rectangle viewRectangle = view.tanukiRectangle;
                if (viewRectangle == null)
                {
                    continue;
                }
                point.X -= viewRectangle.Width;
            }
            return point;
        }

        /// <summary>
        /// フレーム更新
        /// </summary>
        /// <param name="o"></param>
        /// <param name="e"></param>
        private void TanukiView_ImageFrameChanged(object o, EventArgs e)
        {
            Invalidate();
        }

        /// <summary>
        /// 再描画
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TanukiView_Paint(object sender, PaintEventArgs e)
        {
            ImageAnimator.UpdateFrames(pictureBoxTanuki.Image);
        }

        /// <summary>
        /// マウス押下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TanukiView_MouseDown(object sender, MouseEventArgs e)
        {
            if (timerMouseDown.Enabled)
            {
                timerMouseDown.Stop();
                timerMouseDown.Start();
                return;
            }

            pictureBoxTanuki.Image.Dispose();
            Image image = model.Command("MouseDown");
            setHeightPostion(image);
            TanukiView_SetBackgroundImage(image);

            timerMouseDown.Start();
        }

        /// <summary>
        /// 高さ位置設定
        /// </summary>
        /// <param name="image"></param>
        /// <returns></returns>
        public void setHeightPostion(Image image)
        {
            int screen_height = Screen.PrimaryScreen.WorkingArea.Height;
            int intBottom = TanukiCommon.getBottom(image);
            Point location = Location;
            location.Y = screen_height - intBottom;
            Location = location;
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
            setHeightPostion(image);
            TanukiView_SetBackgroundImage(image);
        }

        /// <summary>
        /// ドラッグ＆ドロップ開始
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TanukiView_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data == null)
            {
                return;
            }

            // ドラッグ＆ドロップ対象がListViewItemの場合に許可する。
            if ((e.Data.GetDataPresent(typeof(ListViewItem))))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        /// <summary>
        /// ドラッグ＆ドロップ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TanukiView_DragDrop(object sender, DragEventArgs e)
        {
            // ドラッグ＆ドロップ対象がListViewItemの場合
            if ((e.Data.GetDataPresent(typeof(ListViewItem))))
            {
                if (timerMouseDown.Enabled)
                {
                    timerMouseDown.Stop();
                    timerMouseDown.Start();
                    return;
                }

                ListViewItem srcItem = (ListViewItem)e.Data.GetData(typeof(ListViewItem));
                // 後日アイテム名に変更する。
                int index = srcItem.ImageIndex;

                pictureBoxTanuki.Image.Dispose();
                Image image = model.Command("Put:" + index.ToString());
                setHeightPostion(image);
                TanukiView_SetBackgroundImage(image);
                timerMouseDown.Start();
            }
        }

        private void TanukiView_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
