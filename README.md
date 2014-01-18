Asp.Net MVC 4 Templates For Mono
================================

Asp.Net MVC4 projects for .Net 4.0 and .Net 4.5, which build and run on Mono.

The 2 basic templates, Mvc4CSharpRazorFx40Intranet and Mvc4CSharpRazorFx45Intranet, should run out-of-the-box EXCEPT for the one thing noted below for which you must choose one of the 2 fixes.
Although they are NuGet-enabled, all the required dlls are in the repo. They are most recently tested 
in Xamarin Studio on Mac OS X running Mono 3.2.5, but the .Net 4.0 template ran on Mono 2.8.

They were created from the Visual Studio MVC4 Intranet templates, VS2010 for the 4.0 template, & VS2012 for the 4.5 template.

Gotchas
========
There's one gotcha. You must EITHER run these commands:

    sudo mkdir /Library/Frameworks/Mono.framework/Versions/3.2.5/etc/mono/registry
    sudo chmod g+rwx /Library/Frameworks/Mono.framework/Versions/3.2.5/etc/mono/registry
    
OR, you must delete `Microsoft.Web.Infrastructure.dll` from the project references AND from the `bin` directory. If you choose to delete, then the project will only run on Mono and not on IIS.

Full Notes
==========
http://www.cafe-encounter.net/p1510/asp-net-mvc4-net-framework-version-4-5-c-razor-template-for-mono-on-mac-and-linux
