using DumpingDay.Data;
using DumpingDay.Logic;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DumpingDay
{
    class clsCommonLogic
    {
        // **************************************************
        #region " 'ｸﾗｽ変数"
            /// <summary>
            /// ﾃﾞｨﾚｸﾄﾘ取得用
            /// </summary>
            private DirectoryInfo dCurrentDirectory = new DirectoryInfo(Directory.GetCurrentDirectory());
            /// <summary>
            /// XML処理ｸﾗｽ
            /// </summary>
            private clsXMLProcess poXMLProcess = new clsXMLProcess();
            /// <summary>
            /// XML出力ﾊﾟｽ
            /// </summary>
            private string XMLFilePath;
            /// <summary>
            /// ﾛｸﾞﾌｧｲﾙ出力ﾊﾟｽ
            /// </summary>
            private string LogFilePath;
        #endregion
        // **************************************************

        // **************************************************
        #region " 'ｺﾝｽﾄﾗｸﾀ"
            /// <summary>
            /// ｺﾝｽﾄﾗｸﾀ
            /// </summary>
            public clsCommonLogic()
            {
                // XMLﾌｧｲﾙﾊﾟｽを設定
                XMLFilePath = string.Format("{0}\\{1}", dCurrentDirectory.FullName, Const.XMLPath);
                // ﾛｸﾞﾌｧｲﾙ出力ﾊﾟｽを設定
                LogFilePath = string.Format("{0}\\{1}", dCurrentDirectory.FullName, Const.LOGPath);
            }
        #endregion
        // **************************************************

        // **************************************************
        #region " '初期起動時ﾁｪｯｸ処理"
        /// <summary>
        /// 初期起動時設定ﾁｪｯｸ処理
        /// </summary>
        /// <returns></returns>
        public bool checkFormSetting()
            {
                try
                {
                    // ｶﾚﾝﾄﾃﾞｨﾚｸﾄﾘにXMLﾌｫﾙﾀﾞが存在しない場合
                    if (!Directory.Exists(XMLFilePath))
                    {
                        // ｶﾚﾝﾄにXMLﾌｫﾙﾀﾞを作成
                        dCurrentDirectory.CreateSubdirectory(Const.XMLPath);
                        // XMLﾌｫﾙﾀﾞ内に設定XMLﾌｧｲﾙを作成
                        poXMLProcess.Spool(string.Format("{0}\\{1}", dCurrentDirectory.FullName, Const.XMLPath), Const.XMLPath);
                    }


                    // ｶﾚﾝﾄﾃﾞｨﾚｸﾄﾘにLOGﾌｫﾙﾀﾞが存在しない場合
                    if (!Directory.Exists(LogFilePath))
                    {
                        // ｶﾚﾝﾄにLOGﾌｫﾙﾀﾞを作成
                        dCurrentDirectory.CreateSubdirectory(Const.LOGPath);
                    }

                    return true;
                }
                catch (Exception e)
                {
                    clsLogManager LogManager = new clsLogManager();
                    LogManager.WriteLog(LogFilePath, e);
                    return false;
                }
            }
        #endregion
        // **************************************************

        // **************************************************
        #region " '設定内容取得処理"
        /// <summary>
        /// 設定内容取得処理
        /// </summary>
        /// <returns></returns>
        public DisplayData[] getFormSetting()
        {
            // 該当ﾌｧｲﾙﾊﾟｽの設定情報を取得
            return poXMLProcess.Read(XMLFilePath, Const.XMLPath);
        }
        #endregion
        // **************************************************

        // **************************************************
        #region " '設定内容設定処理"
        /// <summary>
        /// 設定内容設定処理
        /// </summary>
        /// <returns></returns>
        public void setFormSetting(DisplayData displayData,int listIndex)
        {
            // 該当ﾌｧｲﾙﾊﾟｽの設定情報を取得
            poXMLProcess.Update(XMLFilePath, Const.XMLPath,displayData, listIndex);
        }
        #endregion
        // **************************************************

        // **************************************************
        #region " 'ｲﾍﾞﾝﾄ内容取得"
        /// <summary>
        /// ﾃﾞﾘｹﾞｰﾄ
        /// </summary>
        /// <param name="displayDataList"></param>
        /// <returns></returns>
        public delegate string[] getDayofWeekEventContents(DisplayData[] displayDataList);
            /// <summary>
            /// 各曜日に該当した表示内容を取得する
            /// </summary>
            /// <returns></returns>
            public string getDayOfWeekEvent(getDayofWeekEventContents getEventContents)
            {
                try
                {
                    // 曜日を取得
                    DayOfWeek dayOfWeek = DateTime.Today.DayOfWeek;
                    // 設定ﾌｧｲﾙの配列を取得
                    DisplayData[] DisplayDataList = getFormSetting();
                    // ｲﾍﾞﾝﾄ配列を取得
                    string[] EventList = getEventContents(DisplayDataList);
                    // 当日の曜日に該当する内容を返却
                    return EventList[(int)dayOfWeek];
                }
                catch (Exception e)
                {
                    clsLogManager LogManager = new clsLogManager();
                    LogManager.WriteLog(LogFilePath, e);
                    return null;
                }  
            }
            /// <summary>
            /// 1行目のｲﾍﾞﾝﾄ
            /// </summary>
            /// <param name="displayDataList"></param>
            /// <returns></returns>
            public string[] getDayEvent1(DisplayData[] displayDataList)
            {
                // ｲﾍﾞﾝﾄ配列を取得
                return displayDataList[0].DayOfWeekEvent();

            }
            /// <summary>
            /// 2行目のｲﾍﾞﾝﾄ
            /// </summary>
            /// <param name="displayDataList"></param>
            /// <returns></returns>
            public string[] getDayEvent2(DisplayData[] displayDataList)
            {
                // ｲﾍﾞﾝﾄ配列を取得
                return displayDataList[1].DayOfWeekEvent();

            }
            /// <summary>
            /// 3行目のｲﾍﾞﾝﾄ
            /// </summary>
            /// <param name="displayDataList"></param>
            /// <returns></returns>
            public string[] getDayEvent3(DisplayData[] displayDataList)
            {
                // ｲﾍﾞﾝﾄ配列を取得
                return displayDataList[2].DayOfWeekEvent();

            }
            /// <summary>
            /// 4行目のｲﾍﾞﾝﾄ
            /// </summary>
            /// <param name="displayDataList"></param>
            /// <returns></returns>
            public string[] getDayEvent4(DisplayData[] displayDataList)
            {
                // ｲﾍﾞﾝﾄ配列を取得
                return displayDataList[3].DayOfWeekEvent();

            }
        #endregion
        // **************************************************

    }
}
