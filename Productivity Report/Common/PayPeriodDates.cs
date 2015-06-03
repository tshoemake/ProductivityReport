using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Productivity_Report
{
    class PayPeriodDates
    {
        public static string GetPayPeriodStartDate(int year, int payperiod)
        {
            string PPEnd = "";
            if (year == 2014)
            {
                switch (payperiod)
                {
                    case 1:
                        PPEnd = "20140105";
                        break;
                    case 2:
                        PPEnd = "20140119";
                        break;
                    case 3:
                        PPEnd = "20140202";
                        break;
                    case 4:
                        PPEnd = "20140216";
                        break;
                    case 5:
                        PPEnd = "20140302";
                        break;
                    case 6:
                        PPEnd = "20140316";
                        break;
                    case 7:
                        PPEnd = "20140330";
                        break;
                    case 8:
                        PPEnd = "20140413";
                        break;
                    case 9:
                        PPEnd = "20140427";
                        break;
                    case 10:
                        PPEnd = "20140511";
                        break;
                    case 11:
                        PPEnd = "20140525";
                        break;
                    case 12:
                        PPEnd = "20140608";
                        break;
                    case 13:
                        PPEnd = "20140622";
                        break;
                    case 14:
                        PPEnd = "20140706";
                        break;
                    case 15:
                        PPEnd = "20140720";
                        break;
                    case 16:
                        PPEnd = "20140803";
                        break;
                    case 17:
                        PPEnd = "20140817";
                        break;
                    case 18:
                        PPEnd = "20140831";
                        break;
                    case 19:
                        PPEnd = "20140914";
                        break;
                    case 20:
                        PPEnd = "20140928";
                        break;
                    case 21:
                        PPEnd = "20141012";
                        break;
                    case 22:
                        PPEnd = "20141026";
                        break;
                    case 23:
                        PPEnd = "20141109";
                        break;
                    case 24:
                        PPEnd = "20141124";
                        break;
                    case 25:
                        PPEnd = "20141208";
                        break;
                    case 26:
                        PPEnd = "20141222";
                        break;
                    case 27:
                        PPEnd = "20141222";
                        break;
                }
            }
            else
            {
                switch (payperiod)
                {
                    case 1:
                        PPEnd = "20141222";
                        break;
                    case 2:
                        PPEnd = "20150105";
                        break;
                    case 3:
                        PPEnd = "20150119";
                        break;
                    case 4:
                        PPEnd = "20150202";
                        break;
                    case 5:
                        PPEnd = "20150216";
                        break;
                    case 6:
                        PPEnd = "20150302";
                        break;
                    case 7:
                        PPEnd = "20150316";
                        break;
                    case 8:
                        PPEnd = "20150330";
                        break;
                    case 9:
                        PPEnd = "20150413";
                        break;
                    case 10:
                        PPEnd = "20150427";
                        break;
                    case 11:
                        PPEnd = "20150511";
                        break;
                    case 12:
                        PPEnd = "20150525";
                        break;
                    case 13:
                        PPEnd = "20150608";
                        break;
                    case 14:
                        PPEnd = "20150622";
                        break;
                    case 15:
                        PPEnd = "20150706";
                        break;
                    case 16:
                        PPEnd = "20150720";
                        break;
                    case 17:
                        PPEnd = "20150803";
                        break;
                    case 18:
                        PPEnd = "20150817";
                        break;
                    case 19:
                        PPEnd = "20150831";
                        break;
                    case 20:
                        PPEnd = "20150914";
                        break;
                    case 21:
                        PPEnd = "20150928";
                        break;
                    case 22:
                        PPEnd = "20151012";
                        break;
                    case 23:
                        PPEnd = "20151026";
                        break;
                    case 24:
                        PPEnd = "20151109";
                        break;
                    case 25:
                        PPEnd = "20151123";
                        break;
                    case 26:
                        PPEnd = "20151207";
                        break;
                }


            }
            return PPEnd;
        }

        public static string GetPayPeriodEndDate(int year, int payperiod)
        {
            string PPEnd = "";
            if (year == 2014)
            {
                switch (payperiod)
                {
                    case 1:
                        PPEnd = "20140105";
                        break;
                    case 2:
                        PPEnd = "20140119";
                        break;
                    case 3:
                        PPEnd = "20140202";
                        break;
                    case 4:
                        PPEnd = "20140216";
                        break;
                    case 5:
                        PPEnd = "20140302";
                        break;
                    case 6:
                        PPEnd = "20140316";
                        break;
                    case 7:
                        PPEnd = "20140330";
                        break;
                    case 8:
                        PPEnd = "20140413";
                        break;
                    case 9:
                        PPEnd = "20140427";
                        break;
                    case 10:
                        PPEnd = "20140511";
                        break;
                    case 11:
                        PPEnd = "20140525";
                        break;
                    case 12:
                        PPEnd = "20140608";
                        break;
                    case 13:
                        PPEnd = "20140622";
                        break;
                    case 14:
                        PPEnd = "20140706";
                        break;
                    case 15:
                        PPEnd = "20140720";
                        break;
                    case 16:
                        PPEnd = "20140803";
                        break;
                    case 17:
                        PPEnd = "20140817";
                        break;
                    case 18:
                        PPEnd = "20140831";
                        break;
                    case 19:
                        PPEnd = "20140914";
                        break;
                    case 20:
                        PPEnd = "20140928";
                        break;
                    case 21:
                        PPEnd = "20141012";
                        break;
                    case 22:
                        PPEnd = "20141026";
                        break;
                    case 23:
                        PPEnd = "20141109";
                        break;
                    case 24:
                        PPEnd = "20141124";
                        break;
                    case 25:
                        PPEnd = "20141208";
                        break;
                    case 26:
                        PPEnd = "20141222";
                        break;
                    case 27:
                        PPEnd = "20141222";
                        break;
                }
            }
            else
            {
                switch (payperiod)
                {
                    case 1:
                        PPEnd = "20150104";
                        break;
                    case 2:
                        PPEnd = "20150118";
                        break;
                    case 3:
                        PPEnd = "20150201";
                        break;
                    case 4:
                        PPEnd = "20150215";
                        break;
                    case 5:
                        PPEnd = "20150301";
                        break;
                    case 6:
                        PPEnd = "20150315";
                        break;
                    case 7:
                        PPEnd = "20150329";
                        break;
                    case 8:
                        PPEnd = "20150412";
                        break;
                    case 9:
                        PPEnd = "20150426";
                        break;
                    case 10:
                        PPEnd = "20150510";
                        break;
                    case 11:
                        PPEnd = "20150524";
                        break;
                    case 12:
                        PPEnd = "20150607";
                        break;
                    case 13:
                        PPEnd = "20150621";
                        break;
                    case 14:
                        PPEnd = "20150705";
                        break;
                    case 15:
                        PPEnd = "20150719";
                        break;
                    case 16:
                        PPEnd = "20150802";
                        break;
                    case 17:
                        PPEnd = "20150816";
                        break;
                    case 18:
                        PPEnd = "20150830";
                        break;
                    case 19:
                        PPEnd = "20150913";
                        break;
                    case 20:
                        PPEnd = "20150927";
                        break;
                    case 21:
                        PPEnd = "20151011";
                        break;
                    case 22:
                        PPEnd = "20151025";
                        break;
                    case 23:
                        PPEnd = "20151108";
                        break;
                    case 24:
                        PPEnd = "20151122";
                        break;
                    case 25:
                        PPEnd = "20151206";
                        break;
                    case 26:
                        PPEnd = "20151220";
                        break;
                }
            }
            return PPEnd;
        }

        public static string GetPayPeriodCheckDate(int year, int payperiod)
        {
            string PPCheck = "";
            if (year == 2014)
            {
                switch (payperiod)
                {
                    //case 0:
                    //    PPCheck = "20140101";       //Eventually change to 2013 last check date
                    //    break;
                    case 1:
                        PPCheck = "20140110";
                        break;
                    case 2:
                        PPCheck = "20140124";
                        break;
                    case 3:
                        PPCheck = "20140207";
                        break;
                    case 4:
                        PPCheck = "20140221";
                        break;
                    case 5:
                        PPCheck = "20140307";
                        break;
                    case 6:
                        PPCheck = "20140321";
                        break;
                    case 7:
                        PPCheck = "20140404";
                        break;
                    case 8:
                        PPCheck = "20140418";
                        break;
                    case 9:
                        PPCheck = "20140502";
                        break;
                    case 10:
                        PPCheck = "20140516";
                        break;
                    case 11:
                        PPCheck = "20140530";
                        break;
                    case 12:
                        PPCheck = "20140613";
                        break;
                    case 13:
                        PPCheck = "20140627";
                        break;
                    case 14:
                        PPCheck = "20140711";
                        break;
                    case 15:
                        PPCheck = "20140725";
                        break;
                    case 16:
                        PPCheck = "20140808";
                        break;
                    case 17:
                        PPCheck = "20140822";
                        break;
                    case 18:
                        PPCheck = "20140905";
                        break;
                    case 19:
                        PPCheck = "20140919";
                        break;
                    case 20:
                        PPCheck = "20141003";
                        break;
                    case 21:
                        PPCheck = "20141017";
                        break;
                    case 22:
                        PPCheck = "20141031";
                        break;
                    case 23:
                        PPCheck = "20141114";
                        break;
                    case 24:
                        PPCheck = "20141128";
                        break;
                    case 25:
                        PPCheck = "20141212";
                        break;
                    case 26:
                        PPCheck = "20141226";
                        break;
                    case 27:
                        PPCheck = "20141226";
                        break;

                }
            }
            else
            {
                switch (payperiod)
                {
                    //case 0:
                    //    PPCheck = "20150101";     //eventually change to 2014 last check date
                    //    break;
                    case 1:
                        PPCheck = "20150109";
                        break;
                    case 2:
                        PPCheck = "20150123";
                        break;
                    case 3:
                        PPCheck = "20150206";
                        break;
                    case 4:
                        PPCheck = "20150220";
                        break;
                    case 5:
                        PPCheck = "20150306";
                        break;
                    case 6:
                        PPCheck = "20150320";
                        break;
                    case 7:
                        PPCheck = "20150403";
                        break;
                    case 8:
                        PPCheck = "20150417";
                        break;
                    case 9:
                        PPCheck = "20150501";
                        break;
                    case 10:
                        PPCheck = "20150515";
                        break;
                    case 11:
                        PPCheck = "20150529";
                        break;
                    case 12:
                        PPCheck = "20150612";
                        break;
                    case 13:
                        PPCheck = "20150626";
                        break;
                    case 14:
                        PPCheck = "20150710";
                        break;
                    case 15:
                        PPCheck = "20150724";
                        break;
                    case 16:
                        PPCheck = "20150807";
                        break;
                    case 17:
                        PPCheck = "20150821";
                        break;
                    case 18:
                        PPCheck = "20150904";
                        break;
                    case 19:
                        PPCheck = "20150918";
                        break;
                    case 20:
                        PPCheck = "20151002";
                        break;
                    case 21:
                        PPCheck = "20151016";
                        break;
                    case 22:
                        PPCheck = "20151030";
                        break;
                    case 23:
                        PPCheck = "20151113";
                        break;
                    case 24:
                        PPCheck = "20151127";
                        break;
                    case 25:
                        PPCheck = "20151211";
                        break;
                    case 26:
                        PPCheck = "20151224";
                        break;
                }

            }
            return PPCheck;
        }

    }
}
