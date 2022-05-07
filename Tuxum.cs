using System.Threading.Tasks;
public class Tuxum
{
    public static void GazYoqish()
    {
        System.Console.WriteLine("Gaz yoqildi .");
    }

    public static void TovaniQizdirish()
    {
        System.Console.WriteLine("Tova niQizdirilyapti ..");
        Task.Delay(100);
        System.Console.WriteLine(" Tova Qizidi ...");
    }

    public static void TuxumniQozongaSolish()
    {
        System.Console.WriteLine("TuxumniQozongaSolindi ....");
    }
    public static async Task Kutish()
    {
        // System.Console.WriteLine(" Tuxum Kutilyapti .....");
        await Task.Delay(8000);
        System.Console.WriteLine("Tuxum Tayyor .....!");
    }
    
}