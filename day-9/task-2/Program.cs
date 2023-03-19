using System;
using System.Collections.Generic;

namespace task2
{
    interface IRecord
    {
        string LastName { get; set; }
        string FirstName { get; set; }
        DateTime BirthDate { get; set; }
        string PhoneNumber { get; set; }
    }

    interface INotebook
    {
        void AddRecord(IRecord record);
        void RemoveRecord(int index);
        void SortByLastName();
        List<IRecord> FindRecords(string query);
        IRecord GetRecord(int index);
        int Count { get; }
    }

    class Record : IRecord
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime BirthDate { get; set; }
        public string PhoneNumber { get; set; }
    }

    class Notebook : INotebook
    {
        public List<IRecord> records = new List<IRecord>();

        public void AddRecord(IRecord record)
        {
            records.Add(record);
        }

        public void RemoveRecord(int index)
        {
            records.RemoveAt(index);
        }

        public void SortByLastName()
        {
            records.Sort((a, b) => a.LastName.CompareTo(b.LastName));
        }

        public List<IRecord> FindRecords(string query)
        {
            return records.FindAll(record =>
                record.LastName.Contains(query) ||
                record.FirstName.Contains(query) ||
                record.PhoneNumber.Contains(query));
        }

        public IRecord GetRecord(int index)
        {
            return records[index];
        }

        public int Count => records.Count;
    }

    class Program
    {
        static void Main(string[] args)
        {
            var notebook = new Notebook();

            var record2 = new Record { LastName = "Petin", FirstName = "Petr", BirthDate = new DateTime(1980, 2, 2), PhoneNumber = "222-22-22" };
            notebook.AddRecord(record2);

            var record3 = new Record { LastName = "Sidorik", FirstName = "Sidor", BirthDate = new DateTime(1970, 3, 3), PhoneNumber = "333-33-33" };
            notebook.AddRecord(record3);

            var record1 = new Record { LastName = "Ivanov", FirstName = "Ivan", BirthDate = new DateTime(1990, 1, 1), PhoneNumber = "111-11-11" };
            notebook.AddRecord(record1);

            Console.WriteLine($"Count: {notebook.Count}");

            Console.WriteLine("All records:");
            for (int i = 0; i < notebook.Count; i++)
            {
                var record = notebook.GetRecord(i);
                Console.WriteLine($"{i + 1}. {record.LastName} {record.FirstName}, {record.BirthDate.ToString("yyyy-MM-dd")}, {record.PhoneNumber}");
            }

            Console.WriteLine("Find by last name:");
            var foundRecords = notebook.FindRecords("ov");
            for (int i = 0; i < foundRecords.Count; i++)
            {
                var record = foundRecords[i];
                Console.WriteLine($"{i + 1}. {record.LastName} {record.FirstName}, {record.BirthDate.ToString("yyyy-MM-dd")}, {record.PhoneNumber}");
            }

            notebook.RemoveRecord(1);

            Console.WriteLine("Sort:");
            notebook.SortByLastName();
            for (int i = 0; i < notebook.Count; i++)
            {
                var record = notebook.GetRecord(i);
                Console.WriteLine($"{i + 1}. {record.LastName} {record.FirstName}, {record.BirthDate.ToString("yyyy-MM-dd")}, {record.PhoneNumber}");
            }
        }
    }
}
