namespace task1
{
    class TestClass : Ix, Iy, Iz
    {
        private int w;
        public TestClass(int w)
        {
            this.w = w;
        }
        // Ix implementation
        public void IxF0(int w)
        {
            Console.WriteLine($"IxF0: 7*w = {7 * w}");
        }
        public void IxF1()
        {
            Console.WriteLine($"IxF1: w*8 = {w * 8}");
        }
        // Iy implementation (неявная)
        public void F0(int w)
        {
            Console.WriteLine($"Iy.F0: 6+w = {6 + w}");
        }
        public void F1()
        {
            Console.WriteLine($"Iy.F1: w*8 = {w * 8}");
        }
        // Iz implementation (явная)
        void Iz.F0(int w)
        {
            Console.WriteLine($"Iz.F0: 6+w = {6 + w}");
        }
        void Iz.F1()
        {
            Console.WriteLine($"Iz.F1: 6+w = {6 + w}");
        }
    }
}
