using WasmSharp.Core;

namespace WasmSharp.CodeGen.Entries;

public abstract class ImportEntry(string moduleName, string fieldName)
{
    public abstract ExternId Kind { get; }
    public readonly string ModuleName = moduleName;
    public readonly string FieldName = fieldName;
}

public class FunctionImportEntry(string moduleName, string fieldName, FunctionTypeEntry ftype)
: ImportEntry(moduleName, fieldName)
{
    public override ExternId Kind => ExternId.Function;
}
public class MemoryImportEntry(string moduleName, string fieldName, uint min, uint max = 0)
: ImportEntry(moduleName, fieldName)
{
    public override ExternId Kind => ExternId.Memory;
    public readonly uint LimitMin = min;
    public readonly uint LimitMax = max;
}
public class GlobalImportEntry(string moduleName, string fieldName, TypeId typeId)
: ImportEntry(moduleName, fieldName)
{
    public override ExternId Kind => ExternId.Global;
    public readonly TypeId TypeId = typeId;
}

