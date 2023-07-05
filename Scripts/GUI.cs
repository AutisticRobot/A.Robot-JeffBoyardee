using Godot;
using System;

private node pause;
private Sprite burger;

public class GUI : CanvasLayer
{
    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        pause = GetNode<node>("PauseMenu");
        burger = GetNode<Sprite>("MenuHamburger");
    }

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }
}
