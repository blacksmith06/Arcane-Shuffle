using Godot;
using System;

public partial class Card : Area2D
{

public Vector2 basedirection ;
	public override void _PhysicsProcess(double delta){

Position += basedirection; 
	}

 


}
