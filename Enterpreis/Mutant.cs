namespace Enterpreis {
    internal class Mutant : Wesen {
        private Random rnd = new Random();
        private List<int> zahlen = new List<int>();
        public Mutant() {
            int zahl;
            do {
                zahl = rnd.Next(0, 1000);
            } while ((zahlen.Contains(zahl)));
            this.Name = "Mutant_" + zahl;
            zahlen.Add(zahl);
        }
    }
}
