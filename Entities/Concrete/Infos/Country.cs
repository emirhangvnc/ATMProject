using CoreLayer.DataAccess;

namespace EntitiesLayer.Concrete.Infos
{
    public class Country:IEntity
    {
        public int Id { get; set; }
        public string CountryName { get; set; }
        public string CountryCode { get; set; }
        public IList<City> Cities { get; set; }
    }
}
