// Função para simular a busca de dados do backend/banco de dados
function carregarDadosDashboard() {

    // Simulação de dados chegando do sistema
    const dadosDoSistema = {
        vendasHojeReais: 1450.75,
        pedidosHoje: 12,
        totalProdutosEstoque: 1248,
        produtosAcabando: 5
    };

    // 1. Formatando os valores para fi car profissional
    // Transforma 1450.75 em "R$ 1.450,75" com padrão brasileiro
    const valorFormatado = new Intl.NumberFormat('pt-BR', {
        style: 'currency',
        currency: 'BRL'
    }).format(dadosDoSistema.vendasHojeReais);

    // 2. Injetando os dados no HTML usando as IDs
    document.getElementById("valorVendas").innerText = valorFormatado;
    document.getElementById("qtdVendasTexto").innerText = `${dadosDoSistema.pedidosHoje} pedidos finalizados`;

    document.getElementById("qtdEstoque").innerText = dadosDoSistema.totalProdutosEstoque;

    document.getElementById("alertasEstoque").innerText = dadosDoSistema.produtosAcabando;
}

// Faz a função rodar automaticamente assim que a página terminar de carregar
document.addEventListener("DOMContentLoaded", function () {
    carregarDadosDashboard();
});