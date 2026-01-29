using Smartphones.Models;

Console.WriteLine("\nNokia: ");
Smartphone nokia = new Nokia("21934534325", "Nokia 5.4","101010101010101", 128);
nokia.TurnOn();
nokia.CallReceive();
nokia.InstallApp("Telegram");

Console.WriteLine("\nIphone: ");
Smartphone iphone = new Iphone("21934534325", "Iphone 17","101010101010101", 256);
iphone.TurnOn();
iphone.CallReceive();
iphone.InstallApp("iCloud");
