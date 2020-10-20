using System;
using System.Collections.Generic;
using System.Text;
using CleanArch.Application.Interfaces;
using CleanArch.Application.Services;
using CleanArch.Domain.Interfaces;
using CleanArch.Infra.Data.Repositores;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArch.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Application Layer

            services.AddScoped<ICourseServices, CourseServices>();

            //Infra Data Layer

            services.AddScoped<ICourseRepositores, CourseRepositores>();
        }
    }
}
