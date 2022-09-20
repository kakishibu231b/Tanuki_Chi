using System.Drawing;

namespace Tanuki_Chi
{
    public class InesFujin : TanukiModel
    {
        /// <summary>
        /// 
        /// </summary>
        public InesFujin() : base("アイネスフウジン", Properties.Resources.アイネスフウジン歌唱)
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
