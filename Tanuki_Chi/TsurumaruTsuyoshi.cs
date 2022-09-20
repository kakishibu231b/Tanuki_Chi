using System.Drawing;

namespace Tanuki_Chi
{
    public class TsurumaruTsuyoshi : TanukiModel
    {
        Image initImage = Properties.Resources.ツルマルツヨシにっこり;

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
