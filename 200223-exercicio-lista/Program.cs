using System.ComponentModel.DataAnnotations;
using _200223_exercicio_lista;

namespace ExercicioLista
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<Products> estoque = new List<Products>();
            int operation;

            do
            {
                int item;
                operation = menu();
                switch (operation)
                {
                    case 1:
                        InserirItem();
                        PrintEstoque();
                        Console.Write("PressEnter...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        Console.Clear();
                        PrintEstoque();
                        Console.Write("PressEnter...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        item = ProcurarItem();
                        Console.WriteLine(estoque[item].ToString());
                        EditarItem(item);
                        Console.Clear();
                        break;
                    case 4:
                        Console.Clear();
                        item = ProcurarItem();
                        Console.WriteLine(estoque[item].ToString());
                        estoque.Remove(DeleteContact(item));
                        break;
                    case 5:
                        System.Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Opção inválida...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            } while (operation != 5);


            Products DeleteContact(int i)
            {
                return estoque[i];
            }

            int menu()
            {
                int op;
                Console.WriteLine("Escolha a opção\n1- Inserir Item\n2- Mostrar estoque\n3- Editar item\n4- Retirar Item\n5- Sair");
                return op = ReceberInteiro();
            }

            void InserirItem()
            {
                Console.Clear();
                Console.Write("Inserir Itens no estoque:\nNome Item: ");
                string nome1 = Console.ReadLine();
                Console.Write("id Item: ");
                int id1 = ReceberInteiro();
                Console.Write("Quantidade: ");
                int quant1 = ReceberInteiro();
                estoque.Add(new Products(nome1.ToUpper(), id1, quant1));
            }

            int ReceberInteiro()
            {
                int op = 0;
                bool result;
                do
                {
                    try
                    {
                        op = int.Parse(Console.ReadLine());
                        result = true;
                    }
                    catch (Exception ex) { result = false; }
                } while (result == false);
                return op;
            }

            void EditarItem (int item)
            {
                Console.WriteLine("Editar:\n[1]- Nome | [2]- ID | [3]- Quantidade");
                int op = ReceberInteiro();
                switch (op)
                {
                    case 1:
                        Console.Write("Digite o nome: ");
                        string nome = Console.ReadLine();
                        estoque[item].EditNome(nome);
                        break;
                    case 2:
                        Console.Write("Digite o ID: ");
                        int id = ReceberInteiro();
                        estoque[item].EditID(id);
                        break;
                    case 3:
                        Console.Write("Digite a quantidade: ");
                        int quant = ReceberInteiro();
                        estoque[item].EditQuant(quant);
                        break;
                    default:
                        Console.WriteLine("Opção Inválida.");
                        break;
                }
            }

            void PrintEstoque()
            {
                foreach (Products item in estoque)
                {
                    Console.WriteLine(item.ToString());
                }
            }


            int ProcurarItem()
            {
                PrintEstoque();
                Console.Write("Digite o ID do item: ");
                int id = ReceberInteiro();
                Console.Clear();
                for (int i = 0; i < estoque.Count; i++)
                {
                    if (estoque[i].ID == id)
                    {
                        return i;
                    }
                }
                return -1;
            }
        }
    }
}