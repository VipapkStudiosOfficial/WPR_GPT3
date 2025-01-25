using backend.Dtos.Voertuig;

public interface IVehicleService
{
    List<VoertuigDto> GetAllVehicles();
    List<VoertuigDto> FilterVehicles(VoertuigFilterDto filter);
    byte[] ExportVehicles(string format);
}
