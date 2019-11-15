using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//TODO 10: Add Opslag Class voor alle Broden

namespace BaDeHo.Models
{
    public class Opslagplaats
    {
        private static List<Brood> mijnBroden = new List<Brood>()
        {
            new Brood()
            {
                ID=1,
                Naam= "Wit brood",
                Beschrijving="Wit brood op steen gebakken",
                FotoLocatie="witbrood.jpg",
                Prijs = 1.8
            },

            new Brood()
            {
                ID = 2,
                Naam = "Bruin brood",
                Beschrijving = "Bruin brood op steen gebakken.",
                FotoLocatie = "bruinbrood.jpg",
                Prijs = 1.8
            },

            new Brood()
            {
                ID = 3,
                Naam = "Speltbrood",
                Beschrijving = "Brood gebakken met spelt.",
                FotoLocatie = "speltbrood.jpg",
                Prijs = 2.1
            },

            new Brood()
            {
                ID = 4,
                Naam = "Volkorenbrood",
                Beschrijving = "Iets bruiner brood gebakken met volkorenbloem.",
                FotoLocatie = "volkorenbrood.jpg",
                Prijs = 2.4
            },

            new Brood()
            {
                ID = 5,
                Naam = "Stokbrood",
                Beschrijving = "Wit brood dat na enkele dagen een baseball bat wordt.",
                FotoLocatie = "stokbrood.png",
                Prijs = 1.0
            }
        };

        public List<Brood> MijnBroden
        {
            get
            {
                return mijnBroden;
            }
        }
    }
}
