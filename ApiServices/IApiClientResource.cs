using System.Collections.Generic;
using System.Threading.Tasks;
using ApiServices.Models.Request;
using ApiServices.Models.Responce;
using Refit;

namespace ApiServices
{
    public interface IApiClientResource
    {
        /// <summary>Gets the albums response by album identifier asynchronous.</summary>
        /// <param name="albumId">The album identifier.</param>
        /// <returns>ApiResponse</returns>
        [Get("/albums/{albumId}")]
        Task<ApiResponse<AlbumsResponseBodyModel>> GetAlbumsResponseByAlbumIdAsync(int albumId);

        /// <summary>Gets the comments response by comments identifier asynchronous.</summary>
        /// <param name="commentsId">The comments identifier.</param>
        /// <returns>ApiResponse</returns>
        [Get("/comments/{commentsId}")]
        Task<ApiResponse<CommentsResponseBodyModel>> GetCommentsResponseByCommentsIdAsync(int commentsId);

        /// <summary>Gets the photos response by photo identifier asynchronous.</summary>
        /// <param name="photoId">The photo identifier.</param>
        /// <returns>ApiResponse</returns>
        [Get("/photos/{photoId}")]
        Task<ApiResponse<PhotosResponseBodyModel>> GetPhotosResponseByPhotoIdAsync(int photoId);

        /// <summary>
        /// Gets the posts response by post identifier asynchronous.
        /// </summary>
        /// <param name="postId">The post identifier.</param>
        /// <returns>ApiResponse</returns>
        [Get("/posts/{postId}")]
        Task<ApiResponse<PostsResponseBodyModel>> GetPostsResponseByPostIdAsync(int postId);

        /// <summary>
        /// Gets to dos response by todo identifier asynchronous.
        /// </summary>
        /// <param name="todoId">The todo identifier.</param>
        /// <returns>ApiResponse</returns>
        [Get("/todos/{todoId}")]
        Task<ApiResponse<ToDosResponseBodyModel>> GetToDosResponseByTodoIdAsync(int todoId);

        /// <summary>
        /// Gets the user response by user identifier asynchronous.
        /// </summary>
        /// <param name="userId">The user identifier.</param>
        /// <returns>ApiResponse</returns>
        [Get("/users/{userId}")]
        Task<ApiResponse<UsersResponseBodyModel>> GetUserResponseByUserIdAsync(int userId);

        /// <summary>
        /// Gets the list of album photos response by album identifier asynchronous.
        /// </summary>
        /// <param name="albumId">The album identifier.</param>
        /// <returns>ApiResponse</returns>
        [Get("/albums/{albumId}/Photos")]
        Task<ApiResponse<List<PhotosResponseBodyModel>>> GetListOfAlbumPhotosResponseByAlbumIdAsync(int albumId);

        /// <summary>
        /// Gets the list of post comments response by post identifier asynchronous.
        /// </summary>
        /// <param name="postId">The post identifier.</param>
        /// <returns>ApiResponse</returns>
        [Get("/posts/{postId}/comments")]
        Task<ApiResponse<List<CommentsResponseBodyModel>>> GetListOfPostCommentsResponseByPostIdAsync(int postId);

        /// <summary>
        /// Gets the list of user albums response by user identifier asynchronous.
        /// </summary>
        /// <param name="userId">The user identifier.</param>
        /// <returns>ApiResponse</returns>
        [Get("/users/{userId}/albums")]
        Task<ApiResponse<List<AlbumsResponseBodyModel>>> GetListOfUserAlbumsResponseByUserIdAsync(int userId);

        /// <summary>
        /// Gets the list of user todos response by user identifier asynchronous.
        /// </summary>
        /// <param name="userId">The user identifier.</param>
        /// <returns>ApiResponse</returns>
        [Get("/users/{userId}/todos")]
        Task<ApiResponse<List<ToDosResponseBodyModel>>> GetListOfUserTodosResponseByUserIdAsync(int userId);

        /// <summary>
        /// Gets the list of user posts response by user identifier asynchronous.
        /// </summary>
        /// <param name="userId">The user identifier.</param>
        /// <returns>ApiResponse</returns>
        [Get("/users/{userId}/posts")]
        Task<ApiResponse<List<PostsResponseBodyModel>>> GetListOfUserPostsResponseByUserIdAsync(int userId);

        /// <summary>
        /// Creates a new posts for a user by user identifier.
        /// </summary>
        /// <param name="requestBody">The request body.</param>
        /// <returns>ApiResponse</returns>
        [Post("/posts")]
        Task<ApiResponse<PostsResponseBodyModel>> CreateANewPostsForAUserByUserId([Body] PostsRequestBody requestBody);

    }
}
