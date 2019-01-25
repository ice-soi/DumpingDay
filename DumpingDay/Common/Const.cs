using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DumpingDay
{
    public static class Const
    {
        // **************************************************
        #region " '定数"
            /// <summary>
            /// 設定XML保存ﾌｫﾙﾀﾞﾊﾟｽ名称
            /// </summary>
            public const string  XMLPath = "XML";
            /// <summary>
            /// ﾛｸﾞ保存ﾌｫﾙﾀﾞﾊﾟｽ名称
            /// </summary>
            public const string LOGPath = "LOG";
            /// <summary>
            /// ｴﾗｰﾒｯｾｰｼﾞ1
            /// </summary>
            public const string ERROR_MSG_SETTING_XML = "初期設定チェックでエラーが発生しました";
            /// <summary>
            /// 曜日の配列(日曜Origin) 
            /// </summary>
            public static readonly string[] sArrayDayofWeek = { "日", "月", "火", "水", "木", "金", "土" };
            /// <summary>
            /// ごみの種類 
            /// </summary>
            public static readonly string[] sArrayDumpingCategory = { "燃えるごみ","燃えないごみ","雑がみ","枝・葉・草","容器プラ","びん・缶・ペットボトル" ,"なし"};
        #endregion
        // **************************************************
    }
}
