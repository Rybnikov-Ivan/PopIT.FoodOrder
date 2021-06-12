using System.Net;

namespace popIT.FoodOrder.Core.Exceptions.Response
{
    public struct ExceptionResponse
    {
        public ExceptionResponse(string jsonResponse, HttpStatusCode statusCode)
        {
            JsonResponse = jsonResponse;
            StatusCode = statusCode;
        }

        public string JsonResponse { get; set; }
        public HttpStatusCode StatusCode { get; set; }
    }
}