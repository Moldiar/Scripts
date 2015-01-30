﻿using System;
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
        string date = this.Day + " " + MonthsName[Month-1] + " " + this.Year;
        return date;
    }

    string[] MonthsName = {
                              "Vesing",
                              "Rilal",
                              "Entheg",
                              "Aracki",
                              "Taiash",
                              "Akrat",
                              "Terler",
                              "Rynur",
                              "Sulint",
                              "Tyela",

                              "Imardi",
                              "Belgaru",
                              "Rath",
                              "Yerig",
                              "Rutas",
                              "Nularn",
                              "Ineund",
                              "Masys",
                              "Radest",
                              "Olod"
                          };
}
