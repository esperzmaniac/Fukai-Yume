using Godot;

public partial class HitotsukiMain
{
	public int steps = 0;
	public AnimatedSprite2D Animation;
	public void AnimationStart()
	{
		if(!Animation.IsPlaying())
		{
			Animation.Play();
		}
	}

	public void AnimationEnd()
	{
		Animation.Stop();
		AnimationLogic();

	}

	public void AnimationLogic()
	{
		if(steps == 1)
		{
			Animation.Frame = 0;
		}
		else
		{
			Animation.Frame = 2;
		}
	}

	public void AnimationDirection()
	{
		if(InputDir == new Vector2(0, 1))
		{
			Animation.Animation = "Down";
		}
		else if(InputDir == new Vector2(0, -1))
		{
			Animation.Animation = "Up";
		}
		else if(InputDir == new Vector2(1, 0))
		{
			Animation.Animation = "Right";
		}
		else if(InputDir == new Vector2(-1, 0))
		{
			Animation.Animation = "Left";
		}
	}
}
