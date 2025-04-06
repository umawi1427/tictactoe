using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace tictactoe
{
    public partial class Form1 : Form
    {
        public enum Player
        {
            X, O
        }

        Player currentPlayer;
        List<Button> buttons;
        Random rand = new Random();
        int playerWins = 0;
        int computerWins = 0;

        System.Windows.Forms.Timer AImoves = new System.Windows.Forms.Timer();

        public Form1()
        {
            InitializeComponent();
            resetGame();
            AImoves.Interval = 1000;
            AImoves.Tick += AImove;
        }

        private void playerClick(object sender, EventArgs e)
        {
            var button = (Button)sender;
            currentPlayer = Player.X;
            button.Text = currentPlayer.ToString();
            button.Enabled = false;
            button.BackColor = Color.Cyan;
            buttons.Remove(button);
            Check();
            AImoves.Start();
        }

        private void AImove(object? sender, EventArgs e)
        {
            if (buttons.Count > 0)
            {
                int index = rand.Next(buttons.Count);
                buttons[index].Enabled = false;
                currentPlayer = Player.O;
                buttons[index].Text = currentPlayer.ToString();
                buttons[index].BackColor = Color.DarkSalmon;
                buttons.RemoveAt(index);
                Check();
                AImoves.Stop();
            }
        }

        private void restartGame(object sender, EventArgs e)
        {
            resetGame();
        }

        private void loadbuttons()
        {
            buttons = new List<Button> { button1, button2, button3, button4, button5, button6, button7, button8, button9 };
        }

        private void resetGame()
        {
            foreach (Control X in this.Controls)
            {
                if (X is Button && X.Tag == "play")
                {
                    ((Button)X).Enabled = true;
                    ((Button)X).Text = "";
                    ((Button)X).BackColor = default(Color);
                }
            }
            loadbuttons();
            playerWinsLabel.Text = $"Player Wins: {playerWins}";
            computerWinsLabel.Text = $"Computer Wins: {computerWins}";
        }

        private void Check()
        {
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X"
                || button4.Text == "X" && button5.Text == "X" && button6.Text == "X"
                || button7.Text == "X" && button8.Text == "X" && button9.Text == "X"
                || button1.Text == "X" && button4.Text == "X" && button7.Text == "X"
                || button2.Text == "X" && button5.Text == "X" && button8.Text == "X"
                || button3.Text == "X" && button6.Text == "X" && button9.Text == "X"
                || button1.Text == "X" && button5.Text == "X" && button9.Text == "X"
                || button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                AImoves.Stop();
                MessageBox.Show("Player Wins");
                playerWins++;
                resetGame();
            }
            else if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O"
                || button4.Text == "O" && button5.Text == "O" && button6.Text == "O"
                || button7.Text == "O" && button8.Text == "O" && button9.Text == "O"
                || button1.Text == "O" && button4.Text == "O" && button7.Text == "O"
                || button2.Text == "O" && button5.Text == "O" && button8.Text == "O"
                || button3.Text == "O" && button6.Text == "O" && button9.Text == "O"
                || button1.Text == "O" && button5.Text == "O" && button9.Text == "O"
                || button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                AImoves.Stop();
                MessageBox.Show("Computer Wins");
                computerWins++;
                resetGame();
            }
        }
    }
}