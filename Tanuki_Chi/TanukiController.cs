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
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tanuki_Load(object sender, EventArgs e)
        {
            TanukiView tanukiView = new TanukiView(new HayakawaTazuna());
            tanukiView.Show(this);
        }
    }
}
