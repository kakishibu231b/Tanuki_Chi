using System.Drawing;

namespace Tanuki_Chi
{
    public class Maruzensky : TanukiModel
    {
        Image initImage = Properties.Resources.マルゼンスキー今風1歌唱;

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
