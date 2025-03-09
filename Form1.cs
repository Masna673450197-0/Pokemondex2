using System.Data;

namespace pokemondeks
{
    public partial class Form1 : Form
    {
        private List<Pokemon> pokemonsList = new List<Pokemon>();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Create Pikachu object
            Pikachu pikachu = new Pikachu();
            //add Pikachu object to the list
            this.pokemonsList.Add(pikachu);
            //display the Pokemon's name and image
            this.displayPokemon(pikachu);
        }
        private void displayPokemon(Pokemon pokemon)
        {
            this.lblName.Text = pokemon.getName();
            using (var ms = new MemoryStream(pokemon.getImage()))
            {
                this.PTB1.Image = Image.FromStream(ms);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pikachu pikachu = new Pikachu(); //  √È“ßÕÁÕ∫‡®Á°µÏ Pikachu
            pikachu.Name = "Pikachu";
            pikachu.Type = Pokemon.PokemonType.Electric;
            pikachu.Status = "Normal";

            PTB1.Image = pikachu.getImageAsImage();
            PTB1.Visible = true;
            PTB1.BorderStyle = BorderStyle.FixedSingle;
            lblHeight.Text = "Height: " + pikachu.Height.ToString();
            lblWeight.Text = "Weight: " + pikachu.Weight.ToString();
            lblHP.Text = "HP: " + pikachu.HP.ToString();
            lblAttack.Text = "Attack: " + pikachu.Attack.ToString();
            lblDefense.Text = "Defense: " + pikachu.Defense.ToString();
            lblSpecialAttack.Text = "Special Attack: " + pikachu.SpecialAttack.ToString();
            lblSpecialDefense.Text = "Special Defense: " + pikachu.SpecialDefense.ToString();
            lblSpeed.Text = "Speed: " + pikachu.Speed.ToString();
            lblTotal.Text = "Total: " + pikachu.Total.ToString();
            lblName.Text = "Name: " + pikachu.Name.ToString();
            lblType.Text = "Type: " + pikachu.Type.ToString();

            lblName.Visible = true;
            lblType.Visible = true;
            lblStatus.Visible = true;
            lblHeight.Visible = true;
            lblWeight.Visible = true;
            lblHP.Visible = true;
            lblAttack.Visible = true;
            lblDefense.Visible = true;
            lblAttack.Visible = true;
            lblDefense.Visible = true;
            lblSpecialDefense.Visible = true;
            lblSpecialAttack.Visible = true;
            lblSpeed.Visible = true;
            lblTotal.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Snorlax snorlax = new Snorlax();

            PTB1.Image = snorlax.getImageAsImage();
            PTB1.Visible = true;
            PTB1.BorderStyle = BorderStyle.FixedSingle;
            lblHeight.Text = "Height: " + snorlax.Height.ToString();
            lblWeight.Text = "Weight: " + snorlax.Weight.ToString();
            lblHP.Text = "HP: " + snorlax.HP.ToString();
            lblAttack.Text = "Attack: " + snorlax.Attack.ToString();
            lblDefense.Text = "Defense: " + snorlax.Defense.ToString();
            lblSpecialAttack.Text = "Special Attack: " + snorlax.SpecialAttack.ToString();
            lblSpecialDefense.Text = "Special Defense: " + snorlax.SpecialDefense.ToString();
            lblSpeed.Text = "Speed: " + snorlax.Speed.ToString();
            lblTotal.Text = "Total: " + snorlax.Total.ToString();
            lblName.Text = "Name: " + snorlax.Name.ToString();
            lblType.Text = "Type: " + snorlax.Type.ToString();
            lblStatus.Text = snorlax.Status;

            lblName.Visible = true;
            lblType.Visible = true;
            lblStatus.Visible = true;
            lblHeight.Visible = true;
            lblWeight.Visible = true;
            lblHP.Visible = true;
            lblAttack.Visible = true;
            lblDefense.Visible = true;
            lblSpecialDefense.Visible = true;
            lblSpecialAttack.Visible = true;
            lblSpeed.Visible = true;
            lblTotal.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Lizardon lizardon = new Lizardon();
            PTB1.Image = lizardon.getImageAsImage();
            PTB1.Visible = true;
            PTB1.BorderStyle = BorderStyle.FixedSingle;
            lblHeight.Text = "Height: " + lizardon.Height.ToString();
            lblWeight.Text = "Weight: " + lizardon.Weight.ToString();
            lblHP.Text = "HP: " + lizardon.HP.ToString();
            lblAttack.Text = "Attack: " + lizardon.Attack.ToString();
            lblDefense.Text = "Defense: " + lizardon.Defense.ToString();
            lblSpecialAttack.Text = "Special Attack: " + lizardon.SpecialAttack.ToString();
            lblSpecialDefense.Text = "Special Defense: " + lizardon.SpecialDefense.ToString();
            lblSpeed.Text = "Speed: " + lizardon.Speed.ToString();
            lblTotal.Text = "Total: " + lizardon.Total.ToString();
            lblName.Text = "Name: " + lizardon.Name.ToString();
            lblType.Text = "Type: " + lizardon.Type.ToString();
            lblStatus.Text = lizardon.Status;

            lblName.Visible = true;
            lblType.Visible = true;
            lblStatus.Visible = true;
            lblHeight.Visible = true;
            lblWeight.Visible = true;
            lblHP.Visible = true;
            lblAttack.Visible = true;
            lblDefense.Visible = true;
            lblSpecialDefense.Visible = true;
            lblSpecialAttack.Visible = true;
            lblSpeed.Visible = true;
            lblTotal.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Lizardo lizardo = new Lizardo();
            PTB1.Image = lizardo.getImageAsImage();
            PTB1.Visible = true;
            PTB1.BorderStyle = BorderStyle.FixedSingle;
            lblHeight.Text = "Height: " + lizardo.Height.ToString();
            lblWeight.Text = "Weight: " + lizardo.Weight.ToString();
            lblHP.Text = "HP: " + lizardo.HP.ToString();
            lblAttack.Text = "Attack: " + lizardo.Attack.ToString();
            lblDefense.Text = "Defense: " + lizardo.Defense.ToString();
            lblSpecialAttack.Text = "Special Attack: " + lizardo.SpecialAttack.ToString();
            lblSpecialDefense.Text = "Special Defense: " + lizardo.SpecialDefense.ToString();
            lblSpeed.Text = "Speed: " + lizardo.Speed.ToString();
            lblTotal.Text = "Total: " + lizardo.Total.ToString();
            lblName.Text = "Name: " + lizardo.Name.ToString();
            lblType.Text = "Type: " + lizardo.Type.ToString();
            lblStatus.Text = lizardo.Status;

            lblName.Visible = true;
            lblType.Visible = true;
            lblStatus.Visible = true;
            lblHeight.Visible = true;
            lblWeight.Visible = true;
            lblHP.Visible = true;
            lblAttack.Visible = true;
            lblDefense.Visible = true;
            lblSpecialDefense.Visible = true;
            lblSpecialAttack.Visible = true;
            lblSpeed.Visible = true;
            lblTotal.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hitokage hitokage = new Hitokage();
            PTB1.Image = hitokage.getImageAsImage();
            PTB1.Visible = true;
            PTB1.BorderStyle = BorderStyle.FixedSingle;
            lblHeight.Text = "Height: " + hitokage.Height.ToString();
            lblWeight.Text = "Weight: " + hitokage.Weight.ToString();
            lblHP.Text = "HP: " + hitokage.HP.ToString();
            lblAttack.Text = "Attack: " + hitokage.Attack.ToString();
            lblDefense.Text = "Defense: " + hitokage.Defense.ToString();
            lblSpecialAttack.Text = "Special Attack: " + hitokage.SpecialAttack.ToString();
            lblSpecialDefense.Text = "Special Defense: " + hitokage.SpecialDefense.ToString();
            lblSpeed.Text = "Speed: " + hitokage.Speed.ToString();
            lblTotal.Text = "Total: " + hitokage.Total.ToString();
            lblName.Text = "Name: " + hitokage.Name.ToString();
            lblType.Text = "Type: " + hitokage.Type.ToString();
            lblStatus.Text = hitokage.Status;

            lblName.Visible = true;
            lblType.Visible = true;
            lblStatus.Visible = true;
            lblHeight.Visible = true;
            lblWeight.Visible = true;
            lblHP.Visible = true;
            lblAttack.Visible = true;
            lblDefense.Visible = true;
            lblSpecialDefense.Visible = true;
            lblSpecialAttack.Visible = true;
            lblSpeed.Visible = true;
            lblTotal.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Kameil kameil = new Kameil();
            PTB1.Image = kameil.getImageAsImage();
            PTB1.Visible = true;
            PTB1.BorderStyle = BorderStyle.FixedSingle;
            lblHeight.Text = "Height: " + kameil.Height.ToString();
            lblWeight.Text = "Weight: " + kameil.Weight.ToString();
            lblHP.Text = "HP: " + kameil.HP.ToString();
            lblAttack.Text = "Attack: " + kameil.Attack.ToString();
            lblDefense.Text = "Defense: " + kameil.Defense.ToString();
            lblSpecialAttack.Text = "Special Attack: " + kameil.SpecialAttack.ToString();
            lblSpecialDefense.Text = "Special Defense: " + kameil.SpecialDefense.ToString();
            lblSpeed.Text = "Speed: " + kameil.Speed.ToString();
            lblTotal.Text = "Total: " + kameil.Total.ToString();
            lblName.Text = "Name: " + kameil.Name.ToString();
            lblType.Text = "Type: " + kameil.Type.ToString();
            lblStatus.Text = kameil.Status;

            lblName.Visible = true;
            lblType.Visible = true;
            lblStatus.Visible = true;
            lblHeight.Visible = true;
            lblWeight.Visible = true;
            lblHP.Visible = true;
            lblAttack.Visible = true;
            lblDefense.Visible = true;
            lblSpecialDefense.Visible = true;
            lblSpecialAttack.Visible = true;
            lblSpeed.Visible = true;
            lblTotal.Visible = true;
        }
    }
}
