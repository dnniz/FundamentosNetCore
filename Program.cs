using System.Collections.Generic;
using Etapa1.Entidades;
using ETAPA1.Entidades;
using static System.Console;

namespace Etapa1
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("---Implementación de Lista Genérica y ejemplo de delegados con lambda---");

            var escuela = new Escuela("Tokio Room", 2019,
                tiposEscuela: TiposEscuela.Secundaria
            );
            var curso1 = new Curso()
            {
                Nombre = "BIO"
            };
            var curso2 = new Curso()
            {
                Nombre = "BOT"
            };
            escuela.lstCursos = new List<Curso>();
            escuela.lstCursos.Add(curso1);
            escuela.lstCursos.Add(curso2);

            escuela.lstCursos.RemoveAll((curso) => ( curso.Nombre == "BIO" && curso.Jornada == TiposJornada.Mañana));
            
            foreach (var item in escuela.lstCursos)
            {
                WriteLine(item.ToString());
            }


            WriteLine("---Uso de Colecciones Genéricas---");

            var cola = new Queue<string>();
            cola.Enqueue("1");
            cola.Enqueue("2");
            cola.Enqueue("3");
            cola.Enqueue("4");
            cola.Enqueue("5");

            // if (cola.Contains("4"))
            // {
            //     var ojeado = cola.Peek();
            //     var eliminado = cola.Dequeue();

            //     WriteLine($"Se ojeó de la cola el elemento: {ojeado}");
            //     WriteLine($"Se eliminó de la cola el elemento: {eliminado}");
            //     foreach (var item in cola)
            //     {
            //         WriteLine(item);
            //     }
            // }

            var conjuntoA = new HashSet<string>();
            conjuntoA.Add("Lima");
            conjuntoA.Add("Surco");
            conjuntoA.Add("Villa");
            
            var conjuntoB = new HashSet<string>();
            conjuntoB.Add("Villa");
            conjuntoB.Add("Rimac");
            conjuntoB.Add("San Isidro");

            var interseccion = new HashSet<string>(conjuntoA);
            interseccion.IntersectWith(conjuntoB);

            var exceptoB = new  HashSet<string>(conjuntoA);
            exceptoB.ExceptWith(conjuntoB);

            var exceptoA = new  HashSet<string>(conjuntoB);
            exceptoA.ExceptWith(conjuntoA);

            var union = new HashSet<string>(conjuntoA);
            union.UnionWith(conjuntoB);

            WriteLine("---Interseccion---");
            foreach (var item in interseccion)
            {
                WriteLine(item);
            }

            WriteLine("---Excepto B---");
            foreach (var item in exceptoB)
            {
                WriteLine(item);
            }

            WriteLine("---Excepto A---");
            foreach (var item in exceptoA)
            {
                WriteLine(item);
            }

            WriteLine("---Union---");
            foreach (var item in union)
            {
                WriteLine(item);
            }
        }
    }
}
