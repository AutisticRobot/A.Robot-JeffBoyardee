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
private Vector2 pos;

public override void _Ready()
{
    jeff = GetParent().GetNode<AnimatedSprite>("jẽff");
    jeff.Position = new Vector2(1000,400);
    pos = jeff.Position;
    
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
    pos = jeff.Position;

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

    pos += mov.Normalized() * speed;
    pos.y = Mathf.Clamp(pos.y, 128, 952);
    pos.x = Mathf.Clamp(pos.x, 64, 1855);

    jeff.Position = pos;

}

}
