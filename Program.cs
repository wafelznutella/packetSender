Packet packet = new Packet();
bool gotPacketFromTechnik = false;
//placeholder
string ip = "123.456.78.9";
int port = 1212;
//placeholder 2
string username = "admin";
string password = "admin";

Console.WriteLine("Please insert username: ");
string insertedUsername = Console.ReadLine();
Console.WriteLine("Now insert a password:");
string insertedPassword = Console.ReadLine();

if(insertedUsername == username && insertedPassword == password)
{
   Console.WriteLine($"Welcome, {username}!");
   Console.WriteLine("Select an option:"); 
   Console.WriteLine("1. Send package");
   Console.WriteLine("2. Get package");
   Console.WriteLine("3. Exit panel");
   int option = int.Parse(Console.ReadLine());
   if(option == 1)
    {
        Console.Clear();
        Console.WriteLine("Insert target ip (temporary, will not do anything):");
        ip = Console.ReadLine();
        Console.WriteLine("Insert target port:");
        port = int.Parse(Console.ReadLine());
        gotPacketFromTechnik = true;
    }
    else if(option == 2)
    {
        Console.Clear();
        Console.WriteLine("Insert source ip (temporary, will not do anything):");
        ip = Console.ReadLine();
        Console.WriteLine("Insert source port:");
        port = int.Parse(Console.ReadLine());
        packet.Get(ip, port);
    }
    else if(option == 3)
    {
        return;
    }
    else
    {
        Console.WriteLine("Invalid option");
    }
}


if(gotPacketFromTechnik == true)
{
    packet.Send(ip, port);
}