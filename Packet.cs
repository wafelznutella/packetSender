using System.Net;
using System.Net.Sockets;
using System.Text;
public class Packet
{
    public void Send(string ip, int port, string dataToSend)
    {
        using UdpClient client = new UdpClient(); 
        byte[] data = System.Text.Encoding.UTF8.GetBytes(dataToSend);
        client.Send(data, data.Length, ip, port);
    }

    public void Get(string ip, int port)
    {
        
        using UdpClient listener = new UdpClient(port);
        IPEndPoint groupEP = new IPEndPoint(IPAddress.Any, port);

        try
        {
            Debug.Log($"Oczekiwanie na pakiety na porcie {port}...");
            
            while (true) // Pętla nasłuchiwania
            {
                byte[] bytes = listener.Receive(ref groupEP);
                string message = Encoding.UTF8.GetString(bytes);

                Debug.Log($"Odebrano od {groupEP}: {message}");
            }
        }
        catch (SocketException e)
        {
            Debug.Log($"Błąd gniazda: {e.Message}");
        }
        finally
        {
            listener.Close();
        }
    }
}