using Godot;

public partial class Killzone : Area2D
{
    [Export] private Timer _timer;
    
    public override void _Ready()
    {
        GD.Print(_timer);
        _timer.Timeout += OnRespawnTimeout;
        BodyEntered += OnBodyEntered;
    }
    
    private void OnBodyEntered(Node body)
    {
        GD.Print("you are died");
        _timer.Start();
    }

    private void OnRespawnTimeout()
    {
        GD.Print("time out");
        GetTree().ReloadCurrentScene();
    }
}