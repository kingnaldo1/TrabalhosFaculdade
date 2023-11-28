using ConstrutorAluno;

Aluno aluno1 = new Aluno("João", 20);
Aluno aluno2 = new Aluno("Maria", 22);
Aluno aluno3 = new Aluno("Pedro", 19);

    Console.WriteLine($"Aluno 1 - Nome: {aluno1.Nome}, Idade: {aluno1.Idade}, RA: {aluno1.RA}");
    Console.WriteLine($"Aluno 2 - Nome: {aluno2.Nome}, Idade: {aluno2.Idade}, RA: {aluno2.RA}");
    Console.WriteLine($"Aluno 3 - Nome: {aluno3.Nome}, Idade: {aluno3.Idade}, RA: {aluno3.RA}");