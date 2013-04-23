using System.Data;
using System.Configuration;
using System.Collections;

using SES.CMS.DAL;
using SES.CMS.DO;
using System.Collections.Generic;
using System;
using System.Globalization;

namespace SES.CMS.BL
{
    public class cmsCounterBL
    {
        cmsCounterDAL couterDAL = new cmsCounterDAL();

        private int getWeek(DateTime t)
        {
            CultureInfo myCI = new CultureInfo("en-US");
            System.Globalization.Calendar myCal = myCI.Calendar;
            CalendarWeekRule myCWR = myCI.DateTimeFormat.CalendarWeekRule;

            DayOfWeek myFirstDOW = myCI.DateTimeFormat.FirstDayOfWeek;
            int week = myCal.GetWeekOfYear(t, myCWR, myFirstDOW);
            return week;
        }
        public void Insert(cmsCounterDO counterDO)
        {
            couterDAL.Insert(counterDO);
        }

        public List<cmsCounterDO> GetAll()
        {
            return couterDAL.GetAll();
        }
        public int VisitorInCurrentDay()
        {
            int i = 0;
            List<cmsCounterDO> lstCount = couterDAL.GetAll();
            lstCount.ForEach(
                delegate(cmsCounterDO oCount)
                {
                    if (oCount.tDate.Day == DateTime.Now.Day)
                        i++;
                }
            );
            return i;
        }
        /// <summary>
        ///Lấy số lượng truy cập ngày hôm qua
        ///
        /// </summary>
        /// <returns>Số lượng</returns>
        public int VisitorInTomorow()
        {
            int i = 0;
            List<cmsCounterDO> lstCount = couterDAL.GetAll();
            lstCount.ForEach(
                delegate(cmsCounterDO oCount)
                {
                    if (oCount.tDate.Day == DateTime.Now.Day - 1)
                        i++;
                }
            );
            return i;
        }
        /// <summary>
        ///Lấy số lượng truy cập tuần 
        ///
        /// </summary>
        /// <returns>Số lượng</returns>
        public int VisitorInCurrentWeek()
        {
            int i = 0;
            List<cmsCounterDO> lstCount = couterDAL.GetAll();
            lstCount.ForEach(
                delegate(cmsCounterDO oCount)
                {
                    if ((oCount.tDate.Year == DateTime.Now.Year) && (getWeek(oCount.tDate) == getWeek(DateTime.Now)))
                        i++;
                }
            );
            return i;
        }
        /// <summary>
        /// Lấy số lượng truy cập tuần trước
        /// </summary>
        /// <returns></returns>
        public int VisitorInBeforeWeek()
        {
            int i = 0;
            List<cmsCounterDO> lstCount = couterDAL.GetAll();
            lstCount.ForEach(
                delegate(cmsCounterDO oCount)
                {
                    if ((oCount.tDate.Year == DateTime.Now.Year) && (getWeek(oCount.tDate) == getWeek(DateTime.Now) - 1))
                        i++;
                }
            );
            return i;
        }
        /// <summary>
        /// Lấy số lượng truy cập trong tháng
        /// </summary>
        /// <returns></returns>
        public int VisitorInCurrentMonth()
        {
            int i = 0;
            List<cmsCounterDO> lstCount = couterDAL.GetAll();
            lstCount.ForEach(
                delegate(cmsCounterDO oCount)
                {
                    if (oCount.tDate.Month == DateTime.Now.Month)
                        i++;
                }
            );
            return i;
        }
        /// <summary>
        /// Lấy số lượng truy cập trong tháng trước
        /// </summary>
        /// <returns></returns>
        public int VisitorInBeforeMonth()
        {
            int i = 0;
            List<cmsCounterDO> lstCount = couterDAL.GetAll();
            lstCount.ForEach(
                delegate(cmsCounterDO oCount)
                {
                    if (oCount.tDate.Month == DateTime.Now.Month - 1)
                        i++;
                }
            );
            return i;
        }

        public DateTime getTimeNow()
        {
            return  new cmsCounterDAL().getTimeNow();
        }
    }
}
