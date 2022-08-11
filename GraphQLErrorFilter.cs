using Serilog;

public class GraphQLErrorFilter : IErrorFilter
{
    public IError OnError(IError error)
    {
        Log.Error(error.Exception, "Exception occurred");

        return error.WithMessage(error!.Exception!.Message);
    }
}