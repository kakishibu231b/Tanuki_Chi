using System.Drawing;

namespace Tanuki_Chi
{
    public class HayakawaTazuna : TanukiModel
    {
        /// <summary>
        /// 
        /// </summary>
        public HayakawaTazuna() : base("駿川たづな", Properties.Resources.HayakawaTazuna_Front_Smile)
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
                if(CurrentImage != Properties.Resources.HayakawaTazuna_Front_Smiling)
                {
                    image = Properties.Resources.HayakawaTazuna_Front_Smiling;
                }
            }

            return image;
        }
    }
}
