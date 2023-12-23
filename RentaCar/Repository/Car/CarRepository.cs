using RentaCar.Repository.DbContext;
using System.Data.SqlClient;
using RentaCar.Entities;
using Microsoft.Extensions.Configuration;
using AutoMapper.Internal.Mappers;
using RentaCar.Mapping;


namespace RentaCar.Repository.Car
{
    public class CarRepository : AppDbContext
    {

        public List<Cars> GetAllCars()
        {
            string query = "SELECT * FROM Araç";
            var firstCar = ObjectMapper.Mapper.Map<List<Cars>>(Query(query)).Where(x=> x.Renk.Equals("siyah")).Select(x=> x.Yil).FirstOrDefault();
            return ObjectMapper.Mapper.Map<List<Cars>>(Query(query)) ;
        }
        //public bool CreateCars(Car car)
        //{
        //    string query = "SELECT * FROM Araç";

        //    return ObjectMapper.Mapper.Map<List<Cars>>(Query(query)); ;
        //}
        public List<Cars> GetAllCarsWithYear(string year)
        {
            string query = $"SELECT * FROM Cars WHERE Yıl = {year}";
            return null;
        }
    }

}
