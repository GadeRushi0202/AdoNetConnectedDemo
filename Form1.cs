using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace AdoNetConnectedDemo
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader reader;
        public Form1()
        {
            InitializeComponent();
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString);
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                List<Dept> list = new List<Dept>();
                string qry = "Select * from Dept";
                cmd = new SqlCommand(qry, con);
                con.Open();
                reader = cmd.ExecuteReader();
                
                if(reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Dept dept = new Dept();
                        dept.Did = Convert.ToInt32(reader["did"]);//Colomn Name
                        dept.Dname = reader["dname"].ToString();
                        list.Add(dept);
                    }

                }
                //Display dname and on selection of dname we need dname 
                comboDept.DataSource = list;
                comboDept.DisplayMember="Dname"; //Match property name
                comboDept.ValueMember = "did";


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { 
                con.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "insert into Employee values(@name,@email,@age,@salary,@did)";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@name", textName.Text);
                cmd.Parameters.AddWithValue("@email", textEmail.Text);
                cmd.Parameters.AddWithValue("@age", Convert.ToInt32(textAge.Text));
                cmd.Parameters.AddWithValue("@Salary", Convert.ToDouble(textSalary.Text));
                cmd.Parameters.AddWithValue("@did", Convert.ToInt32(comboDept.SelectedValue));
                con.Open();
                int result =cmd.ExecuteNonQuery();
                if(result >= 1)
                {
                    MessageBox.Show("Record Inserted");
                    ClearField();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            { 
                con.Close();
            }    
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "select e.*,d.dname from Employee e inner join dept d on d.did = e.did where e.id=@id";

                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(textId.Text));
                con.Open();
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                        textName.Text = reader["name"].ToString();
                        textEmail.Text = reader["email"].ToString();
                        textAge.Text = reader["age"].ToString();
                        textSalary.Text = reader["salary"].ToString();
                        comboDept.Text = reader["dname"].ToString();
                    }

                }
                else
                {
                    MessageBox.Show("Record Not Found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try {
                string qry = "update Employee set name=@name,email=@email,age=@age, salary = @salary, did=@did where id=@id ";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@name", textName.Text);
                cmd.Parameters.AddWithValue("@email", textEmail.Text);
                cmd.Parameters.AddWithValue("@age", Convert.ToInt32(textAge.Text));
                cmd.Parameters.AddWithValue("@Salary", Convert.ToDouble(textSalary.Text));
                cmd.Parameters.AddWithValue("@did", Convert.ToInt32(comboDept.SelectedValue));
                cmd.Parameters.AddWithValue("@id",Convert.ToInt32(textId.Text));    
                con.Open();
                int result = cmd.ExecuteNonQuery();
                if (result >= 1)
                {
                    MessageBox.Show("Record Upadate");
                    ClearField();
                }
            }
            
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            { 
                con.Close();
            } 

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "delete from Employee where id=@id ";
                cmd = new SqlCommand(qry, con);
                
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(textId.Text));
                con.Open();
                int result = cmd.ExecuteNonQuery();
                if (result >= 1)
                {
                    MessageBox.Show("Record Delete");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            GetAllEmployee();
        }
        public void GetAllEmployee()
        {
            string qry = "select e.*,d.dname from Employee e inner join dept d on d.did = e.did";
            cmd= new SqlCommand(qry, con);
            con.Open() ;
            reader = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            dataGridView1.DataSource=table;
            con.Close();
        }
        private void ClearField()
        {
            textId.Clear();
            textName.Clear();
            textEmail.Clear();
            textAge.Clear();
            textSalary.Clear();
            comboDept.Refresh();
        }
        private void btnShowall_Click(object sender, EventArgs e)
        {
            try
            {
                GetAllEmployee();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { 
                con.Close(); 
            }

        }
    }
}
