using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mystictac
{
    public enum GameState
    {
        Setup,
        Game,
        End,
    }
    public enum CellState
    {
        Empty = 0,
        Player1,
        Player2,
    }
    public partial class GameWindow : Form
    {
        bool debug = false;

        int minimumWeight = 1;
        int maximumWeight = 8;
        Random rnd = new Random();

        int _playgroundSize = 4;
        int _maxPlaygroundSize = 16;
        int[] scores = new int[2] { 0, 0 };
        Color[] colors = new Color[2] { Color.FromArgb(255,170,0) , Color.FromArgb(0,170,255) };

        Button[,] cells;
        int[] rowWeights; //i
        int[] columnWeights; //j

        Label[] rowNumbers;
        Label[] columnNumbers;

        Point playgroundTopLeft = new Point(100, 100);
        int cellEdgeLength;
        GameState currentState = GameState.Setup;
        int currentPlayer;
        public GameWindow()
        {
            InitializeComponent();
        }
        private void GameWindow_Paint(object sender, PaintEventArgs e)
        {
            
        }
        private void GameWindow_Load(object sender, EventArgs e)
        {
            ScorePlayer1.BackColor = colors[0];
            ScorePlayer2.BackColor = colors[1];
        }
        private void init_playground()
        {
            Playboard.Controls.Clear();
            scores[0] = 0;
            scores[1] = 0;
            cellEdgeLength = (600 / _playgroundSize) - 5;
            cells = new Button[_playgroundSize, _playgroundSize];
            for (int i = 0; i < _playgroundSize; i++)
            {
                for (int j = 0; j < _playgroundSize; j++)
                {
                    Button NewCell = new Button();
                    Playboard.Controls.Add(NewCell);
                    NewCell.Text = "0";
                    NewCell.Name = i.ToString() + "_" + j.ToString();
                    NewCell.Click += Button_Click;
                    NewCell.Top = playgroundTopLeft.Y + i * (cellEdgeLength + 5);
                    NewCell.Left = playgroundTopLeft.X + j * (cellEdgeLength + 5);
                    NewCell.Size = new Size(cellEdgeLength, cellEdgeLength);
                    NewCell.BackColor = Color.LightGray;
                    cells[i, j] = NewCell;
                }
            }
            rowWeights = new int[_playgroundSize];
            columnWeights = new int[_playgroundSize];
            for (int i = 0; i < _playgroundSize; i++)
            {
                rowWeights[i] = rnd.Next(minimumWeight, maximumWeight);
                columnWeights[i] = rnd.Next(minimumWeight, maximumWeight);
            }
            //if (debug)
            rowAndColumnPoints_Create();
            currentPlayer = 0;
        }
        private void rowAndColumnPoints_Create()
        {
            Font font = new Font("Arial", 15);
            rowNumbers = new Label[_playgroundSize];
            columnNumbers = new Label[_playgroundSize];
            for (int i = 0; i < _playgroundSize; i++)
            {
                rowNumbers[i] = new Label();
                Playboard.Controls.Add(rowNumbers[i]);
                if (debug)
                    rowNumbers[i].Text = rowWeights[i].ToString();
                else
                    rowNumbers[i].Text = GetLetter(i);
                rowNumbers[i].Top = playgroundTopLeft.Y + i * (cellEdgeLength + 5) + (cellEdgeLength / 2) + 8;
                rowNumbers[i].Left = playgroundTopLeft.X - 30;
                rowNumbers[i].Font = font;

                columnNumbers[i] = new Label();
                Playboard.Controls.Add(columnNumbers[i]);
                if (debug)
                    columnNumbers[i].Text = columnWeights[i].ToString();
                else
                    columnNumbers[i].Text = (i + 1).ToString();
                columnNumbers[i].Top = playgroundTopLeft.Y - 30;
                columnNumbers[i].Left = playgroundTopLeft.X + i * (cellEdgeLength + 5) + (cellEdgeLength / 2);
                columnNumbers[i].Font = font;
            }

        }
        private void canvas_Paint(object sender, PaintEventArgs e)
        {
            this.LabelPlaygroundSize.Text = _playgroundSize.ToString() + " X " + _playgroundSize.ToString();
        }
        private void Playboard_Paint(object sender, PaintEventArgs e)
        {
            if (currentState == GameState.Setup && scores[0]==0)
            {
                Label explanation = new Label();
                Playboard.Controls.Add(explanation);
                
                Font font = new Font("Georgia", 10);
                explanation.Font = font;
                explanation.Size = new Size(800, 800);
                explanation.Text = "\r\n\r\n     It is a very different version of Tic Tac Toe.\r\n" +
                    "     Players make their move by choosing a square over the board.\r\n" +
                    "     Actually, this is the only similarity between this game and that game.\r\n" +
                    "     Every column and row has its own weights.\r\n" +
                    "     Players increase their points by the multiplication of the weights of row and column that have the chosen square.\r\n" +
                    "     Weights could be any integer between  " + minimumWeight.ToString() + " and  " + maximumWeight.ToString() + ". Players can only see the points of chosen squares during the game. \r\n" +
                    "     Players should discover the random board by solving the weights of rows and columns so they can choose a square with high points.\r\n" +
                    "     The player with the most total points wins the game.\r\n" +
                    "     Good luck! Have fun! \r\n\r\n\n" +


                    "     Bu oyun; Tic Tac Toe'nun çok farklı, sayısal bir versiyonu.\r\n" +
                    "     Oyuncular tahtada birer birer kare seçerek oyuna devam eder. İki oyun arasındaki tek benzerlik bu aslında.\r\n" +
                    "     Her satır ve sütunun kendine özel bir puan ağırlığı vardır.\r\n" +
                    "     Oyuncular seçtiği karenin bulunduğu satır ve sütunun puan ağırlıklarının çarpımı kadar puan kazanır.\r\n" +
                    "     Puan ağırlıkları " + minimumWeight.ToString() + " ve " + maximumWeight.ToString() + " arasındadır. Oyun sırasında sadece seçilen karelerden kaç puan kazanıldığı gözükür.\r\n" +
                    "     Oyuncular rastgele oluşan tahtayı, satır ve sütunların puanlarını çözerek keşfetmeli ve buna göre kare seçimlerini yapmalı.\r\n" +
                    "     Oyunun sonunda toplam en çok puanı kazanan oyuncu oyunu kazanır.\r\n" +
                    "     Good luck! Have fun! \r\n\r\n\n";
            }
            else if (currentState == GameState.Game)
            {
                scores_Paint();
                checkEnd();
            }
        }
        private void checkEnd()
        {
            for (int i=0; i<_playgroundSize; i++)
            {
                for (int j=0; j<_playgroundSize; j++)
                {
                    if (cells[i, j].Text == "0")
                        return;
                }
            }
            currentState = GameState.Setup;
            Label result = new Label();
            canvas.Controls.Add(result);
            Font font = new Font("Arial", 15);
            result.Font = font;
            result.Size = new Size(350,30);
            if (scores[0]>scores[1])
                result.Text = "PLAYER ORANGE WON!!";
            else if (scores[1] > scores[0])
                result.Text = "PLAYER BLUE WON!!";
            else
                result.Text = "IT IS A TIE!!";
            result.Top = 600;
            result.Left = 750;
        }
        void Button_Click(object sender, EventArgs e)
        {
            var b = sender as Button;
            if (b!=null)
            {
                string[] indices = b.Name.Split('_');
                int i = int.Parse(indices[0]);
                int j = int.Parse(indices[1]);
                if (b.Text!="0")
                    return;
                int scorePlus = columnWeights[j] * rowWeights[i];
                if (currentPlayer==1)
                {
                    b.BackColor = colors[1];
                    b.Text = scorePlus.ToString();
                    scores[1] += scorePlus;
                }
                else if (currentPlayer==0)
                {
                    b.BackColor = colors[0];
                    b.Text = scorePlus.ToString();
                    scores[0] += scorePlus;
                }
                currentPlayer = (currentPlayer+1)%2;
            }
        }
        private void scores_Paint()
        {
            ScorePlayer1.Text = scores[0].ToString();
            ScorePlayer2.Text = scores[1].ToString();
        }
        private void buttonPlaygroundSize_plus_MouseClick(object sender, MouseEventArgs e)
        {
            if (currentState == GameState.Game)
                return;

            _playgroundSize += 2;
            if (_playgroundSize > _maxPlaygroundSize)
                _playgroundSize = _maxPlaygroundSize;
        }
        private void buttonPlaygroundSize_minus_Click(object sender, EventArgs e)
        {
            if (currentState == GameState.Game)
                return;

            _playgroundSize -= 2;
            if (_playgroundSize < 4)
                _playgroundSize = 4;
        }
        private void StartButton_MouseClick(object sender, MouseEventArgs e)
        {
            if (currentState == GameState.Setup)
            {
                currentState = GameState.Game;
                init_playground();
            }
        }
        public string GetLetter(int value)
        {
            char letter = (char)('A' + value);
            return letter.ToString();
        }

    }
}
