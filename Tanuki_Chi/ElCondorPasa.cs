using System.Drawing;

namespace Tanuki_Chi
{
    public class ElCondorPasa : TanukiModel
    {
        Image initImage = Properties.Resources.エルコンドルパサーにっこり;

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
