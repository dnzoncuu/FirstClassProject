using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NesnelerveSınıflar
{
    public class Person//Class oluşturuldu.
    {
        //Fields Oluşturuldu.
        private string _name; 
        private string _lastName;
        private DateTime _birthDate;

        //properties tanımlandı.
        public string name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string lastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public DateTime birthDate
        {
            get { return _birthDate; }
            set { _birthDate = value; }
        }
        //Metot tanımlandı.
        public void BilgileriYazdir()
        {
            Console.WriteLine($"Adınız : {name}");
            Console.WriteLine($"Soyadınız : {lastName}");
            Console.WriteLine($"Doğum Tarihi : {birthDate.ToShortDateString()}");
        }
    }
}
