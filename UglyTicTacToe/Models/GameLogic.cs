
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UglyTicTacToe.Models
{
    public class GameLogic
    {
        public static int ButtonsLeft=9;
        public static Buttons[,] buttonArray = new Buttons[3, 3];

        public static void initArray()
        {
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col<3; col++)
                {
                    buttonArray[row, col] = new Buttons(MyState.None);
                }                
            }
        }

        public Buttons[,] getArray()
        {
            return buttonArray;
        }

        public static MyState ApplyLogic()
        {
            for (int row = 0; row < 3; row++)
            {
                if (buttonArray[row,0].currentState == buttonArray[row, 1].currentState && buttonArray[row, 1].currentState == buttonArray[row, 2].currentState)
                {
                    //user wins (same state in a row);
                    if (buttonArray[row, 0].currentState != MyState.None)
                    {
                        return buttonArray[row, 0].currentState;
                    }
                }
            }
            for (int col = 0; col < 3; col++)
            {
                if (buttonArray[0, col].currentState == buttonArray[1, col].currentState && buttonArray[1, col].currentState == buttonArray[2, col].currentState)
                {
                    //user wins (same state in a column);
                    if (buttonArray[0, col].currentState != MyState.None)
                    {
                        return buttonArray[0, col].currentState;
                    }
                }
            }

            if (buttonArray[0, 0].currentState == buttonArray[1, 1].currentState && buttonArray[1, 1].currentState == buttonArray[2, 2].currentState)
            {
                //user wins (left to right diagonal)
                if (buttonArray[0, 0].currentState != MyState.None)
                {
                    return buttonArray[0, 0].currentState;
                }
            }
            if (buttonArray[0, 2].currentState == buttonArray[1, 1].currentState && buttonArray[1, 1].currentState == buttonArray[2, 0].currentState)
            {
                //user wins (right to left diagonal)
                if (buttonArray[0, 2].currentState != MyState.None)
                {
                    return buttonArray[0, 2].currentState;
                }
            }
            return MyState.None;
        }
    }
}