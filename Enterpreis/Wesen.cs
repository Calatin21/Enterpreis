namespace Enterpreis {
    internal class Wesen : IComparable, IComparer<object> {
        public string Name { get; set; }
        int IComparable.CompareTo(object obj) {
            if (obj == null)
                return 1;
            else
                return this.Name.CompareTo(((Wesen)obj).Name);
        }
        public int Compare(object x, object y) {
            int ergebnis = 0;
            if (x.GetType == y.GetType)
                return 0;
            if (x is Mensch && !(y is Mensch))
                return 1;
            if (x is Droid && !(y is Mensch) && !(y is Droid))
                return 1;
            if (x is Mutant && !(y is Mensch) && !(y is Droid) && !(y is Mutant))
                return 1;
            if (x is Wookie && !(y is Wookie))
                return -1;
            if (y is Mensch && !(x is Mensch))
                return -1;
            if (y is Droid && !(x is Mensch) && !(x is Droid))
                return -1;
            if (y is Mutant && !(x is Mensch) && !(x is Droid) && !(x is Mutant))
                return -1;
            if (y is Wookie && !(x is Wookie))
                return 1;
            return ergebnis;
        }
    }
}