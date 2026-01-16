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
			//Animation Direction Logic
			AnimationDirection();
			TryMove();						
		}
		//Animation end and steps logic
		else if(Animation.IsPlaying())
		{
			AnimationEnd();	
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
		
		//Steps Counter
		steps = (steps +1) % 2;

		var Tween = CreateTween();
		Tween.TweenProperty(this, "position", Position + InputDir * TileSize, 0.3);
		Tween.TweenCallback(Callable.From(FinishMove));
		
		//Animation Start Logic
		AnimationStart();
	}

	public void FinishMove()
	{
		moving = false;
	}
}
