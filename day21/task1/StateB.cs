namespace task1;

public class StateB : State
{ 
    public override void Handle(Context context) 
    { 
        Console.WriteLine("Переход из StateB в StateA"); 
        context.State = new StateA();
    }
}