using Godot;
using System;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;




public partial class Movement : CharacterBody2D
{
	[Export]
	public int Speed { get; set; } = 500;

	/*public void GetInput()
	{

		Vector2 inputDirection = Input.GetVector("left", "right", "up", "down");
		Velocity = inputDirection * Speed ;
	}*/

	public override void _PhysicsProcess(double delta)
	{
		
		//GetInput();
	Vector2 inputDirection = Input.GetVector("left", "right", "up", "down");
		Velocity = inputDirection * Speed  ;
	Vector2 shootDirections = Input.GetVector("shoot down", "shoot up","shoot right", "shoot left");
	
		MoveAndSlide();
	}
}

	
