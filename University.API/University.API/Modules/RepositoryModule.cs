using Autofac;
using University.Data.Context;
using University.Data.Repositories;
using University.Data.Repositories.Interfaces;

namespace University.API.Modules
{
    public class RepositoryModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<StudentRepository>()
                   .As<IStudentRepository>()
                   .InstancePerLifetimeScope();

            builder.RegisterType<CourseRepository>()
                   .As<ICourseRepository>()
                   .InstancePerLifetimeScope();

            builder.RegisterType<UniversityDbContext>()
                .AsSelf()
                .InstancePerLifetimeScope();
        }
    }
}