using System;
using TerytApi;
using TerytWsApi.Client;



TerytWs1Client client = new TerytWs1Client(TerytWs1Client.EndpointConfiguration.custom, TerytConfig.UslugaTeryt);
client.ClientCredentials.UserName.UserName = TerytConfig.LoginTeryt;
client.ClientCredentials.UserName.Password = TerytConfig.HasloTeryt;
var test = await client.PobierzListeWojewodztwAsync(DateTime.Now);

Console.WriteLine("Koniec");