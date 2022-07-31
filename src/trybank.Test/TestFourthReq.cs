using Xunit;
using FluentAssertions;
using trybank;
using System;

namespace trybank.Test;

public class TestFourthReq
{
    [Theory(DisplayName = "Deve transefir um valor com uma conta logada")]
    [InlineData(10, 7)]
    public void TestTransferSucess(int balance, int value)
    {        
        Trybank instance = new ();
        instance.RegisterAccount(0, 0, 0);
        instance.RegisterAccount(1, 1, 1);
        instance.Login(0, 0, 0);
        instance.Deposit(balance);
        instance.Transfer(1, 1, value);
        int result0 = instance.CheckBalance();
        result0.Should().Be(balance - value);
        instance.Logout();
        instance.Login(1, 1, 1);
        int result1 = instance.CheckBalance();
        result1.Should().Be(value);
    }

    [Theory(DisplayName = "Deve lançar uma exceção de usuário não logado")]
    [InlineData(10)]
    public void TestTransferWithoutLogin(int value)
    {        
        Trybank instance = new ();
        instance.RegisterAccount(0, 0, 0);
        instance.Login(0, 0, 0);
        instance.Deposit(value);
        instance.Logout();
        Action act = () => instance.Transfer(1, 1, value);
        act.Should().Throw<AccessViolationException>().WithMessage("Usuário já está logado");
    }

    [Theory(DisplayName = "Deve lançar uma exceção de usuário não logado")]
    [InlineData(10, 20)]
    public void TestTransferWithoutBalance(int balance, int value)
    {        
        Trybank instance = new ();
        instance.RegisterAccount(0, 0, 0);
        instance.Login(0, 0, 0);
        instance.Deposit(balance);
        Action act = () => instance.Transfer(1, 1, value);
        act.Should().Throw<InvalidOperationException>().WithMessage("Saldo insuficiente");
    }
}
