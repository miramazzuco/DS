create database testando;
use testando;
create table usuario(
id_usuario int primary key not null auto_increment,
nome varchar(50),
senha varchar(40)
)default charset = utf8;
