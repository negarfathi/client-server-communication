using System.ServiceModel;

namespace WebService
{
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        string NumberToWords(int number);
    }
}