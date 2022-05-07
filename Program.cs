using System;
using System.Threading.Tasks;

namespace Banck;

    class Program
    {
        static async Task Main(string[] args)
        {
            
            Choy.GazYoqish();
            Choy.ChynakToldirish();
            Choy.GazgaQoyish();
            // Choy.Kutish();
            
            Tuxum.GazYoqish();
            Tuxum.TovaniQizdirish();
            Tuxum.TuxumniQozongaSolish();
            // Tuxum.Kutish();
            
            var choy = Choy.Kutish();
            var tuxum = Tuxum.Kutish();

            Dasturxon.DasturxonYozish();
            Dasturxon.NonQoyish();
            Dasturxon.ChoyQoyish(choy,tuxum);
            // // public static async Dasturxon()
            
            // // var dasturxon = new List<Task> {choy, tuxum};

            // // while(dasturxon.Count > 0)
            // // {
            // //     Task finish = await Task.WhenAny(choy, tuxum);

            // // }
            

            Console.ReadLine();
            
        }

        

    }
