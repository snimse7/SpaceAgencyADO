using SpaceAgencyado.DAO;
using SpaceAgencyado.Model;

namespace SpaceAgencyado.Interface
{
    public interface IAgencyDA
    {
        List<Agencies> GetAgencies();
        List<Agencies> GetAgenciesById(int id);
        void AddAgency(Agencies agency);
        void UpdateAgency(Agencies agency);
        void DeleteAgency(int id);
        List<countries> GetCountries();
        List<space_station> GetSp(string nm);
        List<MissionInfo> GetSpaceMission();

    }
}
