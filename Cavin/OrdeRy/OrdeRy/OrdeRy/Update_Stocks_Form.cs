using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace OrdeRy
{
    public partial class Update_Stocks_Form : Form
    {
        public Update_Stocks_Form()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();

        //string query;
        int result;


        //for updating database products 
        public void Update100()
        {

            try
            {
                conn.Open();
                string queryUpdate = "UPDATE tblProducts SET ProductQuantity=" + Qty.Text + "WHERE ProductId=100";
                cmd.Connection = conn;
                cmd.CommandText = queryUpdate;
                result = cmd.ExecuteNonQuery();
                conn.Close();
                //MessageBox.Show("Done updating");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update Form" + ex.Message);
            }
        }
        //------------------------------------------------------------------
        public void Update101()
        {
            try
            {
                conn.Open();
                string queryUpdate = "UPDATE tblProducts SET ProductQuantity=" + Qty1.Text + "WHERE ProductId=101";
                cmd.Connection = conn;
                cmd.CommandText = queryUpdate;
                result = cmd.ExecuteNonQuery();
                conn.Close();
                //MessageBox.Show("Done updating");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update Form" + ex.Message);
            }
        }
        //------------------------------------------------------------------
        public void Update102()
        {

            try
            {
                conn.Open();
                string queryUpdate = "UPDATE tblProducts SET ProductQuantity=" + Qty2.Text + "WHERE ProductId=102";
                cmd.Connection = conn;
                cmd.CommandText = queryUpdate;
                result = cmd.ExecuteNonQuery();
                conn.Close();
                //MessageBox.Show("Done updating");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update Form" + ex.Message);
            }
        }
        //------------------------------------------------------------------
        public void Update103()
        {

            try
            {
                conn.Open();
                string queryUpdate = "UPDATE tblProducts SET ProductQuantity=" + Qty3.Text + "WHERE ProductId=103";
                cmd.Connection = conn;
                cmd.CommandText = queryUpdate;
                result = cmd.ExecuteNonQuery();
                conn.Close();
                //MessageBox.Show("Done updating");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update Form" + ex.Message);
            }
        }
        //------------------------------------------------------------------
        public void Update104()
        {

            try
            {
                conn.Open();
                string queryUpdate = "UPDATE tblProducts SET ProductQuantity=" + Qty4.Text + "WHERE ProductId=104";
                cmd.Connection = conn;
                cmd.CommandText = queryUpdate;
                result = cmd.ExecuteNonQuery();
                conn.Close();
                //MessageBox.Show("Done updating");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update Form" + ex.Message);
            }
        }
        //------------------------------------------------------------------
        public void Update105()
        {
            try
            {
                conn.Open();
                string queryUpdate = "UPDATE tblProducts SET ProductQuantity=" + Qty4Iced.Text + "WHERE ProductId=105";
                cmd.Connection = conn;
                cmd.CommandText = queryUpdate;
                result = cmd.ExecuteNonQuery();
                conn.Close();
                //MessageBox.Show("Done updating");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update Form" + ex.Message);
            }
        }

        //------------------------------------------------------------------
        public void Update106()
        {
            try
            {
                conn.Open();
                string queryUpdate = "UPDATE tblProducts SET ProductQuantity=" + Qty5.Text + "WHERE ProductId=106";
                cmd.Connection = conn;
                cmd.CommandText = queryUpdate;
                result = cmd.ExecuteNonQuery();
                conn.Close();
                //MessageBox.Show("Done updating");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update Form" + ex.Message);
            }
        }

        //for updating database starting stocks 
        public void bs100()
        {

            try
            {
                conn.Open();
                string queryUpdate = "UPDATE Starting SET qty=" + Qty.Text + "WHERE ID=100";
                cmd.Connection = conn;
                cmd.CommandText = queryUpdate;
                result = cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update Form" + ex.Message);
            }
        }
        //------------------------------------------------------------------
        public void bs101()
        {
            try
            {
                conn.Open();
                string queryUpdate = "UPDATE Starting SET qty=" + Qty1.Text + "WHERE ID=101";
                cmd.Connection = conn;
                cmd.CommandText = queryUpdate;
                result = cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update Form" + ex.Message);
            }
        }
        //------------------------------------------------------------------
        public void bs102()
        {

            try
            {
                conn.Open();
                string queryUpdate = "UPDATE Starting SET qty=" + Qty2.Text + "WHERE ID=102";
                cmd.Connection = conn;
                cmd.CommandText = queryUpdate;
                result = cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update Form" + ex.Message);
            }
        }
        //------------------------------------------------------------------
        public void bs103()
        {

            try
            {
                conn.Open();
                string queryUpdate = "UPDATE Starting SET qty=" + Qty3.Text + "WHERE ID=103";
                cmd.Connection = conn;
                cmd.CommandText = queryUpdate;
                result = cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update Form" + ex.Message);
            }
        }
        //------------------------------------------------------------------
        public void bs104()
        {

            try
            {
                conn.Open();
                string queryUpdate = "UPDATE Starting SET qty=" + Qty4.Text + "WHERE ID=104";
                cmd.Connection = conn;
                cmd.CommandText = queryUpdate;
                result = cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update Form" + ex.Message);
            }
        }
        //------------------------------------------------------------------
        public void bs105()
        {
            try
            {
                conn.Open();
                string queryUpdate = "UPDATE Starting SET qty=" + Qty4Iced.Text + "WHERE ID=105";
                cmd.Connection = conn;
                cmd.CommandText = queryUpdate;
                result = cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update Form" + ex.Message);
            }
        }

        //------------------------------------------------------------------
        public void bs106()
        {
            try
            {
                conn.Open();
                string queryUpdate = "UPDATE Starting SET qty=" + Qty5.Text + "WHERE ID=106";
                cmd.Connection = conn;
                cmd.CommandText = queryUpdate;
                result = cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update Form" + ex.Message);
            }
        }

        //close and save
        private void btnDone_Click(object sender, EventArgs e)
        {
            

                if (Qty.Text=="" && Qty1.Text=="" && Qty2.Text == "" && Qty3.Text == "" && Qty4.Text == "" && Qty5.Text == "" && Qty4Iced.Text == "") {
                    MessageBox.Show("You did not put any value.");
                }
                else{
                DialogResult dialogResult = MessageBox.Show("Are you sure?", "ADD", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (Qty.Text != "")////////////////////////eto yung may checkbox
                    {
                        Update100();
                        bs100();
                    }
                    if (Qty1.Text != "")
                    {
                        Update101();
                        bs101();
                    }
                    if (Qty2.Text != "")
                    {
                        Update102();
                        bs102();
                    }
                    if (Qty3.Text != "")
                    {
                        Update103();
                        bs103();
                    }
                    if (Qty4.Text != "")
                    {
                        Update104();
                        bs104();
                    }
                    if (Qty4Iced.Text != "")
                    {
                        //bagong update
                        Update105();
                        bs105();
                    }
                    if (Qty5.Text != "")
                    {
                        Update106();
                        bs106();
                    }
                    this.Close();
                }
                
            }
  
        }
        


        //Onload form
        private void Update_Stocks_Form_Load(object sender, EventArgs e)
        {
            conn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\PZ\Stocks_BD.mdf;Integrated Security=True;Connect Timeout=30";
            this.KeyPreview = true;

        }

        private void Update_Stocks_Form_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    btnDone_Click(sender, e);
                    break;
            }
        }
    }
}
