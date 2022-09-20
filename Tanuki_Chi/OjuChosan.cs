using System.Drawing;

namespace Tanuki_Chi
{
    public class OjuChosan : TanukiModel
    {
        /// <summary>
        /// 
        /// </summary>
        public OjuChosan() : base("オジュウチョウサン", Properties.Resources.OjuChosan_Front_WaistSwing)
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
