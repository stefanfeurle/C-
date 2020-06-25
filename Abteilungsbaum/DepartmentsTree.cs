using AbteilungsbaumData;
using AbteilungsbaumLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abteilungsbaum
{
    public partial class DepartmentsTree : Form
    {
        DepartmentController controller = new DepartmentController();

        public DepartmentsTree()
        {
            InitializeComponent();
            PrintDepartments();
        }

        private void PrintDepartments()
        {
            var list = controller.getDepartments();
            treeViewDepartment.Nodes.Clear();            
            foreach (var item in list)
            {
                if(item.Parent_Id == null)
                {
                    var node = treeViewDepartment.Nodes.Add(item.Name);
                    var parentId = item.Id;
                    printSubdepartments(list, node, parentId);
                }
            }
        }

        private void printSubdepartments(List<Department> list, TreeNode node, int parentId)
        {
            foreach (var item in list)
            {
                if (parentId == item.Parent_Id)
                {
                    var subnode = node.Nodes.Add(item.Name);
                    var subId = item.Id;
                    printSubdepartments(list, subnode, subId);
                }
            }
        }

        private void btnAddDepartment_Click(object sender, EventArgs e)
        {
            string output = controller.addDepartment(tbDepartment.Text, tbParentDepartment.Text);
            MessageBox.Show(output);
            tbDepartment.Text = null;
            tbParentDepartment.Text = null;
            PrintDepartments();
            var message = "Möchten sie wirklich löschen?";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;            
            DialogResult dialogResult = MessageBox.Show(message,"Marc", buttons);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show("Marc");
            }
            else
            {
                MessageBox.Show("Stefan");
            }
            var myDate = DateTime.Parse
            ("2020-06-16");
            myDate.AddYears(1);
            // 2020 
            MessageBox.Show(Convert.ToString(myDate.Year));
            myDate = myDate.AddYears(1);
            //2021
            MessageBox.Show(Convert.ToString(myDate.Year));     

        }
    }
}
