using Godot;

public partial class HitotsukiMain : CharacterBody2D
{
    public override void _PhysicsProcess(double delta)
    {
        GetInput();

        GD.Print(InputDir);
    }

}
