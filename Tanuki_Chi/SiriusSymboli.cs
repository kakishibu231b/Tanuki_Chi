using System.Drawing;

namespace Tanuki_Chi
{
    public class SiriusSymboli : TanukiModel
    {
        Image initImage = Properties.Resources.シリウスシンボリ立ちにっこり;

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
