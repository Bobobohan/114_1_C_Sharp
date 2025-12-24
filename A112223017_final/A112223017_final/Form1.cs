namespace A112223017_final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeGame();
        }

        private int playerWins = 0;
        private int computerWins = 0;

        private int computerChoice;

        private const int ROCK = 0;
        private const int SCISSORS = 1;
        private const int PAPER = 2;

        private enum Move
        {
            Rock, Scissors, Paper
        }

        private void InitializeGame()
        {
            // 程式啟動時，圖片區域為空白
            pictureBox_computer.Image = null;
            pictureBox_player.Image = null;                        
        }

        private void btnStone_Click(object sender, EventArgs e)
        {
            PlayGameRound(ROCK);
        }

        private void btnPaper_Click(object sender, EventArgs e)
        {
            PlayGameRound(SCISSORS);
        }

        private void btnScissor_Click(object sender, EventArgs e)
        {
            PlayGameRound(PAPER);
        }

        private void PlayGameRound(int playerChoice)
        {
            getCompChoice();

            showPlayerImage(playerChoice);
            
            showWinner(playerChoice);
        }

        private void getCompChoice()
        {
            Random rnd = new Random();
            computerChoice = rnd.Next(0, 3);
        }

        private void showPlayerImage(int playerChoice)
        {
            SetImageToPictureBox(pictureBox_player, playerChoice);
        }

        private void showWinner(int playerChoice)
        {
            // 平手
            if (playerChoice == computerChoice)
            {
                label1.Text = "本局結果：平手！";
            }
            else if ((playerChoice == ROCK && computerChoice == SCISSORS) ||
                     (playerChoice == SCISSORS && computerChoice == PAPER) ||
                     (playerChoice == PAPER && computerChoice == ROCK))
            {
                playerWins++;
                label1.Text = "本局結果：玩家獲勝！";
            }
            else
            {
                computerWins++;
                label1.Text = "本局結果：電腦獲勝！";
            }
        }

        private void SetImageToPictureBox(PictureBox pic, int choice)
        {            
            string fileName = "";
            switch (choice)
            {
                case ROCK: fileName = "stone_computer.png"; break;
                case SCISSORS: fileName = "Scissors.png"; break;
                case PAPER: fileName = "Paper.png"; break;
            }
        }

        private void pictureBox_computer_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox_player_Click(object sender, EventArgs e)
        {

        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            this.Close();
            MessageBox.Show("");
        }
    }
}
