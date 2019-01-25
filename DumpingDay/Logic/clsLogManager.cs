using System.IO;
using System.Configuration;
using System;

namespace DumpingDay.Logic
{
    class clsLogManager
    {
        //****************************************************
        #region " '出力処理"
        /// <summary>
        /// ﾛｸﾞ出力処理
        /// </summary>
        /// <param name="sFilePathTag"></param>
        /// <param name="ex"></param>
        public void WriteLog(string sFullPath, Exception ex)
        {
            // ｶﾚﾝﾄﾃﾞｨﾚｸﾄﾘ取得
            DirectoryInfo dCurrentDirectory = new DirectoryInfo(Directory.GetCurrentDirectory());
            // 出力
            using (StreamWriter lStreamWriter = new StreamWriter(string.Format(sFullPath + "\\{0}.txt", DateTime.Today.ToString("yyyyMMdd")), true))
            {
                // ﾛｸﾞ出力
                lStreamWriter.WriteLine(DateTime.Now.ToString("yyyy年MM月dd日 HH:mm:ss") + ex.Message + ex.StackTrace + ex.Source);
            }
        }
        #endregion 
        //****************************************************
    }
}
