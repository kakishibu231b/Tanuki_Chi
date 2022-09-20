using System.Drawing;

namespace Tanuki_Chi
{
    public class MihonoBourbon : TanukiModel
    {
        /// <summary>
        /// 
        /// </summary>
        public MihonoBourbon() : base("ミホノブルボン", Properties.Resources.MihonoBourbon_Dance_Sing)
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
