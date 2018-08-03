using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construction
{
    public class Home
    {
        int doors;
        int windows;
        PaintState state;

        public Home():this(2, 4)
        {
           
        }

        public Home(int doors, int windows)
        {
            this.doors = doors;
            this.windows = windows;
            state = PaintState.Unpainted;
        }

        public int Doors
        {
            get {
                return doors;
            }
            set {
                doors = value;
            }


        }

        public void PaintHome()
        {
            state = PaintState.Painted;
            
        }

        public bool IsHabitable()
        {
            if(state == PaintState.Unpainted)
            {
                return false;
            }
            else if(state == PaintState.Painted)
            {
                return true;
            }

            return false;
        }


    }

    public enum PaintState
    {
        Painted,
        Unpainted
    }
}
