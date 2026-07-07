using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {

        Job job1 = new Job();

        job1._company = "Kerr inc.";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2026;
        job1._endYear = 2030;

        Job job2 = new Job();
        job2._company = "Asurto inc.";
        job2._jobTitle = "Manager";
        job2._startYear = 2027;
        job2._endYear = 2035;


        Resume resume1 = new Resume();
        resume1._name = "Kerr Asurto";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);
        resume1.Display();





    }


}