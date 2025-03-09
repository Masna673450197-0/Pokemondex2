using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokemondeks
{
    public class Hitokage : Pokemon
    {
        public Hitokage()
        {
            this.Type = PokemonType.Fire;
            this.Height = 0.6;
            this.Weight = 8.5;
            this.HP = 39;
            this.Attack = 52;
            this.Defense = 43;
            this.SpecialAttack = 60;
            this.SpecialDefense = 50;
            this.Speed = 65;
            this.Total = 309;
            this.Name = "Hitokage";
            // Handle cases where the image is not found
            byte[] HitokageImage = Resource1.ResourceManager.GetObject("Hitokage") as byte[];
            if (HitokageImage != null)
            {
                this.image = HitokageImage;
            }
            else
            {
                // Handle cases where the image is not found
                // Option 1: Use a default image from resources
                this.image = pokemondeks.Resource1.Hitokage; // ต้องเพิ่มรูปภาพ DefaultPikachuImage ใน Resources

                // Option 2: Log an error message
                Console.WriteLine("Error: Hitokage image not found in resources.");
            }
        }
        public string Status { get; set; }
    }
}