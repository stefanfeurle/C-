using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vier_gewinnt_Logic;

namespace Vier_gewinnt
{
    public partial class Vier_gewinnt : Form
    {
        VierGewinntController controller = new VierGewinntController();
        int player1 = 1;
        int player2 = 2;
        int throwIn = 0;

        public Vier_gewinnt()
        {
            InitializeComponent();
            StartGame();
        }

        private void btnStartNewGame_Click(object sender, EventArgs e)
        {
            StartGame();
        }

        private void StartGame()
        {
            controller.createNewDictionary();
            for (int c = 0; c < 7; c++)
            {
                for (int r = 0; r < 6; r++)
                {
                    var pBox = Controls.Find($"pBox{c}_{r}", true).FirstOrDefault();
                    pBox.BackColor = Color.FromArgb(224,224,224);
                }
            }
            throwIn = 0;
        }

        private void checkThrowIn(int column)
        {
            var player = throwIn % 2 == 0 ? player1 : player2;
            int? row = controller.checkThrowIn(column, player);
            if(row != null)
            {
                var pBox = Controls.Find($"pBox{column}_{row}",true).FirstOrDefault();
                //Controls.Contains
                //    this.Controls.RemoveByKey($"pBox{column}_{row}");//.FirstOrDefault();
                if (player == 1)
                    pBox.BackColor = Color.Yellow;
                else
                    pBox.BackColor = Color.Red;
                throwIn++;
                player = controller.CheckFourInRow();
                if (player > 0)
                {
                    MessageBox.Show($"Player {player} hat gewonnen!");
                    StartGame();
                }
            }
        }

        private void btnColumn0_Click(object sender, EventArgs e)
        {
            checkThrowIn(0);
        }

        private void btnColumn1_Click(object sender, EventArgs e)
        {
            checkThrowIn(1);
        }

        private void btnColumn2_Click(object sender, EventArgs e)
        {
            checkThrowIn(2);
        }

        private void btnColumn3_Click(object sender, EventArgs e)
        {
            checkThrowIn(3);
        }

        private void btnColumn4_Click(object sender, EventArgs e)
        {
            checkThrowIn(4);
        }

        private void btnColumn5_Click(object sender, EventArgs e)
        {
            checkThrowIn(5);
        }

        private void btnColumn6_Click(object sender, EventArgs e)
        {
            checkThrowIn(6);
        }
    }
}
