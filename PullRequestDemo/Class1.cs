﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PullRequestDemo
{
    internal class Class1
    {
    }

    public static class RoleCheckerAssigment
    {
        public enum Role
        {
            Admin,
            User,
            Guest
        }

        public static bool IsAdmin(Role role)
        {
            //Assigment 11: Return true if role is Admin, otherwise return false.

            bool rolecheck;
            {

                if (role == Role.Admin)
                {
                    return true;
                }

                else
                {
                    return false;
                }

            }
            return rolecheck;
        }


        public static bool HasPrivligies(Role role, DateTime validUntill)
        {
            //Assigment 12: Return true if role is Admin or User and validUntill is in the future, otherwise return false.
            throw new NotImplementedException();

            bool rolevalid;
            {
                if ((role == Role.Admin || role == Role.User) && validUntill > DateTime.Now)
                {
                    return true;
                }

                else
                {
                    return false;
                }
            }
            return rolevalid;

        }

        public static string RoleToString(Role role)
        {
            //Assigment 13: Implement a method RoleToString(Role role) that converts the Role enum to its string representation.

            string roleString = Enum.GetName(typeof(Role), role);

            return roleString; ;
        }

        public static Role StringToRole(string roleString)
        {
            //Assigment 14: Write a method StringToRole(string roleString) that converts a string to the corresponding Role enum. 
            //If the string does not match any role, throw an appropriate exception.
            //Hint: Remember how conversion worked on ints (especially TryParse)


            return (Role)Enum.Parse(typeof(Role), roleString, true);
            throw new ArgumentException();
        }
    }

}
