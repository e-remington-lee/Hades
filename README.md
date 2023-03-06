# TODO

SQS
AWS secrets
DB connection
Load balancers


Couldn't get it to run on any other port other than 80 in a dockerfile, even after doing https://andrewlock.net/why-isnt-my-aspnetcore-app-in-docker-working/
# web

.NET 6.0 Empty Web Template

[![](https://raw.githubusercontent.com/ServiceStack/Assets/master/csharp-templates/web.png)](http://web.web-templates.io/)

> Browse [source code](https://github.com/NetCoreTemplates/web), view live demo [web.web-templates.io](http://web.web-templates.io) and install with [dotnet-new](https://docs.servicestack.net/dotnet-new):

    $ dotnet tool install -g x

    $ x new web ProjectName

Alternatively write new project files directly into an empty repository, using the Directory Name as the ProjectName:

    $ git clone https://github.com/<User>/<ProjectName>.git
    $ cd <ProjectName>
    $ x new web
