public class Dasturxon
{
    public static void DasturxonYozish()
    {
        System.Console.WriteLine("Dasturhon yoqildi");
    }

    public static void NonQoyish()
    {
        System.Console.WriteLine("Non qo'yildi");
    }

    public static async void ChoyQoyish(Task choy, Task tuxum)
    {
        
       
        var dasturxon = new List<Task> { choy, tuxum };

            while(dasturxon.Count > 0)
            {
                Task finish = await Task.WhenAny(dasturxon);
                if(finish == choy)
                {
                     System.Console.WriteLine("Choy dasturhonda");
                }
                else if(finish == tuxum)
                {
                    System.Console.WriteLine("Tuxum Dasturxonda");
                }
                dasturxon.Remove(finish);
            }
    }
    // public static void TuxumQoyish()
    // {
        
    // }
    
}