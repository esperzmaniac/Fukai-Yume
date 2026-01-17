using Godot;

public partial class HitotsukiMain : CharacterBody2D
{
    // Assigning objects
    public override void _Ready()
    {
        Ray = GetNode<RayCast2D>("RayCast2D");
        Animation = GetNode<AnimatedSprite2D>("Animation");
        InteractionArea = GetNode<Area2D>("Interactions/Area2D");

        //Signals
        InteractionArea.AreaEntered += OnAreaEntered;
        InteractionArea.AreaExited += OnAreaExited;
    }


    public override void _PhysicsProcess(double delta)
    {
        GetInput();

        //Animation end and steps logic
		if(Animation.IsPlaying() && InputDir == Vector2.Zero)
		{
			AnimationEnd();	
		}
    }

}
