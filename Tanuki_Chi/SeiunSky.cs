using System.Drawing;

namespace Tanuki_Chi
{
    public class SeiunSky : TanukiModel
    {
         /// <summary>
        /// 
        /// </summary>
        public SeiunSky() : base("セイウンスカイ")
        {

        }

        /// <summary>
        /// 
        /// </summary>
        public override Image InitImage()
        {
            return Properties.Resources.SeiunSky_Dance_Smiling;
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
