namespace TiendaServicios.Api.CarritoCompra.Aplicacion
{
    public class CarritoDetalleDto
    {
        //Comunicacion entre microservicios
        public Guid LibroId { get; set; }
        public string TituloLibro { get; set; }
        public string AutorLibro { get; set; }
        public DateTime? FechaPublicacion { get; set; }
    }
}
