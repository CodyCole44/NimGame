using System;
using System.Collections.Generic;
using System.Text;

namespace Nim
{
    class SetPiles : MakePiles
    {
        public SetPiles()
        {
            Random rnd = new Random();

            StackA = rnd.Next(1, 5);
            StackB = rnd.Next(1, 5);
            StackC = rnd.Next(1, 5);
            
        }
    }
}
