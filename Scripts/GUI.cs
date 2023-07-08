using Godot;
using System;

public class GUI : CanvasLayer
{

    public Control pauseMenu;
    public Button burger;
    public AnimatedSprite jeff;


    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        pauseMenu = GetNode<Control>("PauseMenu");
        burger = GetNode<Button>("MenuHamburger");
        jeff = GetParent().GetNode<AnimatedSprite>("jẽff");
    }

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }

    public void _on_MenuHamburger_pressed()
    {
        pauseMenu.Show();
        burger.Hide();
        jeff.paused = true;
    }
}
