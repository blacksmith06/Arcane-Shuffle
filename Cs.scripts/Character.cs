using Godot;
using System;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;




public partial class Character : CharacterBody2D
{
	private Vector2 Shootvector; 
	private SignalBus _Signalbus; 

	[Export]
	private int Speed { get; set; } = 500;

	[Export]
	private int Health { get; set; } = 40;
	
	[Export]
private int ShootSpeed { get; set; } = 600;
	 

	public override void _Ready()
	{
		_Signalbus= GetNode<SignalBus>("/root/SignalBus");
		PackedScene scene = GD.Load<PackedScene>("res://Card.tscn");
		
		
	}


	public override void _PhysicsProcess(double delta)
	{
		
	
	Vector2 CharMovementDirection = Input.GetVector("left", "right", "up", "down");
		Velocity = CharMovementDirection * Speed  ;
	Vector2 shootDirections = Input.GetVector("shoot left", "shoot right","shoot up", "shoot down");
		Shootvector = shootDirections * ShootSpeed *(float)delta;
	
	if (Shootvector != Vector2.Zero ){
		Debug.WriteLine($"character is shooting{Shootvector}" );
		_Signalbus.EmitSignal(nameof(_Signalbus.Shoot),Shootvector);
	
	}
		MoveAndSlide();
	
	}
	
}

	
