using Godot;

public partial class HitotsukiMain
{
	public Vector2 InputDir;
	public void GetInput()
	{
		InputDir = Vector2.Zero;
		if (Input.IsActionPressed("ui_up"))
		{
			InputDir = new Vector2(0, -1);
		}
		else if(Input.IsActionPressed("ui_down"))
		{
			InputDir = new Vector2(0, 1);
		}
		else if(Input.IsActionPressed("ui_left"))
		{
			InputDir = new Vector2(1, 0);
		}
		else if(Input.IsActionPressed("ui_right"))
		{
			InputDir = new Vector2(-1, 0);
		}
	}
}
