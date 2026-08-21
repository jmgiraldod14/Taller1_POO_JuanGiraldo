using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace Backend;

public class Time
{
    //Fields
    private int _hour;
    private int _minute;
    private int _second;
    private int _millisecond;
   


    //Constructors
    public Time()
    {
        Hour = 0;
        Minute = 0;
        Second = 0;
        Millisecond = 0;
        
    }

    public Time(int hour)
    {
        Hour = hour;
        Minute = 0;
        Second = 0;
        Millisecond = 0;
      
    }

    public Time(int hour, int minute)
    {
        Hour = hour;
        Minute = minute;
        Second = 0;
        Millisecond = 0;
    }

    public Time(int hour, int minute, int second)
    {
        Hour = hour;
        Minute = minute;
        Second = second;
        Millisecond = 0;
    }

    public Time(int hour, int minute, int second, int millisecond)
    {
        Hour= hour;
        Minute = minute;
        Second = second;
        Millisecond =millisecond;
    }

    //Properties

    public int Hour 
    {
        get => _hour; 
        set => _hour = ValidateHour(value); 
    }

    public int Minute 
    {
        get => _minute;
        set => _minute = ValidateMinute(value);
    }

    public int Second 
    {
        get => _second;
        set => _second = ValidateSecond(value);
    }

    public int Millisecond 
    {
        get => _millisecond;
        set => _millisecond = ValidateMillisecond(value);
    }
 
    
    //Public Methods

    public override string ToString()
    {
        string period;
        int T_hour = Hour;

        if (Hour < 12)
        {
            period = "AM"; 
        }
        else
        {
            period = "PM";
        }

        if (T_hour == 0) 
        {
            T_hour = 12;
        }
        else if (T_hour > 12)
        {
            T_hour = T_hour - 12;
        }
        return $"{T_hour:D2}:{Minute:D2}:{Second:D2}.{Millisecond:D3} {period}";
    }

    public int ToMilliseconds() 
    {
        int T_milliseconds;
        T_milliseconds = Hour*3600000 + Minute*60000 + Second*1000 + Millisecond;
        return T_milliseconds;
    }

    public int ToSeconds()
    {
        int T_seconds;
        T_seconds = Hour*3600 + Minute*60 + Second;
        return T_seconds;
    }

    public int ToMinutes()
    {
        int T_minutes;
        T_minutes = Hour * 60 + Minute;
        return T_minutes;
    }

    public Time Add(Time previous)
    {
        int add_milliseconds = Millisecond + previous.Millisecond;
        int add_seconds = Second + previous.Second;
        int add_minutes = Minute + previous.Minute;
        int add_hours = Hour + previous.Hour;

        if (add_milliseconds >= 1000)
        {
            add_milliseconds = add_milliseconds - 1000;
            add_seconds = add_seconds + 1;
        }

        if (add_seconds >= 60)
        {
            add_seconds = add_seconds - 60;
            add_minutes = add_minutes + 1;
        }

        if (add_minutes >= 60)
        {
            add_minutes = add_minutes - 60;
            add_hours = add_hours + 1;
        }

        if (add_hours >= 24)
        {
            add_hours = add_hours - 24;
        }

        return new Time(add_hours, add_minutes, add_seconds, add_milliseconds);
    }


    public bool IsOtherDay(Time another)
    {
        int add_milliseconds = Millisecond + another.Millisecond;
        int add_seconds = Second + another.Second;
        int add_minutes = Minute + another.Minute;
        int add_hours = Hour + another.Hour;
        bool condition = false;

        if (add_milliseconds >= 1000)
        {
            add_seconds = add_seconds + 1;
        }

        if (add_seconds >= 60)
        {
            add_minutes = add_minutes + 1;
        }

        if (add_minutes >= 60)
        {
            add_hours = add_hours + 1;
        }

        if (add_hours >= 24)
        {
            condition = true;
        }

        return condition;
    }

    //Private Methods

    private int ValidateHour(int hour)
    {
        if (hour < 0 || hour > 23)
        {

            throw new Exception($"The hour: {hour}, is not valid.");
        }
        return hour;
    }

    private int ValidateMinute(int minute)
    {
        if (minute < 0 || minute >59)
        {

            throw new Exception($"The minute: {minute}, is not valid.");
        }
        return minute;
    }

    private int ValidateSecond(int second)
    {
        if (second < 0 || second > 59)
        {

            throw new Exception($"The second: {second}, is not valid.");
        }
        return second;
    }

    private int ValidateMillisecond(int millisecond)
    {
        if (millisecond < 0 || millisecond > 999)
        {

            throw new Exception($"The millisecond: {millisecond}, is not valid.");
        }
        return millisecond;
    }

}
