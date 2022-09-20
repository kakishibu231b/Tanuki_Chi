using System.Drawing;

namespace Tanuki_Chi
{
    public class TwinTurbo : TanukiModel
    {
        /// <summary>
        /// 
        /// </summary>
        public TwinTurbo() : base("ツインターボ", Properties.Resources.ターボはりきり)
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
