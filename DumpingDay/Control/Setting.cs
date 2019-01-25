using DumpingDay.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DumpingDay.Control
{
    public partial class Setting : Form
    {
        // **************************************************
        #region"' ｸﾗｽ変数"
            /// <summary>
            /// ﾏｳｽのｸﾘｯｸ位置
            /// </summary>
            private Point mousePoint;
            /// <summary>
            /// 共通BL 
            /// </summary>
            private clsCommonLogic CommonBL = new clsCommonLogic();
        #endregion
        // **************************************************

        // **************************************************
        #region " 'ｺﾝｽﾄﾗｸﾀ"
            /// <summary>
            /// ｺﾝｽﾄﾗｸﾀ
            /// </summary>
            public Setting()
            {
                InitializeComponent();
                // ｺﾝﾎﾞﾎﾞｯｸｽ設定
                setComboList();
            }
        #endregion
        // **************************************************

        // **************************************************
        #region " 'ｺﾝﾄﾛｰﾙ設定"
            /// <summary>
            /// ｺﾝﾎﾞﾎﾞｯｸｽ設定
            /// </summary>
            private void setComboList()
            {
                // ﾘｽﾄの設定を行う
                for (int count = 1; count <= 4; count++)
                {
                    this.cmbEventList.Items.Add(string.Format(Const.XMLPath + "{0}", count.ToString()));
                }
                // 先頭の項目を選択状態にする
                this.cmbEventList.SelectedIndex = 0;
            }
            /// <summary>
            /// 取得設定
            /// </summary>
            private void setTextBox()
            {
                // 設定ﾌｧｲﾙの配列を取得
                DisplayData[] DisplayDataList = CommonBL.getFormSetting();
                // 選択したﾘｽﾄｲﾝﾃﾞｯｸｽの取得
                int listIndex = cmbEventList.SelectedIndex;
                // ﾃｷｽﾄﾎﾞｯｸｽに画面項目を設定
                this.txtSunday.Text = DisplayDataList[listIndex].SundayMessage;
                this.txtMonday.Text = DisplayDataList[listIndex].MondaydayMessage;
                this.txtTuesday.Text = DisplayDataList[listIndex].TuesdayMessage;
                this.txtWednesday.Text = DisplayDataList[listIndex].WednesdayMessage;
                this.txtThursday.Text = DisplayDataList[listIndex].ThursdayMessage;
                this.txtFriday.Text = DisplayDataList[listIndex].FridayMessage;
                this.txtSaturday.Text = DisplayDataList[listIndex].SaturdayMessage;
            }
            /// <summary>
            /// XML設定
            /// </summary>
            private void getTextBox()
            {
                // 設定ﾌｧｲﾙの配列を取得
                DisplayData oDisplayData = new DisplayData();
                // 選択したﾘｽﾄｲﾝﾃﾞｯｸｽの取得
                int listIndex = cmbEventList.SelectedIndex + 1;
                // ﾃｷｽﾄﾎﾞｯｸｽに画面項目を設定
                oDisplayData.SundayMessage = this.txtSunday.Text;
                oDisplayData.MondaydayMessage = this.txtMonday.Text;
                oDisplayData.TuesdayMessage = this.txtTuesday.Text;
                oDisplayData.WednesdayMessage = this.txtWednesday.Text;
                oDisplayData.ThursdayMessage = this.txtThursday.Text;
                oDisplayData.FridayMessage = this.txtFriday.Text;
                oDisplayData.SaturdayMessage = this.txtSaturday.Text;
                // 更新処理
                CommonBL.setFormSetting(oDisplayData, listIndex);
            }
        #endregion
        // **************************************************

        // **************************************************
        #region " 'ﾘｽﾄｲﾍﾞﾝﾄ"
        /// <summary>
        /// ﾘｽﾄ選択変更
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbEventList_SelectedIndexChanged(object sender, EventArgs e)
            {
                setTextBox();
            }
        #endregion
        // **************************************************

        // **************************************************
        #region " 'Close"
        /// <summary>
        /// Close
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
            {
                this.DialogResult = DialogResult.OK;
            }
        #endregion
        // **************************************************

        // **************************************************
        #region " 'Update"
            /// <summary>
            /// Update
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void btnUpdate_Click(object sender, EventArgs e)
            {
                // ﾃｷｽﾄﾎﾞｯｸｽの内容をXMLに設定
                getTextBox();
                // 画面を閉じる
                this.DialogResult = DialogResult.OK;
            }
        #endregion
        // **************************************************

        // **************************************************
        #region " 'ﾌｫｰﾑ移動" 
            /// <summary>
            /// ﾏｳｽが移動した場合のｲﾍﾞﾝﾄ
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void Setting_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
            {
                if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
                {
                    this.Left += e.X - mousePoint.X;
                    this.Top += e.Y - mousePoint.Y;
                }
            }
            /// <summary>
            /// ﾏｳｽを押したときのｲﾍﾞﾝﾄ
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void Setting_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
            {
                if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
                {
                    mousePoint = new Point(e.X, e.Y);
                }
            }
        #endregion
        // **************************************************
    }
}
