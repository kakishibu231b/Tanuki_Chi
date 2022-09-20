using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tanuki_Chi
{
    public partial class TanukiView : Form
    {
        public TanukiModel model;

        /// <summary>
        /// 
        /// </summary>
        private TanukiView()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
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
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TanukiView_Load(object sender, EventArgs e)
        {
            // 初期表示画像取得
            Image image = model.InitImage;

            // 境界取得
            tanukiRectangle = TanukiCommon.getImageBorder(image);

            // 初期位置取得
            Location = getInitLocation(tanukiRectangle);

            // 背景設定
            TanukiView_SetBackgroundImage(image);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="image"></param>
        public void TanukiView_SetBackgroundImage(Image image)
        {
            if (BackgroundImage == image)
            {
                return;
            }

            // サイズは初期表示画像を基に決定する。
            Height = image.Height;
            Width = image.Width;

            // 初期表示画像を貼り付ける。
            BackgroundImage = image;

            model.CurrentImage = image;

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
        /// 
        /// </summary>
        /// <param name="o"></param>
        /// <param name="e"></param>
        private void TanukiView_ImageFrameChanged(object o, EventArgs e)
        {
            Invalidate();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TanukiView_Paint(object sender, PaintEventArgs e)
        {
            ImageAnimator.UpdateFrames(BackgroundImage);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TanukiView_MouseDown(object sender, MouseEventArgs e)
        {
            Image image = model.Command("MouseDown");
            TanukiView_SetBackgroundImage(image);
        }
    }
}
