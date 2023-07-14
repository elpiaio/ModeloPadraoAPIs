using ModeloPadraoAPIs.DTOs;
using ModeloPadraoAPIs.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModeloPadraoAPIs.Interfaces
{
    public interface IntBrasilApi
    {
        Task<ResponceGenerico<EnderecoModel>> BuscarEnderecoPorCEP(string cep);
        Task<ResponceGenerico<List<BancoModel>>> BuscarTodosBancos();
        Task<ResponceGenerico<BancoModel>> BuscarBanco(string codigoBanco);
    }
}
