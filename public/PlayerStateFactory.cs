public class PlayerStateFactory
{
    // Set context to type PlayerStateMachine
    PlayerStateMachine _context;

    // constructor method with currentContext of type PlayerStateMachine
    public PlayerStateFactory(PlayerStateMachine currentContext)
    {
        _context = currentContext;
    }

    // call constructor methods of the following concrete states, passing in PlayerStateMachine as context and this PlayerStateFactory class
    // To Do: find a way to do this without repeating code and creating a new instance of each concrete class everytime the state is switchsed (avoid garbage collection)
    public PlayerBaseState Idle() {
        return new PlayerIdleState(_context, this);
    }

    public PlayerBaseState Walk()
    {
        return new PlayerWalkState(_context, this);
    }

    public PlayerBaseState Roll()
    {
        return new PlayerRollState(_context, this);
    }

    public PlayerBaseState Grounded()
    {
        return new PlayerGroundedState(_context, this);
    }

    public PlayerBaseState Jump()
    {
        return new PlayerJumpState(_context, this);
    }

    public PlayerBaseState Falling()
    {
        return new PlayerFallingState(_context, this);
    }

    public PlayerBaseState WallSlide()
    {
        return new PlayerWallSlideState(_context, this);
    }

    public PlayerBaseState Dash()
    {
        return new PlayerDashState(_context, this);
    }

    public PlayerBaseState Airborne()
    {
        return new PlayerAirborneState(_context, this);
    }

    public PlayerBaseState Attack()
    {
        return new PlayerAttackState(_context, this);
    }


}
