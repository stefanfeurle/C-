using System;
using System.Timers;
using System.Windows.Forms;
using ToDoAppData;
using ToDoAppLogic;

namespace ToDoApp
{
    public partial class ToDoApp : Form
    {
        ToDoController controller = new ToDoController();
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

        public ToDoApp()
        {
            InitializeComponent();
            timerStart();            
        }

        private void timerStart()
        {
            timer.Interval = 20000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            var list = controller.getList();
            if (list.Count > 0)
            {
                timer.Stop();
                var form = new ToDoToDo();
                form.ShowDialog();                
                timer.Start();                
            }
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            var time = dateTimePicker.Value;
            var task = rtbTask.Text;
            var todo = new ToDoList() {dateTime = time, task = task, hasDoneTask = 0};
            MessageBox.Show(controller.NewTask(todo));
            rtbTask.Text = null;
        }
    }
}
