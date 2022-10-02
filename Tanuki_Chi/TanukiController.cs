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
            Application.Idle += new EventHandler(Tanuki_Idle);

            //tanukiViews.Add(new TanukiViewBgImg(new HayakawaTazuna(), this));
            //tanukiViews.Add(new TanukiViewBgImg(new OjuChosan(), this));

            //tanukiViews.Add(new TanukiViewBgImg(new ElCondorPasa(), this));
            //tanukiViews.Add(new TanukiViewBgImg(new GrassWonder(), this));
            //tanukiViews.Add(new TanukiViewBgImg(new KingHalo(), this));
            //tanukiViews.Add(new TanukiViewBgImg(new SeiunSky(), this));
            //tanukiViews.Add(new TanukiViewBgImg(new SpecialWeek(), this));
            //tanukiViews.Add(new TanukiViewBgImg(new TsurumaruTsuyoshi(), this));

            //tanukiViews.Add(new TanukiViewBgImg(new InesFujin(), this));
            //tanukiViews.Add(new TanukiViewBgImg(new MihonoBourbon(), this));
            //tanukiViews.Add(new TanukiViewBgImg(new SilenceSuzuka(), this));
            //tanukiViews.Add(new TanukiViewBgImg(new SmartFalcon(), this));
            //tanukiViews.Add(new TanukiViewBgImg(new Maruzensky(), this));

            tanukiViews.Add(new TanukiViewBgImg(new SymboliRudolf(), this));
            //tanukiViews.Add(new TanukiViewBgImg(new SiriusSymboli(), this));
            //tanukiViews.Add(new TanukiViewBgImg(new GoldShip(), this));
            //tanukiViews.Add(new TanukiViewBgImg(new Hatsuratsu(), this));
            //tanukiViews.Add(new TanukiViewBgImg(new TokaiTeio(), this));
            //tanukiViews.Add(new TanukiViewBgImg(new TwinTurbo(), this));

            //tanukiViews.Add(new TanukiViewBgImg(new DaiwaScarlet(), this));
            foreach (var view in tanukiViews)
            {
                //view.TanukiView_SetGuest(new HaruUrara());
                view.Show(this);
            }

            //TanukiItem tanukiItem = new TanukiItem();
            //tanukiItem.Location = new Point(1024,768);
            //tanukiItem.Show(this);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tanuki_Idle(object sender, EventArgs e)
        {
            bool bolVisible = false;
            foreach (var view in tanukiViews)
            {
                if (view.Visible)
                {
                    bolVisible = true;
                }
            }
            if (!bolVisible)
            {
                Close();
            }
        }
    }
}
