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

namespace ADODOTNETEXAMPLE
{
    public partial class ctlLoginForm : Form
    {
        public ctlLoginForm()
        {
            InitializeComponent();


        }
        SqlConnection sqlConnection;
        // it will clear the text in all the textboxes and pointing to id box(textbox1)
        public void clear()
        {
            ctlTxtUserName.Text = ctlTxtPassword.Text = ctlTxtID.Text ="";
            ctlTxtID.Focus();
        }

        public string conString = "Data Source=DELL;Initial Catalog=Suresh;Integrated Security=True";
        
        //it is login page

        private void ctlBtnLogin_Click(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(conString);
            sqlConnection.Open();
            
            if (ctlTxtUserName.Text != string.Empty && ctlTxtPassword.Text != string.Empty)
            {
                string sql = "select * from USER_DETAILS where USERNAME='" + ctlTxtUserName.Text.Trim() + "' AND PASSWORD='" + ctlTxtPassword.Text.Trim() + "'";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql, sqlConnection);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                if (dataTable.Rows.Count == 1)
                {
                    MessageBox.Show("you successfuly logedin","LoginPage",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    clear();
                }
                else
                {
                    MessageBox.Show("enter the correct username and password","LoginPage",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    clear();
                }
            }
            else
            {
                MessageBox.Show("Enter the data", "LoginPage", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clear();    
               
            }
            sqlConnection.Close();
            }
        //it will insert the data into the sqlserver
        private void ctlBtnRegister_Click(object sender, EventArgs e)
        {
           
           sqlConnection = new SqlConnection(conString);
            sqlConnection.Open();
            if (ctlTxtUserName.Text != string.Empty && ctlTxtPassword.Text != string.Empty)
            {
                string sqlQuery = "INSERT INTO USER_DETAILS(ID,USERNAME,PASSWORD)VALUES('" + ctlTxtID.Text.Trim() + "','" + ctlTxtUserName.Text.Trim() + "','" + ctlTxtPassword.Text.Trim() + "')";
                SqlCommand command = new SqlCommand(sqlQuery, sqlConnection);
                command.ExecuteNonQuery();
                MessageBox.Show(" inserted data successfuly","RegistrationPage",MessageBoxButtons.OK,MessageBoxIcon.Information);
                DisplayData();
                clear();
            }
            
            else
            {
                MessageBox.Show(" Enter the data","RegistrationPage",MessageBoxButtons.OK,MessageBoxIcon.Error);
                clear();
            }
            sqlConnection.Close();
        }
        public void DisplayData()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("select * from USER_DETAILS", sqlConnection);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlConnection.Close();
           
        }

        //it will search the prticular record by using id

        private void ctlBtnSearch_Click(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(conString);

            string search = "select * from USER_DETAILS where ID="+ctlTxtID.Text;
            SqlCommand command = new SqlCommand(search, sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlDataReader = command.ExecuteReader();
            if (sqlDataReader.Read())
            {
                ctlTxtUserName.Text = sqlDataReader["USERNAME"].ToString();
                ctlTxtPassword.Text = sqlDataReader["PASSWORD"].ToString();
                sqlDataReader.Close();
               // DisplayData();
                MessageBox.Show("Sucessfully Searched ", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            else
            {
                MessageBox.Show("Enter the valid data","Search",MessageBoxButtons.OK,MessageBoxIcon.Error);
                clear();
            }
            
            sqlConnection.Close();
        }

        //it will update the record in the table

        private void ctlBtnUpdate_Click(object sender, EventArgs e)
        {
             sqlConnection = new SqlConnection(conString);

            string search = "UPDATE USER_DETAILS set username='"+ctlTxtUserName.Text+"',password='"+ctlTxtPassword.Text+"' where ID=" + ctlTxtID.Text;
            SqlCommand command = new SqlCommand(search, sqlConnection);
            sqlConnection.Open();
            command.ExecuteNonQuery();
            DisplayData();
            MessageBox.Show("Record Updated Successfuly", "UpdatePage", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //it will delete the prticular record in the table

        private void ctlBtnDelete_Click(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(conString);
            string search = "delete USER_DETAILS  where ID=" + ctlTxtID.Text;
            SqlCommand command = new SqlCommand(search, sqlConnection);
            sqlConnection.Open();
            command.ExecuteNonQuery();
            DisplayData();            
            MessageBox.Show("Deleted Record successfuly", "UpdatePage",MessageBoxButtons.OK,MessageBoxIcon.Error);
            clear();
        }

        //it will display the data in datagridview

        private void ctlBtnDisplayData_Click(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(conString);
            
            //Method2
            //string display = "SELECT * FROM USER_DETAILS";
            //sqlConnection.Open();
            //SqlDataAdapter adapt = new SqlDataAdapter(display, sqlConnection);
            //DataTable dt = new DataTable();
            //adapt.Fill(dt);
            //dataGridView1.DataSource = dt;
            //sqlConnection.Close();
            //clear

            DisplayData();  //calling dataDisplay Method
         
        }

        private void ctlLoginForm_Load(object sender, EventArgs e)
        {
            
    }
    }
    }

