using System.Drawing;

namespace Tanuki_Chi
{
    public class SmartFalcon : TanukiModel
    {
        /// <summary>
        /// 
        /// </summary>
        public SmartFalcon() : base("スマートファルコン", Properties.Resources.スマートファルコンコンサート)
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
