using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4
{
   public class Student
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value;}
        }
        private string lastname;
        public string Lastname
        {
            get { return lastname; }
            set { lastname = value; }
        }
        private string group;
        public string Group
        {
            get { return group; }
            set { group = value; }
        }
        private int year;
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        private string adress;
        public string Adress
        {
            get { return adress; }
            set { adress = value; }
        }
        private string passport;
        public string Passport
        {
            get { return passport; }
            set { passport = value; }
        }
        private int age;
        public int Age
        {
            get { return age; }
            set
            {
                if (value > 0)
                {
                    age = value;
                }
                else
                    throw new Exception("Enter your real age");
            }
        }
        private int telephone;
        public int Telephone
        {
            get { return telephone; }
            set { telephone = value; }
        }
        private int rating;
        public int Rating
        {
            get { return rating; }
            set
            {
                if (value <= 100)
                {
                    rating = value;
                }
                else
                    throw new Exception("Enter rating 0-100");
            }
        }

        public Student()
        {
            name = "Anonimous";
            lastname = "Anonimous";
            group = " - ";
            year = 0;
            adress = " - ";
            passport = " - ";
            age = 0;
            telephone = 0;
            rating = 0;
        }
            
        public string StudentRating(int R)
        {
            if(R >= 90)
            {
                return "Congratulations to the excellent student";
            }
            else if (R >= 75)
            {
                return "You can study better";
            }
            else
            {
                return "you should pay more attention to learning";

            }
        }

    }
}
