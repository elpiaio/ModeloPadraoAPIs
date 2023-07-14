using AutoMapper;
using ModeloPadraoAPIs.DTOs;
using ModeloPadraoAPIs.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModeloPadraoAPIs.Mappings
{
    public class EnderecoMapping : Profile
    {
        public EnderecoMapping()
        {
            CreateMap(typeof(ResponceGenerico<>), typeof(ResponceGenerico<>));
            CreateMap<EnderecoResponse, EnderecoModel>();
            CreateMap<EnderecoModel, EnderecoResponse>();
        }
    }
}
