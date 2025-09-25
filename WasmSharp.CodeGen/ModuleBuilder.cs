using WasmSharp.CodeGen.Entries;

namespace WasmSharp.CodeGen;

public class ModuleBuilder
{
    private List<CustomSectionBuilder> _customSections = [];
    
    private List<ImportEntry> _Imports = [];
    private List<FunctionTypeEntry> _functions = [];
    private List<CodeEntry > _code = [];

    public void AddCustomSection(CustomSectionBuilder section) => _customSections.Add(section);
}
