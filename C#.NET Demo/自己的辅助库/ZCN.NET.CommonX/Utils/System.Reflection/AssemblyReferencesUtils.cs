using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace ZCN.NET.CommonX.Utils
{
    /// <summary>
    ///     自定义类：用于发现同一依赖程序集的不同版本之间存在冲突的警告
    /// </summary>
    public class AssemblyReferencesUtils
    {
        /// <summary>
        ///     查找指定目录下程序集之间的引用冲突。如果没有冲突，则返回空字符串；如果有冲入，则返回冲突的具体信息。
        /// </summary>
        /// <param name="path">指定的目录</param>
        /// <returns></returns>
        public string FindConflictingReferences(string path)
        {
            //var assemblies = GetAllAssemblies(path);
            //var references = GetReferencesFromAllAssemblies(assemblies);
            //var groupsOfConflicts = FindReferencesWithTheSameShortNameButDifferentFullNames(references);
            //foreach (var group in groupsOfConflicts)
            //{
            //    Debug.Write(string.Format("可能的冲突 {0}:\r\n", group.Key));
            //    foreach (var reference in group)
            //    {
            //        Debug.Write(string.Format("- {0} 引用 {1}\r\n",
            //                                  reference.Assembly.Name.PadRight(35),
            //                                  reference.ReferencedAssembly.FullName));
            //    }
            //}

            StringBuilder sb = new StringBuilder();
            var assemblies = GetAllAssemblies(path);
            var references = GetReferencesFromAllAssemblies(assemblies);
            var groupsOfConflicts = FindReferencesWithTheSameShortNameButDifferentFullNames(references);
            foreach (var group in groupsOfConflicts)
            {
                sb.AppendFormat("可能的冲突 {0}:", group.Key);
                foreach (var reference in group)
                {
                    sb.AppendFormat("- {0} 引用 {1}",
                                    reference.Assembly.Name,
                                    reference.ReferencedAssembly.FullName);
                }

                sb.AppendLine("");//换行
            }

            return sb.ToString();
        }

        /// <summary>
        ///     查找指定目录下的所有 .dll 与 .exe 的程序集集合
        /// </summary>
        /// <param name="path">指定的目录</param>
        /// <returns></returns>
        private List<Assembly> GetAllAssemblies(string path)
        {
            var ret = new List<Assembly>();
            var files = new List<FileInfo>();
            var directoryToSearch = new DirectoryInfo(path);
            files.AddRange(directoryToSearch.GetFiles("*.dll", SearchOption.AllDirectories));
            files.AddRange(directoryToSearch.GetFiles("*.exe", SearchOption.AllDirectories));
            foreach (var file in files)
            {
                try
                {
                    ret.Add(Assembly.LoadFile(file.FullName));
                }
                catch (System.Exception ex)
                {
                    Debug.Write(ex.Message);
                }
            }

            return ret;
        }

        /// <summary>
        ///     从指定的程序集集合中查找引用的所有程序集，返回 <see cref="T:SparkSoft.Platform.Common.Utility.Reference" /> 对象集合
        /// </summary>
        /// <param name="assemblies"></param>
        /// <returns></returns>
        private List<Reference> GetReferencesFromAllAssemblies(List<Assembly> assemblies)
        {
            var references = new List<Reference>();
            foreach (var assembly in assemblies)
            {
                AssemblyName[] referencedAssemblies = assembly.GetReferencedAssemblies(); //获取此程序集引用的所有程序集的 <see cref="T:System.Reflection.AssemblyName" /> 对象
                foreach (var referencedAssembly in referencedAssemblies)
                {
                    references.Add(new Reference
                    {
                        Assembly = assembly.GetName(),
                        ReferencedAssembly = referencedAssembly
                    });
                }
            }

            return references;
        }

        /// <summary>
        ///     从指定的集合中查找短名称相同但全名不同的引用
        /// </summary>
        /// <param name="references"></param>
        /// <returns></returns>
        private IEnumerable<IGrouping<string, Reference>> FindReferencesWithTheSameShortNameButDifferentFullNames(List<Reference> references)
        {
            return from reference in references
                   group reference by reference.ReferencedAssembly.Name into referenceGroup
                   where referenceGroup.ToList()
                                       .Select(reference => reference.ReferencedAssembly.FullName)
                                       .Distinct()
                                       .Count() > 1
                   select referenceGroup;
        }
    }

    /// <summary>
    ///  引用集合类
    /// </summary>
    internal class Reference
    {
        /// <summary>
        ///  原程序集的名称
        /// </summary>
        public AssemblyName Assembly { get; set; }

        /// <summary>
        ///  被引用的程序集的名称
        /// </summary>
        public AssemblyName ReferencedAssembly { get; set; }
    }
}