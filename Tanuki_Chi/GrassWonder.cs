using System.Drawing;

namespace Tanuki_Chi
{
    public class GrassWonder : TanukiModel
    {
        Image initImage = Properties.Resources.グラスワンダーにっこり;

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
