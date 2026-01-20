using Godot;

public partial class Interactable : Sprite2D
{
	public Area2D InteractObject;
	public CustomSignals _customSignals;
	public CharacterBody2D Hitotsuki;
	public HitotsukiMain HitoMain;
	public AudioStreamPlayer Burger;
	public bool Interact = false;
    public override void _Ready()
	{
		InteractObject = GetNode<Area2D>("Area2D");
		_customSignals = GetNode<CustomSignals>("/root/CustomSignals");
		InteractObject.AreaEntered += OnAreaEntered;
		InteractObject.AreaExited += OnAreaExited;
		_customSignals.InteractSignal += Interacted;
		Hitotsuki = GetNode<CharacterBody2D>("/root/Test Level/Hitotsuki");
		HitoMain = GetNode<HitotsukiMain>("/root/Test Level/Hitotsuki");
		Burger = GetNode<AudioStreamPlayer>("CrunchyBite");
	}
	
	public void OnAreaEntered(Area2D area)
	{
		Interact = true;

	}
	public void OnAreaExited(Area2D area)
	{
		Interact = false;
	}
	public void Interacted()
	{
		if (Interact)
		{
			HitoMain.moving = true;
			HitoMain.InputDir = new Vector2(1, 0);
			HitoMain.Animation.Animation = "Right";
			Burger.Play();
			var currentPos = Hitotsuki.Position;
			var Tween = CreateTween();
			Tween.SetTrans(Tween.TransitionType.Sine);
			Tween.TweenProperty(Hitotsuki, "position", Hitotsuki.Position + new Vector2(32, 0), 0.2);
			this.Visible = false;
			Tween.TweenProperty(Hitotsuki, "position", currentPos, 0.2);
			HitoMain.moving = false;
		}
	}

}
