using System.Drawing;

namespace Tanuki_Chi
{
    public class MihonoBourbon : TanukiModel
    {
        /// <summary>
        /// 
        /// </summary>
        public MihonoBourbon() : base("ミホノブルボン")
        {

        }

        /// <summary>
        /// 
        /// </summary>
        public override Image InitImage()
        {
            return Properties.Resources.MihonoBourbon_Dance_Sing;
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
