namespace Enterpreis {
    internal class Raumschiff {
        public event EventHandler<BeamEventArgs> Event;
        public string Name { get; set; }
        public int Geschwindigkeit { get; set; }
        public List<Wesen> Passagiere { get; set; } = new List<Wesen>();
        public void durchWeltallFliegen(Weltall all) {
            Random rnd = new Random();
            BeamEventArgs bea = new BeamEventArgs() { Alle = all };
            Console.WriteLine("Der Flug der {0} beginnt an Bord sind:", this.Name);
            this.WerIstAnBord();
            for (int i = 0; i < 100; i++) {
                this.Geschwindigkeit = rnd.Next(0, 3001);
                if (Geschwindigkeit < 100) {
                    bea.Lebensform = all.GetDroid();
                    Event(this, bea);
                }
                else if (Geschwindigkeit > 1000 && Geschwindigkeit < 1200) {
                    bea.Lebensform = all.GetMutant();
                    Event(this, bea);
                }
                else if (Geschwindigkeit == 3000) {
                    bea.Lebensform = all.GetWookie();
                    Event(this, bea);
                }
                Thread.Sleep(50);
            }
            this.WerIstAnBord();
        }
        public void WerIstAnBord() {
            Passagiere.Sort();
            Console.WriteLine("Passagiere Anzahl: {0}", Passagiere.Count());
            foreach (Wesen item in Passagiere) {
                Console.WriteLine(item.Name);
            }
        }
        public void Beamen(object source, BeamEventArgs bea) {
            this.Passagiere.Add(bea.Lebensform);
            bea.Alle.Objekte.Remove(bea.Lebensform);
            Console.WriteLine("Bei Geschwindigkeit: {0} Lebensform vom Typ {1} an Bord gebeamt.", Geschwindigkeit, bea.Lebensform.GetType());
        }
    }
}


