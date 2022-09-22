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
            rectangle = new Rectangle(rectangle.X + 10, rectangle.Y + 10, rectangle.Width - 20, rectangle.Height - 20);
            Bounds = rectangle;

            Bitmap bitmap = new Bitmap(Width, Height);
            Graphics g = Graphics.FromImage(bitmap);
            g.DrawImageUnscaled(Properties.Resources.room_yuka_tatami, 0 - rectangle.Left, 0 - rectangle.Top, rectangle.Width, rectangle.Height);
            pictureBoxTanuki.BackgroundImage = bitmap;
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
            TanukiView_SetpictureBoxTanukiImage(image);
        }

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

            // 初期表示画像を貼り付ける。
            pictureBoxTanuki.Image = image;

            // アニメーション設定
            ImageAnimator.Animate(image, new EventHandler(base.TanukiView_ImageFrameChanged));
        }

        /// <summary>
        /// 再描画
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TanukiView_Paint(object sender, PaintEventArgs e)
        {
            base.TanukiView_Paint(sender, e, pictureBoxTanuki.Image);
        }

        /// <summary>
        /// マウスクリック
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxTanuki_Click(object sender, EventArgs e)
        {
            if (timerMouseDown.Enabled)
            {
                timerMouseDown.Stop();
                timerMouseDown.Start();
                return;
            }

            pictureBoxTanuki.Image.Dispose();
            Image image = model.Command("MouseDown");
            TanukiView_SetpictureBoxTanukiImage(image);

            timerMouseDown.Start();
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
    }
}
