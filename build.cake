#tool nuget:?package=NUnit.ConsoleRunner&version=3.4.0
var target = Argument("target", "Default");
var configuration = Argument("configuration", "Release");
var solution = "./src/FilmWishlist.sln";

Task("Clean")
    .Does(() =>
{
    CleanDirectories("./src/**/bin/");
});

Task("Restore-NuGet-Packages")
    .IsDependentOn("Clean")
    .Does(() =>
{
    NuGetRestore(solution);
});

Task("Build")
    .IsDependentOn("Restore-NuGet-Packages")
    .Does(() =>
{
    MSBuild(solution, settings =>
        settings.SetConfiguration(configuration));
});

Task("Run-Tests")
    .IsDependentOn("Build")
    .Does(() =>
{
    NUnit3("./src/**/bin/" + configuration + "/*Tests.dll", new NUnit3Settings { NoResults = false });
});

Task("Default")
    .IsDependentOn("Run-Tests");

RunTarget(target);