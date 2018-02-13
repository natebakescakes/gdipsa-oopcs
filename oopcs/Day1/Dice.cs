using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopcs
{
    public class Dice
    {
        private int _faceUp;
        private Random r = new Random();

        public Dice()
        {
            this.Throw();
        }

        public Dice(int initValue)
        {
            _faceUp = initValue;
        }

        public string StrFaceUp
        {
            get
            {
                return _faceUp.ToString();
            }
        }

        public void Throw()
        {
            _faceUp = r.Next(1, 7);
        }       
    }
}
