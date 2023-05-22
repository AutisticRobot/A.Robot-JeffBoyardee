using Godot;
using System;

public class Lion : Sprite
{


[Export]
public float range = 100;
[Export]
public int speed = 10;


private String state = "idle";
private Vector2 Target;


ai lionAI = new ai(Lion);
    
// Called when the node enters the scene tree for the first time.
public override void _Ready()
{
}

public override void _Process(float delta)
{
    mainLoop(delta);
}

public void mainLoop(float delta)
{
    switch (state)
    {
        case "idle":
            Target = lionAI.findValidPos(range);
            state = "walk"
        break;

        case "walk":
            this.Position += lionAI.walkToVel(Target) * delta * speed;
        break;
    }
}



}
