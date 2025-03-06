using Godot;
using System;
using System.Diagnostics;

public partial class Level : Node2D
{
	
	public override void _Ready()
	{
	Door2 area2enterd = GetNode<Door2>("door");
		area2enterd.AreaEntered += OnAreaEntred;
	}

	private void OnAreaEntred(Node body)
	{
		Debug.WriteLine($"signal receved: {body.Name} entred the area");
	}
}
