namespace task1;

public class Context
{ 
    private State _state;
    public Context(State state) 
    { 
        State = state;
    }

    public State State
    { 
        get { return _state; } 
        set 
        { 
            _state = value; 
            Console.WriteLine($"Текущее состояние: {_state.GetType().Name}");
        }
    }
    public void Request() 
    { 
        _state.Handle(this);
    }
}