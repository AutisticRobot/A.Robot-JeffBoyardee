using Godot;
using System;

public class jẽff : AnimatedSprite
{

[Export]
public int speed;

[Export]
public bool paused = false;


//public AnimatedSprite jẽff;
public Vector2 screen;

public override void _Ready()
{
    
}


public override void _Process(float delta)
{
    if(!paused)
    {
        //move code
        Vector2 mov = new Vector2(0,0);
    }
}


}
