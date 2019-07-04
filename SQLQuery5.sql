select cli.ID, cli.Nome 'Nome', cli.CPF, cli.RG, cli.Telefone1 'Telefone', 
            cli.Telefone2 'Celular', cli.email 'E-mail', cli.CEP, est.Nome 'Estado', cid.nome 'Cidade', 
            cli.Rua, cli.Bairro, cli.Numero, cli.Complemento, cli.conta 'Conta' from clientes cli inner join 
            cidades cid on cli.cidade = cid.id inner join estados est on cli.estado = est.id