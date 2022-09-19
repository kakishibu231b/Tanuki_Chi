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
    public partial class TanukiView : Form
    {
        public TanukiModel model;

        /// <summary>
        /// 
        /// </summary>
        public TanukiView()
        {
            InitializeComponent();
        }

        public TanukiView(TanukiModel model)
        {
            InitializeComponent();
            this.model = model;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TanukiView_Load(object sender, EventArgs e)
        {
            Image image = model.InitImage;
            if (BackgroundImage != null)
            {
                BackgroundImage.Dispose();
            }
            BackgroundImage = image;
            ImageAnimator.Animate(BackgroundImage, new EventHandler(Image_FrameChanged));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="o"></param>
        /// <param name="e"></param>
        private void Image_FrameChanged(object o, EventArgs e)
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
    }
}
