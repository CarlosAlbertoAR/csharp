using eCobranca.Atributos;
using eCobranca.Enumerator;
using eCobranca.Factory;
using eCobranca.Util;

namespace eCobranca.Core.Parametros.Ban021;

public class ParametrosAdicionaisDisponiveisConfiguracaoArquivoRemessaBan021 : ParametrosAdicionaisDisponiveisConfiguracaoArquivoRemessa, IParametrosAdicionaisDisponiveisConfiguracaoArquivoRemessaBan021
{
	public ParametrosAdicionaisDisponiveisConfiguracaoArquivoRemessaBan021()
	{
		parametros.AddRange(EnumUtil.GetEnumByAttributeToParametroConfiguracao<EnumParametrosAdicionaisConfiguracao, AtributoChave>(new AtributoChave(EnumModuloParametrizacao.CONFIGURACAO_REMESSA, EnumCodigoBanco.BANCO_DO_ESTADO_DO_ESPIRITO_SANTO)));
	}

	public ParametroConfiguracao GeraRegistroTransacaoRemessaCnab400()
	{
		return FactoryParametroConfiguracao.CriarParametroConfiguracao(EnumParametrosAdicionaisConfiguracao.REM_GERA_REGISTRO_TRANSACAO_REMESSA_CNAB400);
	}
}
