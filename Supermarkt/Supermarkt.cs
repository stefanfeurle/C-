using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarkt
{
    public partial class Supermarkt : Form
    {
        Dictionary<String, int> purchasingList = new Dictionary<string, int>();

        public Supermarkt()
        {
            InitializeComponent();
            string[] myFileContent = System.IO.File.ReadAllLines("C:\\Users\\DCV\\stefan\\IdeaProjects\\CodingCampus\\6. C#\\MeineEinkaufsliste.txt");
            foreach (var myFileContentLine in myFileContent)
            {
                string[] splitValue = myFileContentLine.Split(';');
                var product = splitValue[0];
                int.TryParse(splitValue[1], out var number);
                purchasingList.Add(product, number);
            }
            updatePurchasingList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var product = tbProduct.Text;
            int.TryParse(tbNumber.Text, out var number);

            if (!string.IsNullOrEmpty(product) && number > 0) {
                if (purchasingList.ContainsKey(product))
                {
                    purchasingList[product] += number;                    
                }
                else
                {
                    purchasingList.Add(product, number);                    
                }
                updatePurchasingList();              
            }           
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var product = tbProduct.Text;
            int.TryParse(tbNumber.Text, out var number);

            if (!string.IsNullOrEmpty(product) && number > 0)
            {
                if (purchasingList.ContainsKey(product))
                {
                    purchasingList.TryGetValue(product, out var oldNumber);
                    number = oldNumber - number;
                    if (number > 0)
                    {
                        purchasingList[product] = number;
                    } else
                    {
                        purchasingList.Remove(product);
                    }
                    updatePurchasingList();
                }
            }
        }

        private void updatePurchasingList()
        {
            //var listOfStrings = purchasingList.Select(x => new {display = x.Key + " (" + x.Value + ")" });
            List<string> listOfStrings = new List<string>();
            foreach (var item in purchasingList)
            {
                listOfStrings.Add( $"{item.Key} ({item.Value})");
            }          
            lbPurchasingList.DataSource = listOfStrings.ToList();
            tbNumber.Text = null;
            tbProduct.Text = null;
        }

        private void btnExportCSV_Click(object sender, EventArgs e)
        {
            List<string> addFile = new List<string>();
            foreach (var item in purchasingList)
            {
                addFile.Add($"{item.Key};{item.Value}");
            }
            System.IO.File.WriteAllLines("C:\\Users\\DCV\\stefan\\IdeaProjects\\CodingCampus\\6. C#\\MeineEinkaufsliste.txt", addFile);
        }
    }
}
