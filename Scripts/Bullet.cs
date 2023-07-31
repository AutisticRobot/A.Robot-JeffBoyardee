using Godot;
using System;

public partial class Bullet : CharacterBody2D
{
    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";
    private Vector2 dir;

    private Vector2 pos;

    [Export]
    public int speed = 1;

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        dir = GetViewport().GetMousePosition() - Position;
        dir = dir.Normalized();
    }

    // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(float delta)
    {
        pos = Position;
        pos.x += dir.x * delta * speed;
        pos.y += dir.y * delta * speed;
        Position = pos;
    }
}