// See https://aka.ms/new-console-template for more information
using ATM_Example;

/// <summary>
/// Create an ATM that allows a user to deposit & withdraw from their own account, OR charge/pay into another account.
/// Name: Angelo Encarnacion
/// Last Modified: June 27th 2024.
/// </summary>
/// 

// Enter in user info
//      Client Number
//      Pin

// Menu
//      Deposit
//      Withdraw
//      Charge
//      Pay

int AssignRandomClientNumber()
{
    return 0;
}

int MAX_CLIENTS = 25;
BankClient[] clients = new BankClient[MAX_CLIENTS];
List<BankClient> clientList = new List<BankClient>();


clients[0] = new BankClient(1, "Angelo Encarnacion", 4376);
clients[1] = new BankClient(2, "Robbin Law", 1111);

clients[0].DepositMoneyIntoAccount(1000);
clients[0].DisplayBalance();
