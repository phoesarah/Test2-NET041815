using System;
using System.Runtime.CompilerServices;
using Xunit.Sdk;

namespace Test02
{
    /// <summary>
    /// Represents a first and last name
    /// </summary>
    public class Name : IEquatable<Name>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public Name(string first, string last)
        {
            if (first == String.Empty)
                throw new ArgumentException();

            if (last == String.Empty)
                throw new ArgumentException();

            if (first == null)
                throw new ArgumentException();

            if (last == null)
                throw new ArgumentException();

            First = first;
            Last = last;
        }

        /// <summary>
        /// First name
        /// </summary>
        public string First { get; protected set; }

        /// <summary>
        /// Last name
        /// </summary>
        public string Last { get; protected set; }

        /// <summary>
        /// Returns the full name
        /// </summary>
        public string Full
        {
            get
            {
                if (First != null && Last !=null)
                {
                    return First + " "+ Last;
                }
                else if ((First != string.Empty && First != null) && Last == null)
                {
                    return First.Trim();
                }

                else if (First == null && Last != null)
                {
                    return Last.Trim();
                }
                if (First == String.Empty && Last == string.Empty)
                   return String.Empty;

                else return String.Empty;


            }
        }

        /// <summary>
        /// Create a new name with a different first name
        /// </summary>
        public Name ChangeFirst(string first)
        {
            Name d = new Name();
            string last = Last;
            d.First = first;
            d.Last = last;
            if (d.First == string.Empty || d.First ==null)
            {
                throw new ArgumentException(); 
                
            }
             //get new name use first name passed in but use the last name from the one passed in
              
            
            return d;


        }

        /// <summary>
        /// Create a new name with a different last name
        /// </summary>
        public Name ChangeLast(string last)
        {
            Name d = new Name();
            string first = First;
            d.First = first;
            d.Last = last;
            if (d.Last == string.Empty || d.Last == null)
            {
                throw new ArgumentException();

            }
            //get new name use first name passed in but use the last name from the one passed in


            return d;

        }

        /// <summary>
        /// Checks for equality
        /// </summary>
        public bool Equals(Name other)
        {
            if (First == other.First && Last == other.Last)
            {
                return true;
            }
            else return false;

        }

        #region "Pre-built code"
        private static readonly Name none = new Name { First = string.Empty, Last = string.Empty };

        /// <summary>
        /// Constructor
        /// </summary>
        private Name()
        {

        }

        /// <summary>
        /// Represents an empty name
        /// </summary>
        /// <remarks>You should not need to touch this.  It represents an empty name</remarks>
        public static Name None
        {
            get
            {
                return none;
            }
        }

        /// <summary>
        /// Gets the hash code of the name
        /// </summary>
        /// <remarks>You should not need to touch this.  Feel free to look up what it's for</remarks>
        public override int GetHashCode()
        {
            return First.GetHashCode() ^ Last.GetHashCode();
        }

        /// <summary>
        /// Checks for equality
        /// </summary>
        /// <remarks>You should not need to touch this.  Feel free to look up what it's for</remarks>
        public override bool Equals(object obj)
        {
            return Equals(obj as Name);
        }
        #endregion
    }
}
