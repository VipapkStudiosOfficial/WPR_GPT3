using backend.Dtos.Voertuig;

public interface IVehicleService
{
    List<VoertuigDto> GetAllVehicles();
    List<VoertuigDto> FilterVehicles(VoertuigDto filter);
    byte[] ExportVehicles(string format);
}
