using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using net_rest_api.Models.CarModel;
using net_rest_api.Repository;

namespace net_rest_api.Controllers
{
    // For simplicity for frontend apps
    [ApiController]
    [Route("cars")]     // For defining own route name. If don't define controller name will be route name
    public class CarModelController : ControllerBase
    {

        private readonly CarRepository _repository;

        public CarModelController()
        {
            _repository = new CarRepository();

        }

        // GET /cars
        [HttpGet]
        public IEnumerable<CarModel> GetCars()
        {

            var cars = _repository.GetCarModels();
            return cars;

        }



    }
}