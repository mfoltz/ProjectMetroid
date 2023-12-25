// Decompiled with JetBrains decompiler
// Type: ProjectM.CastleBuilding.CastleStairs
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.CastleBuilding
{
  [StructLayout(LayoutKind.Explicit)]
  public struct CastleStairs
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_StairsType;
    private static readonly System.IntPtr NativeFieldInfoPtr_Direction;
    [FieldOffset(0)]
    public CastleStairsType StairsType;
    [FieldOffset(4)]
    public CardinalDirection Direction;

    static CastleStairs()
    {
      Il2CppClassPointerStore<CastleStairs>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.CastleBuilding", nameof (CastleStairs));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleStairs>.NativeClassPtr);
      CastleStairs.NativeFieldInfoPtr_StairsType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleStairs>.NativeClassPtr, nameof (StairsType));
      CastleStairs.NativeFieldInfoPtr_Direction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleStairs>.NativeClassPtr, nameof (Direction));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CastleStairs>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
