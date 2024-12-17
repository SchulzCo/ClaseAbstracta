using Microsoft.AspNetCore.Mvc;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ClaseAbstracta.Models
{
    public abstract class Animal : IAnimal
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public abstract string Dormir();
        public abstract string Comer();
        public abstract string HacerRuido { get; }

        public string Datos()
        {
            return $"Nombre: {Nombre}, Edad: {Edad}";
        }
    }
}