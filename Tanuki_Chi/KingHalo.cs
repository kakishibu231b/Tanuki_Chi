using System.Drawing;

namespace Tanuki_Chi
{
    public class KingHalo : TanukiModel
    {
        /// <summary>
        /// 
        /// </summary>
        public KingHalo() : base("キングヘイロー", Properties.Resources.キングヘイローはりきり)
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
