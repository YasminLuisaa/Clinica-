using App.Cadastros;
using AutoMapper;
using Domain.Base;
using Domain.Entities;
using Repository.Repository;
using Service.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Repository.Context;
using App.Models;

namespace App.Infra
{
    public static class ConfigureDI
    {
        public static ServiceCollection? Services;

        public static ServiceProvider? ServicesProvider;

        public static void ConfiguraServices()
        {
            Services = new ServiceCollection();

            // Configuração do DbContext
            Services.AddDbContext<MySqlContext>(options =>
            {
                var server = "localhost";
                var port = "3306";
                var database = "ClinicaYasmin";
                var username = "root";
                var password = "";
                var strCon = $"Server={server};Port={port};Database={database};Uid={username};Pwd={password}";
                //var strCon = File.ReadAllText("Config/DatabaseSettings.txt");
                options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
                options.EnableSensitiveDataLogging();

                options.UseMySql(strCon, ServerVersion.AutoDetect(strCon), opt =>
                {
                    opt.CommandTimeout(180);
                    opt.EnableRetryOnFailure(5);
                });
            });

            // Repositories
            Services.AddScoped<IBaseRepository<Paciente>, BaseRepository<Paciente>>();
            Services.AddScoped<IBaseRepository<Medico>, BaseRepository<Medico>>();
            Services.AddScoped<IBaseRepository<Consulta>, BaseRepository<Consulta>>();
            Services.AddScoped<IBaseRepository<ProntuarioMedico>, BaseRepository<ProntuarioMedico>>();
            Services.AddScoped<IBaseRepository<Pagamento>, BaseRepository<Pagamento>>();

            // Services
            Services.AddScoped<IBaseService<Paciente>, BaseService<Paciente>>();
            Services.AddScoped<IBaseService<Medico>, BaseService<Medico>>();
            Services.AddScoped<IBaseService<Consulta>, BaseService<Consulta>>();
            Services.AddScoped<IBaseService<ProntuarioMedico>, BaseService<ProntuarioMedico>>();
            Services.AddScoped<IBaseService<Pagamento>, BaseService<Pagamento>>();

            // Formulários (caso você tenha formulários para cadastro)
            Services.AddTransient<CadastroPaciente, CadastroPaciente>();
            Services.AddTransient<CadastroMedico, CadastroMedico>();
            Services.AddTransient<CadastroConsulta, CadastroConsulta>();
            Services.AddTransient<CadastroProntuarioMedico, CadastroProntuarioMedico>();
            Services.AddTransient<CadastroPagamento, CadastroPagamento>();

            // Configuração do AutoMapper
            Services.AddSingleton(new MapperConfiguration(config =>
            {
                // Mapeamento das entidades para os modelos
                config.CreateMap<Paciente, PacienteModel>();
                config.CreateMap<Medico, MedicoModel>();
                config.CreateMap<Consulta, ConsultaModel>()
                    .ForMember(d => d.NomePaciente, d => d.MapFrom(x => x.Paciente!.Nome))
                    .ForMember(d => d.NomeMedico, d => d.MapFrom(x => x.Medico!.Nome));
                config.CreateMap<ProntuarioMedico, ProntuarioMedicoModel>()
                    .ForMember(d => d.NomePaciente, d => d.MapFrom(x => x.Paciente!.Nome))
                    .ForMember(d => d.NomeMedico, d => d.MapFrom(x => x.Medico!.Nome));
                config.CreateMap<Pagamento, PagamentoModel>()
                    .ForMember(d => d.NomePaciente, d => d.MapFrom(x => x.Paciente!.Nome))
                    .ForMember(d => d.DataHoraConsulta, d => d.MapFrom(x => x.Consulta!.DataHora));
            }).CreateMapper());

            ServicesProvider = Services.BuildServiceProvider();
        }
    }
}