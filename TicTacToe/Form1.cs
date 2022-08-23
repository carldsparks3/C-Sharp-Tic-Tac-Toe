namespace TicTacToe
{
    public partial class Form1 : Form
    {
        private string status = "";
        private int playersTurn = 1;
        private List<int> player1Moves = new List<int>();
        private List<int> player2Moves = new List<int>();
        private Boolean gameOver = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GameStatus_Label.Text = "Tic Tac Toe";

            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
        }

        private void StartGame()
        {
            player1Moves = new List<int>();
            player2Moves = new List<int>();

            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";

            status = "Player 1 make a move";
            playersTurn = 1;
            GameStatus_Label.Text = status;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            StartGame();
        }

        private void MakeMove(int playersTurn, int buttonNumber)
        {
            // Only update the move if the position has not already been taken
            if ((!player1Moves.Contains(buttonNumber) && !player2Moves.Contains(buttonNumber)) && !gameOver)
            {
                // Store move 
                if (playersTurn == 1)
                {
                    player1Moves.Add(buttonNumber);

                    // Update UI for button.. draw X
                    UpdateButtonText(playersTurn, buttonNumber, "X");
                }
                else
                {
                    player2Moves.Add(buttonNumber);

                    // Update UI for button.. draw O
                    UpdateButtonText(playersTurn, buttonNumber, "O");
                }

                // Evaluate win condition
                gameOver = EvaluateWinCondition();

                // Setup for next player
                if (!gameOver)
                {
                    if (playersTurn == 1)
                    {
                        this.playersTurn = 2;
                        status = "Player 2 make a move";
                    }
                    else
                    {
                        this.playersTurn = 1;
                        status = "Player 1 make a move";
                    }
                    GameStatus_Label.Text = status;
                }
                else
                {
                    // A player has won
                    GameStatus_Label.Text = status;
                }
            }
        }

        private void UpdateButtonText(int playersTurn, int buttonNumber, string newText)
        {
            switch (buttonNumber)
            {
                case 1:
                    button1.Text = newText;
                    break;
                case 2:
                    button2.Text = newText;
                    break;
                case 3:
                    button3.Text = newText;
                    break;
                case 4:
                    button4.Text = newText;
                    break;
                case 5:
                    button5.Text = newText;
                    break;
                case 6:
                    button6.Text = newText;
                    break;
                case 7:
                    button7.Text = newText;
                    break;
                case 8:
                    button8.Text = newText;
                    break;
                case 9:
                    button9.Text = newText;
                    break;
                default:
                    break;
            }
        }

        private Boolean EvaluateWinCondition()
        {
            Boolean playerHasWon = false;

            // There are only 8 possible win conditions
            if ((player1Moves.Contains(1) && player1Moves.Contains(2) && player1Moves.Contains(3)) ||
                (player1Moves.Contains(4) && player1Moves.Contains(5) && player1Moves.Contains(6)) ||
                (player1Moves.Contains(7) && player1Moves.Contains(8) && player1Moves.Contains(9)) ||
                (player1Moves.Contains(1) && player1Moves.Contains(4) && player1Moves.Contains(7)) ||
                (player1Moves.Contains(2) && player1Moves.Contains(5) && player1Moves.Contains(8)) ||
                (player1Moves.Contains(3) && player1Moves.Contains(6) && player1Moves.Contains(9)) ||
                (player1Moves.Contains(1) && player1Moves.Contains(5) && player1Moves.Contains(9)) ||
                (player1Moves.Contains(3) && player1Moves.Contains(5) && player1Moves.Contains(7)))
            {
                status = "Player 1 Wins!";
                playerHasWon = true;
            }

            // There are only 8 possible win conditions
            if ((player2Moves.Contains(1) && player2Moves.Contains(2) && player2Moves.Contains(3)) ||
                (player2Moves.Contains(4) && player2Moves.Contains(5) && player2Moves.Contains(6)) ||
                (player2Moves.Contains(7) && player2Moves.Contains(8) && player2Moves.Contains(9)) ||
                (player2Moves.Contains(1) && player2Moves.Contains(4) && player2Moves.Contains(7)) ||
                (player2Moves.Contains(2) && player2Moves.Contains(5) && player2Moves.Contains(8)) ||
                (player2Moves.Contains(3) && player2Moves.Contains(6) && player2Moves.Contains(9)) ||
                (player2Moves.Contains(1) && player2Moves.Contains(5) && player2Moves.Contains(9)) ||
                (player2Moves.Contains(3) && player2Moves.Contains(5) && player2Moves.Contains(7)))
            {
                status = "Player 2 Wins!";
                playerHasWon = true;
            }

            return playerHasWon;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MakeMove(playersTurn, 1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MakeMove(playersTurn, 2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MakeMove(playersTurn, 3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MakeMove(playersTurn, 4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MakeMove(playersTurn, 5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MakeMove(playersTurn, 6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MakeMove(playersTurn, 7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MakeMove(playersTurn, 8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MakeMove(playersTurn, 9);
        }
    }
}