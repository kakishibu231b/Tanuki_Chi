using System.Drawing;

namespace Tanuki_Chi
{
    public class HayakawaTazuna : TanukiModel
    {
        Image initImage = Properties.Resources.関係者_駿川たづな直立にっこり;

        public Image InitImage
        {
            get { return initImage; }
        }

        public Image Command(string command)
        {
            Image image = initImage;

            if(command == "MouseDown")
            {
                image = Properties.Resources.関係者_駿川たづな直立笑顔;
            }

            return image;
        }
    }
}
