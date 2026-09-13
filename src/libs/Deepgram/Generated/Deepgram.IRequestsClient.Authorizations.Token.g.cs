
#nullable enable

namespace Deepgram
{
    public partial interface IRequestsClient
    {
        /// <summary>
        /// Authorize using Token authentication.
        /// </summary>
        /// <param name="apiKey"></param>

        public void AuthorizeUsingToken(
            string apiKey);
    }
}