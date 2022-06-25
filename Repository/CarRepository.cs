using System;
using System.Collections.Generic;
using System.Linq;
using net_rest_api.Models.CarModel;

namespace net_rest_api.Repository
{
    public class CarRepository
    {
        private readonly List<CarModel> _carModels = new List<CarModel> {
           new CarModel{id= Guid.NewGuid(), Name="Honda", ModelName="City", CreatedAt= DateTime.Now},

            new CarModel{id= Guid.NewGuid(), Name="Maruti Suzaki", ModelName="Alto", CreatedAt= DateTime.Now},

            new CarModel{id= Guid.NewGuid(), Name="BMW", ModelName="M3", CreatedAt= DateTime.Now}
        };


        // using arrow function similar to js

        // Return all car models in repository.
        public IEnumerable<CarModel> GetCarModels() => _carModels;

        public CarModel? GetCar(Guid id) => _carModels.Where(carModels => carModels.id == id).SingleOrDefault();
    }
}