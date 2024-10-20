using MediaFlow_Final.Entities.Models;

namespace MediaFlow_Final.Business.Abstract
{
    public interface IContentPostService
    {
        Task<IEnumerable<ContentPost>> GetAllPostsAsync();
        Task<ContentPost> GetPostByIdAsync(int id);
        Task CreatePostAsync(ContentPost post);
        Task UpdatePostAsync(ContentPost post);
        Task DeletePostAsync(int id);
    }
}
