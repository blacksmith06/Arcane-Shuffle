using Godot;
using System;
using System.Diagnostics;

public partial class Level : Node2D
{

	public override void _Ready()
	{
//	Door2 area2enterd = GetNode<Door2>("door");
//		area2enterd.AreaEntered += OnAreaEntred;
	GetNode <SignalBus>("/root/SignalBus").Shoot += ThrowCard;
	
	
	}


	private void OnAreaEntred(Node body)
	{
		Debug.WriteLine($"signal receved: {body.Name} entred the area");

	}
private void ThrowCard(Vector2 directions){
	Debug.WriteLine("signal receved");
PackedScene scene = GD.Load<PackedScene>("res://Card.tscn");
		
			Area2D shotNode = (Area2D)scene.Instantiate();
		 	Node2D player = GetNode<Node2D>("player");
			Debug.WriteLine("card spawned");
			Card card =shotNode as Card;
			shotNode.Position= player.Position;
			card.basedirection=directions;
			AddChild(shotNode);
			

}
 	
	
	
}
