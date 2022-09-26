using Furion.DynamicApiController;

namespace _01WebApiFurion
{
    public class TestServices :IDynamicApiController
    {
        public string SayHello(string name)
        {
            return $"Hello {name}";
        }

        public List<string> GetName()
        {
            return new List<string>()
            {
                "Name1",
                "Name2",
                "Name3"
            };
        }
    }
}
