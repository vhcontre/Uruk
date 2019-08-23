- Paso 1
<System>.Hosts.Web
<System>.Services.Http

Install-Package Microsoft.AspNet.WebApi -Version 5.2.7

<-!! Verificacion !!->

- Paso 2
<System>.Framework

Install-Package Microsoft.AspNet.Mvc -Version 5.2.3
System.Web (Assembly)

- Paso 3
<System>.UI.Process

System.Web (Assembly)
System.Configuration (Assembly)
Install-Package System.Net.Http.Formatting.Extension -Version 5.2.3

- Paso 4
<System>.Hosts.Web

Install-Package Swashbuckle -Version 5.6.0

- Paso 5
<System>.UI.Web
<add key="serviceUrl" value="http://localhost:55216/" />

- Paso 6
<System>.Framework

System.Runtime.Caching (Assembly)


Install-Package Microsoft.AspNet.Identity.EntityFramework -Version 2.2.1
Install-Package Microsoft.AspNet.Identity.Owin -Version 2.2.1
 <package id="Microsoft.Owin.Security.Google" version="3.0.1" targetFramework="net46" />