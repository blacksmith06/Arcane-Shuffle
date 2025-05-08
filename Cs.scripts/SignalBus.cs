using Godot;
using System;

public partial class SignalBus : Node
{
	[Signal]
	public delegate void ShootEventHandler(Vector2 Directions);


	


}
