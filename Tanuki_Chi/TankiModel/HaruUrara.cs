using System.Drawing;

namespace Tanuki_Chi
{
    public class HaruUrara : TanukiModel
    {
        /// <summary>
        /// 
        /// </summary>
        public HaruUrara() : base("ハルウララ", "")
        {

        }

        /// <summary>
        /// 
        /// </summary>
        public override Image InitImage()
        {
            return Properties.Resources.HaruUrara_Dance_Smiling;
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
