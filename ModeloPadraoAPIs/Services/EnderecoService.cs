using AutoMapper;
using ModeloPadraoAPIs.DTOs;
using ModeloPadraoAPIs.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModeloPadraoAPIs.Services
{
    public class EnderecoService : IntEnderecoServices
    {
        private readonly IMapper _mapper;
        private readonly IntBrasilApi _brasilApi;

        public EnderecoService(IMapper mapper, IntBrasilApi brasilApi)
        {
            _mapper = mapper;
            _brasilApi = brasilApi;
            Console.WriteLine("Thiago gay");
        }

        public async Task<ResponceGenerico<EnderecoResponse>> BuscarEndereco(string cep)
        {
            var endereco = await _brasilApi.BuscarEnderecoPorCEP(cep);
            return _mapper.Map<ResponceGenerico<EnderecoResponse>>(endereco);
        }
    }
}
