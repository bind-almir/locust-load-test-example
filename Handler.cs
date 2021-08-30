using Amazon.Lambda.Core;
using Amazon.Lambda.APIGatewayEvents;

[assembly:LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]
namespace AwsDotnetCsharp
{
    public class Request
    {
      public string Key1 {get; set;}
      public string Key2 {get; set;}
      public string Key3 {get; set;}
    }
    
    public class Handler
    {

      private APIGatewayProxyResponse ResponseLambda(int statusCode, string body)
      {
        return new APIGatewayProxyResponse
        {
          StatusCode = statusCode,
          Body = body
        };
      }

       public APIGatewayProxyResponse Hello(Request request)
       {
          return ResponseLambda(200, "{message: TEST RUN!}");
       }
    }

}
