using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokemondeks
{
     public  class  Lizardo : Pokemon   
    {
        public Lizardo()
        {
            this.Type = PokemonType.Fire;
            this.Height = 2.1;
            this.Weight = 460.0;
            this.HP = 78;
            this.Attack = 84;
            this.Defense = 78;
            this.SpecialAttack = 109;
            this.SpecialDefense = 85;
            this.Speed = 100;
            this.Total = 534;
            this.Name = "Lizardo";
            // Handle cases where the image is not found
            byte[] LizardoImage = Resource1.ResourceManager.GetObject("Lizardo") as byte[];
            if (LizardoImage != null)
            {
                this.image = LizardoImage;
            }
            else
            {
                // Handle cases where the image is not found
                // Option 1: Use a default image from resources
                this.image = pokemondeks.Resource1.Lizardo; // ต้องเพิ่มรูปภาพ DefaultPikachuImage ใน Resources

                // Option 2: Log an error message
                Console.WriteLine("Error: Lizardo image not found in resources.");
            }
        }
        public string Status { get; set; }
    }
}