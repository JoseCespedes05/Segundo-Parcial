using System;
namespace Pregunta12
{
    public class Pregunta12
    {
        string[] operarios;float[] sueldo;
        public void Cargar() 
        {
            operarios=new string[5];
            sueldo=new float[5];
            for(int i=0;i < operarios.Length;i++) 
            {
                Console.Write("Ingrese el nombre de uno de los operarios:");
                operarios[i] = Console.ReadLine();
                Console.Write("Ingrese su sueldo:");
                string pago;
                pago = Console.ReadLine();
                sueldo[i]=float.Parse(pago);
            }
        }

        public void Mayorsueldo() 
        {
            float dinero;
            int array;
            dinero=sueldo[0];
            array=0;
            for(int z=1;z < operarios.Length;z++) 
            {
                if (sueldo[z] > dinero) 
                {
                    dinero=sueldo[z];
                    array=z;
                }
            }
            Console.WriteLine("EL operario con el sueldo mas alto es "+operarios[array]);
            Console.WriteLine("Su sueldo es de:"+dinero);
        }

        public void Main(string[] args)
        {
            Pregunta12 pv = new Pregunta12();
            pv.Cargar();
            pv.Mayorsueldo();
        }
    }
}