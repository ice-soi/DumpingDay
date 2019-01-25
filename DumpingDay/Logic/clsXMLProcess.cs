using System.IO;
using System.Xml.Serialization;
using System.Configuration;
using System.Text;
using DumpingDay.Data;

namespace DumpingDay.Logic
{
    class clsXMLProcess
    {
        //****************************************************
        #region "' ｺﾝｽﾄﾗｸﾀ"
        /// <summary>
        /// ｺﾝｽﾄﾗｸﾀ
        /// </summary>
        public clsXMLProcess()
        {
        }
        #endregion
        //****************************************************

        //****************************************************
        #region " '設定用XML出力処理"
        /// <summary>
        /// 設定XML出力処理
        /// </summary>
        /// <param name="sFilePathTag"></param>
        /// <param name="fXmlFile"></param>
        public void Spool(string sFilePath,string sXMLName)
        {
            // 表示ﾒﾓ1から4までのXMLをｽﾌﾟｰﾙ
            for (int count = 1; count <= 4; count++)
            {
                // ｽﾌﾟｰﾙ
                spoolSettingXml(string.Format(sFilePath + "\\{0}{1}.xml", sXMLName, count.ToString()));
            }
        }
        /// <summary>
        /// 設定XML出力処理
        /// </summary>
        /// <param name="sFilePathTag"></param>
        /// <param name="fXmlFile"></param>
        public DisplayData[] Read(string sFilePath, string sXMLName)
        {
            DisplayData[] DisplayDataList = new DisplayData[4];

            // 表示ﾒﾓ1から4までのXMLをｽﾌﾟｰﾙ
            for (int count = 1; count <= 4; count++)
            {
                // ｽﾌﾟｰﾙ
                DisplayDataList[count - 1] = readSettingXML(string.Format(sFilePath + "\\{0}{1}.xml", sXMLName, count.ToString()));
            }
            // ﾘﾀｰﾝ
            return DisplayDataList;
        }
        /// <summary>
        /// 設定XML出力処理
        /// </summary>
        /// <param name="sFilePathTag"></param>
        /// <param name="fXmlFile"></param>
        public void Update(string sFilePath, string sXMLName, DisplayData displayData,int listIndex)
        {
            // XML更新処理
            updateSettingXML(string.Format(sFilePath + "\\{0}{1}.xml", sXMLName, listIndex.ToString()), displayData);
        }
        #endregion
        //****************************************************

        //****************************************************
        #region "' XML出力"
        /// <summary>
        /// 設定XML出力
        /// </summary>
        /// <param name="sFullPath"></param>
        private void spoolSettingXml(string sFullPath)
        {
            // 出力用ｸﾗｽを設定
            DisplayData oDisplayData = new DisplayData();
            // ﾌｧｲﾙを開く
            using (StreamWriter lStreamWriter = new StreamWriter(sFullPath, false, new UTF8Encoding(false)))
            {
                // 設定ﾌｧｲﾙ用のXmlSirializerの作成
                XmlSerializer lXMLSerializer = new XmlSerializer(typeof(DisplayData));
                // ｱｸｾｽ情報をｼﾘｱﾙ化してXMLに出力
                lXMLSerializer.Serialize(lStreamWriter, oDisplayData);
            } 
        }
        #endregion
        //****************************************************

        //****************************************************
        #region "' XML読込"
        /// <summary>
        /// 設定XML読込
        /// </summary>
        /// <param name="sFullPath"></param>
        private DisplayData readSettingXML(string sFullPath)
        {
            // 読込用ｸﾗｽを設定
            DisplayData oDisplayData = new DisplayData();
            // ﾌｧｲﾙを開く
            using (StreamReader lStreamReader = new StreamReader(sFullPath, new UTF8Encoding(false)))
            {
                // ｱｸｾｽ用のXmlSirializerの作成
                XmlSerializer lXMLSerializer = new XmlSerializer(typeof(DisplayData));
                // ｱｸｾｽ情報をｼﾘｱﾙ化してXMLに出力
                oDisplayData = (DisplayData)lXMLSerializer.Deserialize(lStreamReader);
                // ﾘﾀｰﾝ
                return oDisplayData;
            }
        }
        #endregion
        //****************************************************

        //****************************************************
        #region "' XML出力"
        /// <summary>
        /// 設定XML出力
        /// </summary>
        /// <param name="sFullPath"></param>
        private void updateSettingXML(string sFullPath, DisplayData oDisplayData)
        {
            // ﾌｧｲﾙを開く
            using (StreamWriter lStreamWriter = new StreamWriter(sFullPath, false, new UTF8Encoding(false)))
            {
                // 設定ﾌｧｲﾙ用のXmlSirializerの作成
                XmlSerializer lXMLSerializer = new XmlSerializer(typeof(DisplayData));
                // ｱｸｾｽ情報をｼﾘｱﾙ化してXMLに出力
                lXMLSerializer.Serialize(lStreamWriter, oDisplayData);
            }
        }
        #endregion
        //****************************************************
    }
}
