namespace Enterpreis {
    internal class Program {
        static void Main(string[] args) {
            Weltall galaxie = new Weltall();
            galaxie.Objekte.Add(new Raumschiff() {  Name = "Enterpreis"});
            galaxie.GetRaumschiff().Event += galaxie.GetRaumschiff().Beamen;
            galaxie.Objekte.Add(new Mensch() { Name = "Besatzung: Kirk" });
            galaxie.Objekte.Add(new Mensch() { Name = "Besatzung: Spock" });
            galaxie.Objekte.Add(new Mensch() { Name = "Besatzung: McCoy" });
            galaxie.Objekte.Add(new Mensch() { Name = "Besatzung: Scotty" });
            galaxie.GetRaumschiff().Passagiere.Add(galaxie.GetWesen("Besatzung: Kirk"));
            galaxie.GetRaumschiff().Passagiere.Add(galaxie.GetWesen("Besatzung: Spock"));
            galaxie.GetRaumschiff().Passagiere.Add(galaxie.GetWesen("Besatzung: McCoy"));
            galaxie.GetRaumschiff().Passagiere.Add(galaxie.GetWesen("Besatzung: Scotty"));
            for (int i = 0; i < 1000; i++) {
                galaxie.Objekte.Add(new Droid());
                galaxie.Objekte.Add(new Mutant());
                galaxie.Objekte.Add(new Wookie() { Name = "Chewbacca" + i});
            }
            galaxie.GetRaumschiff().durchWeltallFliegen(galaxie);
        }
    }
}