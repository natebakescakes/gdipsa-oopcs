using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopcs
{
    public class Coin
    {
        private Random r = new Random();

        public enum FaceType { Heads, Tails }

        // Possible to overload, initialize to Heads/Tails.
        public Coin()
        {
            this.Flip();
        }

        public Coin(FaceType faceType)
        {
            switch (faceType)
            {
                case FaceType.Heads:
                    Face = FaceType.Heads;
                    break;
                case FaceType.Tails:
                    Face = FaceType.Tails;
                    break;
            }
        }

        public FaceType Face { get; set; }

        public void Flip()
        {
            Face = r.Next(2) == 0 ? FaceType.Heads : FaceType.Tails;
        }
    }
}
