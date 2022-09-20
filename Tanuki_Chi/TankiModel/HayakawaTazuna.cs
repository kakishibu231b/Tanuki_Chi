using System.Drawing;

namespace Tanuki_Chi
{
    public class HayakawaTazuna : TanukiModel
    {
        /// <summary>
        /// 
        /// </summary>
        public HayakawaTazuna() : base("駿川たづな")
        {
            
        }

        /// <summary>
        /// 
        /// </summary>
        public override Image InitImage()
        {
            return Properties.Resources.HayakawaTazuna_Front_Smiling;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        public override Image Command(string command)
        {
            Image image = null;

            if (command == "MouseDown")
            {
                if (CurrentImage != "HayakawaTazuna_Front_Smile")
                {
                    CurrentImage = "HayakawaTazuna_Front_Smile";
                    image = Properties.Resources.HayakawaTazuna_Front_Smile;
                }
            }

            if (image == null)
            {
                CurrentImage = "";
                image = InitImage();
            }

            return image;
        }
    }
}
