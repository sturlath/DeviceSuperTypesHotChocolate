using Serilog;

public class GraphQLErrorFilter : IErrorFilter
{
    public IError OnError(IError error)
    {
        Log.Error(error.Exception, "Exception occurred");

        if (error.Exception != null)
        {
            return error.WithMessage(error.Exception.Message);
        }
        else
        {
            return error.WithMessage(error.Message);
        }
    }
}