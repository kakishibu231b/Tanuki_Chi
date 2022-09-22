using System.Drawing;

namespace Tanuki_Chi
{
    public class OjuChosan : TanukiModel
    {
        /// <summary>
        /// 
        /// </summary>
        public OjuChosan() : base("オジュウチョウサン", "")
        {

        }

        /// <summary>
        /// 
        /// </summary>
        public override Image InitImage()
        {
            return Properties.Resources.OjuChosan_Dance_Smiling;
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
                if (CurrentImageName != "OjuChosan_Front_WaistSwing")
                {
                    CurrentImageName = "OjuChosan_Front_WaistSwing";
                    image = Properties.Resources.OjuChosan_Front_WaistSwing;
                }
            }

            if(image == null)
            {
                CurrentImageName = "";
                image = InitImage();
            }

            return image;
        }
    }
}
