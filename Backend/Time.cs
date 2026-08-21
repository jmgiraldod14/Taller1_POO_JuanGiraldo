using System;
using System.Collections.Generic;
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
