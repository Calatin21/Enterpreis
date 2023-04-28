namespace Enterpreis {
    internal class Wesen : IComparable {
        public string Name { get; set; }
        int IComparable.CompareTo(object? obj) {
            if (obj == null)
                return 1;
            else
                return this.Name.CompareTo(((Wesen)obj).Name);
        }
    }
}