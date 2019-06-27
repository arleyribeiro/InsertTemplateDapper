using System;
using System.Collections.Generic;
using Templates.DataAccess;
using Templates.Domain;
using System.IO;

namespace Templates
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootFolder = "C:\\Users\\Dell\\Desktop\\Templates\\Templates_Prontos\\";
            string connectionString = "";
            TemplateRepository _templateRepository = new TemplateRepository(connectionString);
            var list = PreencheLista();
            foreach(TemplateEntity template in list) {
                string content = File.ReadAllText(rootFolder + template.FileName + ".html");
                var codigo = _templateRepository.Insert(template);
                System.Console.WriteLine("Insert template id: ", codigo);
            }            
        }

        static List<TemplateEntity> PreencheLista() {
            var list = new List<TemplateEntity>();

            list.Add(new TemplateEntity {
                CodTemplate = "APROVADO_EMAIL",
                FileName = "template-pedido-aprovado"
            });
            list.Add(new TemplateEntity{
                CodTemplate = "CANCELADO_EMAIL",
                FileName = "template-pedido-cancelado"
            });
            list.Add(new TemplateEntity{
                CodTemplate = "DISPONIVEL_RET_EMAIL",
                FileName = "template-pedido-disponivel-retirada"
            });
            list.Add(new TemplateEntity{
                CodTemplate = "EM_NEGOCIACAO_EMAIL",
                FileName = "template-pedido-em-negociacao"
            });
            list.Add(new TemplateEntity{
                CodTemplate = "ESTORNO_EMAIL",
                FileName = "template-pedido-estorno"
            });
            list.Add(new TemplateEntity{
                CodTemplate = "PRE_CANCEL_EMAIL",
                FileName = "template-pedido-pre-cancelamento"
            });
            list.Add(new TemplateEntity{
                CodTemplate = "REEMBOLSO_EMAIL",
                FileName = "template-pedido-reembolso"
            });
            list.Add(new TemplateEntity{
                CodTemplate = "REEMBOLSO_CONV_EMAIL",
                FileName = "template-pedido-reembolso-conveniado"
            });
            list.Add(new TemplateEntity{
                CodTemplate = "RETIRADO_EMAIL",
                FileName = "template-pedido-retirado"
            });
            list.Add(new TemplateEntity{
                CodTemplate = "SEM_PAGAMENTO_EMAIL",
                FileName = "template-pedido-sem-pagamento"
            });
            return list;
        }
    }
}
