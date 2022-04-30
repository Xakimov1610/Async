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
            Choy.Kutish();

            Tuxum.GazYoqish();
            Tuxum.TovaniQizdirish();
            Tuxum.TuxumniQozongaSolish();
            Tuxum.Kutish();

            Dasturxon.DasturxonYozish();
            Dasturxon.NonQoyish();
            Dasturxon.ChoyQoyish();
            Dasturxon.TuxumQoyish();


            Console.ReadLine();
            
        }

        

    }
