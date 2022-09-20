using System.Drawing;

namespace Tanuki_Chi
{
    public class SymboliRudolf : TanukiModel
    {
        Image initImage = Properties.Resources.ションボリ立ち正面ｖ;

        public Image InitImage
        {
            get { return initImage; }
        }

        public Image Command(string command)
        {
            return initImage;
        }
    }
}
