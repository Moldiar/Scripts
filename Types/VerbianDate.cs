using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class VerbianDate
{
    public int Year { get; set; }
    public int Month { get; set; }
    public int Day{ get; set; }

    public VerbianDate(int year, int month, int day)
    {
        this.Year = year;
        this.Month = month;
        this.Day = day;
    }

    public string ToString()
    {
        string date = this.Day + " . " + this.Month + " . " +this.Year;
        return date;
    }
}
