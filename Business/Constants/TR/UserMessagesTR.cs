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
            internal override string UserFirstName()
            {
                return $"{UserMessagesTR.User} {BaseConstantsTR.FirstName}";
            }
            internal override string UserLastName()
            {
                return $"{UserMessagesTR.User} {BaseConstantsTR.LastName}";
            }
            internal override string UserNameNotNull()
            {
                return $"{UserMessagesTR.User} {BaseConstantsTR.Name} {BaseConstantsTR.NotNull}";
            }
            internal override string UserListed()
            {
                return $"{UserMessagesTR.User} {BaseConstantsTR.Listed}";
            }
            internal override string UsersListed()
            {
                return $"{UserMessagesTR.User}ler {BaseConstantsTR.Listed}";
            }
            internal override string UserRegistered()
            {
                return $"{UserMessagesTR.User} Kayıt Başarılı";
            }
            internal override string UserRolListed()
            {
                return $"{UserMessagesTR.User} Rolleri {BaseConstantsTR.Listed}";
            }
            internal override string AuthorizationDenied()
            {
                return $"Yetkilendirilme Reddedildi";
            }
            internal override string UserAlreadyExists()
            {
                return $"{UserMessagesTR.User} {BaseConstantsTR.AlreadyExists}";
            }
            internal override string PasswordError()
            {
                return $"Hatalı {BaseConstantsTR.Password}";
            }
            internal override string AccessTokenCreated()
            {
                return $"Token {BaseConstantsTR.Created}";
            }
            internal override string UserAdded()
            {
                return $"{UserMessagesTR.User} {BaseConstantsTR.Added}";
            }
            internal override string UserDeleted()
            {
                return $"{UserMessagesTR.User} {BaseConstantsTR.Deleted}";
            }
            internal override string UserUpdated()
            {
                return $"{UserMessagesTR.User} {BaseConstantsTR.Updated}";
            }
            internal override string UserNotFound()
            {
                return $"{UserMessagesTR.User} {BaseConstantsTR.NotFound}";
            }
        }
        readonly static Worker worker = new Worker();
        public static string User = worker.User();
        public static string UserFirstName = worker.UserFirstName();
        public static string UserLastName = worker.UserLastName();
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