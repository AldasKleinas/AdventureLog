using AdventureLogAPI.Models;

namespace AdventureLogAPI.Service.Implementation
{
    public class CampaignService
    {
        private readonly AdventureLogContext _dbContext;

        public CampaignService(AdventureLogContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool AddCampaign(Campaign campaign)
        {
            _dbContext.Campaigns.Add(campaign);
            return Save();
        }

        public bool RemoveCampaign(int id)
        {
            Campaign? campaign = _dbContext.Campaigns.Find(id);
            if (campaign != null)
            {
                _dbContext.Campaigns.Remove(campaign);
                return Save();
            }
            return false;
        }

        public bool AddCampaigns(IEnumerable<Campaign> campaigns)
        {
            foreach (Campaign campaign in campaigns)
            {
                _dbContext.Campaigns.Add(campaign);
            }
            return Save();
        }

        public bool RemoveCampaigns(IEnumerable<Campaign> campaigns)
        {
            foreach (Campaign campaign in campaigns)
            {
                _dbContext.Campaigns.Remove(campaign);
            }
            return Save();
        }

        public Campaign? GetCampaign(int id)
        {
            if (CampaignExists(id) == true)
            {
                return _dbContext.Campaigns.Find(id);
            }
            return null;
        }

        public IEnumerable<Campaign> GetCampaigns()
        {
            return _dbContext.Campaigns.ToList();
        }

        public bool Save()
        {
            var saved = _dbContext.SaveChanges();
            return saved > 0;
        }

        public bool UpdateCampaign(Campaign campaign)
        {
            _dbContext.Campaigns.Update(campaign);

            return Save();
        }

        public bool CampaignExists(int id)
        {
            return _dbContext.Campaigns.Any(m => m.Id == id);
        }
    }
}
