// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;
using System.Security.Cryptography;
// TODO LIST: 3 Classes, 2 For-loops, 4 Unique functions

// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>

        BasketballObjects Basketball = new BasketballObjects();
        Weather Cloud = new Weather();
        BasketSun Sun = new BasketSun();
        float BallMultiplier = 1;
        bool nightTime = false;

        public void Setup()
        {
            Window.SetTitle("Basketball Rain");
            Window.SetSize(800, 600);
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(111, 172, 222); //teal background by default
            if (nightTime == true) Window.ClearBackground(11, 42, 92); //dark blue when night

            Draw.SetLineSize(0); //removes the outline of shapes

            Draw.SetFillColor(11, 222, 33); //sets the top grass layer to bright green
            Draw.Rectangle(0, 490, 800, 10); //draws a top grass layer

            Draw.SetFillColor(11, 192, 33); //sets the ground to green
            Draw.Rectangle(0, 500, 800, 30); //draws a green ground

            Draw.SetFillColor(99, 77, 11); //sets the bottom soil layer to brown
            Draw.Rectangle(0, 530, 800, 70); //draws a bottom soil layer



            Sun.BasketballSun(BallMultiplier, nightTime); //Draws the sun/moon

            Draw.SetLineSize(0);

            for (int i = 0; i < 5; i++)
            {
                Cloud.Cloud(60 + i*150, 90); 
                //Draws 5 clouds, each being 150 pixels to the right of the other
            }


            

            //Basketball2.Update();
            Basketball.SpawnBasketball(BallMultiplier);

            //Depending on the number the user taps on their keyboard, the strength
            //of the sun increases, visually indicated by the markings of the sun
            //getting bigger, this increases how many basketballs rains
            //when the user holds down the 'B' key (or 'SPACEBAR')
            //if the user taps 0, few basketballs rain
            //if the user taps 9, it's a basketball storm
            if (Input.IsKeyboardKeyPressed(KeyboardKey.One)) BallMultiplier = 1;
            else if (Input.IsKeyboardKeyPressed(KeyboardKey.Two)) BallMultiplier = 2;
            else if (Input.IsKeyboardKeyPressed(KeyboardKey.Three)) BallMultiplier = 3;
            else if (Input.IsKeyboardKeyPressed(KeyboardKey.Four)) BallMultiplier = 4;
            else if (Input.IsKeyboardKeyPressed(KeyboardKey.Five)) BallMultiplier = 5;
            else if (Input.IsKeyboardKeyPressed(KeyboardKey.Six)) BallMultiplier = 6;
            else if (Input.IsKeyboardKeyPressed(KeyboardKey.Seven)) BallMultiplier = 7;
            else if (Input.IsKeyboardKeyPressed(KeyboardKey.Eight)) BallMultiplier = 8;
            else if (Input.IsKeyboardKeyPressed(KeyboardKey.Nine)) BallMultiplier = 9;
            else if (Input.IsKeyboardKeyPressed(KeyboardKey.Zero)) BallMultiplier = 0.2f;


            //Tap 'ENTER' to switch between Day & Night 🗿💱
            if (Input.IsKeyboardKeyPressed(KeyboardKey.Enter) && nightTime == false) 
            { nightTime = true; Console.WriteLine("it's night"); }
            else if (Input.IsKeyboardKeyPressed(KeyboardKey.Enter) && nightTime == true) 
            { nightTime = false; Console.WriteLine("it's day"); }
        }


        

        

        


    }

}
