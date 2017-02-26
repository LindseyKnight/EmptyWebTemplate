using StructureMap;

namespace HelloWorld.Web.Config
{
    public static class TypeConfig
    {
        public static IContainer RegisterTypes()
        {
            return new Container();
        }
    }
}