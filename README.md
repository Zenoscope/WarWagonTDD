
TDD scripting
https://blog.coscreen.co/blog/tdd-in-c-guide/

testing:
https://sentry.io/signup/?original_referrer=https%3A%2F%2Fblog.sentry.io%2F

dotnet setup:
install pulsar ide
install dotnet - sudo apt instal dotnet-sdk-<version>

then setting up a test environment:
Solution for to organise tests and codes 
dotnet new sln -o MySolution

create application:
dotnet new classlib -o MyProject

create a test frmework (Nunit, xunit etc)
dotnet new nunit -o MyProject.Tests

link it all together:

dotnet sln MySolution add MyProject/MyProject.csproj
dotnet sln MySolution add MyProject.Tests/MyProject.Tests.csproj
dotnet add MyProject.Tests/MyProject.Tests.csproj reference MyProject/MyProject.csproj 
