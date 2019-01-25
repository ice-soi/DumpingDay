using DumpingDay.Control;
using DumpingDay.Data;
using DumpingDay.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DumpingDay
{
    #region " 'ﾌｫｰﾑｸﾗｽ"
    /// <summary>
    /// ﾌｫｰﾑｸﾗｽ
    /// </summary>
    public partial class Main : Form
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
        #region " 'Initialize"
            /// <summary>
            /// Initialize
            /// </summary>
            public Main()
            {
                InitializeComponent();
                // 設定ﾌｧｲﾙ初期ﾁｪｯｸ
                if (!CommonBL.checkFormSetting())
                {
                    MessageBox.Show(Const.ERROR_MSG_SETTING_XML);
                }
            }
        #endregion
        // **************************************************

        // **************************************************
        #region " 'Load"
            /// <summary>
            /// Formのﾛｰﾄﾞｲﾍﾞﾝﾄ
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void Main_Load(object sender, EventArgs e)
            {
                // 画面設定
                setFormInit();
            }
        #endregion
        // **************************************************

        // **************************************************
        #region " 'Reload"
            /// <summary>
            /// ﾘﾛｰﾄﾞ
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void btnReload_Click(object sender, EventArgs e)
            {
                // 画面設定
                setFormInit();
            }
        #endregion
        // **************************************************

        // **************************************************
        #region " 'Setting"
            /// <summary>
            /// 設定
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void btnSetting_Click(object sender, EventArgs e)
            {
                // 設定画面
                Setting setting = new Setting();
                if (setting.ShowDialog() == DialogResult.OK)
                {
                    // 画面設定
                    setFormInit();
                }
            }
        #endregion
        // **************************************************

        // **************************************************
        #region " 'ｸﾛｰｽﾞ"
        /// <summary>
        /// ｸﾛｰｽﾞ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
            {
                this.Close();
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
            private void Main_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
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
            private void Main_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
            {
                if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
                {
                    mousePoint = new Point(e.X, e.Y);
                }
            }
        #endregion
        // **************************************************

        // **************************************************
        #region " '設定内容設定処理"
        /// <summary>
        /// ﾌｫｰﾑの内容設定
        /// </summary>
        private void setFormInit()
            {
                // 今日の日付を取得
                setCurrentDate();
                // 今日の曜日を取得
                setDayofWeek();
                // ﾒﾓ1を取得
                setMemo1();
                // ﾒﾓ2を取得
                setMemo2();
                // ﾒﾓ3を取得
                setMemo3();
                // ﾒﾓ4を取得
                setMemo4();
            }
            /// <summary>
            /// 今現在の日付を取得
            /// </summary>
            private void setCurrentDate()
            {
                // 今日の日付を取得
                lblCurrentDate.Text = DateTime.Today.ToString("yyyy年MM月dd日");
            }
            /// <summary>
            /// 今日の曜日を返却
            /// </summary>
            private void setDayofWeek()
            {
                // 曜日を取得
                lblDayofWeek.Text = string.Format("({0})",Const.sArrayDayofWeek[(int)DateTime.Today.DayOfWeek]);
            }
            /// <summary>
            /// ﾒﾓ1を取得
            /// </summary>
            private void setMemo1()
            {
                // 該当の項目を取得
                lblMemo1.Text = CommonBL.getDayOfWeekEvent(CommonBL.getDayEvent1);   
            }
            /// <summary>
            /// ﾒﾓ2を取得
            /// </summary>
            private void setMemo2()
            {
                lblMemo2.Text = CommonBL.getDayOfWeekEvent(CommonBL.getDayEvent2);
            }
            /// <summary>
            /// ﾒﾓ3を取得
            /// </summary>
            private void setMemo3()
            {
                lblMemo3.Text = CommonBL.getDayOfWeekEvent(CommonBL.getDayEvent3);

            }
            /// <summary>
            /// ﾒﾓ4を取得
            /// </summary>
            private void setMemo4()
            {
                lblMemo4.Text = CommonBL.getDayOfWeekEvent(CommonBL.getDayEvent4);
            }
        #endregion
        // **************************************************
    }
    #endregion
}
