namespace Enterpreis {
    internal class Droid : Wesen {
        private Random rnd = new Random();
        private List<int> zahlen = new List<int>();
        public Droid() {
            int zahl;
            do {
                zahl = rnd.Next(0, 1000);
            } while ((zahlen.Contains(zahl)));
            this.Name = "R2D" + zahl;
            zahlen.Add(zahl);
        }
    }
}
