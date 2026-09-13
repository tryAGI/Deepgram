
#nullable enable

namespace Deepgram
{
    public partial interface ITextClient
    {
        /// <summary>
        /// Authorize using Token authentication.
        /// </summary>
        /// <param name="apiKey"></param>

        public void AuthorizeUsingToken(
            string apiKey);
    }
}