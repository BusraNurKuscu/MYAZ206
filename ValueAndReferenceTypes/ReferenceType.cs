﻿namespace ValueAndReferenceTypes
{
    public class ReferenceType
    {
        public ReferenceType()
        {

        }
        public ReferenceType(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get; set; }
        public int Y { get; set; }

        public void SwapByValue(int x, int y)
        {
            var temp = x;
            x = y;
            y = temp;
        }
        public void SwapByRef(ref int x,ref int y)
        {
            var temp = x;
            x = y;
            y = temp;
        }



    }
   
}