using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace InsaManageMentSystem
{
    public class DllProvider
    {
        private string Url(string fileName) => $"{Environment.CurrentDirectory}/SystemTasks/{fileName}.dll";
        public UserControl GetDllUserControls(string fileName)
        {
            MessageBox.Show(Url(fileName));

            byte[] dllFileBytes = File.ReadAllBytes(Url(fileName));
            Assembly assembly = Assembly.Load(dllFileBytes);
            return (UserControl)assembly.CreateInstance($"{fileName}.{fileName}");
        }
    }
}
