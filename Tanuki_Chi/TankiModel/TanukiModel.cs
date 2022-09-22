using System.Drawing;

namespace Tanuki_Chi
{
    public abstract class TanukiModel
    {
        private string fullName;
        private string eponymousName;
        private string currentImageName;

        /// <summary>
        /// 
        /// </summary>
        private TanukiModel()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="fulllname"></param>
        /// <param name="eponymousName"></param>
        public TanukiModel(string fulllname, string eponymousName)
        {
            this.fullName = fulllname;
            this.eponymousName = eponymousName;
        }

        /// <summary>
        /// 
        /// </summary>
        public string FullName
        {
            get { return fullName; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string EponymousName
        {
            get { return eponymousName; }
        }

        /// <summary>
        /// 
        /// </summary>
        public abstract Image InitImage();

        /// <summary>
        /// 
        /// </summary>
        public string CurrentImageName
        {
            get { return currentImageName; }
            set { currentImageName = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        public abstract Image Command(string command); 
    }
}
