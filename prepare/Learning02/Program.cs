using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company ="DASA";
        job1._jobTitle = "Custumer Service Logistic";
        job1._startYear = 2022;
        job1._endYear = 2023;

        Job job2 = new Job();
        job2._company ="Huarpe";
        job2._jobTitle = "Logistic Asistent";
        job2._startYear = 2020;
        job2._endYear = 2022;

        Job job3 = new Job();
        job3._company ="Fuesmen";
        job3._jobTitle = "Custumer Service";
        job3._startYear = 2018;
        job3._endYear = 2020;

        Resume resume1 = new Resume();
        resume1._name = "Gabriel Puebla";
        resume1.jobs.Add(job1);
        resume1.jobs.Add(job2);
        resume1.jobs.Add(job3);

        resume1.Display();

    }
}