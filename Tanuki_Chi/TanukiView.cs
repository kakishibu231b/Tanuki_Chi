using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tanuki_Chi
{
    public partial class TanukiView : Form
    {
        public TanukiModel model;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        private TanukiView()
        {
            InitializeComponent();
        }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public TanukiView(TanukiModel model, Form owner)
        {
            InitializeComponent();
            this.model = model;
            this.Owner = owner;
        }

        /// <summary>
        /// 
        /// </summary>
        public Rectangle tanukiRectangle;
        
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

            // 初期位置取得
            Location = getInitLocation(tanukiRectangle);

            // 背景設定
            TanukiView_SetBackgroundImage(image);
        }

        /// <summary>
        /// 背景画像設定
        /// </summary>
        /// <param name="image"></param>
        public void TanukiView_SetBackgroundImage(Image image)
        {
            if (BackgroundImage != null && BackgroundImage.Equals(image))
            {
                return;
            }

            // サイズは初期表示画像を基に決定する。
            Height = image.Height;
            Width = image.Width;

            // 初期表示画像を貼り付ける。
            BackgroundImage = image;

            // アニメーション設定
            ImageAnimator.Animate(BackgroundImage, new EventHandler(TanukiView_ImageFrameChanged));
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
            foreach (TanukiView view in tanukiController.tanukiViews)
            {
                if (view == this)
                {
                    break;
                }

                if (view.BackgroundImage == null)
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
            ImageAnimator.UpdateFrames(BackgroundImage);
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

            BackgroundImage.Dispose();
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
        /// マウス押下時間切れ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerMouseDown_Tick(object sender, EventArgs e)
        {
            timerMouseDown.Stop();

            BackgroundImage.Dispose();
            Image image = model.Command("");
            setHeightPostion(image);
            TanukiView_SetBackgroundImage(image);
        }
    }
}
