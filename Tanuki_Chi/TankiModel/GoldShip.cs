using System.Drawing;

namespace Tanuki_Chi
{
    public class GoldShip : TanukiModel
    {
        /// <summary>
        /// 
        /// </summary>
        public GoldShip() : base("ゴールドシップ", "")
        {

        }

        /// <summary>
        /// 
        /// </summary>
        public override Image InitImage()
        {
            return Properties.Resources.GoldShip_Front_Smiling;
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

            if (image == null)
            {
                CurrentImageName = "";
                image = InitImage();
            }

            return image;
        }
    }
}
