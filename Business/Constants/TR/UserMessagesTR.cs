using BusinessLayer.Constants.Standart;
using BusinessLayer.Constants.TR.Base;

namespace BusinessLayer.Constants.TR
{
    public static class UserMessagesTR
    {
        private class Worker : UserMessagesStandart.UserWorker
        {
            internal override string User()
            {
                return "Üye";
            }
            internal override string UserNameNotNull()
            {
                return $"{UserMessagesTR.User} {BaseConstantsTR.Name} {BaseConstantsTR.NotNull}";
            }
        }
        readonly static Worker worker = new Worker();
        public static string User = worker.User();
        public static string UserNameNotNull = worker.UserNameNotNull();
        public static string UserListed = worker.UserListed();
        public static string UsersListed = worker.UsersListed();
        public static string UserRegistered = worker.UserRegistered();
        public static string UserRolListed = worker.UserRolListed();
        public static string AuthorizationDenied = worker.AuthorizationDenied();
        public static string UserAlreadyExists = worker.UserAlreadyExists();
        public static string PasswordError = worker.PasswordError();
        public static string AccessTokenCreated = worker.AccessTokenCreated();
        public static string UserAdded = worker.UserAdded();
        public static string UserDeleted = worker.UserDeleted();
        public static string UserUpdated = worker.UserUpdated();
        public static string UserNotFound = worker.UserNotFound();
    }
}