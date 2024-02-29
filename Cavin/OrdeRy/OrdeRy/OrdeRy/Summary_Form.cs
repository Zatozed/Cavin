using System;
using System.Data;
using System.Data.SqlClient;

using System.Windows.Forms;

namespace OrdeRy
{
    public partial class Summary_Form : Form
    {
        public Summary_Form()
        {
            InitializeComponent();
        }
        //initialize all classes
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        SqlDataReader dr;

        //variables for sql
        string query;
        //int result;


        //for values of starting and remaining stocks 

        string p100, p101, p102, p103, p104, p105, p106,r100, r101, r102, r103, r104, r105, r106;

        //the number of sold prdcts
        int soldLanzonesW, soldBananaW, soldRiceW, soldLanzonesC, soldRiceCH, soldRiceCI, soldBananaC;

        //sums
        int sumLanzonesW, sumBananaW, sumRiceW, sumLanzonesC, sumRiceCH, sumRiceCI, sumBananaC, total;

        //reading values from Starting table

        public void ReadStartingStocks() {
            try
            {
                //-----------------------------------------------------100
                conn.Open();
                query = "SELECT ProductQuantity FROM tblProducts WHERE ProductId=100";
                cmd.Connection = conn;
                cmd.CommandText = query;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    r100 = (dr["ProductQuantity"].ToString());
                }
                conn.Close();
                //----------------------------------------------------101
                conn.Open();
                query = "SELECT ProductQuantity FROM tblProducts WHERE ProductId=101";
                cmd.Connection = conn;
                cmd.CommandText = query;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    r101 = (dr["ProductQuantity"].ToString());
                }
                conn.Close();
                //----------------------------------------------------102
                conn.Open();
                query = "SELECT ProductQuantity FROM tblProducts WHERE ProductId=102";
                cmd.Connection = conn;
                cmd.CommandText = query;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    r102 = (dr["ProductQuantity"].ToString());
                }
                conn.Close();
                //----------------------------------------------------103
                conn.Open();
                query = "SELECT ProductQuantity FROM tblProducts WHERE ProductId=103";
                cmd.Connection = conn;
                cmd.CommandText = query;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    r103 = (dr["ProductQuantity"].ToString());
                }
                conn.Close();
                //----------------------------------------------------104
                conn.Open();
                query = "SELECT ProductQuantity FROM tblProducts WHERE ProductId=104";
                cmd.Connection = conn;
                cmd.CommandText = query;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    r104 = (dr["ProductQuantity"].ToString());
                }
                conn.Close();
                //----------------------------------------------------105
                conn.Open();
                query = "SELECT ProductQuantity FROM tblProducts WHERE ProductId=105";
                cmd.Connection = conn;
                cmd.CommandText = query;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    r105 = (dr["ProductQuantity"].ToString());
                }
                conn.Close();
                //----------------------------------------------------106
                conn.Open();
                query = "SELECT ProductQuantity FROM tblProducts WHERE ProductId=106";
                cmd.Connection = conn;
                cmd.CommandText = query;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    r106 = (dr["ProductQuantity"].ToString());
                }
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Sum to  " + ex);
            }
        }

        //read the remaining stocks
        public void ReadRemainingS() {
            try
            {
                //-----------------------------------------------------100
                conn.Open();
                query = "SELECT qty FROM Starting WHERE ID=100";
                cmd.Connection = conn;
                cmd.CommandText = query;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    p100 = (dr["qty"].ToString());
                }
                conn.Close();
                //----------------------------------------------------101
                conn.Open();
                query = "SELECT qty FROM Starting WHERE ID=101";
                cmd.Connection = conn;
                cmd.CommandText = query;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    p101 = (dr["qty"].ToString());
                }
                conn.Close();
                //----------------------------------------------------102
                conn.Open();
                query = "SELECT qty FROM Starting WHERE ID=102";
                cmd.Connection = conn;
                cmd.CommandText = query;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    p102 = (dr["qty"].ToString());
                }
                conn.Close();
                //----------------------------------------------------103
                conn.Open();
                query = "SELECT qty FROM Starting WHERE ID=103";
                cmd.Connection = conn;
                cmd.CommandText = query;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    p103 = (dr["qty"].ToString());
                }
                conn.Close();
                //----------------------------------------------------104
                conn.Open();
                query = "SELECT qty FROM Starting WHERE ID=104";
                cmd.Connection = conn;
                cmd.CommandText = query;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    p104 = (dr["qty"].ToString());
                }
                conn.Close();
                //----------------------------------------------------105
                conn.Open();
                query = "SELECT qty FROM Starting WHERE ID=105";
                cmd.Connection = conn;
                cmd.CommandText = query;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    p105 = (dr["qty"].ToString());
                }
                conn.Close();
                //----------------------------------------------------106
                conn.Open();
                query = "SELECT qty FROM Starting WHERE ID=106";
                cmd.Connection = conn;
                cmd.CommandText = query;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    p106 = (dr["qty"].ToString());
                }
                conn.Close();

            }
            catch (Exception ex)
            {
                //MessageBox.Show("Sum to  " + ex);
                conn.Close();

            }
        }

        //----------------------------------sum of lanzones wine
        public void SumOfLanzonesWine()
        {
            try
            {
                conn.Open();
                query = "SELECT SUM(Lanzones_Wine) FROM tblTransaction";
                cmd.Connection = conn;
                cmd.CommandText = query;
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    soldLanzonesW = Convert.ToInt32(dr[0]);
                }
                conn.Close();

            }
            catch (Exception ex)
            {
                //MessageBox.Show("Sum to  " + ex);
                conn.Close();

            }
        }

        //----------------------------------sum of banana wine
        public void SumOfBananaWine()
        {
            try
            {
                conn.Open();
                query = "SELECT SUM(Banana_Wine) FROM tblTransaction";
                cmd.Connection = conn;
                cmd.CommandText = query;
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    soldBananaW = Convert.ToInt32(dr[0]);
                }
                conn.Close();

            }
            catch (Exception ex)
            {
                //MessageBox.Show("Sum to  " + ex);
                conn.Close();

            }
        }

        //----------------------------------sum of rice wine
        public void SumOfRiceWine()
        {
            try
            {
                conn.Open();
                query = "SELECT SUM(Rice_Wine) FROM tblTransaction";
                cmd.Connection = conn;
                cmd.CommandText = query;
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    soldRiceW = Convert.ToInt32(dr[0]);
                }
                conn.Close();

            }
            catch (Exception ex)
            {
                //MessageBox.Show("Sum to  " + ex);
                conn.Close();

            }
        }

        //----------------------------------sum of rc lanzones frappe
        public void SumOfLanzonesFrappe()
        {
            try
            {
                conn.Open();
                query = "SELECT SUM(RC_Lanzones_Frappe) FROM tblTransaction";
                cmd.Connection = conn;
                cmd.CommandText = query;
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    soldLanzonesC = Convert.ToInt32(dr[0]);
                }
                conn.Close();

            }
            catch (Exception ex)
            {
                //MessageBox.Show("Sum to  " + ex);
                conn.Close();

            }
        }

        //----------------------------------sum of rice coffee
        public void SumOfRiceCoffeeHot()
        {
            try
            {
                conn.Open();
                query = "SELECT SUM([Rice_Coffee(Hot)]) FROM tblTransaction";
                cmd.Connection = conn;
                cmd.CommandText = query;
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    soldRiceCH = Convert.ToInt32(dr[0]);
                }
                conn.Close();

            }
            catch (Exception ex)
            {
                //MessageBox.Show("Sum to  " + ex);
                conn.Close();

            }
        }

        //----------------------------------sum of rice coffee iced
        public void SumOfRiceCoffeeIced()
        {
            try
            {
                conn.Open();
                query = "SELECT SUM([Rice_Coffee(Iced)]) FROM tblTransaction";
                cmd.Connection = conn;
                cmd.CommandText = query;
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    soldRiceCI = Convert.ToInt32(dr[0]);
                }
                conn.Close();

            }
            catch (Exception ex)
            {
                //MessageBox.Show("Sum to  " + ex);
                conn.Close();

            }
        }

        //----------------------------------sum of rice coffee
        public void SumOfBananaFrizz()
        {
            try
            {
                conn.Open();
                query = "SELECT SUM(Banana_Frizz) FROM tblTransaction";
                cmd.Connection = conn;
                cmd.CommandText = query;
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    soldBananaC = Convert.ToInt32(dr[0]);
                }
                conn.Close();

            }
            catch (Exception ex)
            {
                //MessageBox.Show("Sum to  " + ex);
                conn.Close();

            }
        }

        private void Summary_Form_Load(object sender, EventArgs e)
        {
            conn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\PZ\Stocks_BD.mdf;Integrated Security=True;Connect Timeout=30";
            ReadStartingStocks();
            ReadRemainingS();

            SumOfLanzonesWine();
            SumOfLanzonesFrappe();
            SumOfBananaWine();
            SumOfBananaFrizz();
            SumOfRiceCoffeeHot();
            SumOfRiceCoffeeIced();
            SumOfRiceWine();


            // calculation

            sumLanzonesW = soldLanzonesW * 305;
            sumBananaW = soldBananaW * 163;
            sumRiceW = soldRiceW * 177;
            sumLanzonesC = soldLanzonesC * 71;
            sumRiceCH = soldRiceCH * 21;
            sumRiceCI = soldRiceCI * 31;
            sumBananaC = soldBananaC * 76;
            total = sumLanzonesW + sumBananaW + sumRiceW + sumLanzonesC + sumRiceCH + sumRiceCI + sumBananaC;

            //displaying beginning stocks
            listBox1.Items.Add("Beginning Stocks:");
            listBox1.Items.Add("Lanzones Wine: " + p100);
            listBox1.Items.Add("Banana Wine: " + p101);
            listBox1.Items.Add("Rice Wine: " + p102);
            listBox1.Items.Add("RC Lanzones Frappe: " + p103);
            listBox1.Items.Add("Rice Coffee(Hot): " + p104);
            listBox1.Items.Add("Rice Coffee(Iced): " + p105);
            listBox1.Items.Add("Banana Frizz: " + p106);
            listBox1.Items.Add("");

            //displaying sold products
            listBox1.Items.Add("Sold Products:");
            listBox1.Items.Add("Lanzones Wine: " + soldLanzonesW +" = " + "Php " + sumLanzonesW);
            listBox1.Items.Add("Banana Wine: " + soldBananaW + " = " + "Php " + sumBananaW);
            listBox1.Items.Add("Rice Wine: " + soldRiceW + " = " + "Php " + sumRiceW);
            listBox1.Items.Add("RC Lanzones Frappe: " + soldLanzonesC + " = " + "Php " + sumLanzonesC);
            listBox1.Items.Add("Rice Coffee(Hot): " + soldRiceCH + "Php " + " = " + sumRiceCH);
            listBox1.Items.Add("Rice Coffee(Iced): " + soldRiceCI + "Php " + " = " + sumRiceCI);
            listBox1.Items.Add("Banana Frizz: " + soldBananaC + "Php " + " = " + sumBananaC);
            listBox1.Items.Add("");

            //"""" ramianing stocks
            listBox1.Items.Add("Remaining Stocks:");
            listBox1.Items.Add("Lanzones Wine: " + r100);
            listBox1.Items.Add("Banana Wine: " + r101);
            listBox1.Items.Add("Rice Wine: " + r102);
            listBox1.Items.Add("RC Lanzones Frappe: " + r103);
            listBox1.Items.Add("Rice Coffee(Hot): " + r104);
            listBox1.Items.Add("Rice Coffee(Iced): " + r105);
            listBox1.Items.Add("Banana Frizz: " + r106);
            listBox1.Items.Add("----------------------------------------------");
            listBox1.Items.Add("Your Income: " + total);

        }

        
    }
}
