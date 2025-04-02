using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // comentario lsdkfjklsdjfgaskdfgaks


            // hola soy martin
            // vamo arriba peñarol

            //sdjfhksdjhfksdf

            // sdkfjsldkfsd
            List<Sucursal> Sucursales = new List<Sucursal>();

            Sucursal suc1 = new Sucursal();
            suc1.Id = 1;
            suc1.Name = "Melonnnnnnn" ;
            suc1.Poblacion = 20000;

            Sucursal suc2 = new Sucursal();
            suc2.Id = 2;
            suc2.Name = "Maldonado";
            suc2.Poblacion = 150000;

            Sucursal suc3 = new Sucursal();
            suc3.Id = 3;
            suc3.Name = "Salto";
            suc3.Poblacion = 80000;

            Sucursal suc4 = new Sucursal();
            suc4.Id = 4;
            suc4.Name = "San Carlos";
            suc4.Poblacion = 40000;
            Sucursales.Add(suc1);
            Sucursales.Add(suc2);
            Sucursales.Add(suc3);
            Sucursales.Add(suc4);

            Sucursales.OrderBy(x => x.Poblacion)
                 .Where(x => x.Poblacion > 50000)
                 .Where(x => x.Name == "Melo")
                 .Select(x => x.Poblacion).ToList()
                 .ForEach(x => Console.WriteLine(x));
                

            Console.ReadLine();

           
            
            //hola soy Fran inteno
            // mas comentarios
            Console.ReadLine();
        }
    }
}
