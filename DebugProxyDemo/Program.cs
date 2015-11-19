
using System;
using System.Collections.Generic;
using System.Diagnostics;
using DebugProxyDemo.Model;

namespace DebugProxyDemo
{
    class Program
    {
        public static Discography MetallicaDiscography;
        static void Main(string[] args)
        {

            MetallicaDiscography = new Discography
            {
                BandName = "Metallica",
                Records = new List<Record>
                {
                    new Record
                    {
                        Title = "Kill 'Em All",
                        ReleaseDate = new DateTime(1983,07,25)
                    },
                     new Record
                    {
                        Title = "Ride the Lightning",
                        ReleaseDate = new DateTime(1984,07,27)
                    },
                      new Record
                    {
                        Title = "Master of Puppets",
                        ReleaseDate = new DateTime(1986,03,03)
                    },
                       new Record
                    {
                        Title = "...And Justice for All ",
                        ReleaseDate = new DateTime(1988,08,25)
                    },
                        new Record
                    {
                        Title = "Metallica",
                        ReleaseDate = new DateTime(1991,08,12)
                    }, new Record
                    {
                        Title = "Load",
                        ReleaseDate = new DateTime(1996,06,04)
                    },
                         new Record
                    {
                        Title = "Reload",
                        ReleaseDate = new DateTime(1997,11,18)
                    },
                         new Record
                    {
                        Title = "St. Anger",
                        ReleaseDate = new DateTime(2003,06,05)
                    },
                        new Record
                    {
                        Title = "Death Magnetic",
                        ReleaseDate = new DateTime(2008,09,12)
                    },
                }
            };


            if (Debugger.IsAttached)
                Debugger.Break();
        }
    }
}
