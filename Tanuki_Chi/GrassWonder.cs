using System.Drawing;

namespace Tanuki_Chi
{
    public class GrassWonder : TanukiModel
    {
        /// <summary>
        /// 
        /// </summary>
        public GrassWonder() : base("グラスワンダー", Properties.Resources.GrassWonder_Dance_Smiling)
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
