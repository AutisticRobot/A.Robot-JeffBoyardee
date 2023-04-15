using Godot;
using System;

public class jẽff : AnimatedSprite
{

[Export]
public int speed;

[Export]
public bool paused = false;


public AnimatedSprite jeff;
public Vector2 screen;

public override void _Ready()
{
    jeff = GetParent().GetNode<AnimatedSprite>("jẽff");
    jeff.Position = new Vector2(1000,400);
    
}


public override void _Process(float delta)
{
    if(!paused)
    {
        movePlayer(delta);
    }
}

private void movePlayer(float delta)
{
    Vector2 mov = new Vector2(0,0);

    if(Input.IsActionPressed("up")){
        mov.y -= delta;
    }
    if(Input.IsActionPressed("down")){
        mov.y += delta;
    }
    if(Input.IsActionPressed("left")){
        mov.x -= delta;
    }
    if(Input.IsActionPressed("right")){
        mov.x += delta;
    }

    jeff.Position += mov.Normalized() * speed;

}

}
