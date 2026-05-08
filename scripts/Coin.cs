using Godot;
using System;

public partial class Coin : Area2D
{
    public override void _Ready()
    {
        // 推荐方式：在代码中连接信号
        BodyEntered += OnBodyEntered;
    }
    
    private void OnBodyEntered(Node body)
    {
        GD.Print("entered: " + body.Name);
        QueueFree();
    }
}