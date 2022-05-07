using System.Threading.Tasks;
public class Choy
{
    public static void GazYoqish()
    {
        System.Console.WriteLine("Gaz yoqildi .");
    }

    public static void ChynakToldirish()
    {
        System.Console.WriteLine("Choynak to'ldirildi ..");
    }

    public static void GazgaQoyish()
    {
        System.Console.WriteLine("Choy Gazga Qo'yildi ...");
    }
    public static async Task Kutish()
    {
        // System.Console.WriteLine("Choy Kutilyapti ....");
        await Task.Delay(5000);
        System.Console.WriteLine("Choy Tayyor .....!");
        
    }
    
}