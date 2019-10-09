using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaModelagem.Models;

namespace CamadaModelagem.Models
{
    public class Motorista : ItemSeguradoAbstrato
    {
        public string CPF { get; set; }
        public string Name { get; set; }
        public string RG { get; set; }
        public string Endereco { get; set; }
        public DateTime DataNascimento { get; set; }
        public long Telefone { get; set; }
        public long TelefoneContato { get; set; }
        public bool Situacao { get; set; }
        public CNH CNH { get; set; }                                                    //Existe a possibilidade de mudar essa lista para um tipo mais genérico como IEnumerable, ICollection
        public List<ExameMedico> ExamesMedicos { get; set; } = new List<ExameMedico>(); //O motorista pode possuir varios exames,
                                                                                        //portanto ele precisa ter uma lista de exames médicos
        public Motorista()
        {

        }

        public Motorista(string cPF, string name, string rG, string endereco, DateTime dataNascimento, long telefone, long telefoneContato, bool situacao, CNH cNH)  //Mudança da FK para TB_CNH
        {
            CPF = cPF;
            Name = name;
            RG = rG;
            Endereco = endereco;
            DataNascimento = dataNascimento;
            Telefone = telefone;
            TelefoneContato = telefoneContato;
            Situacao = situacao;
            CNH = cNH;
        }

        public void AdicionarExame(ExameMedico exameMedico)
        {
            ExamesMedicos.Add(exameMedico);
        }

        public void RemoverExame(ExameMedico exameMedico)
        {
            ExamesMedicos.Remove(exameMedico);
        }
    }
}
