using System.Net.Http.Headers;

namespace WebPatrones.BuilderPattern
{
    public interface IBuilder
    {
        void StartUpOperations();
        void BuildBody();
        void InsertWheels();
        void AddHeadLights();
        void EndOpererations();
        Product GetVehicle();
    }
}