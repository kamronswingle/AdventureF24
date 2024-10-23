namespace AdventureF24;

public class State
{
    public bool IsActive { get; private set; }

    public StateType Type;
    private List<Action> methodsToCallOnActivate = new List<Action>();
    private List<Action> methodsToCallOnDeactivate = new List<Action>();
    
    public State(StateType type)
    {
        Type = type;
        IsActive = false;
        // if (type == StateType.Exploring) {...}
    }

    public void Activate()
    {
        IsActive = true;
        foreach (Action action in methodsToCallOnActivate)
        {
            action.Invoke();
        }
    }

    public void Deactivate()
    {
        IsActive = false;
        foreach (Action action in methodsToCallOnDeactivate)
        {
            action.Invoke();
        }
    }

    public void AddToActivateCallList(Action action)
    {
        methodsToCallOnActivate.Add(action);
    }
    
}