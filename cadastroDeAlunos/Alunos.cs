﻿using System;
using System.Collections.Generic;
using System.Text;

namespace cadastroDeAlunos
{
    public class Alunos
    {
        private static int id;
        private int _id;
        public int Id
        {
            get
                {
                return (_id);
            }
        }
        public string Nome
        {
            get; set;
        }
        public string Turma
        {
            get; set;
        }
        public Alunos(string nome, string turma)
        {
            id++;
            _id = id;
            Nome = nome;
            Turma = turma;
        }
        public override string ToString()
        {
            return ($"Id: {_id} Nome do aluno: {Nome} \n turma: {Turma} \n");
        }

    }
}

