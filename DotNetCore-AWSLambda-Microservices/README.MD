 ## AWS Lambda Microservices

ASP.NET core can be published as complete API project on AWS Lambda Serverless function. Amazon API gateway proxy is directly integrated
into .NET Core api routing out of box. So individual .NET core API can work as your micrservice that can be configured behind Amazon API 
gateway. 

You can publish Shopping and Users projects as individual microserivces AWS lambda functions and configure behing AWS lambda API gateway.  

# API Gateway 

Your API gateway will integrate individual microserivces . Here Shopping and Users is your .NET core microsevrices projects this
gateway will direct to.

![Api Gateway](https://github.com/ImranMA/CodeSamples/blob/master/DotNetCore-AWSLambda-Microservices/APIGatewayImage.JPG)
