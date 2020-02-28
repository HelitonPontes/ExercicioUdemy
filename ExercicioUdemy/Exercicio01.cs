using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioUdemy
{
    class Exercicio01
    {
        public string cod01 { get; set; }
        public string cod02 { get; set; }
        public string quant01 { get; set; }
        public string quant02 { get; set; }
        public string valor01 { get; set; }
        public string valor02 { get; set; }
        public float resultado01 { get; set; }
        public float resultado02 { get; set; }
        public float resultadofinal { get; set; }

        public void Executar()
        { 
            
            resultado01= float.Parse(quant01)*float.Parse( valor01);
            resultado02 = float.Parse(quant02) *float.Parse(valor02);
            resultadofinal = resultado01 + resultado02;

        }
       
        

    }
}