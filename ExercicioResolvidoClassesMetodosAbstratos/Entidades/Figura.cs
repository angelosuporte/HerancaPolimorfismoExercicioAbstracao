using ExercicioResolvidoClassesMetodosAbstratos.Entidades.Enums;

namespace ExercicioResolvidoClassesMetodosAbstratos.Entidades
{
    abstract class Figura
    {
        public Cor Cor { get; set; }



        public Figura(Cor cor)
        {
            Cor = cor;
        }

        public abstract double Area();
    }
}
