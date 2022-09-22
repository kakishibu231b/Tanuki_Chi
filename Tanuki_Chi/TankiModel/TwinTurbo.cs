using System.Drawing;

namespace Tanuki_Chi
{
    public class TwinTurbo : TanukiModel
    {
        /// <summary>
        /// 
        /// </summary>
        public TwinTurbo() : base("ツインターボ", "")
        {

        }

        /// <summary>
        /// 
        /// </summary>
        public override Image InitImage()
        {
            return Properties.Resources.TwinTurbo_Dance_HighSpirits;
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
