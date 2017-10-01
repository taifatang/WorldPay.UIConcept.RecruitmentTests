# WorldPay Merchant GenieU - prototype (recruitment tests)

[WorldPay's Genie Portal](http://worldpaygenie.azurewebsites.net/ "WorldPay's Genie Portal")

## Authorize Endpoint
Issue OAuth token on sign in, current behavior is hardcoded.
```
[HttpPost]
http://worldpaygenie.azurewebsites.net/api/genie/authorize
Content-Type: application/json
Body: 
{
    "secret": ""
}
```
## Get Profile Endpoint
To retrive the user's profile with a valid OAuth token
```
[HttpPost]
http://worldpaygenie.azurewebsites.net/api/genie/getprofile
Content-Type: application/json
Body: 
{
    "idToken": "",
    "accessToken": ""
}
```