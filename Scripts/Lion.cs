using Godot;
using System;

public class Lion : Sprite
{
    [Export]
    public float range = 100;
    [Export]
    public int speed = 10;
    ai lionAI = new ai();
    
    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        Vector2 validPos;
        validPos = lionAI.findValidPos(Position, range);
    }

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }

}
