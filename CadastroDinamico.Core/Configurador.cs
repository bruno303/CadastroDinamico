﻿using CadastroDinamico.Dominio;
using System;
using CadastroDinamico.Utils;

namespace CadastroDinamico.Core
{
    public class Configurador : IConfigurador
    {
        private const string FILE_NAME = "config.ini";
        private readonly string Path;

        public Configurador()
        {
            Path = AppDomain.CurrentDomain.BaseDirectory;
            if (!Path.EndsWith("\\"))
            {
                Path += "\\";
            }
            Path += FILE_NAME;
        }

        public string AlterarConfiguracao(Configuracao configuracao)
        {
            string retorno = string.Empty;
            string json = string.Empty;

            try
            {
                json = new Json<Configuracao>().ConverterParaJson(configuracao);
                json = new Criptografia().Criptografar(json);
                new Arquivo().EscreverEmArquivo(Path, json, false);
            }
            catch (Exception ex)
            {
                retorno = "Erro ao salvar as configurações. Mensagem: " + ex.Message;
            }

            return retorno;
        }

        public Configuracao RetornarConfiguracao()
        {
            Configuracao configuracao = null;
            Criptografia criptografia = new Criptografia();
            string json = string.Empty;

            try
            {
                Arquivo arquivo = new Arquivo();
                json = arquivo.LerArquivo(Path);
                json = criptografia.Descriptografar(json);
                configuracao = new Json<Configuracao>().ConverterParaObjeto(json);
            }
            catch (Exception)
            {
                configuracao = null;
            }

            return configuracao;
        }

        public bool ConfiguracaoValida()
        {
            return RetornarConfiguracao() != null;
        }
    }
}
