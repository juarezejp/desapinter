namespace _16.interfaces.Clases
{
    public interface ICaja{
        string Color { get; set; }
        bool EstaAbierta{get; set;}
        string Contenido{get; set;}
        void Abrir();
        void Cerrar();
    }
}
