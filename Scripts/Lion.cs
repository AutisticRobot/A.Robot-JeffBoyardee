using Godot;
using System;

public class Lion : Sprite
{
    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        
    }

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }
private void ai(float range)
{
    Vector2 target = new Vector2(0,0);
    target.x = (float)GD.RandRange(-1,1);
    target.y = (float)GD.RandRange(-1,1);
    float distance = (float)GD.RandRange(0,range);
    target * distance;
}
}
