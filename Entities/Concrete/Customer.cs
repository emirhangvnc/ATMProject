﻿using CoreLayer.DataAccess;

namespace EntitiesLayer.Concrete
{
    public class Customer:IEntity
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
    }
}