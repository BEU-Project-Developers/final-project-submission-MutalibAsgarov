using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace mutalibwinformapp
{
    public partial class formHome : Form
    {
        SqlConnection sqlBaglanti = new SqlConnection(@"Data Source=DESKTOP-4N4BE95\SQLEXPRESS;Initial Catalog=Finance;Integrated Security=True;Trust Server Certificate=True");


        public formHome()
        {
            InitializeComponent();
        }


        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void formHome_Load(object sender, EventArgs e)
        {

        }

        

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (int.TryParse(textBox1.Text, out int expence))
            {
                listBoxExpences.Items.Add(expence);
                textBox1.Clear();

                
                int totalExpenses = CalculateTotal(listBoxExpences);
                label3.Text = totalExpenses.ToString();

                
                UpdateBudget(-expence);
            }
            else
            {
                MessageBox.Show("Bu ədəd keçərli deyil", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                sqlBaglanti.Open();
                string sqlcumlesi = "INSERT INTO Finance VALUES(@Expences,NULL,@Budget)";
                SqlCommand komut = new SqlCommand(sqlcumlesi, sqlBaglanti);
                komut.Parameters.AddWithValue("@Expences", expence);
                komut.Parameters.AddWithValue("@Budget", label5.Text);
                komut.ExecuteNonQuery();

            }
            catch(Exception ex) 
            {
                MessageBox.Show("Databazada xəta baş verdi, yenidən yoxlayın " + ex.Message);

            }
            finally
            {
                if(sqlBaglanti != null) 
                sqlBaglanti.Close();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (int.TryParse(textBox2.Text, out int income))
            {
                listBoxIncomes.Items.Add(income);
                textBox2.Clear();

                
                int totalIncome = CalculateTotal(listBoxIncomes);
                label4.Text = totalIncome.ToString();

                
                UpdateBudget(income);
            }
            else
            {
                MessageBox.Show("Bu ədəd keçərli deyil", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                sqlBaglanti.Open();
                string sqlcumlesi = "INSERT INTO Finance VALUES(NULL,@Incomes,@Budget)";
                SqlCommand komut = new SqlCommand(sqlcumlesi, sqlBaglanti);
                komut.Parameters.AddWithValue("@Incomes", income);
                komut.Parameters.AddWithValue("@Budget", label5.Text);
                komut.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Databazada xəta baş verdi, yenidən yoxlayın " + ex.Message);

            }
            finally
            {
                if (sqlBaglanti != null)
                    sqlBaglanti.Close();
            }
        }

        
        private int CalculateTotal(ListBox listBox)
        {
            int total = 0;
            foreach (var item in listBox.Items)
            {
                if (int.TryParse(item.ToString(), out int number))
                {
                    total += number;
                }
            }
            return total;
        }

        private void UpdateBudget(int amount)
        {
            if (int.TryParse(label5.Text, out int currentBudget))
            {
                currentBudget += amount;
                label5.Text = currentBudget.ToString();
            }
            else
            {
                label5.Text = amount.ToString();
            }
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
    }
}
