using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace QLSV
{
    public partial class Students : Form
    {
        public Students()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Trung\OneDrive\Documents\School.mdf;Integrated Security=True;Connect Timeout=30");
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if(StNameTb.Text == "" || FeesTb.Text == "" || AddressTb.Text == "" || StGenCb.SelectedIndex == -1 || ClassCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into StudentTbl(StName, StGen, StDOB, StClass, StFees, StAdd) value (@SName, @SGen, @SDob, @SClass, @SFees, @SAdd)", Con);
                cmd.Parameters.AddWithValue("@SName", StNameTb.Text);
                cmd.Parameters.AddWithValue("@SGen", StGenCb.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@SDob", DOBPicker.Value.Date);
                cmd.Parameters.AddWithValue("@SClass", ClassCb.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@SFees", FeesTb.Text);
                cmd.Parameters.AddWithValue("@SAdd", AddressTb.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Student Added");
                Con.Close();
            }
        }
    }
}
