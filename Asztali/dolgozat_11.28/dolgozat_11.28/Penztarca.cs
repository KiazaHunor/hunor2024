using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;


/* tárca a class  fia kézpénz - valamennyi 
feleség masik tárca  első tarcaból levonas ebbe 
 kap fizetest neha penz vagy pénztarca
 lakodalom -  1 pénztarca
 adossag - megegy pénztarca*/



namespace dolgozat_11._28
{
    internal class Penztarca
    {

        public int keszp;
        public int tarca;


        public Penztarca(int keszp, int tarca)
        {
            this.keszp = keszp;
            this.tarca = tarca;
        }
        public static Penztarca operator(Penztarca a, Penztarca b)
        {

        }





    }


}
        

