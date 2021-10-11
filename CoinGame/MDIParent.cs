using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using CoinGame.Models;

namespace CoinGame
{
    public partial class MDIParent : Form
    {
        private bool IsGameWindowShown = false;
        private PlayingField GameWindow;
        private List<HighScore> HighScores = new List<HighScore>();

        public MDIParent()
        {
            InitializeComponent();
            GetScoreFromTxt();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            StartGame();
        }

        private void btnHighScores_Click(object sender, EventArgs e)
        {
            string s = "";
            HighScores.ForEach(p => s += p.Name + "\t" + "\t" + p.Score + "\n\n");
            MessageBox.Show(s, "HighScores");
        }

        private void btnRules_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
               "RULES: \n" +
               "Collect money until timer runs out \n\n" +
               "POWER UP's: \n" +
               "A - Accelaration\n" +
               "S - Slow Motion\n" +
               "$ - Money\n" +
               "T - Time\n \n" +
               "Click OK to start the game");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to quit game, you will lose all progress", "Quit Game", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                SaveScoreToTxt();
                CloseGameWindow();
                Close();
            }
        }

        public void StartGame()
        {
            if (!IsGameWindowShown)
                OpenGameWindow();
            else
            {
                DialogResult dialogResult = MessageBox.Show("Game already in progress. Would you like to start again", "Exit Game", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    CloseGameWindow();
                    OpenGameWindow();
                }
            }
        }

        public void OpenGameWindow()
        {
            IsGameWindowShown = true;
            GameWindow = new PlayingField();
            GameWindow.Show();
        }

        public void CloseGameWindow()
        {
            if (IsGameWindowShown)
                GameWindow.Close();
            IsGameWindowShown = false;
        }

        private void GetScoreFromTxt()
        {
            using (StreamReader sr = new StreamReader(new FileStream("HigScores.txt", FileMode.OpenOrCreate)))
            {
                string txtInFile = sr.ReadToEnd();
                List<string> highScores = txtInFile.Split(new string[] { "\n", "\r\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();
                if (highScores.Count > 0)
                {
                    highScores.ForEach(p =>
                    {
                        string[] highscore = p.Split(new string[] { "-" }, StringSplitOptions.RemoveEmptyEntries);
                        if (highscore.Length == 2)
                        {
                            HighScores.Add(new HighScore(highscore[0], Convert.ToInt32(highscore[1])));
                        }
                    });
                }
            }
        }

        private void SaveScoreToTxt()
        {
            using (StreamWriter sw = new StreamWriter(new FileStream("HigScores.txt", FileMode.Truncate)))
            {
                HighScores.ForEach(p =>
                {
                    sw.WriteLine(p.Name + "-" + p.Score);
                });
            }
        }


    }
}
