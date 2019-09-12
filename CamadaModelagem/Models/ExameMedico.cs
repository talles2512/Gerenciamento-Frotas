using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaModelagem.Models.Enums;

namespace CamadaModelagem.Models
{
    public class ExameMedico //Padrão Pascal case/Camel case, a qual cada palavra inicia com maiúscula
    {
        public DateTime Data { get; set; } //atributos também são Pascal case
        public string Descricao { get; set; }
        public SituacaoExameMedico Situacao { get; set; } //Enum definindo: Pendente ou Realizado
        public Motorista Motorista { get; set; }

        public ExameMedico()
        {

        }

        public ExameMedico(DateTime data, string descricao, SituacaoExameMedico situacao , Motorista motorista) //parâmetros começam com minúsculo, mas também são
        {                                                                                                            //Pascal case
            Data = data;
            Descricao = descricao;
            Situacao = situacao;
            Motorista = motorista;
        }
    }
}
