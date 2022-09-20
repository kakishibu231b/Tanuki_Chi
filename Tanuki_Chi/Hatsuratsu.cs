using System.Drawing;

namespace Tanuki_Chi
{
    public class Hatsuratsu : TanukiModel
    {
        /// <summary>
        /// 
        /// </summary>
        public Hatsuratsu() : base("ハツラツ")
        {

        }

        /// <summary>
        /// 
        /// </summary>
        public override Image InitImage()
        {
            return Properties.Resources.Hatsuratsu_Front_Smiling;
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
                CurrentImage = "";
                image = InitImage();
            }

            return image;
        }
    }
}
