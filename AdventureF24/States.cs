namespace AdventureF24;

public enum StateType
{
    Exploring, // number 0 for the computer
    Combat, // number 1
    Conversation, // number 2
    Snoozing
}
public static class States
{
    private static State currentState;
    private static Dictionary<StateType, State> states = new Dictionary<StateType, State>();

    public static void Initialize()
    {
        // create all the states
        AddState(StateType.Exploring);
        AddState(StateType.Combat);
        AddState(StateType.Conversation);
        currentState = states[StateType.Exploring]; // Current state by default is exploring
    }

    public static StateType GetCurrentState()
    {
        return currentState.Type;
    }

    public static void AddState(StateType type)
    {
        State state = new State(type);
        if (!states.ContainsKey(state.Type))
        {
            states[state.Type] = state;
        }
    }

    public static void ChangeState(StateType type)
    {
        if (!states.ContainsKey(type))
        {
            IO.Error($"No state of type {type} was found.");
            return;
        }
        
        // deactivate the current state
        // set the new state as current
        // activate the new state
        currentState.Deactivate();
        currentState = states[type];
        currentState.Activate();
    }
}