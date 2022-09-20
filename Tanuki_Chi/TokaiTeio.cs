using System.Drawing;

namespace Tanuki_Chi
{
    public class TokaiTeio : TanukiModel
    {
        /// <summary>
        /// 
        /// </summary>
        public TokaiTeio() : base("トウカイテイオー", Properties.Resources.TokaiTeio_Front_Smiling)
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
