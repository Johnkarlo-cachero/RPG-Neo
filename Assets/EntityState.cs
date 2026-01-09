using UnityEngine;

/**
 * The base class for all states.
 * containing shared functionality
 * (like timers, animation triggers, etc.) that player needs
 */
public abstract class EntityState
{
    protected Player player;
    protected StateMachine stateMachine;
    protected string stateName;

    public EntityState(Player player, StateMachine stateMachine, string stateName)
    {
        this.player = player;
        this.stateMachine = stateMachine;
        this.stateName = stateName;
    }

    public virtual void Enter()
    {
        // everytime state will be changed, Enter will be called
        Debug.Log("Entering " + stateName);
    }

    public virtual void Update()
    {
        // we are going to run logic of the state through Player here
        Debug.Log("Updating " + stateName);
    }

    public virtual void Exit()
    {
        // This will be called, everytime we exit state and change to a new one
        Debug.Log("Exiting " + stateName);
    }
}
