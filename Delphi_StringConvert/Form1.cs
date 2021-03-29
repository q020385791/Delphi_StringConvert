using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delphi_StringConvert
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnstr2SQL_Click(object sender, EventArgs e)
        {
            txtResult.Text = "";
            string ConvertWay = "";
            if (!IfRadChecked(out ConvertWay))
            {
                MessageBox.Show("請點選轉換方式");
                return;
            }


            if (ConvertWay == "SQLAdd")
            {
                string Source = txtSource.Text.ToUpper();
                string Result = "";
                //將語法的SQL.Add、前後括弧、最後的分號 去除
                Result=Source.Replace("SQL.ADD('", "").Replace("');", "").Replace("''", "'");
                txtResult.Text = Result;
            }

            if (ConvertWay == "sSQL")
            {
                string Source = txtSource.Text.ToUpper();
                string Result = "";
                foreach (string Line in txtSource.Lines)
                {
                        string temp = Line;
                    temp = temp.Trim().Replace(';', ' ');
                    #region 去除最前的+'
                    if (temp.IndexOf("+") != -1&& (temp.IndexOf("+")==0))
                    {
                        temp = temp.Remove(temp.IndexOf("+"), 1);
                    }

                    //if (temp.Length > 0)
                    //{
                    //    temp = temp.Remove(temp.Length - 1, 1);
                    //}

                    if (temp.IndexOf("'") != -1)
                    {
                       
                        var tchararray = temp.ToCharArray();
                        temp = new string(tchararray).Remove(temp.IndexOf("'"), 1);
                        tchararray = temp.ToCharArray();
                        Array.Reverse(tchararray);
                        var reArray = new string(tchararray);
                        temp = reArray.Remove(reArray.IndexOf("'"), 1);
                        tchararray = temp.ToCharArray();
                        Array.Reverse(tchararray);
                        temp = new string(tchararray);
                    }

         
                        
                    temp = temp.Replace("''", "'");
                    #endregion

                        Result += temp+Environment.NewLine;
                }

                txtResult.Text = Result;
            }
        }

      

        private void btnSQL2str_Click(object sender, EventArgs e)
        {
            txtResult.Text = "";
            string ConvertWay = "";
            if (!IfRadChecked(out ConvertWay))
            {
                MessageBox.Show("請點選轉換方式");
                return;
            }


            if (ConvertWay == "SQLAdd")
            {
                foreach (var item in txtSource.Lines)
                {
                    string temp = item;
                    temp=temp.Replace("'", "''");
                    temp = "SQL.ADD('" + temp;
                    temp = temp + "\');";

                    txtResult.Text += temp+Environment.NewLine;
                }
            }

            if (ConvertWay == "sSQL")
            {
                for (int i = 0; i < txtSource.Lines.Count(); i++)
                {
                    string temp = txtSource.Lines[i];
                    temp = temp.Replace("'", "''");
                    if (i != 0)
                    {
                        temp = "+'" + temp + "'";
                    }
                    else 
                    {
                        temp = "'" + temp +"'";


                    }
                    if (i== txtSource.Lines.Count()-1)
                    {
                        temp = temp + ";";
                    }
                  

                    txtResult.Text += temp + Environment.NewLine;
                }

            }
        }
        /// <summary>
        /// 確認是否點選轉換方式
        /// </summary>
        /// <returns></returns>
        public bool IfRadChecked(out string ConvertWay)
        {

            if (radSQLAdd.Checked == false && radsSQL.Checked == false)
            {
                ConvertWay = "";
                return false;
            }

            if (radSQLAdd.Checked == true)
            {
                ConvertWay = "SQLAdd";
                return true;
            }

            if (radsSQL.Checked == true)
            {
                ConvertWay = "sSQL";
                return true;
            }
            ConvertWay = "";
            return false;

        }

        private void btnCleartxt_Click(object sender, EventArgs e)
        {
            txtSource.Text = "";
            txtResult.Text = "";
        }

        private void radSQLAdd_Click(object sender, EventArgs e)
        {
            labMemo.Text = "";
            labMemo.Text = "SQLAddSQLTostringEX ： SQL.ADD('Select * From UserAccount')<<<<>>>> Select * From UserAccount"
                + Environment.NewLine;

        }

        private void radsSQL_Click(object sender, EventArgs e)
        {
            labMemo.Text = "";
            labMemo.Text = "sSQLTostringEX ：" + Environment.NewLine + "  Select * from UserAccount " + Environment.NewLine
                                                           + " Where acc=:sacc" + Environment.NewLine
                                                           + "↓↓↓" + "" + Environment.NewLine
                                                           + "' Select * from UserAccount '" + Environment.NewLine
                                                           + "'Where acc=:sacc'";
        }
    }
}
