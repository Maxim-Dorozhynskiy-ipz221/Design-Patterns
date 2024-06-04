using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface IReporting
{
    int GetUniqueID();
    void PrintIncomeStatement(string productName);
    void PrintExpenseStatement(string productName);
}