using System;
using System.Globalization;

namespace ClassicadorCowboy {

    class Program {

        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            string nicknameCowboy;
            double experienciaJogador;

            Console.WriteLine("Olá, forasteiro! É sempre bom ver carne nova se aventurando por essas bandas. Todos os novos viajantes são bem-vidos, apesar de que os últimos cowboys que passaram por essa cidade remota do Oeste, não tiveram um fim muito gloriso... No mais, desejo a você uma boa jornada! E antes que você seja fuzilado... Ou, melhor... Que eu me esqueça de registrar essa informação de suma importância: Qual é o seu bendito nome, cowboy?");
            nicknameCowboy = Console.ReadLine();
            Console.WriteLine("XP obtido na Jornada: ");
            experienciaJogador = Convert.ToDouble(Console.ReadLine(), CI); //Não se esquecer de colocar o ponto quando for entrar com o número double.

            

                if (experienciaJogador <= 1.000) {

                    Console.WriteLine($"{nicknameCowboy}, seu Xp adquirido foi miseros {experienciaJogador.ToString("F3", CultureInfo.InvariantCulture)}. Bronze\nConsideração final: Já vi carneiros serem menos covardes na hora do abate.");

                }
                else if (experienciaJogador >= 2.001 && experienciaJogador <= 3.000) {

                    Console.WriteLine($"{nicknameCowboy}, seu Xp adquirido foi de apenas {experienciaJogador.ToString("F3", CultureInfo.InvariantCulture)}. Prata\nConsideração final: Um belo exemplo do que não fazer em uma partida PvP.");

                }
                else if (experienciaJogador >= 3.001 && experienciaJogador <= 4.000) {

                    Console.WriteLine($"{nicknameCowboy}, seu Xp adquirido foi de vergonhosos {experienciaJogador.ToString("F3", CultureInfo.InvariantCulture)}. Ouro\nConsideração final: Pratique mais antes de decidir enfrentar um oponente. Ou escolha um adversário de um nível menor... ");

                }
                else if (experienciaJogador >= 4.001 && experienciaJogador <= 5.000) {

                    Console.WriteLine($"{nicknameCowboy}, seu Xp adquirido foi de limitados {experienciaJogador.ToString("F3", CultureInfo.InvariantCulture)}. Diamante\nConsideração final: Nada mal. Jogue e conquiste mais habilidades únicas no modo campanha. ");

                }
                else if (experienciaJogador >= 5.001 && experienciaJogador <= 6.000) {

                    Console.WriteLine($"{nicknameCowboy}, seu Xp adquirido foi de consideráveis {experienciaJogador.ToString("F3", CultureInfo.InvariantCulture)}. Ascendente\nConsideração final: Tem potencial. Se empenhe mais para usar a esquiva/cobertura. Ou melhore suas armas. AVANTE! ");

                }
                else if (experienciaJogador >= 6.001 && experienciaJogador <= 9.000) {

                    Console.WriteLine($"{nicknameCowboy}, seu Xp adquirido foi de imponentes {experienciaJogador.ToString("F3", CultureInfo.InvariantCulture)}. Imortal\nConsideração final: Seu desempenho foi recompesado. Continue conquistando mais pontos para chegar no rank 1 de melhores colocados gerais. ");

                }
                else if (experienciaJogador >= 9.001) {

                    Console.WriteLine($"{nicknameCowboy}, seu Xp adquirido foi de gloriosos {experienciaJogador.ToString("F3", CultureInfo.InvariantCulture)}. Radiante\nConsideração final: Parabéns! Seu esforço o colocou em primeiro lugar do rank. Mantenha ou perca o status de melhor rankeado.  ");


                }
                else {

                    Console.WriteLine();
                }



            }

        }

    }
