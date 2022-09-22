using System.Drawing;

namespace Tanuki_Chi
{
    public class SpecialWeek : TanukiModel
    {
        /// <summary>
        /// 
        /// </summary>
        public SpecialWeek() : base("スペシャルウィーク", "")
        {

        }

        /// <summary>
        /// 
        /// </summary>
        public override Image InitImage()
        {
            return Properties.Resources.SpecialWeek_Dance_Smiling;
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
                if (CurrentImageName != "SpecialWeek_Dance_EatRice")
                {
                    CurrentImageName = "SpecialWeek_Dance_EatRice";
                    image = Properties.Resources.SpecialWeek_Dance_EatRice;
                }
            }

            if (command == "Put:0")
            {
                if (CurrentImageName != "SpecialWeek_Dance_EatRice")
                {
                    CurrentImageName = "SpecialWeek_Dance_EatRice";
                    image = Properties.Resources.SpecialWeek_Dance_EatRice;
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
