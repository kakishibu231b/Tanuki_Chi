using System.Drawing;

namespace Tanuki_Chi
{
    public class GoldShip : TanukiModel
    {
        /// <summary>
        /// 
        /// </summary>
        public GoldShip() : base("ゴールドシップ", Properties.Resources.ゴルシ直立ななめおだやか)
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
