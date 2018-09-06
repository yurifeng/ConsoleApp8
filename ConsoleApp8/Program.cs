using System;

namespace 接口隔离原则
{
    class Program
    {
        static void Main(string[] args)
        {
            //WarmKiller wk = new WarmKiller();
            //IKiller killer = wk;
            //killer.Kill();

            IKiller killer = new WarmKiller();
            killer.Kill();
            var wk = killer as IGentleMen;
            wk.Love();

            //WarmKiller wm = new WarmKiller();
            //wm.Love();
        }
    }

    interface IGentleMen
    {
        void Love();
    }

    interface IKiller
    {
        void Kill();
    }


    class WarmKiller : IGentleMen, IKiller
    {
        public void Love()
        {
            Console.WriteLine("I will love you forever....");
        }

        /// <summary>
        /// 显示的实现接口
        /// </summary>
        void IKiller.Kill()
        {
            Console.WriteLine("move,move,go,go,go.....");
        }
    }
}
