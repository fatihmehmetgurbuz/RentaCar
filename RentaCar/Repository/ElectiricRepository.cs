using RentaCar.Dtos;
using RentaCar.Repository.DbContext;

namespace RentaCar.Repository
{
    public class ElectiricRepository : AppDbContext
    {

        public ModelAndBrandDto GetCarsMaoelAndBrandByPlaka(string plaka)
        {
            string query = $"SELECT model,marka FROM Elektirik WHERE plaka = {plaka};";
            var response = Query(query);
            return Mapping.ObjectMapper.Mapper.Map<ModelAndBrandDto>(response);
        }


    }
}
