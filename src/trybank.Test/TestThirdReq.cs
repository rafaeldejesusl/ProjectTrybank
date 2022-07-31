using Xunit;
using FluentAssertions;
using trybank;
using System;

namespace trybank.Test;

public class TestThirdReq
{
    [Theory(DisplayName = "Deve devolver o saldo em uma conta logada")]
    [InlineData(10)]
    public void TestCheckBalanceSucess(int balance)
    {        
        Trybank instance = new ();
        instance.RegisterAccount(0, 0, 0);
        instance.Login(0, 0, 0);
        instance.Deposit(balance);
        int result = instance.CheckBalance();
        result.Should().Be(balance);
    }

    [Theory(DisplayName = "Deve lançar uma exceção de usuário não logado")]
    [InlineData(0)]
    public void TestCheckBalanceWithoutLogin(int balance)
    {        
        Trybank instance = new ();
        instance.RegisterAccount(0, 0, 0);
        instance.Login(0, 0, 0);
        instance.Deposit(balance);
        instance.Logout();
        Action act = () => instance.CheckBalance();
        act.Should().Throw<AccessViolationException>().WithMessage("Usuário já está logado");
    }

    [Theory(DisplayName = "Deve depositar um saldo em uma conta logada")]
    [InlineData(10)]
    public void TestDepositSucess(int value)
    {        
        Trybank instance = new ();
        instance.RegisterAccount(0, 0, 0);
        instance.Login(0, 0, 0);
        instance.Deposit(value);
        int result = instance.CheckBalance();
        result.Should().Be(value);
    }

    [Theory(DisplayName = "Deve lançar uma exceção de usuário não logado")]
    [InlineData(0)]
    public void TestDepositWithoutLogin(int value)
    {        
        Trybank instance = new ();
        instance.RegisterAccount(0, 0, 0);
        instance.Login(0, 0, 0);
        instance.Logout();
        Action act = () => instance.Deposit(value);
        act.Should().Throw<AccessViolationException>().WithMessage("Usuário já está logado");
    }

    [Theory(DisplayName = "Deve sacar um valor em uma conta logada")]
    [InlineData(10, 7)]
    public void TestWithdrawSucess(int balance, int value)
    {        
        Trybank instance = new ();
        instance.RegisterAccount(0, 0, 0);
        instance.Login(0, 0, 0);
        instance.Deposit(balance);
        instance.Withdraw(value);
        int result = instance.CheckBalance();
        result.Should().Be(balance - value);
    }

    [Theory(DisplayName = "Deve lançar uma exceção de usuário não logado")]
    [InlineData(0)]
    public void TestWithdrawWithoutLogin(int value)
    {        
        Trybank instance = new ();
        instance.RegisterAccount(0, 0, 0);
        instance.Login(0, 0, 0);
        instance.Deposit(value);
        instance.Logout();
        Action act = () => instance.Withdraw(value);
        act.Should().Throw<AccessViolationException>().WithMessage("Usuário já está logado");
    }

    [Theory(DisplayName = "Deve lançar uma exceção de usuário com saldo insuficiente")]
    [InlineData(10, 20)]
    public void TestWithdrawWithoutBalance(int balance, int value)
    {        
        Trybank instance = new ();
        instance.RegisterAccount(0, 0, 0);
        instance.Login(0, 0, 0);
        instance.Deposit(balance);
        Action act = () => instance.Withdraw(value);
        act.Should().Throw<InvalidOperationException>().WithMessage("Saldo insuficiente");
    }
}