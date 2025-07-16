using Autofac;
using University.API.Helpers;
using University.Core.Services;
using University.Core.Services.Interfaces;

namespace University.API.Modules
{
    public class ServiceModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<StudentService>()
                .As<IStudentService>()
                .InstancePerLifetimeScope();

            builder.RegisterType<CourseService>()
                .As<ICourseService>()
                .InstancePerLifetimeScope();

            builder.RegisterType<AuthService>()
                .As<IAuthService>()
                .InstancePerLifetimeScope();

            builder.RegisterType<JwtTokenHelper>()
                .As<IJwtTokenHelper>()
                .InstancePerLifetimeScope();
        }

    }
}
