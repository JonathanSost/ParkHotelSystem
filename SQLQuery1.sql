CREATE TABLE ESTADOS
(
ID INT PRIMARY KEY IDENTITY,
NOME VARCHAR(20) NOT NULL,
SIGLA CHAR(2) NOT NULL
)

INSERT INTO estados (NOME, SIGLA) VALUES('Acre', 'AC')

INSERT INTO estados (NOME, SIGLA) VALUES('Alagoas', 'AL')

INSERT INTO estados (NOME, SIGLA) VALUES('Amazonas', 'AM')

INSERT INTO estados (NOME, SIGLA) VALUES('Amapá', 'AP')

INSERT INTO estados (NOME, SIGLA) VALUES('Bahia', 'BA')

INSERT INTO estados (NOME, SIGLA) VALUES('Ceará', 'CE')

INSERT INTO estados (NOME, SIGLA) VALUES('Distrito Federal', 'DF')

INSERT INTO estados (NOME, SIGLA) VALUES('Espírito Santo', 'ES')

INSERT INTO estados (NOME, SIGLA) VALUES('Goiás', 'GO')

INSERT INTO estados (NOME, SIGLA) VALUES('Maranhão', 'MA')

INSERT INTO estados (NOME, SIGLA) VALUES('Minas Gerais', 'MG')

INSERT INTO estados (NOME, SIGLA) VALUES('Mato Grosso do Sul', 'MS')

INSERT INTO estados (NOME, SIGLA) VALUES('Mato Grosso', 'MT')

INSERT INTO estados (NOME, SIGLA) VALUES('Pará', 'PA')

INSERT INTO estados (NOME, SIGLA) VALUES('Paraíba', 'PB')

INSERT INTO estados (NOME, SIGLA) VALUES('Pernambuco', 'PE')

INSERT INTO estados (NOME, SIGLA) VALUES('Piauí', 'PI')

INSERT INTO estados (NOME, SIGLA) VALUES('Paraná', 'PR')

INSERT INTO estados (NOME, SIGLA) VALUES('Rio de Janeiro', 'RJ')

INSERT INTO estados (NOME, SIGLA) VALUES('Rio Grande do Norte', 'RN')

INSERT INTO estados (NOME, SIGLA) VALUES('Rondônia', 'RO')

INSERT INTO estados (NOME, SIGLA) VALUES('Roraima', 'RR')

INSERT INTO estados (NOME, SIGLA) VALUES('Rio Grande do Sul', 'RS')

INSERT INTO estados (NOME, SIGLA) VALUES('Santa Catarina', 'SC')

INSERT INTO estados (NOME, SIGLA) VALUES('Sergipe', 'SE')

INSERT INTO estados (NOME, SIGLA) VALUES('São Paulo', 'SP')

INSERT INTO estados (NOME, SIGLA) VALUES('Tocantins', 'TO')

CREATE TABLE CIDADES
(
ID INT PRIMARY KEY IDENTITY,
NOME VARCHAR(40) NOT NULL,
ESTADO INT NOT NULL REFERENCES ESTADOS,
IBGE INT DEFAULT NULL
)

insert into cidades values('Afonso Cláudio',8,'3200102')

insert into cidades values('Água Doce do Norte',8,'3200169')

insert into cidades values('Águia Branca',8,'3200136')

insert into cidades values('Alegre',8,'3200201')

insert into cidades values('Alfredo Chaves',8,'3200300')

insert into cidades values('Alto Rio Novo',8,'3200359')

insert into cidades values('Anchieta',8,'3200409')

insert into cidades values('Apiacá',8,'3200508')

insert into cidades values('Aracruz',8,'3200607')

insert into cidades values('Atilio Vivacqua',8,'3200706')

insert into cidades values('Baixo Guandu',8,'3200805')

insert into cidades values('Barra de São Francisco',8,'3200904')

insert into cidades values('Boa Esperança',8,'3201001')

insert into cidades values('Bom Jesus do Norte',8,'3201100')

insert into cidades values('Brejetuba',8,'3201159')

insert into cidades values('Cachoeiro de Itapemirim',8,'3201209')

insert into cidades values('Cariacica',8,'3201308')

insert into cidades values('Castelo',8,'3201407')

insert into cidades values('Colatina',8,'3201506')

insert into cidades values('Conceição da Barra',8,'3201605')

insert into cidades values('Conceição do Castelo',8,'3201704')

insert into cidades values('Divino de São Lourenço',8,'3201803')

insert into cidades values('Domingos Martins',8,'3201902')

insert into cidades values('Dores do Rio Preto',8,'3202009')

insert into cidades values('Ecoporanga',8,'3202108')

insert into cidades values('Fundão',8,'3202207')

insert into cidades values('Governador Lindenberg',8,'3202256')

insert into cidades values('Guaçuí',8,'3202306')

insert into cidades values('Guarapari',8,'3202405')

insert into cidades values('Ibatiba',8,'3202454')

insert into cidades values('Ibiraçu',8,'3202504')

insert into cidades values('Ibitirama',8,'3202553')

insert into cidades values('Iconha',8,'3202603')

insert into cidades values('Irupi',8,'3202652')

insert into cidades values('Itaguaçu',8,'3202702')

insert into cidades values('Itapemirim',8,'3202801')

insert into cidades values('Itarana',8,'3202900')

insert into cidades values('Iúna',8,'3203007')

insert into cidades values('Jaguaré',8,'3203056')

insert into cidades values('Jerônimo Monteiro',8,'3203106')

insert into cidades values('João Neiva',8,'3203130')

insert into cidades values('Laranja da Terra',8,'3203163')

insert into cidades values('Linhares',8,'3203205')

insert into cidades values('Mantenópolis',8,'3203304')

insert into cidades values('Marataízes',8,'3203320')

insert into cidades values('Marechal Floriano',8,'3203346')

insert into cidades values('Marilândia',8,'3203353')

insert into cidades values('Mimoso do Sul',8,'3203403')

insert into cidades values('Montanha',8,'3203502')

insert into cidades values('Mucurici',8,'3203601')

insert into cidades values('Muniz Freire',8,'3203700')

insert into cidades values('Muqui',8,'3203809')

insert into cidades values('Nova Venécia',8,'3203908')

insert into cidades values('Pancas',8,'3204005')

insert into cidades values('Pedro Canário',8,'3204054')

insert into cidades values('Pinheiros',8,'3204104')

insert into cidades values('Piúma',8,'3204203')

insert into cidades values('Ponto Belo',8,'3204252')

insert into cidades values('Presidente Kennedy',8,'3204302')

insert into cidades values('Rio Bananal',8,'3204351')

insert into cidades values('Rio Novo do Sul',8,'3204401')

insert into cidades values('Santa Leopoldina',8,'3204500')

insert into cidades values('Santa Maria de Jetibá',8,'3204559')

insert into cidades values('Santa Teresa',8,'3204609')

insert into cidades values('São Domingos do Norte',8,'3204658')

insert into cidades values('São Gabriel da Palha',8,'3204708')

insert into cidades values('São José do Calçado',8,'3204807')

insert into cidades values('São Mateus',8,'3204906')

insert into cidades values('São Roque do Canaã',8,'3204955')

insert into cidades values('Serra',8,'3205002')

insert into cidades values('Sooretama',8,'3205010')

insert into cidades values('Vargem Alta',8,'3205036')

insert into cidades values('Venda Nova do Imigrante',8,'3205069')

insert into cidades values('Viana',8,'3205101')

insert into cidades values('Vila Pavão',8,'3205150')

insert into cidades values('Vila Valério',8,'3205176')

insert into cidades values('Vila Velha',8,'3205200')

insert into cidades values('Vitória',8,'3205309')

insert into cidades values('Acrelândia',1,'1200013')

insert into cidades values('Assis Brasil',1,'1200054')

insert into cidades values('Brasiléia',1,'1200104')

insert into cidades values('Bujari',1,'1200138')

insert into cidades values('Capixaba',1,'1200179')

insert into cidades values('Cruzeiro do Sul',1,'1200203')

insert into cidades values('Epitaciolândia',1,'1200252')

insert into cidades values('Feijó',1,'1200302')

insert into cidades values('Jordão',1,'1200328')

insert into cidades values('Mâncio Lima',1,'1200336')

insert into cidades values('Manoel Urbano',1,'1200344')

insert into cidades values('Marechal Thaumaturgo',1,'1200351')

insert into cidades values('Plácido de Castro',1,'1200385')

insert into cidades values('Porto Acre',1,'1200807')

insert into cidades values('Porto Walter',1,'1200393')

insert into cidades values('Rio Branco',1,'1200401')

insert into cidades values('Rodrigues Alves',1,'1200427')

insert into cidades values('Santa Rosa do Purus',1,'1200435')

insert into cidades values('Sena Madureira',1,'1200500')

insert into cidades values('Senador Guiomard',1,'1200450')

insert into cidades values('Tarauacá',1,'1200609')

insert into cidades values('Xapuri',1,'1200708')

insert into cidades values('Água Branca',2,'2700102')

insert into cidades values('Anadia',2,'2700201')

insert into cidades values('Arapiraca',2,'2700300')

insert into cidades values('Atalaia',2,'2700409')

insert into cidades values('Barra de Santo Antônio',2,'2700508')

insert into cidades values('Barra de São Miguel',2,'2700607')

insert into cidades values('Batalha',2,'2700706')

insert into cidades values('Belém',2,'2700805')

insert into cidades values('Belo Monte',2,'2700904')

insert into cidades values('Boca da Mata',2,'2701001')

insert into cidades values('Branquinha',2,'2701100')

insert into cidades values('Cacimbinhas',2,'2701209')

insert into cidades values('Cajueiro',2,'2701308')

insert into cidades values('Campestre',2,'2701357')

insert into cidades values('Campo Alegre',2,'2701407')

insert into cidades values('Campo Grande',2,'2701506')

insert into cidades values('Canapi',2,'2701605')

insert into cidades values('Capela',2,'2701704')

insert into cidades values('Carneiros',2,'2701803')

insert into cidades values('Chã Preta',2,'2701902')

insert into cidades values('Coité do Nóia',2,'2702009')

insert into cidades values('Colônia Leopoldina',2,'2702108')

insert into cidades values('Coqueiro Seco',2,'2702207')

insert into cidades values('Coruripe',2,'2702306')

insert into cidades values('Craíbas',2,'2702355')

insert into cidades values('Delmiro Gouveia',2,'2702405')

insert into cidades values('Dois Riachos',2,'2702504')

insert into cidades values('Estrela de Alagoas',2,'2702553')

insert into cidades values('Feira Grande',2,'2702603')

insert into cidades values('Feliz Deserto',2,'2702702')

insert into cidades values('Flexeiras',2,'2702801')

insert into cidades values('Girau do Ponciano',2,'2702900')

insert into cidades values('Ibateguara',2,'2703007')

insert into cidades values('Igaci',2,'2703106')

insert into cidades values('Igreja Nova',2,'2703205')

insert into cidades values('Inhapi',2,'2703304')

insert into cidades values('Jacaré dos Homens',2,'2703403')

insert into cidades values('Jacuípe',2,'2703502')

insert into cidades values('Japaratinga',2,'2703601')

insert into cidades values('Jaramataia',2,'2703700')

insert into cidades values('Jequiá da Praia',2,'2703759')

insert into cidades values('Joaquim Gomes',2,'2703809')

insert into cidades values('Jundiá',2,'2703908')

insert into cidades values('Junqueiro',2,'2704005')

insert into cidades values('Lagoa da Canoa',2,'2704104')

insert into cidades values('Limoeiro de Anadia',2,'2704203')

insert into cidades values('Maceió',2,'2704302')

insert into cidades values('Major Isidoro',2,'2704401')

insert into cidades values('Mar Vermelho',2,'2704906')

insert into cidades values('Maragogi',2,'2704500')

insert into cidades values('Maravilha',2,'2704609')

insert into cidades values('Marechal Deodoro',2,'2704708')

insert into cidades values('Maribondo',2,'2704807')

insert into cidades values('Mata Grande',2,'2705002')

insert into cidades values('Matriz de Camaragibe',2,'2705101')

insert into cidades values('Messias',2,'2705200')

insert into cidades values('Minador do Negrão',2,'2705309')

insert into cidades values('Monteirópolis',2,'2705408')

insert into cidades values('Murici',2,'2705507')

insert into cidades values('Novo Lino',2,'2705606')

insert into cidades values('Olho dÁgua das Flores',2,'2705705')

insert into cidades values('Olho dÁgua do Casado',2,'2705804')

insert into cidades values('Olho dÁgua Grande',2,'2705903')

insert into cidades values('Olivença',2,'2706000')

insert into cidades values('Ouro Branco',2,'2706109')

insert into cidades values('Palestina',2,'2706208')

insert into cidades values('Palmeira dos Índios',2,'2706307')

insert into cidades values('Pão de Açúcar',2,'2706406')

insert into cidades values('Pariconha',2,'2706422')

insert into cidades values('Paripueira',2,'2706448')

insert into cidades values('Passo de Camaragibe',2,'2706505')

insert into cidades values('Paulo Jacinto',2,'2706604')

insert into cidades values('Penedo',2,'2706703')

insert into cidades values('Piaçabuçu',2,'2706802')

insert into cidades values('Pilar',2,'2706901')

insert into cidades values('Pindoba',2,'2707008')

insert into cidades values('Piranhas',2,'2707107')

insert into cidades values('Poço das Trincheiras',2,'2707206')

insert into cidades values('Porto Calvo',2,'2707305')

insert into cidades values('Porto de Pedras',2,'2707404')

insert into cidades values('Porto Real do Colégio',2,'2707503')

insert into cidades values('Quebrangulo',2,'2707602')

insert into cidades values('Rio Largo',2,'2707701')

insert into cidades values('Roteiro',2,'2707800')

insert into cidades values('Santa Luzia do Norte',2,'2707909')

insert into cidades values('Santana do Ipanema',2,'2708006')

insert into cidades values('Santana do Mundaú',2,'2708105')

insert into cidades values('São Brás',2,'2708204')

insert into cidades values('São José da Laje',2,'2708303')

insert into cidades values('São José da Tapera',2,'2708402')

insert into cidades values('São Luís do Quitunde',2,'2708501')

insert into cidades values('São Miguel dos Campos',2,'2708600')

insert into cidades values('São Miguel dos Milagres',2,'2708709')

insert into cidades values('São Sebastião',2,'2708808')

insert into cidades values('Satuba',2,'2708907')

insert into cidades values('Senador Rui Palmeira',2,'2708956')

insert into cidades values('Tanque dArca',2,'2709004')

insert into cidades values('Taquarana',2,'2709103')

insert into cidades values('Teotônio Vilela',2,'2709152')

insert into cidades values('Traipu',2,'2709202')

insert into cidades values('União dos Palmares',2,'2709301')

insert into cidades values('Viçosa',2,'2709400')

insert into cidades values('Amapá',4,'1600105')

insert into cidades values('Calçoene',4,'1600204')

insert into cidades values('Cutias',4,'1600212')

insert into cidades values('Ferreira Gomes',4,'1600238')

insert into cidades values('Itaubal',4,'1600253')

insert into cidades values('Laranjal do Jari',4,'1600279')

insert into cidades values('Macapá',4,'1600303')

insert into cidades values('Mazagão',4,'1600402')

insert into cidades values('Oiapoque',4,'1600501')

insert into cidades values('Pedra Branca do Amaparí',4,'1600154')

insert into cidades values('Porto Grande',4,'1600535')

insert into cidades values('Pracuúba',4,'1600550')

insert into cidades values('Santana',4,'1600600')

insert into cidades values('Serra do Navio',4,'1600055')

insert into cidades values('Tartarugalzinho',4,'1600709')

insert into cidades values('Vitória do Jari',4,'1600808')

insert into cidades values('Alvarães',3,'1300029')

insert into cidades values('Amaturá',3,'1300060')

insert into cidades values('Anamã',3,'1300086')

insert into cidades values('Anori',3,'1300102')

insert into cidades values('Apuí',3,'1300144')

insert into cidades values('Atalaia do Norte',3,'1300201')

insert into cidades values('Autazes',3,'1300300')

insert into cidades values('Barcelos',3,'1300409')

insert into cidades values('Barreirinha',3,'1300508')

insert into cidades values('Benjamin Constant',3,'1300607')

insert into cidades values('Beruri',3,'1300631')

insert into cidades values('Boa Vista do Ramos',3,'1300680')

insert into cidades values('Boca do Acre',3,'1300706')

insert into cidades values('Borba',3,'1300805')

insert into cidades values('Caapiranga',3,'1300839')

insert into cidades values('Canutama',3,'1300904')

insert into cidades values('Carauari',3,'1301001')

insert into cidades values('Careiro',3,'1301100')

insert into cidades values('Careiro da Várzea',3,'1301159')

insert into cidades values('Coari',3,'1301209')

insert into cidades values('Codajás',3,'1301308')

insert into cidades values('Eirunepé',3,'1301407')

insert into cidades values('Envira',3,'1301506')

insert into cidades values('Fonte Boa',3,'1301605')

insert into cidades values('Guajará',3,'1301654')

insert into cidades values('Humaitá',3,'1301704')

insert into cidades values('Ipixuna',3,'1301803')

insert into cidades values('Iranduba',3,'1301852')

insert into cidades values('Itacoatiara',3,'1301902')

insert into cidades values('Itamarati',3,'1301951')

insert into cidades values('Itapiranga',3,'1302009')

insert into cidades values('Japurá',3,'1302108')

insert into cidades values('Juruá',3,'1302207')

insert into cidades values('Jutaí',3,'1302306')

insert into cidades values('Lábrea',3,'1302405')

insert into cidades values('Manacapuru',3,'1302504')

insert into cidades values('Manaquiri',3,'1302553')

insert into cidades values('Manaus',3,'1302603')

insert into cidades values('Manicoré',3,'1302702')

insert into cidades values('Maraã',3,'1302801')

insert into cidades values('Maués',3,'1302900')

insert into cidades values('Nhamundá',3,'1303007')

insert into cidades values('Nova Olinda do Norte',3,'1303106')

insert into cidades values('Novo Airão',3,'1303205')

insert into cidades values('Novo Aripuanã',3,'1303304')

insert into cidades values('Parintins',3,'1303403')

insert into cidades values('Pauini',3,'1303502')

insert into cidades values('Presidente Figueiredo',3,'1303536')

insert into cidades values('Rio Preto da Eva',3,'1303569')

insert into cidades values('Santa Isabel do Rio Negro',3,'1303601')

insert into cidades values('Santo Antônio do Içá',3,'1303700')

insert into cidades values('São Gabriel da Cachoeira',3,'1303809')

insert into cidades values('São Paulo de Olivença',3,'1303908')

insert into cidades values('São Sebastião do Uatumã',3,'1303957')

insert into cidades values('Silves',3,'1304005')

insert into cidades values('Tabatinga',3,'1304062')

insert into cidades values('Tapauá',3,'1304104')

insert into cidades values('Tefé',3,'1304203')

insert into cidades values('Tonantins',3,'1304237')

insert into cidades values('Uarini',3,'1304260')

insert into cidades values('Urucará',3,'1304302')

insert into cidades values('Urucurituba',3,'1304401')

insert into cidades values('Abaíra',5,'2900108')

insert into cidades values('Abaré',5,'2900207')

insert into cidades values('Acajutiba',5,'2900306')

insert into cidades values('Adustina',5,'2900355')

insert into cidades values('Água Fria',5,'2900405')

insert into cidades values('Aiquara',5,'2900603')

insert into cidades values('Alagoinhas',5,'2900702')

insert into cidades values('Alcobaça',5,'2900801')

insert into cidades values('Almadina',5,'2900900')

insert into cidades values('Amargosa',5,'2901007')

insert into cidades values('Amélia Rodrigues',5,'2901106')

insert into cidades values('América Dourada',5,'2901155')

insert into cidades values('Anagé',5,'2901205')

insert into cidades values('Andaraí',5,'2901304')

insert into cidades values('Andorinha',5,'2901353')

insert into cidades values('Angical',5,'2901403')

insert into cidades values('Anguera',5,'2901502')

insert into cidades values('Antas',5,'2901601')

insert into cidades values('Antônio Cardoso',5,'2901700')

insert into cidades values('Antônio Gonçalves',5,'2901809')

insert into cidades values('Aporá',5,'2901908')

insert into cidades values('Apuarema',5,'2901957')

insert into cidades values('Araças',5,'2902054')

insert into cidades values('Aracatu',5,'2902005')

insert into cidades values('Araci',5,'2902104')

insert into cidades values('Aramari',5,'2902203')

insert into cidades values('Arataca',5,'2902252')

insert into cidades values('Aratuípe',5,'2902302')

insert into cidades values('Aurelino Leal',5,'2902401')

insert into cidades values('Baianópolis',5,'2902500')

insert into cidades values('Baixa Grande',5,'2902609')

insert into cidades values('Banzaê',5,'2902658')

insert into cidades values('Barra',5,'2902708')

insert into cidades values('Barra da Estiva',5,'2902807')

insert into cidades values('Barra do Choça',5,'2902906')

insert into cidades values('Barra do Mendes',5,'2903003')

insert into cidades values('Barra do Rocha',5,'2903102')

insert into cidades values('Barreiras',5,'2903201')

insert into cidades values('Barro Alto',5,'2903235')

insert into cidades values('Barro Preto antigo Gov. Lomanto Jr.',5,'2903300')

insert into cidades values('Barrocas',5,'2903276')

insert into cidades values('Belmonte',5,'2903409')

insert into cidades values('Belo Campo',5,'2903508')

insert into cidades values('Biritinga',5,'2903607')

insert into cidades values('Boa Nova',5,'2903706')

insert into cidades values('Boa Vista do Tupim',5,'2903805')

insert into cidades values('Bom Jesus da Lapa',5,'2903904')

insert into cidades values('Bom Jesus da Serra',5,'2903953')

insert into cidades values('Boninal',5,'2904001')

insert into cidades values('Bonito',5,'2904050')

insert into cidades values('Boquira',5,'2904100')

insert into cidades values('Botuporã',5,'2904209')

insert into cidades values('Brejões',5,'2904308')

insert into cidades values('Brejolândia',5,'2904407')

insert into cidades values('Brotas de Macaúbas',5,'2904506')

insert into cidades values('Brumado',5,'2904605')

insert into cidades values('Buerarema',5,'2904704')

insert into cidades values('Buritirama',5,'2904753')

insert into cidades values('Caatiba',5,'2904803')

insert into cidades values('Cabaceiras do Paraguaçu',5,'2904852')

insert into cidades values('Cachoeira',5,'2904902')

insert into cidades values('Caculé',5,'2905008')

insert into cidades values('Caém',5,'2905107')

insert into cidades values('Caetanos',5,'2905156')

insert into cidades values('Caetité',5,'2905206')

insert into cidades values('Cafarnaum',5,'2905305')

insert into cidades values('Cairu',5,'2905404')

insert into cidades values('Caldeirão Grande',5,'2905503')

insert into cidades values('Camacan',5,'2905602')

insert into cidades values('Camaçari',5,'2905701')

insert into cidades values('Camamu',5,'2905800')

insert into cidades values('Campo Alegre de Lourdes',5,'2905909')

insert into cidades values('Campo Formoso',5,'2906006')

insert into cidades values('Canápolis',5,'2906105')

insert into cidades values('Canarana',5,'2906204')

insert into cidades values('Canavieiras',5,'2906303')

insert into cidades values('Candeal',5,'2906402')

insert into cidades values('Candeias',5,'2906501')

insert into cidades values('Candiba',5,'2906600')

insert into cidades values('Cândido Sales',5,'2906709')

insert into cidades values('Cansanção',5,'2906808')

insert into cidades values('Canudos',5,'2906824')

insert into cidades values('Capela do Alto Alegre',5,'2906857')

insert into cidades values('Capim Grosso',5,'2906873')

insert into cidades values('Caraíbas',5,'2906899')

insert into cidades values('Caravelas',5,'2906907')

insert into cidades values('Cardeal da Silva',5,'2907004')

insert into cidades values('Carinhanha',5,'2907103')

insert into cidades values('Casa Nova',5,'2907202')

insert into cidades values('Castro Alves',5,'2907301')

insert into cidades values('Catolândia',5,'2907400')

insert into cidades values('Catu',5,'2907509')

insert into cidades values('Caturama',5,'2907558')

insert into cidades values('Central',5,'2907608')

insert into cidades values('Chorrochó',5,'2907707')

insert into cidades values('Cícero Dantas',5,'2907806')

insert into cidades values('Cipó',5,'2907905')

insert into cidades values('Coaraci',5,'2908002')

insert into cidades values('Cocos',5,'2908101')

insert into cidades values('Conceição da Feira',5,'2908200')

insert into cidades values('Conceição do Almeida',5,'2908309')

insert into cidades values('Conceição do Coité',5,'2908408')

insert into cidades values('Conceição do Jacuípe',5,'2908507')

insert into cidades values('Conde',5,'2908606')

insert into cidades values('Condeúba',5,'2908705')

insert into cidades values('Contendas do Sincorá',5,'2908804')

insert into cidades values('Coração de Maria',5,'2908903')

insert into cidades values('Cordeiros',5,'2909000')

insert into cidades values('Coribe',5,'2909109')

insert into cidades values('Coronel João Sá',5,'2909208')

insert into cidades values('Correntina',5,'2909307')

insert into cidades values('Cotegipe',5,'2909406')

insert into cidades values('Cravolândia',5,'2909505')

insert into cidades values('Crisópolis',5,'2909604')

insert into cidades values('Cristópolis',5,'2909703')

insert into cidades values('Cruz das Almas',5,'2909802')

insert into cidades values('Curaçá',5,'2909901')

insert into cidades values('Dário Meira',5,'2910008')

insert into cidades values('Dias dÁvila',5,'2910057')

insert into cidades values('Dom Basílio',5,'2910107')

insert into cidades values('Dom Macedo Costa',5,'2910206')

insert into cidades values('Elísio Medrado',5,'2910305')

insert into cidades values('Encruzilhada',5,'2910404')

insert into cidades values('Entre Rios',5,'2910503')

insert into cidades values('Érico Cardoso',5,'2900504')

insert into cidades values('Esplanada',5,'2910602')

insert into cidades values('Euclides da Cunha',5,'2910701')

insert into cidades values('Eunápolis',5,'2910727')

insert into cidades values('Fátima',5,'2910750')

insert into cidades values('Feira da Mata',5,'2910776')

insert into cidades values('Feira de Santana',5,'2910800')

insert into cidades values('Filadélfia',5,'2910859')

insert into cidades values('Firmino Alves',5,'2910909')

insert into cidades values('Floresta Azul',5,'2911006')

insert into cidades values('Formosa do Rio Preto',5,'2911105')

insert into cidades values('Gandu',5,'2911204')

insert into cidades values('Gavião',5,'2911253')

insert into cidades values('Gentio do Ouro',5,'2911303')

insert into cidades values('Glória',5,'2911402')

insert into cidades values('Gongogi',5,'2911501')

insert into cidades values('Governador Mangabeira',5,'2911600')

insert into cidades values('Guajeru',5,'2911659')

insert into cidades values('Guanambi',5,'2911709')

insert into cidades values('Guaratinga',5,'2911808')

insert into cidades values('Heliópolis',5,'2911857')

insert into cidades values('Iaçu',5,'2911907')

insert into cidades values('Ibiassucê',5,'2912004')

insert into cidades values('Ibicaraí',5,'2912103')

insert into cidades values('Ibicoara',5,'2912202')

insert into cidades values('Ibicuí',5,'2912301')

insert into cidades values('Ibipeba',5,'2912400')

insert into cidades values('Ibipitanga',5,'2912509')

insert into cidades values('Ibiquera',5,'2912608')

insert into cidades values('Ibirapitanga',5,'2912707')

insert into cidades values('Ibirapuã',5,'2912806')

insert into cidades values('Ibirataia',5,'2912905')

insert into cidades values('Ibitiara',5,'2913002')

insert into cidades values('Ibititá',5,'2913101')

insert into cidades values('Ibotirama',5,'2913200')

insert into cidades values('Ichu',5,'2913309')

insert into cidades values('Igaporã',5,'2913408')

insert into cidades values('Igrapiúna',5,'2913457')

insert into cidades values('Iguaí',5,'2913507')

insert into cidades values('Ilhéus',5,'2913606')

insert into cidades values('Inhambupe',5,'2913705')

insert into cidades values('Ipecaetá',5,'2913804')

insert into cidades values('Ipiaú',5,'2913903')

insert into cidades values('Ipirá',5,'2914000')

insert into cidades values('Ipupiara',5,'2914109')

insert into cidades values('Irajuba',5,'2914208')

insert into cidades values('Iramaia',5,'2914307')

insert into cidades values('Iraquara',5,'2914406')

insert into cidades values('Irará',5,'2914505')

insert into cidades values('Irecê',5,'2914604')

insert into cidades values('Itabela',5,'2914653')

insert into cidades values('Itaberaba',5,'2914703')

insert into cidades values('Itabuna',5,'2914802')

insert into cidades values('Itacaré',5,'2914901')

insert into cidades values('Itaeté',5,'2915007')

insert into cidades values('Itagi',5,'2915106')

insert into cidades values('Itagibá',5,'2915205')

insert into cidades values('Itagimirim',5,'2915304')

insert into cidades values('Itaguaçu da Bahia',5,'2915353')

insert into cidades values('Itaju do Colônia',5,'2915403')

insert into cidades values('Itajuípe',5,'2915502')

insert into cidades values('Itamaraju',5,'2915601')

insert into cidades values('Itamari',5,'2915700')

insert into cidades values('Itambé',5,'2915809')

insert into cidades values('Itanagra',5,'2915908')

insert into cidades values('Itanhém',5,'2916005')

insert into cidades values('Itaparica',5,'2916104')

insert into cidades values('Itapé',5,'2916203')

insert into cidades values('Itapebi',5,'2916302')

insert into cidades values('Itapetinga',5,'2916401')

insert into cidades values('Itapicuru',5,'2916500')

insert into cidades values('Itapitanga',5,'2916609')

insert into cidades values('Itaquara',5,'2916708')

insert into cidades values('Itarantim',5,'2916807')

insert into cidades values('Itatim',5,'2916856')

insert into cidades values('Itiruçu',5,'2916906')

insert into cidades values('Itiúba',5,'2917003')

insert into cidades values('Itororó',5,'2917102')

insert into cidades values('Ituaçu',5,'2917201')

insert into cidades values('Ituberá',5,'2917300')

insert into cidades values('Iuiú',5,'2917334')

insert into cidades values('Jaborandi',5,'2917359')

insert into cidades values('Jacaraci',5,'2917409')

insert into cidades values('Jacobina',5,'2917508')

insert into cidades values('Jaguaquara',5,'2917607')

insert into cidades values('Jaguarari',5,'2917706')

insert into cidades values('Jaguaripe',5,'2917805')

insert into cidades values('Jandaíra',5,'2917904')

insert into cidades values('Jequié',5,'2918001')

insert into cidades values('Jeremoabo',5,'2918100')

insert into cidades values('Jiquiriçá',5,'2918209')

insert into cidades values('Jitaúna',5,'2918308')

insert into cidades values('João Dourado',5,'2918357')

insert into cidades values('Juazeiro',5,'2918407')

insert into cidades values('Jucuruçu',5,'2918456')

insert into cidades values('Jussara',5,'2918506')

insert into cidades values('Jussari',5,'2918555')

insert into cidades values('Jussiape',5,'2918605')

insert into cidades values('Lafaiete Coutinho',5,'2918704')

insert into cidades values('Lagoa Real',5,'2918753')

insert into cidades values('Laje',5,'2918803')

insert into cidades values('Lajedão',5,'2918902')

insert into cidades values('Lajedinho',5,'2919009')

insert into cidades values('Lajedo do Tabocal',5,'2919058')

insert into cidades values('Lamarão',5,'2919108')

insert into cidades values('Lapão',5,'2919157')

insert into cidades values('Lauro de Freitas',5,'2919207')

insert into cidades values('Lençóis',5,'2919306')

insert into cidades values('Licínio de Almeida',5,'2919405')

insert into cidades values('Livramento de Nossa Senhora',5,'2919504')

insert into cidades values('Luís Eduardo Magalhães',5,'2919553')

insert into cidades values('Macajuba',5,'2919603')

insert into cidades values('Macarani',5,'2919702')

insert into cidades values('Macaúbas',5,'2919801')

insert into cidades values('Macururé',5,'2919900')

insert into cidades values('Madre de Deus',5,'2919926')

insert into cidades values('Maetinga',5,'2919959')

insert into cidades values('Maiquinique',5,'2920007')

insert into cidades values('Mairi',5,'2920106')

insert into cidades values('Malhada',5,'2920205')

insert into cidades values('Malhada de Pedras',5,'2920304')

insert into cidades values('Manoel Vitorino',5,'2920403')

insert into cidades values('Mansidão',5,'2920452')

insert into cidades values('Maracás',5,'2920502')

insert into cidades values('Maragogipe',5,'2920601')

insert into cidades values('Maraú',5,'2920700')

insert into cidades values('Marcionílio Souza',5,'2920809')

insert into cidades values('Mascote',5,'2920908')

insert into cidades values('Mata de São João',5,'2921005')

insert into cidades values('Matina',5,'2921054')

insert into cidades values('Medeiros Neto',5,'2921104')

insert into cidades values('Miguel Calmon',5,'2921203')

insert into cidades values('Milagres',5,'2921302')

insert into cidades values('Mirangaba',5,'2921401')

insert into cidades values('Mirante',5,'2921450')

insert into cidades values('Monte Santo',5,'2921500')

insert into cidades values('Morpará',5,'2921609')

insert into cidades values('Morro do Chapéu',5,'2921708')

insert into cidades values('Mortugaba',5,'2921807')

insert into cidades values('Mucugê',5,'2921906')

insert into cidades values('Mucuri',5,'2922003')

insert into cidades values('Mulungu do Morro',5,'2922052')

insert into cidades values('Mundo Novo',5,'2922102')

insert into cidades values('Muniz Ferreira',5,'2922201')

insert into cidades values('Muquém de São Francisco',5,'2922250')

insert into cidades values('Muritiba',5,'2922300')

insert into cidades values('Mutuípe',5,'2922409')

insert into cidades values('Nazaré',5,'2922508')

insert into cidades values('Nilo Peçanha',5,'2922607')

insert into cidades values('Nordestina',5,'2922656')

insert into cidades values('Nova Canaã',5,'2922706')

insert into cidades values('Nova Fátima',5,'2922730')

insert into cidades values('Nova Ibiá',5,'2922755')

insert into cidades values('Nova Itarana',5,'2922805')

insert into cidades values('Nova Redenção',5,'2922854')

insert into cidades values('Nova Soure',5,'2922904')

insert into cidades values('Nova Viçosa',5,'2923001')

insert into cidades values('Novo Horizonte',5,'2923035')

insert into cidades values('Novo Triunfo',5,'2923050')

insert into cidades values('Olindina',5,'2923100')

insert into cidades values('Oliveira dos Brejinhos',5,'2923209')

insert into cidades values('Ouriçangas',5,'2923308')

insert into cidades values('Ourolândia',5,'2923357')

insert into cidades values('Palmas de Monte Alto',5,'2923407')

insert into cidades values('Palmeiras',5,'2923506')

insert into cidades values('Paramirim',5,'2923605')

insert into cidades values('Paratinga',5,'2923704')

insert into cidades values('Paripiranga',5,'2923803')

insert into cidades values('Pau Brasil',5,'2923902')

insert into cidades values('Paulo Afonso',5,'2924009')

insert into cidades values('Pé de Serra',5,'2924058')

insert into cidades values('Pedrão',5,'2924108')

insert into cidades values('Pedro Alexandre',5,'2924207')

insert into cidades values('Piatã',5,'2924306')

insert into cidades values('Pilão Arcado',5,'2924405')

insert into cidades values('Pindaí',5,'2924504')

insert into cidades values('Pindobaçu',5,'2924603')

insert into cidades values('Pintadas',5,'2924652')

insert into cidades values('Piraí do Norte',5,'2924678')

insert into cidades values('Piripá',5,'2924702')

insert into cidades values('Piritiba',5,'2924801')

insert into cidades values('Planaltino',5,'2924900')

insert into cidades values('Planalto',5,'2925006')

insert into cidades values('Poções',5,'2925105')

insert into cidades values('Pojuca',5,'2925204')

insert into cidades values('Ponto Novo',5,'2925253')

insert into cidades values('Porto Seguro',5,'2925303')

insert into cidades values('Potiraguá',5,'2925402')

insert into cidades values('Prado',5,'2925501')

insert into cidades values('Presidente Dutra',5,'2925600')

insert into cidades values('Presidente Jânio Quadros',5,'2925709')

insert into cidades values('Presidente Tancredo Neves',5,'2925758')

insert into cidades values('Queimadas',5,'2925808')

insert into cidades values('Quijingue',5,'2925907')

insert into cidades values('Quixabeira',5,'2925931')

insert into cidades values('Rafael Jambeiro',5,'2925956')

insert into cidades values('Remanso',5,'2926004')

insert into cidades values('Retirolândia',5,'2926103')

insert into cidades values('Riachão das Neves',5,'2926202')

insert into cidades values('Riachão do Jacuípe',5,'2926301')

insert into cidades values('Riacho de Santana',5,'2926400')

insert into cidades values('Ribeira do Amparo',5,'2926509')

insert into cidades values('Ribeira do Pombal',5,'2926608')

insert into cidades values('Ribeirão do Largo',5,'2926657')

insert into cidades values('Rio de Contas',5,'2926707')

insert into cidades values('Rio do Antônio',5,'2926806')

insert into cidades values('Rio do Pires',5,'2926905')

insert into cidades values('Rio Real',5,'2927002')

insert into cidades values('Rodelas',5,'2927101')

insert into cidades values('Ruy Barbosa',5,'2927200')

insert into cidades values('Salinas da Margarida',5,'2927309')

insert into cidades values('Salvador',5,'2927408')

insert into cidades values('Santa Bárbara',5,'2927507')

insert into cidades values('Santa Brígida',5,'2927606')

insert into cidades values('Santa Cruz Cabrália',5,'2927705')

insert into cidades values('Santa Cruz da Vitória',5,'2927804')

insert into cidades values('Santa Inês',5,'2927903')

insert into cidades values('Santa Luzia',5,'2928059')

insert into cidades values('Santa Maria da Vitória',5,'2928109')

insert into cidades values('Santa Rita de Cássia',5,'2928406')

insert into cidades values('Santa Teresinha',5,'2928505')

insert into cidades values('Santaluz',5,'2928000')

insert into cidades values('Santana',5,'2928208')

insert into cidades values('Santanópolis',5,'2928307')

insert into cidades values('Santo Amaro',5,'2928604')

insert into cidades values('Santo Antônio de Jesus',5,'2928703')

insert into cidades values('Santo Estêvão',5,'2928802')

insert into cidades values('São Desidério',5,'2928901')

insert into cidades values('São Domingos',5,'2928950')

insert into cidades values('São Felipe',5,'2929107')

insert into cidades values('São Félix',5,'2929008')

insert into cidades values('São Félix do Coribe',5,'2929057')

insert into cidades values('São Francisco do Conde',5,'2929206')

insert into cidades values('São Gabriel',5,'2929255')

insert into cidades values('São Gonçalo dos Campos',5,'2929305')

insert into cidades values('São José da Vitória',5,'2929354')

insert into cidades values('São José do Jacuípe',5,'2929370')

insert into cidades values('São Miguel das Matas',5,'2929404')

insert into cidades values('São Sebastião do Passé',5,'2929503')

insert into cidades values('Sapeaçu',5,'2929602')

insert into cidades values('Sátiro Dias',5,'2929701')

insert into cidades values('Saubara',5,'2929750')

insert into cidades values('Saúde',5,'2929800')

insert into cidades values('Seabra',5,'2929909')

insert into cidades values('Sebastião Laranjeiras',5,'2930006')

insert into cidades values('Senhor do Bonfim',5,'2930105')

insert into cidades values('Sento Sé',5,'2930204')

insert into cidades values('Serra do Ramalho',5,'2930154')

insert into cidades values('Serra Dourada',5,'2930303')

insert into cidades values('Serra Preta',5,'2930402')

insert into cidades values('Serrinha',5,'2930501')

insert into cidades values('Serrolândia',5,'2930600')

insert into cidades values('Simões Filho',5,'2930709')

insert into cidades values('Sítio do Mato',5,'2930758')

insert into cidades values('Sítio do Quinto',5,'2930766')

insert into cidades values('Sobradinho',5,'2930774')

insert into cidades values('Souto Soares',5,'2930808')

insert into cidades values('Tabocas do Brejo Velho',5,'2930907')

insert into cidades values('Tanhaçu',5,'2931004')

insert into cidades values('Tanque Novo',5,'2931053')

insert into cidades values('Tanquinho',5,'2931103')

insert into cidades values('Taperoá',5,'2931202')

insert into cidades values('Tapiramutá',5,'2931301')

insert into cidades values('Teixeira de Freitas',5,'2931350')

insert into cidades values('Teodoro Sampaio',5,'2931400')

insert into cidades values('Teofilândia',5,'2931509')

insert into cidades values('Teolândia',5,'2931608')

insert into cidades values('Terra Nova',5,'2931707')

insert into cidades values('Tremedal',5,'2931806')

insert into cidades values('Tucano',5,'2931905')

insert into cidades values('Uauá',5,'2932002')

insert into cidades values('Ubaíra',5,'2932101')

insert into cidades values('Ubaitaba',5,'2932200')

insert into cidades values('Ubatã',5,'2932309')

insert into cidades values('Uibaí',5,'2932408')

insert into cidades values('Umburanas',5,'2932457')

insert into cidades values('Una',5,'2932507')

insert into cidades values('Urandi',5,'2932606')

insert into cidades values('Uruçuca',5,'2932705')

insert into cidades values('Utinga',5,'2932804')

insert into cidades values('Valença',5,'2932903')

insert into cidades values('Valente',5,'2933000')

insert into cidades values('Várzea da Roça',5,'2933059')

insert into cidades values('Várzea do Poço',5,'2933109')

insert into cidades values('Várzea Nova',5,'2933158')

insert into cidades values('Varzedo',5,'2933174')

insert into cidades values('Vera Cruz',5,'2933208')

insert into cidades values('Vereda',5,'2933257')

insert into cidades values('Vitória da Conquista',5,'2933307')

insert into cidades values('Wagner',5,'2933406')

insert into cidades values('Wanderley',5,'2933455')

insert into cidades values('Wenceslau Guimarães',5,'2933505')

insert into cidades values('Xique-Xique',5,'2933604')

insert into cidades values('Abaiara',6,'2300101')

insert into cidades values('Acarape',6,'2300150')

insert into cidades values('Acaraú',6,'2300200')

insert into cidades values('Acopiara',6,'2300309')

insert into cidades values('Aiuaba',6,'2300408')

insert into cidades values('Alcântaras',6,'2300507')

insert into cidades values('Altaneira',6,'2300606')

insert into cidades values('Alto Santo',6,'2300705')

insert into cidades values('Amontada',6,'2300754')

insert into cidades values('Antonina do Norte',6,'2300804')

insert into cidades values('Apuiarés',6,'2300903')

insert into cidades values('Aquiraz',6,'2301000')

insert into cidades values('Aracati',6,'2301109')

insert into cidades values('Aracoiaba',6,'2301208')

insert into cidades values('Ararendá',6,'2301257')

insert into cidades values('Araripe',6,'2301307')

insert into cidades values('Aratuba',6,'2301406')

insert into cidades values('Arneiroz',6,'2301505')

insert into cidades values('Assaré',6,'2301604')

insert into cidades values('Aurora',6,'2301703')

insert into cidades values('Baixio',6,'2301802')

insert into cidades values('Banabuiú',6,'2301851')

insert into cidades values('Barbalha',6,'2301901')

insert into cidades values('Barreira',6,'2301950')

insert into cidades values('Barro',6,'2302008')

insert into cidades values('Barroquinha',6,'2302057')

insert into cidades values('Baturité',6,'2302107')

insert into cidades values('Beberibe',6,'2302206')

insert into cidades values('Bela Cruz',6,'2302305')

insert into cidades values('Boa Viagem',6,'2302404')

insert into cidades values('Brejo Santo',6,'2302503')

insert into cidades values('Camocim',6,'2302602')

insert into cidades values('Campos Sales',6,'2302701')

insert into cidades values('Canindé',6,'2302800')

insert into cidades values('Capistrano',6,'2302909')

insert into cidades values('Caridade',6,'2303006')

insert into cidades values('Cariré',6,'2303105')

insert into cidades values('Caririaçu',6,'2303204')

insert into cidades values('Cariús',6,'2303303')

insert into cidades values('Carnaubal',6,'2303402')

insert into cidades values('Cascavel',6,'2303501')

insert into cidades values('Catarina',6,'2303600')

insert into cidades values('Catunda',6,'2303659')

insert into cidades values('Caucaia',6,'2303709')

insert into cidades values('Cedro',6,'2303808')

insert into cidades values('Chaval',6,'2303907')

insert into cidades values('Choró',6,'2303931')

insert into cidades values('Chorozinho',6,'2303956')

insert into cidades values('Coreaú',6,'2304004')

insert into cidades values('Crateús',6,'2304103')

insert into cidades values('Crato',6,'2304202')

insert into cidades values('Croatá',6,'2304236')

insert into cidades values('Cruz',6,'2304251')

insert into cidades values('Deputado Irapuan Pinheiro',6,'2304269')

insert into cidades values('Ererê',6,'2304277')

insert into cidades values('Eusébio',6,'2304285')

insert into cidades values('Farias Brito',6,'2304301')

insert into cidades values('Forquilha',6,'2304350')

insert into cidades values('Fortaleza',6,'2304400')

insert into cidades values('Fortim',6,'2304459')

insert into cidades values('Frecheirinha',6,'2304509')

insert into cidades values('General Sampaio',6,'2304608')

insert into cidades values('Graça',6,'2304657')

insert into cidades values('Granja',6,'2304707')

insert into cidades values('Granjeiro',6,'2304806')

insert into cidades values('Groaíras',6,'2304905')

insert into cidades values('Guaiúba',6,'2304954')

insert into cidades values('Guaraciaba do Norte',6,'2305001')

insert into cidades values('Guaramiranga',6,'2305100')

insert into cidades values('Hidrolândia',6,'2305209')

insert into cidades values('Horizonte',6,'2305233')

insert into cidades values('Ibaretama',6,'2305266')

insert into cidades values('Ibiapina',6,'2305308')

insert into cidades values('Ibicuitinga',6,'2305332')

insert into cidades values('Icapuí',6,'2305357')

insert into cidades values('Icó',6,'2305407')

insert into cidades values('Iguatu',6,'2305506')

insert into cidades values('Independência',6,'2305605')

insert into cidades values('Ipaporanga',6,'2305654')

insert into cidades values('Ipaumirim',6,'2305704')

insert into cidades values('Ipu',6,'2305803')

insert into cidades values('Ipueiras',6,'2305902')

insert into cidades values('Iracema',6,'2306009')

insert into cidades values('Irauçuba',6,'2306108')

insert into cidades values('Itaiçaba',6,'2306207')

insert into cidades values('Itaitinga',6,'2306256')

insert into cidades values('Itapagé',6,'2306306')

insert into cidades values('Itapipoca',6,'2306405')

insert into cidades values('Itapiúna',6,'2306504')

insert into cidades values('Itarema',6,'2306553')

insert into cidades values('Itatira',6,'2306603')

insert into cidades values('Jaguaretama',6,'2306702')

insert into cidades values('Jaguaribara',6,'2306801')

insert into cidades values('Jaguaribe',6,'2306900')

insert into cidades values('Jaguaruana',6,'2307007')

insert into cidades values('Jardim',6,'2307106')

insert into cidades values('Jati',6,'2307205')

insert into cidades values('Jijoca de Jericoacoara',6,'2307254')

insert into cidades values('Juazeiro do Norte',6,'2307304')

insert into cidades values('Jucás',6,'2307403')

insert into cidades values('Lavras da Mangabeira',6,'2307502')

insert into cidades values('Limoeiro do Norte',6,'2307601')

insert into cidades values('Madalena',6,'2307635')

insert into cidades values('Maracanaú',6,'2307650')

insert into cidades values('Maranguape',6,'2307700')

insert into cidades values('Marco',6,'2307809')

insert into cidades values('Martinópole',6,'2307908')

insert into cidades values('Massapê',6,'2308005')

insert into cidades values('Mauriti',6,'2308104')

insert into cidades values('Meruoca',6,'2308203')

insert into cidades values('Milagres',6,'2308302')

insert into cidades values('Milhã',6,'2308351')

insert into cidades values('Miraíma',6,'2308377')

insert into cidades values('Missão Velha',6,'2308401')

insert into cidades values('Mombaça',6,'2308500')

insert into cidades values('Monsenhor Tabosa',6,'2308609')

insert into cidades values('Morada Nova',6,'2308708')

insert into cidades values('Moraújo',6,'2308807')

insert into cidades values('Morrinhos',6,'2308906')

insert into cidades values('Mucambo',6,'2309003')

insert into cidades values('Mulungu',6,'2309102')

insert into cidades values('Nova Olinda',6,'2309201')

insert into cidades values('Nova Russas',6,'2309300')

insert into cidades values('Novo Oriente',6,'2309409')

insert into cidades values('Ocara',6,'2309458')

insert into cidades values('Orós',6,'2309508')

insert into cidades values('Pacajus',6,'2309607')

insert into cidades values('Pacatuba',6,'2309706')

insert into cidades values('Pacoti',6,'2309805')

insert into cidades values('Pacujá',6,'2309904')

insert into cidades values('Palhano',6,'2310001')

insert into cidades values('Palmácia',6,'2310100')

insert into cidades values('Paracuru',6,'2310209')

insert into cidades values('Paraipaba',6,'2310258')

insert into cidades values('Parambu',6,'2310308')

insert into cidades values('Paramoti',6,'2310407')

insert into cidades values('Pedra Branca',6,'2310506')

insert into cidades values('Penaforte',6,'2310605')

insert into cidades values('Pentecoste',6,'2310704')

insert into cidades values('Pereiro',6,'2310803')

insert into cidades values('Pindoretama',6,'2310852')

insert into cidades values('Piquet Carneiro',6,'2310902')

insert into cidades values('Pires Ferreira',6,'2310951')

insert into cidades values('Poranga',6,'2311009')

insert into cidades values('Porteiras',6,'2311108')

insert into cidades values('Potengi',6,'2311207')

insert into cidades values('Potiretama',6,'2311231')

insert into cidades values('Quiterianópolis',6,'2311264')

insert into cidades values('Quixadá',6,'2311306')

insert into cidades values('Quixelô',6,'2311355')

insert into cidades values('Quixeramobim',6,'2311405')

insert into cidades values('Quixeré',6,'2311504')

insert into cidades values('Redenção',6,'2311603')

insert into cidades values('Reriutaba',6,'2311702')

insert into cidades values('Russas',6,'2311801')

insert into cidades values('Saboeiro',6,'2311900')

insert into cidades values('Salitre',6,'2311959')

insert into cidades values('Santa Quitéria',6,'2312205')

insert into cidades values('Santana do Acaraú',6,'2312007')

insert into cidades values('Santana do Cariri',6,'2312106')

insert into cidades values('São Benedito',6,'2312304')

insert into cidades values('São Gonçalo do Amarante',6,'2312403')

insert into cidades values('São João do Jaguaribe',6,'2312502')

insert into cidades values('São Luís do Curu',6,'2312601')

insert into cidades values('Senador Pompeu',6,'2312700')

insert into cidades values('Senador Sá',6,'2312809')

insert into cidades values('Sobral',6,'2312908')

insert into cidades values('Solonópole',6,'2313005')

insert into cidades values('Tabuleiro do Norte',6,'2313104')

insert into cidades values('Tamboril',6,'2313203')

insert into cidades values('Tarrafas',6,'2313252')

insert into cidades values('Tauá',6,'2313302')

insert into cidades values('Tejuçuoca',6,'2313351')

insert into cidades values('Tianguá',6,'2313401')

insert into cidades values('Trairi',6,'2313500')

insert into cidades values('Tururu',6,'2313559')

insert into cidades values('Ubajara',6,'2313609')

insert into cidades values('Umari',6,'2313708')

insert into cidades values('Umirim',6,'2313757')

insert into cidades values('Uruburetama',6,'2313807')

insert into cidades values('Uruoca',6,'2313906')

insert into cidades values('Varjota',6,'2313955')

insert into cidades values('Várzea Alegre',6,'2314003')

insert into cidades values('Viçosa do Ceará',6,'2314102')

insert into cidades values('Brasília',7,'5300108')

insert into cidades values('Abadia de Goiás',9,'5200050')

insert into cidades values('Abadiânia',9,'5200100')

insert into cidades values('Acreúna',9,'5200134')

insert into cidades values('Adelândia',9,'5200159')

insert into cidades values('Água Fria de Goiás',9,'5200175')

insert into cidades values('Água Limpa',9,'5200209')

insert into cidades values('Águas Lindas de Goiás',9,'5200258')

insert into cidades values('Alexânia',9,'5200308')

insert into cidades values('Aloândia',9,'5200506')

insert into cidades values('Alto Horizonte',9,'5200555')

insert into cidades values('Alto Paraíso de Goiás',9,'5200605')

insert into cidades values('Alvorada do Norte',9,'5200803')

insert into cidades values('Amaralina',9,'5200829')

insert into cidades values('Americano do Brasil',9,'5200852')

insert into cidades values('Amorinópolis',9,'5200902')

insert into cidades values('Anápolis',9,'5201108')

insert into cidades values('Anhanguera',9,'5201207')

insert into cidades values('Anicuns',9,'5201306')

insert into cidades values('Aparecida de Goiânia',9,'5201405')

insert into cidades values('Aparecida do Rio Doce',9,'5201454')

insert into cidades values('Aporé',9,'5201504')

insert into cidades values('Araçu',9,'5201603')

insert into cidades values('Aragarças',9,'5201702')

insert into cidades values('Aragoiânia',9,'5201801')

insert into cidades values('Araguapaz',9,'5202155')

insert into cidades values('Arenópolis',9,'5202353')

insert into cidades values('Aruanã',9,'5202502')

insert into cidades values('Aurilândia',9,'5202601')

insert into cidades values('Avelinópolis',9,'5202809')

insert into cidades values('Baliza',9,'5203104')

insert into cidades values('Barro Alto',9,'5203203')

insert into cidades values('Bela Vista de Goiás',9,'5203302')

insert into cidades values('Bom Jardim de Goiás',9,'5203401')

insert into cidades values('Bom Jesus de Goiás',9,'5203500')

insert into cidades values('Bonfinópolis',9,'5203559')

insert into cidades values('Bonópolis',9,'5203575')

insert into cidades values('Brazabrantes',9,'5203609')

insert into cidades values('Britânia',9,'5203807')

insert into cidades values('Buriti Alegre',9,'5203906')

insert into cidades values('Buriti de Goiás',9,'5203939')

insert into cidades values('Buritinópolis',9,'5203962')

insert into cidades values('Cabeceiras',9,'5204003')

insert into cidades values('Cachoeira Alta',9,'5204102')

insert into cidades values('Cachoeira de Goiás',9,'5204201')

insert into cidades values('Cachoeira Dourada',9,'5204250')

insert into cidades values('Caçu',9,'5204300')

insert into cidades values('Caiapônia',9,'5204409')

insert into cidades values('Caldas Novas',9,'5204508')

insert into cidades values('Caldazinha',9,'5204557')

insert into cidades values('Campestre de Goiás',9,'5204607')

insert into cidades values('Campinaçu',9,'5204656')

insert into cidades values('Campinorte',9,'5204706')

insert into cidades values('Campo Alegre de Goiás',9,'5204805')

insert into cidades values('Campo Limpo de Goiás',9,'5204854')

insert into cidades values('Campos Belos',9,'5204904')

insert into cidades values('Campos Verdes',9,'5204953')

insert into cidades values('Carmo do Rio Verde',9,'5205000')

insert into cidades values('Castelândia',9,'5205059')

insert into cidades values('Catalão',9,'5205109')

insert into cidades values('Caturaí',9,'5205208')

insert into cidades values('Cavalcante',9,'5205307')

insert into cidades values('Ceres',9,'5205406')

insert into cidades values('Cezarina',9,'5205455')

insert into cidades values('Chapadão do Céu',9,'5205471')

insert into cidades values('cidades Ocidental',9,'5205497')

insert into cidades values('Cocalzinho de Goiás',9,'5205513')

insert into cidades values('Colinas do Sul',9,'5205521')

insert into cidades values('Córrego do Ouro',9,'5205703')

insert into cidades values('Corumbá de Goiás',9,'5205802')

insert into cidades values('Corumbaíba',9,'5205901')

insert into cidades values('Cristalina',9,'5206206')

insert into cidades values('Cristianópolis',9,'5206305')

insert into cidades values('Crixás',9,'5206404')

insert into cidades values('Cromínia',9,'5206503')

insert into cidades values('Cumari',9,'5206602')

insert into cidades values('Damianópolis',9,'5206701')

insert into cidades values('Damolândia',9,'5206800')

insert into cidades values('Davinópolis',9,'5206909')

insert into cidades values('Diorama',9,'5207105')

insert into cidades values('Divinópolis de Goiás',9,'5208301')

insert into cidades values('Doverlândia',9,'5207253')

insert into cidades values('Edealina',9,'5207352')

insert into cidades values('Edéia',9,'5207402')

insert into cidades values('Estrela do Norte',9,'5207501')

insert into cidades values('Faina',9,'5207535')

insert into cidades values('Fazenda Nova',9,'5207600')

insert into cidades values('Firminópolis',9,'5207808')

insert into cidades values('Flores de Goiás',9,'5207907')

insert into cidades values('Formosa',9,'5208004')

insert into cidades values('Formoso',9,'5208103')

insert into cidades values('Gameleira de Goiás',9,'5208152')

insert into cidades values('Goianápolis',9,'5208400')

insert into cidades values('Goiandira',9,'5208509')

insert into cidades values('Goianésia',9,'5208608')

insert into cidades values('Goiânia',9,'5208707')

insert into cidades values('Goianira',9,'5208806')

insert into cidades values('Goiás',9,'5208905')

insert into cidades values('Goiatuba',9,'5209101')

insert into cidades values('Gouvelândia',9,'5209150')

insert into cidades values('Guapó',9,'5209200')

insert into cidades values('Guaraíta',9,'5209291')

insert into cidades values('Guarani de Goiás',9,'5209408')

insert into cidades values('Guarinos',9,'5209457')

insert into cidades values('Heitoraí',9,'5209606')

insert into cidades values('Hidrolândia',9,'5209705')

insert into cidades values('Hidrolina',9,'5209804')

insert into cidades values('Iaciara',9,'5209903')

insert into cidades values('Inaciolândia',9,'5209937')

insert into cidades values('Indiara',9,'5209952')

insert into cidades values('Inhumas',9,'5210000')

insert into cidades values('Ipameri',9,'5210109')

insert into cidades values('Ipiranga de Goiás',9,'5210158')

insert into cidades values('Iporá',9,'5210208')

insert into cidades values('Israelândia',9,'5210307')

insert into cidades values('Itaberaí',9,'5210406')

insert into cidades values('Itaguari',9,'5210562')

insert into cidades values('Itaguaru',9,'5210604')

insert into cidades values('Itajá',9,'5210802')

insert into cidades values('Itapaci',9,'5210901')

insert into cidades values('Itapirapuã',9,'5211008')

insert into cidades values('Itapuranga',9,'5211206')

insert into cidades values('Itarumã',9,'5211305')

insert into cidades values('Itauçu',9,'5211404')

insert into cidades values('Itumbiara',9,'5211503')

insert into cidades values('Ivolândia',9,'5211602')

insert into cidades values('Jandaia',9,'5211701')

insert into cidades values('Jaraguá',9,'5211800')

insert into cidades values('Jataí',9,'5211909')

insert into cidades values('Jaupaci',9,'5212006')

insert into cidades values('Jesúpolis',9,'5212055')

insert into cidades values('Joviânia',9,'5212105')

insert into cidades values('Jussara',9,'5212204')

insert into cidades values('Lagoa Santa',9,'5212253')

insert into cidades values('Leopoldo de Bulhões',9,'5212303')

insert into cidades values('Luziânia',9,'5212501')

insert into cidades values('Mairipotaba',9,'5212600')

insert into cidades values('Mambaí',9,'5212709')

insert into cidades values('Mara Rosa',9,'5212808')

insert into cidades values('Marzagão',9,'5212907')

insert into cidades values('Matrinchã',9,'5212956')

insert into cidades values('Maurilândia',9,'5213004')

insert into cidades values('Mimoso de Goiás',9,'5213053')

insert into cidades values('Minaçu',9,'5213087')

insert into cidades values('Mineiros',9,'5213103')

insert into cidades values('Moiporá',9,'5213400')

insert into cidades values('Monte Alegre de Goiás',9,'5213509')

insert into cidades values('Montes Claros de Goiás',9,'5213707')

insert into cidades values('Montividiu',9,'5213756')

insert into cidades values('Montividiu do Norte',9,'5213772')

insert into cidades values('Morrinhos',9,'5213806')

insert into cidades values('Morro Agudo de Goiás',9,'5213855')

insert into cidades values('Mossâmedes',9,'5213905')

insert into cidades values('Mozarlândia',9,'5214002')

insert into cidades values('Mundo Novo',9,'5214051')

insert into cidades values('Mutunópolis',9,'5214101')

insert into cidades values('Nazário',9,'5214408')

insert into cidades values('Nerópolis',9,'5214507')

insert into cidades values('Niquelândia',9,'5214606')

insert into cidades values('Nova América',9,'5214705')

insert into cidades values('Nova Aurora',9,'5214804')

insert into cidades values('Nova Crixás',9,'5214838')

insert into cidades values('Nova Glória',9,'5214861')

insert into cidades values('Nova Iguaçu de Goiás',9,'5214879')

insert into cidades values('Nova Roma',9,'5214903')

insert into cidades values('Nova Veneza',9,'5215009')

insert into cidades values('Novo Brasil',9,'5215207')

insert into cidades values('Novo Gama',9,'5215231')

insert into cidades values('Novo Planalto',9,'5215256')

insert into cidades values('Orizona',9,'5215306')

insert into cidades values('Ouro Verde de Goiás',9,'5215405')

insert into cidades values('Ouvidor',9,'5215504')

insert into cidades values('Padre Bernardo',9,'5215603')

insert into cidades values('Palestina de Goiás',9,'5215652')

insert into cidades values('Palmeiras de Goiás',9,'5215702')

insert into cidades values('Palmelo',9,'5215801')

insert into cidades values('Palminópolis',9,'5215900')

insert into cidades values('Panamá',9,'5216007')

insert into cidades values('Paranaiguara',9,'5216304')

insert into cidades values('Paraúna',9,'5216403')

insert into cidades values('Perolândia',9,'5216452')

insert into cidades values('Petrolina de Goiás',9,'5216809')

insert into cidades values('Pilar de Goiás',9,'5216908')

insert into cidades values('Piracanjuba',9,'5217104')

insert into cidades values('Piranhas',9,'5217203')

insert into cidades values('Pirenópolis',9,'5217302')

insert into cidades values('Pires do Rio',9,'5217401')

insert into cidades values('Planaltina',9,'5217609')

insert into cidades values('Pontalina',9,'5217708')

insert into cidades values('Porangatu',9,'5218003')

insert into cidades values('Porteirão',9,'5218052')

insert into cidades values('Portelândia',9,'5218102')

insert into cidades values('Posse',9,'5218300')

insert into cidades values('Professor Jamil',9,'5218391')

insert into cidades values('Quirinópolis',9,'5218508')

insert into cidades values('Rialma',9,'5218607')

insert into cidades values('Rianápolis',9,'5218706')

insert into cidades values('Rio Quente',9,'5218789')

insert into cidades values('Rio Verde',9,'5218805')

insert into cidades values('Rubiataba',9,'5218904')

insert into cidades values('Sanclerlândia',9,'5219001')

insert into cidades values('Santa Bárbara de Goiás',9,'5219100')

insert into cidades values('Santa Cruz de Goiás',9,'5219209')

insert into cidades values('Santa Fé de Goiás',9,'5219258')

insert into cidades values('Santa Helena de Goiás',9,'5219308')

insert into cidades values('Santa Isabel',9,'5219357')

insert into cidades values('Santa Rita do Araguaia',9,'5219407')

insert into cidades values('Santa Rita do Novo Destino',9,'5219456')

insert into cidades values('Santa Rosa de Goiás',9,'5219506')

insert into cidades values('Santa Tereza de Goiás',9,'5219605')

insert into cidades values('Santa Terezinha de Goiás',9,'5219704')

insert into cidades values('Santo Antônio da Barra',9,'5219712')

insert into cidades values('Santo Antônio de Goiás',9,'5219738')

insert into cidades values('Santo Antônio do Descoberto',9,'5219753')

insert into cidades values('São Domingos',9,'5219803')

insert into cidades values('São Francisco de Goiás',9,'5219902')

insert into cidades values('São João dAliança',9,'5220009')

insert into cidades values('São João da Paraúna',9,'5220058')

insert into cidades values('São Luís de Montes Belos',9,'5220108')

insert into cidades values('São Luíz do Norte',9,'5220157')

insert into cidades values('São Miguel do Araguaia',9,'5220207')

insert into cidades values('São Miguel do Passa Quatro',9,'5220264')

insert into cidades values('São Patrício',9,'5220280')

insert into cidades values('São Simão',9,'5220405')

insert into cidades values('Senador Canedo',9,'5220454')

insert into cidades values('Serranópolis',9,'5220504')

insert into cidades values('Silvânia',9,'5220603')

insert into cidades values('Simolândia',9,'5220686')

insert into cidades values('Sítio dAbadia',9,'5220702')

insert into cidades values('Taquaral de Goiás',9,'5221007')

insert into cidades values('Teresina de Goiás',9,'5221080')

insert into cidades values('Terezópolis de Goiás',9,'5221197')

insert into cidades values('Três Ranchos',9,'5221304')

insert into cidades values('Trindade',9,'5221403')

insert into cidades values('Trombas',9,'5221452')

insert into cidades values('Turvânia',9,'5221502')

insert into cidades values('Turvelândia',9,'5221551')

insert into cidades values('Uirapuru',9,'5221577')

insert into cidades values('Uruaçu',9,'5221601')

insert into cidades values('Uruana',9,'5221700')

insert into cidades values('Urutaí',9,'5221809')

insert into cidades values('Valparaíso de Goiás',9,'5221858')

insert into cidades values('Varjão',9,'5221908')

insert into cidades values('Vianópolis',9,'5222005')

insert into cidades values('Vicentinópolis',9,'5222054')

insert into cidades values('Vila Boa',9,'5222203')

insert into cidades values('Vila Propício',9,'5222302')

insert into cidades values('Açailândia',10,'2100055')

insert into cidades values('Afonso Cunha',10,'2100105')

insert into cidades values('Água Doce do Maranhão',10,'2100154')

insert into cidades values('Alcântara',10,'2100204')

insert into cidades values('Aldeias Altas',10,'2100303')

insert into cidades values('Altamira do Maranhão',10,'2100402')

insert into cidades values('Alto Alegre do Maranhão',10,'2100436')

insert into cidades values('Alto Alegre do Pindaré',10,'2100477')

insert into cidades values('Alto Parnaíba',10,'2100501')

insert into cidades values('Amapá do Maranhão',10,'2100550')

insert into cidades values('Amarante do Maranhão',10,'2100600')

insert into cidades values('Anajatuba',10,'2100709')

insert into cidades values('Anapurus',10,'2100808')

insert into cidades values('Apicum-Açu',10,'2100832')

insert into cidades values('Araguanã',10,'2100873')

insert into cidades values('Araioses',10,'2100907')

insert into cidades values('Arame',10,'2100956')

insert into cidades values('Arari',10,'2101004')

insert into cidades values('Axixá',10,'2101103')

insert into cidades values('Bacabal',10,'2101202')

insert into cidades values('Bacabeira',10,'2101251')

insert into cidades values('Bacuri',10,'2101301')

insert into cidades values('Bacurituba',10,'2101350')

insert into cidades values('Balsas',10,'2101400')

insert into cidades values('Barão de Grajaú',10,'2101509')

insert into cidades values('Barra do Corda',10,'2101608')

insert into cidades values('Barreirinhas',10,'2101707')

insert into cidades values('Bela Vista do Maranhão',10,'2101772')

insert into cidades values('Belágua',10,'2101731')

insert into cidades values('Benedito Leite',10,'2101806')

insert into cidades values('Bequimão',10,'2101905')

insert into cidades values('Bernardo do Mearim',10,'2101939')

insert into cidades values('Boa Vista do Gurupi',10,'2101970')

insert into cidades values('Bom Jardim',10,'2102002')

insert into cidades values('Bom Jesus das Selvas',10,'2102036')

insert into cidades values('Bom Lugar',10,'2102077')

insert into cidades values('Brejo',10,'2102101')

insert into cidades values('Brejo de Areia',10,'2102150')

insert into cidades values('Buriti',10,'2102200')

insert into cidades values('Buriti Bravo',10,'2102309')

insert into cidades values('Buriticupu',10,'2102325')

insert into cidades values('Buritirana',10,'2102358')

insert into cidades values('Cachoeira Grande',10,'2102374')

insert into cidades values('Cajapió',10,'2102408')

insert into cidades values('Cajari',10,'2102507')

insert into cidades values('Campestre do Maranhão',10,'2102556')

insert into cidades values('Cândido Mendes',10,'2102606')

insert into cidades values('Cantanhede',10,'2102705')

insert into cidades values('Capinzal do Norte',10,'2102754')

insert into cidades values('Carolina',10,'2102804')

insert into cidades values('Carutapera',10,'2102903')

insert into cidades values('Caxias',10,'2103000')

insert into cidades values('Cedral',10,'2103109')

insert into cidades values('Central do Maranhão',10,'2103125')

insert into cidades values('Centro do Guilherme',10,'2103158')

insert into cidades values('Centro Novo do Maranhão',10,'2103174')

insert into cidades values('Chapadinha',10,'2103208')

insert into cidades values('Cidelândia',10,'2103257')

insert into cidades values('Codó',10,'2103307')

insert into cidades values('Coelho Neto',10,'2103406')

insert into cidades values('Colinas',10,'2103505')

insert into cidades values('Conceição do Lago-Açu',10,'2103554')

insert into cidades values('Coroatá',10,'2103604')

insert into cidades values('Cururupu',10,'2103703')

insert into cidades values('Davinópolis',10,'2103752')

insert into cidades values('Dom Pedro',10,'2103802')

insert into cidades values('Duque Bacelar',10,'2103901')

insert into cidades values('Esperantinópolis',10,'2104008')

insert into cidades values('Estreito',10,'2104057')

insert into cidades values('Feira Nova do Maranhão',10,'2104073')

insert into cidades values('Fernando Falcão',10,'2104081')

insert into cidades values('Formosa da Serra Negra',10,'2104099')

insert into cidades values('Fortaleza dos Nogueiras',10,'2104107')

insert into cidades values('Fortuna',10,'2104206')

insert into cidades values('Godofredo Viana',10,'2104305')

insert into cidades values('Gonçalves Dias',10,'2104404')

insert into cidades values('Governador Archer',10,'2104503')

insert into cidades values('Governador Edison Lobão',10,'2104552')

insert into cidades values('Governador Eugênio Barros',10,'2104602')

insert into cidades values('Governador Luiz Rocha',10,'2104628')

insert into cidades values('Governador Newton Bello',10,'2104651')

insert into cidades values('Governador Nunes Freire',10,'2104677')

insert into cidades values('Graça Aranha',10,'2104701')

insert into cidades values('Grajaú',10,'2104800')

insert into cidades values('Guimarães',10,'2104909')

insert into cidades values('Humberto de Campos',10,'2105005')

insert into cidades values('Icatu',10,'2105104')

insert into cidades values('Igarapé do Meio',10,'2105153')

insert into cidades values('Igarapé Grande',10,'2105203')

insert into cidades values('Imperatriz',10,'2105302')

insert into cidades values('Itaipava do Grajaú',10,'2105351')

insert into cidades values('Itapecuru Mirim',10,'2105401')

insert into cidades values('Itinga do Maranhão',10,'2105427')

insert into cidades values('Jatobá',10,'2105450')

insert into cidades values('Jenipapo dos Vieiras',10,'2105476')

insert into cidades values('João Lisboa',10,'2105500')

insert into cidades values('Joselândia',10,'2105609')

insert into cidades values('Junco do Maranhão',10,'2105658')

insert into cidades values('Lago da Pedra',10,'2105708')

insert into cidades values('Lago do Junco',10,'2105807')

insert into cidades values('Lago dos Rodrigues',10,'2105948')

insert into cidades values('Lago Verde',10,'2105906')

insert into cidades values('Lagoa do Mato',10,'2105922')

insert into cidades values('Lagoa Grande do Maranhão',10,'2105963')

insert into cidades values('Lajeado Novo',10,'2105989')

insert into cidades values('Lima Campos',10,'2106003')

insert into cidades values('Loreto',10,'2106102')

insert into cidades values('Luís Domingues',10,'2106201')

insert into cidades values('Magalhães de Almeida',10,'2106300')

insert into cidades values('Maracaçumé',10,'2106326')

insert into cidades values('Marajá do Sena',10,'2106359')

insert into cidades values('Maranhãozinho',10,'2106375')

insert into cidades values('Mata Roma',10,'2106409')

insert into cidades values('Matinha',10,'2106508')

insert into cidades values('Matões',10,'2106607')

insert into cidades values('Matões do Norte',10,'2106631')

insert into cidades values('Milagres do Maranhão',10,'2106672')

insert into cidades values('Mirador',10,'2106706')

insert into cidades values('Miranda do Norte',10,'2106755')

insert into cidades values('Mirinzal',10,'2106805')

insert into cidades values('Monção',10,'2106904')

insert into cidades values('Montes Altos',10,'2107001')

insert into cidades values('Morros',10,'2107100')

insert into cidades values('Nina Rodrigues',10,'2107209')

insert into cidades values('Nova Colinas',10,'2107258')

insert into cidades values('Nova Iorque',10,'2107308')

insert into cidades values('Nova Olinda do Maranhão',10,'2107357')

insert into cidades values('Olho dÁgua das Cunhãs',10,'2107407')

insert into cidades values('Olinda Nova do Maranhão',10,'2107456')

insert into cidades values('Paço do Lumiar',10,'2107506')

insert into cidades values('Palmeirândia',10,'2107605')

insert into cidades values('Paraibano',10,'2107704')

insert into cidades values('Parnarama',10,'2107803')

insert into cidades values('Passagem Franca',10,'2107902')

insert into cidades values('Pastos Bons',10,'2108009')

insert into cidades values('Paulino Neves',10,'2108058')

insert into cidades values('Paulo Ramos',10,'2108108')

insert into cidades values('Pedreiras',10,'2108207')

insert into cidades values('Pedro do Rosário',10,'2108256')

insert into cidades values('Penalva',10,'2108306')

insert into cidades values('Peri Mirim',10,'2108405')

insert into cidades values('Peritoró',10,'2108454')

insert into cidades values('Pindaré-Mirim',10,'2108504')

insert into cidades values('Pinheiro',10,'2108603')

insert into cidades values('Pio XII',10,'2108702')

insert into cidades values('Pirapemas',10,'2108801')

insert into cidades values('Poção de Pedras',10,'2108900')

insert into cidades values('Porto Franco',10,'2109007')

insert into cidades values('Porto Rico do Maranhão',10,'2109056')

insert into cidades values('Presidente Dutra',10,'2109106')

insert into cidades values('Presidente Juscelino',10,'2109205')

insert into cidades values('Presidente Médici',10,'2109239')

insert into cidades values('Presidente Sarney',10,'2109270')

insert into cidades values('Presidente Vargas',10,'2109304')

insert into cidades values('Primeira Cruz',10,'2109403')

insert into cidades values('Raposa',10,'2109452')

insert into cidades values('Riachão',10,'2109502')

insert into cidades values('Ribamar Fiquene',10,'2109551')

insert into cidades values('Rosário',10,'2109601')

insert into cidades values('Sambaíba',10,'2109700')

insert into cidades values('Santa Filomena do Maranhão',10,'2109759')

insert into cidades values('Santa Helena',10,'2109809')

insert into cidades values('Santa Inês',10,'2109908')

insert into cidades values('Santa Luzia',10,'2110005')

insert into cidades values('Santa Luzia do Paruá',10,'2110039')

insert into cidades values('Santa Quitéria do Maranhão',10,'2110104')

insert into cidades values('Santa Rita',10,'2110203')

insert into cidades values('Santana do Maranhão',10,'2110237')

insert into cidades values('Santo Amaro do Maranhão',10,'2110278')

insert into cidades values('Santo Antônio dos Lopes',10,'2110302')

insert into cidades values('São Benedito do Rio Preto',10,'2110401')

insert into cidades values('São Bento',10,'2110500')

insert into cidades values('São Bernardo',10,'2110609')

insert into cidades values('São Domingos do Azeitão',10,'2110658')

insert into cidades values('São Domingos do Maranhão',10,'2110708')

insert into cidades values('São Félix de Balsas',10,'2110807')

insert into cidades values('São Francisco do Brejão',10,'2110856')

insert into cidades values('São Francisco do Maranhão',10,'2110906')

insert into cidades values('São João Batista',10,'2111003')

insert into cidades values('São João do Carú',10,'2111029')

insert into cidades values('São João do Paraíso',10,'2111052')

insert into cidades values('São João do Soter',10,'2111078')

insert into cidades values('São João dos Patos',10,'2111102')

insert into cidades values('São José de Ribamar',10,'2111201')

insert into cidades values('São José dos Basílios',10,'2111250')

insert into cidades values('São Luís',10,'2111300')

insert into cidades values('São Luís Gonzaga do Maranhão',10,'2111409')

insert into cidades values('São Mateus do Maranhão',10,'2111508')

insert into cidades values('São Pedro da Água Branca',10,'2111532')

insert into cidades values('São Pedro dos Crentes',10,'2111573')

insert into cidades values('São Raimundo das Mangabeiras',10,'2111607')

insert into cidades values('São Raimundo do Doca Bezerra',10,'2111631')

insert into cidades values('São Roberto',10,'2111672')

insert into cidades values('São Vicente Ferrer',10,'2111706')

insert into cidades values('Satubinha',10,'2111722')

insert into cidades values('Senador Alexandre Costa',10,'2111748')

insert into cidades values('Senador La Rocque',10,'2111763')

insert into cidades values('Serrano do Maranhão',10,'2111789')

insert into cidades values('Sítio Novo',10,'2111805')

insert into cidades values('Sucupira do Norte',10,'2111904')

insert into cidades values('Sucupira do Riachão',10,'2111953')

insert into cidades values('Tasso Fragoso',10,'2112001')

insert into cidades values('Timbiras',10,'2112100')

insert into cidades values('Timon',10,'2112209')

insert into cidades values('Trizidela do Vale',10,'2112233')

insert into cidades values('Tufilândia',10,'2112274')

insert into cidades values('Tuntum',10,'2112308')

insert into cidades values('Turiaçu',10,'2112407')

insert into cidades values('Turilândia',10,'2112456')

insert into cidades values('Tutóia',10,'2112506')

insert into cidades values('Urbano Santos',10,'2112605')

insert into cidades values('Vargem Grande',10,'2112704')

insert into cidades values('Viana',10,'2112803')

insert into cidades values('Vila Nova dos Martírios',10,'2112852')

insert into cidades values('Vitória do Mearim',10,'2112902')

insert into cidades values('Vitorino Freire',10,'2113009')

insert into cidades values('Zé Doca',10,'2114007')

insert into cidades values('Acorizal',13,'5100102')

insert into cidades values('Água Boa',13,'5100201')

insert into cidades values('Alta Floresta',13,'5100250')

insert into cidades values('Alto Araguaia',13,'5100300')

insert into cidades values('Alto Boa Vista',13,'5100359')

insert into cidades values('Alto Garças',13,'5100409')

insert into cidades values('Alto Paraguai',13,'5100508')

insert into cidades values('Alto Taquari',13,'5100607')

insert into cidades values('Apiacás',13,'5100805')

insert into cidades values('Araguaiana',13,'5101001')

insert into cidades values('Araguainha',13,'5101209')

insert into cidades values('Araputanga',13,'5101258')

insert into cidades values('Arenápolis',13,'5101308')

insert into cidades values('Aripuanã',13,'5101407')

insert into cidades values('Barão de Melgaço',13,'5101605')

insert into cidades values('Barra do Bugres',13,'5101704')

insert into cidades values('Barra do Garças',13,'5101803')

insert into cidades values('Bom Jesus do Araguaia',13,'5101852')

insert into cidades values('Brasnorte',13,'5101902')

insert into cidades values('Cáceres',13,'5102504')

insert into cidades values('Campinápolis',13,'5102603')

insert into cidades values('Campo Novo do Parecis',13,'5102637')

insert into cidades values('Campo Verde',13,'5102678')

insert into cidades values('Campos de Júlio',13,'5102686')

insert into cidades values('Canabrava do Norte',13,'5102694')

insert into cidades values('Canarana',13,'5102702')

insert into cidades values('Carlinda',13,'5102793')

insert into cidades values('Castanheira',13,'5102850')

insert into cidades values('Chapada dos Guimarães',13,'5103007')

insert into cidades values('Cláudia',13,'5103056')

insert into cidades values('Cocalinho',13,'5103106')

insert into cidades values('Colíder',13,'5103205')

insert into cidades values('Colniza',13,'5103254')

insert into cidades values('Comodoro',13,'5103304')

insert into cidades values('Confresa',13,'5103353')

insert into cidades values('Conquista dOeste',13,'5103361')

insert into cidades values('Cotriguaçu',13,'5103379')

insert into cidades values('Cuiabá',13,'5103403')

insert into cidades values('Curvelândia',13,'5103437')

insert into cidades values('Denise',13,'5103452')

insert into cidades values('Diamantino',13,'5103502')

insert into cidades values('Dom Aquino',13,'5103601')

insert into cidades values('Feliz Natal',13,'5103700')

insert into cidades values('Figueirópolis dOeste',13,'5103809')

insert into cidades values('Gaúcha do Norte',13,'5103858')

insert into cidades values('General Carneiro',13,'5103908')

insert into cidades values('Glória dOeste',13,'5103957')

insert into cidades values('Guarantã do Norte',13,'5104104')

insert into cidades values('Guiratinga',13,'5104203')

insert into cidades values('Indiavaí',13,'5104500')

insert into cidades values('Ipiranga do Norte',13,'5104526')

insert into cidades values('Itanhangá',13,'5104542')

insert into cidades values('Itaúba',13,'5104559')

insert into cidades values('Itiquira',13,'5104609')

insert into cidades values('Jaciara',13,'5104807')

insert into cidades values('Jangada',13,'5104906')

insert into cidades values('Jauru',13,'5105002')

insert into cidades values('Juara',13,'5105101')

insert into cidades values('Juína',13,'5105150')

insert into cidades values('Juruena',13,'5105176')

insert into cidades values('Juscimeira',13,'5105200')

insert into cidades values('Lambari dOeste',13,'5105234')

insert into cidades values('Lucas do Rio Verde',13,'5105259')

insert into cidades values('Luciára',13,'5105309')

insert into cidades values('Marcelândia',13,'5105580')

insert into cidades values('Matupá',13,'5105606')

insert into cidades values('Mirassol dOeste',13,'5105622')

insert into cidades values('Nobres',13,'5105903')

insert into cidades values('Nortelândia',13,'5106000')

insert into cidades values('Nossa Senhora do Livramento',13,'5106109')

insert into cidades values('Nova Bandeirantes',13,'5106158')

insert into cidades values('Nova Brasilândia',13,'5106208')

insert into cidades values('Nova Canaã do Norte',13,'5106216')

insert into cidades values('Nova Guarita',13,'5108808')

insert into cidades values('Nova Lacerda',13,'5106182')

insert into cidades values('Nova Marilândia',13,'5108857')

insert into cidades values('Nova Maringá',13,'5108907')

insert into cidades values('Nova Monte verde',13,'5108956')

insert into cidades values('Nova Mutum',13,'5106224')

insert into cidades values('Nova Olímpia',13,'5106232')

insert into cidades values('Nova Santa Helena',13,'5106190')

insert into cidades values('Nova Ubiratã',13,'5106240')

insert into cidades values('Nova Xavantina',13,'5106257')

insert into cidades values('Novo Horizonte do Norte',13,'5106273')

insert into cidades values('Novo Mundo',13,'5106265')

insert into cidades values('Novo Santo Antônio',13,'5106315')

insert into cidades values('Novo São Joaquim',13,'5106281')

insert into cidades values('Paranaíta',13,'5106299')

insert into cidades values('Paranatinga',13,'5106307')

insert into cidades values('Pedra Preta',13,'5106372')

insert into cidades values('Peixoto de Azevedo',13,'5106422')

insert into cidades values('Planalto da Serra',13,'5106455')

insert into cidades values('Poconé',13,'5106505')

insert into cidades values('Pontal do Araguaia',13,'5106653')

insert into cidades values('Ponte Branca',13,'5106703')

insert into cidades values('Pontes e Lacerda',13,'5106752')

insert into cidades values('Porto Alegre do Norte',13,'5106778')

insert into cidades values('Porto dos Gaúchos',13,'5106802')

insert into cidades values('Porto Esperidião',13,'5106828')

insert into cidades values('Porto Estrela',13,'5106851')

insert into cidades values('Poxoréo',13,'5107008')

insert into cidades values('Primavera do Leste',13,'5107040')

insert into cidades values('Querência',13,'5107065')

insert into cidades values('Reserva do Cabaçal',13,'5107156')

insert into cidades values('Ribeirão Cascalheira',13,'5107180')

insert into cidades values('Ribeirãozinho',13,'5107198')

insert into cidades values('Rio Branco',13,'5107206')

insert into cidades values('Rondolândia',13,'5107578')

insert into cidades values('Rondonópolis',13,'5107602')

insert into cidades values('Rosário Oeste',13,'5107701')

insert into cidades values('Salto do Céu',13,'5107750')

insert into cidades values('Santa Carmem',13,'5107248')

insert into cidades values('Santa Cruz do Xingu',13,'5107743')

insert into cidades values('Santa Rita do Trivelato',13,'5107768')

insert into cidades values('Santa Terezinha',13,'5107776')

insert into cidades values('Santo Afonso',13,'5107263')

insert into cidades values('Santo Antônio do Leste',13,'5107792')

insert into cidades values('Santo Antônio do Leverger',13,'5107800')

insert into cidades values('São Félix do Araguaia',13,'5107859')

insert into cidades values('São José do Povo',13,'5107297')

insert into cidades values('São José do Rio Claro',13,'5107305')

insert into cidades values('São José do Xingu',13,'5107354')

insert into cidades values('São José dos Quatro Marcos',13,'5107107')

insert into cidades values('São Pedro da Cipa',13,'5107404')

insert into cidades values('Sapezal',13,'5107875')

insert into cidades values('Serra Nova Dourada',13,'5107883')

insert into cidades values('Sinop',13,'5107909')

insert into cidades values('Sorriso',13,'5107925')

insert into cidades values('Tabaporã',13,'5107941')

insert into cidades values('Tangará da Serra',13,'5107958')

insert into cidades values('Tapurah',13,'5108006')

insert into cidades values('Terra Nova do Norte',13,'5108055')

insert into cidades values('Tesouro',13,'5108105')

insert into cidades values('Torixoréu',13,'5108204')

insert into cidades values('União do Sul',13,'5108303')

insert into cidades values('Vale de São Domingos',13,'5108352')

insert into cidades values('Várzea Grande',13,'5108402')

insert into cidades values('Vera',13,'5108501')

insert into cidades values('Vila Bela da Santíssima Trindade',13,'5105507')

insert into cidades values('Vila Rica',13,'5108600')

insert into cidades values('Água Clara',12,'5000203')

insert into cidades values('Alcinópolis',12,'5000252')

insert into cidades values('Amambaí',12,'5000609')

insert into cidades values('Anastácio',12,'5000708')

insert into cidades values('Anaurilândia',12,'5000807')

insert into cidades values('Angélica',12,'5000856')

insert into cidades values('Antônio João',12,'5000906')

insert into cidades values('Aparecida do Taboado',12,'5001003')

insert into cidades values('Aquidauana',12,'5001102')

insert into cidades values('Aral Moreira',12,'5001243')

insert into cidades values('Bandeirantes',12,'5001508')

insert into cidades values('Bataguassu',12,'5001904')

insert into cidades values('Bela Vista',12,'5002100')

insert into cidades values('Bodoquena',12,'5002159')

insert into cidades values('Bonito',12,'5002209')

insert into cidades values('Brasilândia',12,'5002308')

insert into cidades values('Caarapó',12,'5002407')

insert into cidades values('Camapuã',12,'5002605')

insert into cidades values('Campo Grande',12,'5002704')

insert into cidades values('Caracol',12,'5002803')

insert into cidades values('Cassilândia',12,'5002902')

insert into cidades values('Chapadão do Sul',12,'5002951')

insert into cidades values('Corguinho',12,'5003108')

insert into cidades values('Coronel Sapucaia',12,'5003157')

insert into cidades values('Corumbá',12,'5003207')

insert into cidades values('Costa Rica',12,'5003256')

insert into cidades values('Coxim',12,'5003306')

insert into cidades values('Deodápolis',12,'5003454')

insert into cidades values('Dois Irmãos do Buriti',12,'5003488')

insert into cidades values('Douradina',12,'5003504')

insert into cidades values('Dourados',12,'5003702')

insert into cidades values('Eldorado',12,'5003751')

insert into cidades values('Fátima do Sul',12,'5003801')

insert into cidades values('Figueirão',12,'5003900')

insert into cidades values('Glória de Dourados',12,'5004007')

insert into cidades values('Guia Lopes da Laguna',12,'5004106')

insert into cidades values('Iguatemi',12,'5004304')

insert into cidades values('Inocência',12,'5004403')

insert into cidades values('Itaporã',12,'5004502')

insert into cidades values('Itaquiraí',12,'5004601')

insert into cidades values('Ivinhema',12,'5004700')

insert into cidades values('Japorã',12,'5004809')

insert into cidades values('Jaraguari',12,'5004908')

insert into cidades values('Jardim',12,'5005004')

insert into cidades values('Jateí',12,'5005103')

insert into cidades values('Juti',12,'5005152')

insert into cidades values('Ladário',12,'5005202')

insert into cidades values('Laguna Carapã',12,'5005251')

insert into cidades values('Maracaju',12,'5005400')

insert into cidades values('Miranda',12,'5005608')

insert into cidades values('Mundo Novo',12,'5005681')

insert into cidades values('Naviraí',12,'5005707')

insert into cidades values('Nioaque',12,'5005806')

insert into cidades values('Nova Alvorada do Sul',12,'5006002')

insert into cidades values('Nova Andradina',12,'5006200')

insert into cidades values('Novo Horizonte do Sul',12,'5006259')

insert into cidades values('Paranaíba',12,'5006309')

insert into cidades values('Paranhos',12,'5006358')

insert into cidades values('Pedro Gomes',12,'5006408')

insert into cidades values('Ponta Porã',12,'5006606')

insert into cidades values('Porto Murtinho',12,'5006903')

insert into cidades values('Ribas do Rio Pardo',12,'5007109')

insert into cidades values('Rio Brilhante',12,'5007208')

insert into cidades values('Rio Negro',12,'5007307')

insert into cidades values('Rio Verde de Mato Grosso',12,'5007406')

insert into cidades values('Rochedo',12,'5007505')

insert into cidades values('Santa Rita do Pardo',12,'5007554')

insert into cidades values('São Gabriel do Oeste',12,'5007695')

insert into cidades values('Selvíria',12,'5007802')

insert into cidades values('Sete Quedas',12,'5007703')

insert into cidades values('Sidrolândia',12,'5007901')

insert into cidades values('Sonora',12,'5007935')

insert into cidades values('Tacuru',12,'5007950')

insert into cidades values('Taquarussu',12,'5007976')

insert into cidades values('Terenos',12,'5008008')

insert into cidades values('Três Lagoas',12,'5008305')

insert into cidades values('Vicentina',12,'5008404')

insert into cidades values('Abadia dos Dourados',11,'3100104')

insert into cidades values('Abaeté',11,'3100203')

insert into cidades values('Abre Campo',11,'3100302')

insert into cidades values('Acaiaca',11,'3100401')

insert into cidades values('Açucena',11,'3100500')

insert into cidades values('Água Boa',11,'3100609')

insert into cidades values('Água Comprida',11,'3100708')

insert into cidades values('Aguanil',11,'3100807')

insert into cidades values('Águas Formosas',11,'3100906')

insert into cidades values('Águas Vermelhas',11,'3101003')

insert into cidades values('Aimorés',11,'3101102')

insert into cidades values('Aiuruoca',11,'3101201')

insert into cidades values('Alagoa',11,'3101300')

insert into cidades values('Albertina',11,'3101409')

insert into cidades values('Além Paraíba',11,'3101508')

insert into cidades values('Alfenas',11,'3101607')

insert into cidades values('Alfredo Vasconcelos',11,'3101631')

insert into cidades values('Almenara',11,'3101706')

insert into cidades values('Alpercata',11,'3101805')

insert into cidades values('Alpinópolis',11,'3101904')

insert into cidades values('Alterosa',11,'3102001')

insert into cidades values('Alto Caparaó',11,'3102050')

insert into cidades values('Alto Jequitibá',11,'3153509')

insert into cidades values('Alto Rio Doce',11,'3102100')

insert into cidades values('Alvarenga',11,'3102209')

insert into cidades values('Alvinópolis',11,'3102308')

insert into cidades values('Alvorada de Minas',11,'3102407')

insert into cidades values('Amparo do Serra',11,'3102506')

insert into cidades values('Andradas',11,'3102605')

insert into cidades values('Andrelândia',11,'3102803')

insert into cidades values('Angelândia',11,'3102852')

insert into cidades values('Antônio Carlos',11,'3102902')

insert into cidades values('Antônio Dias',11,'3103009')

insert into cidades values('Antônio Prado de Minas',11,'3103108')

insert into cidades values('Araçaí',11,'3103207')

insert into cidades values('Aracitaba',11,'3103306')

insert into cidades values('Araçuaí',11,'3103405')

insert into cidades values('Araguari',11,'3103504')

insert into cidades values('Arantina',11,'3103603')

insert into cidades values('Araponga',11,'3103702')

insert into cidades values('Araporã',11,'3103751')

insert into cidades values('Arapuá',11,'3103801')

insert into cidades values('Araújos',11,'3103900')

insert into cidades values('Araxá',11,'3104007')

insert into cidades values('Arceburgo',11,'3104106')

insert into cidades values('Arcos',11,'3104205')

insert into cidades values('Areado',11,'3104304')

insert into cidades values('Argirita',11,'3104403')

insert into cidades values('Aricanduva',11,'3104452')

insert into cidades values('Arinos',11,'3104502')

insert into cidades values('Astolfo Dutra',11,'3104601')

insert into cidades values('Ataléia',11,'3104700')

insert into cidades values('Augusto de Lima',11,'3104809')

insert into cidades values('Baependi',11,'3104908')

insert into cidades values('Baldim',11,'3105004')

insert into cidades values('Bambuí',11,'3105103')

insert into cidades values('Bandeira',11,'3105202')

insert into cidades values('Bandeira do Sul',11,'3105301')

insert into cidades values('Barão de Cocais',11,'3105400')

insert into cidades values('Barão de Monte Alto',11,'3105509')

insert into cidades values('Barbacena',11,'3105608')

insert into cidades values('Barra Longa',11,'3105707')

insert into cidades values('Barroso',11,'3105905')

insert into cidades values('Bela Vista de Minas',11,'3106002')

insert into cidades values('Belmiro Braga',11,'3106101')

insert into cidades values('Belo Horizonte',11,'3106200')

insert into cidades values('Belo Oriente',11,'3106309')

insert into cidades values('Belo Vale',11,'3106408')

insert into cidades values('Berilo',11,'3106507')

insert into cidades values('Berizal',11,'3106655')

insert into cidades values('Bertópolis',11,'3106606')

insert into cidades values('Betim',11,'3106705')

insert into cidades values('Bias Fortes',11,'3106804')

insert into cidades values('Bicas',11,'3106903')

insert into cidades values('Biquinhas',11,'3107000')

insert into cidades values('Boa Esperança',11,'3107109')

insert into cidades values('Bocaina de Minas',11,'3107208')

insert into cidades values('Bocaiúva',11,'3107307')

insert into cidades values('Bom Despacho',11,'3107406')

insert into cidades values('Bom Jardim de Minas',11,'3107505')

insert into cidades values('Bom Jesus da Penha',11,'3107604')

insert into cidades values('Bom Jesus do Amparo',11,'3107703')

insert into cidades values('Bom Jesus do Galho',11,'3107802')

insert into cidades values('Bom Repouso',11,'3107901')

insert into cidades values('Bom Sucesso',11,'3108008')

insert into cidades values('Bonfim',11,'3108107')

insert into cidades values('Bonfinópolis de Minas',11,'3108206')

insert into cidades values('Bonito de Minas',11,'3108255')

insert into cidades values('Borda da Mata',11,'3108305')

insert into cidades values('Botelhos',11,'3108404')

insert into cidades values('Botumirim',11,'3108503')

insert into cidades values('Brás Pires',11,'3108701')

insert into cidades values('Brasilândia de Minas',11,'3108552')

insert into cidades values('Brasília de Minas',11,'3108602')

insert into cidades values('Brasópolis',11,'3108909')

insert into cidades values('Braúnas',11,'3108800')

insert into cidades values('Brumadinho',11,'3109006')

insert into cidades values('Bueno Brandão',11,'3109105')

insert into cidades values('Buenópolis',11,'3109204')

insert into cidades values('Bugre',11,'3109253')

insert into cidades values('Buritis',11,'3109303')

insert into cidades values('Buritizeiro',11,'3109402')

insert into cidades values('Cabeceira Grande',11,'3109451')

insert into cidades values('Cabo Verde',11,'3109501')

insert into cidades values('Cachoeira da Prata',11,'3109600')

insert into cidades values('Cachoeira de Minas',11,'3109709')

insert into cidades values('Cachoeira de Pajeú',11,'3102704')

insert into cidades values('Cachoeira Dourada',11,'3109808')

insert into cidades values('Caetanópolis',11,'3109907')

insert into cidades values('Caeté',11,'3110004')

insert into cidades values('Caiana',11,'3110103')

insert into cidades values('Cajuri',11,'3110202')

insert into cidades values('Caldas',11,'3110301')

insert into cidades values('Camacho',11,'3110400')

insert into cidades values('Camanducaia',11,'3110509')

insert into cidades values('Cambuí',11,'3110608')

insert into cidades values('Cambuquira',11,'3110707')

insert into cidades values('Campanário',11,'3110806')

insert into cidades values('Campanha',11,'3110905')

insert into cidades values('Campestre',11,'3111002')

insert into cidades values('Campina Verde',11,'3111101')

insert into cidades values('Campo Azul',11,'3111150')

insert into cidades values('Campo Belo',11,'3111200')

insert into cidades values('Campo do Meio',11,'3111309')

insert into cidades values('Campo Florido',11,'3111408')

insert into cidades values('Campos Altos',11,'3111507')

insert into cidades values('Campos Gerais',11,'3111606')

insert into cidades values('Cana Verde',11,'3111903')

insert into cidades values('Canaã',11,'3111705')

insert into cidades values('Canápolis',11,'3111804')

insert into cidades values('Candeias',11,'3112000')

insert into cidades values('Cantagalo',11,'3112059')

insert into cidades values('Caparaó',11,'3112109')

insert into cidades values('Capela Nova',11,'3112208')

insert into cidades values('Capelinha',11,'3112307')

insert into cidades values('Capetinga',11,'3112406')

insert into cidades values('Capim Branco',11,'3112505')

insert into cidades values('Capinópolis',11,'3112604')

insert into cidades values('Capitão Andrade',11,'3112653')

insert into cidades values('Capitão Enéas',11,'3112703')

insert into cidades values('Capitólio',11,'3112802')

insert into cidades values('Caputira',11,'3112901')

insert into cidades values('Caraí',11,'3113008')

insert into cidades values('Caranaíba',11,'3113107')

insert into cidades values('Carandaí',11,'3113206')

insert into cidades values('Carangola',11,'3113305')

insert into cidades values('Caratinga',11,'3113404')

insert into cidades values('Carbonita',11,'3113503')

insert into cidades values('Careaçu',11,'3113602')

insert into cidades values('Carlos Chagas',11,'3113701')

insert into cidades values('Carmésia',11,'3113800')

insert into cidades values('Carmo da Cachoeira',11,'3113909')

insert into cidades values('Carmo da Mata',11,'3114006')

insert into cidades values('Carmo de Minas',11,'3114105')

insert into cidades values('Carmo do Cajuru',11,'3114204')

insert into cidades values('Carmo do Paranaíba',11,'3114303')

insert into cidades values('Carmo do Rio Claro',11,'3114402')

insert into cidades values('Carmópolis de Minas',11,'3114501')

insert into cidades values('Carneirinho',11,'3114550')

insert into cidades values('Carrancas',11,'3114600')

insert into cidades values('Carvalhópolis',11,'3114709')

insert into cidades values('Carvalhos',11,'3114808')

insert into cidades values('Casa Grande',11,'3114907')

insert into cidades values('Cascalho Rico',11,'3115003')

insert into cidades values('Cássia',11,'3115102')

insert into cidades values('Cataguases',11,'3115300')

insert into cidades values('Catas Altas',11,'3115359')

insert into cidades values('Catas Altas da Noruega',11,'3115409')

insert into cidades values('Catuji',11,'3115458')

insert into cidades values('Catuti',11,'3115474')

insert into cidades values('Caxambu',11,'3115508')

insert into cidades values('Cedro do Abaeté',11,'3115607')

insert into cidades values('Central de Minas',11,'3115706')

insert into cidades values('Centralina',11,'3115805')

insert into cidades values('Chácara',11,'3115904')

insert into cidades values('Chalé',11,'3116001')

insert into cidades values('Chapada do Norte',11,'3116100')

insert into cidades values('Chapada Gaúcha',11,'3116159')

insert into cidades values('Chiador',11,'3116209')

insert into cidades values('Cipotânea',11,'3116308')

insert into cidades values('Claraval',11,'3116407')

insert into cidades values('Claro dos Poções',11,'3116506')

insert into cidades values('Cláudio',11,'3116605')

insert into cidades values('Coimbra',11,'3116704')

insert into cidades values('Coluna',11,'3116803')

insert into cidades values('Comendador Gomes',11,'3116902')

insert into cidades values('Comercinho',11,'3117009')

insert into cidades values('Conceição da Aparecida',11,'3117108')

insert into cidades values('Conceição da Barra de Minas',11,'3115201')

insert into cidades values('Conceição das Alagoas',11,'3117306')

insert into cidades values('Conceição das Pedras',11,'3117207')

insert into cidades values('Conceição de Ipanema',11,'3117405')

insert into cidades values('Conceição do Mato Dentro',11,'3117504')

insert into cidades values('Conceição do Pará',11,'3117603')

insert into cidades values('Conceição do Rio Verde',11,'3117702')

insert into cidades values('Conceição dos Ouros',11,'3117801')

insert into cidades values('Cônego Marinho',11,'3117836')

insert into cidades values('Confins',11,'3117876')

insert into cidades values('Congonhal',11,'3117900')

insert into cidades values('Congonhas',11,'3118007')

insert into cidades values('Congonhas do Norte',11,'3118106')

insert into cidades values('Conquista',11,'3118205')

insert into cidades values('Conselheiro Lafaiete',11,'3118304')

insert into cidades values('Conselheiro Pena',11,'3118403')

insert into cidades values('Consolação',11,'3118502')

insert into cidades values('Contagem',11,'3118601')

insert into cidades values('Coqueiral',11,'3118700')

insert into cidades values('Coração de Jesus',11,'3118809')

insert into cidades values('Cordisburgo',11,'3118908')

insert into cidades values('Cordislândia',11,'3119005')

insert into cidades values('Corinto',11,'3119104')

insert into cidades values('Coroaci',11,'3119203')

insert into cidades values('Coromandel',11,'3119302')

insert into cidades values('Coronel Fabriciano',11,'3119401')

insert into cidades values('Coronel Murta',11,'3119500')

insert into cidades values('Coronel Pacheco',11,'3119609')

insert into cidades values('Coronel Xavier Chaves',11,'3119708')

insert into cidades values('Córrego Danta',11,'3119807')

insert into cidades values('Córrego do Bom Jesus',11,'3119906')

insert into cidades values('Córrego Fundo',11,'3119955')

insert into cidades values('Córrego Novo',11,'3120003')

insert into cidades values('Couto de Magalhães de Minas',11,'3120102')

insert into cidades values('Crisólita',11,'3120151')

insert into cidades values('Cristais',11,'3120201')

insert into cidades values('Cristália',11,'3120300')

insert into cidades values('Cristiano Otoni',11,'3120409')

insert into cidades values('Cristina',11,'3120508')

insert into cidades values('Crucilândia',11,'3120607')

insert into cidades values('Cruzeiro da Fortaleza',11,'3120706')

insert into cidades values('Cruzília',11,'3120805')

insert into cidades values('Cuparaque',11,'3120839')

insert into cidades values('Curral de Dentro',11,'3120870')

insert into cidades values('Curvelo',11,'3120904')

insert into cidades values('Datas',11,'3121001')

insert into cidades values('Delfim Moreira',11,'3121100')

insert into cidades values('Delfinópolis',11,'3121209')

insert into cidades values('Delta',11,'3121258')

insert into cidades values('Descoberto',11,'3121308')

insert into cidades values('Desterro de Entre Rios',11,'3121407')

insert into cidades values('Desterro do Melo',11,'3121506')

insert into cidades values('Diamantina',11,'3121605')

insert into cidades values('Diogo de Vasconcelos',11,'3121704')

insert into cidades values('Dionísio',11,'3121803')

insert into cidades values('Divinésia',11,'3121902')

insert into cidades values('Divino',11,'3122009')

insert into cidades values('Divino das Laranjeiras',11,'3122108')

insert into cidades values('Divinolândia de Minas',11,'3122207')

insert into cidades values('Divinópolis',11,'3122306')

insert into cidades values('Divisa Alegre',11,'3122355')

insert into cidades values('Divisa Nova',11,'3122405')

insert into cidades values('Divisópolis',11,'3122454')

insert into cidades values('Dom Bosco',11,'3122470')

insert into cidades values('Dom Cavati',11,'3122504')

insert into cidades values('Dom Joaquim',11,'3122603')

insert into cidades values('Dom Silvério',11,'3122702')

insert into cidades values('Dom Viçoso',11,'3122801')

insert into cidades values('Dona Eusébia',11,'3122900')

insert into cidades values('Dores de Campos',11,'3123007')

insert into cidades values('Dores de Guanhães',11,'3123106')

insert into cidades values('Dores do Indaiá',11,'3123205')

insert into cidades values('Dores do Turvo',11,'3123304')

insert into cidades values('Doresópolis',11,'3123403')

insert into cidades values('Douradoquara',11,'3123502')

insert into cidades values('Durandé',11,'3123528')

insert into cidades values('Elói Mendes',11,'3123601')

insert into cidades values('Engenheiro Caldas',11,'3123700')

insert into cidades values('Engenheiro Navarro',11,'3123809')

insert into cidades values('Entre Folhas',11,'3123858')

insert into cidades values('Entre Rios de Minas',11,'3123908')

insert into cidades values('Ervália',11,'3124005')

insert into cidades values('Esmeraldas',11,'3124104')

insert into cidades values('Espera Feliz',11,'3124203')

insert into cidades values('Espinosa',11,'3124302')

insert into cidades values('Espírito Santo do Dourado',11,'3124401')

insert into cidades values('Estiva',11,'3124500')

insert into cidades values('Estrela Dalva',11,'3124609')

insert into cidades values('Estrela do Indaiá',11,'3124708')

insert into cidades values('Estrela do Sul',11,'3124807')

insert into cidades values('Eugenópolis',11,'3124906')

insert into cidades values('Ewbank da Câmara',11,'3125002')

insert into cidades values('Extrema',11,'3125101')

insert into cidades values('Fama',11,'3125200')

insert into cidades values('Faria Lemos',11,'3125309')

insert into cidades values('Felício dos Santos',11,'3125408')

insert into cidades values('Felisburgo',11,'3125606')

insert into cidades values('Felixlândia',11,'3125705')

insert into cidades values('Fernandes Tourinho',11,'3125804')

insert into cidades values('Ferros',11,'3125903')

insert into cidades values('Fervedouro',11,'3125952')

insert into cidades values('Florestal',11,'3126000')

insert into cidades values('Formiga',11,'3126109')

insert into cidades values('Formoso',11,'3126208')

insert into cidades values('Fortaleza de Minas',11,'3126307')

insert into cidades values('Fortuna de Minas',11,'3126406')

insert into cidades values('Francisco Badaró',11,'3126505')

insert into cidades values('Francisco Dumont',11,'3126604')

insert into cidades values('Francisco Sá',11,'3126703')

insert into cidades values('Franciscópolis',11,'3126752')

insert into cidades values('Frei Gaspar',11,'3126802')

insert into cidades values('Frei Inocêncio',11,'3126901')

insert into cidades values('Frei Lagonegro',11,'3126950')

insert into cidades values('Fronteira',11,'3127008')

insert into cidades values('Fronteira dos Vales',11,'3127057')

insert into cidades values('Fruta de Leite',11,'3127073')

insert into cidades values('Frutal',11,'3127107')

insert into cidades values('Funilândia',11,'3127206')

insert into cidades values('Galiléia',11,'3127305')

insert into cidades values('Gameleiras',11,'3127339')

insert into cidades values('Glaucilândia',11,'3127354')

insert into cidades values('Goiabeira',11,'3127370')

insert into cidades values('Goianá',11,'3127388')

insert into cidades values('Gonçalves',11,'3127404')

insert into cidades values('Gonzaga',11,'3127503')

insert into cidades values('Gouveia',11,'3127602')

insert into cidades values('Governador Valadares',11,'3127701')

insert into cidades values('Grão Mogol',11,'3127800')

insert into cidades values('Grupiara',11,'3127909')

insert into cidades values('Guanhães',11,'3128006')

insert into cidades values('Guapé',11,'3128105')

insert into cidades values('Guaraciaba',11,'3128204')

insert into cidades values('Guaraciama',11,'3128253')

insert into cidades values('Guaranésia',11,'3128303')

insert into cidades values('Guarani',11,'3128402')

insert into cidades values('Guarará',11,'3128501')

insert into cidades values('Guarda-Mor',11,'3128600')

insert into cidades values('Guaxupé',11,'3128709')

insert into cidades values('Guidoval',11,'3128808')

insert into cidades values('Guimarânia',11,'3128907')

insert into cidades values('Guiricema',11,'3129004')

insert into cidades values('Gurinhatã',11,'3129103')

insert into cidades values('Heliodora',11,'3129202')

insert into cidades values('Iapu',11,'3129301')

insert into cidades values('Ibertioga',11,'3129400')

insert into cidades values('Ibiá',11,'3129509')

insert into cidades values('Ibiaí',11,'3129608')

insert into cidades values('Ibiracatu',11,'3129657')

insert into cidades values('Ibiraci',11,'3129707')

insert into cidades values('Ibirité',11,'3129806')

insert into cidades values('Ibitiúra de Minas',11,'3129905')

insert into cidades values('Ibituruna',11,'3130002')

insert into cidades values('Icaraí de Minas',11,'3130051')

insert into cidades values('Igarapé',11,'3130101')

insert into cidades values('Igaratinga',11,'3130200')

insert into cidades values('Iguatama',11,'3130309')

insert into cidades values('Ijaci',11,'3130408')

insert into cidades values('Ilicínea',11,'3130507')

insert into cidades values('Imbé de Minas',11,'3130556')

insert into cidades values('Inconfidentes',11,'3130606')

insert into cidades values('Indaiabira',11,'3130655')

insert into cidades values('Indianópolis',11,'3130705')

insert into cidades values('Ingaí',11,'3130804')

insert into cidades values('Inhapim',11,'3130903')

insert into cidades values('Inhaúma',11,'3131000')

insert into cidades values('Inimutaba',11,'3131109')

insert into cidades values('Ipaba',11,'3131158')

insert into cidades values('Ipanema',11,'3131208')

insert into cidades values('Ipatinga',11,'3131307')

insert into cidades values('Ipiaçu',11,'3131406')

insert into cidades values('Ipuiúna',11,'3131505')

insert into cidades values('Iraí de Minas',11,'3131604')

insert into cidades values('Itabira',11,'3131703')

insert into cidades values('Itabirito',11,'3131901')

insert into cidades values('Itacambira',11,'3132008')

insert into cidades values('Itacarambi',11,'3132107')

insert into cidades values('Itaguara',11,'3132206')

insert into cidades values('Itaipé',11,'3132305')

insert into cidades values('Itajubá',11,'3132404')

insert into cidades values('Itamarandiba',11,'3132503')

insert into cidades values('Itamarati de Minas',11,'3132602')

insert into cidades values('Itambacuri',11,'3132701')

insert into cidades values('Itambé do Mato Dentro',11,'3132800')

insert into cidades values('Itamogi',11,'3132909')

insert into cidades values('Itamonte',11,'3133006')

insert into cidades values('Itanhandu',11,'3133105')

insert into cidades values('Itanhomi',11,'3133204')

insert into cidades values('Itaobim',11,'3133303')

insert into cidades values('Itapagipe',11,'3133402')

insert into cidades values('Itapecerica',11,'3133501')

insert into cidades values('Itapeva',11,'3133600')

insert into cidades values('Itatiaiuçu',11,'3133709')

insert into cidades values('Itaú de Minas',11,'3133758')

insert into cidades values('Itaúna',11,'3133808')

insert into cidades values('Itaverava',11,'3133907')

insert into cidades values('Itinga',11,'3134004')

insert into cidades values('Itueta',11,'3134103')

insert into cidades values('Ituiutaba',11,'3134202')

insert into cidades values('Itumirim',11,'3134301')

insert into cidades values('Iturama',11,'3134400')

insert into cidades values('Itutinga',11,'3134509')

insert into cidades values('Jaboticatubas',11,'3134608')

insert into cidades values('Jacinto',11,'3134707')

insert into cidades values('Jacuí',11,'3134806')

insert into cidades values('Jacutinga',11,'3134905')

insert into cidades values('Jaguaraçu',11,'3135001')

insert into cidades values('Jaíba',11,'3135050')

insert into cidades values('Jampruca',11,'3135076')

insert into cidades values('Janaúba',11,'3135100')

insert into cidades values('Januária',11,'3135209')

insert into cidades values('Japaraíba',11,'3135308')

insert into cidades values('Japonvar',11,'3135357')

insert into cidades values('Jeceaba',11,'3135407')

insert into cidades values('Jenipapo de Minas',11,'3135456')

insert into cidades values('Jequeri',11,'3135506')

insert into cidades values('Jequitaí',11,'3135605')

insert into cidades values('Jequitibá',11,'3135704')

insert into cidades values('Jequitinhonha',11,'3135803')

insert into cidades values('Jesuânia',11,'3135902')

insert into cidades values('Joaíma',11,'3136009')

insert into cidades values('Joanésia',11,'3136108')

insert into cidades values('João Monlevade',11,'3136207')

insert into cidades values('João Pinheiro',11,'3136306')

insert into cidades values('Joaquim Felício',11,'3136405')

insert into cidades values('Jordânia',11,'3136504')

insert into cidades values('José Gonçalves de Minas',11,'3136520')

insert into cidades values('José Raydan',11,'3136553')

insert into cidades values('Josenópolis',11,'3136579')

insert into cidades values('Juatuba',11,'3136652')

insert into cidades values('Juiz de Fora',11,'3136702')

insert into cidades values('Juramento',11,'3136801')

insert into cidades values('Juruaia',11,'3136900')

insert into cidades values('Juvenília',11,'3136959')

insert into cidades values('Ladainha',11,'3137007')

insert into cidades values('Lagamar',11,'3137106')

insert into cidades values('Lagoa da Prata',11,'3137205')

insert into cidades values('Lagoa dos Patos',11,'3137304')

insert into cidades values('Lagoa Dourada',11,'3137403')

insert into cidades values('Lagoa Formosa',11,'3137502')

insert into cidades values('Lagoa Grande',11,'3137536')

insert into cidades values('Lagoa Santa',11,'3137601')

insert into cidades values('Lajinha',11,'3137700')

insert into cidades values('Lambari',11,'3137809')

insert into cidades values('Lamim',11,'3137908')

insert into cidades values('Laranjal',11,'3138005')

insert into cidades values('Lassance',11,'3138104')

insert into cidades values('Lavras',11,'3138203')

insert into cidades values('Leandro Ferreira',11,'3138302')

insert into cidades values('Leme do Prado',11,'3138351')

insert into cidades values('Leopoldina',11,'3138401')

insert into cidades values('Liberdade',11,'3138500')

insert into cidades values('Lima Duarte',11,'3138609')

insert into cidades values('Limeira do Oeste',11,'3138625')

insert into cidades values('Lontra',11,'3138658')

insert into cidades values('Luisburgo',11,'3138674')

insert into cidades values('Luislândia',11,'3138682')

insert into cidades values('Luminárias',11,'3138708')

insert into cidades values('Luz',11,'3138807')

insert into cidades values('Machacalis',11,'3138906')

insert into cidades values('Machado',11,'3139003')

insert into cidades values('Madre de Deus de Minas',11,'3139102')

insert into cidades values('Malacacheta',11,'3139201')

insert into cidades values('Mamonas',11,'3139250')

insert into cidades values('Manga',11,'3139300')

insert into cidades values('Manhuaçu',11,'3139409')

insert into cidades values('Manhumirim',11,'3139508')

insert into cidades values('Mantena',11,'3139607')

insert into cidades values('Mar de Espanha',11,'3139805')

insert into cidades values('Maravilhas',11,'3139706')

insert into cidades values('Maria da Fé',11,'3139904')

insert into cidades values('Mariana',11,'3140001')

insert into cidades values('Marilac',11,'3140100')

insert into cidades values('Mário Campos',11,'3140159')

insert into cidades values('Maripá de Minas',11,'3140209')

insert into cidades values('Marliéria',11,'3140308')

insert into cidades values('Marmelópolis',11,'3140407')

insert into cidades values('Martinho Campos',11,'3140506')

insert into cidades values('Martins Soares',11,'3140530')

insert into cidades values('Mata Verde',11,'3140555')

insert into cidades values('Materlândia',11,'3140605')

insert into cidades values('Mateus Leme',11,'3140704')

insert into cidades values('Mathias Lobato',11,'3171501')

insert into cidades values('Matias Barbosa',11,'3140803')

insert into cidades values('Matias Cardoso',11,'3140852')

insert into cidades values('Matipó',11,'3140902')

insert into cidades values('Mato Verde',11,'3141009')

insert into cidades values('Matozinhos',11,'3141108')

insert into cidades values('Matutina',11,'3141207')

insert into cidades values('Medeiros',11,'3141306')

insert into cidades values('Medina',11,'3141405')

insert into cidades values('Mendes Pimentel',11,'3141504')

insert into cidades values('Mercês',11,'3141603')

insert into cidades values('Mesquita',11,'3141702')

insert into cidades values('Minas Novas',11,'3141801')

insert into cidades values('Minduri',11,'3141900')

insert into cidades values('Mirabela',11,'3142007')

insert into cidades values('Miradouro',11,'3142106')

insert into cidades values('Miraí',11,'3142205')

insert into cidades values('Miravânia',11,'3142254')

insert into cidades values('Moeda',11,'3142304')

insert into cidades values('Moema',11,'3142403')

insert into cidades values('Monjolos',11,'3142502')

insert into cidades values('Monsenhor Paulo',11,'3142601')

insert into cidades values('Montalvânia',11,'3142700')

insert into cidades values('Monte Alegre de Minas',11,'3142809')

insert into cidades values('Monte Azul',11,'3142908')

insert into cidades values('Monte Belo',11,'3143005')

insert into cidades values('Monte Carmelo',11,'3143104')

insert into cidades values('Monte Formoso',11,'3143153')

insert into cidades values('Monte Santo de Minas',11,'3143203')

insert into cidades values('Monte Sião',11,'3143401')

insert into cidades values('Montes Claros',11,'3143302')

insert into cidades values('Montezuma',11,'3143450')

insert into cidades values('Morada Nova de Minas',11,'3143500')

insert into cidades values('Morro da Garça',11,'3143609')

insert into cidades values('Morro do Pilar',11,'3143708')

insert into cidades values('Munhoz',11,'3143807')

insert into cidades values('Muriaé',11,'3143906')

insert into cidades values('Mutum',11,'3144003')

insert into cidades values('Muzambinho',11,'3144102')

insert into cidades values('Nacip Raydan',11,'3144201')

insert into cidades values('Nanuque',11,'3144300')

insert into cidades values('Naque',11,'3144359')

insert into cidades values('Natalândia',11,'3144375')

insert into cidades values('Natércia',11,'3144409')

insert into cidades values('Nazareno',11,'3144508')

insert into cidades values('Nepomuceno',11,'3144607')

insert into cidades values('Ninheira',11,'3144656')

insert into cidades values('Nova Belém',11,'3144672')

insert into cidades values('Nova Era',11,'3144706')

insert into cidades values('Nova Lima',11,'3144805')

insert into cidades values('Nova Módica',11,'3144904')

insert into cidades values('Nova Ponte',11,'3145000')

insert into cidades values('Nova Porteirinha',11,'3145059')

insert into cidades values('Nova Resende',11,'3145109')

insert into cidades values('Nova Serrana',11,'3145208')

insert into cidades values('Nova União',11,'3136603')

insert into cidades values('Novo Cruzeiro',11,'3145307')

insert into cidades values('Novo Oriente de Minas',11,'3145356')

insert into cidades values('Novorizonte',11,'3145372')

insert into cidades values('Olaria',11,'3145406')

insert into cidades values('Olhos-dÁgua',11,'3145455')

insert into cidades values('Olímpio Noronha',11,'3145505')

insert into cidades values('Oliveira',11,'3145604')

insert into cidades values('Oliveira Fortes',11,'3145703')

insert into cidades values('Onça de Pitangui',11,'3145802')

insert into cidades values('Oratórios',11,'3145851')

insert into cidades values('Orizânia',11,'3145877')

insert into cidades values('Ouro Branco',11,'3145901')

insert into cidades values('Ouro Fino',11,'3146008')

insert into cidades values('Ouro Preto',11,'3146107')

insert into cidades values('Ouro Verde de Minas',11,'3146206')

insert into cidades values('Padre Carvalho',11,'3146255')

insert into cidades values('Padre Paraíso',11,'3146305')

insert into cidades values('Pai Pedro',11,'3146552')

insert into cidades values('Paineiras',11,'3146404')

insert into cidades values('Pains',11,'3146503')

insert into cidades values('Paiva',11,'3146602')

insert into cidades values('Palma',11,'3146701')

insert into cidades values('Palmópolis',11,'3146750')

insert into cidades values('Papagaios',11,'3146909')

insert into cidades values('Pará de Minas',11,'3147105')

insert into cidades values('Paracatu',11,'3147006')

insert into cidades values('Paraguaçu',11,'3147204')

insert into cidades values('Paraisópolis',11,'3147303')

insert into cidades values('Paraopeba',11,'3147402')

insert into cidades values('Passa Quatro',11,'3147600')

insert into cidades values('Passa Tempo',11,'3147709')

insert into cidades values('Passabém',11,'3147501')

insert into cidades values('Passa-Vinte',11,'3147808')

insert into cidades values('Passos',11,'3147907')

insert into cidades values('Patis',11,'3147956')

insert into cidades values('Patos de Minas',11,'3148004')

insert into cidades values('Patrocínio',11,'3148103')

insert into cidades values('Patrocínio do Muriaé',11,'3148202')

insert into cidades values('Paula Cândido',11,'3148301')

insert into cidades values('Paulistas',11,'3148400')

insert into cidades values('Pavão',11,'3148509')

insert into cidades values('Peçanha',11,'3148608')

insert into cidades values('Pedra Azul',11,'3148707')

insert into cidades values('Pedra Bonita',11,'3148756')

insert into cidades values('Pedra do Anta',11,'3148806')

insert into cidades values('Pedra do Indaiá',11,'3148905')

insert into cidades values('Pedra Dourada',11,'3149002')

insert into cidades values('Pedralva',11,'3149101')

insert into cidades values('Pedras de Maria da Cruz',11,'3149150')

insert into cidades values('Pedrinópolis',11,'3149200')

insert into cidades values('Pedro Leopoldo',11,'3149309')

insert into cidades values('Pedro Teixeira',11,'3149408')

insert into cidades values('Pequeri',11,'3149507')

insert into cidades values('Pequi',11,'3149606')

insert into cidades values('Perdigão',11,'3149705')

insert into cidades values('Perdizes',11,'3149804')

insert into cidades values('Perdões',11,'3149903')

insert into cidades values('Periquito',11,'3149952')

insert into cidades values('Pescador',11,'3150000')

insert into cidades values('Piau',11,'3150109')

insert into cidades values('Piedade de Caratinga',11,'3150158')

insert into cidades values('Piedade de Ponte Nova',11,'3150208')

insert into cidades values('Piedade do Rio Grande',11,'3150307')

insert into cidades values('Piedade dos Gerais',11,'3150406')

insert into cidades values('Pimenta',11,'3150505')

insert into cidades values('Pingo-dÁgua',11,'3150539')

insert into cidades values('Pintópolis',11,'3150570')

insert into cidades values('Piracema',11,'3150604')

insert into cidades values('Pirajuba',11,'3150703')

insert into cidades values('Piranga',11,'3150802')

insert into cidades values('Piranguçu',11,'3150901')

insert into cidades values('Piranguinho',11,'3151008')

insert into cidades values('Pirapetinga',11,'3151107')

insert into cidades values('Pirapora',11,'3151206')

insert into cidades values('Piraúba',11,'3151305')

insert into cidades values('Pitangui',11,'3151404')

insert into cidades values('Piumhi',11,'3151503')

insert into cidades values('Planura',11,'3151602')

insert into cidades values('Poço Fundo',11,'3151701')

insert into cidades values('Poços de Caldas',11,'3151800')

insert into cidades values('Pocrane',11,'3151909')

insert into cidades values('Pompéu',11,'3152006')

insert into cidades values('Ponte Nova',11,'3152105')

insert into cidades values('Ponto Chique',11,'3152131')

insert into cidades values('Ponto dos Volantes',11,'3152170')

insert into cidades values('Porteirinha',11,'3152204')

insert into cidades values('Porto Firme',11,'3152303')

insert into cidades values('Poté',11,'3152402')

insert into cidades values('Pouso Alegre',11,'3152501')

insert into cidades values('Pouso Alto',11,'3152600')

insert into cidades values('Prados',11,'3152709')

insert into cidades values('Prata',11,'3152808')

insert into cidades values('Pratápolis',11,'3152907')

insert into cidades values('Pratinha',11,'3153004')

insert into cidades values('Presidente Bernardes',11,'3153103')

insert into cidades values('Presidente Juscelino',11,'3153202')

insert into cidades values('Presidente Kubitschek',11,'3153301')

insert into cidades values('Presidente Olegário',11,'3153400')

insert into cidades values('Prudente de Morais',11,'3153608')

insert into cidades values('Quartel Geral',11,'3153707')

insert into cidades values('Queluzito',11,'3153806')

insert into cidades values('Raposos',11,'3153905')

insert into cidades values('Raul Soares',11,'3154002')

insert into cidades values('Recreio',11,'3154101')

insert into cidades values('Reduto',11,'3154150')

insert into cidades values('Resende Costa',11,'3154200')

insert into cidades values('Resplendor',11,'3154309')

insert into cidades values('Ressaquinha',11,'3154408')

insert into cidades values('Riachinho',11,'3154457')

insert into cidades values('Riacho dos Machados',11,'3154507')

insert into cidades values('Ribeirão das Neves',11,'3154606')

insert into cidades values('Ribeirão Vermelho',11,'3154705')

insert into cidades values('Rio Acima',11,'3154804')

insert into cidades values('Rio Casca',11,'3154903')

insert into cidades values('Rio do Prado',11,'3155108')

insert into cidades values('Rio Doce',11,'3155009')

insert into cidades values('Rio Espera',11,'3155207')

insert into cidades values('Rio Manso',11,'3155306')

insert into cidades values('Rio Novo',11,'3155405')

insert into cidades values('Rio Paranaíba',11,'3155504')

insert into cidades values('Rio Pardo de Minas',11,'3155603')

insert into cidades values('Rio Piracicaba',11,'3155702')

insert into cidades values('Rio Pomba',11,'3155801')

insert into cidades values('Rio Preto',11,'3155900')

insert into cidades values('Rio Vermelho',11,'3156007')

insert into cidades values('Ritápolis',11,'3156106')

insert into cidades values('Rochedo de Minas',11,'3156205')

insert into cidades values('Rodeiro',11,'3156304')

insert into cidades values('Romaria',11,'3156403')

insert into cidades values('Rosário da Limeira',11,'3156452')

insert into cidades values('Rubelita',11,'3156502')

insert into cidades values('Rubim',11,'3156601')

insert into cidades values('Sabará',11,'3156700')

insert into cidades values('Sabinópolis',11,'3156809')

insert into cidades values('Sacramento',11,'3156908')

insert into cidades values('Salinas',11,'3157005')

insert into cidades values('Salto da Divisa',11,'3157104')

insert into cidades values('Santa Bárbara',11,'3157203')

insert into cidades values('Santa Bárbara do Leste',11,'3157252')

insert into cidades values('Santa Bárbara do Monte Verde',11,'3157278')

insert into cidades values('Santa Bárbara do Tugúrio',11,'3157302')

insert into cidades values('Santa Cruz de Minas',11,'3157336')

insert into cidades values('Santa Cruz de Salinas',11,'3157377')

insert into cidades values('Santa Cruz do Escalvado',11,'3157401')

insert into cidades values('Santa Efigênia de Minas',11,'3157500')

insert into cidades values('Santa Fé de Minas',11,'3157609')

insert into cidades values('Santa Helena de Minas',11,'3157658')

insert into cidades values('Santa Juliana',11,'3157708')

insert into cidades values('Santa Luzia',11,'3157807')

insert into cidades values('Santa Margarida',11,'3157906')

insert into cidades values('Santa Maria de Itabira',11,'3158003')

insert into cidades values('Santa Maria do Salto',11,'3158102')

insert into cidades values('Santa Maria do Suaçuí',11,'3158201')

insert into cidades values('Santa Rita de Caldas',11,'3159209')

insert into cidades values('Santa Rita de Ibitipoca',11,'3159407')

insert into cidades values('Santa Rita de Jacutinga',11,'3159308')

insert into cidades values('Santa Rita de Minas',11,'3159357')

insert into cidades values('Santa Rita do Itueto',11,'3159506')

insert into cidades values('Santa Rita do Sapucaí',11,'3159605')

insert into cidades values('Santa Rosa da Serra',11,'3159704')

insert into cidades values('Santa Vitória',11,'3159803')

insert into cidades values('Santana da Vargem',11,'3158300')

insert into cidades values('Santana de Cataguases',11,'3158409')

insert into cidades values('Santana de Pirapama',11,'3158508')

insert into cidades values('Santana do Deserto',11,'3158607')

insert into cidades values('Santana do Garambéu',11,'3158706')

insert into cidades values('Santana do Jacaré',11,'3158805')

insert into cidades values('Santana do Manhuaçu',11,'3158904')

insert into cidades values('Santana do Paraíso',11,'3158953')

insert into cidades values('Santana do Riacho',11,'3159001')

insert into cidades values('Santana dos Montes',11,'3159100')

insert into cidades values('Santo Antônio do Amparo',11,'3159902')

insert into cidades values('Santo Antônio do Aventureiro',11,'3160009')

insert into cidades values('Santo Antônio do Grama',11,'3160108')

insert into cidades values('Santo Antônio do Itambé',11,'3160207')

insert into cidades values('Santo Antônio do Jacinto',11,'3160306')

insert into cidades values('Santo Antônio do Monte',11,'3160405')

insert into cidades values('Santo Antônio do Retiro',11,'3160454')

insert into cidades values('Santo Antônio do Rio Abaixo',11,'3160504')

insert into cidades values('Santo Hipólito',11,'3160603')

insert into cidades values('Santos Dumont',11,'3160702')

insert into cidades values('São Bento Abade',11,'3160801')

insert into cidades values('São Brás do Suaçuí',11,'3160900')

insert into cidades values('São Domingos das Dores',11,'3160959')

insert into cidades values('São Domingos do Prata',11,'3161007')

insert into cidades values('São Félix de Minas',11,'3161056')

insert into cidades values('São Francisco',11,'3161106')

insert into cidades values('São Francisco de Paula',11,'3161205')

insert into cidades values('São Francisco de Sales',11,'3161304')

insert into cidades values('São Francisco do Glória',11,'3161403')

insert into cidades values('São Geraldo',11,'3161502')

insert into cidades values('São Geraldo da Piedade',11,'3161601')

insert into cidades values('São Geraldo do Baixio',11,'3161650')

insert into cidades values('São Gonçalo do Abaeté',11,'3161700')

insert into cidades values('São Gonçalo do Pará',11,'3161809')

insert into cidades values('São Gonçalo do Rio Abaixo',11,'3161908')

insert into cidades values('São Gonçalo do Rio Preto',11,'3125507')

insert into cidades values('São Gonçalo do Sapucaí',11,'3162005')

insert into cidades values('São Gotardo',11,'3162104')

insert into cidades values('São João Batista do Glória',11,'3162203')

insert into cidades values('São João da Lagoa',11,'3162252')

insert into cidades values('São João da Mata',11,'3162302')

insert into cidades values('São João da Ponte',11,'3162401')

insert into cidades values('São João das Missões',11,'3162450')

insert into cidades values('São João del Rei',11,'3162500')

insert into cidades values('São João do Manhuaçu',11,'3162559')

insert into cidades values('São João do Manteninha',11,'3162575')

insert into cidades values('São João do Oriente',11,'3162609')

insert into cidades values('São João do Pacuí',11,'3162658')

insert into cidades values('São João do Paraíso',11,'3162708')

insert into cidades values('São João Evangelista',11,'3162807')

insert into cidades values('São João Nepomuceno',11,'3162906')

insert into cidades values('São Joaquim de Bicas',11,'3162922')

insert into cidades values('São José da Barra',11,'3162948')

insert into cidades values('São José da Lapa',11,'3162955')

insert into cidades values('São José da Safira',11,'3163003')

insert into cidades values('São José da Varginha',11,'3163102')

insert into cidades values('São José do Alegre',11,'3163201')

insert into cidades values('São José do Divino',11,'3163300')

insert into cidades values('São José do Goiabal',11,'3163409')

insert into cidades values('São José do Jacuri',11,'3163508')

insert into cidades values('São José do Mantimento',11,'3163607')

insert into cidades values('São Lourenço',11,'3163706')

insert into cidades values('São Miguel do Anta',11,'3163805')

insert into cidades values('São Pedro da União',11,'3163904')

insert into cidades values('São Pedro do Suaçuí',11,'3164100')

insert into cidades values('São Pedro dos Ferros',11,'3164001')

insert into cidades values('São Romão',11,'3164209')

insert into cidades values('São Roque de Minas',11,'3164308')

insert into cidades values('São Sebastião da Bela Vista',11,'3164407')

insert into cidades values('São Sebastião da Vargem Alegre',11,'3164431')

insert into cidades values('São Sebastião do Anta',11,'3164472')

insert into cidades values('São Sebastião do Maranhão',11,'3164506')

insert into cidades values('São Sebastião do Oeste',11,'3164605')

insert into cidades values('São Sebastião do Paraíso',11,'3164704')

insert into cidades values('São Sebastião do Rio Preto',11,'3164803')

insert into cidades values('São Sebastião do Rio Verde',11,'3164902')

insert into cidades values('São Thomé das Letras',11,'3165206')

insert into cidades values('São Tiago',11,'3165008')

insert into cidades values('São Tomás de Aquino',11,'3165107')

insert into cidades values('São Vicente de Minas',11,'3165305')

insert into cidades values('Sapucaí-Mirim',11,'3165404')

insert into cidades values('Sardoá',11,'3165503')

insert into cidades values('Sarzedo',11,'3165537')

insert into cidades values('Sem-Peixe',11,'3165560')

insert into cidades values('Senador Amaral',11,'3165578')

insert into cidades values('Senador Cortes',11,'3165602')

insert into cidades values('Senador Firmino',11,'3165701')

insert into cidades values('Senador José Bento',11,'3165800')

insert into cidades values('Senador Modestino Gonçalves',11,'3165909')

insert into cidades values('Senhora de Oliveira',11,'3166006')

insert into cidades values('Senhora do Porto',11,'3166105')

insert into cidades values('Senhora dos Remédios',11,'3166204')

insert into cidades values('Sericita',11,'3166303')

insert into cidades values('Seritinga',11,'3166402')

insert into cidades values('Serra Azul de Minas',11,'3166501')

insert into cidades values('Serra da Saudade',11,'3166600')

insert into cidades values('Serra do Salitre',11,'3166808')

insert into cidades values('Serra dos Aimorés',11,'3166709')

insert into cidades values('Serrania',11,'3166907')

insert into cidades values('Serranópolis de Minas',11,'3166956')

insert into cidades values('Serranos',11,'3167004')

insert into cidades values('Serro',11,'3167103')

insert into cidades values('Sete Lagoas',11,'3167202')

insert into cidades values('Setubinha',11,'3165552')

insert into cidades values('Silveirânia',11,'3167301')

insert into cidades values('Silvianópolis',11,'3167400')

insert into cidades values('Simão Pereira',11,'3167509')

insert into cidades values('Simonésia',11,'3167608')

insert into cidades values('Sobrália',11,'3167707')

insert into cidades values('Soledade de Minas',11,'3167806')

insert into cidades values('Tabuleiro',11,'3167905')

insert into cidades values('Taiobeiras',11,'3168002')

insert into cidades values('Taparuba',11,'3168051')

insert into cidades values('Tapira',11,'3168101')

insert into cidades values('Tapiraí',11,'3168200')

insert into cidades values('Taquaraçu de Minas',11,'3168309')

insert into cidades values('Tarumirim',11,'3168408')

insert into cidades values('Teixeiras',11,'3168507')

insert into cidades values('Teófilo Otoni',11,'3168606')

insert into cidades values('Timóteo',11,'3168705')

insert into cidades values('Tiradentes',11,'3168804')

insert into cidades values('Tiros',11,'3168903')

insert into cidades values('Tocantins',11,'3169000')

insert into cidades values('Tocos do Moji',11,'3169059')

insert into cidades values('Toledo',11,'3169109')

insert into cidades values('Tombos',11,'3169208')

insert into cidades values('Três Corações',11,'3169307')

insert into cidades values('Três Marias',11,'3169356')

insert into cidades values('Três Pontas',11,'3169406')

insert into cidades values('Tumiritinga',11,'3169505')

insert into cidades values('Tupaciguara',11,'3169604')

insert into cidades values('Turmalina',11,'3169703')

insert into cidades values('Turvolândia',11,'3169802')

insert into cidades values('Ubá',11,'3169901')

insert into cidades values('Ubaí',11,'3170008')

insert into cidades values('Ubaporanga',11,'3170057')

insert into cidades values('Uberaba',11,'3170107')

insert into cidades values('Uberlândia',11,'3170206')

insert into cidades values('Umburatiba',11,'3170305')

insert into cidades values('Unaí',11,'3170404')

insert into cidades values('União de Minas',11,'3170438')

insert into cidades values('Uruana de Minas',11,'3170479')

insert into cidades values('Urucânia',11,'3170503')

insert into cidades values('Urucuia',11,'3170529')

insert into cidades values('Vargem Alegre',11,'3170578')

insert into cidades values('Vargem Bonita',11,'3170602')

insert into cidades values('Vargem Grande do Rio Pardo',11,'3170651')

insert into cidades values('Varginha',11,'3170701')

insert into cidades values('Varjão de Minas',11,'3170750')

insert into cidades values('Várzea da Palma',11,'3170800')

insert into cidades values('Varzelândia',11,'3170909')

insert into cidades values('Vazante',11,'3171006')

insert into cidades values('Verdelândia',11,'3171030')

insert into cidades values('Veredinha',11,'3171071')

insert into cidades values('Veríssimo',11,'3171105')

insert into cidades values('Vermelho Novo',11,'3171154')

insert into cidades values('Vespasiano',11,'3171204')

insert into cidades values('Viçosa',11,'3171303')

insert into cidades values('Vieiras',11,'3171402')

insert into cidades values('Virgem da Lapa',11,'3171600')

insert into cidades values('Virgínia',11,'3171709')

insert into cidades values('Virginópolis',11,'3171808')

insert into cidades values('Virgolândia',11,'3171907')

insert into cidades values('Visconde do Rio Branco',11,'3172004')

insert into cidades values('Volta Grande',11,'3172103')

insert into cidades values('Wenceslau Braz',11,'3172202')

insert into cidades values('Abaetetuba',14,'1500107')

insert into cidades values('Abel Figueiredo',14,'1500131')

insert into cidades values('Acará',14,'1500206')

insert into cidades values('Afuá',14,'1500305')

insert into cidades values('Água Azul do Norte',14,'1500347')

insert into cidades values('Alenquer',14,'1500404')

insert into cidades values('Almeirim',14,'1500503')

insert into cidades values('Altamira',14,'1500602')

insert into cidades values('Anajás',14,'1500701')

insert into cidades values('Ananindeua',14,'1500800')

insert into cidades values('Anapu',14,'1500859')

insert into cidades values('Augusto Corrêa',14,'1500909')

insert into cidades values('Aurora do Pará',14,'1500958')

insert into cidades values('Aveiro',14,'1501006')

insert into cidades values('Bagre',14,'1501105')

insert into cidades values('Baião',14,'1501204')

insert into cidades values('Bannach',14,'1501253')

insert into cidades values('Barcarena',14,'1501303')

insert into cidades values('Belém',14,'1501402')

insert into cidades values('Belterra',14,'1501451')

insert into cidades values('Benevides',14,'1501501')

insert into cidades values('Bom Jesus do Tocantins',14,'1501576')

insert into cidades values('Bonito',14,'1501600')

insert into cidades values('Bragança',14,'1501709')

insert into cidades values('Brasil Novo',14,'1501725')

insert into cidades values('Brejo Grande do Araguaia',14,'1501758')

insert into cidades values('Breu Branco',14,'1501782')

insert into cidades values('Breves',14,'1501808')

insert into cidades values('Bujaru',14,'1501907')

insert into cidades values('Cachoeira do Arari',14,'1502004')

insert into cidades values('Cachoeira do Piriá',14,'1501956')

insert into cidades values('Cametá',14,'1502103')

insert into cidades values('Canaã dos Carajás',14,'1502152')

insert into cidades values('Capanema',14,'1502202')

insert into cidades values('Capitão Poço',14,'1502301')

insert into cidades values('Castanhal',14,'1502400')

insert into cidades values('Chaves',14,'1502509')

insert into cidades values('Colares',14,'1502608')

insert into cidades values('Conceição do Araguaia',14,'1502707')

insert into cidades values('Concórdia do Pará',14,'1502756')

insert into cidades values('Cumaru do Norte',14,'1502764')

insert into cidades values('Curionópolis',14,'1502772')

insert into cidades values('Curralinho',14,'1502806')

insert into cidades values('Curuá',14,'1502855')

insert into cidades values('Curuçá',14,'1502905')

insert into cidades values('Dom Eliseu',14,'1502939')

insert into cidades values('Eldorado dos Carajás',14,'1502954')

insert into cidades values('Faro',14,'1503002')

insert into cidades values('Floresta do Araguaia',14,'1503044')

insert into cidades values('Garrafão do Norte',14,'1503077')

insert into cidades values('Goianésia do Pará',14,'1503093')

insert into cidades values('Gurupá',14,'1503101')

insert into cidades values('Igarapé-Açu',14,'1503200')

insert into cidades values('Igarapé-Miri',14,'1503309')

insert into cidades values('Inhangapi',14,'1503408')

insert into cidades values('Ipixuna do Pará',14,'1503457')

insert into cidades values('Irituia',14,'1503507')

insert into cidades values('Itaituba',14,'1503606')

insert into cidades values('Itupiranga',14,'1503705')

insert into cidades values('Jacareacanga',14,'1503754')

insert into cidades values('Jacundá',14,'1503804')

insert into cidades values('Juruti',14,'1503903')

insert into cidades values('Limoeiro do Ajuru',14,'1504000')

insert into cidades values('Mãe do Rio',14,'1504059')

insert into cidades values('Magalhães Barata',14,'1504109')

insert into cidades values('Marabá',14,'1504208')

insert into cidades values('Maracanã',14,'1504307')

insert into cidades values('Marapanim',14,'1504406')

insert into cidades values('Marituba',14,'1504422')

insert into cidades values('Medicilândia',14,'1504455')

insert into cidades values('Melgaço',14,'1504505')

insert into cidades values('Mocajuba',14,'1504604')

insert into cidades values('Moju',14,'1504703')

insert into cidades values('Monte Alegre',14,'1504802')

insert into cidades values('Muaná',14,'1504901')

insert into cidades values('Nova Esperança do Piriá',14,'1504950')

insert into cidades values('Nova Ipixuna',14,'1504976')

insert into cidades values('Nova Timboteua',14,'1505007')

insert into cidades values('Novo Progresso',14,'1505031')

insert into cidades values('Novo Repartimento',14,'1505064')

insert into cidades values('Óbidos',14,'1505106')

insert into cidades values('Oeiras do Pará',14,'1505205')

insert into cidades values('Oriximiná',14,'1505304')

insert into cidades values('Ourém',14,'1505403')

insert into cidades values('Ourilândia do Norte',14,'1505437')

insert into cidades values('Pacajá',14,'1505486')

insert into cidades values('Palestina do Pará',14,'1505494')

insert into cidades values('Paragominas',14,'1505502')

insert into cidades values('Parauapebas',14,'1505536')

insert into cidades values('Pau dArco',14,'1505551')

insert into cidades values('Peixe-Boi',14,'1505601')

insert into cidades values('Piçarra',14,'1505635')

insert into cidades values('Placas',14,'1505650')

insert into cidades values('Ponta de Pedras',14,'1505700')

insert into cidades values('Portel',14,'1505809')

insert into cidades values('Porto de Moz',14,'1505908')

insert into cidades values('Prainha',14,'1506005')

insert into cidades values('Primavera',14,'1506104')

insert into cidades values('Quatipuru',14,'1506112')

insert into cidades values('Redenção',14,'1506138')

insert into cidades values('Rio Maria',14,'1506161')

insert into cidades values('Rondon do Pará',14,'1506187')

insert into cidades values('Rurópolis',14,'1506195')

insert into cidades values('Salinópolis',14,'1506203')

insert into cidades values('Salvaterra',14,'1506302')

insert into cidades values('Santa Bárbara do Pará',14,'1506351')

insert into cidades values('Santa Cruz do Arari',14,'1506401')

insert into cidades values('Santa Isabel do Pará',14,'1506500')

insert into cidades values('Santa Luzia do Pará',14,'1506559')

insert into cidades values('Santa Maria das Barreiras',14,'1506583')

insert into cidades values('Santa Maria do Pará',14,'1506609')

insert into cidades values('Santana do Araguaia',14,'1506708')

insert into cidades values('Santarém',14,'1506807')

insert into cidades values('Santarém Novo',14,'1506906')

insert into cidades values('Santo Antônio do Tauá',14,'1507003')

insert into cidades values('São Caetano de Odivelas',14,'1507102')

insert into cidades values('São Domingos do Araguaia',14,'1507151')

insert into cidades values('São Domingos do Capim',14,'1507201')

insert into cidades values('São Félix do Xingu',14,'1507300')

insert into cidades values('São Francisco do Pará',14,'1507409')

insert into cidades values('São Geraldo do Araguaia',14,'1507458')

insert into cidades values('São João da Ponta',14,'1507466')

insert into cidades values('São João de Pirabas',14,'1507474')

insert into cidades values('São João do Araguaia',14,'1507508')

insert into cidades values('São Miguel do Guamá',14,'1507607')

insert into cidades values('São Sebastião da Boa Vista',14,'1507706')

insert into cidades values('Sapucaia',14,'1507755')

insert into cidades values('Senador José Porfírio',14,'1507805')

insert into cidades values('Soure',14,'1507904')

insert into cidades values('Tailândia',14,'1507953')

insert into cidades values('Terra Alta',14,'1507961')

insert into cidades values('Terra Santa',14,'1507979')

insert into cidades values('Tomé-Açu',14,'1508001')

insert into cidades values('Tracuateua',14,'1508035')

insert into cidades values('Trairão',14,'1508050')

insert into cidades values('Tucumã',14,'1508084')

insert into cidades values('Tucuruí',14,'1508100')

insert into cidades values('Ulianópolis',14,'1508126')

insert into cidades values('Uruará',14,'1508159')

insert into cidades values('Vigia',14,'1508209')

insert into cidades values('Viseu',14,'1508308')

insert into cidades values('Vitória do Xingu',14,'1508357')

insert into cidades values('Xinguara',14,'1508407')

insert into cidades values('Água Branca',15,'2500106')

insert into cidades values('Aguiar',15,'2500205')

insert into cidades values('Alagoa Grande',15,'2500304')

insert into cidades values('Alagoa Nova',15,'2500403')

insert into cidades values('Alagoinha',15,'2500502')

insert into cidades values('Alcantil',15,'2500536')

insert into cidades values('Algodão de Jandaíra',15,'2500577')

insert into cidades values('Alhandra',15,'2500601')

insert into cidades values('Amparo',15,'2500734')

insert into cidades values('Aparecida',15,'2500775')

insert into cidades values('Araçagi',15,'2500809')

insert into cidades values('Arara',15,'2500908')

insert into cidades values('Araruna',15,'2501005')

insert into cidades values('Areia',15,'2501104')

insert into cidades values('Areia de Baraúnas',15,'2501153')

insert into cidades values('Areial',15,'2501203')

insert into cidades values('Aroeiras',15,'2501302')

insert into cidades values('Assunção',15,'2501351')

insert into cidades values('Baía da Traição',15,'2501401')

insert into cidades values('Bananeiras',15,'2501500')

insert into cidades values('Baraúna',15,'2501534')

insert into cidades values('Barra de Santa Rosa',15,'2501609')

insert into cidades values('Barra de Santana',15,'2501575')

insert into cidades values('Barra de São Miguel',15,'2501708')

insert into cidades values('Bayeux',15,'2501807')

insert into cidades values('Belém',15,'2501906')

insert into cidades values('Belém do Brejo do Cruz',15,'2502003')

insert into cidades values('Bernardino Batista',15,'2502052')

insert into cidades values('Boa Ventura',15,'2502102')

insert into cidades values('Boa Vista',15,'2502151')

insert into cidades values('Bom Jesus',15,'2502201')

insert into cidades values('Bom Sucesso',15,'2502300')

insert into cidades values('Bonito de Santa Fé',15,'2502409')

insert into cidades values('Boqueirão',15,'2502508')

insert into cidades values('Borborema',15,'2502706')

insert into cidades values('Brejo do Cruz',15,'2502805')

insert into cidades values('Brejo dos Santos',15,'2502904')

insert into cidades values('Caaporã',15,'2503001')

insert into cidades values('Cabaceiras',15,'2503100')

insert into cidades values('Cabedelo',15,'2503209')

insert into cidades values('Cachoeira dos Índios',15,'2503308')

insert into cidades values('Cacimba de Areia',15,'2503407')

insert into cidades values('Cacimba de Dentro',15,'2503506')

insert into cidades values('Cacimbas',15,'2503555')

insert into cidades values('Caiçara',15,'2503605')

insert into cidades values('Cajazeiras',15,'2503704')

insert into cidades values('Cajazeirinhas',15,'2503753')

insert into cidades values('Caldas Brandão',15,'2503803')

insert into cidades values('Camalaú',15,'2503902')

insert into cidades values('Campina Grande',15,'2504009')

insert into cidades values('Campo de Santana',15,'2516409')

insert into cidades values('Capim',15,'2504033')

insert into cidades values('Caraúbas',15,'2504074')

insert into cidades values('Carrapateira',15,'2504108')

insert into cidades values('Casserengue',15,'2504157')

insert into cidades values('Catingueira',15,'2504207')

insert into cidades values('Catolé do Rocha',15,'2504306')

insert into cidades values('Caturité',15,'2504355')

insert into cidades values('Conceição',15,'2504405')

insert into cidades values('Condado',15,'2504504')

insert into cidades values('Conde',15,'2504603')

insert into cidades values('Congo',15,'2504702')

insert into cidades values('Coremas',15,'2504801')

insert into cidades values('Coxixola',15,'2504850')

insert into cidades values('Cruz do Espírito Santo',15,'2504900')

insert into cidades values('Cubati',15,'2505006')

insert into cidades values('Cuité',15,'2505105')

insert into cidades values('Cuité de Mamanguape',15,'2505238')

insert into cidades values('Cuitegi',15,'2505204')

insert into cidades values('Curral de Cima',15,'2505279')

insert into cidades values('Curral Velho',15,'2505303')

insert into cidades values('Damião',15,'2505352')

insert into cidades values('Desterro',15,'2505402')

insert into cidades values('Diamante',15,'2505600')

insert into cidades values('Dona Inês',15,'2505709')

insert into cidades values('Duas Estradas',15,'2505808')

insert into cidades values('Emas',15,'2505907')

insert into cidades values('Esperança',15,'2506004')

insert into cidades values('Fagundes',15,'2506103')

insert into cidades values('Frei Martinho',15,'2506202')

insert into cidades values('Gado Bravo',15,'2506251')

insert into cidades values('Guarabira',15,'2506301')

insert into cidades values('Gurinhém',15,'2506400')

insert into cidades values('Gurjão',15,'2506509')

insert into cidades values('Ibiara',15,'2506608')

insert into cidades values('Igaracy',15,'2502607')

insert into cidades values('Imaculada',15,'2506707')

insert into cidades values('Ingá',15,'2506806')

insert into cidades values('Itabaiana',15,'2506905')

insert into cidades values('Itaporanga',15,'2507002')

insert into cidades values('Itapororoca',15,'2507101')

insert into cidades values('Itatuba',15,'2507200')

insert into cidades values('Jacaraú',15,'2507309')

insert into cidades values('Jericó',15,'2507408')

insert into cidades values('João Pessoa',15,'2507507')

insert into cidades values('Juarez Távora',15,'2507606')

insert into cidades values('Juazeirinho',15,'2507705')

insert into cidades values('Junco do Seridó',15,'2507804')

insert into cidades values('Juripiranga',15,'2507903')

insert into cidades values('Juru',15,'2508000')

insert into cidades values('Lagoa',15,'2508109')

insert into cidades values('Lagoa de Dentro',15,'2508208')

insert into cidades values('Lagoa Seca',15,'2508307')

insert into cidades values('Lastro',15,'2508406')

insert into cidades values('Livramento',15,'2508505')

insert into cidades values('Logradouro',15,'2508554')

insert into cidades values('Lucena',15,'2508604')

insert into cidades values('Mãe dÁgua',15,'2508703')

insert into cidades values('Malta',15,'2508802')

insert into cidades values('Mamanguape',15,'2508901')

insert into cidades values('Manaíra',15,'2509008')

insert into cidades values('Marcação',15,'2509057')

insert into cidades values('Mari',15,'2509107')

insert into cidades values('Marizópolis',15,'2509156')

insert into cidades values('Massaranduba',15,'2509206')

insert into cidades values('Mataraca',15,'2509305')

insert into cidades values('Matinhas',15,'2509339')

insert into cidades values('Mato Grosso',15,'2509370')

insert into cidades values('Maturéia',15,'2509396')

insert into cidades values('Mogeiro',15,'2509404')

insert into cidades values('Montadas',15,'2509503')

insert into cidades values('Monte Horebe',15,'2509602')

insert into cidades values('Monteiro',15,'2509701')

insert into cidades values('Mulungu',15,'2509800')

insert into cidades values('Natuba',15,'2509909')

insert into cidades values('Nazarezinho',15,'2510006')

insert into cidades values('Nova Floresta',15,'2510105')

insert into cidades values('Nova Olinda',15,'2510204')

insert into cidades values('Nova Palmeira',15,'2510303')

insert into cidades values('Olho dÁgua',15,'2510402')

insert into cidades values('Olivedos',15,'2510501')

insert into cidades values('Ouro Velho',15,'2510600')

insert into cidades values('Parari',15,'2510659')

insert into cidades values('Passagem',15,'2510709')

insert into cidades values('Patos',15,'2510808')

insert into cidades values('Paulista',15,'2510907')

insert into cidades values('Pedra Branca',15,'2511004')

insert into cidades values('Pedra Lavrada',15,'2511103')

insert into cidades values('Pedras de Fogo',15,'2511202')

insert into cidades values('Pedro Régis',15,'2512721')

insert into cidades values('Piancó',15,'2511301')

insert into cidades values('Picuí',15,'2511400')

insert into cidades values('Pilar',15,'2511509')

insert into cidades values('Pilões',15,'2511608')

insert into cidades values('Pilõezinhos',15,'2511707')

insert into cidades values('Pirpirituba',15,'2511806')

insert into cidades values('Pitimbu',15,'2511905')

insert into cidades values('Pocinhos',15,'2512002')

insert into cidades values('Poço Dantas',15,'2512036')

insert into cidades values('Poço de José de Moura',15,'2512077')

insert into cidades values('Pombal',15,'2512101')

insert into cidades values('Prata',15,'2512200')

insert into cidades values('Princesa Isabel',15,'2512309')

insert into cidades values('Puxinanã',15,'2512408')

insert into cidades values('Queimadas',15,'2512507')

insert into cidades values('Quixabá',15,'2512606')

insert into cidades values('Remígio',15,'2512705')

insert into cidades values('Riachão',15,'2512747')

insert into cidades values('Riachão do Bacamarte',15,'2512754')

insert into cidades values('Riachão do Poço',15,'2512762')

insert into cidades values('Riacho de Santo Antônio',15,'2512788')

insert into cidades values('Riacho dos Cavalos',15,'2512804')

insert into cidades values('Rio Tinto',15,'2512903')

insert into cidades values('Salgadinho',15,'2513000')

insert into cidades values('Salgado de São Félix',15,'2513109')

insert into cidades values('Santa Cecília',15,'2513158')

insert into cidades values('Santa Cruz',15,'2513208')

insert into cidades values('Santa Helena',15,'2513307')

insert into cidades values('Santa Inês',15,'2513356')

insert into cidades values('Santa Luzia',15,'2513406')

insert into cidades values('Santa Rita',15,'2513703')

insert into cidades values('Santa Teresinha',15,'2513802')

insert into cidades values('Santana de Mangueira',15,'2513505')

insert into cidades values('Santana dos Garrotes',15,'2513604')

insert into cidades values('Santarém',15,'2513653')

insert into cidades values('Santo André',15,'2513851')

insert into cidades values('São Bentinho',15,'2513927')

insert into cidades values('São Bento',15,'2513901')

insert into cidades values('São Domingos de Pombal',15,'2513968')

insert into cidades values('São Domingos do Cariri',15,'2513943')

insert into cidades values('São Francisco',15,'2513984')

insert into cidades values('São João do Cariri',15,'2514008')

insert into cidades values('São João do Rio do Peixe',15,'2500700')

insert into cidades values('São João do Tigre',15,'2514107')

insert into cidades values('São José da Lagoa Tapada',15,'2514206')

insert into cidades values('São José de Caiana',15,'2514305')

insert into cidades values('São José de Espinharas',15,'2514404')

insert into cidades values('São José de Piranhas',15,'2514503')

insert into cidades values('São José de Princesa',15,'2514552')

insert into cidades values('São José do Bonfim',15,'2514602')

insert into cidades values('São José do Brejo do Cruz',15,'2514651')

insert into cidades values('São José do Sabugi',15,'2514701')

insert into cidades values('São José dos Cordeiros',15,'2514800')

insert into cidades values('São José dos Ramos',15,'2514453')

insert into cidades values('São Mamede',15,'2514909')

insert into cidades values('São Miguel de Taipu',15,'2515005')

insert into cidades values('São Sebastião de Lagoa de Roça',15,'2515104')

insert into cidades values('São Sebastião do Umbuzeiro',15,'2515203')

insert into cidades values('Sapé',15,'2515302')

insert into cidades values('Seridó',15,'2515401')

insert into cidades values('Serra Branca',15,'2515500')

insert into cidades values('Serra da Raiz',15,'2515609')

insert into cidades values('Serra Grande',15,'2515708')

insert into cidades values('Serra Redonda',15,'2515807')

insert into cidades values('Serraria',15,'2515906')

insert into cidades values('Sertãozinho',15,'2515930')

insert into cidades values('Sobrado',15,'2515971')

insert into cidades values('Solânea',15,'2516003')

insert into cidades values('Soledade',15,'2516102')

insert into cidades values('Sossêgo',15,'2516151')

insert into cidades values('Sousa',15,'2516201')

insert into cidades values('Sumé',15,'2516300')

insert into cidades values('Taperoá',15,'2516508')

insert into cidades values('Tavares',15,'2516607')

insert into cidades values('Teixeira',15,'2516706')

insert into cidades values('Tenório',15,'2516755')

insert into cidades values('Triunfo',15,'2516805')

insert into cidades values('Uiraúna',15,'2516904')

insert into cidades values('Umbuzeiro',15,'2517001')

insert into cidades values('Várzea',15,'2517100')

insert into cidades values('Vieirópolis',15,'2517209')

insert into cidades values('Vista Serrana',15,'2505501')

insert into cidades values('Zabelê',15,'2517407')

insert into cidades values('Abatiá',18,'4100103')

insert into cidades values('Adrianópolis',18,'4100202')

insert into cidades values('Agudos do Sul',18,'4100301')

insert into cidades values('Almirante Tamandaré',18,'4100400')

insert into cidades values('Altamira do Paraná',18,'4100459')

insert into cidades values('Alto Paraíso',18,'4128625')

insert into cidades values('Alto Paraná',18,'4100608')

insert into cidades values('Alto Piquiri',18,'4100707')

insert into cidades values('Altônia',18,'4100509')

insert into cidades values('Alvorada do Sul',18,'4100806')

insert into cidades values('Amaporã',18,'4100905')

insert into cidades values('Ampére',18,'4101002')

insert into cidades values('Anahy',18,'4101051')

insert into cidades values('Andirá',18,'4101101')

insert into cidades values('Ângulo',18,'4101150')

insert into cidades values('Antonina',18,'4101200')

insert into cidades values('Antônio Olinto',18,'4101309')

insert into cidades values('Apucarana',18,'4101408')

insert into cidades values('Arapongas',18,'4101507')

insert into cidades values('Arapoti',18,'4101606')

insert into cidades values('Arapuã',18,'4101655')

insert into cidades values('Araruna',18,'4101705')

insert into cidades values('Araucária',18,'4101804')

insert into cidades values('Ariranha do Ivaí',18,'4101853')

insert into cidades values('Assaí',18,'4101903')

insert into cidades values('Assis Chateaubriand',18,'4102000')

insert into cidades values('Astorga',18,'4102109')

insert into cidades values('Atalaia',18,'4102208')

insert into cidades values('Balsa Nova',18,'4102307')

insert into cidades values('Bandeirantes',18,'4102406')

insert into cidades values('Barbosa Ferraz',18,'4102505')

insert into cidades values('Barra do Jacaré',18,'4102703')

insert into cidades values('Barracão',18,'4102604')

insert into cidades values('Bela Vista da Caroba',18,'4102752')

insert into cidades values('Bela Vista do Paraíso',18,'4102802')

insert into cidades values('Bituruna',18,'4102901')

insert into cidades values('Boa Esperança',18,'4103008')

insert into cidades values('Boa Esperança do Iguaçu',18,'4103024')

insert into cidades values('Boa Ventura de São Roque',18,'4103040')

insert into cidades values('Boa Vista da Aparecida',18,'4103057')

insert into cidades values('Bocaiúva do Sul',18,'4103107')

insert into cidades values('Bom Jesus do Sul',18,'4103156')

insert into cidades values('Bom Sucesso',18,'4103206')

insert into cidades values('Bom Sucesso do Sul',18,'4103222')

insert into cidades values('Borrazópolis',18,'4103305')

insert into cidades values('Braganey',18,'4103354')

insert into cidades values('Brasilândia do Sul',18,'4103370')

insert into cidades values('Cafeara',18,'4103404')

insert into cidades values('Cafelândia',18,'4103453')

insert into cidades values('Cafezal do Sul',18,'4103479')

insert into cidades values('Califórnia',18,'4103503')

insert into cidades values('Cambará',18,'4103602')

insert into cidades values('Cambé',18,'4103701')

insert into cidades values('Cambira',18,'4103800')

insert into cidades values('Campina da Lagoa',18,'4103909')

insert into cidades values('Campina do Simão',18,'4103958')

insert into cidades values('Campina Grande do Sul',18,'4104006')

insert into cidades values('Campo Bonito',18,'4104055')

insert into cidades values('Campo do Tenente',18,'4104105')

insert into cidades values('Campo Largo',18,'4104204')

insert into cidades values('Campo Magro',18,'4104253')

insert into cidades values('Campo Mourão',18,'4104303')

insert into cidades values('Cândido de Abreu',18,'4104402')

insert into cidades values('Candói',18,'4104428')

insert into cidades values('Cantagalo',18,'4104451')

insert into cidades values('Capanema',18,'4104501')

insert into cidades values('Capitão Leônidas Marques',18,'4104600')

insert into cidades values('Carambeí',18,'4104659')

insert into cidades values('Carlópolis',18,'4104709')

insert into cidades values('Cascavel',18,'4104808')

insert into cidades values('Castro',18,'4104907')

insert into cidades values('Catanduvas',18,'4105003')

insert into cidades values('Centenário do Sul',18,'4105102')

insert into cidades values('Cerro Azul',18,'4105201')

insert into cidades values('Céu Azul',18,'4105300')

insert into cidades values('Chopinzinho',18,'4105409')

insert into cidades values('Cianorte',18,'4105508')

insert into cidades values('cidades Gaúcha',18,'4105607')

insert into cidades values('Clevelândia',18,'4105706')

insert into cidades values('Colombo',18,'4105805')

insert into cidades values('Colorado',18,'4105904')

insert into cidades values('Congonhinhas',18,'4106001')

insert into cidades values('Conselheiro Mairinck',18,'4106100')

insert into cidades values('Contenda',18,'4106209')

insert into cidades values('Corbélia',18,'4106308')

insert into cidades values('Cornélio Procópio',18,'4106407')

insert into cidades values('Coronel Domingos Soares',18,'4106456')

insert into cidades values('Coronel Vivida',18,'4106506')

insert into cidades values('Corumbataí do Sul',18,'4106555')

insert into cidades values('Cruz Machado',18,'4106803')

insert into cidades values('Cruzeiro do Iguaçu',18,'4106571')

insert into cidades values('Cruzeiro do Oeste',18,'4106605')

insert into cidades values('Cruzeiro do Sul',18,'4106704')

insert into cidades values('Cruzmaltina',18,'4106852')

insert into cidades values('Curitiba',18,'4106902')

insert into cidades values('Curiúva',18,'4107009')

insert into cidades values('Diamante dOeste',18,'4107157')

insert into cidades values('Diamante do Norte',18,'4107108')

insert into cidades values('Diamante do Sul',18,'4107124')

insert into cidades values('Dois Vizinhos',18,'4107207')

insert into cidades values('Douradina',18,'4107256')

insert into cidades values('Doutor Camargo',18,'4107306')

insert into cidades values('Doutor Ulysses',18,'4128633')

insert into cidades values('Enéas Marques',18,'4107405')

insert into cidades values('Engenheiro Beltrão',18,'4107504')

insert into cidades values('Entre Rios do Oeste',18,'4107538')

insert into cidades values('Esperança Nova',18,'4107520')

insert into cidades values('Espigão Alto do Iguaçu',18,'4107546')

insert into cidades values('Farol',18,'4107553')

insert into cidades values('Faxinal',18,'4107603')

insert into cidades values('Fazenda Rio Grande',18,'4107652')

insert into cidades values('Fênix',18,'4107702')

insert into cidades values('Fernandes Pinheiro',18,'4107736')

insert into cidades values('Figueira',18,'4107751')

insert into cidades values('Flor da Serra do Sul',18,'4107850')

insert into cidades values('Floraí',18,'4107801')

insert into cidades values('Floresta',18,'4107900')

insert into cidades values('Florestópolis',18,'4108007')

insert into cidades values('Flórida',18,'4108106')

insert into cidades values('Formosa do Oeste',18,'4108205')

insert into cidades values('Foz do Iguaçu',18,'4108304')

insert into cidades values('Foz do Jordão',18,'4108452')

insert into cidades values('Francisco Alves',18,'4108320')

insert into cidades values('Francisco Beltrão',18,'4108403')

insert into cidades values('General Carneiro',18,'4108502')

insert into cidades values('Godoy Moreira',18,'4108551')

insert into cidades values('Goioerê',18,'4108601')

insert into cidades values('Goioxim',18,'4108650')

insert into cidades values('Grandes Rios',18,'4108700')

insert into cidades values('Guaíra',18,'4108809')

insert into cidades values('Guairaçá',18,'4108908')

insert into cidades values('Guamiranga',18,'4108957')

insert into cidades values('Guapirama',18,'4109005')

insert into cidades values('Guaporema',18,'4109104')

insert into cidades values('Guaraci',18,'4109203')

insert into cidades values('Guaraniaçu',18,'4109302')

insert into cidades values('Guarapuava',18,'4109401')

insert into cidades values('Guaraqueçaba',18,'4109500')

insert into cidades values('Guaratuba',18,'4109609')

insert into cidades values('Honório Serpa',18,'4109658')

insert into cidades values('Ibaiti',18,'4109708')

insert into cidades values('Ibema',18,'4109757')

insert into cidades values('Ibiporã',18,'4109807')

insert into cidades values('Icaraíma',18,'4109906')

insert into cidades values('Iguaraçu',18,'4110003')

insert into cidades values('Iguatu',18,'4110052')

insert into cidades values('Imbaú',18,'4110078')

insert into cidades values('Imbituva',18,'4110102')

insert into cidades values('Inácio Martins',18,'4110201')

insert into cidades values('Inajá',18,'4110300')

insert into cidades values('Indianópolis',18,'4110409')

insert into cidades values('Ipiranga',18,'4110508')

insert into cidades values('Iporã',18,'4110607')

insert into cidades values('Iracema do Oeste',18,'4110656')

insert into cidades values('Irati',18,'4110706')

insert into cidades values('Iretama',18,'4110805')

insert into cidades values('Itaguajé',18,'4110904')

insert into cidades values('Itaipulândia',18,'4110953')

insert into cidades values('Itambaracá',18,'4111001')

insert into cidades values('Itambé',18,'4111100')

insert into cidades values('Itapejara dOeste',18,'4111209')

insert into cidades values('Itaperuçu',18,'4111258')

insert into cidades values('Itaúna do Sul',18,'4111308')

insert into cidades values('Ivaí',18,'4111407')

insert into cidades values('Ivaiporã',18,'4111506')

insert into cidades values('Ivaté',18,'4111555')

insert into cidades values('Ivatuba',18,'4111605')

insert into cidades values('Jaboti',18,'4111704')

insert into cidades values('Jacarezinho',18,'4111803')

insert into cidades values('Jaguapitã',18,'4111902')

insert into cidades values('Jaguariaíva',18,'4112009')

insert into cidades values('Jandaia do Sul',18,'4112108')

insert into cidades values('Janiópolis',18,'4112207')

insert into cidades values('Japira',18,'4112306')

insert into cidades values('Japurá',18,'4112405')

insert into cidades values('Jardim Alegre',18,'4112504')

insert into cidades values('Jardim Olinda',18,'4112603')

insert into cidades values('Jataizinho',18,'4112702')

insert into cidades values('Jesuítas',18,'4112751')

insert into cidades values('Joaquim Távora',18,'4112801')

insert into cidades values('Jundiaí do Sul',18,'4112900')

insert into cidades values('Juranda',18,'4112959')

insert into cidades values('Jussara',18,'4113007')

insert into cidades values('Kaloré',18,'4113106')

insert into cidades values('Lapa',18,'4113205')

insert into cidades values('Laranjal',18,'4113254')

insert into cidades values('Laranjeiras do Sul',18,'4113304')

insert into cidades values('Leópolis',18,'4113403')

insert into cidades values('Lidianópolis',18,'4113429')

insert into cidades values('Lindoeste',18,'4113452')

insert into cidades values('Loanda',18,'4113502')

insert into cidades values('Lobato',18,'4113601')

insert into cidades values('Londrina',18,'4113700')

insert into cidades values('Luiziana',18,'4113734')

insert into cidades values('Lunardelli',18,'4113759')

insert into cidades values('Lupionópolis',18,'4113809')

insert into cidades values('Mallet',18,'4113908')

insert into cidades values('Mamborê',18,'4114005')

insert into cidades values('Mandaguaçu',18,'4114104')

insert into cidades values('Mandaguari',18,'4114203')

insert into cidades values('Mandirituba',18,'4114302')

insert into cidades values('Manfrinópolis',18,'4114351')

insert into cidades values('Mangueirinha',18,'4114401')

insert into cidades values('Manoel Ribas',18,'4114500')

insert into cidades values('Marechal Cândido Rondon',18,'4114609')

insert into cidades values('Maria Helena',18,'4114708')

insert into cidades values('Marialva',18,'4114807')

insert into cidades values('Marilândia do Sul',18,'4114906')

insert into cidades values('Marilena',18,'4115002')

insert into cidades values('Mariluz',18,'4115101')

insert into cidades values('Maringá',18,'4115200')

insert into cidades values('Mariópolis',18,'4115309')

insert into cidades values('Maripá',18,'4115358')

insert into cidades values('Marmeleiro',18,'4115408')

insert into cidades values('Marquinho',18,'4115457')

insert into cidades values('Marumbi',18,'4115507')

insert into cidades values('Matelândia',18,'4115606')

insert into cidades values('Matinhos',18,'4115705')

insert into cidades values('Mato Rico',18,'4115739')

insert into cidades values('Mauá da Serra',18,'4115754')

insert into cidades values('Medianeira',18,'4115804')

insert into cidades values('Mercedes',18,'4115853')

insert into cidades values('Mirador',18,'4115903')

insert into cidades values('Miraselva',18,'4116000')

insert into cidades values('Missal',18,'4116059')

insert into cidades values('Moreira Sales',18,'4116109')

insert into cidades values('Morretes',18,'4116208')

insert into cidades values('Munhoz de Melo',18,'4116307')

insert into cidades values('Nossa Senhora das Graças',18,'4116406')

insert into cidades values('Nova Aliança do Ivaí',18,'4116505')

insert into cidades values('Nova América da Colina',18,'4116604')

insert into cidades values('Nova Aurora',18,'4116703')

insert into cidades values('Nova Cantu',18,'4116802')

insert into cidades values('Nova Esperança',18,'4116901')

insert into cidades values('Nova Esperança do Sudoeste',18,'4116950')

insert into cidades values('Nova Fátima',18,'4117008')

insert into cidades values('Nova Laranjeiras',18,'4117057')

insert into cidades values('Nova Londrina',18,'4117107')

insert into cidades values('Nova Olímpia',18,'4117206')

insert into cidades values('Nova Prata do Iguaçu',18,'4117255')

insert into cidades values('Nova Santa Bárbara',18,'4117214')

insert into cidades values('Nova Santa Rosa',18,'4117222')

insert into cidades values('Nova Tebas',18,'4117271')

insert into cidades values('Novo Itacolomi',18,'4117297')

insert into cidades values('Ortigueira',18,'4117305')

insert into cidades values('Ourizona',18,'4117404')

insert into cidades values('Ouro Verde do Oeste',18,'4117453')

insert into cidades values('Paiçandu',18,'4117503')

insert into cidades values('Palmas',18,'4117602')

insert into cidades values('Palmeira',18,'4117701')

insert into cidades values('Palmital',18,'4117800')

insert into cidades values('Palotina',18,'4117909')

insert into cidades values('Paraíso do Norte',18,'4118006')

insert into cidades values('Paranacity',18,'4118105')

insert into cidades values('Paranaguá',18,'4118204')

insert into cidades values('Paranapoema',18,'4118303')

insert into cidades values('Paranavaí',18,'4118402')

insert into cidades values('Pato Bragado',18,'4118451')

insert into cidades values('Pato Branco',18,'4118501')

insert into cidades values('Paula Freitas',18,'4118600')

insert into cidades values('Paulo Frontin',18,'4118709')

insert into cidades values('Peabiru',18,'4118808')

insert into cidades values('Perobal',18,'4118857')

insert into cidades values('Pérola',18,'4118907')

insert into cidades values('Pérola dOeste',18,'4119004')

insert into cidades values('Piên',18,'4119103')

insert into cidades values('Pinhais',18,'4119152')

insert into cidades values('Pinhal de São Bento',18,'4119251')

insert into cidades values('Pinhalão',18,'4119202')

insert into cidades values('Pinhão',18,'4119301')

insert into cidades values('Piraí do Sul',18,'4119400')

insert into cidades values('Piraquara',18,'4119509')

insert into cidades values('Pitanga',18,'4119608')

insert into cidades values('Pitangueiras',18,'4119657')

insert into cidades values('Planaltina do Paraná',18,'4119707')

insert into cidades values('Planalto',18,'4119806')

insert into cidades values('Ponta Grossa',18,'4119905')

insert into cidades values('Pontal do Paraná',18,'4119954')

insert into cidades values('Porecatu',18,'4120002')

insert into cidades values('Porto Amazonas',18,'4120101')

insert into cidades values('Porto Barreiro',18,'4120150')

insert into cidades values('Porto Rico',18,'4120200')

insert into cidades values('Porto Vitória',18,'4120309')

insert into cidades values('Prado Ferreira',18,'4120333')

insert into cidades values('Pranchita',18,'4120358')

insert into cidades values('Presidente Castelo Branco',18,'4120408')

insert into cidades values('Primeiro de Maio',18,'4120507')

insert into cidades values('Prudentópolis',18,'4120606')

insert into cidades values('Quarto Centenário',18,'4120655')

insert into cidades values('Quatiguá',18,'4120705')

insert into cidades values('Quatro Barras',18,'4120804')

insert into cidades values('Quatro Pontes',18,'4120853')

insert into cidades values('Quedas do Iguaçu',18,'4120903')

insert into cidades values('Querência do Norte',18,'4121000')

insert into cidades values('Quinta do Sol',18,'4121109')

insert into cidades values('Quitandinha',18,'4121208')

insert into cidades values('Ramilândia',18,'4121257')

insert into cidades values('Rancho Alegre',18,'4121307')

insert into cidades values('Rancho Alegre dOeste',18,'4121356')

insert into cidades values('Realeza',18,'4121406')

insert into cidades values('Rebouças',18,'4121505')

insert into cidades values('Renascença',18,'4121604')

insert into cidades values('Reserva',18,'4121703')

insert into cidades values('Reserva do Iguaçu',18,'4121752')

insert into cidades values('Ribeirão Claro',18,'4121802')

insert into cidades values('Ribeirão do Pinhal',18,'4121901')

insert into cidades values('Rio Azul',18,'4122008')

insert into cidades values('Rio Bom',18,'4122107')

insert into cidades values('Rio Bonito do Iguaçu',18,'4122156')

insert into cidades values('Rio Branco do Ivaí',18,'4122172')

insert into cidades values('Rio Branco do Sul',18,'4122206')

insert into cidades values('Rio Negro',18,'4122305')

insert into cidades values('Rolândia',18,'4122404')

insert into cidades values('Roncador',18,'4122503')

insert into cidades values('Rondon',18,'4122602')

insert into cidades values('Rosário do Ivaí',18,'4122651')

insert into cidades values('Sabáudia',18,'4122701')

insert into cidades values('Salgado Filho',18,'4122800')

insert into cidades values('Salto do Itararé',18,'4122909')

insert into cidades values('Salto do Lontra',18,'4123006')

insert into cidades values('Santa Amélia',18,'4123105')

insert into cidades values('Santa Cecília do Pavão',18,'4123204')

insert into cidades values('Santa Cruz de Monte Castelo',18,'4123303')

insert into cidades values('Santa Fé',18,'4123402')

insert into cidades values('Santa Helena',18,'4123501')

insert into cidades values('Santa Inês',18,'4123600')

insert into cidades values('Santa Isabel do Ivaí',18,'4123709')

insert into cidades values('Santa Izabel do Oeste',18,'4123808')

insert into cidades values('Santa Lúcia',18,'4123824')

insert into cidades values('Santa Maria do Oeste',18,'4123857')

insert into cidades values('Santa Mariana',18,'4123907')

insert into cidades values('Santa Mônica',18,'4123956')

insert into cidades values('Santa Tereza do Oeste',18,'4124020')

insert into cidades values('Santa Terezinha de Itaipu',18,'4124053')

insert into cidades values('Santana do Itararé',18,'4124004')

insert into cidades values('Santo Antônio da Platina',18,'4124103')

insert into cidades values('Santo Antônio do Caiuá',18,'4124202')

insert into cidades values('Santo Antônio do Paraíso',18,'4124301')

insert into cidades values('Santo Antônio do Sudoeste',18,'4124400')

insert into cidades values('Santo Inácio',18,'4124509')

insert into cidades values('São Carlos do Ivaí',18,'4124608')

insert into cidades values('São Jerônimo da Serra',18,'4124707')

insert into cidades values('São João',18,'4124806')

insert into cidades values('São João do Caiuá',18,'4124905')

insert into cidades values('São João do Ivaí',18,'4125001')

insert into cidades values('São João do Triunfo',18,'4125100')

insert into cidades values('São Jorge dOeste',18,'4125209')

insert into cidades values('São Jorge do Ivaí',18,'4125308')

insert into cidades values('São Jorge do Patrocínio',18,'4125357')

insert into cidades values('São José da Boa Vista',18,'4125407')

insert into cidades values('São José das Palmeiras',18,'4125456')

insert into cidades values('São José dos Pinhais',18,'4125506')

insert into cidades values('São Manoel do Paraná',18,'4125555')

insert into cidades values('São Mateus do Sul',18,'4125605')

insert into cidades values('São Miguel do Iguaçu',18,'4125704')

insert into cidades values('São Pedro do Iguaçu',18,'4125753')

insert into cidades values('São Pedro do Ivaí',18,'4125803')

insert into cidades values('São Pedro do Paraná',18,'4125902')

insert into cidades values('São Sebastião da Amoreira',18,'4126009')

insert into cidades values('São Tomé',18,'4126108')

insert into cidades values('Sapopema',18,'4126207')

insert into cidades values('Sarandi',18,'4126256')

insert into cidades values('Saudade do Iguaçu',18,'4126272')

insert into cidades values('Sengés',18,'4126306')

insert into cidades values('Serranópolis do Iguaçu',18,'4126355')

insert into cidades values('Sertaneja',18,'4126405')

insert into cidades values('Sertanópolis',18,'4126504')

insert into cidades values('Siqueira Campos',18,'4126603')

insert into cidades values('Sulina',18,'4126652')

insert into cidades values('Tamarana',18,'4126678')

insert into cidades values('Tamboara',18,'4126702')

insert into cidades values('Tapejara',18,'4126801')

insert into cidades values('Tapira',18,'4126900')

insert into cidades values('Teixeira Soares',18,'4127007')

insert into cidades values('Telêmaco Borba',18,'4127106')

insert into cidades values('Terra Boa',18,'4127205')

insert into cidades values('Terra Rica',18,'4127304')

insert into cidades values('Terra Roxa',18,'4127403')

insert into cidades values('Tibagi',18,'4127502')

insert into cidades values('Tijucas do Sul',18,'4127601')

insert into cidades values('Toledo',18,'4127700')

insert into cidades values('Tomazina',18,'4127809')

insert into cidades values('Três Barras do Paraná',18,'4127858')

insert into cidades values('Tunas do Paraná',18,'4127882')

insert into cidades values('Tuneiras do Oeste',18,'4127908')

insert into cidades values('Tupãssi',18,'4127957')

insert into cidades values('Turvo',18,'4127965')

insert into cidades values('Ubiratã',18,'4128005')

insert into cidades values('Umuarama',18,'4128104')

insert into cidades values('União da Vitória',18,'4128203')

insert into cidades values('Uniflor',18,'4128302')

insert into cidades values('Uraí',18,'4128401')

insert into cidades values('Ventania',18,'4128534')

insert into cidades values('Vera Cruz do Oeste',18,'4128559')

insert into cidades values('Verê',18,'4128609')

insert into cidades values('Virmond',18,'4128658')

insert into cidades values('Vitorino',18,'4128708')

insert into cidades values('Wenceslau Braz',18,'4128500')

insert into cidades values('Xambrê',18,'4128807')

insert into cidades values('Abreu e Lima',16,'2600054')

insert into cidades values('Afogados da Ingazeira',16,'2600104')

insert into cidades values('Afrânio',16,'2600203')

insert into cidades values('Agrestina',16,'2600302')

insert into cidades values('Água Preta',16,'2600401')

insert into cidades values('Águas Belas',16,'2600500')

insert into cidades values('Alagoinha',16,'2600609')

insert into cidades values('Aliança',16,'2600708')

insert into cidades values('Altinho',16,'2600807')

insert into cidades values('Amaraji',16,'2600906')

insert into cidades values('Angelim',16,'2601003')

insert into cidades values('Araçoiaba',16,'2601052')

insert into cidades values('Araripina',16,'2601102')

insert into cidades values('Arcoverde',16,'2601201')

insert into cidades values('Barra de Guabiraba',16,'2601300')

insert into cidades values('Barreiros',16,'2601409')

insert into cidades values('Belém de Maria',16,'2601508')

insert into cidades values('Belém de São Francisco',16,'2601607')

insert into cidades values('Belo Jardim',16,'2601706')

insert into cidades values('Betânia',16,'2601805')

insert into cidades values('Bezerros',16,'2601904')

insert into cidades values('Bodocó',16,'2602001')

insert into cidades values('Bom Conselho',16,'2602100')

insert into cidades values('Bom Jardim',16,'2602209')

insert into cidades values('Bonito',16,'2602308')

insert into cidades values('Brejão',16,'2602407')

insert into cidades values('Brejinho',16,'2602506')

insert into cidades values('Brejo da Madre de Deus',16,'2602605')

insert into cidades values('Buenos Aires',16,'2602704')

insert into cidades values('Buíque',16,'2602803')

insert into cidades values('Cabo de Santo Agostinho',16,'2602902')

insert into cidades values('Cabrobó',16,'2603009')

insert into cidades values('Cachoeirinha',16,'2603108')

insert into cidades values('Caetés',16,'2603207')

insert into cidades values('Calçado',16,'2603306')

insert into cidades values('Calumbi',16,'2603405')

insert into cidades values('Camaragibe',16,'2603454')

insert into cidades values('Camocim de São Félix',16,'2603504')

insert into cidades values('Camutanga',16,'2603603')

insert into cidades values('Canhotinho',16,'2603702')

insert into cidades values('Capoeiras',16,'2603801')

insert into cidades values('Carnaíba',16,'2603900')

insert into cidades values('Carnaubeira da Penha',16,'2603926')

insert into cidades values('Carpina',16,'2604007')

insert into cidades values('Caruaru',16,'2604106')

insert into cidades values('Casinhas',16,'2604155')

insert into cidades values('Catende',16,'2604205')

insert into cidades values('Cedro',16,'2604304')

insert into cidades values('Chã de Alegria',16,'2604403')

insert into cidades values('Chã Grande',16,'2604502')

insert into cidades values('Condado',16,'2604601')

insert into cidades values('Correntes',16,'2604700')

insert into cidades values('Cortês',16,'2604809')

insert into cidades values('Cumaru',16,'2604908')

insert into cidades values('Cupira',16,'2605004')

insert into cidades values('Custódia',16,'2605103')

insert into cidades values('Dormentes',16,'2605152')

insert into cidades values('Escada',16,'2605202')

insert into cidades values('Exu',16,'2605301')

insert into cidades values('Feira Nova',16,'2605400')

insert into cidades values('Fernando de Noronha',16,'2605459')

insert into cidades values('Ferreiros',16,'2605509')

insert into cidades values('Flores',16,'2605608')

insert into cidades values('Floresta',16,'2605707')

insert into cidades values('Frei Miguelinho',16,'2605806')

insert into cidades values('Gameleira',16,'2605905')

insert into cidades values('Garanhuns',16,'2606002')

insert into cidades values('Glória do Goitá',16,'2606101')

insert into cidades values('Goiana',16,'2606200')

insert into cidades values('Granito',16,'2606309')

insert into cidades values('Gravatá',16,'2606408')

insert into cidades values('Iati',16,'2606507')

insert into cidades values('Ibimirim',16,'2606606')

insert into cidades values('Ibirajuba',16,'2606705')

insert into cidades values('Igarassu',16,'2606804')

insert into cidades values('Iguaraci',16,'2606903')

insert into cidades values('Ilha de Itamaracá',16,'2607604')

insert into cidades values('Inajá',16,'2607000')

insert into cidades values('Ingazeira',16,'2607109')

insert into cidades values('Ipojuca',16,'2607208')

insert into cidades values('Ipubi',16,'2607307')

insert into cidades values('Itacuruba',16,'2607406')

insert into cidades values('Itaíba',16,'2607505')

insert into cidades values('Itambé',16,'2607653')

insert into cidades values('Itapetim',16,'2607703')

insert into cidades values('Itapissuma',16,'2607752')

insert into cidades values('Itaquitinga',16,'2607802')

insert into cidades values('Jaboatão dos Guararapes',16,'2607901')

insert into cidades values('Jaqueira',16,'2607950')

insert into cidades values('Jataúba',16,'2608008')

insert into cidades values('Jatobá',16,'2608057')

insert into cidades values('João Alfredo',16,'2608107')

insert into cidades values('Joaquim Nabuco',16,'2608206')

insert into cidades values('Jucati',16,'2608255')

insert into cidades values('Jupi',16,'2608305')

insert into cidades values('Jurema',16,'2608404')

insert into cidades values('Lagoa do Carro',16,'2608453')

insert into cidades values('Lagoa do Itaenga',16,'2608503')

insert into cidades values('Lagoa do Ouro',16,'2608602')

insert into cidades values('Lagoa dos Gatos',16,'2608701')

insert into cidades values('Lagoa Grande',16,'2608750')

insert into cidades values('Lajedo',16,'2608800')

insert into cidades values('Limoeiro',16,'2608909')

insert into cidades values('Macaparana',16,'2609006')

insert into cidades values('Machados',16,'2609105')

insert into cidades values('Manari',16,'2609154')

insert into cidades values('Maraial',16,'2609204')

insert into cidades values('Mirandiba',16,'2609303')

insert into cidades values('Moreilândia',16,'2614303')

insert into cidades values('Moreno',16,'2609402')

insert into cidades values('Nazaré da Mata',16,'2609501')

insert into cidades values('Olinda',16,'2609600')

insert into cidades values('Orobó',16,'2609709')

insert into cidades values('Orocó',16,'2609808')

insert into cidades values('Ouricuri',16,'2609907')

insert into cidades values('Palmares',16,'2610004')

insert into cidades values('Palmeirina',16,'2610103')

insert into cidades values('Panelas',16,'2610202')

insert into cidades values('Paranatama',16,'2610301')

insert into cidades values('Parnamirim',16,'2610400')

insert into cidades values('Passira',16,'2610509')

insert into cidades values('Paudalho',16,'2610608')

insert into cidades values('Paulista',16,'2610707')

insert into cidades values('Pedra',16,'2610806')

insert into cidades values('Pesqueira',16,'2610905')

insert into cidades values('Petrolândia',16,'2611002')

insert into cidades values('Petrolina',16,'2611101')

insert into cidades values('Poção',16,'2611200')

insert into cidades values('Pombos',16,'2611309')

insert into cidades values('Primavera',16,'2611408')

insert into cidades values('Quipapá',16,'2611507')

insert into cidades values('Quixaba',16,'2611533')

insert into cidades values('Recife',16,'2611606')

insert into cidades values('Riacho das Almas',16,'2611705')

insert into cidades values('Ribeirão',16,'2611804')

insert into cidades values('Rio Formoso',16,'2611903')

insert into cidades values('Sairé',16,'2612000')

insert into cidades values('Salgadinho',16,'2612109')

insert into cidades values('Salgueiro',16,'2612208')

insert into cidades values('Saloá',16,'2612307')

insert into cidades values('Sanharó',16,'2612406')

insert into cidades values('Santa Cruz',16,'2612455')

insert into cidades values('Santa Cruz da Baixa Verde',16,'2612471')

insert into cidades values('Santa Cruz do Capibaribe',16,'2612505')

insert into cidades values('Santa Filomena',16,'2612554')

insert into cidades values('Santa Maria da Boa Vista',16,'2612604')

insert into cidades values('Santa Maria do Cambucá',16,'2612703')

insert into cidades values('Santa Terezinha',16,'2612802')

insert into cidades values('São Benedito do Sul',16,'2612901')

insert into cidades values('São Bento do Una',16,'2613008')

insert into cidades values('São Caitano',16,'2613107')

insert into cidades values('São João',16,'2613206')

insert into cidades values('São Joaquim do Monte',16,'2613305')

insert into cidades values('São José da Coroa Grande',16,'2613404')

insert into cidades values('São José do Belmonte',16,'2613503')

insert into cidades values('São José do Egito',16,'2613602')

insert into cidades values('São Lourenço da Mata',16,'2613701')

insert into cidades values('São Vicente Ferrer',16,'2613800')

insert into cidades values('Serra Talhada',16,'2613909')

insert into cidades values('Serrita',16,'2614006')

insert into cidades values('Sertânia',16,'2614105')

insert into cidades values('Sirinhaém',16,'2614204')

insert into cidades values('Solidão',16,'2614402')

insert into cidades values('Surubim',16,'2614501')

insert into cidades values('Tabira',16,'2614600')

insert into cidades values('Tacaimbó',16,'2614709')

insert into cidades values('Tacaratu',16,'2614808')

insert into cidades values('Tamandaré',16,'2614857')

insert into cidades values('Taquaritinga do Norte',16,'2615003')

insert into cidades values('Terezinha',16,'2615102')

insert into cidades values('Terra Nova',16,'2615201')

insert into cidades values('Timbaúba',16,'2615300')

insert into cidades values('Toritama',16,'2615409')

insert into cidades values('Tracunhaém',16,'2615508')

insert into cidades values('Trindade',16,'2615607')

insert into cidades values('Triunfo',16,'2615706')

insert into cidades values('Tupanatinga',16,'2615805')

insert into cidades values('Tuparetama',16,'2615904')

insert into cidades values('Venturosa',16,'2616001')

insert into cidades values('Verdejante',16,'2616100')

insert into cidades values('Vertente do Lério',16,'2616183')

insert into cidades values('Vertentes',16,'2616209')

insert into cidades values('Vicência',16,'2616308')

insert into cidades values('Vitória de Santo Antão',16,'2616407')

insert into cidades values('Xexéu',16,'2616506')

insert into cidades values('Acauã',17,'2200053')

insert into cidades values('Agricolândia',17,'2200103')

insert into cidades values('Água Branca',17,'2200202')

insert into cidades values('Alagoinha do Piauí',17,'2200251')

insert into cidades values('Alegrete do Piauí',17,'2200277')

insert into cidades values('Alto Longá',17,'2200301')

insert into cidades values('Altos',17,'2200400')

insert into cidades values('Alvorada do Gurguéia',17,'2200459')

insert into cidades values('Amarante',17,'2200509')

insert into cidades values('Angical do Piauí',17,'2200608')

insert into cidades values('Anísio de Abreu',17,'2200707')

insert into cidades values('Antônio Almeida',17,'2200806')

insert into cidades values('Aroazes',17,'2200905')

insert into cidades values('Aroeiras do Itaim',17,'2200954')

insert into cidades values('Arraial',17,'2201002')

insert into cidades values('Assunção do Piauí',17,'2201051')

insert into cidades values('Avelino Lopes',17,'2201101')

insert into cidades values('Baixa Grande do Ribeiro',17,'2201150')

insert into cidades values('Barra dAlcântara',17,'2201176')

insert into cidades values('Barras',17,'2201200')

insert into cidades values('Barreiras do Piauí',17,'2201309')

insert into cidades values('Barro Duro',17,'2201408')

insert into cidades values('Batalha',17,'2201507')

insert into cidades values('Bela Vista do Piauí',17,'2201556')

insert into cidades values('Belém do Piauí',17,'2201572')

insert into cidades values('Beneditinos',17,'2201606')

insert into cidades values('Bertolínia',17,'2201705')

insert into cidades values('Betânia do Piauí',17,'2201739')

insert into cidades values('Boa Hora',17,'2201770')

insert into cidades values('Bocaina',17,'2201804')

insert into cidades values('Bom Jesus',17,'2201903')

insert into cidades values('Bom Princípio do Piauí',17,'2201919')

insert into cidades values('Bonfim do Piauí',17,'2201929')

insert into cidades values('Boqueirão do Piauí',17,'2201945')

insert into cidades values('Brasileira',17,'2201960')

insert into cidades values('Brejo do Piauí',17,'2201988')

insert into cidades values('Buriti dos Lopes',17,'2202000')

insert into cidades values('Buriti dos Montes',17,'2202026')

insert into cidades values('Cabeceiras do Piauí',17,'2202059')

insert into cidades values('Cajazeiras do Piauí',17,'2202075')

insert into cidades values('Cajueiro da Praia',17,'2202083')

insert into cidades values('Caldeirão Grande do Piauí',17,'2202091')

insert into cidades values('Campinas do Piauí',17,'2202109')

insert into cidades values('Campo Alegre do Fidalgo',17,'2202117')

insert into cidades values('Campo Grande do Piauí',17,'2202133')

insert into cidades values('Campo Largo do Piauí',17,'2202174')

insert into cidades values('Campo Maior',17,'2202208')

insert into cidades values('Canavieira',17,'2202251')

insert into cidades values('Canto do Buriti',17,'2202307')

insert into cidades values('Capitão de Campos',17,'2202406')

insert into cidades values('Capitão Gervásio Oliveira',17,'2202455')

insert into cidades values('Caracol',17,'2202505')

insert into cidades values('Caraúbas do Piauí',17,'2202539')

insert into cidades values('Caridade do Piauí',17,'2202554')

insert into cidades values('Castelo do Piauí',17,'2202604')

insert into cidades values('Caxingó',17,'2202653')

insert into cidades values('Cocal',17,'2202703')

insert into cidades values('Cocal de Telha',17,'2202711')

insert into cidades values('Cocal dos Alves',17,'2202729')

insert into cidades values('Coivaras',17,'2202737')

insert into cidades values('Colônia do Gurguéia',17,'2202752')

insert into cidades values('Colônia do Piauí',17,'2202778')

insert into cidades values('Conceição do Canindé',17,'2202802')

insert into cidades values('Coronel José Dias',17,'2202851')

insert into cidades values('Corrente',17,'2202901')

insert into cidades values('Cristalândia do Piauí',17,'2203008')

insert into cidades values('Cristino Castro',17,'2203107')

insert into cidades values('Curimatá',17,'2203206')

insert into cidades values('Currais',17,'2203230')

insert into cidades values('Curral Novo do Piauí',17,'2203271')

insert into cidades values('Curralinhos',17,'2203255')

insert into cidades values('Demerval Lobão',17,'2203305')

insert into cidades values('Dirceu Arcoverde',17,'2203354')

insert into cidades values('Dom Expedito Lopes',17,'2203404')

insert into cidades values('Dom Inocêncio',17,'2203453')

insert into cidades values('Domingos Mourão',17,'2203420')

insert into cidades values('Elesbão Veloso',17,'2203503')

insert into cidades values('Eliseu Martins',17,'2203602')

insert into cidades values('Esperantina',17,'2203701')

insert into cidades values('Fartura do Piauí',17,'2203750')

insert into cidades values('Flores do Piauí',17,'2203800')

insert into cidades values('Floresta do Piauí',17,'2203859')

insert into cidades values('Floriano',17,'2203909')

insert into cidades values('Francinópolis',17,'2204006')

insert into cidades values('Francisco Ayres',17,'2204105')

insert into cidades values('Francisco Macedo',17,'2204154')

insert into cidades values('Francisco Santos',17,'2204204')

insert into cidades values('Fronteiras',17,'2204303')

insert into cidades values('Geminiano',17,'2204352')

insert into cidades values('Gilbués',17,'2204402')

insert into cidades values('Guadalupe',17,'2204501')

insert into cidades values('Guaribas',17,'2204550')

insert into cidades values('Hugo Napoleão',17,'2204600')

insert into cidades values('Ilha Grande',17,'2204659')

insert into cidades values('Inhuma',17,'2204709')

insert into cidades values('Ipiranga do Piauí',17,'2204808')

insert into cidades values('Isaías Coelho',17,'2204907')

insert into cidades values('Itainópolis',17,'2205003')

insert into cidades values('Itaueira',17,'2205102')

insert into cidades values('Jacobina do Piauí',17,'2205151')

insert into cidades values('Jaicós',17,'2205201')

insert into cidades values('Jardim do Mulato',17,'2205250')

insert into cidades values('Jatobá do Piauí',17,'2205276')

insert into cidades values('Jerumenha',17,'2205300')

insert into cidades values('João Costa',17,'2205359')

insert into cidades values('Joaquim Pires',17,'2205409')

insert into cidades values('Joca Marques',17,'2205458')

insert into cidades values('José de Freitas',17,'2205508')

insert into cidades values('Juazeiro do Piauí',17,'2205516')

insert into cidades values('Júlio Borges',17,'2205524')

insert into cidades values('Jurema',17,'2205532')

insert into cidades values('Lagoa Alegre',17,'2205557')

insert into cidades values('Lagoa de São Francisco',17,'2205573')

insert into cidades values('Lagoa do Barro do Piauí',17,'2205565')

insert into cidades values('Lagoa do Piauí',17,'2205581')

insert into cidades values('Lagoa do Sítio',17,'2205599')

insert into cidades values('Lagoinha do Piauí',17,'2205540')

insert into cidades values('Landri Sales',17,'2205607')

insert into cidades values('Luís Correia',17,'2205706')

insert into cidades values('Luzilândia',17,'2205805')

insert into cidades values('Madeiro',17,'2205854')

insert into cidades values('Manoel Emídio',17,'2205904')

insert into cidades values('Marcolândia',17,'2205953')

insert into cidades values('Marcos Parente',17,'2206001')

insert into cidades values('Massapê do Piauí',17,'2206050')

insert into cidades values('Matias Olímpio',17,'2206100')

insert into cidades values('Miguel Alves',17,'2206209')

insert into cidades values('Miguel Leão',17,'2206308')

insert into cidades values('Milton Brandão',17,'2206357')

insert into cidades values('Monsenhor Gil',17,'2206407')

insert into cidades values('Monsenhor Hipólito',17,'2206506')

insert into cidades values('Monte Alegre do Piauí',17,'2206605')

insert into cidades values('Morro Cabeça no Tempo',17,'2206654')

insert into cidades values('Morro do Chapéu do Piauí',17,'2206670')

insert into cidades values('Murici dos Portelas',17,'2206696')

insert into cidades values('Nazaré do Piauí',17,'2206704')

insert into cidades values('Nossa Senhora de Nazaré',17,'2206753')

insert into cidades values('Nossa Senhora dos Remédios',17,'2206803')

insert into cidades values('Nova Santa Rita',17,'2207959')

insert into cidades values('Novo Oriente do Piauí',17,'2206902')

insert into cidades values('Novo Santo Antônio',17,'2206951')

insert into cidades values('Oeiras',17,'2207009')

insert into cidades values('Olho dÁgua do Piauí',17,'2207108')

insert into cidades values('Padre Marcos',17,'2207207')

insert into cidades values('Paes Landim',17,'2207306')

insert into cidades values('Pajeú do Piauí',17,'2207355')

insert into cidades values('Palmeira do Piauí',17,'2207405')

insert into cidades values('Palmeirais',17,'2207504')

insert into cidades values('Paquetá',17,'2207553')

insert into cidades values('Parnaguá',17,'2207603')

insert into cidades values('Parnaíba',17,'2207702')

insert into cidades values('Passagem Franca do Piauí',17,'2207751')

insert into cidades values('Patos do Piauí',17,'2207777')

insert into cidades values('Pau dArco do Piauí',17,'2207793')

insert into cidades values('Paulistana',17,'2207801')

insert into cidades values('Pavussu',17,'2207850')

insert into cidades values('Pedro II',17,'2207900')

insert into cidades values('Pedro Laurentino',17,'2207934')

insert into cidades values('Picos',17,'2208007')

insert into cidades values('Pimenteiras',17,'2208106')

insert into cidades values('Pio IX',17,'2208205')

insert into cidades values('Piracuruca',17,'2208304')

insert into cidades values('Piripiri',17,'2208403')

insert into cidades values('Porto',17,'2208502')

insert into cidades values('Porto Alegre do Piauí',17,'2208551')

insert into cidades values('Prata do Piauí',17,'2208601')

insert into cidades values('Queimada Nova',17,'2208650')

insert into cidades values('Redenção do Gurguéia',17,'2208700')

insert into cidades values('Regeneração',17,'2208809')

insert into cidades values('Riacho Frio',17,'2208858')

insert into cidades values('Ribeira do Piauí',17,'2208874')

insert into cidades values('Ribeiro Gonçalves',17,'2208908')

insert into cidades values('Rio Grande do Piauí',17,'2209005')

insert into cidades values('Santa Cruz do Piauí',17,'2209104')

insert into cidades values('Santa Cruz dos Milagres',17,'2209153')

insert into cidades values('Santa Filomena',17,'2209203')

insert into cidades values('Santa Luz',17,'2209302')

insert into cidades values('Santa Rosa do Piauí',17,'2209377')

insert into cidades values('Santana do Piauí',17,'2209351')

insert into cidades values('Santo Antônio de Lisboa',17,'2209401')

insert into cidades values('Santo Antônio dos Milagres',17,'2209450')

insert into cidades values('Santo Inácio do Piauí',17,'2209500')

insert into cidades values('São Braz do Piauí',17,'2209559')

insert into cidades values('São Félix do Piauí',17,'2209609')

insert into cidades values('São Francisco de Assis do Piauí',17,'2209658')

insert into cidades values('São Francisco do Piauí',17,'2209708')

insert into cidades values('São Gonçalo do Gurguéia',17,'2209757')

insert into cidades values('São Gonçalo do Piauí',17,'2209807')

insert into cidades values('São João da Canabrava',17,'2209856')

insert into cidades values('São João da Fronteira',17,'2209872')

insert into cidades values('São João da Serra',17,'2209906')

insert into cidades values('São João da Varjota',17,'2209955')

insert into cidades values('São João do Arraial',17,'2209971')

insert into cidades values('São João do Piauí',17,'2210003')

insert into cidades values('São José do Divino',17,'2210052')

insert into cidades values('São José do Peixe',17,'2210102')

insert into cidades values('São José do Piauí',17,'2210201')

insert into cidades values('São Julião',17,'2210300')

insert into cidades values('São Lourenço do Piauí',17,'2210359')

insert into cidades values('São Luis do Piauí',17,'2210375')

insert into cidades values('São Miguel da Baixa Grande',17,'2210383')

insert into cidades values('São Miguel do Fidalgo',17,'2210391')

insert into cidades values('São Miguel do Tapuio',17,'2210409')

insert into cidades values('São Pedro do Piauí',17,'2210508')

insert into cidades values('São Raimundo Nonato',17,'2210607')

insert into cidades values('Sebastião Barros',17,'2210623')

insert into cidades values('Sebastião Leal',17,'2210631')

insert into cidades values('Sigefredo Pacheco',17,'2210656')

insert into cidades values('Simões',17,'2210706')

insert into cidades values('Simplício Mendes',17,'2210805')

insert into cidades values('Socorro do Piauí',17,'2210904')

insert into cidades values('Sussuapara',17,'2210938')

insert into cidades values('Tamboril do Piauí',17,'2210953')

insert into cidades values('Tanque do Piauí',17,'2210979')

insert into cidades values('Teresina',17,'2211001')

insert into cidades values('União',17,'2211100')

insert into cidades values('Uruçuí',17,'2211209')

insert into cidades values('Valença do Piauí',17,'2211308')

insert into cidades values('Várzea Branca',17,'2211357')

insert into cidades values('Várzea Grande',17,'2211407')

insert into cidades values('Vera Mendes',17,'2211506')

insert into cidades values('Vila Nova do Piauí',17,'2211605')

insert into cidades values('Wall Ferraz',17,'2211704')

insert into cidades values('Angra dos Reis',19,'3300100')

insert into cidades values('Aperibé',19,'3300159')

insert into cidades values('Araruama',19,'3300209')

insert into cidades values('Areal',19,'3300225')

insert into cidades values('Armação dos Búzios',19,'3300233')

insert into cidades values('Arraial do Cabo',19,'3300258')

insert into cidades values('Barra do Piraí',19,'3300308')

insert into cidades values('Barra Mansa',19,'3300407')

insert into cidades values('Belford Roxo',19,'3300456')

insert into cidades values('Bom Jardim',19,'3300506')

insert into cidades values('Bom Jesus do Itabapoana',19,'3300605')

insert into cidades values('Cabo Frio',19,'3300704')

insert into cidades values('Cachoeiras de Macacu',19,'3300803')

insert into cidades values('Cambuci',19,'3300902')

insert into cidades values('Campos dos Goytacazes',19,'3301009')

insert into cidades values('Cantagalo',19,'3301108')

insert into cidades values('Carapebus',19,'3300936')

insert into cidades values('Cardoso Moreira',19,'3301157')

insert into cidades values('Carmo',19,'3301207')

insert into cidades values('Casimiro de Abreu',19,'3301306')

insert into cidades values('Comendador Levy Gasparian',19,'3300951')

insert into cidades values('Conceição de Macabu',19,'3301405')

insert into cidades values('Cordeiro',19,'3301504')

insert into cidades values('Duas Barras',19,'3301603')

insert into cidades values('Duque de Caxias',19,'3301702')

insert into cidades values('Engenheiro Paulo de Frontin',19,'3301801')

insert into cidades values('Guapimirim',19,'3301850')

insert into cidades values('Iguaba Grande',19,'3301876')

insert into cidades values('Itaboraí',19,'3301900')

insert into cidades values('Itaguaí',19,'3302007')

insert into cidades values('Italva',19,'3302056')

insert into cidades values('Itaocara',19,'3302106')

insert into cidades values('Itaperuna',19,'3302205')

insert into cidades values('Itatiaia',19,'3302254')

insert into cidades values('Japeri',19,'3302270')

insert into cidades values('Laje do Muriaé',19,'3302304')

insert into cidades values('Macaé',19,'3302403')

insert into cidades values('Macuco',19,'3302452')

insert into cidades values('Magé',19,'3302502')

insert into cidades values('Mangaratiba',19,'3302601')

insert into cidades values('Maricá',19,'3302700')

insert into cidades values('Mendes',19,'3302809')

insert into cidades values('Mesquita',19,'3302858')

insert into cidades values('Miguel Pereira',19,'3302908')

insert into cidades values('Miracema',19,'3303005')

insert into cidades values('Natividade',19,'3303104')

insert into cidades values('Nilópolis',19,'3303203')

insert into cidades values('Niterói',19,'3303302')

insert into cidades values('Nova Friburgo',19,'3303401')

insert into cidades values('Nova Iguaçu',19,'3303500')

insert into cidades values('Paracambi',19,'3303609')

insert into cidades values('Paraíba do Sul',19,'3303708')

insert into cidades values('Parati',19,'3303807')

insert into cidades values('Paty do Alferes',19,'3303856')

insert into cidades values('Petrópolis',19,'3303906')

insert into cidades values('Pinheiral',19,'3303955')

insert into cidades values('Piraí',19,'3304003')

insert into cidades values('Porciúncula',19,'3304102')

insert into cidades values('Porto Real',19,'3304110')

insert into cidades values('Quatis',19,'3304128')

insert into cidades values('Queimados',19,'3304144')

insert into cidades values('Quissamã',19,'3304151')

insert into cidades values('Resende',19,'3304201')

insert into cidades values('Rio Bonito',19,'3304300')

insert into cidades values('Rio Claro',19,'3304409')

insert into cidades values('Rio das Flores',19,'3304508')

insert into cidades values('Rio das Ostras',19,'3304524')

insert into cidades values('Rio de Janeiro',19,'3304557')

insert into cidades values('Santa Maria Madalena',19,'3304607')

insert into cidades values('Santo Antônio de Pádua',19,'3304706')

insert into cidades values('São Fidélis',19,'3304805')

insert into cidades values('São Francisco de Itabapoana',19,'3304755')

insert into cidades values('São Gonçalo',19,'3304904')

insert into cidades values('São João da Barra',19,'3305000')

insert into cidades values('São João de Meriti',19,'3305109')

insert into cidades values('São José de Ubá',19,'3305133')

insert into cidades values('São José do Vale do Rio Preto',19,'3305158')

insert into cidades values('São Pedro da Aldeia',19,'3305208')

insert into cidades values('São Sebastião do Alto',19,'3305307')

insert into cidades values('Sapucaia',19,'3305406')

insert into cidades values('Saquarema',19,'3305505')

insert into cidades values('Seropédica',19,'3305554')

insert into cidades values('Silva Jardim',19,'3305604')

insert into cidades values('Sumidouro',19,'3305703')

insert into cidades values('Tanguá',19,'3305752')

insert into cidades values('Teresópolis',19,'3305802')

insert into cidades values('Trajano de Morais',19,'3305901')

insert into cidades values('Três Rios',19,'3306008')

insert into cidades values('Valença',19,'3306107')

insert into cidades values('Varre-Sai',19,'3306156')

insert into cidades values('Vassouras',19,'3306206')

insert into cidades values('Volta Redonda',19,'3306305')

insert into cidades values('Acari',20,'2400109')

insert into cidades values('Açu',20,'2400208')

insert into cidades values('Afonso Bezerra',20,'2400307')

insert into cidades values('Água Nova',20,'2400406')

insert into cidades values('Alexandria',20,'2400505')

insert into cidades values('Almino Afonso',20,'2400604')

insert into cidades values('Alto do Rodrigues',20,'2400703')

insert into cidades values('Jardim de Angicos',20,'2405504')

insert into cidades values('Antônio Martins',20,'2400901')

insert into cidades values('Apodi',20,'2401008')

insert into cidades values('Areia Branca',20,'2401107')

insert into cidades values('Arês',20,'2401206')

insert into cidades values('Augusto Severo',20,'2401305')

insert into cidades values('Baía Formosa',20,'2401404')

insert into cidades values('Baraúna',20,'2401453')

insert into cidades values('Barcelona',20,'2401503')

insert into cidades values('Bento Fernandes',20,'2401602')

insert into cidades values('Bodó',20,'2401651')

insert into cidades values('Bom Jesus',20,'2401701')

insert into cidades values('Brejinho',20,'2401800')

insert into cidades values('Caiçara do Norte',20,'2401859')

insert into cidades values('Caiçara do Rio do Vento',20,'2401909')

insert into cidades values('Caicó',20,'2402006')

insert into cidades values('Campo Redondo',20,'2402105')

insert into cidades values('Canguaretama',20,'2402204')

insert into cidades values('Caraúbas',20,'2402303')

insert into cidades values('Carnaúba dos Dantas',20,'2402402')

insert into cidades values('Carnaubais',20,'2402501')

insert into cidades values('Ceará-Mirim',20,'2402600')

insert into cidades values('Cerro Corá',20,'2402709')

insert into cidades values('Coronel Ezequiel',20,'2402808')

insert into cidades values('Coronel João Pessoa',20,'2402907')

insert into cidades values('Cruzeta',20,'2403004')

insert into cidades values('Currais Novos',20,'2403103')

insert into cidades values('Doutor Severiano',20,'2403202')

insert into cidades values('Encanto',20,'2403301')

insert into cidades values('Equador',20,'2403400')

insert into cidades values('Espírito Santo',20,'2403509')

insert into cidades values('Extremoz',20,'2403608')

insert into cidades values('Felipe Guerra',20,'2403707')

insert into cidades values('Fernando Pedroza',20,'2403756')

insert into cidades values('Florânia',20,'2403806')

insert into cidades values('Francisco Dantas',20,'2403905')

insert into cidades values('Frutuoso Gomes',20,'2404002')

insert into cidades values('Galinhos',20,'2404101')

insert into cidades values('Goianinha',20,'2404200')

insert into cidades values('Governador Dix-Sept Rosado',20,'2404309')

insert into cidades values('Grossos',20,'2404408')

insert into cidades values('Guamaré',20,'2404507')

insert into cidades values('Ielmo Marinho',20,'2404606')

insert into cidades values('Ipanguaçu',20,'2404705')

insert into cidades values('Ipueira',20,'2404804')

insert into cidades values('Itajá',20,'2404853')

insert into cidades values('Itaú',20,'2404903')

insert into cidades values('Jaçanã',20,'2405009')

insert into cidades values('Jandaíra',20,'2405108')

insert into cidades values('Janduís',20,'2405207')

insert into cidades values('Januário Cicco',20,'2405306')

insert into cidades values('Japi',20,'2405405')

insert into cidades values('Jardim de Piranhas',20,'2405603')

insert into cidades values('Jardim do Seridó',20,'2405702')

insert into cidades values('João Câmara',20,'2405801')

insert into cidades values('João Dias',20,'2405900')

insert into cidades values('José da Penha',20,'2406007')

insert into cidades values('Jucurutu',20,'2406106')

insert into cidades values('Jundiá',20,'2406155')

insert into cidades values('Lagoa dAnta',20,'2406205')

insert into cidades values('Lagoa de Pedras',20,'2406304')

insert into cidades values('Lagoa de Velhos',20,'2406403')

insert into cidades values('Lagoa Nova',20,'2406502')

insert into cidades values('Lagoa Salgada',20,'2406601')

insert into cidades values('Lajes',20,'2406700')

insert into cidades values('Lajes Pintadas',20,'2406809')

insert into cidades values('Lucrécia',20,'2406908')

insert into cidades values('Luís Gomes',20,'2407005')

insert into cidades values('Macaíba',20,'2407104')

insert into cidades values('Macau',20,'2407203')

insert into cidades values('Major Sales',20,'2407252')

insert into cidades values('Marcelino Vieira',20,'2407302')

insert into cidades values('Martins',20,'2407401')

insert into cidades values('Maxaranguape',20,'2407500')

insert into cidades values('Messias Targino',20,'2407609')

insert into cidades values('Montanhas',20,'2407708')

insert into cidades values('Monte Alegre',20,'2407807')

insert into cidades values('Monte das Gameleiras',20,'2407906')

insert into cidades values('Mossoró',20,'2408003')

insert into cidades values('Natal',20,'2408102')

insert into cidades values('Nísia Floresta',20,'2408201')

insert into cidades values('Nova Cruz',20,'2408300')

insert into cidades values('Olho-dÁgua do Borges',20,'2408409')

insert into cidades values('Ouro Branco',20,'2408508')

insert into cidades values('Paraná',20,'2408607')

insert into cidades values('Paraú',20,'2408706')

insert into cidades values('Parazinho',20,'2408805')

insert into cidades values('Parelhas',20,'2408904')

insert into cidades values('Parnamirim',20,'2403251')

insert into cidades values('Passa e Fica',20,'2409100')

insert into cidades values('Passagem',20,'2409209')

insert into cidades values('Patu',20,'2409308')

insert into cidades values('Pau dos Ferros',20,'2409407')

insert into cidades values('Pedra Grande',20,'2409506')

insert into cidades values('Pedra Preta',20,'2409605')

insert into cidades values('Pedro Avelino',20,'2409704')

insert into cidades values('Pedro Velho',20,'2409803')

insert into cidades values('Pendências',20,'2409902')

insert into cidades values('Pilões',20,'2410009')

insert into cidades values('Poço Branco',20,'2410108')

insert into cidades values('Portalegre',20,'2410207')

insert into cidades values('Porto do Mangue',20,'2410256')

insert into cidades values('Presidente Juscelino',20,'2410306')

insert into cidades values('Pureza',20,'2410405')

insert into cidades values('Rafael Fernandes',20,'2410504')

insert into cidades values('Rafael Godeiro',20,'2410603')

insert into cidades values('Riacho da Cruz',20,'2410702')

insert into cidades values('Riacho de Santana',20,'2410801')

insert into cidades values('Riachuelo',20,'2410900')

insert into cidades values('Rio do Fogo',20,'2408953')

insert into cidades values('Rodolfo Fernandes',20,'2411007')

insert into cidades values('Ruy Barbosa',20,'2411106')

insert into cidades values('Santa Cruz',20,'2411205')

insert into cidades values('Santa Maria',20,'2409332')

insert into cidades values('Santana do Matos',20,'2411403')

insert into cidades values('Santana do Seridó',20,'2411429')

insert into cidades values('Santo Antônio',20,'2411502')

insert into cidades values('São Bento do Norte',20,'2411601')

insert into cidades values('São Bento do Trairí',20,'2411700')

insert into cidades values('São Fernando',20,'2411809')

insert into cidades values('São Francisco do Oeste',20,'2411908')

insert into cidades values('São Gonçalo do Amarante',20,'2412005')

insert into cidades values('São João do Sabugi',20,'2412104')

insert into cidades values('São José de Mipibu',20,'2412203')

insert into cidades values('São José do Campestre',20,'2412302')

insert into cidades values('São José do Seridó',20,'2412401')

insert into cidades values('São Miguel',20,'2412500')

insert into cidades values('São Miguel do Gostoso',20,'2412559')

insert into cidades values('São Paulo do Potengi',20,'2412609')

insert into cidades values('São Pedro',20,'2412708')

insert into cidades values('São Rafael',20,'2412807')

insert into cidades values('São Tomé',20,'2412906')

insert into cidades values('São Vicente',20,'2413003')

insert into cidades values('Senador Elói de Souza',20,'2413102')

insert into cidades values('Senador Georgino Avelino',20,'2413201')

insert into cidades values('Serra de São Bento',20,'2413300')

insert into cidades values('Serra do Mel',20,'2413359')

insert into cidades values('Serra Negra do Norte',20,'2413409')

insert into cidades values('Serrinha',20,'2413508')

insert into cidades values('Serrinha dos Pintos',20,'2413557')

insert into cidades values('Severiano Melo',20,'2413607')

insert into cidades values('Sítio Novo',20,'2413706')

insert into cidades values('Taboleiro Grande',20,'2413805')

insert into cidades values('Taipu',20,'2413904')

insert into cidades values('Tangará',20,'2414001')

insert into cidades values('Tenente Ananias',20,'2414100')

insert into cidades values('Tenente Laurentino Cruz',20,'2414159')

insert into cidades values('Tibau',20,'2411056')

insert into cidades values('Tibau do Sul',20,'2414209')

insert into cidades values('Timbaúba dos Batistas',20,'2414308')

insert into cidades values('Touros',20,'2414407')

insert into cidades values('Triunfo Potiguar',20,'2414456')

insert into cidades values('Umarizal',20,'2414506')

insert into cidades values('Upanema',20,'2414605')

insert into cidades values('Várzea',20,'2414704')

insert into cidades values('Venha-Ver',20,'2414753')

insert into cidades values('Vera Cruz',20,'2414803')

insert into cidades values('Viçosa',20,'2414902')

insert into cidades values('Vila Flor',20,'2415008')

insert into cidades values('Aceguá',23,'4300034')

insert into cidades values('Água Santa',23,'4300059')

insert into cidades values('Agudo',23,'4300109')

insert into cidades values('Ajuricaba',23,'4300208')

insert into cidades values('Alecrim',23,'4300307')

insert into cidades values('Alegrete',23,'4300406')

insert into cidades values('Alegria',23,'4300455')

insert into cidades values('Almirante Tamandaré do Sul',23,'4300471')

insert into cidades values('Alpestre',23,'4300505')

insert into cidades values('Alto Alegre',23,'4300554')

insert into cidades values('Alto Feliz',23,'4300570')

insert into cidades values('Alvorada',23,'4300604')

insert into cidades values('Amaral Ferrador',23,'4300638')

insert into cidades values('Ametista do Sul',23,'4300646')

insert into cidades values('André da Rocha',23,'4300661')

insert into cidades values('Anta Gorda',23,'4300703')

insert into cidades values('Antônio Prado',23,'4300802')

insert into cidades values('Arambaré',23,'4300851')

insert into cidades values('Araricá',23,'4300877')

insert into cidades values('Aratiba',23,'4300901')

insert into cidades values('Arroio do Meio',23,'4301008')

insert into cidades values('Arroio do Padre',23,'4301073')

insert into cidades values('Arroio do Sal',23,'4301057')

insert into cidades values('Arroio do Tigre',23,'4301206')

insert into cidades values('Arroio dos Ratos',23,'4301107')

insert into cidades values('Arroio Grande',23,'4301305')

insert into cidades values('Arvorezinha',23,'4301404')

insert into cidades values('Augusto Pestana',23,'4301503')

insert into cidades values('Áurea',23,'4301552')

insert into cidades values('Bagé',23,'4301602')

insert into cidades values('Balneário Pinhal',23,'4301636')

insert into cidades values('Barão',23,'4301651')

insert into cidades values('Barão de Cotegipe',23,'4301701')

insert into cidades values('Barão do Triunfo',23,'4301750')

insert into cidades values('Barra do Guarita',23,'4301859')

insert into cidades values('Barra do Quaraí',23,'4301875')

insert into cidades values('Barra do Ribeiro',23,'4301909')

insert into cidades values('Barra do Rio Azul',23,'4301925')

insert into cidades values('Barra Funda',23,'4301958')

insert into cidades values('Barracão',23,'4301800')

insert into cidades values('Barros Cassal',23,'4302006')

insert into cidades values('Benjamin Constant do Sul',23,'4302055')

insert into cidades values('Bento Gonçalves',23,'4302105')

insert into cidades values('Boa Vista das Missões',23,'4302154')

insert into cidades values('Boa Vista do Buricá',23,'4302204')

insert into cidades values('Boa Vista do Cadeado',23,'4302220')

insert into cidades values('Boa Vista do Incra',23,'4302238')

insert into cidades values('Boa Vista do Sul',23,'4302253')

insert into cidades values('Bom Jesus',23,'4302303')

insert into cidades values('Bom Princípio',23,'4302352')

insert into cidades values('Bom Progresso',23,'4302378')

insert into cidades values('Bom Retiro do Sul',23,'4302402')

insert into cidades values('Boqueirão do Leão',23,'4302451')

insert into cidades values('Bossoroca',23,'4302501')

insert into cidades values('Bozano',23,'4302584')

insert into cidades values('Braga',23,'4302600')

insert into cidades values('Brochier',23,'4302659')

insert into cidades values('Butiá',23,'4302709')

insert into cidades values('Caçapava do Sul',23,'4302808')

insert into cidades values('Cacequi',23,'4302907')

insert into cidades values('Cachoeira do Sul',23,'4303004')

insert into cidades values('Cachoeirinha',23,'4303103')

insert into cidades values('Cacique Doble',23,'4303202')

insert into cidades values('Caibaté',23,'4303301')

insert into cidades values('Caiçara',23,'4303400')

insert into cidades values('Camaquã',23,'4303509')

insert into cidades values('Camargo',23,'4303558')

insert into cidades values('Cambará do Sul',23,'4303608')

insert into cidades values('Campestre da Serra',23,'4303673')

insert into cidades values('Campina das Missões',23,'4303707')

insert into cidades values('Campinas do Sul',23,'4303806')

insert into cidades values('Campo Bom',23,'4303905')

insert into cidades values('Campo Novo',23,'4304002')

insert into cidades values('Campos Borges',23,'4304101')

insert into cidades values('Candelária',23,'4304200')

insert into cidades values('Cândido Godói',23,'4304309')

insert into cidades values('Candiota',23,'4304358')

insert into cidades values('Canela',23,'4304408')

insert into cidades values('Canguçu',23,'4304507')

insert into cidades values('Canoas',23,'4304606')

insert into cidades values('Canudos do Vale',23,'4304614')

insert into cidades values('Capão Bonito do Sul',23,'4304622')

insert into cidades values('Capão da Canoa',23,'4304630')

insert into cidades values('Capão do Cipó',23,'4304655')

insert into cidades values('Capão do Leão',23,'4304663')

insert into cidades values('Capela de Santana',23,'4304689')

insert into cidades values('Capitão',23,'4304697')

insert into cidades values('Capivari do Sul',23,'4304671')

insert into cidades values('Caraá',23,'4304713')

insert into cidades values('Carazinho',23,'4304705')

insert into cidades values('Carlos Barbosa',23,'4304804')

insert into cidades values('Carlos Gomes',23,'4304853')

insert into cidades values('Casca',23,'4304903')

insert into cidades values('Caseiros',23,'4304952')

insert into cidades values('Catuípe',23,'4305009')

insert into cidades values('Caxias do Sul',23,'4305108')

insert into cidades values('Centenário',23,'4305116')

insert into cidades values('Cerrito',23,'4305124')

insert into cidades values('Cerro Branco',23,'4305132')

insert into cidades values('Cerro Grande',23,'4305157')

insert into cidades values('Cerro Grande do Sul',23,'4305173')

insert into cidades values('Cerro Largo',23,'4305207')

insert into cidades values('Chapada',23,'4305306')

insert into cidades values('Charqueadas',23,'4305355')

insert into cidades values('Charrua',23,'4305371')

insert into cidades values('Chiapetta',23,'4305405')

insert into cidades values('Chuí',23,'4305439')

insert into cidades values('Chuvisca',23,'4305447')

insert into cidades values('Cidreira',23,'4305454')

insert into cidades values('Ciríaco',23,'4305504')

insert into cidades values('Colinas',23,'4305587')

insert into cidades values('Colorado',23,'4305603')

insert into cidades values('Condor',23,'4305702')

insert into cidades values('Constantina',23,'4305801')

insert into cidades values('Coqueiro Baixo',23,'4305835')

insert into cidades values('Coqueiros do Sul',23,'4305850')

insert into cidades values('Coronel Barros',23,'4305871')

insert into cidades values('Coronel Bicaco',23,'4305900')

insert into cidades values('Coronel Pilar',23,'4305934')

insert into cidades values('Cotiporã',23,'4305959')

insert into cidades values('Coxilha',23,'4305975')

insert into cidades values('Crissiumal',23,'4306007')

insert into cidades values('Cristal',23,'4306056')

insert into cidades values('Cristal do Sul',23,'4306072')

insert into cidades values('Cruz Alta',23,'4306106')

insert into cidades values('Cruzaltense',23,'4306130')

insert into cidades values('Cruzeiro do Sul',23,'4306205')

insert into cidades values('David Canabarro',23,'4306304')

insert into cidades values('Derrubadas',23,'4306320')

insert into cidades values('Dezesseis de Novembro',23,'4306353')

insert into cidades values('Dilermando de Aguiar',23,'4306379')

insert into cidades values('Dois Irmãos',23,'4306403')

insert into cidades values('Dois Irmãos das Missões',23,'4306429')

insert into cidades values('Dois Lajeados',23,'4306452')

insert into cidades values('Dom Feliciano',23,'4306502')

insert into cidades values('Dom Pedrito',23,'4306601')

insert into cidades values('Dom Pedro de Alcântara',23,'4306551')

insert into cidades values('Dona Francisca',23,'4306700')

insert into cidades values('Doutor Maurício Cardoso',23,'4306734')

insert into cidades values('Doutor Ricardo',23,'4306759')

insert into cidades values('Eldorado do Sul',23,'4306767')

insert into cidades values('Encantado',23,'4306809')

insert into cidades values('Encruzilhada do Sul',23,'4306908')

insert into cidades values('Engenho Velho',23,'4306924')

insert into cidades values('Entre Rios do Sul',23,'4306957')

insert into cidades values('Entre-Ijuís',23,'4306932')

insert into cidades values('Erebango',23,'4306973')

insert into cidades values('Erechim',23,'4307005')

insert into cidades values('Ernestina',23,'4307054')

insert into cidades values('Erval Grande',23,'4307203')

insert into cidades values('Erval Seco',23,'4307302')

insert into cidades values('Esmeralda',23,'4307401')

insert into cidades values('Esperança do Sul',23,'4307450')

insert into cidades values('Espumoso',23,'4307500')

insert into cidades values('Estação',23,'4307559')

insert into cidades values('Estância Velha',23,'4307609')

insert into cidades values('Esteio',23,'4307708')

insert into cidades values('Estrela',23,'4307807')

insert into cidades values('Estrela Velha',23,'4307815')

insert into cidades values('Eugênio de Castro',23,'4307831')

insert into cidades values('Fagundes Varela',23,'4307864')

insert into cidades values('Farroupilha',23,'4307906')

insert into cidades values('Faxinal do Soturno',23,'4308003')

insert into cidades values('Faxinalzinho',23,'4308052')

insert into cidades values('Fazenda Vilanova',23,'4308078')

insert into cidades values('Feliz',23,'4308102')

insert into cidades values('Flores da Cunha',23,'4308201')

insert into cidades values('Floriano Peixoto',23,'4308250')

insert into cidades values('Fontoura Xavier',23,'4308300')

insert into cidades values('Formigueiro',23,'4308409')

insert into cidades values('Forquetinha',23,'4308433')

insert into cidades values('Fortaleza dos Valos',23,'4308458')

insert into cidades values('Frederico Westphalen',23,'4308508')

insert into cidades values('Garibaldi',23,'4308607')

insert into cidades values('Garruchos',23,'4308656')

insert into cidades values('Gaurama',23,'4308706')

insert into cidades values('General Câmara',23,'4308805')

insert into cidades values('Gentil',23,'4308854')

insert into cidades values('Getúlio Vargas',23,'4308904')

insert into cidades values('Giruá',23,'4309001')

insert into cidades values('Glorinha',23,'4309050')

insert into cidades values('Gramado',23,'4309100')

insert into cidades values('Gramado dos Loureiros',23,'4309126')

insert into cidades values('Gramado Xavier',23,'4309159')

insert into cidades values('Gravataí',23,'4309209')

insert into cidades values('Guabiju',23,'4309258')

insert into cidades values('Guaíba',23,'4309308')

insert into cidades values('Guaporé',23,'4309407')

insert into cidades values('Guarani das Missões',23,'4309506')

insert into cidades values('Harmonia',23,'4309555')

insert into cidades values('Herval',23,'4307104')

insert into cidades values('Herveiras',23,'4309571')

insert into cidades values('Horizontina',23,'4309605')

insert into cidades values('Hulha Negra',23,'4309654')

insert into cidades values('Humaitá',23,'4309704')

insert into cidades values('Ibarama',23,'4309753')

insert into cidades values('Ibiaçá',23,'4309803')

insert into cidades values('Ibiraiaras',23,'4309902')

insert into cidades values('Ibirapuitã',23,'4309951')

insert into cidades values('Ibirubá',23,'4310009')

insert into cidades values('Igrejinha',23,'4310108')

insert into cidades values('Ijuí',23,'4310207')

insert into cidades values('Ilópolis',23,'4310306')

insert into cidades values('Imbé',23,'4310330')

insert into cidades values('Imigrante',23,'4310363')

insert into cidades values('Independência',23,'4310405')

insert into cidades values('Inhacorá',23,'4310413')

insert into cidades values('Ipê',23,'4310439')

insert into cidades values('Ipiranga do Sul',23,'4310462')

insert into cidades values('Iraí',23,'4310504')

insert into cidades values('Itaara',23,'4310538')

insert into cidades values('Itacurubi',23,'4310553')

insert into cidades values('Itapuca',23,'4310579')

insert into cidades values('Itaqui',23,'4310603')

insert into cidades values('Itati',23,'4310652')

insert into cidades values('Itatiba do Sul',23,'4310702')

insert into cidades values('Ivorá',23,'4310751')

insert into cidades values('Ivoti',23,'4310801')

insert into cidades values('Jaboticaba',23,'4310850')

insert into cidades values('Jacuizinho',23,'4310876')

insert into cidades values('Jacutinga',23,'4310900')

insert into cidades values('Jaguarão',23,'4311007')

insert into cidades values('Jaguari',23,'4311106')

insert into cidades values('Jaquirana',23,'4311122')

insert into cidades values('Jari',23,'4311130')

insert into cidades values('Jóia',23,'4311155')

insert into cidades values('Júlio de Castilhos',23,'4311205')

insert into cidades values('Lagoa Bonita do Sul',23,'4311239')

insert into cidades values('Lagoa dos Três Cantos',23,'4311270')

insert into cidades values('Lagoa Vermelha',23,'4311304')

insert into cidades values('Lagoão',23,'4311254')

insert into cidades values('Lajeado',23,'4311403')

insert into cidades values('Lajeado do Bugre',23,'4311429')

insert into cidades values('Lavras do Sul',23,'4311502')

insert into cidades values('Liberato Salzano',23,'4311601')

insert into cidades values('Lindolfo Collor',23,'4311627')

insert into cidades values('Linha Nova',23,'4311643')

insert into cidades values('Maçambara',23,'4311718')

insert into cidades values('Machadinho',23,'4311700')

insert into cidades values('Mampituba',23,'4311734')

insert into cidades values('Manoel Viana',23,'4311759')

insert into cidades values('Maquiné',23,'4311775')

insert into cidades values('Maratá',23,'4311791')

insert into cidades values('Marau',23,'4311809')

insert into cidades values('Marcelino Ramos',23,'4311908')

insert into cidades values('Mariana Pimentel',23,'4311981')

insert into cidades values('Mariano Moro',23,'4312005')

insert into cidades values('Marques de Souza',23,'4312054')

insert into cidades values('Mata',23,'4312104')

insert into cidades values('Mato Castelhano',23,'4312138')

insert into cidades values('Mato Leitão',23,'4312153')

insert into cidades values('Mato Queimado',23,'4312179')

insert into cidades values('Maximiliano de Almeida',23,'4312203')

insert into cidades values('Minas do Leão',23,'4312252')

insert into cidades values('Miraguaí',23,'4312302')

insert into cidades values('Montauri',23,'4312351')

insert into cidades values('Monte Alegre dos Campos',23,'4312377')

insert into cidades values('Monte Belo do Sul',23,'4312385')

insert into cidades values('Montenegro',23,'4312401')

insert into cidades values('Mormaço',23,'4312427')

insert into cidades values('Morrinhos do Sul',23,'4312443')

insert into cidades values('Morro Redondo',23,'4312450')

insert into cidades values('Morro Reuter',23,'4312476')

insert into cidades values('Mostardas',23,'4312500')

insert into cidades values('Muçum',23,'4312609')

insert into cidades values('Muitos Capões',23,'4312617')

insert into cidades values('Muliterno',23,'4312625')

insert into cidades values('Não-Me-Toque',23,'4312658')

insert into cidades values('Nicolau Vergueiro',23,'4312674')

insert into cidades values('Nonoai',23,'4312708')

insert into cidades values('Nova Alvorada',23,'4312757')

insert into cidades values('Nova Araçá',23,'4312807')

insert into cidades values('Nova Bassano',23,'4312906')

insert into cidades values('Nova Boa Vista',23,'4312955')

insert into cidades values('Nova Bréscia',23,'4313003')

insert into cidades values('Nova Candelária',23,'4313011')

insert into cidades values('Nova Esperança do Sul',23,'4313037')

insert into cidades values('Nova Hartz',23,'4313060')

insert into cidades values('Nova Pádua',23,'4313086')

insert into cidades values('Nova Palma',23,'4313102')

insert into cidades values('Nova Petrópolis',23,'4313201')

insert into cidades values('Nova Prata',23,'4313300')

insert into cidades values('Nova Ramada',23,'4313334')

insert into cidades values('Nova Roma do Sul',23,'4313359')

insert into cidades values('Nova Santa Rita',23,'4313375')

insert into cidades values('Novo Barreiro',23,'4313490')

insert into cidades values('Novo Cabrais',23,'4313391')

insert into cidades values('Novo Hamburgo',23,'4313409')

insert into cidades values('Novo Machado',23,'4313425')

insert into cidades values('Novo Tiradentes',23,'4313441')

insert into cidades values('Novo Xingu',23,'4313466')

insert into cidades values('Osório',23,'4313508')

insert into cidades values('Paim Filho',23,'4313607')

insert into cidades values('Palmares do Sul',23,'4313656')

insert into cidades values('Palmeira das Missões',23,'4313706')

insert into cidades values('Palmitinho',23,'4313805')

insert into cidades values('Panambi',23,'4313904')

insert into cidades values('Pantano Grande',23,'4313953')

insert into cidades values('Paraí',23,'4314001')

insert into cidades values('Paraíso do Sul',23,'4314027')

insert into cidades values('Pareci Novo',23,'4314035')

insert into cidades values('Parobé',23,'4314050')

insert into cidades values('Passa Sete',23,'4314068')

insert into cidades values('Passo do Sobrado',23,'4314076')

insert into cidades values('Passo Fundo',23,'4314100')

insert into cidades values('Paulo Bento',23,'4314134')

insert into cidades values('Paverama',23,'4314159')

insert into cidades values('Pedras Altas',23,'4314175')

insert into cidades values('Pedro Osório',23,'4314209')

insert into cidades values('Pejuçara',23,'4314308')

insert into cidades values('Pelotas',23,'4314407')

insert into cidades values('Picada Café',23,'4314423')

insert into cidades values('Pinhal',23,'4314456')

insert into cidades values('Pinhal da Serra',23,'4314464')

insert into cidades values('Pinhal Grande',23,'4314472')

insert into cidades values('Pinheirinho do Vale',23,'4314498')

insert into cidades values('Pinheiro Machado',23,'4314506')

insert into cidades values('Pirapó',23,'4314555')

insert into cidades values('Piratini',23,'4314605')

insert into cidades values('Planalto',23,'4314704')

insert into cidades values('Poço das Antas',23,'4314753')

insert into cidades values('Pontão',23,'4314779')

insert into cidades values('Ponte Preta',23,'4314787')

insert into cidades values('Portão',23,'4314803')

insert into cidades values('Porto Alegre',23,'4314902')

insert into cidades values('Porto Lucena',23,'4315008')

insert into cidades values('Porto Mauá',23,'4315057')

insert into cidades values('Porto Vera Cruz',23,'4315073')

insert into cidades values('Porto Xavier',23,'4315107')

insert into cidades values('Pouso Novo',23,'4315131')

insert into cidades values('Presidente Lucena',23,'4315149')

insert into cidades values('Progresso',23,'4315156')

insert into cidades values('Protásio Alves',23,'4315172')

insert into cidades values('Putinga',23,'4315206')

insert into cidades values('Quaraí',23,'4315305')

insert into cidades values('Quatro Irmãos',23,'4315313')

insert into cidades values('Quevedos',23,'4315321')

insert into cidades values('Quinze de Novembro',23,'4315354')

insert into cidades values('Redentora',23,'4315404')

insert into cidades values('Relvado',23,'4315453')

insert into cidades values('Restinga Seca',23,'4315503')

insert into cidades values('Rio dos Índios',23,'4315552')

insert into cidades values('Rio Grande',23,'4315602')

insert into cidades values('Rio Pardo',23,'4315701')

insert into cidades values('Riozinho',23,'4315750')

insert into cidades values('Roca Sales',23,'4315800')

insert into cidades values('Rodeio Bonito',23,'4315909')

insert into cidades values('Rolador',23,'4315958')

insert into cidades values('Rolante',23,'4316006')

insert into cidades values('Ronda Alta',23,'4316105')

insert into cidades values('Rondinha',23,'4316204')

insert into cidades values('Roque Gonzales',23,'4316303')

insert into cidades values('Rosário do Sul',23,'4316402')

insert into cidades values('Sagrada Família',23,'4316428')

insert into cidades values('Saldanha Marinho',23,'4316436')

insert into cidades values('Salto do Jacuí',23,'4316451')

insert into cidades values('Salvador das Missões',23,'4316477')

insert into cidades values('Salvador do Sul',23,'4316501')

insert into cidades values('Sananduva',23,'4316600')

insert into cidades values('Santa Bárbara do Sul',23,'4316709')

insert into cidades values('Santa Cecília do Sul',23,'4316733')

insert into cidades values('Santa Clara do Sul',23,'4316758')

insert into cidades values('Santa Cruz do Sul',23,'4316808')

insert into cidades values('Santa Margarida do Sul',23,'4316972')

insert into cidades values('Santa Maria',23,'4316907')

insert into cidades values('Santa Maria do Herval',23,'4316956')

insert into cidades values('Santa Rosa',23,'4317202')

insert into cidades values('Santa Tereza',23,'4317251')

insert into cidades values('Santa Vitória do Palmar',23,'4317301')

insert into cidades values('Santana da Boa Vista',23,'4317004')

insert into cidades values('Santana do Livramento',23,'4317103')

insert into cidades values('Santiago',23,'4317400')

insert into cidades values('Santo Ângelo',23,'4317509')

insert into cidades values('Santo Antônio da Patrulha',23,'4317608')

insert into cidades values('Santo Antônio das Missões',23,'4317707')

insert into cidades values('Santo Antônio do Palma',23,'4317558')

insert into cidades values('Santo Antônio do Planalto',23,'4317756')

insert into cidades values('Santo Augusto',23,'4317806')

insert into cidades values('Santo Cristo',23,'4317905')

insert into cidades values('Santo Expedito do Sul',23,'4317954')

insert into cidades values('São Borja',23,'4318002')

insert into cidades values('São Domingos do Sul',23,'4318051')

insert into cidades values('São Francisco de Assis',23,'4318101')

insert into cidades values('São Francisco de Paula',23,'4318200')

insert into cidades values('São Gabriel',23,'4318309')

insert into cidades values('São Jerônimo',23,'4318408')

insert into cidades values('São João da Urtiga',23,'4318424')

insert into cidades values('São João do Polêsine',23,'4318432')

insert into cidades values('São Jorge',23,'4318440')

insert into cidades values('São José das Missões',23,'4318457')

insert into cidades values('São José do Herval',23,'4318465')

insert into cidades values('São José do Hortêncio',23,'4318481')

insert into cidades values('São José do Inhacorá',23,'4318499')

insert into cidades values('São José do Norte',23,'4318507')

insert into cidades values('São José do Ouro',23,'4318606')

insert into cidades values('São José do Sul',23,'4318614')

insert into cidades values('São José dos Ausentes',23,'4318622')

insert into cidades values('São Leopoldo',23,'4318705')

insert into cidades values('São Lourenço do Sul',23,'4318804')

insert into cidades values('São Luiz Gonzaga',23,'4318903')

insert into cidades values('São Marcos',23,'4319000')

insert into cidades values('São Martinho',23,'4319109')

insert into cidades values('São Martinho da Serra',23,'4319125')

insert into cidades values('São Miguel das Missões',23,'4319158')

insert into cidades values('São Nicolau',23,'4319208')

insert into cidades values('São Paulo das Missões',23,'4319307')

insert into cidades values('São Pedro da Serra',23,'4319356')

insert into cidades values('São Pedro das Missões',23,'4319364')

insert into cidades values('São Pedro do Butiá',23,'4319372')

insert into cidades values('São Pedro do Sul',23,'4319406')

insert into cidades values('São Sebastião do Caí',23,'4319505')

insert into cidades values('São Sepé',23,'4319604')

insert into cidades values('São Valentim',23,'4319703')

insert into cidades values('São Valentim do Sul',23,'4319711')

insert into cidades values('São Valério do Sul',23,'4319737')

insert into cidades values('São Vendelino',23,'4319752')

insert into cidades values('São Vicente do Sul',23,'4319802')

insert into cidades values('Sapiranga',23,'4319901')

insert into cidades values('Sapucaia do Sul',23,'4320008')

insert into cidades values('Sarandi',23,'4320107')

insert into cidades values('Seberi',23,'4320206')

insert into cidades values('Sede Nova',23,'4320230')

insert into cidades values('Segredo',23,'4320263')

insert into cidades values('Selbach',23,'4320305')

insert into cidades values('Senador Salgado Filho',23,'4320321')

insert into cidades values('Sentinela do Sul',23,'4320354')

insert into cidades values('Serafina Corrêa',23,'4320404')

insert into cidades values('Sério',23,'4320453')

insert into cidades values('Sertão',23,'4320503')

insert into cidades values('Sertão Santana',23,'4320552')

insert into cidades values('Sete de Setembro',23,'4320578')

insert into cidades values('Severiano de Almeida',23,'4320602')

insert into cidades values('Silveira Martins',23,'4320651')

insert into cidades values('Sinimbu',23,'4320677')

insert into cidades values('Sobradinho',23,'4320701')

insert into cidades values('Soledade',23,'4320800')

insert into cidades values('Tabaí',23,'4320859')

insert into cidades values('Tapejara',23,'4320909')

insert into cidades values('Tapera',23,'4321006')

insert into cidades values('Tapes',23,'4321105')

insert into cidades values('Taquara',23,'4321204')

insert into cidades values('Taquari',23,'4321303')

insert into cidades values('Taquaruçu do Sul',23,'4321329')

insert into cidades values('Tavares',23,'4321352')

insert into cidades values('Tenente Portela',23,'4321402')

insert into cidades values('Terra de Areia',23,'4321436')

insert into cidades values('Teutônia',23,'4321451')

insert into cidades values('Tio Hugo',23,'4321469')

insert into cidades values('Tiradentes do Sul',23,'4321477')

insert into cidades values('Toropi',23,'4321493')

insert into cidades values('Torres',23,'4321501')

insert into cidades values('Tramandaí',23,'4321600')

insert into cidades values('Travesseiro',23,'4321626')

insert into cidades values('Três Arroios',23,'4321634')

insert into cidades values('Três Cachoeiras',23,'4321667')

insert into cidades values('Três Coroas',23,'4321709')

insert into cidades values('Três de Maio',23,'4321808')

insert into cidades values('Três Forquilhas',23,'4321832')

insert into cidades values('Três Palmeiras',23,'4321857')

insert into cidades values('Três Passos',23,'4321907')

insert into cidades values('Trindade do Sul',23,'4321956')

insert into cidades values('Triunfo',23,'4322004')

insert into cidades values('Tucunduva',23,'4322103')

insert into cidades values('Tunas',23,'4322152')

insert into cidades values('Tupanci do Sul',23,'4322186')

insert into cidades values('Tupanciretã',23,'4322202')

insert into cidades values('Tupandi',23,'4322251')

insert into cidades values('Tuparendi',23,'4322301')

insert into cidades values('Turuçu',23,'4322327')

insert into cidades values('Ubiretama',23,'4322343')

insert into cidades values('União da Serra',23,'4322350')

insert into cidades values('Unistalda',23,'4322376')

insert into cidades values('Uruguaiana',23,'4322400')

insert into cidades values('Vacaria',23,'4322509')

insert into cidades values('Vale do Sol',23,'4322533')

insert into cidades values('Vale Real',23,'4322541')

insert into cidades values('Vale Verde',23,'4322525')

insert into cidades values('Vanini',23,'4322558')

insert into cidades values('Venâncio Aires',23,'4322608')

insert into cidades values('Vera Cruz',23,'4322707')

insert into cidades values('Veranópolis',23,'4322806')

insert into cidades values('Vespasiano Correa',23,'4322855')

insert into cidades values('Viadutos',23,'4322905')

insert into cidades values('Viamão',23,'4323002')

insert into cidades values('Vicente Dutra',23,'4323101')

insert into cidades values('Victor Graeff',23,'4323200')

insert into cidades values('Vila Flores',23,'4323309')

insert into cidades values('Vila Lângaro',23,'4323358')

insert into cidades values('Vila Maria',23,'4323408')

insert into cidades values('Vila Nova do Sul',23,'4323457')

insert into cidades values('Vista Alegre',23,'4323507')

insert into cidades values('Vista Alegre do Prata',23,'4323606')

insert into cidades values('Vista Gaúcha',23,'4323705')

insert into cidades values('Vitória das Missões',23,'4323754')

insert into cidades values('Westfália',23,'4323770')

insert into cidades values('Xangri-lá',23,'4323804')

insert into cidades values('Alta Floresta dOeste',21,'1100015')

insert into cidades values('Alto Alegre dos Parecis',21,'1100379')

insert into cidades values('Alto Paraíso',21,'1100403')

insert into cidades values('Alvorada dOeste',21,'1100346')

insert into cidades values('Ariquemes',21,'1100023')

insert into cidades values('Buritis',21,'1100452')

insert into cidades values('Cabixi',21,'1100031')

insert into cidades values('Cacaulândia',21,'1100601')

insert into cidades values('Cacoal',21,'1100049')

insert into cidades values('Campo Novo de Rondônia',21,'1100700')

insert into cidades values('Candeias do Jamari',21,'1100809')

insert into cidades values('Castanheiras',21,'1100908')

insert into cidades values('Cerejeiras',21,'1100056')

insert into cidades values('Chupinguaia',21,'1100924')

insert into cidades values('Colorado do Oeste',21,'1100064')

insert into cidades values('Corumbiara',21,'1100072')

insert into cidades values('Costa Marques',21,'1100080')

insert into cidades values('Cujubim',21,'1100940')

insert into cidades values('Espigão dOeste',21,'1100098')

insert into cidades values('Governador Jorge Teixeira',21,'1101005')

insert into cidades values('Guajará-Mirim',21,'1100106')

insert into cidades values('Itapuã do Oeste',21,'1101104')

insert into cidades values('Jaru',21,'1100114')

insert into cidades values('Ji-Paraná',21,'1100122')

insert into cidades values('Machadinho dOeste',21,'1100130')

insert into cidades values('Ministro Andreazza',21,'1101203')

insert into cidades values('Mirante da Serra',21,'1101302')

insert into cidades values('Monte Negro',21,'1101401')

insert into cidades values('Nova Brasilândia dOeste',21,'1100148')

insert into cidades values('Nova Mamoré',21,'1100338')

insert into cidades values('Nova União',21,'1101435')

insert into cidades values('Novo Horizonte do Oeste',21,'1100502')

insert into cidades values('Ouro Preto do Oeste',21,'1100155')

insert into cidades values('Parecis',21,'1101450')

insert into cidades values('Pimenta Bueno',21,'1100189')

insert into cidades values('Pimenteiras do Oeste',21,'1101468')

insert into cidades values('Porto Velho',21,'1100205')

insert into cidades values('Presidente Médici',21,'1100254')

insert into cidades values('Primavera de Rondônia',21,'1101476')

insert into cidades values('Rio Crespo',21,'1100262')

insert into cidades values('Rolim de Moura',21,'1100288')

insert into cidades values('Santa Luzia dOeste',21,'1100296')

insert into cidades values('São Felipe dOeste',21,'1101484')

insert into cidades values('São Francisco do Guaporé',21,'1101492')

insert into cidades values('São Miguel do Guaporé',21,'1100320')

insert into cidades values('Seringueiras',21,'1101500')

insert into cidades values('Teixeirópolis',21,'1101559')

insert into cidades values('Theobroma',21,'1101609')

insert into cidades values('Urupá',21,'1101708')

insert into cidades values('Vale do Anari',21,'1101757')

insert into cidades values('Vale do Paraíso',21,'1101807')

insert into cidades values('Vilhena',21,'1100304')

insert into cidades values('Alto Alegre',22,'1400050')

insert into cidades values('Amajari',22,'1400027')

insert into cidades values('Boa Vista',22,'1400100')

insert into cidades values('Bonfim',22,'1400159')

insert into cidades values('Cantá',22,'1400175')

insert into cidades values('Caracaraí',22,'1400209')

insert into cidades values('Caroebe',22,'1400233')

insert into cidades values('Iracema',22,'1400282')

insert into cidades values('Mucajaí',22,'1400308')

insert into cidades values('Normandia',22,'1400407')

insert into cidades values('Pacaraima',22,'1400456')

insert into cidades values('Rorainópolis',22,'1400472')

insert into cidades values('São João da Baliza',22,'1400506')

insert into cidades values('São Luiz',22,'1400605')

insert into cidades values('Uiramutã',22,'1400704')

insert into cidades values('Abdon Batista',24,'4200051')

insert into cidades values('Abelardo Luz',24,'4200101')

insert into cidades values('Agrolândia',24,'4200200')

insert into cidades values('Agronômica',24,'4200309')

insert into cidades values('Água Doce',24,'4200408')

insert into cidades values('Águas de Chapecó',24,'4200507')

insert into cidades values('Águas Frias',24,'4200556')

insert into cidades values('Águas Mornas',24,'4200606')

insert into cidades values('Alfredo Wagner',24,'4200705')

insert into cidades values('Alto Bela Vista',24,'4200754')

insert into cidades values('Anchieta',24,'4200804')

insert into cidades values('Angelina',24,'4200903')

insert into cidades values('Anita Garibaldi',24,'4201000')

insert into cidades values('Anitápolis',24,'4201109')

insert into cidades values('Antônio Carlos',24,'4201208')

insert into cidades values('Apiúna',24,'4201257')

insert into cidades values('Arabutã',24,'4201273')

insert into cidades values('Araquari',24,'4201307')

insert into cidades values('Araranguá',24,'4201406')

insert into cidades values('Armazém',24,'4201505')

insert into cidades values('Arroio Trinta',24,'4201604')

insert into cidades values('Arvoredo',24,'4201653')

insert into cidades values('Ascurra',24,'4201703')

insert into cidades values('Atalanta',24,'4201802')

insert into cidades values('Aurora',24,'4201901')

insert into cidades values('Balneário Arroio do Silva',24,'4201950')

insert into cidades values('Balneário Barra do Sul',24,'4202057')

insert into cidades values('Balneário Camboriú',24,'4202008')

insert into cidades values('Balneário Gaivota',24,'4202073')

insert into cidades values('Bandeirante',24,'4202081')

insert into cidades values('Barra Bonita',24,'4202099')

insert into cidades values('Barra Velha',24,'4202107')

insert into cidades values('Bela Vista do Toldo',24,'4202131')

insert into cidades values('Belmonte',24,'4202156')

insert into cidades values('Benedito Novo',24,'4202206')

insert into cidades values('Biguaçu',24,'4202305')

insert into cidades values('Blumenau',24,'4202404')

insert into cidades values('Bocaina do Sul',24,'4202438')

insert into cidades values('Bom Jardim da Serra',24,'4202503')

insert into cidades values('Bom Jesus',24,'4202537')

insert into cidades values('Bom Jesus do Oeste',24,'4202578')

insert into cidades values('Bom Retiro',24,'4202602')

insert into cidades values('Bombinhas',24,'4202453')

insert into cidades values('Botuverá',24,'4202701')

insert into cidades values('Braço do Norte',24,'4202800')

insert into cidades values('Braço do Trombudo',24,'4202859')

insert into cidades values('Brunópolis',24,'4202875')

insert into cidades values('Brusque',24,'4202909')

insert into cidades values('Caçador',24,'4203006')

insert into cidades values('Caibi',24,'4203105')

insert into cidades values('Calmon',24,'4203154')

insert into cidades values('Camboriú',24,'4203204')

insert into cidades values('Campo Alegre',24,'4203303')

insert into cidades values('Campo Belo do Sul',24,'4203402')

insert into cidades values('Campo Erê',24,'4203501')

insert into cidades values('Campos Novos',24,'4203600')

insert into cidades values('Canelinha',24,'4203709')

insert into cidades values('Canoinhas',24,'4203808')

insert into cidades values('Capão Alto',24,'4203253')

insert into cidades values('Capinzal',24,'4203907')

insert into cidades values('Capivari de Baixo',24,'4203956')

insert into cidades values('Catanduvas',24,'4204004')

insert into cidades values('Caxambu do Sul',24,'4204103')

insert into cidades values('Celso Ramos',24,'4204152')

insert into cidades values('Cerro Negro',24,'4204178')

insert into cidades values('Chapadão do Lageado',24,'4204194')

insert into cidades values('Chapecó',24,'4204202')

insert into cidades values('Cocal do Sul',24,'4204251')

insert into cidades values('Concórdia',24,'4204301')

insert into cidades values('Cordilheira Alta',24,'4204350')

insert into cidades values('Coronel Freitas',24,'4204400')

insert into cidades values('Coronel Martins',24,'4204459')

insert into cidades values('Correia Pinto',24,'4204558')

insert into cidades values('Corupá',24,'4204509')

insert into cidades values('Criciúma',24,'4204608')

insert into cidades values('Cunha Porã',24,'4204707')

insert into cidades values('Cunhataí',24,'4204756')

insert into cidades values('Curitibanos',24,'4204806')

insert into cidades values('Descanso',24,'4204905')

insert into cidades values('Dionísio Cerqueira',24,'4205001')

insert into cidades values('Dona Emma',24,'4205100')

insert into cidades values('Doutor Pedrinho',24,'4205159')

insert into cidades values('Entre Rios',24,'4205175')

insert into cidades values('Ermo',24,'4205191')

insert into cidades values('Erval Velho',24,'4205209')

insert into cidades values('Faxinal dos Guedes',24,'4205308')

insert into cidades values('Flor do Sertão',24,'4205357')

insert into cidades values('Florianópolis',24,'4205407')

insert into cidades values('Formosa do Sul',24,'4205431')

insert into cidades values('Forquilhinha',24,'4205456')

insert into cidades values('Fraiburgo',24,'4205506')

insert into cidades values('Frei Rogério',24,'4205555')

insert into cidades values('Galvão',24,'4205605')

insert into cidades values('Garopaba',24,'4205704')

insert into cidades values('Garuva',24,'4205803')

insert into cidades values('Gaspar',24,'4205902')

insert into cidades values('Governador Celso Ramos',24,'4206009')

insert into cidades values('Grão Pará',24,'4206108')

insert into cidades values('Gravatal',24,'4206207')

insert into cidades values('Guabiruba',24,'4206306')

insert into cidades values('Guaraciaba',24,'4206405')

insert into cidades values('Guaramirim',24,'4206504')

insert into cidades values('Guarujá do Sul',24,'4206603')

insert into cidades values('Guatambú',24,'4206652')

insert into cidades values('Herval dOeste',24,'4206702')

insert into cidades values('Ibiam',24,'4206751')

insert into cidades values('Ibicaré',24,'4206801')

insert into cidades values('Ibirama',24,'4206900')

insert into cidades values('Içara',24,'4207007')

insert into cidades values('Ilhota',24,'4207106')

insert into cidades values('Imaruí',24,'4207205')

insert into cidades values('Imbituba',24,'4207304')

insert into cidades values('Imbuia',24,'4207403')

insert into cidades values('Indaial',24,'4207502')

insert into cidades values('Iomerê',24,'4207577')

insert into cidades values('Ipira',24,'4207601')

insert into cidades values('Iporã do Oeste',24,'4207650')

insert into cidades values('Ipuaçu',24,'4207684')

insert into cidades values('Ipumirim',24,'4207700')

insert into cidades values('Iraceminha',24,'4207759')

insert into cidades values('Irani',24,'4207809')

insert into cidades values('Irati',24,'4207858')

insert into cidades values('Irineópolis',24,'4207908')

insert into cidades values('Itá',24,'4208005')

insert into cidades values('Itaiópolis',24,'4208104')

insert into cidades values('Itajaí',24,'4208203')

insert into cidades values('Itapema',24,'4208302')

insert into cidades values('Itapiranga',24,'4208401')

insert into cidades values('Itapoá',24,'4208450')

insert into cidades values('Ituporanga',24,'4208500')

insert into cidades values('Jaborá',24,'4208609')

insert into cidades values('Jacinto Machado',24,'4208708')

insert into cidades values('Jaguaruna',24,'4208807')

insert into cidades values('Jaraguá do Sul',24,'4208906')

insert into cidades values('Jardinópolis',24,'4208955')

insert into cidades values('Joaçaba',24,'4209003')

insert into cidades values('Joinville',24,'4209102')

insert into cidades values('José Boiteux',24,'4209151')

insert into cidades values('Jupiá',24,'4209177')

insert into cidades values('Lacerdópolis',24,'4209201')

insert into cidades values('Lages',24,'4209300')

insert into cidades values('Laguna',24,'4209409')

insert into cidades values('Lajeado Grande',24,'4209458')

insert into cidades values('Laurentino',24,'4209508')

insert into cidades values('Lauro Muller',24,'4209607')

insert into cidades values('Lebon Régis',24,'4209706')

insert into cidades values('Leoberto Leal',24,'4209805')

insert into cidades values('Lindóia do Sul',24,'4209854')

insert into cidades values('Lontras',24,'4209904')

insert into cidades values('Luiz Alves',24,'4210001')

insert into cidades values('Luzerna',24,'4210035')

insert into cidades values('Macieira',24,'4210050')

insert into cidades values('Mafra',24,'4210100')

insert into cidades values('Major Gercino',24,'4210209')

insert into cidades values('Major Vieira',24,'4210308')

insert into cidades values('Maracajá',24,'4210407')

insert into cidades values('Maravilha',24,'4210506')

insert into cidades values('Marema',24,'4210555')

insert into cidades values('Massaranduba',24,'4210605')

insert into cidades values('Matos Costa',24,'4210704')

insert into cidades values('Meleiro',24,'4210803')

insert into cidades values('Mirim Doce',24,'4210852')

insert into cidades values('Modelo',24,'4210902')

insert into cidades values('Mondaí',24,'4211009')

insert into cidades values('Monte Carlo',24,'4211058')

insert into cidades values('Monte Castelo',24,'4211108')

insert into cidades values('Morro da Fumaça',24,'4211207')

insert into cidades values('Morro Grande',24,'4211256')

insert into cidades values('Navegantes',24,'4211306')

insert into cidades values('Nova Erechim',24,'4211405')

insert into cidades values('Nova Itaberaba',24,'4211454')

insert into cidades values('Nova Trento',24,'4211504')

insert into cidades values('Nova Veneza',24,'4211603')

insert into cidades values('Novo Horizonte',24,'4211652')

insert into cidades values('Orleans',24,'4211702')

insert into cidades values('Otacílio Costa',24,'4211751')

insert into cidades values('Ouro',24,'4211801')

insert into cidades values('Ouro Verde',24,'4211850')

insert into cidades values('Paial',24,'4211876')

insert into cidades values('Painel',24,'4211892')

insert into cidades values('Palhoça',24,'4211900')

insert into cidades values('Palma Sola',24,'4212007')

insert into cidades values('Palmeira',24,'4212056')

insert into cidades values('Palmitos',24,'4212106')

insert into cidades values('Papanduva',24,'4212205')

insert into cidades values('Paraíso',24,'4212239')

insert into cidades values('Passo de Torres',24,'4212254')

insert into cidades values('Passos Maia',24,'4212270')

insert into cidades values('Paulo Lopes',24,'4212304')

insert into cidades values('Pedras Grandes',24,'4212403')

insert into cidades values('Penha',24,'4212502')

insert into cidades values('Peritiba',24,'4212601')

insert into cidades values('Petrolândia',24,'4212700')

insert into cidades values('Balneário Piçarras',24,'4212809')

insert into cidades values('Pinhalzinho',24,'4212908')

insert into cidades values('Pinheiro Preto',24,'4213005')

insert into cidades values('Piratuba',24,'4213104')

insert into cidades values('Planalto Alegre',24,'4213153')

insert into cidades values('Pomerode',24,'4213203')

insert into cidades values('Ponte Alta',24,'4213302')

insert into cidades values('Ponte Alta do Norte',24,'4213351')

insert into cidades values('Ponte Serrada',24,'4213401')

insert into cidades values('Porto Belo',24,'4213500')

insert into cidades values('Porto União',24,'4213609')

insert into cidades values('Pouso Redondo',24,'4213708')

insert into cidades values('Praia Grande',24,'4213807')

insert into cidades values('Presidente Getúlio',24,'4214003')

insert into cidades values('Presidente Nereu',24,'4214102')

insert into cidades values('Princesa',24,'4214151')

insert into cidades values('Quilombo',24,'4214201')

insert into cidades values('Rancho Queimado',24,'4214300')

insert into cidades values('Rio das Antas',24,'4214409')

insert into cidades values('Rio do Campo',24,'4214508')

insert into cidades values('Rio do Oeste',24,'4214607')

insert into cidades values('Rio do Sul',24,'4214805')

insert into cidades values('Rio dos Cedros',24,'4214706')

insert into cidades values('Rio Fortuna',24,'4214904')

insert into cidades values('Rio Negrinho',24,'4215000')

insert into cidades values('Rio Rufino',24,'4215059')

insert into cidades values('Riqueza',24,'4215075')

insert into cidades values('Rodeio',24,'4215109')

insert into cidades values('Romelândia',24,'4215208')

insert into cidades values('Salete',24,'4215307')

insert into cidades values('Saltinho',24,'4215356')

insert into cidades values('Salto Veloso',24,'4215406')

insert into cidades values('Sangão',24,'4215455')

insert into cidades values('Santa Cecília',24,'4215505')

insert into cidades values('Santa Helena',24,'4215554')

insert into cidades values('Santa Rosa de Lima',24,'4215604')

insert into cidades values('Santa Rosa do Sul',24,'4215653')

insert into cidades values('Santa Terezinha',24,'4215679')

insert into cidades values('Santa Terezinha do Progresso',24,'4215687')

insert into cidades values('Santiago do Sul',24,'4215695')

insert into cidades values('Santo Amaro da Imperatriz',24,'4215703')

insert into cidades values('São Bento do Sul',24,'4215802')

insert into cidades values('São Bernardino',24,'4215752')

insert into cidades values('São Bonifácio',24,'4215901')

insert into cidades values('São Carlos',24,'4216008')

insert into cidades values('São Cristovão do Sul',24,'4216057')

insert into cidades values('São Domingos',24,'4216107')

insert into cidades values('São Francisco do Sul',24,'4216206')

insert into cidades values('São João Batista',24,'4216305')

insert into cidades values('São João do Itaperiú',24,'4216354')

insert into cidades values('São João do Oeste',24,'4216255')

insert into cidades values('São João do Sul',24,'4216404')

insert into cidades values('São Joaquim',24,'4216503')

insert into cidades values('São José',24,'4216602')

insert into cidades values('São José do Cedro',24,'4216701')

insert into cidades values('São José do Cerrito',24,'4216800')

insert into cidades values('São Lourenço do Oeste',24,'4216909')

insert into cidades values('São Ludgero',24,'4217006')

insert into cidades values('São Martinho',24,'4217105')

insert into cidades values('São Miguel da Boa Vista',24,'4217154')

insert into cidades values('São Miguel do Oeste',24,'4217204')

insert into cidades values('São Pedro de Alcântara',24,'4217253')

insert into cidades values('Saudades',24,'4217303')

insert into cidades values('Schroeder',24,'4217402')

insert into cidades values('Seara',24,'4217501')

insert into cidades values('Serra Alta',24,'4217550')

insert into cidades values('Siderópolis',24,'4217600')

insert into cidades values('Sombrio',24,'4217709')

insert into cidades values('Sul Brasil',24,'4217758')

insert into cidades values('Taió',24,'4217808')

insert into cidades values('Tangará',24,'4217907')

insert into cidades values('Tigrinhos',24,'4217956')

insert into cidades values('Tijucas',24,'4218004')

insert into cidades values('Timbé do Sul',24,'4218103')

insert into cidades values('Timbó',24,'4218202')

insert into cidades values('Timbó Grande',24,'4218251')

insert into cidades values('Três Barras',24,'4218301')

insert into cidades values('Treviso',24,'4218350')

insert into cidades values('Treze de Maio',24,'4218400')

insert into cidades values('Treze Tílias',24,'4218509')

insert into cidades values('Trombudo Central',24,'4218608')

insert into cidades values('Tubarão',24,'4218707')

insert into cidades values('Tunápolis',24,'4218756')

insert into cidades values('Turvo',24,'4218806')

insert into cidades values('União do Oeste',24,'4218855')

insert into cidades values('Urubici',24,'4218905')

insert into cidades values('Urupema',24,'4218954')

insert into cidades values('Urussanga',24,'4219002')

insert into cidades values('Vargeão',24,'4219101')

insert into cidades values('Vargem',24,'4219150')

insert into cidades values('Vargem Bonita',24,'4219176')

insert into cidades values('Vidal Ramos',24,'4219200')

insert into cidades values('Videira',24,'4219309')

insert into cidades values('Vitor Meireles',24,'4219358')

insert into cidades values('Witmarsum',24,'4219408')

insert into cidades values('Xanxerê',24,'4219507')

insert into cidades values('Xavantina',24,'4219606')

insert into cidades values('Xaxim',24,'4219705')

insert into cidades values('Zortéa',24,'4219853')

insert into cidades values('Adamantina',26,'3500105')

insert into cidades values('Adolfo',26,'3500204')

insert into cidades values('Aguaí',26,'3500303')

insert into cidades values('Águas da Prata',26,'3500402')

insert into cidades values('Águas de Lindóia',26,'3500501')

insert into cidades values('Águas de Santa Bárbara',26,'3500550')

insert into cidades values('Águas de São Pedro',26,'3500600')

insert into cidades values('Agudos',26,'3500709')

insert into cidades values('Alambari',26,'3500758')

insert into cidades values('Alfredo Marcondes',26,'3500808')

insert into cidades values('Altair',26,'3500907')

insert into cidades values('Altinópolis',26,'3501004')

insert into cidades values('Alto Alegre',26,'3501103')

insert into cidades values('Alumínio',26,'3501152')

insert into cidades values('Álvares Florence',26,'3501202')

insert into cidades values('Álvares Machado',26,'3501301')

insert into cidades values('Álvaro de Carvalho',26,'3501400')

insert into cidades values('Alvinlândia',26,'3501509')

insert into cidades values('Americana',26,'3501608')

insert into cidades values('Américo Brasiliense',26,'3501707')

insert into cidades values('Américo de Campos',26,'3501806')

insert into cidades values('Amparo',26,'3501905')

insert into cidades values('Analândia',26,'3502002')

insert into cidades values('Andradina',26,'3502101')

insert into cidades values('Angatuba',26,'3502200')

insert into cidades values('Anhembi',26,'3502309')

insert into cidades values('Anhumas',26,'3502408')

insert into cidades values('Aparecida',26,'3502507')

insert into cidades values('Aparecida dOeste',26,'3502606')

insert into cidades values('Apiaí',26,'3502705')

insert into cidades values('Araçariguama',26,'3502754')

insert into cidades values('Araçatuba',26,'3502804')

insert into cidades values('Araçoiaba da Serra',26,'3502903')

insert into cidades values('Aramina',26,'3503000')

insert into cidades values('Arandu',26,'3503109')

insert into cidades values('Arapeí',26,'3503158')

insert into cidades values('Araraquara',26,'3503208')

insert into cidades values('Araras',26,'3503307')

insert into cidades values('Arco-Íris',26,'3503356')

insert into cidades values('Arealva',26,'3503406')

insert into cidades values('Areias',26,'3503505')

insert into cidades values('Areiópolis',26,'3503604')

insert into cidades values('Ariranha',26,'3503703')

insert into cidades values('Artur Nogueira',26,'3503802')

insert into cidades values('Arujá',26,'3503901')

insert into cidades values('Aspásia',26,'3503950')

insert into cidades values('Assis',26,'3504008')

insert into cidades values('Atibaia',26,'3504107')

insert into cidades values('Auriflama',26,'3504206')

insert into cidades values('Avaí',26,'3504305')

insert into cidades values('Avanhandava',26,'3504404')

insert into cidades values('Avaré',26,'3504503')

insert into cidades values('Bady Bassitt',26,'3504602')

insert into cidades values('Balbinos',26,'3504701')

insert into cidades values('Bálsamo',26,'3504800')

insert into cidades values('Bananal',26,'3504909')

insert into cidades values('Barão de Antonina',26,'3505005')

insert into cidades values('Barbosa',26,'3505104')

insert into cidades values('Bariri',26,'3505203')

insert into cidades values('Barra Bonita',26,'3505302')

insert into cidades values('Barra do Chapéu',26,'3505351')

insert into cidades values('Barra do Turvo',26,'3505401')

insert into cidades values('Barretos',26,'3505500')

insert into cidades values('Barrinha',26,'3505609')

insert into cidades values('Barueri',26,'3505708')

insert into cidades values('Bastos',26,'3505807')

insert into cidades values('Batatais',26,'3505906')

insert into cidades values('Bauru',26,'3506003')

insert into cidades values('Bebedouro',26,'3506102')

insert into cidades values('Bento de Abreu',26,'3506201')

insert into cidades values('Bernardino de Campos',26,'3506300')

insert into cidades values('Bertioga',26,'3506359')

insert into cidades values('Bilac',26,'3506409')

insert into cidades values('Birigui',26,'3506508')

insert into cidades values('Biritiba-Mirim',26,'3506607')

insert into cidades values('Boa Esperança do Sul',26,'3506706')

insert into cidades values('Bocaina',26,'3506805')

insert into cidades values('Bofete',26,'3506904')

insert into cidades values('Boituva',26,'3507001')

insert into cidades values('Bom Jesus dos Perdões',26,'3507100')

insert into cidades values('Bom Sucesso de Itararé',26,'3507159')

insert into cidades values('Borá',26,'3507209')

insert into cidades values('Boracéia',26,'3507308')

insert into cidades values('Borborema',26,'3507407')

insert into cidades values('Borebi',26,'3507456')

insert into cidades values('Botucatu',26,'3507506')

insert into cidades values('Bragança Paulista',26,'3507605')

insert into cidades values('Braúna',26,'3507704')

insert into cidades values('Brejo Alegre',26,'3507753')

insert into cidades values('Brodowski',26,'3507803')

insert into cidades values('Brotas',26,'3507902')

insert into cidades values('Buri',26,'3508009')

insert into cidades values('Buritama',26,'3508108')

insert into cidades values('Buritizal',26,'3508207')

insert into cidades values('Cabrália Paulista',26,'3508306')

insert into cidades values('Cabreúva',26,'3508405')

insert into cidades values('Caçapava',26,'3508504')

insert into cidades values('Cachoeira Paulista',26,'3508603')

insert into cidades values('Caconde',26,'3508702')

insert into cidades values('Cafelândia',26,'3508801')

insert into cidades values('Caiabu',26,'3508900')

insert into cidades values('Caieiras',26,'3509007')

insert into cidades values('Caiuá',26,'3509106')

insert into cidades values('Cajamar',26,'3509205')

insert into cidades values('Cajati',26,'3509254')

insert into cidades values('Cajobi',26,'3509304')

insert into cidades values('Cajuru',26,'3509403')

insert into cidades values('Campina do Monte Alegre',26,'3509452')

insert into cidades values('Campinas',26,'3509502')

insert into cidades values('Campo Limpo Paulista',26,'3509601')

insert into cidades values('Campos do Jordão',26,'3509700')

insert into cidades values('Campos Novos Paulista',26,'3509809')

insert into cidades values('Cananéia',26,'3509908')

insert into cidades values('Canas',26,'3509957')

insert into cidades values('Cândido Mota',26,'3510005')

insert into cidades values('Cândido Rodrigues',26,'3510104')

insert into cidades values('Canitar',26,'3510153')

insert into cidades values('Capão Bonito',26,'3510203')

insert into cidades values('Capela do Alto',26,'3510302')

insert into cidades values('Capivari',26,'3510401')

insert into cidades values('Caraguatatuba',26,'3510500')

insert into cidades values('Carapicuíba',26,'3510609')

insert into cidades values('Cardoso',26,'3510708')

insert into cidades values('Casa Branca',26,'3510807')

insert into cidades values('Cássia dos Coqueiros',26,'3510906')

insert into cidades values('Castilho',26,'3511003')

insert into cidades values('Catanduva',26,'3511102')

insert into cidades values('Catiguá',26,'3511201')

insert into cidades values('Cedral',26,'3511300')

insert into cidades values('Cerqueira César',26,'3511409')

insert into cidades values('Cerquilho',26,'3511508')

insert into cidades values('Cesário Lange',26,'3511607')

insert into cidades values('Charqueada',26,'3511706')

insert into cidades values('Chavantes',26,'3557204')

insert into cidades values('Clementina',26,'3511904')

insert into cidades values('Colina',26,'3512001')

insert into cidades values('Colômbia',26,'3512100')

insert into cidades values('Conchal',26,'3512209')

insert into cidades values('Conchas',26,'3512308')

insert into cidades values('Cordeirópolis',26,'3512407')

insert into cidades values('Coroados',26,'3512506')

insert into cidades values('Coronel Macedo',26,'3512605')

insert into cidades values('Corumbataí',26,'3512704')

insert into cidades values('Cosmópolis',26,'3512803')

insert into cidades values('Cosmorama',26,'3512902')

insert into cidades values('Cotia',26,'3513009')

insert into cidades values('Cravinhos',26,'3513108')

insert into cidades values('Cristais Paulista',26,'3513207')

insert into cidades values('Cruzália',26,'3513306')

insert into cidades values('Cruzeiro',26,'3513405')

insert into cidades values('Cubatão',26,'3513504')

insert into cidades values('Cunha',26,'3513603')

insert into cidades values('Descalvado',26,'3513702')

insert into cidades values('Diadema',26,'3513801')

insert into cidades values('Dirce Reis',26,'3513850')

insert into cidades values('Divinolândia',26,'3513900')

insert into cidades values('Dobrada',26,'3514007')

insert into cidades values('Dois Córregos',26,'3514106')

insert into cidades values('Dolcinópolis',26,'3514205')

insert into cidades values('Dourado',26,'3514304')

insert into cidades values('Dracena',26,'3514403')

insert into cidades values('Duartina',26,'3514502')

insert into cidades values('Dumont',26,'3514601')

insert into cidades values('Echaporã',26,'3514700')

insert into cidades values('Eldorado',26,'3514809')

insert into cidades values('Elias Fausto',26,'3514908')

insert into cidades values('Elisiário',26,'3514924')

insert into cidades values('Embaúba',26,'3514957')

insert into cidades values('Embu',26,'3515004')

insert into cidades values('Embu-Guaçu',26,'3515103')

insert into cidades values('Emilianópolis',26,'3515129')

insert into cidades values('Engenheiro Coelho',26,'3515152')

insert into cidades values('Espírito Santo do Pinhal',26,'3515186')

insert into cidades values('Espírito Santo do Turvo',26,'3515194')

insert into cidades values('Estiva Gerbi',26,'3557303')

insert into cidades values('Estrela dOeste',26,'3515202')

insert into cidades values('Estrela do Norte',26,'3515301')

insert into cidades values('Euclides da Cunha Paulista',26,'3515350')

insert into cidades values('Fartura',26,'3515400')

insert into cidades values('Fernando Prestes',26,'3515608')

insert into cidades values('Fernandópolis',26,'3515509')

insert into cidades values('Fernão',26,'3515657')

insert into cidades values('Ferraz de Vasconcelos',26,'3515707')

insert into cidades values('Flora Rica',26,'3515806')

insert into cidades values('Floreal',26,'3515905')

insert into cidades values('Flórida Paulista',26,'3516002')

insert into cidades values('Florínia',26,'3516101')

insert into cidades values('Franca',26,'3516200')

insert into cidades values('Francisco Morato',26,'3516309')

insert into cidades values('Franco da Rocha',26,'3516408')

insert into cidades values('Gabriel Monteiro',26,'3516507')

insert into cidades values('Gália',26,'3516606')

insert into cidades values('Garça',26,'3516705')

insert into cidades values('Gastão Vidigal',26,'3516804')

insert into cidades values('Gavião Peixoto',26,'3516853')

insert into cidades values('General Salgado',26,'3516903')

insert into cidades values('Getulina',26,'3517000')

insert into cidades values('Glicério',26,'3517109')

insert into cidades values('Guaiçara',26,'3517208')

insert into cidades values('Guaimbê',26,'3517307')

insert into cidades values('Guaíra',26,'3517406')

insert into cidades values('Guapiaçu',26,'3517505')

insert into cidades values('Guapiara',26,'3517604')

insert into cidades values('Guará',26,'3517703')

insert into cidades values('Guaraçaí',26,'3517802')

insert into cidades values('Guaraci',26,'3517901')

insert into cidades values('Guarani dOeste',26,'3518008')

insert into cidades values('Guarantã',26,'3518107')

insert into cidades values('Guararapes',26,'3518206')

insert into cidades values('Guararema',26,'3518305')

insert into cidades values('Guaratinguetá',26,'3518404')

insert into cidades values('Guareí',26,'3518503')

insert into cidades values('Guariba',26,'3518602')

insert into cidades values('Guarujá',26,'3518701')

insert into cidades values('Guarulhos',26,'3518800')

insert into cidades values('Guatapará',26,'3518859')

insert into cidades values('Guzolândia',26,'3518909')

insert into cidades values('Herculândia',26,'3519006')

insert into cidades values('Holambra',26,'3519055')

insert into cidades values('Hortolândia',26,'3519071')

insert into cidades values('Iacanga',26,'3519105')

insert into cidades values('Iacri',26,'3519204')

insert into cidades values('Iaras',26,'3519253')

insert into cidades values('Ibaté',26,'3519303')

insert into cidades values('Ibirá',26,'3519402')

insert into cidades values('Ibirarema',26,'3519501')

insert into cidades values('Ibitinga',26,'3519600')

insert into cidades values('Ibiúna',26,'3519709')

insert into cidades values('Icém',26,'3519808')

insert into cidades values('Iepê',26,'3519907')

insert into cidades values('Igaraçu do Tietê',26,'3520004')

insert into cidades values('Igarapava',26,'3520103')

insert into cidades values('Igaratá',26,'3520202')

insert into cidades values('Iguape',26,'3520301')

insert into cidades values('Ilha Comprida',26,'3520426')

insert into cidades values('Ilha Solteira',26,'3520442')

insert into cidades values('Ilhabela',26,'3520400')

insert into cidades values('Indaiatuba',26,'3520509')

insert into cidades values('Indiana',26,'3520608')

insert into cidades values('Indiaporã',26,'3520707')

insert into cidades values('Inúbia Paulista',26,'3520806')

insert into cidades values('Ipaussu',26,'3520905')

insert into cidades values('Iperó',26,'3521002')

insert into cidades values('Ipeúna',26,'3521101')

insert into cidades values('Ipiguá',26,'3521150')

insert into cidades values('Iporanga',26,'3521200')

insert into cidades values('Ipuã',26,'3521309')

insert into cidades values('Iracemápolis',26,'3521408')

insert into cidades values('Irapuã',26,'3521507')

insert into cidades values('Irapuru',26,'3521606')

insert into cidades values('Itaberá',26,'3521705')

insert into cidades values('Itaí',26,'3521804')

insert into cidades values('Itajobi',26,'3521903')

insert into cidades values('Itaju',26,'3522000')

insert into cidades values('Itanhaém',26,'3522109')

insert into cidades values('Itaóca',26,'3522158')

insert into cidades values('Itapecerica da Serra',26,'3522208')

insert into cidades values('Itapetininga',26,'3522307')

insert into cidades values('Itapeva',26,'3522406')

insert into cidades values('Itapevi',26,'3522505')

insert into cidades values('Itapira',26,'3522604')

insert into cidades values('Itapirapuã Paulista',26,'3522653')

insert into cidades values('Itápolis',26,'3522703')

insert into cidades values('Itaporanga',26,'3522802')

insert into cidades values('Itapuí',26,'3522901')

insert into cidades values('Itapura',26,'3523008')

insert into cidades values('Itaquaquecetuba',26,'3523107')

insert into cidades values('Itararé',26,'3523206')

insert into cidades values('Itariri',26,'3523305')

insert into cidades values('Itatiba',26,'3523404')

insert into cidades values('Itatinga',26,'3523503')

insert into cidades values('Itirapina',26,'3523602')

insert into cidades values('Itirapuã',26,'3523701')

insert into cidades values('Itobi',26,'3523800')

insert into cidades values('Itu',26,'3523909')

insert into cidades values('Itupeva',26,'3524006')

insert into cidades values('Ituverava',26,'3524105')

insert into cidades values('Jaborandi',26,'3524204')

insert into cidades values('Jaboticabal',26,'3524303')

insert into cidades values('Jacareí',26,'3524402')

insert into cidades values('Jaci',26,'3524501')

insert into cidades values('Jacupiranga',26,'3524600')

insert into cidades values('Jaguariúna',26,'3524709')

insert into cidades values('Jales',26,'3524808')

insert into cidades values('Jambeiro',26,'3524907')

insert into cidades values('Jandira',26,'3525003')

insert into cidades values('Jardinópolis',26,'3525102')

insert into cidades values('Jarinu',26,'3525201')

insert into cidades values('Jaú',26,'3525300')

insert into cidades values('Jeriquara',26,'3525409')

insert into cidades values('Joanópolis',26,'3525508')

insert into cidades values('João Ramalho',26,'3525607')

insert into cidades values('José Bonifácio',26,'3525706')

insert into cidades values('Júlio Mesquita',26,'3525805')

insert into cidades values('Jumirim',26,'3525854')

insert into cidades values('Jundiaí',26,'3525904')

insert into cidades values('Junqueirópolis',26,'3526001')

insert into cidades values('Juquiá',26,'3526100')

insert into cidades values('Juquitiba',26,'3526209')

insert into cidades values('Lagoinha',26,'3526308')

insert into cidades values('Laranjal Paulista',26,'3526407')

insert into cidades values('Lavínia',26,'3526506')

insert into cidades values('Lavrinhas',26,'3526605')

insert into cidades values('Leme',26,'3526704')

insert into cidades values('Lençóis Paulista',26,'3526803')

insert into cidades values('Limeira',26,'3526902')

insert into cidades values('Lindóia',26,'3527009')

insert into cidades values('Lins',26,'3527108')

insert into cidades values('Lorena',26,'3527207')

insert into cidades values('Lourdes',26,'3527256')

insert into cidades values('Louveira',26,'3527306')

insert into cidades values('Lucélia',26,'3527405')

insert into cidades values('Lucianópolis',26,'3527504')

insert into cidades values('Luís Antônio',26,'3527603')

insert into cidades values('Luiziânia',26,'3527702')

insert into cidades values('Lupércio',26,'3527801')

insert into cidades values('Lutécia',26,'3527900')

insert into cidades values('Macatuba',26,'3528007')

insert into cidades values('Macaubal',26,'3528106')

insert into cidades values('Macedônia',26,'3528205')

insert into cidades values('Magda',26,'3528304')

insert into cidades values('Mairinque',26,'3528403')

insert into cidades values('Mairiporã',26,'3528502')

insert into cidades values('Manduri',26,'3528601')

insert into cidades values('Marabá Paulista',26,'3528700')

insert into cidades values('Maracaí',26,'3528809')

insert into cidades values('Marapoama',26,'3528858')

insert into cidades values('Mariápolis',26,'3528908')

insert into cidades values('Marília',26,'3529005')

insert into cidades values('Marinópolis',26,'3529104')

insert into cidades values('Martinópolis',26,'3529203')

insert into cidades values('Matão',26,'3529302')

insert into cidades values('Mauá',26,'3529401')

insert into cidades values('Mendonça',26,'3529500')

insert into cidades values('Meridiano',26,'3529609')

insert into cidades values('Mesópolis',26,'3529658')

insert into cidades values('Miguelópolis',26,'3529708')

insert into cidades values('Mineiros do Tietê',26,'3529807')

insert into cidades values('Mira Estrela',26,'3530003')

insert into cidades values('Miracatu',26,'3529906')

insert into cidades values('Mirandópolis',26,'3530102')

insert into cidades values('Mirante do Paranapanema',26,'3530201')

insert into cidades values('Mirassol',26,'3530300')

insert into cidades values('Mirassolândia',26,'3530409')

insert into cidades values('Mococa',26,'3530508')

insert into cidades values('Mogi das Cruzes',26,'3530607')

insert into cidades values('Mogi Guaçu',26,'3530706')

insert into cidades values('Mogi Mirim',26,'3530805')

insert into cidades values('Mombuca',26,'3530904')

insert into cidades values('Monções',26,'3531001')

insert into cidades values('Mongaguá',26,'3531100')

insert into cidades values('Monte Alegre do Sul',26,'3531209')

insert into cidades values('Monte Alto',26,'3531308')

insert into cidades values('Monte Aprazível',26,'3531407')

insert into cidades values('Monte Azul Paulista',26,'3531506')

insert into cidades values('Monte Castelo',26,'3531605')

insert into cidades values('Monte Mor',26,'3531803')

insert into cidades values('Monteiro Lobato',26,'3531704')

insert into cidades values('Morro Agudo',26,'3531902')

insert into cidades values('Morungaba',26,'3532009')

insert into cidades values('Motuca',26,'3532058')

insert into cidades values('Murutinga do Sul',26,'3532108')

insert into cidades values('Nantes',26,'3532157')

insert into cidades values('Narandiba',26,'3532207')

insert into cidades values('Natividade da Serra',26,'3532306')

insert into cidades values('Nazaré Paulista',26,'3532405')

insert into cidades values('Neves Paulista',26,'3532504')

insert into cidades values('Nhandeara',26,'3532603')

insert into cidades values('Nipoã',26,'3532702')

insert into cidades values('Nova Aliança',26,'3532801')

insert into cidades values('Nova Campina',26,'3532827')

insert into cidades values('Nova Canaã Paulista',26,'3532843')

insert into cidades values('Nova Castilho',26,'3532868')

insert into cidades values('Nova Europa',26,'3532900')

insert into cidades values('Nova Granada',26,'3533007')

insert into cidades values('Nova Guataporanga',26,'3533106')

insert into cidades values('Nova Independência',26,'3533205')

insert into cidades values('Nova Luzitânia',26,'3533304')

insert into cidades values('Nova Odessa',26,'3533403')

insert into cidades values('Novais',26,'3533254')

insert into cidades values('Novo Horizonte',26,'3533502')

insert into cidades values('Nuporanga',26,'3533601')

insert into cidades values('Ocauçu',26,'3533700')

insert into cidades values('Óleo',26,'3533809')

insert into cidades values('Olímpia',26,'3533908')

insert into cidades values('Onda Verde',26,'3534005')

insert into cidades values('Oriente',26,'3534104')

insert into cidades values('Orindiúva',26,'3534203')

insert into cidades values('Orlândia',26,'3534302')

insert into cidades values('Osasco',26,'3534401')

insert into cidades values('Oscar Bressane',26,'3534500')

insert into cidades values('Osvaldo Cruz',26,'3534609')

insert into cidades values('Ourinhos',26,'3534708')

insert into cidades values('Ouro Verde',26,'3534807')

insert into cidades values('Ouroeste',26,'3534757')

insert into cidades values('Pacaembu',26,'3534906')

insert into cidades values('Palestina',26,'3535002')

insert into cidades values('Palmares Paulista',26,'3535101')

insert into cidades values('Palmeira dOeste',26,'3535200')

insert into cidades values('Palmital',26,'3535309')

insert into cidades values('Panorama',26,'3535408')

insert into cidades values('Paraguaçu Paulista',26,'3535507')

insert into cidades values('Paraibuna',26,'3535606')

insert into cidades values('Paraíso',26,'3535705')

insert into cidades values('Paranapanema',26,'3535804')

insert into cidades values('Paranapuã',26,'3535903')

insert into cidades values('Parapuã',26,'3536000')

insert into cidades values('Pardinho',26,'3536109')

insert into cidades values('Pariquera-Açu',26,'3536208')

insert into cidades values('Parisi',26,'3536257')

insert into cidades values('Patrocínio Paulista',26,'3536307')

insert into cidades values('Paulicéia',26,'3536406')

insert into cidades values('Paulínia',26,'3536505')

insert into cidades values('Paulistânia',26,'3536570')

insert into cidades values('Paulo de Faria',26,'3536604')

insert into cidades values('Pederneiras',26,'3536703')

insert into cidades values('Pedra Bela',26,'3536802')

insert into cidades values('Pedranópolis',26,'3536901')

insert into cidades values('Pedregulho',26,'3537008')

insert into cidades values('Pedreira',26,'3537107')

insert into cidades values('Pedrinhas Paulista',26,'3537156')

insert into cidades values('Pedro de Toledo',26,'3537206')

insert into cidades values('Penápolis',26,'3537305')

insert into cidades values('Pereira Barreto',26,'3537404')

insert into cidades values('Pereiras',26,'3537503')

insert into cidades values('Peruíbe',26,'3537602')

insert into cidades values('Piacatu',26,'3537701')

insert into cidades values('Piedade',26,'3537800')

insert into cidades values('Pilar do Sul',26,'3537909')

insert into cidades values('Pindamonhangaba',26,'3538006')

insert into cidades values('Pindorama',26,'3538105')

insert into cidades values('Pinhalzinho',26,'3538204')

insert into cidades values('Piquerobi',26,'3538303')

insert into cidades values('Piquete',26,'3538501')

insert into cidades values('Piracaia',26,'3538600')

insert into cidades values('Piracicaba',26,'3538709')

insert into cidades values('Piraju',26,'3538808')

insert into cidades values('Pirajuí',26,'3538907')

insert into cidades values('Pirangi',26,'3539004')

insert into cidades values('Pirapora do Bom Jesus',26,'3539103')

insert into cidades values('Pirapozinho',26,'3539202')

insert into cidades values('Pirassununga',26,'3539301')

insert into cidades values('Piratininga',26,'3539400')

insert into cidades values('Pitangueiras',26,'3539509')

insert into cidades values('Planalto',26,'3539608')

insert into cidades values('Platina',26,'3539707')

insert into cidades values('Poá',26,'3539806')

insert into cidades values('Poloni',26,'3539905')

insert into cidades values('Pompéia',26,'3540002')

insert into cidades values('Pongaí',26,'3540101')

insert into cidades values('Pontal',26,'3540200')

insert into cidades values('Pontalinda',26,'3540259')

insert into cidades values('Pontes Gestal',26,'3540309')

insert into cidades values('Populina',26,'3540408')

insert into cidades values('Porangaba',26,'3540507')

insert into cidades values('Porto Feliz',26,'3540606')

insert into cidades values('Porto Ferreira',26,'3540705')

insert into cidades values('Potim',26,'3540754')

insert into cidades values('Potirendaba',26,'3540804')

insert into cidades values('Pracinha',26,'3540853')

insert into cidades values('Pradópolis',26,'3540903')

insert into cidades values('Praia Grande',26,'3541000')

insert into cidades values('Pratânia',26,'3541059')

insert into cidades values('Presidente Alves',26,'3541109')

insert into cidades values('Presidente Bernardes',26,'3541208')

insert into cidades values('Presidente Epitácio',26,'3541307')

insert into cidades values('Presidente Prudente',26,'3541406')

insert into cidades values('Presidente Venceslau',26,'3541505')

insert into cidades values('Promissão',26,'3541604')

insert into cidades values('Quadra',26,'3541653')

insert into cidades values('Quatá',26,'3541703')

insert into cidades values('Queiroz',26,'3541802')

insert into cidades values('Queluz',26,'3541901')

insert into cidades values('Quintana',26,'3542008')

insert into cidades values('Rafard',26,'3542107')

insert into cidades values('Rancharia',26,'3542206')

insert into cidades values('Redenção da Serra',26,'3542305')

insert into cidades values('Regente Feijó',26,'3542404')

insert into cidades values('Reginópolis',26,'3542503')

insert into cidades values('Registro',26,'3542602')

insert into cidades values('Restinga',26,'3542701')

insert into cidades values('Ribeira',26,'3542800')

insert into cidades values('Ribeirão Bonito',26,'3542909')

insert into cidades values('Ribeirão Branco',26,'3543006')

insert into cidades values('Ribeirão Corrente',26,'3543105')

insert into cidades values('Ribeirão do Sul',26,'3543204')

insert into cidades values('Ribeirão dos Índios',26,'3543238')

insert into cidades values('Ribeirão Grande',26,'3543253')

insert into cidades values('Ribeirão Pires',26,'3543303')

insert into cidades values('Ribeirão Preto',26,'3543402')

insert into cidades values('Rifaina',26,'3543600')

insert into cidades values('Rincão',26,'3543709')

insert into cidades values('Rinópolis',26,'3543808')

insert into cidades values('Rio Claro',26,'3543907')

insert into cidades values('Rio das Pedras',26,'3544004')

insert into cidades values('Rio Grande da Serra',26,'3544103')

insert into cidades values('Riolândia',26,'3544202')

insert into cidades values('Riversul',26,'3543501')

insert into cidades values('Rosana',26,'3544251')

insert into cidades values('Roseira',26,'3544301')

insert into cidades values('Rubiácea',26,'3544400')

insert into cidades values('Rubinéia',26,'3544509')

insert into cidades values('Sabino',26,'3544608')

insert into cidades values('Sagres',26,'3544707')

insert into cidades values('Sales',26,'3544806')

insert into cidades values('Sales Oliveira',26,'3544905')

insert into cidades values('Salesópolis',26,'3545001')

insert into cidades values('Salmourão',26,'3545100')

insert into cidades values('Saltinho',26,'3545159')

insert into cidades values('Salto',26,'3545209')

insert into cidades values('Salto de Pirapora',26,'3545308')

insert into cidades values('Salto Grande',26,'3545407')

insert into cidades values('Sandovalina',26,'3545506')

insert into cidades values('Santa Adélia',26,'3545605')

insert into cidades values('Santa Albertina',26,'3545704')

insert into cidades values('Santa Bárbara dOeste',26,'3545803')

insert into cidades values('Santa Branca',26,'3546009')

insert into cidades values('Santa Clara dOeste',26,'3546108')

insert into cidades values('Santa Cruz da Conceição',26,'3546207')

insert into cidades values('Santa Cruz da Esperança',26,'3546256')

insert into cidades values('Santa Cruz das Palmeiras',26,'3546306')

insert into cidades values('Santa Cruz do Rio Pardo',26,'3546405')

insert into cidades values('Santa Ernestina',26,'3546504')

insert into cidades values('Santa Fé do Sul',26,'3546603')

insert into cidades values('Santa Gertrudes',26,'3546702')

insert into cidades values('Santa Isabel',26,'3546801')

insert into cidades values('Santa Lúcia',26,'3546900')

insert into cidades values('Santa Maria da Serra',26,'3547007')

insert into cidades values('Santa Mercedes',26,'3547106')

insert into cidades values('Santa Rita dOeste',26,'3547403')

insert into cidades values('Santa Rita do Passa Quatro',26,'3547502')

insert into cidades values('Santa Rosa de Viterbo',26,'3547601')

insert into cidades values('Santa Salete',26,'3547650')

insert into cidades values('Santana da Ponte Pensa',26,'3547205')

insert into cidades values('Santana de Parnaíba',26,'3547304')

insert into cidades values('Santo Anastácio',26,'3547700')

insert into cidades values('Santo André',26,'3547809')

insert into cidades values('Santo Antônio da Alegria',26,'3547908')

insert into cidades values('Santo Antônio de Posse',26,'3548005')

insert into cidades values('Santo Antônio do Aracanguá',26,'3548054')

insert into cidades values('Santo Antônio do Jardim',26,'3548104')

insert into cidades values('Santo Antônio do Pinhal',26,'3548203')

insert into cidades values('Santo Expedito',26,'3548302')

insert into cidades values('Santópolis do Aguapeí',26,'3548401')

insert into cidades values('Santos',26,'3548500')

insert into cidades values('São Bento do Sapucaí',26,'3548609')

insert into cidades values('São Bernardo do Campo',26,'3548708')

insert into cidades values('São Caetano do Sul',26,'3548807')

insert into cidades values('São Carlos',26,'3548906')

insert into cidades values('São Francisco',26,'3549003')

insert into cidades values('São João da Boa Vista',26,'3549102')

insert into cidades values('São João das Duas Pontes',26,'3549201')

insert into cidades values('São João de Iracema',26,'3549250')

insert into cidades values('São João do Pau dAlho',26,'3549300')

insert into cidades values('São Joaquim da Barra',26,'3549409')

insert into cidades values('São José da Bela Vista',26,'3549508')

insert into cidades values('São José do Barreiro',26,'3549607')

insert into cidades values('São José do Rio Pardo',26,'3549706')

insert into cidades values('São José do Rio Preto',26,'3549805')

insert into cidades values('São José dos Campos',26,'3549904')

insert into cidades values('São Lourenço da Serra',26,'3549953')

insert into cidades values('São Luís do Paraitinga',26,'3550001')

insert into cidades values('São Manuel',26,'3550100')

insert into cidades values('São Miguel Arcanjo',26,'3550209')

insert into cidades values('São Paulo',26,'3550308')

insert into cidades values('São Pedro',26,'3550407')

insert into cidades values('São Pedro do Turvo',26,'3550506')

insert into cidades values('São Roque',26,'3550605')

insert into cidades values('São Sebastião',26,'3550704')

insert into cidades values('São Sebastião da Grama',26,'3550803')

insert into cidades values('São Simão',26,'3550902')

insert into cidades values('São Vicente',26,'3551009')

insert into cidades values('Sarapuí',26,'3551108')

insert into cidades values('Sarutaiá',26,'3551207')

insert into cidades values('Sebastianópolis do Sul',26,'3551306')

insert into cidades values('Serra Azul',26,'3551405')

insert into cidades values('Serra Negra',26,'3551603')

insert into cidades values('Serrana',26,'3551504')

insert into cidades values('Sertãozinho',26,'3551702')

insert into cidades values('Sete Barras',26,'3551801')

insert into cidades values('Severínia',26,'3551900')

insert into cidades values('Silveiras',26,'3552007')

insert into cidades values('Socorro',26,'3552106')

insert into cidades values('Sorocaba',26,'3552205')

insert into cidades values('Sud Mennucci',26,'3552304')

insert into cidades values('Sumaré',26,'3552403')

insert into cidades values('Suzanápolis',26,'3552551')

insert into cidades values('Suzano',26,'3552502')

insert into cidades values('Tabapuã',26,'3552601')

insert into cidades values('Tabatinga',26,'3552700')

insert into cidades values('Taboão da Serra',26,'3552809')

insert into cidades values('Taciba',26,'3552908')

insert into cidades values('Taguaí',26,'3553005')

insert into cidades values('Taiaçu',26,'3553104')

insert into cidades values('Taiúva',26,'3553203')

insert into cidades values('Tambaú',26,'3553302')

insert into cidades values('Tanabi',26,'3553401')

insert into cidades values('Tapiraí',26,'3553500')

insert into cidades values('Tapiratiba',26,'3553609')

insert into cidades values('Taquaral',26,'3553658')

insert into cidades values('Taquaritinga',26,'3553708')

insert into cidades values('Taquarituba',26,'3553807')

insert into cidades values('Taquarivaí',26,'3553856')

insert into cidades values('Tarabai',26,'3553906')

insert into cidades values('Tarumã',26,'3553955')

insert into cidades values('Tatuí',26,'3554003')

insert into cidades values('Taubaté',26,'3554102')

insert into cidades values('Tejupá',26,'3554201')

insert into cidades values('Teodoro Sampaio',26,'3554300')

insert into cidades values('Terra Roxa',26,'3554409')

insert into cidades values('Tietê',26,'3554508')

insert into cidades values('Timburi',26,'3554607')

insert into cidades values('Torre de Pedra',26,'3554656')

insert into cidades values('Torrinha',26,'3554706')

insert into cidades values('Trabiju',26,'3554755')

insert into cidades values('Tremembé',26,'3554805')

insert into cidades values('Três Fronteiras',26,'3554904')

insert into cidades values('Tuiuti',26,'3554953')

insert into cidades values('Tupã',26,'3555000')

insert into cidades values('Tupi Paulista',26,'3555109')

insert into cidades values('Turiúba',26,'3555208')

insert into cidades values('Turmalina',26,'3555307')

insert into cidades values('Ubarana',26,'3555356')

insert into cidades values('Ubatuba',26,'3555406')

insert into cidades values('Ubirajara',26,'3555505')

insert into cidades values('Uchoa',26,'3555604')

insert into cidades values('União Paulista',26,'3555703')

insert into cidades values('Urânia',26,'3555802')

insert into cidades values('Uru',26,'3555901')

insert into cidades values('Urupês',26,'3556008')

insert into cidades values('Valentim Gentil',26,'3556107')

insert into cidades values('Valinhos',26,'3556206')

insert into cidades values('Valparaíso',26,'3556305')

insert into cidades values('Vargem',26,'3556354')

insert into cidades values('Vargem Grande do Sul',26,'3556404')

insert into cidades values('Vargem Grande Paulista',26,'3556453')

insert into cidades values('Várzea Paulista',26,'3556503')

insert into cidades values('Vera Cruz',26,'3556602')

insert into cidades values('Vinhedo',26,'3556701')

insert into cidades values('Viradouro',26,'3556800')

insert into cidades values('Vista Alegre do Alto',26,'3556909')

insert into cidades values('Vitória Brasil',26,'3556958')

insert into cidades values('Votorantim',26,'3557006')

insert into cidades values('Votuporanga',26,'3557105')

insert into cidades values('Zacarias',26,'3557154')

insert into cidades values('Amparo de São Francisco',25,'2800100')

insert into cidades values('Aquidabã',25,'2800209')

insert into cidades values('Aracaju',25,'2800308')

insert into cidades values('Arauá',25,'2800407')

insert into cidades values('Areia Branca',25,'2800506')

insert into cidades values('Barra dos Coqueiros',25,'2800605')

insert into cidades values('Boquim',25,'2800670')

insert into cidades values('Brejo Grande',25,'2800704')

insert into cidades values('Campo do Brito',25,'2801009')

insert into cidades values('Canhoba',25,'2801108')

insert into cidades values('Canindé de São Francisco',25,'2801207')

insert into cidades values('Capela',25,'2801306')

insert into cidades values('Carira',25,'2801405')

insert into cidades values('Carmópolis',25,'2801504')

insert into cidades values('Cedro de São João',25,'2801603')

insert into cidades values('Cristinápolis',25,'2801702')

insert into cidades values('Cumbe',25,'2801900')

insert into cidades values('Divina Pastora',25,'2802007')

insert into cidades values('Estância',25,'2802106')

insert into cidades values('Feira Nova',25,'2802205')

insert into cidades values('Frei Paulo',25,'2802304')

insert into cidades values('Gararu',25,'2802403')

insert into cidades values('General Maynard',25,'2802502')

insert into cidades values('Gracho Cardoso',25,'2802601')

insert into cidades values('Ilha das Flores',25,'2802700')

insert into cidades values('Indiaroba',25,'2802809')

insert into cidades values('Itabaiana',25,'2802908')

insert into cidades values('Itabaianinha',25,'2803005')

insert into cidades values('Itabi',25,'2803104')

insert into cidades values('Itaporanga dAjuda',25,'2803203')

insert into cidades values('Japaratuba',25,'2803302')

insert into cidades values('Japoatã',25,'2803401')

insert into cidades values('Lagarto',25,'2803500')

insert into cidades values('Laranjeiras',25,'2803609')

insert into cidades values('Macambira',25,'2803708')

insert into cidades values('Malhada dos Bois',25,'2803807')

insert into cidades values('Malhador',25,'2803906')

insert into cidades values('Maruim',25,'2804003')

insert into cidades values('Moita Bonita',25,'2804102')

insert into cidades values('Monte Alegre de Sergipe',25,'2804201')

insert into cidades values('Muribeca',25,'2804300')

insert into cidades values('Neópolis',25,'2804409')

insert into cidades values('Nossa Senhora Aparecida',25,'2804458')

insert into cidades values('Nossa Senhora da Glória',25,'2804508')

insert into cidades values('Nossa Senhora das Dores',25,'2804607')

insert into cidades values('Nossa Senhora de Lourdes',25,'2804706')

insert into cidades values('Nossa Senhora do Socorro',25,'2804805')

insert into cidades values('Pacatuba',25,'2804904')

insert into cidades values('Pedra Mole',25,'2805000')

insert into cidades values('Pedrinhas',25,'2805109')

insert into cidades values('Pinhão',25,'2805208')

insert into cidades values('Pirambu',25,'2805307')

insert into cidades values('Poço Redondo',25,'2805406')

insert into cidades values('Poço Verde',25,'2805505')

insert into cidades values('Porto da Folha',25,'2805604')

insert into cidades values('Propriá',25,'2805703')

insert into cidades values('Riachão do Dantas',25,'2805802')

insert into cidades values('Riachuelo',25,'2805901')

insert into cidades values('Ribeirópolis',25,'2806008')

insert into cidades values('Rosário do Catete',25,'2806107')

insert into cidades values('Salgado',25,'2806206')

insert into cidades values('Santa Luzia do Itanhy',25,'2806305')

insert into cidades values('Santa Rosa de Lima',25,'2806503')

insert into cidades values('Santana do São Francisco',25,'2806404')

insert into cidades values('Santo Amaro das Brotas',25,'2806602')

insert into cidades values('São Cristóvão',25,'2806701')

insert into cidades values('São Domingos',25,'2806800')

insert into cidades values('São Francisco',25,'2806909')

insert into cidades values('São Miguel do Aleixo',25,'2807006')

insert into cidades values('Simão Dias',25,'2807105')

insert into cidades values('Siriri',25,'2807204')

insert into cidades values('Telha',25,'2807303')

insert into cidades values('Tobias Barreto',25,'2807402')

insert into cidades values('Tomar do Geru',25,'2807501')

insert into cidades values('Umbaúba',25,'2807600')

insert into cidades values('Abreulândia',27,'1700251')

insert into cidades values('Aguiarnópolis',27,'1700301')

insert into cidades values('Aliança do Tocantins',27,'1700350')

insert into cidades values('Almas',27,'1700400')

insert into cidades values('Alvorada',27,'1700707')

insert into cidades values('Ananás',27,'1701002')

insert into cidades values('Angico',27,'1701051')

insert into cidades values('Aparecida do Rio Negro',27,'1701101')

insert into cidades values('Aragominas',27,'1701309')

insert into cidades values('Araguacema',27,'1701903')

insert into cidades values('Araguaçu',27,'1702000')

insert into cidades values('Araguaína',27,'1702109')

insert into cidades values('Araguanã',27,'1702158')

insert into cidades values('Araguatins',27,'1702208')

insert into cidades values('Arapoema',27,'1702307')

insert into cidades values('Arraias',27,'1702406')

insert into cidades values('Augustinópolis',27,'1702554')

insert into cidades values('Aurora do Tocantins',27,'1702703')

insert into cidades values('Axixá do Tocantins',27,'1702901')

insert into cidades values('Babaçulândia',27,'1703008')

insert into cidades values('Bandeirantes do Tocantins',27,'1703057')

insert into cidades values('Barra do Ouro',27,'1703073')

insert into cidades values('Barrolândia',27,'1703107')

insert into cidades values('Bernardo Sayão',27,'1703206')

insert into cidades values('Bom Jesus do Tocantins',27,'1703305')

insert into cidades values('Brasilândia do Tocantins',27,'1703602')

insert into cidades values('Brejinho de Nazaré',27,'1703701')

insert into cidades values('Buriti do Tocantins',27,'1703800')

insert into cidades values('Cachoeirinha',27,'1703826')

insert into cidades values('Campos Lindos',27,'1703842')

insert into cidades values('Cariri do Tocantins',27,'1703867')

insert into cidades values('Carmolândia',27,'1703883')

insert into cidades values('Carrasco Bonito',27,'1703891')

insert into cidades values('Caseara',27,'1703909')

insert into cidades values('Centenário',27,'1704105')

insert into cidades values('Chapada da Natividade',27,'1705102')

insert into cidades values('Chapada de Areia',27,'1704600')

insert into cidades values('Colinas do Tocantins',27,'1705508')

insert into cidades values('Colméia',27,'1716703')

insert into cidades values('Combinado',27,'1705557')

insert into cidades values('Conceição do Tocantins',27,'1705607')

insert into cidades values('Couto de Magalhães',27,'1706001')

insert into cidades values('Cristalândia',27,'1706100')

insert into cidades values('Crixás do Tocantins',27,'1706258')

insert into cidades values('Darcinópolis',27,'1706506')

insert into cidades values('Dianópolis',27,'1707009')

insert into cidades values('Divinópolis do Tocantins',27,'1707108')

insert into cidades values('Dois Irmãos do Tocantins',27,'1707207')

insert into cidades values('Dueré',27,'1707306')

insert into cidades values('Esperantina',27,'1707405')

insert into cidades values('Fátima',27,'1707553')

insert into cidades values('Figueirópolis',27,'1707652')

insert into cidades values('Filadélfia',27,'1707702')

insert into cidades values('Formoso do Araguaia',27,'1708205')

insert into cidades values('Fortaleza do Tabocão',27,'1708254')

insert into cidades values('Goianorte',27,'1708304')

insert into cidades values('Goiatins',27,'1709005')

insert into cidades values('Guaraí',27,'1709302')

insert into cidades values('Gurupi',27,'1709500')

insert into cidades values('Ipueiras',27,'1709807')

insert into cidades values('Itacajá',27,'1710508')

insert into cidades values('Itaguatins',27,'1710706')

insert into cidades values('Itapiratins',27,'1710904')

insert into cidades values('Itaporã do Tocantins',27,'1711100')

insert into cidades values('Jaú do Tocantins',27,'1711506')

insert into cidades values('Juarina',27,'1711803')

insert into cidades values('Lagoa da Confusão',27,'1711902')

insert into cidades values('Lagoa do Tocantins',27,'1711951')

insert into cidades values('Lajeado',27,'1712009')

insert into cidades values('Lavandeira',27,'1712157')

insert into cidades values('Lizarda',27,'1712405')

insert into cidades values('Luzinópolis',27,'1712454')

insert into cidades values('Marianópolis do Tocantins',27,'1712504')

insert into cidades values('Mateiros',27,'1712702')

insert into cidades values('Maurilândia do Tocantins',27,'1712801')

insert into cidades values('Miracema do Tocantins',27,'1713205')

insert into cidades values('Miranorte',27,'1713304')

insert into cidades values('Monte do Carmo',27,'1713601')

insert into cidades values('Monte Santo do Tocantins',27,'1713700')

insert into cidades values('Muricilândia',27,'1713957')

insert into cidades values('Natividade',27,'1714203')

insert into cidades values('Nazaré',27,'1714302')

insert into cidades values('Nova Olinda',27,'1714880')

insert into cidades values('Nova Rosalândia',27,'1715002')

insert into cidades values('Novo Acordo',27,'1715101')

insert into cidades values('Novo Alegre',27,'1715150')

insert into cidades values('Novo Jardim',27,'1715259')

insert into cidades values('Oliveira de Fátima',27,'1715507')

insert into cidades values('Palmas',27,'1721000')

insert into cidades values('Palmeirante',27,'1715705')

insert into cidades values('Palmeiras do Tocantins',27,'1713809')

insert into cidades values('Palmeirópolis',27,'1715754')

insert into cidades values('Paraíso do Tocantins',27,'1716109')

insert into cidades values('Paranã',27,'1716208')

insert into cidades values('Pau dArco',27,'1716307')

insert into cidades values('Pedro Afonso',27,'1716505')

insert into cidades values('Peixe',27,'1716604')

insert into cidades values('Pequizeiro',27,'1716653')

insert into cidades values('Pindorama do Tocantins',27,'1717008')

insert into cidades values('Piraquê',27,'1717206')

insert into cidades values('Pium',27,'1717503')

insert into cidades values('Ponte Alta do Bom Jesus',27,'1717800')

insert into cidades values('Ponte Alta do Tocantins',27,'1717909')

insert into cidades values('Porto Alegre do Tocantins',27,'1718006')

insert into cidades values('Porto Nacional',27,'1718204')

insert into cidades values('Praia Norte',27,'1718303')

insert into cidades values('Presidente Kennedy',27,'1718402')

insert into cidades values('Pugmil',27,'1718451')

insert into cidades values('Recursolândia',27,'1718501')

insert into cidades values('Riachinho',27,'1718550')

insert into cidades values('Rio da Conceição',27,'1718659')

insert into cidades values('Rio dos Bois',27,'1718709')

insert into cidades values('Rio Sono',27,'1718758')

insert into cidades values('Sampaio',27,'1718808')

insert into cidades values('Sandolândia',27,'1718840')

insert into cidades values('Santa Fé do Araguaia',27,'1718865')

insert into cidades values('Santa Maria do Tocantins',27,'1718881')

insert into cidades values('Santa Rita do Tocantins',27,'1718899')

insert into cidades values('Santa Rosa do Tocantins',27,'1718907')

insert into cidades values('Santa Tereza do Tocantins',27,'1719004')

insert into cidades values('Santa Terezinha do Tocantins',27,'1720002')

insert into cidades values('São Bento do Tocantins',27,'1720101')

insert into cidades values('São Félix do Tocantins',27,'1720150')

insert into cidades values('São Miguel do Tocantins',27,'1720200')

insert into cidades values('São Salvador do Tocantins',27,'1720259')

insert into cidades values('São Sebastião do Tocantins',27,'1720309')

insert into cidades values('São Valério da Natividade',27,'1720499')

insert into cidades values('Silvanópolis',27,'1720655')

insert into cidades values('Sítio Novo do Tocantins',27,'1720804')

insert into cidades values('Sucupira',27,'1720853')

insert into cidades values('Taguatinga',27,'1720903')

insert into cidades values('Taipas do Tocantins',27,'1720937')

insert into cidades values('Talismã',27,'1720978')

insert into cidades values('Tocantínia',27,'1721109')

insert into cidades values('Tocantinópolis',27,'1721208')

insert into cidades values('Tupirama',27,'1721257')

insert into cidades values('Tupiratins',27,'1721307')

insert into cidades values('Wanderlândia',27,'1722081')

insert into cidades values('Xambioá',27,'1722107')

insert into cidades values('Gama',7,'5300108')

insert into cidades values('Taguatinga',7,'5300108')

insert into cidades values('Brazlândia',7,'5300108')

insert into cidades values('Sobradinho',7,'5300108')

insert into cidades values('Planaltina',7,'5300108')

insert into cidades values('Paranoá',7,'5300108')

insert into cidades values('Núcleo Bandeirante',7,'5300108')

insert into cidades values('Ceilândia',7,'5300108')

insert into cidades values('Guará',7,'5300108')

insert into cidades values('Cruzeiro',7,'5300108')

insert into cidades values('Samambaia',7,'5300108')

insert into cidades values('Santa Maria',7,'5300108')

insert into cidades values('São Sebastião',7,'5300108')

insert into cidades values('Lago Sul',7,'5300108')

insert into cidades values('Riacho Fundo',7,'5300108')

insert into cidades values('Lago Norte',7,'5300108')

insert into cidades values('Candangolândia',7,'5300108')

insert into cidades values('Águas Claras',7,'5300108')

insert into cidades values('Riacho Fundo II',7,'5300108')

insert into cidades values('Sudoeste/Octogonal',7,'5300108')

insert into cidades values('Varjão',7,'5300108')

insert into cidades values('Park Way',7,'5300108')

insert into cidades values('SCIA',7,'5300108')

insert into cidades values('Sobradinho II',7,'5300108')

insert into cidades values('Itapoã',7,'5300108')

insert into cidades values('SIA',7,'5300108')

insert into cidades values('Vicente Pires',7,'5300108')

insert into cidades values('Fercal',7,'5300108')

insert into cidades values('Recanto das Emas',7,'5300108')

insert into cidades values('Jardim Botânico',7,'5300108')

insert into cidades values('Nazária',17,'2206720')

insert into cidades values('Paraíso das Águas',12,'5006275')

insert into cidades values('Pinto Bandeira',23,'4314548')

insert into cidades values('Balneário Rincão',24,'4220000')

insert into cidades values('Pescaria Brava',24,'4212650')

CREATE TABLE [dbo].[CLIENTES] (
    [ID]          INT          IDENTITY (1, 1) NOT NULL,
    [NOME]        VARCHAR (70) NOT NULL,
    [CPF]         CHAR (11)    NOT NULL,
    [RG]          VARCHAR (9)  NOT NULL,
    [TELEFONE1]   VARCHAR (15) NOT NULL,
    [TELEFONE2]   VARCHAR (15) NULL,
    [EMAIL]       VARCHAR (70) NOT NULL,
    [CEP]         CHAR (8)     NOT NULL,
    [ESTADO]      INT          NOT NULL,
    [CIDADE]      INT          NOT NULL,
    [RUA]         VARCHAR (70) NOT NULL,
    [BAIRRO]      VARCHAR (50) NOT NULL,
    [NUMERO]      VARCHAR (5)  NOT NULL,
    [COMPLEMENTO] VARCHAR (70) NULL,
    [CONTA]       FLOAT (53)   NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [UNIQUE_CLI_EMAIL] UNIQUE NONCLUSTERED ([EMAIL] ASC),
    CONSTRAINT [UNIQUE_CLI_RG] UNIQUE NONCLUSTERED ([RG] ASC),
    CONSTRAINT [UNIQUE_CLI_CPF] UNIQUE NONCLUSTERED ([CPF] ASC),
    CONSTRAINT [FK_CLI_ESTADO] FOREIGN KEY ([ESTADO]) REFERENCES [dbo].[ESTADOS] ([ID]),
    CONSTRAINT [FK_CLI_CIDADE] FOREIGN KEY ([CIDADE]) REFERENCES [dbo].[CIDADES] ([ID])
)

CREATE TABLE [dbo].[FUNCIONARIOS] (
    [ID]          INT          IDENTITY (1, 1) NOT NULL,
    [NOME]        VARCHAR (70) NOT NULL,
    [CPF]         CHAR (11)    NOT NULL,
    [RG]          VARCHAR (9)  NOT NULL,
    [TELEFONE]    VARCHAR (15) NOT NULL,
    [CEP]         CHAR (8)     NOT NULL,
    [ESTADO]      INT          NOT NULL,
    [CIDADE]      INT          NOT NULL,
    [RUA]         VARCHAR (70) NOT NULL,
    [BAIRRO]      VARCHAR (50) NOT NULL,
    [NUMERO]      VARCHAR (5)  NOT NULL,
    [COMPLEMENTO] VARCHAR (70) NULL,
    [EMAIL]       VARCHAR (40) NOT NULL,
    [SENHA]       VARCHAR (25) NOT NULL,
    [EHADM]       BIT          NOT NULL,
    [SAIU]        BIT          NOT NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [UNIQUE_FUN_RG] UNIQUE NONCLUSTERED ([RG] ASC),
    CONSTRAINT [UNIQUE_FUN_EMAIL] UNIQUE NONCLUSTERED ([EMAIL] ASC),
    CONSTRAINT [UNIQUE_FUN_CPF] UNIQUE NONCLUSTERED ([CPF] ASC),
    CONSTRAINT [FK_FUN_ESTADO] FOREIGN KEY ([ESTADO]) REFERENCES [dbo].[ESTADOS] ([ID]),
    CONSTRAINT [FK_FUN_CIDADE] FOREIGN KEY ([CIDADE]) REFERENCES [dbo].[CIDADES] ([ID]),
    FOREIGN KEY ([ESTADO]) REFERENCES [dbo].[ESTADOS] ([ID]),
    FOREIGN KEY ([CIDADE]) REFERENCES [dbo].[CIDADES] ([ID])
)

CREATE TABLE [dbo].[FORNECEDORES] (
    [ID]          INT          IDENTITY (1, 1) NOT NULL,
    [NOMEEMPRESA] VARCHAR (60) NOT NULL,
    [CNPJ]        VARCHAR (14) NOT NULL,
    [NOME]        VARCHAR (70) NOT NULL,
    [TELEFONE]    VARCHAR (15) NOT NULL,
    [EMAIL]       VARCHAR (70) NOT NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [UNIQUE_FOR_CNPJ] UNIQUE NONCLUSTERED ([CNPJ] ASC)
)

CREATE TABLE [dbo].[PRODUTOS] (
    [ID]           INT          IDENTITY (1, 1) NOT NULL,
    [NOME]         VARCHAR (70) NOT NULL,
    [DESCRICAO]    VARCHAR (80) NOT NULL,
    [PRECOUND]     FLOAT (53)   NOT NULL,
    [ESTOQUE]      INT          NOT NULL,
    [IDFORNECEDOR] INT          NOT NULL,
    [STATUS]       VARCHAR (7)   NOT NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_PRO_FORN] FOREIGN KEY ([IDFORNECEDOR]) REFERENCES [dbo].[FORNECEDORES] ([ID])
)

CREATE TABLE [dbo].[TIPOS] (
    [ID]         INT          IDENTITY (1, 1) NOT NULL,
    [TIPOSTRING] VARCHAR (30) NOT NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [UNIQUE_TIPOS_TIPOSTRING] UNIQUE NONCLUSTERED ([TIPOSTRING] ASC),
    UNIQUE NONCLUSTERED ([TIPOSTRING] ASC)
)

CREATE TABLE [dbo].[QUARTOS] (
    [ID]         INT        IDENTITY (1, 1) NOT NULL,
    [PRECO]      FLOAT (53) NOT NULL,
    [TIPO]       INT        NOT NULL,
    [DISPONIVEL] BIT        NOT NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_QUARTO_TIPO] FOREIGN KEY ([TIPO]) REFERENCES [dbo].[TIPOS] ([ID])
)

CREATE TABLE [dbo].[RESERVAS] (
    [ID]       INT      IDENTITY (1, 1) NOT NULL,
    [QUARTO]   INT      NOT NULL,
    [CLIENTE]  INT      NOT NULL,
    [CHECKIN]  DATETIME NOT NULL,
    [CHECKOUT] DATETIME NOT NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_RESERVA_QUARTO] FOREIGN KEY ([QUARTO]) REFERENCES [dbo].[QUARTOS] ([ID]),
    CONSTRAINT [FK_RESERVA_CLIENTE] FOREIGN KEY ([CLIENTE]) REFERENCES [dbo].[CLIENTES] ([ID])
)

CREATE TABLE [dbo].[VENDAS] (
    [ID]          INT        IDENTITY (1, 1) NOT NULL,
    [DATADEVENDA] DATETIME   NOT NULL,
    [FUNCIONARIO] INT        NOT NULL,
    [CLIENTE]     INT        NOT NULL,
    [PRODUTO]     INT        NOT NULL,
    [QUANTIDADE]  INT        NOT NULL,
    [VALOR]       FLOAT (53) NOT NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_VENDA_FUNCIONARIO] FOREIGN KEY ([FUNCIONARIO]) REFERENCES [dbo].[FUNCIONARIOS] ([ID]),
    CONSTRAINT [FK_VENDA_CLIENTE] FOREIGN KEY ([CLIENTE]) REFERENCES [dbo].[CLIENTES] ([ID]),
    CONSTRAINT [FK_VENDA_PRODUTO] FOREIGN KEY ([PRODUTO]) REFERENCES [dbo].[PRODUTOS] ([ID])
)