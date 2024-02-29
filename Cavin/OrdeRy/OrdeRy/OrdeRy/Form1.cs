using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace OrdeRy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cb1.Focus();
            //cb2.Focus();
        }
        //initialize all classes
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        SqlDataReader dr;

        //variables for sql
        string query;
        int result;
        //int userid;

        //int toUpdate100, toUpdate101, toUpdate102, toUpdate103, toUpdate104, toUpdate105;
        int toUpdate, toReduce1, toReduce2, toReduce3, toReduce4, toReduce5, toReduce6, toReduce7;


        //int toReduce100, toReduce101, toReduce102, toReduce103, toReduce104, toReduce105;

        //variables-----------------------------------------------------------------------------------------------

        int Product1, Product2, Product3, Product4, Product5, Product6, Product7; //

        //Load Inventory method----------------------------------------------------------------------------------
        public void Load_Inventory() {
            try
            {
                //variables for sql
                string query;
                query = "SELECT * FROM tblProducts";//string para kausapin si SQL.
                cmd = new SqlCommand();//tagahawak ng command
                cmd.Connection = conn;//connection ng command kung saan execute ang query
                cmd.CommandText = query;//gagawin sa SQL
                da = new SqlDataAdapter();//hahawak ng muna ng data
                da.SelectCommand = cmd;//gagawin ang command para mapunta sa adapter ang data
                dt = new DataTable();//maghahawak ng data
                da.Fill(dt);//ilalagay ang laman ng data adapter sa data table
                dataGW_Invertory.DataSource = dt;//ilalagay ang laman ng data table sa GridView
            }
            catch (Exception ex)
            {
                MessageBox.Show("Form1"+ex.Message);
            }
            finally
            {
                da.Dispose();
            }
        }
        // to load the void table----------------------------------------
        public void Load_Voids() {
            try
            {
                query = "SELECT * FROM VoidTransac";
                cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = query;
                da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);
                GW_Voids.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                da.Dispose();

            }
        }

        //To load transaction table------------------------------------------------------------------------
        public void Load_Transaction() {
            try
            {
                query = "SELECT * FROM tblTransaction";
                cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = query;
                da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);
                dataGW.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                da.Dispose();

            }
        }

        //W-----------------------------------------this will record the transaction----------------------------------------------
        public void Insert_Transac() {
           
                try
                {
                    conn.Open();
                    query = "INSERT INTO tblTransaction VALUES('" + Product1 + "','" + Product2 + "','" + Product3 + "','" + Product4 + "','" + Product5 + "','" + Product6 + "','" + Product7 + "')";
                    cmd.Connection = conn;
                    cmd.CommandText = query;
                    result = cmd.ExecuteNonQuery();

                    conn.Close();
                    Load_Transaction();
                }
                catch (Exception ex)//catch exeption
                {
                    MessageBox.Show(ex.Message);
                }
            
        }

        //-------------------------------Update productId=100-------------------------------------------------------------------

        public void Update_100()
        {
            string ID100string;
            try
            {
                conn.Open();
                query = "SELECT ProductQuantity FROM tblProducts WHERE ProductId=100";
                cmd.Connection = conn;
                cmd.CommandText = query;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    ID100string = (dr["ProductQuantity"].ToString());
                    toReduce1 = int.Parse(ID100string);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (Product1 > toReduce1)
            {
                //MessageBox.Show("Out of stock");
            }
            else
            {
                try
                {
                    toUpdate = toReduce1 - int.Parse(txtbQty.Text);
                    conn.Open();

                    string queryUpdate = "UPDATE tblProducts SET ProductQuantity=" + toUpdate + "WHERE ProductId=100";
                    //string queryUpdate = "UPDATE tblProducts SET ProductQuantity=30 WHERE ProductId=100";

                    cmd.Connection = conn;
                    cmd.CommandText = queryUpdate;
                    result = cmd.ExecuteNonQuery();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }
        //--------------------update 101-------------------------------------------------------------
        public void Update_101()
        {
            string ID101string;
            try
            {
                conn.Open();
                query = "SELECT ProductQuantity FROM tblProducts WHERE ProductId=101";
                cmd.Connection = conn;
                cmd.CommandText = query;
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    ID101string = (dr["ProductQuantity"].ToString());
                    toReduce2 = int.Parse(ID101string);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //////
            if (Product2 > toReduce2)
            {
                //MessageBox.Show("Out of stock");
            }
            else
            {
                try
                {
                    //Insert_Transac();
                    toUpdate = toReduce2 - int.Parse(txtbQtyP2.Text);
                    conn.Open();

                    string queryUpdate = "UPDATE tblProducts SET ProductQuantity=" + toUpdate + "WHERE ProductId=101";
                    //string queryUpdate = "UPDATE tblProducts SET ProductQuantity=30 WHERE ProductId=100";

                    cmd.Connection = conn;
                    cmd.CommandText = queryUpdate;
                    result = cmd.ExecuteNonQuery();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }
        //--------------------update 102-------------------------------------------------------------
        public void Update_102()
        {
            string ID102string;
            try
            {
                conn.Open();
                query = "SELECT ProductQuantity FROM tblProducts WHERE ProductId=102";
                cmd.Connection = conn;
                cmd.CommandText = query;
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    ID102string = (dr["ProductQuantity"].ToString());
                    toReduce3 = int.Parse(ID102string);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (Product3 > toReduce3)
            {
                //MessageBox.Show("Out of stock");
            }
            else
            {
                try
                {
                    //Insert_Transac();
                    toUpdate = toReduce3 - int.Parse(txtbQtyP3.Text);
                    conn.Open();

                    string queryUpdate = "UPDATE tblProducts SET ProductQuantity=" + toUpdate + "WHERE ProductId=102";
                    //string queryUpdate = "UPDATE tblProducts SET ProductQuantity=30 WHERE ProductId=100";

                    cmd.Connection = conn;
                    cmd.CommandText = queryUpdate;
                    result = cmd.ExecuteNonQuery();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }
        //--------------------update 103-------------------------------------------------------------
        public void Update_103()
        {
            string ID103string;
            try
            {
                conn.Open();
                query = "SELECT ProductQuantity FROM tblProducts WHERE ProductId=103";
                cmd.Connection = conn;
                cmd.CommandText = query;
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    ID103string = (dr["ProductQuantity"].ToString());
                    toReduce4 = int.Parse(ID103string);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if ( Product4 > toReduce4)
            {
                //MessageBox.Show("Out of stock");
            }
            else
            {
                try
                {
                    //Insert_Transac();
                    toUpdate = toReduce4 - int.Parse(txtbQtyP4.Text);
                    conn.Open();

                    string queryUpdate = "UPDATE tblProducts SET ProductQuantity=" + toUpdate + "WHERE ProductId=103";
                    //string queryUpdate = "UPDATE tblProducts SET ProductQuantity=30 WHERE ProductId=100";

                    cmd.Connection = conn;
                    cmd.CommandText = queryUpdate;
                    result = cmd.ExecuteNonQuery();
                    conn.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }
        //--------------------update 104-------------------------------------------------------------
        public void Update_104()
        {
            string ID104string;
            try
            {
                conn.Open();
                query = "SELECT ProductQuantity FROM tblProducts WHERE ProductId=104";
                cmd.Connection = conn;
                cmd.CommandText = query;
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    ID104string = (dr["ProductQuantity"].ToString());
                    toReduce5 = int.Parse(ID104string);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (Product5 > toReduce5)
            {
                //MessageBox.Show("Out of stock");
            }
            else
            {
                try
                {
                    //Insert_Transac();
                    toUpdate = toReduce5 - int.Parse(txtbQtyP5.Text);
                    conn.Open();

                    string queryUpdate = "UPDATE tblProducts SET ProductQuantity=" + toUpdate + "WHERE ProductId=104";
                    //string queryUpdate = "UPDATE tblProducts SET ProductQuantity=30 WHERE ProductId=100";

                    cmd.Connection = conn;
                    cmd.CommandText = queryUpdate;
                    result = cmd.ExecuteNonQuery();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }
        //--------------------update 105-------------------------------------------------------------
        public void Update_105()
        {
            string ID105string;
            try
            {
                conn.Open();
                query = "SELECT ProductQuantity FROM tblProducts WHERE ProductId=105";
                cmd.Connection = conn;
                cmd.CommandText = query;
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    ID105string = (dr["ProductQuantity"].ToString());
                    toReduce6 = int.Parse(ID105string);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (Product6 > toReduce6)
            {
                //MessageBox.Show("Out of stock");
            }
            else
            {
                try
                {
                    toUpdate = toReduce6 - int.Parse(txtbQtyP5Iced.Text);
                    conn.Open();

                    string queryUpdate = "UPDATE tblProducts SET ProductQuantity=" + toUpdate + "WHERE ProductId=105";
                    //string queryUpdate = "UPDATE tblProducts SET ProductQuantity=30 WHERE ProductId=100";

                    cmd.Connection = conn;
                    cmd.CommandText = queryUpdate;
                    result = cmd.ExecuteNonQuery();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }
        //--------------------update 106-------------------------------------------------------------
        public void Update_106()
        {
            string ID106string;
            try
            {
                conn.Open();
                query = "SELECT ProductQuantity FROM tblProducts WHERE ProductId=106";
                cmd.Connection = conn;
                cmd.CommandText = query;
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    ID106string = (dr["ProductQuantity"].ToString());
                    toReduce7 = int.Parse(ID106string);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (Product7 > toReduce7)
            {
                //MessageBox.Show("Out of stock");
            }
            else
            {
                try
                {
                    toUpdate = toReduce7 - int.Parse(txtbQtyP6.Text);
                    conn.Open();

                    string queryUpdate = "UPDATE tblProducts SET ProductQuantity=" + toUpdate + "WHERE ProductId=106";
                    //string queryUpdate = "UPDATE tblProducts SET ProductQuantity=30 WHERE ProductId=100";

                    cmd.Connection = conn;
                    cmd.CommandText = queryUpdate;
                    result = cmd.ExecuteNonQuery();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        

        public void ToDisable() {
            Update_100();
            if (toReduce1 == 0)
            {
                cb1.Enabled = false;
            }
            else {
                cb1.Enabled = true;
            }
            //////101
            Update_101();
            if (toReduce2 == 0)
            {
                cb2.Enabled = false;
            }
            else
            {
                cb2.Enabled = true;
            }
            /////////102
            Update_102();
            if (toReduce3 == 0)
            {
                cb3.Enabled = false;
            }
            else
            {
                cb3.Enabled = true;
            }
            /////////103
            Update_103();
            if (toReduce4 == 0)
            {
                cb4.Enabled = false;
            }
            else
            {
                cb4.Enabled = true;
            }
            //////////////104
            Update_104();
            if (toReduce5 == 0)
            {
                cb5.Enabled = false;
            }
            else
            {
                cb5.Enabled = true;
            }

            /////////////////105
            Update_105();
            if (toReduce6 == 0)
            {
                cb5Iced.Enabled = false;
            }
            else
            {
                cb5Iced.Enabled = true;
            }

            /////////////////106
            Update_106();
            if (toReduce7 == 0)
            {
                cb6.Enabled = false;
            }
            else
            {
                cb6.Enabled = true;
            }

            //
            txtbQty.Enabled = false;
            txtbQtyP2.Enabled = false;
            txtbQtyP3.Enabled = false;
            txtbQtyP4.Enabled = false;
            txtbQtyP5.Enabled = false;
            txtbQtyP5Iced.Enabled = false;
            txtbQtyP6.Enabled = false;
        }

        

        //-----------------------------------------------------------------------------------------------------



        //for opening update form
        private void btnOpenForm_Click(object sender, EventArgs e)
        {
            Update_Stocks_Form usf = new Update_Stocks_Form();
            usf.Show();
        }

        //to void transaction-----------------------------------------------------------------------------------------------
        private void toVoid_Click(object sender, EventArgs e)
        {
            try {
                conn.Open();
                query = "INSERT INTO VoidTransac SELECT * FROM tblTransaction WHERE TransactionID=" + idToVoid.Text;
                cmd.Connection = conn;
                cmd.CommandText = query;
                dr = cmd.ExecuteReader();
                conn.Close();
            }
            catch (Exception ex){ MessageBox.Show("Void error: "+ ex);
                conn.Close();

            }

            try
            {
                conn.Open();
                query = "DELETE FROM tblTransaction WHERE TransactionID=" + idToVoid.Text;
                cmd.Connection = conn;
                cmd.CommandText = query;
                dr = cmd.ExecuteReader();
                conn.Close();
            }
            catch (Exception ex) { MessageBox.Show("Void error Del: " + ex); }

            //load/refresh
            Load_Transaction();
            Load_Voids();
        }
        //cb check 
        public void toCheck1()
        {
            if (cb1.Checked == false) { cb1.Checked = true; }
            else { cb1.Checked = false; }
        }

        public void toCheck2() {
            if (cb2.Checked == false) { cb2.Checked = true; }
            else { cb2.Checked = false; }
        }

        public void toCheck3() {
            if (cb3.Checked == false) { cb3.Checked = true; }
            else { cb3.Checked = false; }
        }

        public void toCheck4() {
            if (cb4.Checked == false) { cb4.Checked = true; }
            else { cb4.Checked = false; }
        }

        public void toCheck5() {
            if (cb5.Checked == false) { cb5.Checked = true; }
            else { cb5.Checked = false; }
        }

        public void toCheck6() {
            if (cb5Iced.Checked == false) { cb5Iced.Checked = true; }
            else { cb5Iced.Checked = false; }
        }

        public void toCheck7() {
            if (cb6.Checked == false) { cb6.Checked = true; }
            else { cb6.Checked = false; }
        }


        //shortcut keys-===========-=-==================----------------==============-----------=
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.D1:
                    if (cb1.Enabled == false)
                    {
                        //dot nothing
                    }else
                    {
                        toCheck1();
                    }
                    break;
                case Keys.D2:
                    if (cb2.Enabled == false)
                    {
                        //dot nothing
                    }
                    else
                    {
                        toCheck2();
                    }
                    break;
                case Keys.D3:
                    if (cb3.Enabled == false)
                    {
                        //dot nothing
                    }
                    else
                    {
                        toCheck3();
                    }
                    break;
                case Keys.D4:
                    if (cb4.Enabled == false)
                    {
                        //dot nothing
                    }
                    else
                    {
                        toCheck4();
                    }
                    break;
                case Keys.D5:
                    if (cb5.Enabled == false)
                    {
                        //dot nothing
                    }
                    else
                    {
                        toCheck5();
                    }
                    break;
                case Keys.D6:
                    if (cb5Iced.Enabled == false)
                    {
                        //dot nothing
                    }
                    else
                    {
                        toCheck6();
                    }
                    break;
                case Keys.D7:
                    if (cb6.Enabled == false)
                    {
                        //dot nothing
                    }
                    else
                    {
                        toCheck7();
                    }
                    break;
                case Keys.Enter:
                    btnPrcs6_Click_1(sender, e);
                    break;
                case Keys.F5:
                    btnRefresh_Click(sender, e);
                    break;
                case Keys.U:
                    btnOpenForm_Click(sender, e);
                    break;
                case Keys.S:
                    button2_Click(sender, e);
                    break;
                case Keys.Back:
                    toVoid_Click(sender, e);
                    break;
            }
        }

        private void cbRef_Click(object sender, EventArgs e)
        {
            cb1.Checked = false;
            cb2.Checked = false;
            cb3.Checked = false;
            cb4.Checked = false;
            cb5.Checked = false;
            cb5Iced.Checked = false;
            cb6.Checked = false;
        }


        //private void cb1_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.D1) { toCheck1(); }
        //}

        //.p///////////////////////////////////////////////////////////////////................////////////////////////////////////////////////////
        private void dataGW_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try {
                int index = e.RowIndex;// get the Row Index
                DataGridViewRow slctdRow = dataGW.Rows[index];
                idToVoid.Text = slctdRow.Cells[0].Value.ToString();
            }
            catch (Exception ex) {MessageBox.Show(ex.ToString()); }
        }
        //--------------------------------key down--------------------///////////////////////////////////////////////////////////////////

        //to open login form
        //private void logIn_Click(object sender, EventArgs e)
        //{
        //    LogIn_Form login = new LogIn_Form();
        //    login.Show();
        //}

        //to open the summary form
        private void button2_Click(object sender, EventArgs e)
        {
            Summary_Form summ = new Summary_Form();
            summ.Show();
        }

        private void cb1_CheckedChanged(object sender, EventArgs e)
        {
            if (cb1.Checked == true) {
                txtbQty.Text = "1";
                txtbQty.Enabled = true; }
            else { txtbQty.Text = "0";
                txtbQty.Enabled = false;
            }

        }

        private void cb2_CheckedChanged(object sender, EventArgs e)
        {
            if (cb2.Checked == true) {
                txtbQtyP2.Text = "1";
                txtbQtyP2.Enabled = true;
            }
            else { txtbQtyP2.Text = "0";
                txtbQtyP2.Enabled = false;
            }
        }

        private void cb3_CheckedChanged(object sender, EventArgs e)
        {
            if (cb3.Checked == true) {
                txtbQtyP3.Text = "1";
                txtbQtyP3.Enabled = true;
            }
            else { txtbQtyP3.Text = "0";
                txtbQtyP3.Enabled = false;
            }
        }

        private void cb4_CheckedChanged(object sender, EventArgs e)
        {
            if (cb4.Checked == true) {
                txtbQtyP4.Text = "1";
                txtbQtyP4.Enabled = true;
            }
            else { txtbQtyP4.Text = "0";
                txtbQtyP4.Enabled = false;
            }
        }
        private void cb5Iced_CheckedChanged(object sender, EventArgs e)
        {
            if (cb5Iced.Checked == true) {
                txtbQtyP5Iced.Text = "1";
                txtbQtyP5Iced.Enabled = true;
            }
            else { txtbQtyP5Iced.Text = "0";
                txtbQtyP5Iced.Enabled = false;
            }
        }
        private void cb5_CheckedChanged(object sender, EventArgs e)
        {
            if (cb5.Checked == true) {
                txtbQtyP5.Text = "1";
                txtbQtyP5.Enabled = true;
            }
            else { txtbQtyP5.Text = "0";
                txtbQtyP5.Enabled = false;
            }
        }

        private void cb6_CheckedChanged(object sender, EventArgs e)
        {
            if (cb6.Checked == true) {
                txtbQtyP6.Text = "1";
                txtbQtyP6.Enabled = true;
            }
            else { txtbQtyP6.Text = "0";
                txtbQtyP6.Enabled = false;
            }
        }


        //-------------------------to sum up columns
        private void button1_Click(object sender, EventArgs e)
        {
            //SumOfLanzonesWine();
            //SumOfBananaWine();
            //SumOfRiceWine();
            //SumOfLanzonesFrappe();
            //SumOfRiceCoffee();
            //SumOfBananaFrizz();
        }

        //private void txtbQty_ValueChanged(object sender, EventArgs e) { }

        

        //Load inventory and transaction data table------------------------------------------------------------------------

        private void Form1_Load(object sender, EventArgs e)
        {
            conn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\PZ\Stocks_BD.mdf;Integrated Security=True;Connect Timeout=30";
            ToDisable();
            Load_Transaction();
            Load_Inventory();
            Load_Voids();
            this.KeyPreview = true;
            this.dataGW.CurrentCell.Selected = false;
            this.dataGW_Invertory.CurrentCell.Selected = false;
            this.GW_Voids.CurrentCell.Selected = false;
        }

        
        //pang record
        private void btnPrcs6_Click_1(object sender, EventArgs e)
        {
            // ask if input is right
            DialogResult dialogResult = MessageBox.Show("Are you sure?", "ADD", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Product1 = int.Parse(txtbQty.Text);
                Product2 = int.Parse(txtbQtyP2.Text);
                Product3 = int.Parse(txtbQtyP3.Text);
                Product4 = int.Parse(txtbQtyP4.Text);
                Product5 = int.Parse(txtbQtyP5.Text);
                Product6 = int.Parse(txtbQtyP5Iced.Text);
                Product7 = int.Parse(txtbQtyP6.Text);

                //to insert     
                if (cb1.Checked == true || cb2.Checked == true || cb3.Checked == true || cb4.Checked == true || cb5.Checked == true || cb5Iced.Checked == true || cb6.Checked == true)
                {
                    if (toReduce1 < Product1 || toReduce2 < Product2 || toReduce3 < Product3 || toReduce4 < Product4 || toReduce5 < Product5 || toReduce6 < Product6 || toReduce7 < Product7) {
                        MessageBox.Show("Error code 01");
                    }
                    else {
                        Update_100();
                        Update_101();
                        Update_102();
                        Update_103();
                        Update_104();
                        Update_105();
                        Update_106();
                        Insert_Transac();
                    }
                    
                }
                //uncheck chectbox
                cb1.Checked = false;
                cb2.Checked = false;
                cb3.Checked = false;
                cb4.Checked = false;
                cb5.Checked = false;
                cb5Iced.Checked = false;
                cb6.Checked = false;
                ToDisable();
                Load_Inventory();
            }
            else { }
        }

        //this will refresh/reload data
    private void btnRefresh_Click(object sender, EventArgs e)
        {
            ToDisable();
            Load_Inventory();
            Load_Transaction();
            Load_Voids();
            cb1.Checked = false;
            cb2.Checked = false;
            cb3.Checked = false;
            cb4.Checked = false;
            cb5.Checked = false;
            cb5Iced.Checked = false;
            cb6.Checked = false;
           
        }
    }
}

