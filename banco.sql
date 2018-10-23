Create database horario_onibus;

Use horario_onibus;

Create table onibus (
id int unsigned not null primary key auto_increment,
agencia varchar(50) not null,
horarios time,
velocidade_atual int(3),
id_gps int not null,
linhas_id int
);

Create table ponto (
id int unsigned not null primary key auto_increment,
cidade varchar(50) not null,
bairo varchar(50),
localizacao varchar(300),
distancia_rod int(4),
linha varchar(50)
);


Create table linha (
id int unsigned not null primary key auto_increment,
percurso text
);



