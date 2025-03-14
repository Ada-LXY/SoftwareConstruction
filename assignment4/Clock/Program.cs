using System;
using System.Threading;

namespace AlarmClockSimulation
{
    // 定义闹钟类
    public class AlarmClock
    {
        // 定义 Tick 事件
        public event EventHandler Tick;
        // 定义 Alarm 事件
        public event EventHandler Alarm;

        // 触发 Tick 事件
        protected virtual void OnTick()
        {
            Tick?.Invoke(this, EventArgs.Empty);
        }

        // 触发 Alarm 事件
        protected virtual void OnAlarm()
        {
            Alarm?.Invoke(this, EventArgs.Empty);
        }

        // 启动闹钟
        public void Start(int alarmAfterSeconds)
        {
            for (int i = 1; i <= alarmAfterSeconds; i++)
            {
                Thread.Sleep(1000); // 模拟1秒
                OnTick(); // 触发 Tick 事件
                if (i == alarmAfterSeconds)
                {
                    OnAlarm(); // 触发 Alarm 事件
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // 创建闹钟对象
            AlarmClock clock = new AlarmClock();

            // 订阅 Tick 事件
            clock.Tick += (sender, e) => Console.WriteLine("Tick...");

            // 订阅 Alarm 事件
            clock.Alarm += (sender, e) => Console.WriteLine("Alarm! Time's up!");

            // 启动闹钟，5秒后响铃
            Console.WriteLine("闹钟启动，5秒后响铃...");
            clock.Start(5);
        }
    }
}