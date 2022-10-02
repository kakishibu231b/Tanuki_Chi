using System.Drawing;

namespace Tanuki_Chi
{
    public class SymboliRudolf : TanukiModel
    {
        /// <summary>
        /// 
        /// </summary>
        public SymboliRudolf() : base("シンボリルドルフ", "")
        {

        }

        /// <summary>
        /// 
        /// </summary>
        public override Image InitImage()
        {
            return Properties.Resources.SymboliRudolf_Front_Smiling;
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

            }

            if (command == "meat")
            {
                CurrentImageName = "SymboliRudolf_Front_SmilingMeat";
                image = Properties.Resources.SymboliRudolf_Front_SmilingMeat;
            }

            if (command == "ramen")
            {
                CurrentImageName = "SymboliRudolf_Front_SmilingRamen";
                image = Properties.Resources.SymboliRudolf_Front_SmilingRamen;
            }

            if (command == "futon")
            {
                CurrentImageName = "SymboliRudolf_Sleep_Smiling";
                image = Properties.Resources.SymboliRudolf_Sleep_Smiling;
            }

            if (image == null)
            {
                CurrentImageName = "";
                image = InitImage();
            }

            return image;
        }
    }
}
