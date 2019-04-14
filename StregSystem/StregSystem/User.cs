using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace StregSystem
{
    public class User : IComparable
    {
        //private Backing Fields
        private int _iD;
        private string _firstname;
        private string _lastname;
        private string _email;
        private double _balance;



        //Getter and setter
        public int ID { get; private set; }
         
        public string Firstname
        {
            get { return _firstname; }
            set { _firstname = IsStringEmpy(value); }
            //{
            //    if (value != null)
            //    {
            //        _firstname = value;
            //    }
            //    else
            //    {
            //        throw new ArgumentException("Lastname cannot be null");
            //    }
            //}
        }

        public string Lastname
        {
            get { return _lastname; }
            set { _lastname = IsStringEmpy(value); }
            //{
            //    if (value != null)
            //    {
            //        _lastname = value;
            //    }
            //    else
            //    {
            //        throw new ArgumentException("Lastname cannot be null");
            //    }
            //}
        }

        public string Email
        {
            get { return _email; }
            set => _email = new EmailAddressAttribute().IsValid(value) ? value : throw new ArgumentException("Email adress not valid");
        }

        
        public double Balance { get; private set; }


        //Constructor 
        public User(int iD, string firstname, string lastname, string email, double balance)
        {
            ID = iD;
            Firstname = firstname;
            Lastname = lastname;
            Email = email;
            Balance = balance;
        }

        //Methods
        public string IsStringEmpy(string value)
        {
            if (value != null)
            {
                return value;
            }
            else
            {
                throw new ArgumentException("String cannot be null");
            }           
        }

        //Overrides
        public override string ToString()
        {
            return "Fornavn:  " + Firstname + "\nLastname:  " + Lastname + "\nEmail:  " + Email;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (GetType() != obj.GetType()) return false;

            User k = (User)obj;
            return (ID == k.ID) && (Firstname == k.Firstname) && (Lastname == k.Lastname);            
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        //ICompareable
        public int CompareTo(object obj)
        {
            return ID.CompareTo(obj);
        }
    }
}
