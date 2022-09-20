using System.Drawing;

namespace Tanuki_Chi
{
    public class SpecialWeek : TanukiModel
    {
        /// <summary>
        /// 
        /// </summary>
        public SpecialWeek() : base("スペシャルウィーク")
        {

        }

        /// <summary>
        /// 
        /// </summary>
        public override Image InitImage()
        {
            return Properties.Resources.SpecialWeek_Dance_Smiling;
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
