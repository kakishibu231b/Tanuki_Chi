using System.Drawing;

namespace Tanuki_Chi
{
    public class ElCondorPasa : TanukiModel
    {
        /// <summary>
        /// 
        /// </summary>
        public ElCondorPasa() : base("エルコンドルパサー", Properties.Resources.ElCondorPasa_Dance_Smiling)
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
