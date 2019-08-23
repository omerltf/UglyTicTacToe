using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UglyTicTacToe.Models
{
    public enum MyState
    {
        None,
        Cross,
        Nill
    }

    public class Buttons
    {
        public static MyState recentState { get; set; }
        public MyState currentState;
        public Buttons(MyState state)
        {
            this.currentState = state;
        }
    }
}