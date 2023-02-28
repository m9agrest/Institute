using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Block { public TokenType Type; }
public class BlockOperator : Block { public BlockValue Left; public BlockValue Right; }
public class BlockLogical : Block { public BlockValue Left; public BlockValue Right; }

public class BlockValue : Block { public byte Value; public TokenType ValueType; public int Key; }
public class BlockVar : BlockValue { public string Name; public TokenType VarType => ValueType; }

public class BlockFor : Block 
{
    public BlockVar Var;
    public BlockValue Value;
    public List<Block> Blocks;
}