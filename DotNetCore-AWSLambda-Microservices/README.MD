 ## .NET Core AWS Lambda Microservices

ASP.NET core web api application can be published as on AWS Lambda as Serverless function. You get everything that regular .NET core application provides like controllers , models etc. Amazon API gateway proxy is integrated directly into .NET Core api routing system. 

Here you can publish Shopping and Users web api projects (available in this folder and each project represent seperate microservice) as AWS lambda function and configure behing AWS lambda API gateway.  

In both project you will see app.UsePathBase in startup.cs , and on the basis of this base path i am configuring the api Gatway. 
e.g. for shopping microservices project my base path is app.UsePathBase(new PathString("/shopping")) . Amazon api gateway URL wil be
http://apigatewayurl/shopping/{anything} , where {anything} is passed along the request as it is and .Net core routing system will resolve it. This way you can call multiple controllers can be resolved behind api gateway. 

### Prereq
AWS Toolkit for Visual Studio 2017 and 2019
Visual studio 2017

### AWS Lambda Functions

When you publish the projects you will have AWS lambda Functions Available to you that will be integrated behind api Gateway.

![AWS Lambda Functions](https://github.com/ImranMA/CodeSamples/blob/master/DotNetCore-AWSLambda-Microservices/AWSLambdaFunctions.JPG?raw=true)


### API Gateway 

Your API gateway will sit behind individual microserivces . Here Shopping and Users API resources are pointing to AWS lambda functions
that you have published in earlier step. /{proxy+} mean that you can pass any uri along the request. e.g. in your shopping api resource if you have multiple controllers in your projects http://url/shopping/api/controller1,  http://url/shopping/api/controller2 {proxy+} will make sure that any request after "shopping" is passed to asp.net core api routing system that will resolve the request to right controller. 

![Api Gateway](https://github.com/ImranMA/CodeSamples/blob/master/DotNetCore-AWSLambda-Microservices/APIGatewayImage.JPG)
