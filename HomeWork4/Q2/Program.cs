using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            myClock c = new myClock();
            c.setAlarm(12, 2, 0);
            c.theClock.TimeStartGoing();
        }
    }
}

public class Time
{
    public int hour { get; set; }
    public int minute { get; set; }
    public int second { get; set; }

    public void timeGo()
    {
        if(second<59)
        {
            second++;
        }
        else
        {
            second = 0;
            if (minute < 59)
                minute++;
            else
            {
                minute = 0;
                if (hour < 23)
                    hour++;
                else
                    hour = 0;
                
            }
        }
    }
}

public delegate void TimeRecord(Time time);

public class Clock
{
    public event TimeRecord Tick;
    public event TimeRecord Alarm;

    public void TimeStartGoing()
    {
        Time now = new Time()
        {
            hour = System.DateTime.Now.Hour,
            minute = System.DateTime.Now.Minute,
            second = System.DateTime.Now.Second
        };
        Tick(now);
    }

    public void TimeOut(Time time)
    {
        Alarm(time);
    }
}

public class myClock
{
    public Clock theClock = new Clock();
    public Time myAlarm = new Time() { hour = 0,minute = 0, second = 0 };

    public myClock()
    {
        theClock.Tick += TimeInGoing;
        theClock.Alarm += AlarmTimeOut;
    }

    public void setAlarm(int hour, int minute, int second)
    {
        this.myAlarm.hour = hour;
        this.myAlarm.minute = minute;
        this.myAlarm.second = second;
    }

    public void TimeInGoing(Time time)
    {
        while(true)
        {

            theClock.TimeOut(time);
            Console.WriteLine($"现在是{time.hour}点{time.minute}分{time.second}秒");
            time.timeGo();
            System.Threading.Thread.Sleep(1000);
        }
    }

    public void AlarmTimeOut(Time time)
    {
        if (time.hour == myAlarm.hour && time.minute == myAlarm.minute && time.second == myAlarm.second)
            Console.WriteLine("闹钟响了！！");
    }
}
