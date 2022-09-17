using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Worker
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Zp { get; set; }
        public string Status { get; set; }

        public bool IsPensioner
        {
            get
            {
                if(Age > 60)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public Worker()
        {
        }

        public Worker(string Surname, string Name, int Age, int Zp, string Status)
        {
            this.Surname = Surname;
            this.Name = Name;
            this.Age = Age;
            this.Zp = Zp;
            this.Status = Status;
            
            }
    }
}
