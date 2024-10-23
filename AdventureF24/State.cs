namespace AdventureF24;

public class State
{
    public bool IsActive { get; private set; }

    public string StateType;
    private List<Action> methodsToCallOnActivate = new List<Action>();
    private List<Action> methodsToCallOnDeactivate = new List<Action>();
    
    public State(string stateType)
    {
        StateType = stateType;
        IsActive = false;
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