using System.Drawing;

namespace Tanuki_Chi
{
    public class SilenceSuzuka : TanukiModel
    {
        /// <summary>
        /// 
        /// </summary>
        public SilenceSuzuka() : base("サイレンススズカ", Properties.Resources.SilenceSuzuka_Dance_Sing)
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
