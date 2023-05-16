// See https://aka.ms/new-console-template for more information
using System;

var secret = "DefaultEndpointsProtocol=https;AccountName=scusonlinefuncsa;AccountKey=zUGzjIZRwSYU03HgPLphNBH/LBEa1WqEtFaxZasP2P36FlmqWrF+YeZXaI4zmyXjlRMFEgGbezmkH56zg2T99Q==;EndpointSuffix=core.windows.net";
var secret1 = "DefaultEndpointsProtocol=https;AccountName=scusonlinefuncsa;AccountKey=zUGzjIZRwSYU03HgPLphNBH/LBEa1WqEtFaxZasP2P36FlmqWrF+YeZXaI4zmyXjlRMFEgGbezmkH56zg2T99Q==;EndpointSuffix=core.windows.net";
var secret2 = "DefaultEndpointsProtocol=https;AccountName=testlinefuncsa;AccountKey=zUUUIZRwSYU03HgPLphNBH/LBEa1WqEtFaxZasP2P36FlmqWrF+YeZXaI4zmyXjlRMFEgGbezmkH56zg2T99Q==;EndpointSuffix=core.windows.net";
Console.WriteLine($"Hello {secret}");
var result = GetDivision(1);

int GetDivision(int denominator)
{
    try
    {
        return 1 / denominator;
    }
    catch
    {
        return 0;
    }
}