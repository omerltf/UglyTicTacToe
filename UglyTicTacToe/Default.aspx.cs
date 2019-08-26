using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UglyTicTacToe.Models;
using System.Windows;
namespace UglyTicTacToe
{
    public partial class Default : System.Web.UI.Page
    {
        MyState lastState = Buttons.recentState;
        MyState currentState;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GameLogic.initArray();
            }
        }

        protected void NewGameButton_Click(object sender, EventArgs e)
        {
            Buttons.recentState = MyState.None;
            GameLogic.ButtonsLeft = 9;
            GameLogic.initArray();
            Response.Redirect("~/Default.aspx");
        }

        protected void Button_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            string buttonIDString = "";
            clickedButton.Enabled = false;
            GameLogic.ButtonsLeft -= 1;
            buttonIDString = clickedButton.ID;
            if (lastState == MyState.None || lastState == MyState.Nill)
            {
                clickedButton.Text = "X";
                currentState = MyState.Cross;
                Buttons.recentState = currentState;
            }
            else if (lastState == MyState.Cross)
            {
                clickedButton.Text = "O";
                currentState = MyState.Nill;
                Buttons.recentState = currentState;
            }

            UpdateGameLogic(buttonIDString);

            if (GameLogic.ApplyLogic() == MyState.Cross)
            {
                WinNotificationX.Visible = true;
                Confetti.Visible = true;
                TTT.Visible = true;
                DisableAllButtons();
            }
            else if (GameLogic.ApplyLogic() == MyState.Nill)
            {
                WinNotificationO.Visible = true;
                Confetti.Visible = true;
                TTT.Visible = true;
                DisableAllButtons();
            }
            else if (GameLogic.ButtonsLeft == 0)
            {
                //There is a tie
                TieNotification.Visible = true;
            }
            // if win (display who wins and disable all buttons)
        }

        public void UpdateGameLogic(string buttonID)
        {
            switch (buttonID)
            {
                case "One":
                    GameLogic.buttonArray[0, 0].currentState = currentState;
                    break;
                case "Two":
                    GameLogic.buttonArray[0, 1].currentState = currentState;
                    break;
                case "Three":
                    GameLogic.buttonArray[0, 2].currentState = currentState;
                    break;
                case "Four":
                    GameLogic.buttonArray[1, 0].currentState = currentState;
                    break;
                case "Five":
                    GameLogic.buttonArray[1, 1].currentState = currentState;
                    break;
                case "Six":
                    GameLogic.buttonArray[1, 2].currentState = currentState;
                    break;
                case "Seven":
                    GameLogic.buttonArray[2, 0].currentState = currentState;
                    break;
                case "Eight":
                    GameLogic.buttonArray[2, 1].currentState = currentState;
                    break;
                case "Nine":
                    GameLogic.buttonArray[2, 2].currentState = currentState;
                    break;
            }
        }

        public void DisableAllButtons()
        {
            ButtonPanel.Enabled = false;
        }

        protected void WarningButton_Click(object sender, EventArgs e)
        {
            Warning.Visible = false;
            WarningButton.Visible = false;
            ButtonPanel.Visible = true;
            NewGameButton.Visible = true;
        }
    }
}