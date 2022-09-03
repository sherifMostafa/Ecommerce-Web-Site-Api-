using System;

namespace API.Errors
{
    public class ApiResponse
    {

        public ApiResponse(int statusCode, string message = null)
        {
            StatusCode = statusCode;
            Message = message ?? GetDefaultMessageForStatusCode(statusCode);
        }

        private string GetDefaultMessageForStatusCode(int statsCode)
        {
            return StatusCode switch
            {
                400 => "A bad request, you hsve made",
                401 => "Authorized, you are not",
                404 => "Resource found, it was not",
                500 => "Errors are the path to the dark side. Errors lead to anger, anger leads to hate, Hate leads to career change",
                _=> null

            };

            throw new NotImplementedException();
        }

        public int StatusCode { get; set; }
        public string Message { get; set; }
    }
}
