using System.Drawing;

namespace Tanuki_Chi
{
    public class SmartFalcon : TanukiModel
    {
        Image initImage = Properties.Resources.スマートファルコンコンサート;

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
