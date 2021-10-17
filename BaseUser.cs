using System;
namespace INKJOLEARN
{
    public abstract class BaseUser
    {
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }

        public string GetFullName()
        {
            return this.firstName + this.lastName;
        }

        public abstract int GetOffer();
    }
}
