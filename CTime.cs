using Microsoft.AspNetCore.Components;

namespace Loja.Components.Pages
{
    public class CTime : ComponentBase
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public string Image { get; set; }
        public string DescricaoComp { get; set; }
        public double Preco { get; set; }
       

    }
}