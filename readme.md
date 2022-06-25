## Built using .NET webapi template


## Steps to create

- dotnet new webapi
- dotnet gitignore


[localhost Swagger API Docs](https://localhost:7064/Swagger/index.html)


## Steps to deploy on heroku through CircleCi

- Create New Heroku App
- Go to setting -> add Buildpack -> Add this url because heroku officially not support .NET -> https://github.com/jincod/dotnetcore-buildpackttach Circle CI and save it somewhere, we'll use it later in circleCI 

## Steps to add Circle CI 

- At project root create folder .circleci and in that create file config.yml