using System.Drawing;

namespace Tanuki_Chi
{
    public class SeiunSky : TanukiModel
    {
         /// <summary>
        /// 
        /// </summary>
        public SeiunSky() : base("セイウンスカイ", Properties.Resources.SeiunSky_Dance_Smiling)
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
