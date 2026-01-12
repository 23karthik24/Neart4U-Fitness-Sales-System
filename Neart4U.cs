using System;
using System.Windows.Forms;

namespace Assinment_3
{
    public partial class Neart4U : Form
    {
        const string EQUIPMENTNAME_1 = "Elliptical",
             EQUIPMENTNAME_2 = "Threadmill",
             EQUIPMENTNAME_3 = "Exercise Bike",
             EQUIPMENTNAME_4 = "Rowing Machine",
             EQUIPMENTNAME_5 = "Stair Climber";

        //Declaration of their costs
        const decimal COST_1 = 1199m,
                      COST_2 = 899m,
                      COST_3 = 499m,
                      COST_4 = 699m,
                      COST_5 = 799m;

        //Declaring different Brands
        const string BRAND_1 = "Own Brand",
                     BRAND_2 = "Techno Gym",
                     BRAND_3 = "Proform",
                     BRAND_4 = "Nordic Track",
                     BRAND_5 = "Peloton";

        //Declaring the brand discounts
        const decimal BRAND1_DISC = -0.20m,
                      BRAND2_DISC = -0.10m,
                      BRAND3_DISC = 0.00m,
                      BRAND4_DISC = 0.15m,
                      BRAND5_DISC = 0.25m;

        //Declaring the warranty years
        const string FIRSTYEAR = "1 Year",
                     SECONDYEAR = "3 Year",
                     THIRDYEAR = "5 Year";

        //Declaring percentage
        const decimal PERCENT_1 = 0.15m,
                      PERCENT_2 = 0.25m,
                      PERCENT_3 = 0.30m;

        //global variables
        string EquipName = "";
        string Equipbrand = "";
        decimal EquipCost;
        decimal BrandCost;
        int Quantity;
        string WarrantyYear = "";
        decimal Percent;
        decimal Subcost;
        decimal WarrantyPrice;
        decimal TotalCost;
        decimal INSTALLATION = 99m;
        decimal DELIVERY = 149m;
        decimal OverallPrice;
        bool DiscountApplied;
        const decimal DISCOUNTVAL = 0.075m;
        decimal DiscountPrice;
        int TotalOrders = 0;
        int DiscountedOrders = 0;
        decimal TotalDiscountGiven = 0;
        decimal TotalCharges = 0;

        public Neart4U()
        {
            InitializeComponent();
        }

        private void Clearbutton_Click(object sender, EventArgs e)
        {
            Oneyearwarranty.Checked = false;
            twoyearwarranty.Checked = false;
            threeyearwarranty.Checked = false;
            Installation.Checked = false;
            Outputlabel.Visible = true;
            Searchbutton.Enabled = false;
            Equipmentlistbox.ClearSelected();
            Brandlistbox.ClearSelected();
            Clearbutton.Focus();
            Quantitytextbox.Text = "";
            Outputlabel.Text = "";
        }

        private void Exitbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void quotebutton_Click(object sender, EventArgs e)
        {
            Searchbutton.Enabled = false;
            int Equipment_Name = 0, Brand_Name = 0;

            if ((Equipmentlistbox.SelectedIndex != -1))
            {
                if ((Brandlistbox.SelectedIndex != -1))
                {
                    Equipment_Name = Equipmentlistbox.SelectedIndex;
                    Brand_Name = Brandlistbox.SelectedIndex;
                    switch (Equipment_Name)
                    {
                        case 0:
                            EquipName = EQUIPMENTNAME_1;
                            EquipCost = COST_1;
                            break;
                        case 1:
                            EquipName = EQUIPMENTNAME_2;
                            EquipCost = COST_2;
                            break;
                        case 2:
                            EquipName = EQUIPMENTNAME_3;
                            EquipCost = COST_3;
                            break;
                        case 3:
                            EquipName = EQUIPMENTNAME_4;
                            EquipCost = COST_4;
                            break;
                        case 4:
                            EquipName = EQUIPMENTNAME_5;
                            EquipCost = COST_5;
                            break;
                    }
                    switch (Brand_Name)
                    {
                        case 0:
                            Equipbrand = BRAND_1;
                            BrandCost = BRAND1_DISC;
                            break;
                        case 1:
                            Equipbrand = BRAND_2;
                            BrandCost = BRAND2_DISC;
                            break;
                        case 2:
                            Equipbrand = BRAND_3;
                            BrandCost = BRAND3_DISC;
                            break;
                        case 3:
                            Equipbrand = BRAND_4;
                            BrandCost = BRAND4_DISC;
                            break;
                        case 4:
                            Equipbrand = BRAND_5;
                            BrandCost = BRAND5_DISC;
                            break;
                    }
                    if (int.TryParse((Quantitytextbox.Text), out Quantity) && Quantity > 0)
                    {
                        if (Oneyearwarranty.Checked)
                        {
                            WarrantyYear = FIRSTYEAR;
                            Percent = PERCENT_1;
                        }
                        else if (twoyearwarranty.Checked)
                        {
                            WarrantyYear = SECONDYEAR;
                            Percent = PERCENT_2;
                        }
                        else if (threeyearwarranty.Checked)
                        {
                            WarrantyYear = THIRDYEAR;
                            Percent = PERCENT_3;
                        }

                        //CALCULATION
                        if (BrandCost < 0)
                        {
                            // Negative discount means price INCREASE (like +20%)
                            Subcost = (EquipCost + (EquipCost * Math.Abs(BrandCost))) * Quantity;
                        }
                        else
                        {
                            // Positive discount means price DECREASE (like -15%)
                            Subcost = (EquipCost - (EquipCost * BrandCost)) * Quantity;
                        }

                        WarrantyPrice = Subcost * Percent;
                        TotalCost = Subcost + WarrantyPrice;
                        bool InstallCost = Installation.Checked;
                        if (!InstallCost)
                        {
                            INSTALLATION = 99;
                        }
                        else
                        {
                            INSTALLATION = 0;
                        }
                        OverallPrice = TotalCost + INSTALLATION + DELIVERY;

                        DiscountApplied = (Quantity >= 4) && (SECONDYEAR == "3 Year" || THIRDYEAR == "5 Year");
                        if (DiscountApplied)
                        {
                            DiscountPrice = Subcost * 0.075m;
                            TotalCost = (Subcost - DiscountPrice) + INSTALLATION + DELIVERY;
                        }
                        else
                        {
                            DiscountPrice = 0;
                            TotalCost = Subcost + INSTALLATION + DELIVERY;
                        }

                        // Displaying the values to the User
                        Outputlabel.Text = $"\n Quote value\n" +
                        $"        Brand: {Equipbrand}\n" +
                        $"        Equipment Quantity: {Quantity}\n" +
                        $"        Equipment Cost: {EquipCost:C2}\n" +
                        $"        Total Equipment Cost   : {Subcost:C}\n" +
                        $"        Expedited Installation(If applied): {INSTALLATION:C2}\n" +
                        $"        Delivery: {DELIVERY:C2}\n" +
                        $"        Service Warranty Cost: {WarrantyPrice:C2}\n" +
                        $"        Discount Price:{DiscountPrice:C2}\n" +
                        $"        ================\n" +
                        $"        Total Cost:{TotalCost:C2}\n";

                        Orderbutton.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Please enter a number that is greater than 0.",
                            "Invalid Quantity", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show(" select  Brand", "Brand Name to be selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show(" select  Equipment", "Equipment Name to be selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Searchbutton_Click(object sender, EventArgs e)
        {
            SearchForm searchForm = new SearchForm();
            searchForm.ShowDialog();
        }

        private void Orderbutton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Outputlabel.Text))
            {
                MessageBox.Show("Please generate a quote before placing an order.",
                              "Quote Required",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // confirmation
            DialogResult confirm = MessageBox.Show($"Proceed with {EquipName} order for {TotalCost:C2}?",
                                                "Confirm Order",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                ClientDetailsForm clientForm = new ClientDetailsForm();
                clientForm.TotalCost = TotalCost;
                clientForm.EquipmentName = EquipName;
                clientForm.EquipmentBrand = Equipbrand;
                clientForm.Quantity = Quantity;
                clientForm.ShowDialog();
                CompleteOrder();
            }
        }

        private void CompleteOrder()
        {
            TotalOrders++;
            if (DiscountPrice > 0)
            {
                DiscountedOrders++;
                TotalDiscountGiven += DiscountPrice;
            }
            TotalCharges += TotalCost;

            Searchbutton.Enabled = true;
            Equipmentlistbox.ClearSelected();
            Brandlistbox.ClearSelected();
            Quantitytextbox.Clear();
            Oneyearwarranty.Checked = false;
            twoyearwarranty.Checked = false;
            threeyearwarranty.Checked = false;
            Installation.Checked = false;
            Outputlabel.Text = "";
        }
    }
}