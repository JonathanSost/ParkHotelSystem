select p.id 'IDProduto', p.nome 'NomeProduto', p.descricao 'DescricaoProduto',  p.precound 'PreçoUnidade',
                                  p.estoque 'Estoque', p.idfornecedor 'IDFornecedor', f.nomeempresa 'NomeEmpresaFornecedora' 
                                  from produtos p inner join fornecedores f on p.idfornecedor = f.id where p.descricao = 'asofasfosauh'

