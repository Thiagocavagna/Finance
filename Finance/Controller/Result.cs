namespace Finance.Controller
{
    public class Result
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public bool HasMessage => !string.IsNullOrWhiteSpace(Message);

        public Result(bool success, string message)
        {
            Success = success;
            Message = message;
        }
    }
}
