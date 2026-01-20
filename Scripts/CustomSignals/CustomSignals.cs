using Godot;

public partial class CustomSignals : Node
{
	[Signal]
	public delegate void InteractSignalEventHandler(); 

	public void EmitInteract()
	{
		EmitSignal(SignalName.InteractSignal);
	}
}
