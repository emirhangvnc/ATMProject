using CoreLayer.DataAccess;

namespace EntitiesLayer.Concrete.Infos
{
    public class City : IEntity
    {
        public int Id { get; set; }
        public string CityName { get; set; }
        public string CityCode { get; set; }
    }
}