using Loja.Components.Pages;

namespace Loja.Components.models
{
    public class Produtos
    {
        public static List<CTime> Estoque = new List<CTime>()
        {
            new CTime {
                Id = 1,
                Titulo = "X-Salada",
                Descricao = "Pão Especial, Maionese da Casa, Hambúrguer prensado, Queijo Cheddar, Alface e Tomate.",
                Image = "../img/salada.jpg",
                Preco = 30.99,
                DescricaoComp = "Experimente o nosso incrível X-Salada! Uma explosão de sabores em cada mordida! Começando com o nosso pão especial, leve e macio, você será saudado pelo irresistível aroma da nossa maionese caseira, que se mistura de maneira perfeita com o suculento hambúrguer prensado, garantindo uma textura inigualável. Delicie-se com a cremosidade do queijo Cheddar, derretido delicadamente sobre a carne, enquanto a frescura do crocante alface e dos tomates maduros adiciona uma explosão de frescor. Um clássico reinventado, pronto para conquistar o seu paladar!"

            },
            new CTime {
                Id = 2,
                Titulo = "X-Bacon",
                Descricao = "Pão Especial, Maionese da Casa, Hambúrguer prensado, Queijo Cheddar e Bacon em tiras.",
                Image = "../img/bacon.jpg",
                Preco = 34.99,
                DescricaoComp = "Apresentamos o nosso X-Bacon, uma experiência épica! Pão especial, hambúrguer suculento e maionese da casa criam uma combinação deliciosa. Mas o destaque é o bacon crocante e defumado, complementado pelo queijo Cheddar derretido. Uma sinfonia de sabores que vai deixar você pedindo por mais!"
            },
            new CTime {
                Id = 3,
                Titulo = "Costela",
                Descricao = "Pão e Maionese, Bacon, Hambúrguer de Costela, Queijo Provolone, Molho Barbecue e Cebola Roxa.",
                Image = "../img/costela.jpg",
                Preco = 39.99,
                DescricaoComp = "Apresentando nosso delicioso hambúrguer de Costela! Em um pão macio e generosamente coberto com nossa maionese especial, você encontrará uma combinação de sabores incríveis. O hambúrguer de Costela, suculento e cheio de sabor, é complementado pelo irresistível bacon crocante. E não para por aí - o queijo Provolone derretido adiciona uma camada de cremosidade, enquanto o molho barbecue defumado e a cebola roxa crocante oferecem uma explosão de sabores inigualável. Uma verdadeira festa para os sentidos em cada mordida!"

            },
            new CTime {
                Id = 4,
                Titulo = "Cheeseburguer",
                Descricao = "Pão e Maionese da Casa, Hambúrguer e Queijo Muçarela derretido.",
                Image = "../img/queijo.jpg",
                Preco = 29.99,
                DescricaoComp = "\r\nChatGPT\r\nApresentamos o nosso clássico Cheeseburger! Este favorito atemporal é uma celebração da simplicidade e do sabor autêntico. Começando com o nosso pão macio e aveludado, habilmente coberto com a nossa maionese caseira para uma camada extra de cremosidade. Em seguida, vem o destaque: um suculento hambúrguer, grelhado à perfeição e coberto com queijo Muçarela derretido, que se funde delicadamente com a carne, criando uma experiência de sabor irresistível. Cada mordida é uma sinfonia de texturas e sabores que certamente deixará você desejando mais. Um clássico reinventado para satisfazer todos os paladares!"

            },
            new CTime {
                Id = 5,
                Titulo = "X-Egg",
                Descricao = "Pão Especial, Maionese da Casa, Hambúrguer prensado, Queijo Cheddar, Ovo frito e Bacon em tiras.",
                Image = "../img/ovo.jpg",
                Preco = 37.99,
                DescricaoComp = "\r\nChatGPT\r\nApresentamos nosso X-Egg, um verdadeiro festival de sabores! Com pão especial e maionese da casa, este hambúrguer apresenta um hambúrguer suculento, queijo Cheddar derretido, ovo frito e bacon crocante. Em cada mordida, você desfrutará de uma explosão de texturas e sabores, da cremosidade do queijo à crocância do bacon. Este é o X-Egg que vai conquistar seu paladar em seis linhas de pura delícia!"

            },
        };
    }
}
