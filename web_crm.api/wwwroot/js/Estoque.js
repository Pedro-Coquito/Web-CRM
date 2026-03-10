// ==========================================
// 1. AS FUNÇÕES (A OFICINA)
// ==========================================

// Função que busca os dados no banco e monta a tabela
async function carregarEstoque() {
    try {
        const resposta = await fetch('/api/estoque');
        const produtos = await resposta.json();

        const corpoTabela = document.getElementById('corpoTabelaProdutos');
        corpoTabela.innerHTML = '';

        produtos.forEach(produto => {
            const precoFormatado = new Intl.NumberFormat('pt-BR', { style: 'currency', currency: 'BRL' }).format(produto.preco);

            const linha = `
                <tr>
                    <td class="py-3 px-4">${produto.id}</td>
                    <td class="py-3 fw-bold">${produto.nome}</td>
                    <td class="py-3 text-success">${precoFormatado}</td>
                    <td class="py-3">${produto.peso} kg</td>
                    <td class="py-3 text-center">
                        <button class="btn btn-sm btn-outline-primary">Editar</button>
                    </td>
                </tr>
            `;
            corpoTabela.innerHTML += linha;
        });
    } catch (erro) {
        console.error("Erro ao carregar os produtos do banco:", erro);
        document.getElementById('corpoTabelaProdutos').innerHTML = '<tr><td colspan="5" class="text-danger text-center">Erro ao carregar dados.</td></tr>';
    }
}

// Função que pega os dados do Modal e salva no banco
async function salvarNovoProduto() {
    const nome = document.getElementById('nomeProdutos').value;
    const preco = parseFloat(document.getElementById('preco').value);
    const peso = parseFloat(document.getElementById('pesoProdutos').value);
    const valorCompra = parseFloat(document.getElementById('valorDeCompra').value);

    // Validação de segurança
    if (!nome || isNaN(preco) || isNaN(peso) || isNaN(valorCompra)) {
        alert("Por favor, preencha todos os campos corretamente.");
        return;
    }

    const produtoParaSalvar = {
        Nome: nome,
        Preco: preco,
        Peso: peso,
        ValorCompra: valorCompra
    };

    try {
        const resposta = await fetch('/api/estoque', {
            method: 'POST',
            headers: { 'Content-Type': 'application/json' },
            body: JSON.stringify(produtoParaSalvar)
        });

        if (resposta.ok) {
            // Limpa o formulário
            document.getElementById('formNovoProduto').reset();

            // Esconde o Modal do Bootstrap
            const modalElement = document.getElementById('modalNovoProduto');
            const modalInstancia = bootstrap.Modal.getInstance(modalElement) || new bootstrap.Modal(modalElement);
            modalInstancia.hide();

            // Atualiza a tabela imediatamente
            carregarEstoque();
            alert("Produto salvo com sucesso!");
        } else {
            alert("Erro ao tentar salvar o produto no servidor.");
        }
    } catch (erro) {
        console.error("Erro na comunicação com a API:", erro);
        alert("Erro de conexão.");
    }
}


// ==========================================
// 2. A IGNIÇÃO (O EVENT LISTENER)
// ==========================================

// Tudo o que está aqui dentro só roda quando o HTML estiver 100% pronto na tela
document.addEventListener('DOMContentLoaded', () => {

    // 1. Manda preencher a tabela
    carregarEstoque();

    // 2. Prende o "espião de cliques" no botão Salvar do Modal
    const btnSalvar = document.getElementById('btnSalvarProduto');
    if (btnSalvar) {
        btnSalvar.addEventListener('click', salvarNovoProduto);
    }
});