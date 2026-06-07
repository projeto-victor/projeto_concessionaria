-- phpMyAdmin SQL Dump
-- version 4.0.4.2
-- http://www.phpmyadmin.net
--
-- Máquina: localhost
-- Data de Criação: 04-Dez-2025 às 11:18
-- Versão do servidor: 5.6.13
-- versão do PHP: 5.4.17

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Base de Dados: `att_concessionaria`
--

CREATE DATABASE IF NOT EXISTS `att_concessionaria` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
USE `att_concessionaria`;

-- --------------------------------------------------------

--
-- Estrutura da tabela `balcao` (veículos em estoque)
--
CREATE TABLE IF NOT EXISTS `balcao` (
  `id_balcao` int(11) NOT NULL AUTO_INCREMENT,
  `produto_balcao` varchar(70) NOT NULL,
  `tipo_balcao` varchar(30) NOT NULL,
  `qtde_balcao` int(11) NOT NULL,
  `valor_balcao` int(11) NOT NULL,
  PRIMARY KEY (`id_balcao`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=7 ;

--
-- Extraindo dados da tabela `balcao` (veículos disponíveis no pátio)
--
INSERT INTO `balcao` (`id_balcao`, `produto_balcao`, `tipo_balcao`, `qtde_balcao`, `valor_balcao`) VALUES
(1, 'Chevrolet Onix LT', 'Hatch', 5, 58900),
(2, 'Hyundai HB20 Comfort', 'Hatch', 3, 62400),
(3, 'Toyota Corolla GLi', 'Sedan', 2, 112500),
(4, 'Honda Civic Touring', 'Sedan', 1, 147900),
(5, 'Jeep Compass Sport', 'SUV', 4, 139800),
(6, 'Ford Ranger XLS', 'Picape', 2, 214500);

-- --------------------------------------------------------

--
-- Estrutura da tabela `encomenda` (veículos sob encomenda)
--
CREATE TABLE IF NOT EXISTS `encomenda` (
  `id_encomenda` int(11) NOT NULL AUTO_INCREMENT,
  `produto_encomenda` varchar(70) NOT NULL,
  `tipo_encomenda` varchar(30) NOT NULL,
  `valor_encomenda` int(11) NOT NULL,
  `foto_encomenda` varchar(255) NOT NULL,
  PRIMARY KEY (`id_encomenda`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=16 ;

--
-- Extraindo dados da tabela `encomenda` (carros que podem ser encomendados)
--
INSERT INTO `encomenda` (`id_encomenda`, `produto_encomenda`, `tipo_encomenda`, `valor_encomenda`, `foto_encomenda`) VALUES
(1, 'BMW 320i GP', 'Sedan Luxo', 245900, 'D:/concessionaria/fotos/bmw_320i.jpg'),
(2, 'Mercedes-Benz C180', 'Sedan Luxo', 268700, 'D:/concessionaria/fotos/mercedes_c180.jpg'),
(3, 'Audi Q3', 'SUV Premium', 289500, 'D:/concessionaria/fotos/audi_q3.jpg'),
(4, 'Volvo XC60', 'SUV Premium', 365400, 'D:/concessionaria/fotos/volvo_xc60.jpg'),
(5, 'Porsche Macan', 'SUV Esportivo', 489900, 'D:/concessionaria/fotos/porsche_macan.jpg'),
(6, 'Tesla Model 3', 'Elétrico', 299990, 'D:/concessionaria/fotos/tesla_model3.jpg');

-- --------------------------------------------------------

--
-- Estrutura da tabela `estoque_ingred` (peças/componentes)
-- Obs: mantido o nome original, mas conteúdo adaptado para concessionária
--
CREATE TABLE IF NOT EXISTS `estoque_ingred` (
  `id_ingrediente` int(11) NOT NULL AUTO_INCREMENT,
  `nome_ingrediente` varchar(70) NOT NULL,
  `qtd_ingrediente` int(10) NOT NULL,
  PRIMARY KEY (`id_ingrediente`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=12 ;

--
-- Extraindo dados da tabela `estoque_ingred` (peças em estoque)
--
INSERT INTO `estoque_ingred` (`id_ingrediente`, `nome_ingrediente`, `qtd_ingrediente`) VALUES
(1, 'Óleo do Motor (1L)', 120),
(2, 'Filtro de Óleo', 85),
(3, 'Pastilha de Freio (jogo)', 40),
(4, 'Pneu Aro 16', 60),
(5, 'Bateria 60Ah', 25),
(6, 'Velas de Ignição (kit)', 110),
(7, 'Correia Dentada', 30),
(8, 'Amortecedor Dianteiro', 18),
(9, 'Lâmpada LED Farol', 95),
(10, 'Fluído de Arrefecimento (1L)', 200);

-- --------------------------------------------------------

--
-- Estrutura da tabela `pedidos` (vendas de veículos)
--
CREATE TABLE IF NOT EXISTS `pedidos` (
  `id_pedidos` int(11) NOT NULL AUTO_INCREMENT,
  `cpf_cliente` varchar(14) NOT NULL,
  `produto_pedido` int(11) NOT NULL,
  `valor_pedido` int(11) NOT NULL,
  `qtde` int(11) NOT NULL,
  `data_pedido` varchar(20) NOT NULL,
  `concluido` varchar(10) NOT NULL,
  PRIMARY KEY (`id_pedidos`),
  KEY `cpf_cliente` (`cpf_cliente`),
  KEY `produto_pedido` (`produto_pedido`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=17 ;

--
-- Extraindo dados da tabela `pedidos` (vendas realizadas)
--
INSERT INTO `pedidos` (`id_pedidos`, `cpf_cliente`, `produto_pedido`, `valor_pedido`, `qtde`, `data_pedido`, `concluido`) VALUES
(1, '100.000.000-00', 1, 245900, 1, '10/11/2025', 'ENTREGUE'),
(2, '333.333.333-33', 2, 268700, 1, '15/11/2025', 'ENTREGUE'),
(3, '444.444.444-44', 3, 289500, 1, '20/11/2025', 'ENTREGUE'),
(4, '999.999.999-99', 4, 365400, 1, '22/11/2025', 'ENTREGUE'),
(5, '100.000.000-00', 5, 489900, 1, '25/11/2025', 'ENTREGUE'),
(6, '202.020.202-02', 6, 299990, 1, '28/11/2025', 'ENTREGUE'),
(7, '333.333.333-33', 1, 245900, 1, '01/12/2025', 'PRONTO'),
(8, '888.888.888-88', 2, 268700, 1, '02/12/2025', 'PRONTO'),
(9, '555.555.555-55', 3, 289500, 1, '03/12/2025', 'ENTREGUE');

-- --------------------------------------------------------

--
-- Estrutura da tabela `usuarios` (clientes e funcionários)
--
CREATE TABLE IF NOT EXISTS `usuarios` (
  `cpf_usuario` varchar(14) NOT NULL,
  `nome_usuario` varchar(70) NOT NULL,
  `telefone_usuario` varchar(16) NOT NULL,
  `email_usuario` varchar(70) NOT NULL,
  `senha_usuario` varchar(70) NOT NULL,
  `identificador` varchar(11) NOT NULL,
  `bloqueado` char(3) NOT NULL,
  PRIMARY KEY (`cpf_usuario`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `usuarios` (mantidos os originais, pois já são genéricos)
--
INSERT INTO `usuarios` (`cpf_usuario`, `nome_usuario`, `telefone_usuario`, `email_usuario`, `senha_usuario`, `identificador`, `bloqueado`) VALUES
('0  .   .   -', 'FOUR', '(44) 44444-4444', 'FOUR@EMAIL', '4444', 'CLIENTE', 'SIM'),
('010.101.010-10', 'FUNCIONARIO', '(00) 00000-0000', 'FUNC@EMAIL', 'FUNC', 'FUNCIONARIO', 'NAO'),
('1  .   .   -', 'PROPRIETARIA', '(11) 99731-8210', 'PROP@EMAIL.COM', 'PROP', 'PROP', 'NAO'),
('100.000.000-00', '1', '(10) 00000-0000', '100000', '100', 'CLIENTE', 'NAO'),
('100.200.300-00', 'KIRITO KIRIGAYA', '(00) 10020-0300', 'BETATESTER@SAO', '100', 'FUNCIONARIO', 'SIM'),
('202.020.202-02', 'FELLIPE', '(11) 88888-8888', 'FELLIPE2@EMAIL.COM', '123', 'CLIENTE', 'NAO'),
('333.333.333-33', 'FELLIPE', '(33) 33333-3333', 'FELLIPE@EMAIL.COM', '1234', 'CLIENTE', 'NAO'),
('444.444.444-44', 'FOUR', '(44) 44444-4444', 'FOUR@EMAIL', 'QUATRO', 'CLIENTE', 'NAO'),
('555.555.555-55', 'TAGO', '(55) 55555-5555', 'THI@EMAIL.COM', '3', 'FUNCIONARIO', 'NAO'),
('666.666.666-66', 'A', '(00) 00000-0000', 'F@EMAIL.COM', '2', 'FUNCIONARIO', 'NAO'),
('777.777.777-77', 'SEVEN', '(77) 77777-7777', 'SETE@EMAIL', '7777777', 'FUNCIONARIO', 'SIM'),
('888.888.888-88', 'LEANDRO', '(22) 22222-2222', 'LEANDRO@FUNC.COM', '1234', 'FUNCIONARIO', 'NAO'),
('999.999.999-99', 'LELEULES', '(99) 99999-9999', 'LELEULES@EMAIL', '99999', 'CLIENTE', 'NAO');

--
-- Constraints para tabela `pedidos` COM ON CASCADE
--
ALTER TABLE `pedidos`
  ADD CONSTRAINT `pedidos_ibfk_1` FOREIGN KEY (`cpf_cliente`) REFERENCES `usuarios` (`cpf_usuario`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `pedidos_ibfk_2` FOREIGN KEY (`produto_pedido`) REFERENCES `encomenda` (`id_encomenda`) ON DELETE CASCADE ON UPDATE CASCADE;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
