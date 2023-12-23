using RentaCar.Entities;
using RentaCar.Repository.DbContext;
using Microsoft.Extensions.Configuration;
using AutoMapper.Internal.Mappers;
using RentaCar.Mapping;
using RentaCar.Dtos;

namespace RentaCar.Repository.Car
{
    public class FuelRepository : AppDbContext
    {
        public ModelAndBrandDto GetCarsMaoelAndBrandByPlaka(string plaka)
        {
            string query = $"SELECT model,marka FROM Benzin WHERE plaka = {plaka};";
            var response = Query(query);
            return ObjectMapper.Mapper.Map<ModelAndBrandDto>(response);
        }


    }
}
