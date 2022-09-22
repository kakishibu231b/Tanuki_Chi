using System.Drawing;

namespace Tanuki_Chi
{
    public class TsurumaruTsuyoshi : TanukiModel
    {
        /// <summary>
        /// 
        /// </summary>
        public TsurumaruTsuyoshi() : base("ツルマルツヨシ", "")
        {

        }

        /// <summary>
        /// 
        /// </summary>
        public override Image InitImage()
        {
            return Properties.Resources.TsurumaruTsuyoshi_Dance_Smiling;
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
