using System.Drawing;

namespace Tanuki_Chi
{
    public class MihonoBourbon : TanukiModel
    {
        Image initImage = Properties.Resources.ミホノブルボン歌唱;

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
