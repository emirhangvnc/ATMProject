using BusinessLayer.Constants.Standart.Base;

namespace BusinessLayer.Constants.Standart
{
    internal static class UserMessagesStandart
    {
        internal class UserWorker
        {
            internal virtual string User()
            {
                return $"User";
            }
            internal virtual string UserNameNotNull()
            {
                return $"{UserMessagesStandart.User} {BaseConstantsStandart.Name} {BaseConstantsStandart.NotNull}";
            }
            internal virtual string UserListed()
            {
                return $"{BaseConstantsStandart.Search} {UserMessagesStandart.User} {BaseConstantsStandart.Listed}";
            }
            internal virtual string UsersListed()
            {
                return $"{UserMessagesStandart.User}s {BaseConstantsStandart.Listed}";
            }
            internal virtual string UserRolListed()
            {
                return $"{UserMessagesStandart.User} Role {BaseConstantsStandart.Listed}";
            }
            internal virtual string UserRegistered()
            {
                return $"{UserMessagesStandart.User} Registered";
            }
            internal virtual string SuccessfulLogin()
            {
                return $"{UserMessagesStandart.User} {BaseConstantsStandart.LoginSuccessful}";
            }
            internal virtual string AuthorizationDenied()
            {
                return $"Authorization Denied";
            }
            internal virtual string UserAlreadyExists()
            {
                return $"{UserMessagesStandart.User} {BaseConstantsStandart.AlreadyExists}";
            }
            internal virtual string PasswordError()
            {
                return $"{BaseConstantsStandart.Password} Error";
            }
            internal virtual string AccessTokenCreated()
            {
                return $"Token {BaseConstantsStandart.Created}";
            }
            internal virtual string UserAdded()
            {
                return $"{UserMessagesStandart.User} {BaseConstantsStandart.Added}";
            }
            internal virtual string UserDeleted()
            {
                return $"{UserMessagesStandart.User} {BaseConstantsStandart.Deleted}";
            }
            internal virtual string UserUpdated()
            {
                return $"{UserMessagesStandart.User} {BaseConstantsStandart.Updated}";
            }
            internal virtual string UserNotFound()
            {
                return $"{UserMessagesStandart.User} {BaseConstantsStandart.NotFound}";
            }
        }
        readonly static UserWorker worker = new UserWorker();
        internal static string User = worker.User();
        internal static string UserNameNotNull = worker.UserNameNotNull();
        internal static string UserListed = worker.UserListed();
        internal static string UsersListed = worker.UsersListed();
        internal static string UserRegistered = worker.UserRegistered();
        internal static string UserRolListed = worker.UserRolListed();
        internal static string AuthorizationDenied = worker.AuthorizationDenied();
        internal static string UserAlreadyExists = worker.UserAlreadyExists();
        internal static string PasswordError = worker.PasswordError();
        internal static string AccessTokenCreated = worker.AccessTokenCreated();
        internal static string UserAdded = worker.UserAdded();
        internal static string UserDeleted = worker.UserDeleted();
        internal static string UserUpdated = worker.UserUpdated();
        internal static string UserNotFound = worker.UserNotFound();
    }
}