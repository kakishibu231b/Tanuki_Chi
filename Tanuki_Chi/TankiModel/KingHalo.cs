using System.Drawing;

namespace Tanuki_Chi
{
    public class KingHalo : TanukiModel
    {
        /// <summary>
        /// 
        /// </summary>
        public KingHalo() : base("キングヘイロー", "")
        {

        }

        /// <summary>
        /// 
        /// </summary>
        public override Image InitImage()
        {
            return Properties.Resources.KingHalo_Dance_Smiling;
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

            if (command == "futon")
            {
                if (GuestName == "ハルウララ")
                {
                    if (CurrentImageName != "KingHaloHaruUrara_Sleep_Smiling")
                    {
                        CurrentImageName = "KingHaloHaruUrara_Sleep_Smiling";
                        image = Properties.Resources.KingHaloHaruUrara_Sleep_Smiling;
                    }
                }
                else
                {
                    if (CurrentImageName != "KingHalo_Sleep_Smiling")
                    {
                        CurrentImageName = "KingHalo_Sleep_Smiling";
                        image = Properties.Resources.KingHalo_Sleep_Smiling;
                    }
                }
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
