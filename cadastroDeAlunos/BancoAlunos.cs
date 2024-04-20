using System.Text;

namespace cadastroDeAlunos
{
    public static class BancoAlunos
    {
        private static int _index = 0;
        private static Alunos[] _estudantes = new Alunos[100];
        public static void adicionaAluno(Alunos aluno)
        {
            _estudantes[_index] = aluno;
            _index++;
        }
        public static Alunos buscaAluno(int indice)
        {
            return (_estudantes[indice]);
        }
        public static int getQuantidade()
        {
            return (_index);
        }
    }
}