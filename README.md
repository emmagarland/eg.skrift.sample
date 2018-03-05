# eg.skrift.sample
## Sample code for Skrift Article March 2018 ##
### *SOLID CMS: SOLID Principles in CMS Development* ###

This solution includes a default Umbraco install with the example code as described in the Skrift article

### Summary ###

The code is used to provide examples for following **SOLID** principles in CMS development, based on Umbraco as an example.

### Architecture ###

The solution is composed of 4 projects:

- eg.skrift.web
- eg.skrift.data
- eg.skrift.businesslogic
- eg.skrift.businesslogic.tests

Umbraco is only referenced from the web and data projects. The business logic project should have no knowledge of Umbraco, only getting its dependencies via **Dependency Injection**.

### Dependencies ###

- The unit tests use [Nunit](http://nunit.org/)
- The solution uses [AutoFac](https://autofac.org/) as the **DI Container**
- [ModelsBuilder](https://our.umbraco.org/documentation/reference/templating/modelsbuilder/) is used via the API and in the separate eg.skrift.data project
- [UmbracoCms.Core](https://www.nuget.org/packages/UmbracoCms.Core/) and [Terratype](https://our.umbraco.org/projects/backoffice-extensions/terratype/) are explicitly installed in the eg.skrift.data project
- [UmbracoCms](https://www.nuget.org/packages/UmbracoCms) is installed in the web project

Rebuild all and all the required nuget packages will be installed. 

### Umbraco Login Details###

- Username: emmagarland77+77@gmail.com
- Password: E&6^hM3d@:
