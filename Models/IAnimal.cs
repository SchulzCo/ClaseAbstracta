namespace ClaseAbstracta.Models
{
    public interface IAnimal
    {
        string Nombre { get; set; }
        int Edad { get; set; }
        string Dormir();
        string Comer();
        string Datos();
    }

}
