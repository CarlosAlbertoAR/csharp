using System;
using System.Diagnostics;
using eCobranca.Core.Automacao.Cnab400.Comandos.Retorno;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;

namespace eCobranca.Core.Carteira.Ban004.Comandos.Cnab400.Retorno;

public class ComandoCarregarDetalheRetornoCnab400Ban004 : ComandoCarregarSegmentoDetalheRetornoCnab400
{
	public ComandoCarregarDetalheRetornoCnab400Ban004()
	{
		Logger.Debug($"Criando comando para processar o SEGMENTO DE DETALHE do retorno CNAB400 do [{EnumCodigoBanco.BANCO_DO_NORDESTE_DO_BRASIL}]...");
	}

	public override void Execute()
	{
		try
		{
			Logger.Debug($"Executando comando para carregar o DETALHE do retorno CNAB400 do [{EnumCodigoBanco.BANCO_DO_NORDESTE_DO_BRASIL}]...");
			base.Segmento.CarregarRegistro(base.LinhaDadosRetorno);
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ModeloBoleto.FalhaExecutandoComandoCarregarTraillerArquivoRetornoCNAB400(EnumCodigoBanco.BANCO_DO_NORDESTE_DO_BRASIL, ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}
}