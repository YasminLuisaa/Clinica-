using AutoMapper;
using App.Models;
using Domain.Base;
using Domain.Entities;
using Repository.Context;
using Repository.Repository;
using Service.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using App.Cadastro;

namespace App.Infra
{
    public static class ConfigureDI
    {
        public static ServiceCollection? Services;

        public static ServiceProvider? ServicesProvider;

        public static void ConfiguraServices()
        {
            Services = new ServiceCollection();
            Services.AddDbContext<MySqlContext>(options =>
            {
                // Lê a string de conexão do arquivo de configuração
                var strCon = File.ReadAllText("Config/DatabaseSettings.txt");
                options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
                options.EnableSensitiveDataLogging();

            });

            // Repositories
            Services.AddScoped<IBaseRepository<Paciente>, BaseRepository<Paciente>>();
            Services.AddScoped<IBaseRepository<Medico>, BaseRepository<Medico>>();
            Services.AddScoped<IBaseRepository<Especialidade>, BaseRepository<Especialidade>>();
            Services.AddScoped<IBaseRepository<Consulta>, BaseRepository<Consulta>>();

            // Services
            Services.AddScoped<IBaseService<Paciente>, BaseService<Paciente>>();
            Services.AddScoped<IBaseService<Medico>, BaseService<Medico>>();
            Services.AddScoped<IBaseService<Especialidade>, BaseService<Especialidade>>();
            Services.AddScoped<IBaseService<Consulta>, BaseService<Consulta>>();

            // Formulários
            Services.AddTransient<CadastroPaciente, CadastroPaciente>();
            Services.AddTransient<CadastroMedico, CadastroMedico>();
            Services.AddTransient<CadastroEspecialidade, CadastroEspecialidade>();
            Services.AddTransient<CadastroConsulta, CadastroConsulta>();
            
            Services.AddTransient<FormPrincipal, FormPrincipal>();

            // Mapping
            var mapperConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<Paciente, PacienteModel>();

                config.CreateMap<Medico, MedicoModel>()
                      .ForMember(d => d.IdEspecialidade, d => d.MapFrom(x => x.Especialidade!.Nome))
                      .ForMember(d => d.IdEspecialidade, d => d.MapFrom(x => x.Especialidade!.Id));

                config.CreateMap<Especialidade, EspecialidadeModel>();

                config.CreateMap<Consulta, ConsultaModel>()
                      .ForMember(d => d.IdPaciente, d => d.MapFrom(x => x.Paciente!.Id))
                      .ForMember(d => d.PacienteNome, d => d.MapFrom(x => x.Paciente!.Nome))
                      .ForMember(d => d.IdMedico, d => d.MapFrom(x => x.Medico!.Id))
                      .ForMember(d => d.MedicoNome, d => d.MapFrom(x => x.Medico!.Nome));

                // Adicione mapeamentos adicionais conforme necessário
            });

            Services.AddSingleton(mapperConfig.CreateMapper());

            ServicesProvider = Services.BuildServiceProvider();
        }
    }
}