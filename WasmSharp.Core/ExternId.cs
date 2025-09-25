namespace WasmSharp.Core;

public enum ExternId: byte
{
    Function = 0x00,
    Table = 0x01,
    Memory = 0x02,
    Global = 0x03,
    Tag = 0x04,
}