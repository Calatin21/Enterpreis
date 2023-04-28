namespace Enterpreis {
    internal class Weltall {
        public List<object> Objekte { get; set; } = new List<object>();
        public Raumschiff GetRaumschiff() {
            Raumschiff ergebnis = null;
            foreach (Raumschiff item in Objekte) {
                    ergebnis = item;
                    break;
            }
            return ergebnis;
        }
        public Wesen GetWesen(string name) {
            Wesen ergebnis = null;
            foreach (object item in Objekte) {
                if (item is Wesen) {
                    if (((Wesen)item).Name == name) {
                        ergebnis = (Wesen)item;
                        break;
                    }
                }
            }
            return ergebnis;
        }
        public Wesen GetDroid() {
            Wesen ergebnis = null;
            foreach(object item in Objekte) { 
                if (item is Droid) {
                    ergebnis = item as Droid;
                }
            }
            return ergebnis;
        }
        public Wesen GetMutant() {
            Wesen ergebnis = null;
            foreach (object item in Objekte) {
                if (item is Mutant) {
                    ergebnis = item as Mutant;
                }
            }
            return ergebnis;
        }
        public Wesen GetWookie() {
            Wesen ergebnis = null;
            foreach (object item in Objekte) {
                if (item is Wookie) {
                    ergebnis = item as Wookie;
                }
            }
            return ergebnis;
        }
    }
}
