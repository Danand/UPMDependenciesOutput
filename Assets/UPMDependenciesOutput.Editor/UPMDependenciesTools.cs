using System.Text;
using System.Threading.Tasks;

using UnityEditor;
using UnityEditor.PackageManager;

using UnityEngine;

namespace UPMDependenciesOutput.Editor
{
    public static class UPMDependenciesTools
    {
        [MenuItem("Window/Package Manager/Print all dependencies")]
        public static async void PrintAllDependencies()
        {
            var request = Client.List();

            while (!request.IsCompleted)
            {
                await Task.Yield();
            }

            var collection = request.Result;
            var stringBuilder = new StringBuilder();

            foreach (var item in collection)
            {
                stringBuilder.AppendLine($"{item.name}@{item.version}");

                foreach (var dependency in item.dependencies)
                {
                    stringBuilder.AppendLine($"---- {dependency.name}@{dependency.version}");
                }
            }

            Debug.Log(stringBuilder);
        }
    }
}
