using System.Drawing;

namespace Tanuki_Chi
{
    public class TsurumaruTsuyoshi : TanukiModel
    {
        /// <summary>
        /// 
        /// </summary>
        public TsurumaruTsuyoshi() : base("ツルマルツヨシ", Properties.Resources.ツルマルツヨシにっこり)
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
