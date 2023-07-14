using ModeloPadraoAPIs.DTOs;
using ModeloPadraoAPIs.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;

namespace ModeloPadraoAPIs.Mappings
{
    public class BancoMapping :Profile
    {
        public BancoMapping()
        {
            CreateMap(typeof(ResponceGenerico<>), typeof(ResponceGenerico<>));
            CreateMap<BancoResponse, BancoModel>();
            CreateMap<BancoModel, BancoResponse>();
        }
    }
}
