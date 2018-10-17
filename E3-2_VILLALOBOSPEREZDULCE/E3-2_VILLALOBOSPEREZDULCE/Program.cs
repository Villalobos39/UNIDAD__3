using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace E3_2_VILLALOBOSPEREZDULCE
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue cola = new Queue();//SE CREA EL OBJETO DE QUEUE (COLA)
            Console.WriteLine("\n\t>>CONTENIDOS AÑADIR (Enqueue) <<\n");
            cola.Enqueue("\tDICIEMBRE");//AGREGA ELEMENTOS A LA COLA (QUEUE) , CON EL Enqueue
            cola.Enqueue("\tNOVIEMBRE");
            cola.Enqueue("\tOCTUBRE");
            cola.Enqueue("\tINVIERNO");
            cola.Enqueue("\tOTOÑO");
            cola.Enqueue("\tNIEVE");
            cola.Enqueue("\tLLUVIA");
            foreach (var descripcion in cola)
            {
                Console.WriteLine(descripcion); //MOSTAR LOS ELEMENTOS DE LA QUEUE
            }

            Console.Write("\n\tELEMENTOS DE LA QUEUE :" + cola.Count);
            //COUNT CUENTA LA CANTIDAD DE ELEMNTOS
            Console.WriteLine("\n\tELEMENTO A QUITAR (Dequeue): " + cola.Dequeue());
            //Dequeue QUITA O ELELIMINA ELEMNTOS DE LA COLA 
            Console.WriteLine("\n\tULTIMO ELEMENTO ACTUALMENTE : " + cola.Peek());
            //Peek MUESTRA EL PROXIMO ELEMENTO ESTE METODO TAMIEN ES UTILIZADO EN STACK
            Console.WriteLine("\n\tELEMENTOS TOTAL DE LA QUEUE : " + cola.Count);
            Console.WriteLine("\n\tELEMTOS QUITADOS (Dequeue)");
            cola.Dequeue();
            cola.Dequeue();
            Console.WriteLine("\n\tELEMENTOS TOTAL DE LA QUEUE : " + cola.Count);
            cola.TrimToSize(); // ESTABLECE LA CAPACIDAD DE QUEUE 

            Queue<int> Cola = new Queue<int>(); // QUEUE < TIPO DE DATO >
            //AGREGA ELEMENTOS A LA COLA (QUEUE) CON UN TIPO DE DATO PREDETERMINADO;
            Cola.Enqueue(3);
            Cola.Enqueue(9);
            Cola.TrimExcess();
            Console.WriteLine("\n\tCONTENIDOS NUEVOS (Enqueue) Y COPIADOS:");
            // IMPRIMO LOS ELEMENTOS COPIADOS ADEMAS DE QUE ESTE METODO TAMBIEN SE HACEN EN STACK.
            foreach (var caracter in Cola)
            {
                Console.WriteLine("\t" + caracter);
            }
            Console.Write("\n\tSE ENCUENTRA LA PALABRA INVIRNO :  " + Cola.Contains(3));
            //EL METODO Contains ES EL QUE REGRESA UN TRUE O FALSE SI UN ELEMENTO ESTA EN LA COLA TAMBIEN EN STACK
            Console.WriteLine("\n\tELEMENTOS TOTAL DE LA QUEUE : " + (Cola.Count + cola.Count));
            Console.Write("\n\t" + Cola.Equals(33));
            Console.ReadKey();

            /* EN CONCLUSION : 
                 * LOS METODOS :   PUSH Y ENQUEUE REPRESENTAN EL AÑADIR ELEMENTOS 
                 * LOS METODOS :   POPO Y DEQUEUE REPRESENTAN EL QUITAR Y ELIMINAR ELEMENTOS 
                 * EN SI EL METODO PEEK TIENE LA MISMA SINTAXIS Y ES PARA MOSTRAR LOS ELEMENTOS 
                 * Y CLEAR (),  CONTANINS (T) , CopyTo, ToArray (),Esquals (), trimExcess 
                 * STIENEN LA MISMA FUNCION PARA COLAS(QUEUE) Y PILAS (STACK)  */

        }
    }
}
