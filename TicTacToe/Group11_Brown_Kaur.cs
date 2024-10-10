/* GROUP 11 SECTION 4
 * NAME: AUSTIN BROWN AND MAHAKDEEP KAUR
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Group11_Brown_Kaur : Form
    {
        private int gridSize = 3;
        private PictureBox[,] grid;
        private bool isPlayerO = true;
        private int roundCount = 0;
        private int playerOWins = 0;
        private int playerXWins = 0;
      


        public Group11_Brown_Kaur()
        {
            InitializeComponent();
            InitializeGame();


        }

        private void Group11_Brown_Kaur_Load(object sender, EventArgs e)
        {

        }

        private void InitializeGame()
        {
            roundCount = 1;
            playerOWins = 0;
            playerXWins = 0;
            isPlayerO = true;

            comboBox.Items.Add("3x3");
            comboBox.Items.Add("5x5");
            comboBox.SelectedIndex = -1;

            CircleWinning.Visible = false;
            Xwinning.Visible = false;

            
            panel.Visible = false;

            UpdateMedals();
        }
        private void CreateGrid()
        {
            panel.Controls.Clear();
            gridSize = comboBox.SelectedIndex == 0 ? 3 : 5;
            grid = new PictureBox[gridSize, gridSize];

            int cellSize = panel.Width / gridSize;
            for (int i = 0; i < gridSize; i++)
            {
                for (int j = 0; j < gridSize; j++)
                {
                    grid[i, j] = new PictureBox
                    {
                        Width = cellSize,
                        Height = cellSize,
                        BorderStyle = BorderStyle.FixedSingle,
                        Location = new Point(i * cellSize, j * cellSize),
                        Tag = string.Empty,
                        SizeMode = PictureBoxSizeMode.StretchImage
                    };
                    grid[i, j].Click += new EventHandler(Cell_Click);
                    panel.Controls.Add(grid[i, j]);
                }
            }
        }
        private void Cell_Click(object sender, EventArgs e)
        {
            PictureBox cell = sender as PictureBox;
            if (cell != null && string.IsNullOrEmpty(cell.Tag.ToString()))
            {
                cell.Image = isPlayerO ? Properties.Resources.PlayerCircle : Properties.Resources.PlayerX;
                cell.Tag = isPlayerO ? "O" : "X";

                if (CheckWin())
                {
                    MessageBox.Show($"Player {(isPlayerO ? 1 : 2)} is the winner for this round!");
                    if (isPlayerO) playerOWins++;
                    else playerXWins++;
                    UpdateStats();
                    StartNewGame();
                }
                else if (Draw())
                {
                    MessageBox.Show("The game is a draw XD !!");
                    StartNewGame();
                }
                else
                {
                    isPlayerO = !isPlayerO;
                }
            }
        }


        private bool CheckWin()
        {
            
            for (int i = 0; i < gridSize; i++)
            {
                if (CheckLine(i, 0, 0, 1) || CheckLine(0, i, 1, 0))
                    return true;
            }
            return CheckLine(0, 0, 1, 1) || CheckLine(0, gridSize - 1, 1, -1);


        }
        private bool CheckLine(int startX, int startY, int stepX, int stepY)
        {
            string firstCell = grid[startX, startY].Tag.ToString();
            if (string.IsNullOrEmpty(firstCell)) return false;

            for (int i = 1; i < gridSize; i++)
            {
                if (grid[startX + i * stepX, startY + i * stepY].Tag.ToString() != firstCell)
                    return false;
            }
            return true;
        }
        private void UpdateStats()
        {
            displayrounds.Text = $" {roundCount}";
            scoreplayer1.Text = $"Player 1 Wins: {playerOWins}";
            labelPlayertwo.Text = $"Player 2 Wins: {playerXWins}";

            UpdateMedals();
        }
        private void StartNewGame()
        {
            foreach (PictureBox cell in grid)
            {
                cell.Image = null;
                cell.Tag = string.Empty;
            }
            isPlayerO = true;
            roundCount++;
            UpdateStats();
        }

        private void buttonStartnewgame_Click(object sender, EventArgs e)
        {
            if (roundCount == 1)
            {
                MessageBox.Show("You are already in a new game.", " ", MessageBoxButtons.OK);
                return; 
            }

            playerOWins = 0;
            playerXWins = 0;
            roundCount = 1;

            foreach (PictureBox cell in grid)
            {
                cell.Image = null;
                cell.Tag = string.Empty;
            }

            panel.Visible = false;
            comboBox.SelectedIndex = -1;

            isPlayerO = true;
            UpdateStats();
            CreateGrid();
        }
        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox.SelectedIndex != -1)
            {
                panel.Visible = true;
                CreateGrid();
            }
        }

        private void Exitgame_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks for playing! ", "Exit", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }

        private void UpdateMedals()
        {
            if (playerOWins > playerXWins)
            {
                CircleWinning.Visible = true;
                Xwinning.Visible = false;
                
            }
            else if (playerXWins > playerOWins)
            {
                Xwinning.Visible = true;
                CircleWinning.Visible = false;
                
            }
            else
            {
                CircleWinning.Visible = false;
                Xwinning.Visible = false;
            }
        }

        private bool Draw()
        {
            foreach (var cell in grid)
            {
                if (string.IsNullOrEmpty(cell.Tag.ToString()))
                {
                    return false;
                }
            }
            return true; 
        }
    }
}
