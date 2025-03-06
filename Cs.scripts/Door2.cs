using Godot;
using System;
using System.Diagnostics;

public partial class Door2 : Area2D
{
	[Signal]
	public delegate void DoorEventHandler(Node body);

	private void OnBodyEntered(Node body){

		Debug.WriteLine($"Bodyentered :{body.Name}");
		EmitSignal(SignalName.AreaEntered, body);
	}
	public override void _Ready()
	{
		BodyEntered += OnBodyEntered; 
	}


}
