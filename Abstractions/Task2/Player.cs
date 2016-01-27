using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Text.RegularExpressions;
using System.Linq.Expressions;
namespace Task2
{
    class Player:IPlayable,IRecodable
    {
         string GetName<T>(Expression<Func<T>> property)
        {
            return (property.Body as MemberExpression).Member.Name;
        }
        SoundPlayer player = new SoundPlayer();
        public void Play()
        {
            Console.WriteLine("Played song from IPlayable");
            var s = GetName(() => Resource1.blizzard);
            player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "\\"+s+".wav";
            player.Play();
        }
       
        public void Pause()
        {
            Console.WriteLine("Paused from IPlayable");
        }

        public void Stop()
        {
            Console.WriteLine("Stopped from IPlayable");
            player.Stop();
        }

        void IRecodable.Record()
        {
            Console.WriteLine("Recorded from IRecordable");
        }

        void IRecodable.Pause()
        {
            Console.WriteLine("Paused from IRecordable");

        }

        void IRecodable.Stop()
        {
            Console.WriteLine("Stopped from IRecordable");
        }
    }
}
