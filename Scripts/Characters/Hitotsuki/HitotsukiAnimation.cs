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
		GD.Print(Animation.Frame);
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
		var Progress = Animation.FrameProgress;
		var Frame = Animation.Frame;
		if(InputDir == new Vector2(0, 1))
		{
			Animation.Animation = "Down";
			Animation.SetFrameAndProgress(Frame, Progress);
		}
		else if(InputDir == new Vector2(0, -1))
		{
			Animation.Animation = "Up";
			Animation.SetFrameAndProgress(Frame, Progress);
		}
		else if(InputDir == new Vector2(1, 0))
		{
			Animation.Animation = "Right";
			Animation.SetFrameAndProgress(Frame, Progress);
		}
		else if(InputDir == new Vector2(-1, 0))
		{
			Animation.Animation = "Left";
			Animation.SetFrameAndProgress(Frame, Progress);
		}
		else
		{
			Animation.Animation = "Down";
			Animation.SetFrameAndProgress(Frame, Progress);
		}
	}
}
