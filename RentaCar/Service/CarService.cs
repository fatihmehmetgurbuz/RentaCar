
using RentaCar.Dtos;
using RentaCar.Entities;
using RentaCar.Repository;
using RentaCar.Repository.Car;

namespace RentaCar.Service
{
    public class CarService
    {
        private readonly CarRepository _carRepository;
        private readonly FuelRepository _fuelRepository;
        private readonly ElectiricRepository _electiricRepository;

        public CarService(CarRepository carRepository, FuelRepository fuelRepository, ElectiricRepository electiricRepository)
        {
            _carRepository = carRepository;
            _fuelRepository = fuelRepository;
            _electiricRepository = electiricRepository;
        }

        public List<Cars> GetAllCars()
        {
            var a = _fuelRepository.GetCarsMaoelAndBrandByPlaka("12345");
            return _carRepository.GetAllCars();
        }

        public List<Cars> GetCars(string year)
        {
            if(year == null)
            {
                throw new Exception("year null olamaz");
            }

            return _carRepository.GetAllCarsWithYear(year);
        }

        public ModelAndBrandDto GetModelAndBrandByPlaka(string plaka)
        {
            return null;
        }
    }
}
