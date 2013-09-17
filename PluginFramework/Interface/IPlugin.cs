namespace PluginFramework.Interface
{
    public interface IPlugin
    {
        string Name { get; set; }

        void ShowUI();
    }
}
