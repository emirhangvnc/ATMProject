using BusinessLayer.Constants.Standart;
using BusinessLayer.Constants.TR.Base;
using BusinessLayer.Constants.TR.General;

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
            internal override string UserImageListed()
            {
                return $"{UserImageMessagesTR.UserImage} {BaseConstantsTR.Listed}";
            }
            internal override string UserImagesListed()
            {
                return $"{UserImageMessagesTR.UserImage} {BaseConstantsTR.Listed}";
            }
            internal override string UserImageMustBeExists()
            {
                return $"{UserImageMessagesTR.UserImage} Olmalı";
            }
            internal override string InvalidImageExtension()
            {
                return $"{GeneralConstantsTR.InvalidFileExtension} {BaseConstantsTR.Image} {BaseConstantsTR.For} {BaseConstantsTR.Accepted} {BaseConstantsTR.Extension } => {string.Join(",", GeneralConstantsTR.ValidImageFileTypes)}";
            }
            internal override string UserImageAdded()
            {
                return $"{UserImageMessagesTR.UserImage} {BaseConstantsTR.Added}";
            }
            internal override string UserImageDeleted()
            {
                return $"{UserImageMessagesTR.UserImage} {BaseConstantsTR.Deleted}";
            }
            internal override string UserImageUpdated()
            {
                return $"{UserImageMessagesTR.UserImage} {BaseConstantsTR.Updated}";
            }
        }
        readonly static Worker worker = new Worker();
        public static string UserImage = worker.UserImage();
        public static string UserImageListed = worker.UserImageListed();
        public static string UserImagesListed = worker.UserImagesListed();
        public static string UserImageMustBeExists = worker.UserImageMustBeExists();
        public static string InvalidImageExtension = worker.InvalidImageExtension();
        public static string UserImageAdded = worker.UserImageAdded();
        public static string UserImageDeleted = worker.UserImageDeleted();
        public static string UserImageUpdated = worker.UserImageUpdated();
    }
}