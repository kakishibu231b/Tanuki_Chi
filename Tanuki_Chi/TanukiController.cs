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
    public partial class TanukiController : Form
    {
        /// <summary>
        /// 
        /// </summary>
        public TanukiController()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        public List<TanukiView> tanukiViews = new List<TanukiView>();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tanuki_Load(object sender, EventArgs e)
        {
            tanukiViews.Add(new TanukiView(new HayakawaTazuna(), this));
            tanukiViews.Add(new TanukiView(new HayakawaTazuna(), this));
            tanukiViews.Add(new TanukiView(new HayakawaTazuna(), this));
            tanukiViews.Add(new TanukiView(new HayakawaTazuna(), this));
            tanukiViews.Add(new TanukiView(new HayakawaTazuna(), this));
            tanukiViews.Add(new TanukiView(new HayakawaTazuna(), this));
            tanukiViews.Add(new TanukiView(new HayakawaTazuna(), this));
            tanukiViews.Add(new TanukiView(new HayakawaTazuna(), this));
            foreach (var view in tanukiViews)
            {
                view.Show(this);
            }
        }
    }
}
