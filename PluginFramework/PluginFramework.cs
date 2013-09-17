using PluginFramework.Interface;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace PluginFramework
{
    public class PluginFramework
    {
        public static IEnumerable<IPlugin> LoadAllPlugins()
        {
            var connectionString = @"data source=(localdb)\v11.0;initial catalog=Plugins;Integrated Security=true";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                var command = new SqlCommand("SELECT Path, TypeName FROM Plugin", connection);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        yield return new PluginConfiguration(reader[0].ToString(), reader[1].ToString()).LoadPlugin();
                    }
                }
            }
        }
    }
}