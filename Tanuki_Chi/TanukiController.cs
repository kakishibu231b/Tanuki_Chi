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

            //tanukiViews.Add(new TanukiView(new HayakawaTazuna(), this));
            //tanukiViews.Add(new TanukiView(new OjuChosan(), this));

            //tanukiViews.Add(new TanukiView(new ElCondorPasa(), this));
            //tanukiViews.Add(new TanukiView(new GrassWonder(), this));
            //tanukiViews.Add(new TanukiView(new KingHalo(), this));
            //tanukiViews.Add(new TanukiView(new SeiunSky(), this));
            tanukiViews.Add(new TanukiView(new SpecialWeek(), this));
            //tanukiViews.Add(new TanukiView(new TsurumaruTsuyoshi(), this));

            //tanukiViews.Add(new TanukiView(new InesFujin(), this));
            //tanukiViews.Add(new TanukiView(new MihonoBourbon(), this));
            //tanukiViews.Add(new TanukiView(new SilenceSuzuka(), this));
            //tanukiViews.Add(new TanukiView(new SmartFalcon(), this));
            //tanukiViews.Add(new TanukiView(new Maruzensky(), this));

            //tanukiViews.Add(new TanukiView(new SymboliRudolf(), this));
            //tanukiViews.Add(new TanukiView(new SiriusSymboli(), this));
            //tanukiViews.Add(new TanukiView(new GoldShip(), this));
            //tanukiViews.Add(new TanukiView(new Hatsuratsu(), this));
            //tanukiViews.Add(new TanukiView(new TokaiTeio(), this));
            //tanukiViews.Add(new TanukiView(new TwinTurbo(), this));
            foreach (var view in tanukiViews)
            {
                view.Show(this);
            }

            TanukiItem tanukiItem = new TanukiItem();
            tanukiItem.Location = new Point(1024,768);
            tanukiItem.Show(this);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tanuki_Idle(object sender, EventArgs e)
        {

        }
    }
}
