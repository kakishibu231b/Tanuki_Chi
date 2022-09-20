using System.Drawing;

namespace Tanuki_Chi
{
    public class SilenceSuzuka : TanukiModel
    {
        /// <summary>
        /// 
        /// </summary>
        public SilenceSuzuka() : base("サイレンススズカ")
        {

        }

        /// <summary>
        /// 
        /// </summary>
        public override Image InitImage()
        {
            return Properties.Resources.SilenceSuzuka_Dance_Sing;
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
