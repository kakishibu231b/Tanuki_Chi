using System.Drawing;

namespace Tanuki_Chi
{
    public class Maruzensky : TanukiModel
    {
        /// <summary>
        /// 
        /// </summary>
        public Maruzensky() : base("マルゼンスキー", Properties.Resources.MaruzenskyMS_Dance_Sing)
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
