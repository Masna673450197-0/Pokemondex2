using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokemondeks
{
    public class Pikachu : Pokemon
    {
        public Pikachu()
        {
            this.Type = PokemonType.Electric;
            this.Height = 0.4;
            this.Weight = 6.0;
            this.HP = 35;
            this.Attack = 55;
            this.Defense = 40;
            this.SpecialAttack = 50;
            this.SpecialDefense = 50;
            this.Speed = 90;
            this.Total = 320;
            this.Name = "Pikachu";
            // Handle cases where the image is not found
            byte[] PikachuImage = Resource1.ResourceManager.GetObject("Pikachu") as byte[];
            if (PikachuImage != null)
            {
                this.image = PikachuImage;
            }
            else
            {
                // Handle cases where the image is not found
                // Option 1: Use a default image from resources
                this.image = pokemondeks.Resource1.Pikachu; // ต้องเพิ่มรูปภาพ DefaultPikachuImage ใน Resources

                // Option 2: Log an error message
                Console.WriteLine("Error: Pikachu image not found in resources.");
            }
        }
        public string Status { get; set; }
    }
}