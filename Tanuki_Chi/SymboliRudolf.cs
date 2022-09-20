using System.Drawing;

namespace Tanuki_Chi
{
    public class SymboliRudolf : TanukiModel
    {
        /// <summary>
        /// 
        /// </summary>
        public SymboliRudolf() : base("シンボリルドルフ", Properties.Resources.ションボリ立ち正面ｖ)
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
