using Godot;

public partial class HitotsukiMain
{
	public Area2D InteractionArea;

	public void OnAreaEntered(Area2D area)
	{
		GD.Print("Area Entered");
	}
	public void OnAreaExited(Area2D area)
	{
		GD.Print("Area Exitted");
	}
}
