namespace Generyki
{
    
       


    public static class ZnajdzWiekszy
    {
        public static T znajdzWiekszy<T>(T pierwszy, T drugi) where T : IComparable<T>
        {
            int wynikPorownania = pierwszy.CompareTo(drugi);
            if (wynikPorownania > 0)
                return pierwszy;
            else if (wynikPorownania < 0)
                return drugi;
            else
                return pierwszy;
        }
    }

    public class Student : IComparable<Student>
    {
        public string Nazwisko { get; set; }
        public double Ocena { get; set; }

       
        public int CompareTo(Student other)
        {
            if (other == null) return 1; 

            return this.Ocena.CompareTo(other.Ocena);
        }
    }



    public class Regał<T>
    {
        public T Półka1 { get; set; } = default;
        public T Półka2 { get; set; } = default;
        public T Półka3 { get; set; } = default;

        public override string ToString()
        {
            return $"Półka1: {Półka1}, Półka2: {Półka2}, Półka3: {Półka3}";
        }

        public void WstawNaWolnąPółkę(T item)
        {
            if (EqualityComparer<T>.Default.Equals(Półka1, default))
            {
                Półka1 = item;
            }
            else if (EqualityComparer<T>.Default.Equals(Półka2, default))
            {
                Półka2 = item;
            }
            else if (EqualityComparer<T>.Default.Equals(Półka3, default))
            {
                Półka3 = item;
            }
            else
            {
                throw new InvalidOperationException("Brak wolnej półki");
            }
        }

        public T WolnaPółka
        {
            set
            {
                if (EqualityComparer<T>.Default.Equals(Półka1, default))
                {
                    Półka1 = value;
                }
                else if (EqualityComparer<T>.Default.Equals(Półka2, default))
                {
                    Półka2 = value;
                }
                else if (EqualityComparer<T>.Default.Equals(Półka3, default))
                {
                    Półka3 = value;
                }
                else
                {
                    throw new InvalidOperationException("Brak wolnej półki");
                }
            }
        }
    }

}
