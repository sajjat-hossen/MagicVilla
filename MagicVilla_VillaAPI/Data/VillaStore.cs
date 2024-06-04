using MagicVilla_VillaAPI.Dto;

namespace MagicVilla_VillaAPI.Data
{
    public static class VillaStore
    {
        public static List<VillaDTO> villaList = new List<VillaDTO>
            {
                new VillaDTO { Id = 1, Name = "Pool View", Sqft = 400, Occupancy = 3},
                new VillaDTO { Id = 2, Name = "Beach View", Sqft = 300, Occupancy = 2},
                new VillaDTO { Id = 3, Name = "River View", Sqft = 300, Occupancy = 2}
            };
    }
}
