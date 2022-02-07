namespace refreshment_vs
{
    class Program
    {
        public static int sumInt( int a, int b)
        {
            return a + b;
        }
        public static int sumInt( string a, string b)
        {
            int _a, _b;
            if(!Int32.TryParse(a, out _a))
                _a = 0;
            if(!Int32.TryParse(b, out _b))
                _b = 0;
            return _a + _b;
        }
        public static int sumInt(string a, int b)
        {
            int _a;
            if (!Int32.TryParse(a, out _a))
                _a = 0;
            return _a + b;

        }
        public static int sumInt(int a, string b)
        {
            return sumInt(b,a);
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine(sumInt( 1 , 2 )); 
            Console.WriteLine(sumInt("3","4"));
            Console.WriteLine(sumInt("5", 6 ));
            Console.WriteLine(sumInt( 7 ,"8"));
        }
    }
    
}
