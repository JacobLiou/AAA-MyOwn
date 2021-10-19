using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrpcService2.Services
{
    public class DemoData
    {
        public static List<Student> FakeData { get; } = new List<Student>()
        {
            new Student() {UserName = "张山", Age = 18, Addr = "Shenzhen"},
            new Student() {UserName = "张山", Age = 18, Addr = "Shenzhen"},
            new Student() {UserName = "张山", Age = 18, Addr = "Shenzhen"},
        };
    }
}
