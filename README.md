# Coverlet Issue Reproduction

This repository contains the necessary projects in order to reproduce an issue that causes no coverage data on VB projects.

This uses the coverlet.msbuild package version 3.0.3.

## Steps to Reproduce
Having compiled the project in Debug configuration
- Open a command prompt
- Navigate to the repository root
- Run the following command
```
dotnet test .\Tests\Tests.csproj --configuration Debug --no-restore --no-build /p:CollectCoverage=true /p:CoverletOutputFormat=cobertura
```

**Expected**
The resulting report shows coverage on both vb and c# projects

**Actual**
The report only contains the c# project despite running the tests for both projects

```
+-------------------------------+------+--------+--------+
| Module                        | Line | Branch | Method |
+-------------------------------+------+--------+--------+
| NetFrameworkCsPortableLibrary | 100% | 100%   | 100%   |
+-------------------------------+------+--------+--------+

+---------+------+--------+--------+
|         | Line | Branch | Method |
+---------+------+--------+--------+
| Total   | 100% | 100%   | 100%   |
+---------+------+--------+--------+
| Average | 100% | 100%   | 100%   |
+---------+------+--------+--------+

```