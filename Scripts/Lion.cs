using Godot;
using System;

public class Lion : Sprite
{
    [Export]
    public float range = 100;
    [Export]
    public int speed = 10;
    ai lionAI = new ai(Lion);
    
    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
    }

public void mainLoop()
{

}

}
