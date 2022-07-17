using BusinessLayer.Constants.Standart.Base;
using BusinessLayer.Constants.Standart.General;

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
            internal virtual string UserImageMustBeExists()
            {
                return $"{UserImageMessagesStandart.UserImage} Must Be Exists";
            }
            internal virtual string InvalidImageExtension()
            {
                return $"{GeneralConstantsStandart.InvalidFileExtension} {BaseConstantsStandart.Image} {BaseConstantsStandart.For} {BaseConstantsStandart.Accepted} {BaseConstantsStandart.Extension} => {string.Join(",", GeneralConstantsStandart.ValidImageFileTypes)}";
            }
            internal virtual string UserImageAdded()
            {
                return $"{UserImageMessagesStandart.UserImage} {BaseConstantsStandart.Added}";
            }
            internal virtual string UserImageDeleted()
            {
                return $"{UserImageMessagesStandart.UserImage} {BaseConstantsStandart.Deleted}";
            }
            internal virtual string UserImageUpdated()
            {
                return $"{UserImageMessagesStandart.UserImage} {BaseConstantsStandart.Updated}";
            }
        }
        readonly static UserImageWorker worker = new UserImageWorker();
        internal static string UserImage = worker.UserImage();
        internal static string UserImageListed = worker.UserImageListed();
        internal static string UserImagesListed = worker.UserImagesListed();
        internal static string UserImageMustBeExists = worker.UserImageMustBeExists();
        internal static string InvalidImageExtension = worker.InvalidImageExtension();
        internal static string UserImageAdded = worker.UserImageAdded();
        internal static string UserImageDeleted = worker.UserImageDeleted();
        internal static string UserImageUpdated = worker.UserImageUpdated();
    }
}