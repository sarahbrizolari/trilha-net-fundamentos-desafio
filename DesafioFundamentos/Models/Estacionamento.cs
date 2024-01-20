namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            //IMPLEMENTADO
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine();
            if(veiculos.Contains(placa.ToUpper()))
            {
                Console.WriteLine("Placa do veículo cadastrada. Veículo estacionado. ");
            }
            else
            {
                veiculos.Add(placa.ToUpper());
                Console.WriteLine("Placa do veículo cadastrada. Veículo estacionado.");
            }

        }

        public void RemoverVeiculo()
        {
            //IMPLEMENTADO
            Console.WriteLine("Digite a placa do veículo para remover:");
            string placa = Console.ReadLine();
            
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                //IMPLEMENTADO
                if (int.TryParse(Console.ReadLine(), out int horas))
                {
                   decimal valorTotal = precoInicial + precoPorHora * horas;

                   veiculos.Remove(placa.ToUpper());
                   
                   //IMPLEMENTADO
                   Console.WriteLine($"O Veículo placa: {placa} foi removido e o preço total a pagar é de: {valorTotal}");
                }
                else
                {
                    Console.WriteLine("Entrada inválida para a quantidade de horas.");
                }
            }
        }
           public void ListarVeiculos()
           {
                if (veiculos.Any())
                {
                    Console.WriteLine("Os veículos estacionados são:");
                    //IMPLEMENTADO
                    foreach (var veiculo in veiculos)
                    {
                        Console.WriteLine(veiculo);
                    }
                }
                else
                {
                    Console.WriteLine("Não há veículos estacionados.");
                }
            }
        }
    }
