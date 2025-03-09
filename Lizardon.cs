using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokemondeks
{
    public class Lizardon : Pokemon
    {
        public Lizardon()
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
            this.Name = "Lizardon";        
            byte[] LizardonImage = Resource1.ResourceManager.GetObject("Lizardon") as byte[];
            if (LizardonImage != null)
            {
                this.image = LizardonImage;
            }
            else
            {
               
                this.image = pokemondeks.Resource1.Lizardon; 

                Console.WriteLine("Error: Lizardon image not found in resources.");
            }
        }
        public string Status { get; set; }
    }
}