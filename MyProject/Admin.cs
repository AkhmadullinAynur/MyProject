using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MyProject
{
    class Admin: Data
    {
        [BsonIgnoreIfDefault]
        ObjectId _id;
        public Admin(string surname, string name, string profession, string password)
        {
            Surname = surname;
            Name = name;
            Profession = profession;
            Password = password;
        }

        public string Surname { get => surname; set => surname = value; }
        public string Name { get => name; set => name = value; }
        public string Profession { get => profession; set => profession = value; }
        public string Password { get => password; set => password = value; }
        //public void AdminStatus()
        //{
        //    MessageBox.Show("У вас есть права администратора!");
        //}
    }
}
