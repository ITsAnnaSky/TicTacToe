using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        private int btnCount = 0;
        private Game game;
        public Form1()
        {
            InitializeComponent();
            game = new Game(new ComputerPlayer());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewForm creator = new NewForm();
            creator.FormClosed += Creator_FormClosed;
            this.Visible = false;
            creator.ShowDialog();
            
        }

        private void Creator_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = true;
            var form = sender as NewForm;
            var tBox = form.Controls[0] as TextBox;
            this.button1.Text = tBox.Text;
        }
        

    

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Click(object sender, EventArgs e)
        {
            var table = sender as TableLayoutPanel;
            //table.Controls.
            var pictureBox = table.Controls[0];
           
        }

        private void btnCell_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (button.Text.Length == 1)
                return;
            string symbol = string.Empty;
            var location = button.Name.Substring(7);
            int number = int.Parse(location);
            int x = number / 10;
            int y = number % 10;
            game.Move(x-1,y-1);
            if(game.currentMove == 0)
            {
                symbol = game.currentMove.ToString();
                button.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                symbol = "X";
                button.ForeColor = System.Drawing.Color.Red;
            }
            //button.Enabled = false;
            button.Text = symbol;
            if (game.IsVictory())
            {
                MessageBox.Show("Победа! Возьмите билет на мероприятие");
            }
            if (game.GameIsOver())
            {
                MessageBox.Show("Игра окончена.");
            }
            if(game.currentMove == 1)
            {
                Task.Delay(500).Wait();
                game.currentMove = 1;
                var position = game.player.Move(game.table);
                string name = "btnCell" + (position.Item1+1).ToString() + (position.Item2+1).ToString();
                var btn = this.tableLayoutPanel1.Controls.Cast<Button>().FirstOrDefault(item => item.Name == name);
                btn.PerformClick();
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            string symbol = string.Empty;
            ChangeEnable(false);
            var position = game.player.Move(game.table);
            game.Move(position.Item1, position.Item2);
            game.currentMove = 0;
            string name = "btnCell" + (position.Item1 + 1).ToString() + (position.Item2 + 1).ToString();
            var btn = this.tableLayoutPanel1.Controls.Cast<Button>().FirstOrDefault(item => item.Name == name);
            if (game.currentMove == 0)
            {
                symbol = game.currentMove.ToString();
                btn.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                symbol = "X";
                btn.ForeColor = System.Drawing.Color.Red;
            }
            btn.Text = symbol;
        }
        private void ChangeEnable(bool check)
        {
            this.button1.Enabled = check;
            
            var cells = this.tableLayoutPanel1.Controls.Cast<Button>();
            foreach(var item in cells)
            {
                item.Enabled = !check;
            }
        }
        
    }

}
