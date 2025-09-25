using WasmSharp.Core;

namespace WasmSharp.CodeGen.Entries;

public class CodeEntry
{
    public List<(TypeId type, int count)> Locals = [];
    //TODO instructions
}
