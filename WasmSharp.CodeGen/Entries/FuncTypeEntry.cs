using System.Text;
using WasmSharp.Core;

namespace WasmSharp.CodeGen.Entries;

public class FunctionTypeEntry(TypeId[] args, TypeId[] results)
{
    public readonly TypeId[] Arguments = args;
    public readonly TypeId[] Results = results;

    public override string ToString()
    {
        var sb = new StringBuilder();

        sb.Append('(');
        sb.AppendJoin(", ", Arguments);
        sb.Append(") -> ");
        if (Results.Length > 0)
        {
            sb.Append('(');
            sb.AppendJoin(", ", results);
            sb.Append(')');
        }
        else sb.Append("void");
        sb.Append(')');
        
        return sb.ToString();
    }

    public override int GetHashCode()
    {
        var hash = 0x60;
        foreach (var arg in Arguments) hash = HashCode.Combine(hash, (byte)arg);
        foreach (var res in Results) hash = HashCode.Combine(hash, (byte)res);
        return hash;
    }
}
