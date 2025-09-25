namespace WasmSharp.Core;

public enum TypeId: byte
{
    i32 = 0x7f,
    i64 = 0x7e,
    f32 = 0x7d,
    f64 = 0x7c,
    
    v128 = 0x7b,
    
    funcref = 0x70,
    externref = 0x6f,
    anyref = 0x6f,
    eqref = 0x71,
    i31ref = 0x73,
    dataref = 0x72,
}
