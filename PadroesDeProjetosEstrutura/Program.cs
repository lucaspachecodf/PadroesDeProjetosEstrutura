using PadroesDeProjetosEstrutura.PadraoAdapter;
using PadroesDeProjetosEstrutura.PadraoBridge;
using PadroesDeProjetosEstrutura.PadraoComposite;
using PadroesDeProjetosEstrutura.PadraoDecorator;
using PadroesDeProjetosEstrutura.PadraoFacade;
using PadroesDeProjetosEstrutura.PadraoFlyweight;
using PadroesDeProjetosEstrutura.PadraoProxy;
using System;

namespace PadroesDeProjetosEstrutura
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Padrao Adapter

            //Personagem lucas = new Personagem();
            //Aviao aviao_de_batalha = new Aviao();
            //IAcao adaptador = new Adapter(aviao_de_batalha);

            //Console.WriteLine("---	CAMINHANDO	---");
            //lucas.Andar("Lucas");
            //lucas.Atirar();
            //Console.WriteLine();

            //Console.WriteLine("---	PEGOU UM AVIÃO NO JOGO	---");
            //adaptador.Andar("Lucas");
            //adaptador.Atirar();
            //Console.ReadKey();

            #endregion

            #region Padrao Flyweight

            //Flyweight flyweight = new Flyweight();
            //string cor = string.Empty;
            //Tartaruga tartaruga;
            //while (true)
            //{
            //    Console.WriteLine();
            //    Console.Write("Qual tartaruga enviar para tela: ");
            //    cor = Console.ReadLine();
            //    tartaruga = flyweight.GetTartaruga(cor);
            //    tartaruga.Mostra(cor);
            //    Console.WriteLine();
            //    Console.WriteLine("------------------------");
            //}

            #endregion

            #region Bridge

            //Bridge bridge = new Bridge();
            //Random random = new Random();
            //void Sortear()
            //{
            //    if (random.Next(2) == 1)
            //        bridge.forma_solicitada = new Forma1();
            //    else
            //        bridge.forma_solicitada = new Forma2();
            //    if (random.Next(1, 3) == 1)
            //        bridge.forma_solicitada.ICor = new PadraoBridge.Verde();
            //    else if (random.Next(1, 3) == 2)
            //        bridge.forma_solicitada.ICor = new PadraoBridge.Laranja();
            //    else
            //        bridge.forma_solicitada.ICor = new Rosa();
            //}

            //Console.WriteLine("Pressione ENTER para enviar uma forma");

            //while (1 > 0)
            //{
            //    ConsoleKeyInfo input = Console.ReadKey();
            //    if (input.KeyChar == 13)
            //        Sortear();

            //    Console.WriteLine();
            //    bridge.ExibeQualFormaEstaDescendoNaTela();
            //}

            #endregion

            #region Padrao Composite

            //Composite mapa = new Composite("MAPA DAS CAVERNAS");
            //Composite caverna1 = new Composite("Caverna 1");
            //caverna1.Adicionar(new FaseJogo("Sub Fase 1"));
            //caverna1.Adicionar(new FaseJogo("Sub Fase 2"));
            //caverna1.Adicionar(new FaseJogo("Sub Fase 3"));
            //Composite caverna2 = new Composite("Caverna 2");
            //caverna2.Adicionar(new FaseJogo("Sub Fase 4"));
            //caverna2.Adicionar(new FaseJogo("Sub Fase 5"));
            //Composite porta_secreta = new Composite("Porta Secreta");

            //porta_secreta.Adicionar(new FaseJogo("Sub Fase Secreta X"));

            //mapa.Adicionar(caverna1);
            //mapa.Adicionar(caverna2);
            //caverna2.Adicionar(porta_secreta);
            //mapa.Mostrar(1);
            //Console.ReadKey();

            #endregion

            #region Padrao Decorator

            //Console.WriteLine(" ### Veste Armadura Padrão ###");
            //MoldeArmadura armadura = new ArmaduraPadrao();
            //Console.WriteLine("Descrição: " + armadura.Descricao.TrimEnd(' ', ','));
            //Console.WriteLine();

            //Console.WriteLine(" ### Incluir Novos Itens na Armadura(Decorar) ###");
            //armadura = new Capacete(armadura);
            //armadura = new Espada(armadura);

            //Console.WriteLine("Descrição: " + armadura.Descricao.TrimEnd(' ', ','));
            //Console.ReadKey();

            #endregion

            #region Padrao Facade

            //Facade facade = new Facade();
            //facade.OperacaoA();
            //facade.OperacaoB();
            //Console.ReadKey();

            #endregion

            #region Padrao Proxy

            //Console.WriteLine("#### Acessando a Fase do Jogo sem o Proxy ####");
            //PadraoProxy.FaseJogo fase = new PadraoProxy.FaseJogo();
            //Console.WriteLine(fase.Jogar());
            //Console.WriteLine();
            //Console.ReadKey();

            ProxyFase proxy = new ProxyFase();
            Console.WriteLine("#### Tentando acessar a fase do jogo com Password incorreto ####");
            Console.WriteLine(proxy.InformarPassword("465"));
            Console.WriteLine(proxy.Jogar());
            Console.WriteLine();

            Console.WriteLine("#### Tentando acessar a fase do jogo com Password correto ####");
            Console.WriteLine(proxy.InformarPassword("123"));
            Console.WriteLine(proxy.Jogar());
            Console.WriteLine();
            Console.ReadKey();

            #endregion
        }
    }
}
