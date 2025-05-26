namespace task1;

public class StateA : State
{ 
    public override void Handle(Context context) 
    { 
        Console.WriteLine("Переход из StateA в StateB"); 
        context.State = new StateB();
    }
}