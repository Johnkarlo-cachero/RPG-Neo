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
    protected string animBoolName;

    protected Animator anim;
    protected Rigidbody2D rb;

    public EntityState(Player player, StateMachine stateMachine, string animBoolName)
    {
        this.player = player;
        this.stateMachine = stateMachine;
        this.animBoolName = animBoolName;

        anim = player.anim;
        rb = player.rb;
    }

    public virtual void Enter()
    {
        anim.SetBool(animBoolName, true);
    }

    public virtual void Update()
    {
        // we are going to run logic of the state through Player here
        Debug.Log("Updating " + animBoolName);
    }

    public virtual void Exit()
    {
        anim.SetBool(animBoolName, false);
    }
}
