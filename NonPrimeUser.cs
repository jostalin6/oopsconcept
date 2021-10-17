using System;
namespace INKJOLEARN
{
    public class NonPrimeUser : BaseUser
    {
        
        public int yearlyOffer { get; set; }

     
        public override int GetOffer()
        {
            return this.yearlyOffer / 2;
        }
    }
}
