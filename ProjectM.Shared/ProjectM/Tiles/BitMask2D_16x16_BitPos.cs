// Decompiled with JetBrains decompiler
// Type: ProjectM.Tiles.BitMask2D_16x16_BitPos
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Tiles
{
  [StructLayout(LayoutKind.Explicit)]
  public struct BitMask2D_16x16_BitPos
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_SubCellIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_BitIndex;
    [FieldOffset(0)]
    public byte SubCellIndex;
    [FieldOffset(1)]
    public byte BitIndex;

    static BitMask2D_16x16_BitPos()
    {
      Il2CppClassPointerStore<BitMask2D_16x16_BitPos>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Tiles", nameof (BitMask2D_16x16_BitPos));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BitMask2D_16x16_BitPos>.NativeClassPtr);
      BitMask2D_16x16_BitPos.NativeFieldInfoPtr_SubCellIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BitMask2D_16x16_BitPos>.NativeClassPtr, nameof (SubCellIndex));
      BitMask2D_16x16_BitPos.NativeFieldInfoPtr_BitIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BitMask2D_16x16_BitPos>.NativeClassPtr, nameof (BitIndex));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BitMask2D_16x16_BitPos>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
