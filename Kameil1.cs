using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokemondeks
{
    public class Kameil : Pokemon
    {
        public Kameil()
        {
            this.Type = PokemonType.Poison;
            this.Height = 1.0;
            this.Weight = 22.5;
            this.HP = 59;
            this.Attack = 63;
            this.Defense = 80;
            this.SpecialAttack = 65;
            this.SpecialDefense = 80;
            this.Speed = 58;
            this.Total = 405;
            this.Name = "Kameil";
            // Handle cases where the image is not found
            byte[] pikachuImage = Resource1.ResourceManager.GetObject("Kameil") as byte[];
            if (pikachuImage != null)
            {
                this.image = pikachuImage;
            }
            else
            {
                // Handle cases where the image is not found
                // Option 1: Use a default image from resources
                this.image = pokemondeks.Resource1.Kameil; // ต้องเพิ่มรูปภาพ DefaultPikachuImage ใน Resources

                // Option 2: Log an error message
                Console.WriteLine("Error: Pikachu image not found in resources.");
            }
        }
        public string Status { get; set; }
    }
}