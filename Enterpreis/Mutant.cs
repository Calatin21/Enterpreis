namespace Enterpreis {
    internal class Mutant : Wesen {
        public Mutant() {
            Random rnd = new Random();
            this.Name = "Mutant_" + rnd.Next(0,1000);
        }
    }
}
