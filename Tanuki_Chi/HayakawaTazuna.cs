using System.Drawing;

namespace Tanuki_Chi
{
    public class HayakawaTazuna : TanukiModel
    {
        /// <summary>
        /// 
        /// </summary>
        public HayakawaTazuna() : base("駿川たづな", Properties.Resources.関係者_駿川たづな直立にっこり)
        {
            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        public override Image Command(string command)
        {
            Image image = InitImage;

            if(command == "MouseDown")
            {
                if(CurrentImage != Properties.Resources.関係者_駿川たづな直立笑顔)
                {
                    image = Properties.Resources.関係者_駿川たづな直立笑顔;
                }
            }

            return image;
        }
    }
}
