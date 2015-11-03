using System;


namespace Acerto
{
   public class Produto
    {
    public int id { get; set; }
    public string serie{ get; set; }
    public string material { get; set; }
   public DateTime data { get; set; }
    public int tamanho { get; set; }
    public int nota { get; set; }
    public string descricao { get; set; }

    public Produto(int id, string serie, string material, DateTime data, int tamanho, int nota, string descricao)
        {
            this.id = id;
            this.serie = serie;
            this.material = material;
            this.data = data;
            this.tamanho = tamanho;
            this.nota = nota;
            this.descricao = descricao;
        }
    }
}
