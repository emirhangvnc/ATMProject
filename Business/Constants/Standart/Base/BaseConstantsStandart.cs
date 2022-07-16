
namespace BusinessLayer.Constants.Standart.Base
{
    internal static class BaseConstantsStandart
    {
        internal class BaseWorker
        {
            internal virtual string NotNull()
            {
                return "Not Null";
            }
            internal virtual string Added()
            {
                return "Added";
            }
            internal virtual string Deleted()
            {
                return "Deleted";
            }
            internal virtual string Updated()
            {
                return "Updated";
            }
            internal virtual string Listed()
            {
                return "Listed";
            }
            internal virtual string Search()
            {
                return "Search";
            }
            internal virtual string LoginSuccessful()
            {
                return "Login Successful";
            }
            internal virtual string Summoned()
            {
                return "Summoned";
            }
            internal virtual string AlreadyExists()
            {
                return "Already Exists";
            }
            internal virtual string NotFound()
            {
                return "Not Found";
            }
            internal virtual string Name()
            {
                return "Name";
            }
            internal virtual string ID()
            {
                return "ID";
            }
            internal virtual string Created()
            {
                return "Created";
            }
            internal virtual string Max()
            {
                return "Max";
            }
            internal virtual string Min()
            {
                return "Min";
            }
            internal virtual string Entered()
            {
                return "Can Be Entered";
            }
            internal virtual string Code()
            {
                return "Code";
            }
            internal virtual string Password()
            {
                return "Password";
            }
        }
        readonly static BaseWorker worker = new BaseWorker();
        internal static string NotNull = worker.NotNull();
        internal static string Added = worker.Added();
        internal static string Deleted = worker.Deleted();
        internal static string Updated = worker.Updated();
        internal static string Listed = worker.Listed();
        internal static string Search = worker.Search();
        internal static string LoginSuccessful = worker.LoginSuccessful();
        internal static string Summoned = worker.Summoned();
        internal static string AlreadyExists = worker.AlreadyExists();
        internal static string NotFound = worker.NotFound();
        internal static string Name = worker.Name();
        internal static string ID = worker.ID();
        internal static string Created = worker.Created();
        internal static string Max = worker.Max();
        internal static string Min = worker.Min();
        internal static string Entered = worker.Entered();
        internal static string Code = worker.Code();
        internal static string Password = worker.Password();
    }
}