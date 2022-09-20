using System.Drawing;

namespace Tanuki_Chi
{
    public class TwinTurbo : TanukiModel
    {
        Image initImage = Properties.Resources.ターボはりきり;

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
