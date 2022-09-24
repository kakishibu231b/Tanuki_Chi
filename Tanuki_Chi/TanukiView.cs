using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tanuki_Chi
{
    public class TanukiView : Form
    {
        /// <summary>
        /// 
        /// </summary>
        public TanukiModel modelHost;
        public TanukiModel modelGuest;

        /// <summary>
        /// 
        /// </summary>
        public Rectangle tanukiRectangle;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        internal TanukiView()
        {

        }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="model"></param>
        /// <param name="owner"></param>
        public TanukiView(TanukiModel model, Form owner)
        {
            this.modelHost = model;
            this.Owner = owner;
        }

        /// <summary>
        /// フレーム更新
        /// </summary>
        /// <param name="o"></param>
        /// <param name="e"></param>
        internal void TanukiView_ImageFrameChanged(object o, EventArgs e)
        {
            Invalidate();
        }

        /// <summary>
        /// 再描画
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        internal void TanukiView_Paint(object sender, PaintEventArgs e, Image image)
        {
            ImageAnimator.UpdateFrames(image);
        }

        /// <summary>
        /// ゲスト追加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public virtual void TanukiView_SetGuest(TanukiModel tanukiModel)
        {
            ;   
        }
    }
}
