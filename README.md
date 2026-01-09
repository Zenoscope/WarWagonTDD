
TDD scripting <br>
https://blog.coscreen.co/blog/tdd-in-c-guide/ <br>
<br>

testing: <br>
https://sentry.io/signup/?original_referrer=https%3A%2F%2Fblog.sentry.io%2F <br>
<br>

dotnet setup: <br>
install pulsar ide <br>
install dotnet - sudo apt instal dotnet-sdk-<version> <br>
<br>

then setting up a test environment: <br>
Solution for to organise tests and codes <br> 
dotnet new sln -o MySolution <br>
<br>

create application: <br>
dotnet new classlib -o MyProject <br>
<br>

add a test frmework (Nunit, xunit etc) <br>
dotnet new nunit -o MyProject.Tests <br>
<br>

link it all together: <br>
<br>

dotnet sln MySolution add MyProject/MyProject.csproj <br>
dotnet sln MySolution add MyProject.Tests/MyProject.Tests.csproj <br>
dotnet add MyProject.Tests/MyProject.Tests.csproj reference MyProject/MyProject.csproj  <br>

tests go in the test directory, code in the project directory. <br>

list tests with: <br>
dotnet test MySolution/  -t <br>

run tests with:

dotnet MySolution/ <br>
