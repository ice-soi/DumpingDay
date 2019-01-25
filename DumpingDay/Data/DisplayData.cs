using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DumpingDay.Data
{
    public class DisplayData
    {
        // **************************************************
        #region " 'ﾒﾝﾊﾞ"
            /// <summary>
            /// 曜日設定内容
            /// </summary>
            public string SundayMessage { get; set; }
            public string MondaydayMessage { get; set; }
            public string TuesdayMessage { get; set; }
            public string WednesdayMessage { get; set; }
            public string ThursdayMessage { get; set; }
            public string FridayMessage { get; set; }
            public string SaturdayMessage { get; set; }
        #endregion
        // **************************************************

        // **************************************************
        #region " 'ｺﾝｽﾄﾗｸﾀ"
        public DisplayData()
        {
            SundayMessage = "";
            MondaydayMessage = "";
            TuesdayMessage = "";
            WednesdayMessage = "";
            ThursdayMessage = "";
            FridayMessage = "";
            SaturdayMessage = "";
        }
        #endregion
        // **************************************************

        // **************************************************
        #region " 'ﾒｿｯﾄﾞ"
        /// <summary>
        /// ｲﾍﾞﾝﾄ配列取得
        /// </summary>
        /// <returns></returns>
        public string[] DayOfWeekEvent()
            {
                // 曜日毎のｲﾍﾞﾝﾄを取得する
                string[] WeekEvent = { SundayMessage, MondaydayMessage, TuesdayMessage, WednesdayMessage, ThursdayMessage, FridayMessage, SaturdayMessage};
                // ｲﾍﾞﾝﾄ配列を返却
                return WeekEvent;
            }
        #endregion
        // **************************************************
    }
}
