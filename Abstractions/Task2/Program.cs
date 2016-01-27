using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            player.Play(); //IPlayable
            ((IRecodable)player).Record();

            IPlayable inter = new Player();
            inter.Stop();
            
            Console.ReadLine();
        }
    }
}
