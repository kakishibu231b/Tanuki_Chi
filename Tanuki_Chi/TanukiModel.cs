using System.Drawing;

namespace Tanuki_Chi
{
    public abstract class TanukiModel
    {
        private string fullName;
        private string eponymousName;
        private string currentImageName;
        private string guestName;
        private int stomachMax;
        private int stomachNow;

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
        public TanukiModel(string fulllname, string eponymousName, int stomachMax = 100, int stomachNow = 50)
        {
            this.fullName = fulllname;
            this.eponymousName = eponymousName;
            this.stomachMax = stomachMax;
            this.stomachNow = stomachNow;
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
        public string GuestName
        {
            get { return guestName; }
            set { guestName = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        public abstract Image Command(string command); 
    }
}
