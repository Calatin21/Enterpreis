namespace Enterpreis {
    internal class Droid : Wesen {
        public Droid() {
            Random rnd = new Random();
            this.Name = "R2D" + rnd.Next(0,1000);
        }
    }
}
