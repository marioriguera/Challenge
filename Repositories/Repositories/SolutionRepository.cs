using System.Collections.Generic;
using System.Threading.Tasks;
using Challenge.Repositories.Models;
using Challenge.Repositories.Repositories.Interfaces;

namespace Challenge.Repositories.Repositories
{
    public class SolutionRepository : ISolutionRepository
    {
        private List<Inmueble> inmuebles = new List<Inmueble>()
        {
            new Inmueble(){
                Id = 1,
                AgencyId = "4d4b1dd3-59c5-401f-a184-01e38340fdf4",
                Baths = 1,
                Location = new Location() {
                    Id = 1,
                    City = "Granollers",
                    Address = "C/ Anselm Clave 61"
                },
                OperationType = "venta",
                Price = 1950000.0,
                Rooms = 3,
                Type = "piso"
            },
            new Inmueble(){
                Id = 2,
                AgencyId = "4d4b1dd3-59c5-401f-a184-01e38340fdf5",
                Baths = 2,
                Location = new Location() {
                    Id = 1,
                    City = "Granollers",
                    Address = "C/ Anselm Clave 61"
                },
                OperationType = "venta",
                Price = 2950000.0,
                Rooms = 4,
                Type = "casa"
            },
            new Inmueble(){
                Id = 3,
                AgencyId = "4d4b1dd3-59c5-401f-a184-01e38340fdf6",
                Baths = 1,
                Location = new Location() {
                    Id = 2,
                    City = "Barcelona",
                    Address = "C/ Gran Vía #1"
                },
                OperationType = "alquiler",
                Price = 1000.0,
                Rooms = 3,
                Type = "piso"
            },
        };

        /// <summary>
        ///  Devuelve todos los inmuebles, utilizo task aunque no es asincrono el metodo, lo uso para el acceso a datos
        /// con entity framework
        /// </summary>
        /// <returns></returns>
        public async Task<List<Inmueble>> GetInmueblesAsync()
        {
            return inmuebles;
        }
    }
}