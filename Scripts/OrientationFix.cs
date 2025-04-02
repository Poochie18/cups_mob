using Godot;

public partial class OrientationFix : Node
{
    public override void _EnterTree()
    {
        if (OS.GetName() == "Android" || OS.GetName() == "iOS")
        {
            DisplayServer.ScreenSetOrientation(DisplayServer.ScreenOrientation.Portrait);
        }
    }
}