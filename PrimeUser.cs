using System;
namespace INKJOLEARN
{
    public class PrimeUser : BaseUser
    {
       
        public int monthlyOffer { get; set; }

        
        public override int GetOffer()
        {
            return this.monthlyOffer / 2;
        }
    }
}
