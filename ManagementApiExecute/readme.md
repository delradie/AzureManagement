Azure Management API Executor

This is just a simple tool to allow for execution of Azure management API functions. The tooling takes care of authentication and adding of the bearer token to the request.

Where {subscriptionId} is included in the request URL this is replaced with the subscription ID entered in the options form.

The authentication options can be defaulted through the appsettings:

- DefaultSubscriptionId
- DefaultAadTenant
- DefaultClientId
- DefaultClientSecret
