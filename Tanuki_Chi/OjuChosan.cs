using System.Drawing;

namespace Tanuki_Chi
{
    public class OjuChosan : TanukiModel
    {
        /// <summary>
        /// 
        /// </summary>
        public OjuChosan() : base("オジュウチョウサン")
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
                if (CurrentImage != "OjuChosan_Front_WaistSwing")
                {
                    CurrentImage = "OjuChosan_Front_WaistSwing";
                    image = Properties.Resources.OjuChosan_Front_WaistSwing;
                }
            }

            if(image == null)
            {
                CurrentImage = "";
                image = InitImage();
            }

            return image;
        }
    }
}
