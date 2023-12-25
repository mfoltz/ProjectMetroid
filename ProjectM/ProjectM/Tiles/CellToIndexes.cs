// Decompiled with JetBrains decompiler
// Type: ProjectM.Tiles.CellToIndexes
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Tiles
{
  [StructLayout(LayoutKind.Explicit)]
  public struct CellToIndexes
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_Count;
    [FieldOffset(0)]
    public int Start;
    [FieldOffset(4)]
    public int Count;

    static CellToIndexes()
    {
      Il2CppClassPointerStore<CellToIndexes>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Tiles", nameof (CellToIndexes));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CellToIndexes>.NativeClassPtr);
      CellToIndexes.NativeFieldInfoPtr_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CellToIndexes>.NativeClassPtr, nameof (Start));
      CellToIndexes.NativeFieldInfoPtr_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CellToIndexes>.NativeClassPtr, nameof (Count));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CellToIndexes>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
