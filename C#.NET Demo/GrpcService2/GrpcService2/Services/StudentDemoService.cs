using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Grpc.Core;
using Microsoft.Extensions.Logging;

namespace GrpcService2.Services
{
    public class StudentDemoService : StudentService.StudentServiceBase
    {
        private readonly ILogger<StudentDemoService> _logger;

        public StudentDemoService(ILogger<StudentDemoService> logger)
        {
            _logger = logger;
        }

        public override async Task<CommonResponse> AddManyStudents(IAsyncStreamReader<AddStudentRequest> requestStream, IServerStreamWriter<StudentResponse> responseStream, ServerCallContext context)
        {
            return await Task.FromResult(new CommonResponse());
        }

        public override Task<StudentResponse> GetStudentByUserName(QueryStudentRequest request, ServerCallContext context)
        {
            if (!string.IsNullOrEmpty(request.UserName))
            {
                return Task.FromResult(new StudentResponse());
            }

            var student = DemoData.FakeData.FirstOrDefault(item => item.UserName == request.UserName);
            return Task.FromResult(new StudentResponse()
            {
                Student = student,
            });
        }

        public override async Task GetAllStudent(QueryAllStudentRequest request, IServerStreamWriter<StudentResponse> responseStream, ServerCallContext context)
        {
            //使用流方式进行传送
            foreach (var student in DemoData.FakeData)
            {
                await responseStream.WriteAsync(new StudentResponse(){Student = student});
            }
        }

        public override Task<TokenResponse> GetToken(TokenRequest request, ServerCallContext context)
        {
            return base.GetToken(request, context);
        }

        public override async Task<CommonResponse> UploadImage(IAsyncStreamReader<UploadImgRequest> requestStream, ServerCallContext context)
        {
            try
            {
                var tempData = new List<byte>();
                while (await requestStream.MoveNext())
                {
                    tempData.AddRange(requestStream.Current.Data);
                }
                Console.WriteLine($"接收到文件大小:{tempData.Count}bytes");

                await using FileStream fs = new FileStream("test.jpg", FileMode.Create);
                fs.Write(tempData.ToArray(), 0, tempData.ToArray().Length);

                return new CommonResponse { Code = 0, Msg = "接收成功" };
            }
            catch (Exception ex)
            {
                return new CommonResponse { Code = -1, Msg = "接收失败" };
            }
        }
    }
}
