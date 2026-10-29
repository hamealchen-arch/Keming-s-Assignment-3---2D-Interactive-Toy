using MohawkGame2D;
using Raylib_cs;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace MohawkGame2D
{
    public class BasketballObjects
    {
        public void Basketball(int locationX, int locationY)
        {
            Draw.SetFillColor(250, 120, 40); //sets the basketball deep-orange
            Draw.SetLineSize(0); //clears any lines
            Draw.Ellipse(locationX, locationY, 59, 59); //draws the basketball

            Draw.SetLineColor(3, 4, 5); //black
            Draw.SetLineSize(2); //draws those markings on the basketball

            Draw.LineSharp(locationX - 29, locationY, locationX + 29, locationY); //Draws line left to right
            Draw.LineSharp(locationX, locationY - 29, locationX, locationY + 29); //Draws line top to bottom
            Draw.LineSharp(locationX - 20, locationY - 20, locationX + 21, locationY + 21); //Draws line top-left to bottom-right
            Draw.LineSharp(locationX - 20, locationY + 20, locationX + 21, locationY - 21); //Draws line bottom-left to top-right

        }
        public void SpawnBasketball(float BallMultiplier)
        { //This function spawns 5 basketballs for 1 frame when 'B' is being held down (or 'SPACEBAR')
            if (Input.IsKeyboardKeyDown(KeyboardKey.B) || Input.IsKeyboardKeyDown(KeyboardKey.Space))
            {
                for (int i = 0; i < 5*BallMultiplier; i++)
                {
                    Basketball(90 + Random.Integer(0, 5) * 150 + Random.Integer(-15, 15), Random.Integer(130, 620));
                    //These params randomises the basketball's location,
                    //5 streams, with each stream having a 15 pixel variation.
                    //Also sets the basketballs to flow from the clouds
                    //to the bottom of the screen (and then some)
                }
            }
        }
    }
}
