using Godot;
using System;

public partial class jẽff : AnimatedSprite2D
{
    [Export]
    public int speed;

    [Export]
    public PackedScene bullet;

    public AnimatedSprite2D jeff;
    public Vector2 screen;
    private Vector2 pos;

    public override void _Ready()
    {
        jeff = GetParent().GetNode<AnimatedSprite2D>("jẽff");
        jeff.Position = new Vector2(1000, 400);
        pos = jeff.Position;
    }

    public override void _Process(float delta)
    {
        if (!Global.paused)
        {
            movePlayer(delta);
        }
    }

    private void movePlayer(float delta)
    {
        if (Input.IsActionPressed("click"))
        {
            shoot();
        }
        pos = jeff.Position;

        Vector2 mov = new Vector2(0,0);

        if (Input.IsActionPressed("up"))
        {
            mov.y -= 1;
        }
        if (Input.IsActionPressed("down"))
        {
            mov.y += 1;
        }
        if (Input.IsActionPressed("left"))
        {
            mov.x -= 1;
        }
        if (Input.IsActionPressed("right"))
        {
            mov.x += 1;
        }

        pos += mov.Normalized() * speed * delta;
        pos.y = Mathf.Clamp(pos.y, 128, 952);
        pos.x = Mathf.Clamp(pos.x, 64, 1855);

        jeff.Position = pos;
    }

    private void shoot()
    {
        CharacterBody2D shot = (CharacterBody2D)bullet.Instance();
        shot.Position = GetNode<Sprite2D>("Gun").GlobalPosition;
        GetParent().AddChild(shot);
    }
}