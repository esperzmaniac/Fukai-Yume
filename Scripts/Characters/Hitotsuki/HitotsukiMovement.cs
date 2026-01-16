using Godot;

public partial class HitotsukiMain
{
	[Export] public int TileSize;

	public RayCast2D Ray;
	public bool moving = false;
	public Vector2 InputDir;

	public void GetInput()
	{
		if(moving) return;

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
			InputDir = new Vector2(-1, 0);
		}
		else if(Input.IsActionPressed("ui_right"))
		{
			InputDir = new Vector2(1, 0);
		}
		if(InputDir != Vector2.Zero)
		{
			TryMove();						
		}
	}

	public void TryMove()
	{
		Ray.TargetPosition = InputDir * TileSize;
		Ray.ForceRaycastUpdate();

		if(Ray.IsColliding()) return;

		OnMove();
	}

	public void OnMove()
	{
		moving = true;

		var Tween = CreateTween();
		Tween.TweenProperty(this, "position", Position + InputDir * TileSize, 0.2);
		Tween.TweenCallback(Callable.From(FinishMove));
	}

	public void FinishMove()
	{
		moving = false;
	}
}
