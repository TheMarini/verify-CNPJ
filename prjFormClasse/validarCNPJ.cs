using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjClasse27757
{
    public class validarCNPJ
    {
        //Campos
        private string _cnpj;

        //Propriedades
        public string cnpj
        {
            set { _cnpj = value; }
            get { return _cnpj; }
        }

        public bool valido
        {
            get
            {
                Int64 soma = 0;
                string verificador = cnpj.Substring(0, 12);
                int[] multiplicador = { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };

                #region primeiro passo
                for (int i = 0, k = 1; i < verificador.Length; i++, k++)
                {
                    soma += int.Parse(cnpj[i].ToString()) * multiplicador[k];
                }

                if (soma % 11 < 2) { verificador += 0; }
                    else{ verificador += 11 - soma % 11; }
                #endregion

                soma = 0; //zera a soma

                #region segundo passo
                for (int i = 0; i < verificador.Length; i++)
                {
                    soma += int.Parse(verificador[i].ToString()) * multiplicador[i];
                }

                if (soma % 11 < 2) { verificador += 0; }
                    else{ verificador += 11 - soma % 11; }
                #endregion

                //retorno
                if (cnpj == verificador)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        //Construtor
        public validarCNPJ()
        {
            _cnpj = "54728139000185";
        }

        public validarCNPJ(string valor)
        {
            _cnpj = valor;
        }
    }
}
