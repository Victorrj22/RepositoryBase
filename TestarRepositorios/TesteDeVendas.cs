using Microsoft.VisualBasic.CompilerServices;
using Vendas.Model;
using Vendas.Repositories;

namespace TestarRepositorios
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void IncluirCategoria()
        {
            TBCategoriaRepositorio _Rep = new TBCategoriaRepositorio();
            TBCategorias oCat = new TBCategorias();
            oCat.Descricao = "TESTE " + DateTime.Now.ToString();
            _Rep.Incluir(oCat);

            _Rep.Dispose();
        }

        [Test]
        public void AlterarCategoria()
        {
            TBCategoriaRepositorio _Rep = new TBCategoriaRepositorio();
            TBCategorias oCat = _Rep.SelecionarChave(1);
            string novaDescricao = "Nova Descricao";
            oCat.Descricao = novaDescricao;
            _Rep.Alterar(oCat);
            _Rep.Dispose();
        }

        [Test]
        public void ExcluirCategoria()
        {
            TBCategoriaRepositorio _Rep = new TBCategoriaRepositorio();
            TBCategorias oCat = _Rep.SelecionarChave(3);
            _Rep.Excluir(oCat);
            _Rep.Dispose();
        }

        [Test]
        public void SelecionarTodosNoTrackingCategoria()
        {
            TBCategoriaRepositorio _Rep = new TBCategoriaRepositorio();
            _Rep.SelecionarTodosAsNoTracking();
            _Rep.Dispose();
        }

        [Test]
        public void SelecionarTodosCategoria()
        {
            TBCategoriaRepositorio _Rep = new TBCategoriaRepositorio();
            _Rep.Selecionartodos();
            _Rep.Dispose();
        }
        [Test]
        public void SelecionarChaveCategoria()
        {
            TBCategoriaRepositorio _Rep = new TBCategoriaRepositorio();
            _Rep.SelecionarChave(1);
            _Rep.Dispose();
        }

        [Test]
        public void IncluirCliente()
        {
            TBClientesRepositorio _Rep = new TBClientesRepositorio();
            TBClientes oClientes = new TBClientes();
            oClientes.Documento = "16362165799";
            oClientes.Nome = "Lucas";
            oClientes.Telefone = "2488964567";
            oClientes.Email = "teste2@gmail.com";
            _Rep.Incluir(oClientes);
            _Rep.Dispose();
        }

        [Test]
        public void AlterarCliente()
        {
            TBClientesRepositorio _Rep = new TBClientesRepositorio();
            TBClientes oClientes = _Rep.SelecionarChave("12312312312");
            string novoTelefone = "24992430587";
            oClientes.Telefone = novoTelefone;
            _Rep.Alterar(oClientes);
            _Rep.Dispose();
        }

        [Test]
        public void ExcluirCliente()
        {
            TBClientesRepositorio _Rep = new TBClientesRepositorio();
            TBClientes oClientes = _Rep.SelecionarChave("16362165799");
            _Rep.Excluir(oClientes);
            _Rep.Dispose();
        }

        [Test]
        public void SelecionarTodosNoTrackingCliente()
        {
            TBClientesRepositorio _Rep = new TBClientesRepositorio();
            _Rep.SelecionarTodosAsNoTracking();
            _Rep.Dispose();
        }

        [Test]
        public void SelecionarTodosCliente()
        {
            TBClientesRepositorio _Rep = new TBClientesRepositorio();
            _Rep.Selecionartodos();
            _Rep.Dispose();
        }

        [Test]
        public void SelecionarChaveCliente()
        {
            TBClientesRepositorio _Rep = new TBClientesRepositorio();
            _Rep.SelecionarChave("12312312312");
            _Rep.Dispose();
        }

        [Test]
        public void IncluirItens()
        {
            TBItensRepositorio _Rep = new TBItensRepositorio();
            TBItens oItens = new TBItens();
            oItens.IdPedido = 2;
            oItens.IdProduto = 1;
            oItens.Quantidade = 23;
            _Rep.Incluir(oItens);
            _Rep.Dispose();
        }

        [Test]
        public void AlterarItens()
        {
            TBItensRepositorio _Rep = new TBItensRepositorio();
            TBItens oItens = new TBItens();
            oItens = _Rep.SelecionarChave(10);
            int novaQuantidade = 34;
            oItens.Quantidade = novaQuantidade;
            _Rep.Alterar(oItens);
            _Rep.Dispose();
        }

        [Test]
        public void ExcluirItens()
        {
            TBItensRepositorio _Rep = new TBItensRepositorio();
            TBItens oItens = _Rep.SelecionarChave(12);
            _Rep.Excluir(oItens);
            _Rep.Dispose();
        }

        [Test]
        public void SelecionarTodosNoTrackingItens()
        {
            TBItensRepositorio _Rep = new TBItensRepositorio();
            _Rep.SelecionarTodosAsNoTracking();
            _Rep.Dispose();
        }

        [Test]
        public void SelecionarTodosItens()
        {
            TBItensRepositorio _Rep = new TBItensRepositorio();
            _Rep.Selecionartodos();
            _Rep.Dispose();
        }

        [Test]
        public void SelecionarChaveItens()
        {
            TBItensRepositorio _Rep = new TBItensRepositorio();
            _Rep.SelecionarChave(10);
            _Rep.Dispose();
        }

        [Test]
        public void IncluirPedidos()
        {
            TBPedidosRepositorio _Rep = new TBPedidosRepositorio();
            TBPedidos oPedidos = new TBPedidos();
            oPedidos.DocCliente = "12312312312";
            oPedidos.Data = DateTime.Now;
            oPedidos.NumeroPedido = "1";
            _Rep.Incluir(oPedidos);
            _Rep.Dispose();
        }

        [Test]
        public void AlterarPedidos()
        {
            TBPedidosRepositorio _Rep = new TBPedidosRepositorio();
            TBPedidos oPedidos = _Rep.SelecionarChave(2);
            DateTime novaData = DateTime.Now;
            oPedidos.Data = novaData;
            _Rep.Alterar(oPedidos);
            _Rep.Dispose();
        }

        [Test]
        public void ExcluirPedidos()
        {
            TBPedidosRepositorio _Rep = new TBPedidosRepositorio();
            TBPedidos oPedidos = _Rep.SelecionarChave(5);
            _Rep.Excluir(oPedidos);
            _Rep.Dispose();
        }

        [Test]
        public void SelecionarTodosNoTrackingPedidos()
        {
            TBPedidosRepositorio _Rep = new TBPedidosRepositorio();
            _Rep.SelecionarTodosAsNoTracking();
            _Rep.Dispose();
        }

        [Test]
        public void SelecionarTodosPedidos()
        {
            TBPedidosRepositorio _Rep = new TBPedidosRepositorio();
            _Rep.Selecionartodos();
            _Rep.Dispose();
        }

        [Test]
        public void SelecionarChavePedidos()
        {
            TBPedidosRepositorio _Rep = new TBPedidosRepositorio();
            _Rep.SelecionarChave(3);
            _Rep.Dispose();
        }

        [Test]
        public void IncluirProdutos()
        {
            TBProdutosRepositorio _Rep = new TBProdutosRepositorio();
            TBProdutos oProdutos = new TBProdutos();
            oProdutos.IdCategoria = 1;
            oProdutos.Descricao = "João";
            oProdutos.Unidade = "2488964567";
            oProdutos.Foto = null;
            oProdutos.MimeType = null;
            oProdutos.Preco = 20;
            _Rep.Incluir(oProdutos);
            _Rep.Dispose();
        }

        [Test]
        public void AlterarProdutos()
        {
            TBProdutosRepositorio _Rep = new TBProdutosRepositorio();
            TBProdutos oProdutos = _Rep.SelecionarChave(1);
            int novoPreco = 100;
            oProdutos.Preco = novoPreco;
            _Rep.Alterar(oProdutos);
            _Rep.Dispose();
        }

        [Test]
        public void ExcluirProdutos()
        {
            TBProdutosRepositorio _Rep = new TBProdutosRepositorio();
            TBProdutos oProdutos = _Rep.SelecionarChave(3);
            _Rep.Excluir(oProdutos);
            _Rep.Dispose();
        }

        [Test]
        public void SelecionarTodosNoTrackingProdutos()
        {
            TBProdutosRepositorio _Rep = new TBProdutosRepositorio();
            _Rep.SelecionarTodosAsNoTracking();
            _Rep.Dispose();
        }

        [Test]
        public void SelecionarTodosProdutos()
        {
            TBProdutosRepositorio _Rep = new TBProdutosRepositorio();
            _Rep.Selecionartodos();
            _Rep.Dispose();
        }

        [Test]
        public void SelecionarChaveProdutos()
        {
            TBProdutosRepositorio _Rep = new TBProdutosRepositorio();
            _Rep.SelecionarChave(2);
            _Rep.Dispose();
        }
    }
}