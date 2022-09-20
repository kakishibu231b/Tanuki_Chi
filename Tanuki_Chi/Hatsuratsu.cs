using System.Drawing;

namespace Tanuki_Chi
{
    public class Hatsuratsu : TanukiModel
    {
        /// <summary>
        /// 
        /// </summary>
        public Hatsuratsu() : base("ハツラツ", Properties.Resources.オグリキャップ幼少期立ちｖ)
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
