namespace TestGeneric.TiposGenericos
{
    public class Operaciones<T>
    {
        public static void Intercambio(ref T a, ref T b)
        {
            T t = a;
            a = b;
            b = t;
        }
    }
}
