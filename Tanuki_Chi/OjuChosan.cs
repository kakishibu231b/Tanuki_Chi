using System.Drawing;

namespace Tanuki_Chi
{
    public class OjuChosan : TanukiModel
    {
        Image initImage = Properties.Resources.オジュウチョウサン腰ふり;

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
