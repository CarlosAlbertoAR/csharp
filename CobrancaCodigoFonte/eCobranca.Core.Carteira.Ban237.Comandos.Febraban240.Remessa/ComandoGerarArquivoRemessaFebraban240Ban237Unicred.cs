using eCobranca.Core.Automacao.Febraban240.Comandos.Remessa;

namespace eCobranca.Core.Carteira.Ban237.Comandos.Febraban240.Remessa;

public class ComandoGerarArquivoRemessaFebraban240Ban237Unicred : ComandoGerarArquivoRemessaFebraban240<ComandoGerarHeaderArquivoRemessaFebraban240Ban237Unicred, ComandoGerarLoteArquivoRemessaFebraban240Ban237Unicred, ComandoGerarHeaderLoteRemessaFebraban240Ban237Unicred, ComandoGerarSegmentoPRemessaFebraban240Ban237Unicred, ComandoGerarSegmentoQRemessaFebraban240Ban237Unicred, ComandoGerarSegmentoRRemessaFebraban240Ban237, ComandoGerarTraillerLoteRemessaFebraban240Ban237, ComandoGerarTraillerArquivoRemessaFebraban240Ban237>
{
	public ComandoGerarArquivoRemessaFebraban240Ban237Unicred(CarteiraCobranca carteira)
		: base(carteira)
	{
	}
}
