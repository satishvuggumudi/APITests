using ApiServices.Models.Request;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiServices
{
    public class ApiRequestBody
    {
        /// <summary>Creates a post request json body.</summary>
        /// <param name="userId">The user identifier.</param>
        /// <returns>PostsRequestBody</returns>
        public PostsRequestBody CreateAPostRequestJsonBody(int userId)
        {
            var body = new PostsRequestBody
            {
                Title = Guid.NewGuid().ToString(),
                Body = Guid.NewGuid().ToString(),
                UserId = userId
            };
            return body;
        }
    }
}
