using Godot;

public partial class HitotsukiMain : CharacterBody2D
{
    // Assigning object
    public override void _Ready()
    {
        Ray = GetNode<RayCast2D>("RayCast2D");
        Animation = GetNode<AnimatedSprite2D>("Animation");
        InteractionArea = GetNode<Area2D>("Interactions/Area2D");

        //Signals
        InteractionArea.AreaEntered += OnAreaEntered;
        InteractionArea.AreaExited += OnAreaExited;
        _customSignals = GetNode<CustomSignals>("/root/CustomSignals");
    }


    public override void _PhysicsProcess(double delta)
    {
        GetInput();
        
        //Animation while playing logic
        if(moving) FrameProgressLogic();
        //lmao
    }

    public override void _Input(InputEvent @event)
    {
        //Interaction
        Interact();
    }
}

//happy new system
