using System.Drawing;

namespace Tanuki_Chi
{
    public abstract class TanukiModel
    {
        private string name;
        private Image initImage;
        private Image currentImage;

        /// <summary>
        /// 
        /// </summary>
        private TanukiModel()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="initImage"></param>
        public TanukiModel(string name, Image initImage)
        {
            this.name = name;
            this.initImage = initImage;
        }

        /// <summary>
        /// 
        /// </summary>
        public string Name
        {
            get { return name; }
        }

        /// <summary>
        /// 
        /// </summary>
        public Image InitImage
        {
            get { return initImage; }
        }

        /// <summary>
        /// 
        /// </summary>
        public Image CurrentImage
        {
            get { return currentImage; }
            set { currentImage = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        public abstract Image Command(string command); 
    }
}
