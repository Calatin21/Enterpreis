namespace Enterpreis {
    internal class Program {
        static void Main(string[] args) {
            Weltall galaxie = new Weltall();
            galaxie.Objekte.Add(new Raumschiff() {  Name = "Enterpreis"});
            galaxie.GetRaumschiff().Event += galaxie.GetRaumschiff().Beamen;
            galaxie.Objekte.Add(new Mensch() { Name = "Kirk" });
            galaxie.Objekte.Add(new Mensch() { Name = "Spock" });
            galaxie.Objekte.Add(new Mensch() { Name = "McCoy" });
            galaxie.Objekte.Add(new Mensch() { Name = "Scotty" });
            galaxie.GetRaumschiff().Passagiere.Add(galaxie.GetWesen("Kirk"));
            galaxie.GetRaumschiff().Passagiere.Add(galaxie.GetWesen("Spock"));
            galaxie.GetRaumschiff().Passagiere.Add(galaxie.GetWesen("McCoy"));
            galaxie.GetRaumschiff().Passagiere.Add(galaxie.GetWesen("Scotty"));
            for (int i = 0; i < 10; i++) {
                galaxie.Objekte.Add(new Droid());
                galaxie.Objekte.Add(new Mutant());
                galaxie.Objekte.Add(new Wookie() { Name = "Chewbacca" + i});
            }
            galaxie.GetRaumschiff().durchWeltallFliegen(galaxie);
            galaxie.GetRaumschiff().WerIstAnBord();

        }
    }
}