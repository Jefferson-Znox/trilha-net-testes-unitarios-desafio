using TestesUnitarios.Desafio.Console.Services;

namespace TestesUnitarios.Desafio.Tests;

public class ValidacoesStringTests
{
    private ValidacoesString _validacoes = new ValidacoesString();

    [Fact]
    public void DeveRetornar6QuantidadeCaracteresDaPalavraMatrix()
    {
        //TODO: Variável "texto" e "resultadoEsperado" da seção Arrange, corrigida com sucesso !!!

        // Arrange
        var texto = "abcder";
        var resultadoEsperado = 6;

        // Act
        var resultado = _validacoes.RetornarQuantidadeCaracteres(texto);

        // Assert
        Assert.Equal(resultadoEsperado, resultado);
    }

    [Fact]
    public void DeveContemAPalavraQualquerNoTexto()
    {
        // Arrange
        var texto = "Esse é um texto qualquer";
        var textoProcurado = "qualquer";

        //TODO: Chamada do método "ContemCaractere" da seção Act, corrigida !!!
        // Act
         var resultado = _validacoes.ContemCaractere(texto, textoProcurado);

        // Assert
        //TODO: Assert.True com base no retorno da chamada ao método, corrigida !!!
        Assert.True(resultado);
    }

    [Fact]
    public void NaoDeveConterAPalavraTesteNoTexto()
    {
        // Arrange
        var texto = "Esse é um texto qualquer";
        var textoProcurado = "teste";

        // Act
        var resultado = _validacoes.ContemCaractere(texto, textoProcurado);

        // Assert
        //TODO: Assert.False com base no retorno da chamada ao método, corrigido !!!
        Assert.False(resultado);
    }

    //TODO: Anotação [Fact], corrigida !!!
    [Fact]
    public void TextoDeveTerminarComAPalavraProcurado()
    {
        //TODO: Variável "textoProcurado" seção Arrange, corrigida !!!

        // Arrange
        var texto = "Começo, meio e fim do texto procurado";
        var textoProcurado = "procurado";

        // Act
        var resultado = _validacoes.TextoTerminaCom(texto, textoProcurado);

        // Assert
        Assert.True(resultado);
    }
}
