using System.Drawing;

namespace Tanuki_Chi
{
    public class TokaiTeio : TanukiModel
    {
        /// <summary>
        /// 
        /// </summary>
        public TokaiTeio() : base("トウカイテイオー", "")
        {

        }

        /// <summary>
        /// 
        /// </summary>
        public override Image InitImage()
        {
            return Properties.Resources.TokaiTeio_Front_Smiling;
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
