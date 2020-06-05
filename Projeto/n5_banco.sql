-- phpMyAdmin SQL Dump
-- version 4.9.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 29-Jan-2020 às 23:50
-- Versão do servidor: 10.4.11-MariaDB
-- versão do PHP: 7.4.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `n5_banco`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `usuario`
--

CREATE TABLE `usuario` (
  `id_usuario` int(11) NOT NULL,
  `nome_usuario` varchar(50) NOT NULL,
  `usuario_usuario` varchar(50) NOT NULL,
  `senha_usuario` varchar(50) NOT NULL,
  `status_usuario` varchar(50) NOT NULL,
  `obs_usuario` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `usuario`
--

INSERT INTO `usuario` (`id_usuario`, `nome_usuario`, `usuario_usuario`, `senha_usuario`, `status_usuario`, `obs_usuario`) VALUES
(1, 'Administrador do Sistema', 'admin', '123', 'Ativo', 'Sem obs Mano! Manolo'),
(2, 'Asdrubal', 'asdrubal', '123456', 'Inativo', 'Foi alterado essa bagaça'),
(6, 'b', 'b', 'b', 'b', 'b'),
(9, 'Irineu', 'irineu', '123', 'ativo', 'E... que se dane!'),
(10, 'Marcolino', 'marcolino', '123', 'ativo', 'kjakljsd '),
(11, 'yyyy', 'yyy', 'yyy', 'yyy', 'yy'),
(12, 'zzz', 'zzz', 'zzz', 'zzz', 'zz'),
(13, 'zzzzz', 'zzzzz', 'zz', 'zz', 'z'),
(14, 'dfsd', 'cvx', 'xcz', 'zxz', '\\sd'),
(15, 'Hmenon', 'hmenon', '123', 'ativo', '34qdadf'),
(16, 'Bensola', 'bensola', '123', 'ativo', '123asdlkç'),
(17, 'abc', 'abc', '123', '123', '123'),
(18, 'sss', 'aaa', 'ss', 'dd', 'ffff'),
(19, 'vvvvv', 'vvvvv', 'vvvvv', 'vvv', 'xcvxcv'),
(20, 'Lebrosvau', 'lebrosvau', '123', 'ativo', 'klajsdkjasld'),
(21, 'j', 'j', '123', 'ativo', '111'),
(22, 'John Smith', 'John Smith', '123', 'Ativo', ''),
(23, 'Asdrubal 2', 'asdrubal2', '123456', 'Ativo', 'Cadastro novo');

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `usuario`
--
ALTER TABLE `usuario`
  ADD PRIMARY KEY (`id_usuario`),
  ADD UNIQUE KEY `usuario_usuario` (`usuario_usuario`);

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `usuario`
--
ALTER TABLE `usuario`
  MODIFY `id_usuario` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=26;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
