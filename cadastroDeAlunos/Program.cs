﻿using System;

namespace cadastroDeAlunos
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            string turma;
            Alunos estudante;
            int opcao;
            Console.WriteLine("Bem-vindo ao Sistema escolar.");
            while(true)
            {
                Console.WriteLine("Digite a sua opção \n 1: adicionar um novo aluno. \n 2: buscar um aluno por índice. \n 3: listar todos os alunos cadastrados.");
                opcao = int.Parse(Console.ReadLine());
                switch(opcao)
                {
                    case 1:
                        {
                            Console.WriteLine("Digite o nome do aluno.");
                            nome = Console.ReadLine();
                            Console.WriteLine("Digite a turma do aluno.");
                            turma = Console.ReadLine();
                            estudante = new Alunos(nome, turma);
                            BancoAlunos.adicionaAluno(estudante);
                            Console.WriteLine("Aluno cadastrado.");
                            break;
                        }
                    case 2:
                        {
                            int indice;
                            Console.WriteLine("Digite o índice do aluno que deseja buscar.");
                            indice = int.Parse(Console.ReadLine());
                            Console.WriteLine(BancoAlunos.buscaAluno(indice));
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Construindo.");
                            break;
                        } 
                    default:
                        {
                            Console.WriteLine("Opção inválida.");
                            break;
                        }
                }
            }
        }
    }
}
