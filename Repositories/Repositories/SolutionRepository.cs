using System;
using System.Collections.Generic;
using System.Reflection;
using System.Threading.Tasks;
using Challenge.Repositories.Models;
using Challenge.Repositories.Repositories.Interfaces;

namespace Challenge.Repositories.Repositories
{
    public class SolutionRepository : ISolutionRepository
    {
        private List<Inmueble> inmuebles = new List<Inmueble>();

        public SolutionRepository()
        {
            inmuebles.Add(new Inmueble()
            {
                Id = 1,
                AgencyId = "4d4b1dd3-59c5-401f-a184-01e38340fdf4",
                Baths = 1,
                Location = new Location()
                {
                    Id = 1,
                    City = "Granollers",
                    Address = "C/ Anselm Clave 61",
                    Zipcode = "08028"
                },
                OperationType = "venta",
                Price = 1950000.0,
                Rooms = 3,
                Type = "piso"
            });
            inmuebles.Add(new Inmueble()
            {
                Id = 2,
                AgencyId = "4d4b1dd3-59c5-401f-a184-01e38340fdf5",
                Baths = 2,
                Location = new Location()
                {
                    Id = 1,
                    City = "Granollers",
                    Address = "C/ Anselm Clave 61",
                    Zipcode = "08028"
                },
                OperationType = "venta",
                Price = 2950000.0,
                Rooms = 4,
                Type = "casa"
            });
            inmuebles.Add(new Inmueble()
            {
                Id = 3,
                AgencyId = "4d4b1dd3-59c5-401f-a184-01e38340fdf6",
                Baths = 1,
                Location = new Location()
                {
                    Id = 2,
                    City = "Barcelona",
                    Address = "C/ Gran Vía #1",
                    Zipcode = "08028"
                },
                OperationType = "alquiler",
                Price = 1000.0,
                Rooms = 3,
                Type = "piso"
            });
        }

        /// <summary>
        ///  Devuelve todos los inmuebles, utilizo task aunque no es asincrono el metodo, lo uso para el acceso a datos
        /// con entity framework
        /// </summary>
        /// <returns></returns>
        public async Task<List<Inmueble>> GetInmueblesAsync()
        {
            return inmuebles;
        }

        public async Task<Inmueble> UpdateInmuebleAsync(Inmueble inmueble)
        {
            var inmuebleEncontrado = inmuebles.Find(x => x.AgencyId.Equals(inmueble.AgencyId));
            int index = inmuebles.FindIndex(x => x.AgencyId.Equals(inmueble.AgencyId));
            if (inmuebleEncontrado != null)
            {
                foreach (var item in inmuebleEncontrado.GetType().GetProperties())
                {
                    if (item.Name != "Id" && item.Name != "AgencyId" && item.Name != "Location")
                    {
                        var parametroInmEnc = (item.GetValue(inmuebleEncontrado, null));
                        var parametroInm = (item.GetValue(inmueble, null));
                        if (parametroInm != null)
                        {
                            if (!parametroInm.Equals(parametroInmEnc))
                            {
                                PropertyInfo prop = inmuebleEncontrado.GetType().GetProperty(item.Name);
                                prop.SetValue(inmuebles[index], parametroInm);
                            }
                        }
                    }
                    else
                    {
                        if (item.Name == "Location")
                        {
                            if (inmuebleEncontrado.Location != null)
                            {
                                foreach (var loc in inmuebleEncontrado.Location.GetType().GetProperties())
                                {
                                    if (loc.Name != "Id")
                                    {
                                        var locationInmEnc = (loc.GetValue(inmuebleEncontrado.Location, null));
                                        var locationInm = (loc.GetValue(inmueble.Location, null));
                                        if (locationInm != null)
                                        {
                                            if (!locationInm.Equals(locationInmEnc))
                                            {
                                                PropertyInfo locProp = inmuebleEncontrado.Location.GetType().GetProperty(loc.Name);
                                                locProp.SetValue(inmuebles[index].Location, locationInm);
                                            }
                                        }

                                    }
                                }
                            }
                        }
                    }

                }
                return inmuebles.Find(x => x.AgencyId.Equals(inmueble.AgencyId));
            }
            else
            {
                return null;
            }
        }
    }
}