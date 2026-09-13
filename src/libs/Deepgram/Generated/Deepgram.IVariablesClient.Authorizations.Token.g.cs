
#nullable enable

namespace Deepgram
{
    public partial interface IVariablesClient
    {
        /// <summary>
        /// Authorize using Token authentication.
        /// </summary>
        /// <param name="apiKey"></param>

        public void AuthorizeUsingToken(
            string apiKey);
    }
}