using Godot;
using System;

public partial class Lion : Sprite2D
{
    [Export]
    public float range = 100;

    [Export]
    public int speed = 10;

    private String state = "idle";

    [Export]
    public Vector2 Target;

    private int idleDur = 60;

    private ai lionAI = new ai();//simply passing in each varrible individualy until i Find a better sulution( even if it is only in other games)

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
    }

    public override void _Process(float delta)
    {
        lionAI.pos = Position;
        mainLoop(delta);
    }

    public void mainLoop(float delta)
    {
        switch (state)
        {
            case "idle":
                idleDur--;
                if (idleDur <= 0)
                {
                    Target = lionAI.findValidPos(range);
                    state = "walk";
                }
                break;

            case "walk":
                this.Position += lionAI.walkToVec(Target).Normalized() * delta * speed;
                if (lionAI.checkOverlap(this.Position, Target, new Vector2(speed, speed)))
                {
                    idleDur = 60;
                    state = "idle";
                }
                break;
        }
    }
}