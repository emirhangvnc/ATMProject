using BusinessLayer.Constants.Standart;
using BusinessLayer.Constants.TR.Base;

namespace BusinessLayer.Constants.TR
{
    public static class UserImageMessagesTR
    {
        private class Worker : UserImageMessagesStandart.UserImageWorker
        {
            internal override string UserImage()
            {
                return "Üye Resmi";
            }
        }
        readonly static Worker worker = new Worker();
        public static string UserImage = worker.UserImage();
        public static string UserImageListed = worker.UserImageListed();
        public static string UserImagesListed = worker.UserImagesListed();
    }
}