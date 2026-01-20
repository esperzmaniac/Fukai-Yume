using Godot;

public partial class Interactable : Sprite2D
{
	public Area2D InteractObject;
	public CustomSignals _customSignals;
	public bool Interact = false;
    public override void _Ready()
	{
		InteractObject = GetNode<Area2D>("Area2D");
		_customSignals = GetNode<CustomSignals>("/root/CustomSignals");
		InteractObject.AreaEntered += OnAreaEntered;
		InteractObject.AreaExited += OnAreaExited;
		_customSignals.InteractSignal += Interacted;
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
			GD.Print("worked");
		}
	}

}
