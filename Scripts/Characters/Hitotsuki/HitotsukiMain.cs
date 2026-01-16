using Godot;

public partial class HitotsukiMain : CharacterBody2D
{
    // Assigning objects
    public override void _Ready()
    {
        Ray = GetNode<RayCast2D>("RayCast2D");
    }


    public override void _PhysicsProcess(double delta)
    {
        GetInput();

        GD.Print(InputDir);
    }

}
