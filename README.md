# AzureManagement
Sample code for working with Azure Management APIs

# Purpose of this project
To show how to hook up to the management interface for Azure API Management via c#.

Whilst the actual API Management control RESTful API is very well documented by Microsoft at https://docs.microsoft.com/en-us/rest/api/apimanagement/ the documentation out on the web only covers the original authentication methods using SharedAccessSignature doesn't work with the C# interface in the Microsoft.Azure.Management.ApiManagement Nuget

This code uses Azure Active Direcory App registration to get a bearer token that can then be used when accessing the management services

More extensive documentation will be provided shortly, but in the meantime if you have any questions ping me on twitter [@delradie](https://twitter.com/delradie) or via http://delradiesdev.blogspot.co.uk/
