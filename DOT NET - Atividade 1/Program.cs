using System;
using System.Collections.Generic;

namespace dotnet___atividade_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int idPaciente = 0;
            int idProcedimento = 0;
            List<Paciente> pacientes = new List<Paciente>();
            do
            {
                Console.WriteLine("\n");
                Console.WriteLine("Seja bem-vindo ao supermercado\nDigite a opção desejada:");
                Console.WriteLine("1 - Cadastrar paciente");
                Console.WriteLine("2 - Pesquisar paciente");
                Console.WriteLine("3 - Cadastrar procedimento");
                Console.WriteLine("4 - Realizar um procedimento");
                Console.WriteLine("5 - Sair");

                int opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.Write("Digite o nome do paciente: ");
                        string nomePaciente = Console.ReadLine();
                        Paciente paciente = new Paciente(nomePaciente, idPaciente);
                        pacientes.Add(paciente);
                        idPaciente++;
                        break;

                    case 2:
                        Boolean encontrado = false;
                        Console.Write("Digite o nome do paciente: ");
                        string nomeParaPesquisar = Console.ReadLine();
                        for (int i = 0; i < pacientes.Count; i++)
                        {
                            if (pacientes[i].Nome.Equals(nomeParaPesquisar))
                            {
                                Console.WriteLine(pacientes[i].Nome);
                                encontrado = true;
                            }

                        }
                        if (!encontrado)
                        {
                            Console.WriteLine("Usuário não encontrado");
                        }
                        break;

                    case 3:
                        Console.Write("Digite o nome do procedimento: ");
                        string nomeProcedimento = Console.ReadLine();
                        Console.Write("Digite o nome do paciente: ");
                        string pacienteProcedimento = Console.ReadLine();
                        Procedimento procedimento = new Procedimento(nomeProcedimento, idProcedimento);
                        for (int i = 0; i < pacientes.Count; i++)
                        {
                            if (pacientes[i].Nome.Equals(pacienteProcedimento))
                            {
                                pacientes[i].Procedimentos.Add(procedimento);
                            }

                        }
                        idProcedimento++;
                        break;

                    case 4:
                        Console.Write("Digite o nome do paciente: ");
                        string pacienteNome = Console.ReadLine();
                        Console.Write("Digite o nome do procedimento: ");
                        string procedimentoNome = Console.ReadLine();
                        for (int i = 0; i < pacientes.Count; i++)
                        {
                            if (pacientes[i].Nome.Equals(pacienteNome))
                            {
                                for (int j = 0; j < pacientes[i].Procedimentos.Count; j++)
                                {
                                    if (pacientes[i].Procedimentos[j].Nome.Equals(procedimentoNome))
                                    {
                                        pacientes[i].Procedimentos[j].Finalizado = true;
                                    }
                                }
                            }

                        }
                        break;

                    case 5:
                        Environment.Exit(0);
                        break;
                }

            } while (true);
        }

    }

}
