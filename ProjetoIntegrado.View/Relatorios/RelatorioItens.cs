﻿using System;
// ReSharper disable All

namespace ProjetoIntegrado.View.Relatorios
{
    using Mensagens;

    public class RelatorioItens
    {
        public static void MantemItem(string itemSelecionado)
        {
            try
            {
                var item = (RelatorioEnum)Enum.Parse(typeof(RelatorioEnum), itemSelecionado);

                switch (item)
                {
                    case RelatorioEnum.ListaDeConsultas: ListaDeConsultas(); break;
                    case RelatorioEnum.ConsultasCanceladas: ConsultasCanceladas(); break;
                    case RelatorioEnum.Faturamento: Faturamento(); break;
                }
            }
            catch (Exception) { }
        }

        #region  METODOS ITEM

        private static void ListaDeConsultas() { Mbox.Excecao("ListaDeConsultas"); }

        private static void ConsultasCanceladas() { Mbox.Excecao("ConsultasCanceladas"); }

        private static void Faturamento() { Mbox.Excecao("Faturamento"); }

        #endregion
    }
}