namespace ConsoleApp2;

class B : A
{
    private int _d = 15;

    public int C2
    {
        get
        {
            int result = _d; 
            return result > 20 ? result : 0; 
        }
    }

 
    public B() : base() { }

    public B(int dValue) : base()
    {
        _d = dValue;
    }
}