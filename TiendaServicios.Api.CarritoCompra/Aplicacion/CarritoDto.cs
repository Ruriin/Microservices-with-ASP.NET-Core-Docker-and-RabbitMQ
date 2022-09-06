namespace TiendaServicios.Api.CarritoCompra.Aplicacion
{
    public class CarritoDto
    {
        //Comunicacion entre microservicios
        public int CarritoId { get; set; }
        public DateTime? FechaCreacionSesion { get; set; }
        public List<CarritoDetalleDto> ListaProductos { get; set; }
    }
}
