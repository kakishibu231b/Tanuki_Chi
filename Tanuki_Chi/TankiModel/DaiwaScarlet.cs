using System.Drawing;

namespace Tanuki_Chi
{
    public class DaiwaScarlet : TanukiModel
    {
        /// <summary>
        /// 
        /// </summary>
        public DaiwaScarlet() : base("ダイワスカーレット", "")
        {

        }

        /// <summary>
        /// 
        /// </summary>
        public override Image InitImage()
        {
            return Properties.Resources.DaiwaScarlet_Dance_Smiling;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        public override Image Command(string command)
        {
            Image image = null;

            if (command == "MouseDown")
            {

            }

            if (command == "Meat")
            {
                if (CurrentImageName != "DaiwaScarlet_Dance_EatMeat")
                {
                    CurrentImageName = "DaiwaScarlet_Dance_EatMeat";
                    image = Properties.Resources.DaiwaScarlet_Dance_EatMeat;
                }
            }

            if (image == null)
            {
                CurrentImageName = "";
                image = InitImage();
            }

            return image;
        }
    }
}
