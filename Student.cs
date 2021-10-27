using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;





namespace ExerWindowsApp
{
    public enum Remark : int


    {
        Poor = 1, Fair = 2, Good = 3, Exellent = 4

    }


    public class Student
    {
        
        private string id;
        private string firstname;
        private string lastname;
        private string quizscore;
        private string remarks;


        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Firstname
        {
            get { return firstname; }
            set { firstname = value; }

        }

        public string Lastname
        {
            get { return lastname; }
            set { lastname = value; }

        }

        public string Quizscore
        {
            get { return quizscore; }
            set { quizscore = value; }
        }

        public string Remarks
        {
            get { return remarks; }
            set { remarks = value; }


           
        }
            
      }

  }

