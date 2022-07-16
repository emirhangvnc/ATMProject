using BusinessLayer.Constants.Standart.Base;

namespace BusinessLayer.Constants.Standart
{
    internal static class UserImageMessagesStandart
    {
        internal class UserImageWorker
        {
            internal virtual string UserImage()
            {
                return $"User Image";
            }
            internal virtual string UserImageListed()
            {
                return $"{BaseConstantsStandart.Search} {UserImageMessagesStandart.UserImage} {BaseConstantsStandart.Listed}";
            }
            internal virtual string UserImagesListed()
            {
                return $"{UserImageMessagesStandart.UserImage} {BaseConstantsStandart.Listed}";
            }
        }
        readonly static UserImageWorker worker = new UserImageWorker();
        internal static string UserImage = worker.UserImage();
        internal static string UserImageListed = worker.UserImageListed();
        internal static string UserImagesListed = worker.UserImagesListed();
    }
}