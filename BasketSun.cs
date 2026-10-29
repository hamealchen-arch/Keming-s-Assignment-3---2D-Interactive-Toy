using System;
using System.Collections.Generic;
using System.Text;

namespace MohawkGame2D
{
    public class BasketSun
    {//because the sun is a basketball itself, how else would it rain basketballs?
        public void BasketballSun(float BallMultiplier, bool nightTime)
        {
            if (nightTime != true) //It's day by default
            {
                Draw.SetFillColor(255, 199, 44); //sets the sun to yellow
                Draw.Ellipse(50, 50, 100, 100); //draws the yellow sun
                Draw.SetLineColor(222, 111, 0); //the sun has orange lines
            }
            else //If it's night, it draws a basketball moon instead
            {
                Draw.SetFillColor(177, 177, 199); //sets the moon to gray
                Draw.Ellipse(50, 50, 100, 100); //draws the gray moon
                Draw.SetLineColor(111, 111, 111); //the moon has gray lines
            }
            
            Draw.SetLineSize(1 + 1*BallMultiplier); //line size represents the strength of the sun
            //the thicker the lines, the more basketball it rains
            Draw.LineSharp(0, 50, 100, 50); //Draws line left to right
            Draw.LineSharp(50, 0, 50, 100); //Draws line top to bottom
            Draw.LineSharp(15, 15, 85, 85); //Draws line top-left to bottom-right
            Draw.LineSharp(15, 85, 85, 15); //Draws line bottom-left to top-right


        }
    }
}
