using Godot;

public partial class HitotsukiMain
{
	public int steps = 0;
	public AnimatedSprite2D Animation;
	public Vector2 MoveStartPos;
	public Vector2 MoveEndPos;
	public bool leftFoot = true;
	public void AnimationStart()
	{
		MoveStartPos = Position;
		MoveEndPos = Position + InputDir * TileSize;

		Animation.Frame = 0;
	}

	public void FrameProgressLogic()
	{
		float TotalDistance = MoveStartPos.DistanceTo(MoveEndPos);
        float currentDistance = MoveStartPos.DistanceTo(Position);

        float Progress = currentDistance / TotalDistance;

        if (Progress < 0.33f)
        {
            Animation.Frame = 0;
        }
        else if (Progress < 0.80f)
        {
            Animation.Frame = leftFoot ? 1 : 2;
        }
        else
        {
            Animation.Frame = 0;
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
		else
		{
			Animation.Animation = "Down";
		}
	}
}
