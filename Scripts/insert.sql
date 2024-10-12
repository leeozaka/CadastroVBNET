INSERT INTO UF (Nome) VALUES
('São Paulo'),
('Rio de Janeiro'),
('Minas Gerais'),
('Paraná'),
('Santa Catarina'),
('Rio Grande do Sul');

INSERT INTO Cidade (Nome, IdUF) VALUES
('São Paulo', 1),
('Campinas', 1),
('Rio de Janeiro', 2),
('Belo Horizonte', 3),
('Curitiba', 4),
('Florianópolis', 5),
('Porto Alegre', 6),
('Santos', 1),
('Niterói', 2),
('Juiz de Fora', 3);

INSERT INTO Corretor (Codigo, Nome, CPF) VALUES
('CR001', 'João Silva', '123.456.789-00'),
('CR002', 'Maria Oliveira', '987.654.321-11'),
('CR003', 'Pedro Santos', '456.789.123-22'),
('CR004', 'Ana Pereira', '789.123.456-33'),
('CR005', 'Lucas Almeida', '123.456.789-44'),
('CR006', 'Julia Castro', '987.654.321-55');

INSERT INTO Cliente (Nome, CPF, Endereco, UF, Cidade, Ativo) VALUES
('Pedro Souza', '456.789.123-55', 'Rua A, 123', 1, 1, 1),
('Ana Santos', '789.123.456-88', 'Rua B, 456', 2, 3, 0),
('Lucas Pereira', '123.456.789-22', 'Rua C, 789', 3, 4, 1),
('Maria Almeida', '987.654.321-66', 'Rua D, 101', 4, 5, 1),
('João Castro', '123.456.789-77', 'Rua E, 202', 5, 6, 0),
('Julia Souza', '789.123.456-00', 'Rua F, 303', 6, 7, 1),
('Carlos Silva', '456.789.123-11', 'Rua G, 404', 1, 8, 0),
('Beatriz Oliveira', '789.123.456-22', 'Rua H, 505', 2, 9, 1);

INSERT INTO ClienteXCorretor (IdCorretor, IdCliente) VALUES
('CR001', 1),
('CR002', 2),
('CR001', 3),
('CR003', 4),
('CR004', 5),
('CR005', 6),
('CR006', 7),
('CR002', 8);