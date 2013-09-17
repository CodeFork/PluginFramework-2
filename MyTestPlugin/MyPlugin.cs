using PluginFramework.Interface;
using System.Drawing;
using System.Windows.Forms;

namespace MyTestPlugin
{
    public class MyPlugin : IPlugin
    {
        public MyPlugin()
        {
            this.Name = "A simple plugin";
        }

        public string Name { get; set; }

        public void ShowUI()
        {
            var form = InitForm();
            var button = InitButton(form);

            form.Controls.Add(button);

            form.Show();
        }

        private static Form InitForm()
        {
            var form = new Form();
            form.Text = "A simple plugin UI";
            form.ClientSize = new Size(400, 300);
            
            return form;
        }

        private static Button InitButton(Form form)
        {
            var button = new Button();
            button.Text = "Press Me!";
            button.Width = 200;
            button.Height = 22;
            button.Left = 100;
            button.Top = 139;

            button.Click += (sender, args) => MessageBox.Show("Hello Plugin!");
            return button;
        }
    }
}
