namespace task1;

public class A
{
    public int a;
    public int b;

    public A(int a, int b)
    {
        this.a = a;
        this.b = b;
    }
    
    public int equation()
    {
        return ((3*b-(2/a^2))/4);
    }
    
    public double square()
    {
        return Math.Pow((double)a,(double)b);
    }
}