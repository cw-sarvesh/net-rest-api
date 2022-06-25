using System;

namespace net_rest_api.Models.CarModel
{
    public class CarModel
    {

        // init is like private set means cant change after one time defining
        public Guid id { get;  set; }
        public string Name { get; set; }
        public string ModelName { get; set; }

        public DateTime CreatedAt { get;  set; }
    }
}