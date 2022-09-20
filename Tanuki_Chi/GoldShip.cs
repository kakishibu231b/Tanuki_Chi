using System.Drawing;

namespace Tanuki_Chi
{
    public class GoldShip : TanukiModel
    {
        /// <summary>
        /// 
        /// </summary>
        public GoldShip() : base("ゴールドシップ", Properties.Resources.GoldShip_Front_Smiling)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        public override Image Command(string command)
        {
            Image image = InitImage;

            if (command == "MouseDown")
            {

            }

            return image;
        }
    }
}
