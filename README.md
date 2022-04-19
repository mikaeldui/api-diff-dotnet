# .NET API Diff Action
A GitHub Action checking differences in a public .NET API.

If you have a NuGet packages that's being built using a schedule and only want it to be deployed if there's a diff in the public API then this action will let you compare the built package against the latest published NuGet package.
