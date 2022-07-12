using BusinessLayer.Constants.TR.Base;

namespace BusinessLayer.Constants.TR
{
    public class UserMessages
    {
        public static string User = $"Üye";
        public static string UserNameNotNull = $"{User} {BaseConstants.Name} {BaseConstants.NotNull}";
        public static string UsersListed = $"{User}ler {BaseConstants.Listed}";
        public static string UserRolListed = $"{User} Rolleri {BaseConstants.Listed}";
        public static string UserListed = $"{BaseConstants.Search} {User} {BaseConstants.Listed}";
        public static string UserRegistered = $"{User} {BaseConstants.Added}";
        public static string SuccessfulLogin = $"{User} {BaseConstants.LoginSuccessful}";
        public static string AuthorizationDenied = "Yetkiniz Bulunmamakta";
        public static string UserAlreadyExists = "Kullanıcı Mevcut";
        public static string PasswordError = "Parola Hatası";
        public static string AccessTokenCreated = $"Token {BaseConstants.Created}";
        public static string UserAdded = $"{User} {BaseConstants.Added}";
        public static string UserDeleted = $"{User} {BaseConstants.Deleted}";
        public static string UserUpdated = $"{User} {BaseConstants.Updated}";
        public static string UserNotFound = $"{User} {BaseConstants.NotFound}";
    }
}