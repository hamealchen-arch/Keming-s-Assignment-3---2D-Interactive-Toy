using System;
using System.Collections.Generic;
using System.Text;

namespace MohawkGame2D
{
    public class Weather
    {

        public void Cloud(int locationX, int locationY)
        {
            Draw.SetFillColor(200, 220, 240); //sets the cloud to off-white, it's slightly teal because
                                              //i wanted it to mimic "transparency" for the teal background

            //the following 5 lines draws a cloud
            //the circles go from left to right, and
            //shifts up slightly so it accomodates the size change
            //there's also a rectangle that just makes the
            //bottom of the cloud flat
            Draw.Rectangle(0 + locationX, 25 + locationY, 80, 10);
            Draw.Ellipse(0 + locationX, 13 + locationY, 45, 45);
            Draw.Ellipse(25 + locationX, 3 + locationY, 55, 55);
            Draw.Ellipse(50 + locationX, 8 + locationY, 50, 50);
            Draw.Ellipse(75 + locationX, 13 + locationY, 45, 45);
        }
    }
}
