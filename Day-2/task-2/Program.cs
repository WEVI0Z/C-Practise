using System;

namespace task2
{
    class Task
    {
        public string question;
        public string answer;

        public Task(string question, string answer)
        {
            this.question = question;
            this.answer = answer;
        }
    }

    class Test
    {
        public Task[] tasks;

        public Test(Task[] tasks)
        {
            this.tasks = tasks;
        }
    }

    class Exam : Test
    {
        private string markSystem;

        public Exam(string markSystem, Task[] tasks) : base(tasks) {
            this.markSystem = markSystem;
        }
    }

    class GraduatingExam
    {
        public Exam[] exams;

        public GraduatingExam(Exam[] exams)
        {
            this.exams = exams;
        }
    }

    class Challenge
    {
        public Test[] tests;

        public Challenge(Test[] tests)
        {
            this.tests = tests;
        }
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Class ierarchy");
        }
    }
}
