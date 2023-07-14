using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ModeloPadraoAPIs.DTOs;
using ModeloPadraoAPIs.models;
using ModeloPadraoAPIs.Interfaces;
using ModeloPadraoAPIs.Services;
using ModeloPadraoAPIs.REST;
using ModeloPadraoAPIs.Mappings;
using Microsoft.Graph.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

internal class Program
{
    private static void Main(string[] args)
    {
        WebApplicationBuilder builder = Microsoft.AspNetCore.Builder.WebApplication.CreateBuilder(args);

        // Add services to the container.

        builder.Services.AddControllers();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        builder.Services.AddSingleton<IntEnderecoServices, EnderecoService>();
        builder.Services.AddSingleton(new BancoService());
        builder.Services.AddSingleton<IntBrasilApi, BrasilApiRest>();

        builder.Services.AddAutoMapper(typeof(EnderecoMapping));
        builder.Services.AddAutoMapper(typeof(BancoMapping));

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}