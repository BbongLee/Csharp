using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Web;

namespace NetMVC01.Models
{
    public class CUserManager
    {
        //private List<CUser> theUsers;
        LUserDataContext theUserContext;

        public CUserManager()
        {
            //theUsers = new List<CUser>(); 
            theUserContext = new LUserDataContext();
        }

        public int AddUser(ref CUser aUser)
        {
            /*
            CUser tmpUser = new CUser();
            tmpUser.theUniqueID = 0;
         
            theUsers.Add(aUser);
             */

            string tmpID = aUser.theID;
            int tmpCount = theUserContext.TUser3514.Where(x => x.theID == tmpID).Count();
            if (tmpCount > 0) {
                return (0);
            }


            TUser3514 tmpUser = new TUser3514();
            tmpUser.theID = aUser.theID;
            tmpUser.thePW = aUser.thePW;
            tmpUser.theName = aUser.theName;
            tmpUser.theEMail = aUser.theEMail;
            tmpUser.bSubscription = aUser.bSubscription ? 1 : 0;
            tmpUser.theDate = DateTime.Now;

            theUserContext.TUser3514.InsertOnSubmit(tmpUser);
            theUserContext.SubmitChanges();

            aUser.theDate = DateTime.Now;
            return (1);
        }

        public List<CUser> GetUsers()
        {
            IQueryable<TUser3514> tmpR = theUserContext.TUser3514.OrderByDescending(x => x.theID);//오름차순으로 가져오세요!

            List<TUser3514> tmpL = tmpR.ToList<TUser3514>();
            List<CUser> resUsers = new List<CUser>();

            foreach (TUser3514 iter in tmpL)
            {
                CUser tmpUser = new CUser();
                tmpUser.theUniqueID = iter.theUniqueID;
                tmpUser.theID = iter.theID;
                tmpUser.thePW = iter.thePW;
                tmpUser.theName = iter.theName;
                tmpUser.theEMail = iter.theEMail;
                tmpUser.bSubscription = iter.bSubscription == 1? true : false;
                tmpUser.theDate = iter.theDate;
                resUsers.Add(tmpUser);
            }

            return (resUsers);
        }

        public int CheckUser(string aID, string aPW, out CUser aUser)
        {
            /*
            foreach (CUser iter in theUsers)
            {
                if (iter.theName.Equals(aID) == true && iter.thePW.Equals(aPW) == true)
                {
                    return (1);
                }
            }*/
            Table<TUser3514> users = theUserContext.GetTable<TUser3514>();
            IQueryable<TUser3514> tmpQ = from iter in users
                                         where iter.theID == aID && iter.thePW == aPW
                                         select iter;
            if (tmpQ.Count() > 0) 
            {
                List<TUser3514> tmpUser = tmpQ.Take(1).ToList();
                aUser = new CUser();
                aUser.theID = tmpUser[0].theID;
                aUser.thePW = tmpUser[0].thePW;
                aUser.theName = tmpUser[0].theName;
                aUser.theEMail = tmpUser[0].theEMail;
                aUser.bSubscription = tmpUser[0].bSubscription==1?true:false;
                aUser.theDate = tmpUser[0].theDate;
                return (1);
            }
            aUser = new CUser();
            return (0);
        }

    }
}