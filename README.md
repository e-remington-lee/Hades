# TODO

SQS -- how to test consumers locally? (postman??)
AWS secrets
DB connection
Load balancers


Couldn't get it to run on any other port other than 80 in a dockerfile, even after doing https://andrewlock.net/why-isnt-my-aspnetcore-app-in-docker-working/
# web

docker run -d -p 9090:80 hades

aws ecr create-repository --repository-name publish-code --region us-east-2

login to aws ecr
https://docs.aws.amazon.com/AmazonECR/latest/userguide/getting-started-cli.html



run this command to be able to push to aws ecr (on link above):
replace region
aws_account repo
KEEP aws username

aws ecr get-login-password --region us-east-1 | docker login --username AWS --password-stdin 455974732880.dkr.ecr.us-east-1.amazonaws.com
--this is getting your login for ECR and piping it into docker, so you can push your images to aws ecr repo

docker push 455974732880.dkr.ecr.us-east-1.amazonaws.com/hades:0.0.1


aws ecr create-repository --repository-name publish-code --region us-east-1

.NET 6.0 Empty Web Template

[![](https://raw.githubusercontent.com/ServiceStack/Assets/master/csharp-templates/web.png)](http://web.web-templates.io/)

> Browse [source code](https://github.com/NetCoreTemplates/web), view live demo [web.web-templates.io](http://web.web-templates.io) and install with [dotnet-new](https://docs.servicestack.net/dotnet-new):

    $ dotnet tool install -g x

    $ x new web ProjectName

