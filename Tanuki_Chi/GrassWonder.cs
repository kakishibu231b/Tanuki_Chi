using System.Drawing;

namespace Tanuki_Chi
{
    public class GrassWonder : TanukiModel
    {
        /// <summary>
        /// 
        /// </summary>
        public GrassWonder() : base("グラスワンダー")
        {

        }

        /// <summary>
        /// 
        /// </summary>
        public override Image InitImage()
        {
            return Properties.Resources.GrassWonder_Dance_Smiling;
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
