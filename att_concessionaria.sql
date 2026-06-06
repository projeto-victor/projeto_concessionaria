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
-- Base de Dados: `att_confeitaria`
--
CREATE DATABASE IF NOT EXISTS `att_concessionaria` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
USE `att_concessionaria`;

-- --------------------------------------------------------

--
-- Estrutura da tabela `balcao`
--
CREATE TABLE IF NOT EXISTS `balcao` (
  `id_balcao` int(11) NOT NULL AUTO_INCREMENT,
  `produto_balcao` varchar(70) NOT NULL,
  `tipo_balcao` varchar(30) NOT NULL,
  `qtde_balcao` int(11) NOT NULL,
  `valor_balcao` int(11) NOT NULL,
  PRIMARY KEY (`id_balcao`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=7 ;

--


-- --------------------------------------------------------




-- Estrutura da tabela `encomenda`
--

CREATE TABLE IF NOT EXISTS `encomenda` (
  `id_encomenda` int(11) NOT NULL AUTO_INCREMENT,
  `produto_encomenda` varchar(70) NOT NULL,
  `tipo_encomenda` varchar(30) NOT NULL,
  `valor_encomenda` int(11) NOT NULL,
  `foto_encomenda` varchar(255) NOT NULL,
  PRIMARY KEY (`id_encomenda`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=16 ;

--
-- Extraindo dados da tabela `encomenda`
--

INSERT INTO `encomenda` (`id_encomenda`, `produto_encomenda`, `tipo_encomenda`, `valor_encomenda`, `foto_encomenda`) VALUES
(3, 'carro feminino', 'BOLO', 35, 'D:/projeto_concessionaria (APP_NET)V/bin/Debug/Fotos/carro_de_muie.jpg'),
(4, 'Bolo de Coco', 'BOLO', 40, 'D:/projeto_concessionaria (APP_NET)V/bin/Debug/Fotos/bolo_coco.jpg'),
(6, 'Bolo de Ameixa', 'BOLO', 140, 'D:/projeto_concessionaria (APP_NET)V/bin/Debug/Fotos/Bolo-de-Ameixa.jpg'),
(7, 'Bolo M&M', 'BOLO', 170, 'D:/projeto_concessionaria (APP_NET)V/bin/Debug/Fotos/bolo_mm.jpeg'),
(8, 'Bolo de Banana', 'BOLO', 110, 'D:/projeto_concessionaria (APP_NET)V/bin/Debug/Fotos/bolo_de_banana.jpeg'),
(9, 'Bolo de Morango', 'BOLO', 150, 'D:/projeto_concessionaria (APP_NET)V/bin/Debug/Fotos/bolo_morango.jpg'),
(10, 'Bolo de Sonho', 'BOLO', 175, 'D:/projeto_concessionaria (APP_NET)V/bin/Debug/Fotos/bolo_de_sonho.jpg'),
(11, 'Sonho de Creme', 'VARIADOS', 30, 'D:/projeto_concessionaria (APP_NET)V/bin/Debug/Fotos/sonho_creme.jpeg'),
(12, 'Torta de Limao', 'TORTA', 80, 'D:/projeto_concessionaria (APP_NET)V/bin/Debug/Fotos/torta_limao.png'),
(14, 'Donut SpringField', 'DONUT', 60, 'D:/projeto_concessionaria (APP_NET)V/bin/Debug/Fotos/donuts_springfield.jpg'),
(15, 'Torta de morango', 'TORTA', 40, 'E:/projeto_concessionaria (APP_NET)V/bin/Debug/Fotos/torta-de-morango.jpg');
-- --------------------------------------------------------

--
-- Estrutura da tabela `estoque_ingred`
--

CREATE TABLE IF NOT EXISTS `estoque_ingred` (
  `id_ingrediente` int(11) NOT NULL AUTO_INCREMENT,
  `nome_ingrediente` varchar(70) NOT NULL,
  `qtd_ingrediente` int(10) NOT NULL,
  PRIMARY KEY (`id_ingrediente`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=12 ;

--
-- Extraindo dados da tabela `estoque_ingred`
--

INSERT INTO `estoque_ingred` (`id_ingrediente`, `nome_ingrediente`, `qtd_ingrediente`) VALUES
(1, 'Cenoura', 14),
(2, 'Chocolate', 45),
(3, 'Ovo', 504),
(4, 'Farinha', 200),
(6, 'manteiga', 200),
(7, 'Morango', 70),
(8, 'Ameixa', 30),
(9, 'Leite', 30),
(10, 'Oleo', 58),
(11, 'M&M', 80);

-- --------------------------------------------------------

--
-- Estrutura da tabela `pedidos`
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
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=17 ;

--
-- Extraindo dados da tabela `pedidos`
--

INSERT INTO `pedidos` (`id_pedidos`, `cpf_cliente`, `produto_pedido`, `valor_pedido`, `qtde`, `data_pedido`, `concluido`) VALUES
(1, '666.666.666-66', 3, 90, 3, '18/11/2025', 'ENTREGUE'),
(2, '666.666.666-66', 3, 60, 2, '19/11/2025', 'ENTREGUE'),
(3, '999.999.999-99', 4, 200, 5, '19/11/2025', 'ENTREGUE'),
(4, '999.999.999-99', 3, 30, 1, '19/11/2025', 'ENTREGUE'),
(5, '999.999.999-99', 4, 120, 3, '19/11/2025', 'ENTREGUE'),
(6, '999.999.999-99', 3, 60, 2, '19/11/2025', 'ENTREGUE'),
(7, '999.999.999-99', 3, 150, 5, '19/11/2025', 'ENTREGUE'),
(8, '666.666.666-66', 4, 80, 2, '19/11/2025', 'ENTREGUE'),
(9, '666.666.666-66', 3, 90, 3, '19/11/2025', 'ENTREGUE'),
(10, '100.000.000-00', 9, 450, 3, '27/11/2025', 'ENTREGUE'),
(11, '444.444.444-44', 14, 540, 9, '01/12/2025', 'ENTREGUE'),
(12, '444.444.444-44', 10, 510, 3, '01/12/2025', 'ENTREGUE'),
(13, '100.000.000-00', 12, 1600, 20, '01/12/2025', 'PRONTO'),
(14, '100.000.000-00', 7, 340, 2, '01/12/2025', 'PRONTO'),
(15, '100.000.000-00', 3, 60, 2, '01/12/2025', 'ENTREGUE'),
(16, '202.020.202-02', 8, 440, 4, '04/12/2025', 'ENTREGUE');


-- --------------------------------------------------------

--
-- Estrutura da tabela `usuarios`
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
-- Extraindo dados da tabela `usuarios`
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
-- Constraints for dumped tables
--

--
-- Limitadores para a tabela `pedidos`
--
ALTER TABLE `pedidos`
  ADD CONSTRAINT `pedidos_ibfk_1` FOREIGN KEY (`cpf_cliente`) REFERENCES `usuarios` (`cpf_usuario`),
  ADD CONSTRAINT `pedidos_ibfk_2` FOREIGN KEY (`produto_pedido`) REFERENCES `encomenda` (`id_encomenda`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
