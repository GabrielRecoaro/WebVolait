create database db_VolaitData;
use db_VolaitData;

create table tb_funcionario
(
	CPF_Func char(11) primary key not null,
    NomeCompleto_Func varchar(70) not null,
    NomeSocial_Func varchar(70),
    Email_Func varchar(30) not null,
    Telefone_Func varchar(11) not null,
    Senha_Func char(6) not null
);

create table tb_atendimento
(
	Cod_Atend int primary key not null auto_increment,
    Desc_Atend varchar(100),
    DataHora_Atend datetime,
    NomeCliente_Atend varchar(50),
    CPF_Func char(11) not null,
    constraint fk_cpfFunc foreign key(CPF_Func) references tb_funcionario(CPF_Func)
);

create table tb_cliente
(
	CPF_Cli char(11) primary key not null,
    NomeCompleto_Cli varchar(70) not null,
    NomeSocial_Cli varchar(70),
    Email_Cli varchar(30) not null,
    Telefone_Cli varchar(11) not null
);

create table tb_tipoPagto
(
	Cod_TipoPagto int primary key not null auto_increment,
    Tipo_Pagto varchar(20)
);

create table tb_venda
(
	NotaFiscal int primary key not null,
    Data_Venda date,
    CPF_Func char(11) not null,
    CPF_Cli char(11) not null,
    Cod_TipoPagto int not null auto_increment,
    constraint fk_Func foreign key(CPF_Func) references tb_funcionario(CPF_Func),
    constraint fk_cpfCli foreign key(CPF_Cli) references tb_cliente(CPF_Cli),
    constraint fk_tipoPagto foreign key(Cod_TipoPagto) references tb_tipoPagto(Cod_TipoPagto)
);

create table tb_tipoHosp
(
	Cod_TipoHosp int primary key not null auto_increment,
    Tipo_Hosp varchar(20) not null
);

create table tb_tipoTransp
(
	Cod_TipoTransp int primary key not null auto_increment,
    Tipo_Transp varchar(20) not null
);

create table tb_hospedagem
(
	Cod_Hosp int primary key not null auto_increment,
    Nome_Hosp varchar(50) not null,
    CNPJ_Hosp char(14) not null,
    NumDiarias_Hosp int,
    Cod_TipoHosp int not null,
    constraint fk_tipoHosp foreign key(Cod_TipoHosp) references tb_tipoHosp(Cod_TipoHosp)
);

create table tb_transporte
(
	Cod_Transp int primary key not null auto_increment,
    Empresa_Transp varchar(50) not null,
    CNPJ_Transp char(14) not null,
    Duracao_Transp varchar(20),
    Cod_TipoTransp int not null,
    constraint fk_tipoTransp foreign key(Cod_TipoTransp) references tb_tipoTransp(Cod_TipoTransp)
);

create table tb_passeio
(
	Cod_Passeio int primary key not null auto_increment,
    Empresa_Passeio varchar(50) not null,
    CNPJ_Passeio char(14) not null,
    Nome_Passeio varchar(30) not null,
    Desc_Passeio varchar(100),
    Duracao_Passeio varchar(20)
);

create table tb_itemPacote
(
	Cod_ItemPacote int primary key not null auto_increment
);

create table tb_itemHosp
(
	Cod_Hosp int not null,
    Cod_ItemPacote int not null,
    constraint fk_hosp foreign key(Cod_Hosp) references tb_hospedagem(Cod_Hosp),
    constraint fk_itemPacote1 foreign key(Cod_ItemPacote) references tb_itemPacote(Cod_ItemPacote)
);

create table tb_itemTransp
(
	Cod_Transp int not null,
    Cod_ItemPacote int not null,
    constraint fk_transp foreign key(Cod_Transp) references tb_transporte(Cod_Transp),
    constraint fk_itemPacote2 foreign key(Cod_ItemPacote) references tb_itemPacote(Cod_ItemPacote)
);

create table tb_itemPasseio
(
	Cod_Passeio int not null,
    Cod_ItemPacote int not null,
    constraint fk_passeio foreign key(Cod_Passeio) references tb_passeio(Cod_Passeio),
    constraint fk_itemPacote3 foreign key(Cod_ItemPacote) references tb_itemPacote(Cod_ItemPacote)
);

create table tb_pacote
(
	Cod_Pacote int primary key not null auto_increment,
    Nome_Pacote varchar(50) not null,
    Desc_Pacote varchar(500),
    Destino_Pacote varchar(20),
    Valor_Pacote decimal(15,2),
    Cod_ItemPacote int not null,
    constraint fk_itemPacote4 foreign key(Cod_ItemPacote) references tb_itemPacote(Cod_ItemPacote)
);

create table tb_itemVenda
(
	Cod_ItemVenda int primary key not null auto_increment,
    Qtd_ItemVenda int,
    Valor_ItemVenda decimal(15,2),
    Cod_Pacote int not null,
    NotaFiscal int not null,
    constraint fk_pacote foreign key(Cod_Pacote) references tb_pacote(Cod_Pacote),
    constraint fk_nota foreign key(NotaFiscal) references tb_venda(NotaFiscal)
);

insert into tb_funcionario values('52673833846', 'Brenda Sanches Berzin', 'Brenda', 'brenda.berzin@etec.sp.gov.br', '11942786165', 'bsb137');
select * from tb_funcionario;

insert into tb_tipoHosp values(Default, 'Hotel'), (Default, 'Hostel'), (Default, 'Pousada'), (Default, 'Loca????o'), (Default, 'Resort'), (Default, 'Hotel Fazenda');
select * from tb_tipoHosp;

insert into tb_tipoTransp values(Default, 'Voo'), (Default, 'Carro'), (Default, 'Trem'), (Default, '??nibus'), (Default, 'Van-Transfer');
select * from tb_tipoTransp;

insert into tb_transporte values(Default, 'Gol Linhas A??reas', '07575651000159', '2h10min', 1, 'Voo para Cuiab?? - MT');
select * from tb_transporte;

alter table tb_transporte add Desc_Transp varchar(50);

insert into tb_transporte values(Default, 'Gol Linhas A??reas', '07575651000159', '2h10min', 1, 'Voo para Palmas - TO'), 
(Default, 'LATAM Airlines Brasil', '02012862000160', '2h5min', 1, 'Voo para Salvador - BA'), 
(Default, 'Azul Linhas A??reas Brasileiras', '09296295000160', '1h40min', 1, 'Voo para Campo Grande - MS'),
(Default, 'LATAM Airlines Brasil', '02012862000160', '3h40min', 1, 'Voo para Manaus - AM');

insert into tb_hospedagem values(Default, 'Sesc Pantanal', '33469164033044', 7, 1);

select * from tb_hospedagem;

insert into tb_transporte values(Default, 'LATAM Airlines Brasil', '02012862000160', '1h5min', 1, 'Voo para o Rio de Janeiro - RJ (ida e volta)');

insert into tb_hospedagem values(Default, 'Juma Amazon Lodge', '11188013000152', 5, 1),
(Default, 'Pousada Cachoeiras do Jalap??o', '25579819000101', 4, 3), 
(Default, 'Pousada Cambar??', '39783616000111', 5, 3),
(Default, 'The Hostel Salvador', '26145552000181', 1, 2),
(Default, 'Apoena Ecopousada', '07757838000173', 1, 3),
(Default, 'Tropical Mar Hotel Aracaju', '09753459000189', 2, 1),
(Default, 'Dunem Hotel', '25246713000241', 1, 1),
(Default, 'Mango Tree Hostel Ipanema', '08424337000138', 4, 2);

insert into tb_transporte values(Default, 'DansTour Transportes Tur??sticos', '07453788000149', '2h30min', 5, 'Transfer do Aeroporto de Cuiab?? para o Sesc Pantanal'),
(Default, 'DeckTour Translados', '23257677000133', '4h30min', 5, 'Transfer do Aeroporto de Palmas para S??o F??lix do Tocantins'),
(Default, 'NatTour Transfers Tur??sticos', '09877451000123', '3h40min', 5, 'Transfer do Aeroporto de Campo Grande para Bonito'),
(Default, 'NatTour Transfers Tur??sticos', '09877451000123', '5h30min', 5, 'Transfer do Aeroporto de Manaus para o Juma Amazon Lodge'),
(Default, 'DeckTour Translados', '23257677000133', '3h', 2, 'Transladodo hotel em Salvador para Mangue Seco'),
(Default, 'DansTour Transportes Tur??sticos', '07453788000149', '2h', 2, 'Translado de Mangue Seco para Aracaju'),
(Default, 'DansTour Transportes Tur??sticos', '07453788000149', '2h30min', 2, 'Transfer de Aracaju para Piranhas - AL'),
(Default, 'NatTour Transfers Tur??sticos', '09877451000123', '30min', 5, 'Translado do aeroporto para a hospedagem');
insert into tb_transporte values(Default, 'DansTour Transportes Tur??sticos', '07453788000149', '30min', 5, 'Transfer do Aeroporto de Salvador para a hospedagem');

alter table tb_transporte modify column Desc_Transp varchar(100);
alter table tb_passeio modify column Desc_Passeio varchar(200);
alter table tb_passeio modify column Nome_Passeio varchar(50);

select* from tb_transporte;
select * from tb_hospedagem;
select * from tb_passeio;

insert into tb_passeio values(Default, 'Sesc Pantanal', '33469164033044', 'Pelas ??guas do Pantanal', 'Passeio de barco pelo rio para conhecer o escossistema e avistar animais', '2h'),
(Default, 'Sesc Pantanal', '33469164033044', 'O Pantanal estrelado', 'Passeio noturno de barco pelo rio para conhecer o escossistema a noite e conhecer os animaisde h??bito noturno', '2h'),
(Default, 'Sesc Pantanal', '33469164033044', 'Sobre rodas na Transpantaneira', 'Passeio pela maior estrada do Pantanal, a Transpantaneira, onde ?? poss??vel avistar animais e conhecer a natureza da regi??o', '4h'),
(Default, 'Bonitour', '07933455000123', 'Gruta do Lago Azul', 'Visita a mais famosa e bela gruta de Bonito, paradisi??ca para apreciar os encantos da natureza', '3h'),
(Default, 'Bonitour', '07933455000123', 'Buraco das Araras', 'Visita ao mirante do Buraco das Araras para avistar os ninhos (rapel n??o incluso)', '2h'),
(Default, 'Bonitour', '07933455000123', 'Flutua????o no Rio Sucuri', 'Uma deliciosa flutua????o nas calmas ??guas do Sucuri', '3h'),
(Default, 'Jalap??o Jalape??o Turismo', '09977851000145', 'Dunas do Jalap??o', 'Passeio espetacular pelas dunas brancas do Jalap??o', '3h'),
(Default, 'Jalap??o Jalape??o Turismo', '09977851000145', 'Fervedouro Bela Vista', 'Visita a um dos mais belos fervedouros da regi??o', '3h'),
(Default, 'Jalap??o Jalape??o Turismo', '09977851000145', 'Cachoeira da Formiga', 'Parada para se refrescar na incr??vel Cachoeira da Formiga', '3h'),
(Default, 'Juma Amazon Lodge', '11188013000152', 'Trilha na Selva', 'Passeio imperd??vel para conhecer a floresta atrav??s do olhar singular de um guia local', '5h'),
(Default, 'Juma Amazon Lodge', '11188013000152', 'Pelas ??guas Amaz??nicas', 'Passeio de barco cortando a floresta ao meio, pelos rios', '3h'),
(Default, 'Juma Amazon Lodge', '11188013000152', 'Encontro das ??guas', 'Este passeio proporciona a experi??ncia de testemunhar um dos mais incr??veis fen??menos da natureza, o encontro dos rios Negro e Solim??es em nossa Floresta Amaz??nica', '2h'),
(Default, 'Bahea Passeios', '05733469000144', 'City Tour em Salvador', 'Este passeio proporciona uma visita guiada ??s mais importantes atra????es da cidade como o Pelourinho e a Igreja do Bonfim', '5h'),
(Default, 'Seco Mangue Seco Turismo', '03455689000122', 'Nas dunas de Mangue Seco', 'Passeio de buggy pelas bel??ssimas dunas de Mangue Seco', '2h'),
(Default, 'Caju Passeios', '04223433000167', 'City Tour em Aracaju', 'City Tour pelas melhores atra????es da cidade', '5h'),
(Default, 'S??o Francisco Passeios', '07222431000193', 'C??nios do Xing??, nas ??guas do S??o Francisco', 'Passeio pelos c??nios do Xing??, um espet??culo da natureza cravado no Rio S??o Francisco', '5h'),
(Default, 'Rio Tour', '05477693000149', 'Cristo, o Redentor', 'Visita????o ao cart??o postal do Rio, o nosso Cristo Redentor', '2h'),
(Default, 'Rio Tour', '05477693000149', 'Visita ao Maracan??', 'Uma visita eletrizante ao s??mbolo do futebol brasileiro', '2h'),
(Default, 'Rio Tour', '05477693000149', 'P??o de A????car', 'Visita????o ao morro do P??o de A????car e um passeio pelo mais famoso bondinho do Brasil', '2h');

drop table tb_itempasseio;
drop table tb_itemhosp;
drop table tb_itemtransp;

alter table tb_itempacote add column Cod_Hosp int, add constraint fk_hosp foreign key(Cod_Hosp) references tb_hospedagem(Cod_Hosp);
alter table tb_itempacote add column Cod_Transp int, add constraint fk_transp foreign key(Cod_Transp) references tb_transporte(Cod_Transp);
alter table tb_itempacote add column Cod_Passeio int, add constraint fk_passeio foreign key(Cod_Passeio) references tb_passeio(Cod_Passeio);
alter table tb_itempacote add column Cod_Pacote int, add constraint fk_pacote2 foreign key(Cod_Pacote) references tb_pacote(Cod_Pacote);
alter table tb_pacote drop foreign key fk_itemPacote4;
alter table tb_pacote drop column Cod_ItemPacote;
alter table tb_venda add column Valor_Venda decimal(15,2);

select * from tb_transporte;
select * from tb_hospedagem;
select * from tb_passeio;
select * from tb_pacote;
select * from tb_itempacote;
select * from vw_venda;



insert into tb_pacote values(Default, 'Retiro no Pantanal', 'Pacote de 7 di??rias para um estadia aventureira e tamb??m tranquila no Sesc Pantanal', 'Pantanal - MS', '5567.00');
insert into tb_pacote values(Default, 'Desbravando o Jalap??o', 'Pacote de 4 di??rias para conhecer um dos mais belos destinos brasileiros, com estadia na cidade de S??o F??lix do Tocantins', 'Jalap??o - TO', '3470.00'),
(Default, 'Bonito, mais que lindo', 'Pacote de 5 di??rias para se maravilhar com as belezas de Bonito', 'Bonito - MS', '4635.00'),
(Default, 'Na Selva Amaz??nica', 'Pacote de 5 di??rias para relaxar e aprender mais sobre nossa Amazonia com uma estadia impec??vel em um lodge no meio da floresta', 'Amaz??nia - AM', '7330.00'),
(Default, 'Rodando o Nordeste', 'Pacote de 5 di??rias para rodar o Nordeste e conhecer pontos tur??sticos incr??veis passando por 4 cidades e 3 estados', 'Nordeste Brasileiro', '4578.00'),
(Default, 'Na Cidade Maravilhosa', 'Pacote de 4 di??rias para visitar a cidade maravilhosa, nosso Rio de Janeiro', 'Rio de Janeiro - RJ', '3470.00');

insert into tb_hospedagem values(0, 'N??o h?? hospedagem', '00000000000100', 0, 1);
insert into tb_transporte values(0, 'N??o h?? transporte', '00000000000100', '0h0min', 1, 'N??o h?? transporte');
insert into tb_passeio values(0, 'N??o h?? passeio', '00000000000100', 'N??o h?? passeio', 'N??o h?? passeio', '0h0min');

select * from tb_transporte;
select * from tb_hospedagem;
select * from tb_passeio;
select * from tb_pacote;
select * from tb_itempacote;

select * from tb_passeio;
/*voos*/
insert into tb_itempacote values(Default, 1, 10, 1, 1), (Default, 2, 10, 2, 1), (Default,  3, 10, 4, 1), (Default,  4, 10, 5, 1), (Default,  5, 10, 3, 1), (Default,  6, 10, 17, 1);

/*demais transportes*/
insert into tb_itempacote values(Default, 1, 10, 6, 1), (Default, 2, 10, 7, 1), (Default, 3, 10, 8, 1), (Default, 4, 10, 9, 1), (Default, 5, 10, 10, 1), (Default, 5, 10, 11, 1), (Default, 5, 10, 12, 1), (Default, 5, 10, 14, 1), (Default, 6, 10, 13, 1);

/*hospedagens*/
insert into tb_itempacote values(Default, 1, 1, 15, 1), (Default, 2, 3, 15, 1), (Default, 3, 4, 15, 1), (Default, 4, 2, 15, 1), (Default, 5, 5, 15, 1), (Default, 5, 6, 15, 1), (Default, 5, 7, 15, 1), (Default, 5, 8, 15, 1), (Default, 6, 9, 15, 1);

/*passeios*/
insert into tb_itempacote values
(Default, 1, 10, 15, 3), (Default, 1, 10, 15, 4), (Default, 1, 10, 15, 5),
(Default, 2, 10, 15, 9), (Default, 2, 10, 15, 10), (Default, 2, 10, 15, 11), 
(Default, 3, 10, 15, 6), (Default, 3, 10, 15, 7), (Default, 3, 10, 15, 8),
(Default, 4, 10, 15, 12), (Default, 4, 10, 15, 13), (Default, 4, 10, 15, 14),
(Default, 5, 10, 15, 15), (Default, 5, 10, 15, 16), (Default, 5, 10, 15, 17), (Default, 5, 10, 15, 18), 
(Default, 6, 10, 15, 19), (Default, 6, 10, 15, 20), (Default, 6, 10, 15, 21);

create view vw_pacote
as select
	tb_pacote.Cod_Pacote,
    tb_pacote.Nome_Pacote,
    tb_pacote.Desc_Pacote,
    tb_pacote.Destino_Pacote,
    tb_pacote.Valor_Pacote,
    tb_itempacote.Cod_ItemPacote,
    tb_hospedagem.Nome_Hosp,
    tb_transporte.Desc_Transp,
    tb_passeio.Nome_Passeio
from tb_pacote inner join tb_itempacote on tb_pacote.Cod_Pacote = tb_itempacote.Cod_Pacote 
			   inner join tb_hospedagem on tb_itempacote.Cod_Hosp = tb_hospedagem.Cod_Hosp
               inner join tb_transporte on tb_itempacote.Cod_Transp = tb_transporte.Cod_Transp
               inner join tb_passeio on tb_itempacote.Cod_Passeio = tb_passeio.Cod_Passeio;

select * from vw_pacote;
select * from tb_funcionario;

alter table tb_funcionario modify column Email_Func varchar(50);

insert into tb_funcionario values('98623688689', 'Bruno Silva Bastos', 'Bruno', 'bruno.bastos3@etec.sp.gov.br', '11956383957', 'bsb398'),
('57345699832', 'Gabriel Jard Recoaro Silva', 'Gabriel', 'gabriel.silva2615@etec.sp.gov.br', '11944485007', 'gjs261'),
('78456377925', 'Filipe Ferreiro Pereira', 'Filipe', 'felipe.pereira252@etec.sp.gov.br', '11989652235', 'ffp252'),
('56487933278', 'Pedro Augusto Souza Ribeiro de Aquino', 'Pedro Augusto', 'pedro.aquino@etec.sp.gov.br', '11977188102', 'paa564');



insert into tb_cliente values('65789577234', 'Judith Brito', 'Judith', 'jud.brito@gmail.com', '11947265184'),
('57689455721', 'Elio Gaspari', 'Elio', 'elio.gaspari@gmail.com', '11976119231'),
('90834677903', 'Anna Almeida', 'Anna', 'annaalmeida@gmail.com', '11971694278'),
('96745372198', 'Igor Resende', 'Igor', 'igosende@gmail.com', '11989762241'),
('78545623745', 'Laura Goes', 'Laura', 'laura.goes@gmail.com', '11987619433');

insert into tb_tipopagto values(Default, 'Cart??o de Cr??dito'), (Default, 'Cart??o de D??bito'), (Default, 'Cheque'), (Default, 'Boleto Banc??rio'), (Default, 'PIX');
select * from tb_tipopagto;
select * from tb_pacote;

insert into tb_venda values(12345, '2021-12-08', '52673833846', '90834677903', 1, '22268.00'),
(23456, '2021-12-08', '98623688689', '65789577234', 3, '9270.00'),
(34567, '2021-12-08', '57345699832', '57689455721', 2, '10410.00'),
(45678, '2021-12-08', '78456377925', '96745372198', 1, '16096.00'),
(56789, '2021-12-08', '56487933278', '78545623745', 5, '29320.00');

insert into tb_itemvenda values(Default, 4, '22268.00', 1, 12345),
(Default, 2, '9270.00', 3, 23456),
(Default, 3, '10410.00', 2, 34567),
(Default, 2, '9156.00', 5, 45678),
(Default, 2, '6940.00', 6, 45678),
(Default, 4, '29320.00', 4, 56789);

create view vw_venda
as select
	tb_venda.NotaFiscal,
    tb_venda.Data_Venda,
    tb_venda.Valor_Venda,
    tb_funcionario.NomeCompleto_Func,
    tb_cliente.NomeCompleto_Cli,
    tb_tipopagto.Tipo_Pagto,
    tb_itemvenda.Cod_ItemVenda,
    tb_itemvenda.Qtd_ItemVenda,
    tb_itemvenda.Valor_ItemVenda,
    tb_pacote.Nome_Pacote,
    tb_pacote.Desc_Pacote,
    tb_pacote.Destino_Pacote,
    tb_pacote.Valor_Pacote
from tb_venda inner join tb_itemvenda on tb_venda.NotaFiscal = tb_itemvenda.NotaFiscal 
			  inner join tb_pacote on tb_itemvenda.Cod_Pacote = tb_pacote.Cod_Pacote
              inner join tb_funcionario on tb_venda.CPF_Func = tb_funcionario.CPF_Func
              inner join tb_cliente on tb_venda.CPF_Cli = tb_cliente.CPF_Cli
              inner join tb_tipopagto on tb_venda.Cod_TipoPagto = tb_tipopagto.Cod_TipoPagto;
              
use db_VolaitData;
drop view vw_venda;

create view vw_venda
as select
	tb_venda.NotaFiscal,
    tb_venda.Data_Venda,
    tb_venda.Valor_Venda,
    tb_funcionario.NomeCompleto_Func,
    tb_funcionario.CPF_Func,
    tb_cliente.NomeCompleto_Cli,
    tb_cliente.CPF_Cli,
    tb_tipopagto.Tipo_Pagto,
    tb_itemvenda.Cod_ItemVenda,
    tb_itemvenda.Qtd_ItemVenda,
    tb_itemvenda.Valor_ItemVenda,
    tb_pacote.Nome_Pacote,
    tb_pacote.Desc_Pacote,
    tb_pacote.Destino_Pacote,
    tb_pacote.Valor_Pacote
from tb_venda inner join tb_itemvenda on tb_venda.NotaFiscal = tb_itemvenda.NotaFiscal 
			  inner join tb_pacote on tb_itemvenda.Cod_Pacote = tb_pacote.Cod_Pacote
              inner join tb_funcionario on tb_venda.CPF_Func = tb_funcionario.CPF_Func
              inner join tb_cliente on tb_venda.CPF_Cli = tb_cliente.CPF_Cli
              inner join tb_tipopagto on tb_venda.Cod_TipoPagto = tb_tipopagto.Cod_TipoPagto;
              
drop view vw_venda;

create view vw_venda
as select
	tb_venda.NotaFiscal,
    tb_venda.Data_Venda,
    tb_venda.Valor_Venda,
    tb_funcionario.NomeCompleto_Func,
    tb_funcionario.CPF_Func,
    tb_cliente.NomeCompleto_Cli,
    tb_cliente.CPF_Cli,
    tb_tipopagto.Cod_TipoPagto,
    tb_tipopagto.Tipo_Pagto,
    tb_itemvenda.Cod_ItemVenda,
    tb_itemvenda.Qtd_ItemVenda,
    tb_itemvenda.Valor_ItemVenda,
    tb_pacote.Cod_Pacote,
    tb_pacote.Nome_Pacote,
    tb_pacote.Desc_Pacote,
    tb_pacote.Destino_Pacote,
    tb_pacote.Valor_Pacote
from tb_venda inner join tb_itemvenda on tb_venda.NotaFiscal = tb_itemvenda.NotaFiscal 
			  inner join tb_pacote on tb_itemvenda.Cod_Pacote = tb_pacote.Cod_Pacote
              inner join tb_funcionario on tb_venda.CPF_Func = tb_funcionario.CPF_Func
              inner join tb_cliente on tb_venda.CPF_Cli = tb_cliente.CPF_Cli
              inner join tb_tipopagto on tb_venda.Cod_TipoPagto = tb_tipopagto.Cod_TipoPagto;
              
select * from vw_venda;
              
select * from vw_venda;
              
select * from vw_venda;

select * from tb_funcionario;

 CREATE USER 'adm'@'localhost' IDENTIFIED WITH mysql_native_password BY '12345';
 GRANT ALL PRIVILEGES ON db_VolaitData.* TO 'adm'@'localhost' WITH GRANT OPTION;