using AdventureLogAPI.Models;

namespace AdventureLogAPI.Service.Interfaces
{
    public interface ICampaignService
    {
        public bool AddCampaign(Campaign campaign);

        public bool RemoveCampaign(int id);

        public bool AddCampaigns(IEnumerable<Campaign> campaigns);

        public bool RemoveCampaigns(IEnumerable<Campaign> campaigns);

        public Campaign? GetCampaign(int id);

        public IEnumerable<Campaign> GetCampaigns();

        public bool UpdateCampaign(Campaign campaign);

        public bool CampaignExists(int id);
    }
}
