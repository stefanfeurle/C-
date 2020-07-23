using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDoAppLogic;

namespace ToDoApp
{
    public partial class ToDoToDo : Form
    {
        ToDoController controller = new ToDoController();

        public ToDoToDo()
        {
            InitializeComponent();
            printList();            
        }

        private void printList()
        {
            var list = controller.getList();
            lbTimeAndTask.DataSource = list
                .OrderBy(x => x.dateTime).ToList();       
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(cbTaskDone.Checked)
            {
                var todo = (ToDoAppData.ToDoList)lbTimeAndTask.SelectedItem;
                controller.saveDoneTask(todo);
                MessageBox.Show("Aufgabe erledigt!");
                printList();
                cbTaskDone.Checked = false; 
            }
        }

        private void btnChangeForm_Click(object sender, EventArgs e)
        {
            this.Close();           
        }
    }
}
