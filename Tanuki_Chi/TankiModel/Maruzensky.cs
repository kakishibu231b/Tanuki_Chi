using System.Drawing;

namespace Tanuki_Chi
{
    public class Maruzensky : TanukiModel
    {
        /// <summary>
        /// 
        /// </summary>
        public Maruzensky() : base("マルゼンスキー", "")
        {

        }

        /// <summary>
        /// 
        /// </summary>
        public override Image InitImage()
        {
            return Properties.Resources.MaruzenskyMS_Dance_Sing;
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
