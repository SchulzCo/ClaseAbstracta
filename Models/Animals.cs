namespace ClaseAbstracta.Models
{
    public class Perro : Animal
    {
        public override string HacerRuido => throw new NotImplementedException();

        public override string Dormir()
        {
            return $"{Nombre} duerme en su cama.";
        }

        public override string Comer()
        {
            return $"{Nombre} come croquetas.";
        }

       
    }

    public class Gato : Animal
    {
        public override string HacerRuido => throw new NotImplementedException();

        public override string Dormir()
        {
            return $"{Nombre} duerme en el sofá.";
        }

        public override string Comer()
        {
            return $"{Nombre} come atún.";
        }

        
    }




}
