using System;
using System.Collections.Generic;
using System.Text;

namespace cadastroDeAlunos
{
    public class Alunos
    {
        private static int _id;
        private int _index;
        public int id
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
            _index++;
            _id = _index;
            Nome = nome;
            Turma = turma;
        }
        public override string ToString()
        {
            return ($"Id: {id} Nome do aluno: {Nome} \n turma: {Turma} \n");
        }

    }
}

