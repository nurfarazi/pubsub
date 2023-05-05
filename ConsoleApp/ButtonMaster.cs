namespace ConsoleApp;

public class ButtonMaster
{
    public event EventHandler? ButtonPressed;
    
    public void OnButtonPressed(char keyPressed)
    {
        Console.WriteLine($"Button pressed: {keyPressed}");
        
        ButtonPressed?.Invoke(this, EventArgs.Empty);
    }
}