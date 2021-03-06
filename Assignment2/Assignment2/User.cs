﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public abstract class User
    {
        protected string username, password, firstName, lastName;
        protected int ratingsCount;

        public int RatingsCount
        {
            get
            {
                return ratingsCount;
            }
        }

        protected double averageRating;

        public double AverageRating
        {
            get
            {
                return averageRating;
            }
        }

        protected bool varAppropriateSize()
        {

            return true;
        }

        protected double roundDown(double d)
        {
            return Math.Floor(d * 100) / 100;
        }

// concrete  method,  checks  the  username  and  password parameters against  the member  variables and  return  true  if  they match and returns false otherwise.
        public bool CheckUserNameAndPassword(string username, string password)
        {
            return (this.username == username && this.password == password);
        }
// concrete method, returns astring containing the username and first name only.
        public string GetShortUserString()
        {
            return (this.username + this.firstName);
        }
// concrete method, updates the averageRating and ratingsCount member variables with the given parameter.
        public void AddRating(int rating)
        {
            if (ratingsCount == 0) averageRating = rating;
            else
            {
                ratingsCount++;
                if (averageRating == 0)
                {
                    averageRating = roundDown((rating/4));
                }
                else
                {
                    averageRating = roundDown((averageRating + rating) / 2);
                }
                
            }
        }

        public abstract string GetFullUserString();
    }
}
