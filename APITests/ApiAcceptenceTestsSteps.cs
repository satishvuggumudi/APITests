using ApiServices;
using ApiServices.Models;
using ApiServices.Models.Request;
using NUnit.Framework;
using Refit;
using System.Net;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace APITests
{
   
     [Binding]
    public class ApiAcceptenceTestsSteps
    {
        private readonly IApiClientResource _apiClientResource;
        private IApiResponse<dynamic> _response;
        
        public ApiAcceptenceTestsSteps(IApiClientResource apiClientResource)
        {
            _apiClientResource = apiClientResource;
        }

        [When(@"I request Get a user resource by valid (.*)")]
        public async Task WhenIRequestGetAUserResourceByValidUserId(int userId)
        {
            _response = await _apiClientResource.GetUserResponseByUserIdAsync(userId);            
        }


        [When(@"I request Get a user posts resource by valid (.*)")]
        public async Task WhenIRequestGetAnUserPostsResourceByValid(int postId)
        {
            _response = await _apiClientResource.GetPostsResponseByPostIdAsync(postId);
        }

        [When(@"I request Get a user post Comments resource by valid (.*)")]
        public async Task WhenIRequestGetAnUserPostCommentsResourceByValid(int commentsId)
        {       
            _response = await _apiClientResource.GetCommentsResponseByCommentsIdAsync(commentsId);
        }

        [When(@"I request Get a user todos resource by valid (.*)")]
        public async Task WhenIRequestGetAnUserTodosResourceByValidTodosId(int todosId)
        {
            _response = await _apiClientResource.GetToDosResponseByTodoIdAsync(todosId);
        }

        [When(@"I request Get a user album resource by valid (.*)")]
        public async Task WhenIRequestGetAnUserAlbumResourceByValidAlbumId(int albumId)
        {
            _response = await _apiClientResource.GetAlbumsResponseByAlbumIdAsync(albumId);
        }

        [When(@"I request Get a user album photos resource by valid (.*)")]
        public async Task WhenIRequestGetAnUserAlbumPhotosResourceByValidPhotoId(int photoId)
        {
            _response = await _apiClientResource.GetPhotosResponseByPhotoIdAsync(photoId);
        }

        [When(@"I request Get list of comments associated to a post by (.*)")]
        public async Task WhenIRequestGetListOfCommentsAssociatedToAPostByPostId(int postId)
        {
            _response = await _apiClientResource.GetListOfPostCommentsResponseByPostIdAsync(postId);
        }

        [When(@"I request Get list of photos associated to a album by (.*)")]
        public async Task WhenIRequestGetListOfPhotosAssociatedToAAlbumByPhotoId(int albumId)
        {
            _response = await _apiClientResource.GetListOfAlbumPhotosResponseByAlbumIdAsync(albumId);
        }

        [When(@"I request Get list of albums associated to a user by (.*)")]
        public async Task WhenIRequestGetListOfAlbumsassociatedToAUserByUserId(int userId)
        {
            _response = await _apiClientResource.GetListOfUserAlbumsResponseByUserIdAsync(userId);
        }

        [When(@"I request Get list of todos associated to a user by (.*)")]
        public async Task WhenIRequestGetListOfTodosAssociatedToAUserByUserId(int userId)
        {
            _response = await _apiClientResource.GetListOfUserTodosResponseByUserIdAsync(userId);
        }

        [When(@"I request Get list of posts associated to a user by (.*)")]
        public async Task WhenIRequestGetListOfPostsAssociatedToAUserByUserId(int userId)
        {
            _response = await _apiClientResource.GetListOfUserPostsResponseByUserIdAsync(userId);
        }

        [When(@"I create apost for a user (.*)")]
        public async Task WhenICreateApostForAUser(int userId)
        {
            var requestBody = new ApiRequestBody().CreateAPostRequestJsonBody(userId);
            _response = await _apiClientResource.CreateANewPostsForAUserByUserId(requestBody);
        }

        [Then(@"I receive valid HTTP Success response status code")]
        public void ThenIReceiveValidHTTPSuccessResponseStatusCode()
        {
            Assert.That(_response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Then(@"I receive failure response code")]
        public void ThenIReceiveFailureResponseCode()
        {
            Assert.That(_response.StatusCode, Is.EqualTo(HttpStatusCode.NotFound));
        }

        [Then(@"I receive valid HTTP Success response Created")]
        public void ThenIReceiveValidHTTPSuccessResponseCreated()
        {
            Assert.That(_response.StatusCode, Is.EqualTo(HttpStatusCode.Created));
        }

        [Then(@"Response Body is non-empty")]
        public void ThenResponseBodyIsNon_EmptyAsync()
        {
            Assert.That(_response.Content, Is.Not.Null);
        }
    }
}
