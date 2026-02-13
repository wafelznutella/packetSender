public class Packet
{
    public void Send(string ip, int port)
    {
        //PLACEHOLDER
        Console.WriteLine($"SYSTEM: sent packet to {ip}:{port}");
    }

    public void Get(string ip, int port)
    {
        //PLACEHOLDER
        Console.WriteLine($"SYSTEM: got packet from {ip}:{port}");
    }
}