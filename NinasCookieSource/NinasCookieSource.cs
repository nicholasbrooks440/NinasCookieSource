using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NinasCookieSource
{
    public partial class NinasCookieSource : Form
    {
        private double cookiePrice;
        private double quantity;
        private double totalPrice;
        
        public NinasCookieSource()
        {
            InitializeComponent();
          
            //set to true
            chocChipRadioBtn.Checked = true;
            oneDozRadioBtn.Checked = true;
            ttlPriceLabel.Text = "Total price is: " + 8.99; //default selection price = 8.99
            
            //Set min Date to 3 days ahead and max date 10 days from now
            cookieDateTimePicker.MinDate = DateTime.Now.AddDays(3);
            cookieDateTimePicker.MaxDate = DateTime.Now.AddDays(10);

            var qantityRadio = quantityGroupBox.Controls.OfType<RadioButton>()
                                      .FirstOrDefault(r => r.Checked);

        }

        public double CookiePrice
        {
            get { return cookiePrice; }
            set { cookiePrice = value; }
        }
        public double Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        /////////////////////
        private void cookieDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            //need to drop the seconds
            String userDate = cookieDateTimePicker.Value.ToString("MM/dd/yyyy");

            cookieDelvDate.Text = "Cookies will be delivered on : " + userDate;
        }

        //Cookie Radio buttons
        private void oatmealRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            const double OATMEAL_PRICE = 6.99;
            if (oatmealRadioBtn.Checked == true)
            {
                CookiePrice = OATMEAL_PRICE;
            }
            totalPrice = CookiePrice * Quantity;
            ttlPriceLabel.Text = "Total price is: " + totalPrice.ToString("C");          
        }

        private void vanWafRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            const double VANWAF_PRICE = 6.49;
            if (vanWafRadioBtn.Checked == true)
            {
                CookiePrice = VANWAF_PRICE;   
            }
            totalPrice = CookiePrice * Quantity;
            ttlPriceLabel.Text = "Total price is: " + totalPrice.ToString("C");       
        }

        private void chocChipRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            const double CHOCCHIP_PRICE = 8.99;
            if (chocChipRadioBtn.Checked == true)
            {
                CookiePrice = CHOCCHIP_PRICE;                
            }
            totalPrice = CookiePrice * Quantity;
            ttlPriceLabel.Text = "Total price is: " + totalPrice.ToString("C");       
        }
        /// QTY Radio Buttons
      
        private void halfDozRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            const double HALF_DOZ = .5;
            if (halfDozRadioBtn.Checked == true)
            {
                Quantity = HALF_DOZ;
                totalPrice = CookiePrice * Quantity;
                ttlPriceLabel.Text = "Total price is: " + totalPrice.ToString("C");        
            }
        }

        private void oneDozRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            const double ONE_DOZ = 1;
            if (oneDozRadioBtn.Checked == true)
            {
                Quantity = ONE_DOZ;
                totalPrice = CookiePrice * Quantity;
                ttlPriceLabel.Text = "Total price is: " + totalPrice.ToString("C"); 
            }
        }

        private void twoDozRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            const double TWO_DOZ = 2;
            if (twoDozRadioBtn.Checked == true)
            {
                Quantity = TWO_DOZ;
                totalPrice = CookiePrice * Quantity;
                ttlPriceLabel.Text = "Total price is: " + totalPrice.ToString("C"); 
            }
        }

        private void threeDozRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            const double THREE_DOZ = 3;
            if (threeDozRadioBtn.Checked == true)
            {
                Quantity = THREE_DOZ;
                totalPrice = CookiePrice * Quantity;
                ttlPriceLabel.Text = "Total price is: " + totalPrice.ToString("C");    
            }
        }

    }
}
