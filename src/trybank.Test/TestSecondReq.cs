using Xunit;
using FluentAssertions;
using trybank;
using System;

namespace trybank.Test;

public class TestSecondReq
{
    [Theory(DisplayName = "Deve logar em uma conta!")]
    [InlineData(0, 0, 0)]
    public void TestLoginSucess(int number, int agency, int pass)
    {        
        Trybank instance = new ();
        instance.RegisterAccount(number, agency, pass);
        instance.Login(number, agency, pass);
        instance.Logged.Should().Be(true);
    }

    [Theory(DisplayName = "Deve retornar exceção ao tentar logar em conta já logada")]
    [InlineData(0, 0, 0)]
    public void TestLoginExceptionLogged(int number, int agency, int pass)
    {        
        Trybank instance = new ();
        instance.RegisterAccount(number, agency, pass);
        instance.Login(number, agency, pass);
        Action act = () => instance.Login(number, agency, pass);
        act.Should().Throw<AccessViolationException>().WithMessage("Usuário já está logado");
    }

    [Theory(DisplayName = "Deve retornar exceção ao errar a senha")]
    [InlineData(0, 0, 0)]
    public void TestLoginExceptionWrongPass(int number, int agency, int pass)
    {        
        Trybank instance = new ();
        instance.RegisterAccount(number, agency, pass);
        Action act = () => instance.Login(number, agency, pass + 1);
        act.Should().Throw<ArgumentException>().WithMessage("Senha incorreta");
    }

    [Theory(DisplayName = "Deve retornar exceção ao digitar conta que não existe")]
    [InlineData(0, 0, 0)]
    public void TestLoginExceptionNotFounded(int number, int agency, int pass)
    {        
        Trybank instance = new ();
        instance.RegisterAccount(number, agency, pass);
        Action act = () => instance.Login(number + 1, agency, pass);
        act.Should().Throw<ArgumentException>().WithMessage("Agência + Conta não encontrada");
    }

    [Theory(DisplayName = "Deve sair de uma conta!")]
    [InlineData(0, 0, 0)]
    public void TestLogoutSucess(int number, int agency, int pass)
    {        
        Trybank instance = new ();
        instance.RegisterAccount(number, agency, pass);
        instance.Login(number, agency, pass);
        instance.Logout();
        instance.Logged.Should().Be(false);
    }

    [Theory(DisplayName = "Deve retornar exceção ao sair quando não está logado")]
    [InlineData(0, 0, 0)]
    public void TestLogoutExceptionNotLogged(int number, int agency, int pass)
    {        
        Trybank instance = new ();
        instance.RegisterAccount(number, agency, pass);
        instance.Login(number, agency, pass);
        instance.Logout();
        Action act = () => instance.Logout();
        act.Should().Throw<AccessViolationException>().WithMessage("Usuário não está logado");
    }

}
