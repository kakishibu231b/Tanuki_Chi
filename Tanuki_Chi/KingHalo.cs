using System.Drawing;

namespace Tanuki_Chi
{
    public class KingHalo : TanukiModel
    {
        Image initImage = Properties.Resources.キングヘイローはりきり;

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
