using System.Drawing;

namespace Tanuki_Chi
{
    public class SilenceSuzuka : TanukiModel
    {
        Image initImage = Properties.Resources.サイレンススズカ歌唱;

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
