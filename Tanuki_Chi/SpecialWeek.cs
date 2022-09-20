using System.Drawing;

namespace Tanuki_Chi
{
    public class SpecialWeek : TanukiModel
    {
        /// <summary>
        /// 
        /// </summary>
        public SpecialWeek() : base("スペシャルウィーク", Properties.Resources.SpecialWeek_Dance_Smiling)
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

            if (command == "MouseDown")
            {

            }

            return image;
        }
    }
}
