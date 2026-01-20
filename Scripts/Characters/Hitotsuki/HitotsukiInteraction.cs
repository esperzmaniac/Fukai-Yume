using Godot;

public partial class HitotsukiMain
{
	public CustomSignals _customSignals;
	public Area2D InteractionArea;
	public bool CanInteract = false;
	public void OnAreaEntered(Area2D area)
	{
		CanInteract = true;
	}
	public void OnAreaExited(Area2D area)
	{
		CanInteract = false;
	}

	//interact logic
    public void Interact()
	{
		if (CanInteract)
		{
			if (Input.IsActionJustPressed("Interact"))
			{
				_customSignals.EmitInteract();
			}
		}
	}
}
