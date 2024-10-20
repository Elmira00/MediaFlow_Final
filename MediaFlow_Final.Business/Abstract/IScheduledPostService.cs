using MediaFlow_Final.Entities.Models;

namespace MediaFlow_Final.Business.Abstract
{
    public interface IScheduledPostService
    {
        Task<IEnumerable<ScheduledPost>> GetAllScheduledPostsAsync();
        Task<ScheduledPost> GetScheduledPostByIdAsync(int id);
        Task CreateScheduledPostAsync(ScheduledPost scheduledPost);
        Task UpdateScheduledPostAsync(ScheduledPost scheduledPost);
        Task DeleteScheduledPostAsync(int id);
    }
}
