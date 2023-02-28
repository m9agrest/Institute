using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum TokenType
{
    Int,
    Long,
    Short,
    Byte,
    Float,
    Double,
    Bool,
    Char,
    String,

    Value,
    Var,


    For,
    If,
    While,
    DoWhile,


    OperatorAssign,
    OperatorAdd,
    OperatorSubtract,
    OperatorMultiply,
    OperatorDivide,

    LogicalEquals,
    LogicalNotEquals,
    LogicalLess,
    LogicalGreat,
    LogicalAnd,
    LogicalOr,
}