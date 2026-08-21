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
        _hour = 0;
        _minute = 0;
        _second = 0;
        _millisecond = 0;
        
    }

    public Time(int hour)
    {
        _hour = hour;
        _minute = 0;
        _second = 0;
        _millisecond = 0;
      
    }

    public Time(int hour, int minute)
    {
        _hour = hour;
        _minute = minute;
        _second = 0;
        _millisecond = 0;
    }

    public Time(int hour, int minute, int second)
    {
        _hour = hour;
        _minute = minute;
        _second = second;
        _millisecond = 0;
    }

    public Time(int hour, int minute, int second, int millisecond)
    {
        _hour= hour;
        _minute = minute;
        _second = second;
        _millisecond =millisecond;
    }

    //Properties

    public int Hour 
    {
        get => _hour; 
        set => _hour = value; 
    }

    public int Minute 
    {
        get => _minute;
        set => _minute = value;
    }

    public int Second 
    {
        get => _second;
        set => _second = value;
    }

    public int Millisecond 
    {
        get => _millisecond;
        set => _millisecond = value;
    }




    //Public Methods

    public override string ToString()
    {
        string period;
        int T_hour = _hour;

        if (_hour < 12)
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
        return $"{T_hour:D2}:{_minute:D2}:{_second:D2}.{_millisecond:D3} {period}";
    }

}
