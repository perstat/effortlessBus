Create database horario_onibus;

Use horario_onibus;

Create table trajeto (
id int unsigned not null primary key auto_increment,
id_onibus int not null,
horarios time,
id_gps int not null,
linhas_id int,
foreign key(id_onibus) references onibus(id_onibus)
);

insert into trajeto
	(id, id_onibus, agencia, horarios, id_gps, linhas_id)
    values
    (1, 1, '06:00:00', 1 , 1),
    (2, 1, '06:30:00', 2 , 2),
	(3, 2, '07:00:00', 3 , 1),
    (4, 1, '07:30:00', 4 , 1),
    (5, 4, '08:00:00', 5 , 3),
    (6, 3, '08:00:00', 6 , 4),
    (7, 3, '09:00:00', 7 , 5),
    (8, 5, '10:00:00', 8 , 6);

Create table ponto
	( id int unsigned not null primary key auto_increment,
	cidade varchar(50) not null,
	bairo varchar(50),
	localizacao varchar(300),
	distancia_rod int(4),
	linha varchar(50)
);

insert into ponto
	(id, cidade, bairo, localizacao , distancia_rod, linha)
    values
    (1,'Caragua', 'porto', '%' , 100, 'Caraguatatuba' ),
    (2, 'Caragua', 'indaia', '%' , 300, 'Caraguatatuba'),
	(3,'São Sebastião', 'Pontal da cruz', '%' , 100, 'São Sebastião'),
    (4,'São Sebastião', 'Enceada', '%' , 399, 'São Sebastião'),
    (5, 'Caragua', 'Jaragua', '%' , 100 , 'Jaragua'),
    (6, 'Caragua', 'Porto', '%' , 200 , 'Vapapesca');


Create table linha (
id int unsigned not null primary key auto_increment,
percurso text
);

insert into linha
	(id, percurso)
    values
    (44, '%'),
	(12, '%'),
    (41, '%'),
    (33, '%');
    
SELECT * FROM onibus;

Create table onibus (
id_onibus int not null,
agencia varchar(50) not null
);
