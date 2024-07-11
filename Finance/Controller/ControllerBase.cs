namespace Finance.Controller
{

    public class ControllerBase
    {
        protected Result Unsuccessful(string message)
            => new Result(false, message);

        protected Result Successful(string message)
            => new Result(true, message);

    }
}
