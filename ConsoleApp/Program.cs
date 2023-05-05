using ConsoleApp;

Console.WriteLine("Please any key to continue...");

var buttonMaster = new ButtonMaster();

buttonMaster.ButtonPressed += (sender, args) => { Console.WriteLine("Button pressed event handled!"); };
buttonMaster.ButtonPressed += (sender, args) => { Console.WriteLine("Button pressed event handled!"); };
buttonMaster.ButtonPressed += (sender, args) => { Console.WriteLine("Button pressed event handled!"); };
buttonMaster.ButtonPressed += (sender, args) => { Console.WriteLine("Button pressed event handled!"); };
buttonMaster.ButtonPressed += (sender, args) => { Console.WriteLine("Button pressed event handled!"); };
buttonMaster.ButtonPressed += (sender, args) => { Console.WriteLine("Button pressed event handled!"); };
buttonMaster.ButtonPressed += (sender, args) => { Console.WriteLine("Button pressed event handled!"); };
buttonMaster.ButtonPressed += (sender, args) => { Console.WriteLine("Button pressed event handled!"); };
buttonMaster.ButtonPressed += (sender, args) => { Console.WriteLine("Button pressed event handled!"); };
buttonMaster.ButtonPressed += (sender, args) => { Console.WriteLine("Button pressed event handled!"); };
buttonMaster.ButtonPressed += (sender, args) => { Console.WriteLine("Button pressed event handled!"); };
buttonMaster.ButtonPressed += (sender, args) => { Console.WriteLine("Button pressed event handled!"); };
buttonMaster.ButtonPressed += (sender, args) => { Console.WriteLine("Button pressed event handled!"); };

var keyPressed = Console.ReadKey(true).KeyChar;

buttonMaster.OnButtonPressed(keyPressed);