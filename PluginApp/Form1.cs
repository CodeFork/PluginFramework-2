using PluginFramework.Interface;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PluginApp
{
    public partial class Form1 : Form
    {
        private Dictionary<string, IPlugin> pluginDictionary = new Dictionary<string, IPlugin>();

        public Form1()
        {
            InitializeComponent();

            this.Text = "Plugin App by Alexander Heinz - 2013";            
            this.SetClientSizeCore(420, 220);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var listbox = InitListBox();

            this.Controls.Add(listbox);

            LoadPlugins(listbox);
        }

        private ListBox InitListBox()
        {
            var listbox = new ListBox();
            listbox.Top = 10;
            listbox.Left = 10;
            listbox.Width = 400;
            listbox.Height = 200;

            listbox.DoubleClick += (obj, args) => pluginDictionary[(obj as ListBox).SelectedItem.ToString()].ShowUI();
            return listbox;
        }

        private void LoadPlugins(ListBox listbox)
        {
            var plugins = PluginFramework.PluginFramework.LoadAllPlugins();

            foreach (var plugin in plugins)
            {
                listbox.Items.Add(plugin.Name);
                pluginDictionary.Add(plugin.Name, plugin);
            }
        }
    }
}
