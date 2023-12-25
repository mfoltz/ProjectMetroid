// Decompiled with JetBrains decompiler
// Type: ProjectM.CastleBuilding.DyeableCastleObject
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.CastleBuilding
{
  [StructLayout(LayoutKind.Explicit)]
  public struct DyeableCastleObject
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ColorSwatchAssetGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_NumColorChoices;
    private static readonly System.IntPtr NativeFieldInfoPtr_PrevColorIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_ActiveColorIndex;
    [FieldOffset(0)]
    public PrefabGUID ColorSwatchAssetGuid;
    [FieldOffset(4)]
    public byte NumColorChoices;
    [FieldOffset(5)]
    public byte PrevColorIndex;
    [FieldOffset(6)]
    public byte ActiveColorIndex;

    static DyeableCastleObject()
    {
      Il2CppClassPointerStore<DyeableCastleObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.CastleBuilding", nameof (DyeableCastleObject));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DyeableCastleObject>.NativeClassPtr);
      DyeableCastleObject.NativeFieldInfoPtr_ColorSwatchAssetGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DyeableCastleObject>.NativeClassPtr, nameof (ColorSwatchAssetGuid));
      DyeableCastleObject.NativeFieldInfoPtr_NumColorChoices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DyeableCastleObject>.NativeClassPtr, nameof (NumColorChoices));
      DyeableCastleObject.NativeFieldInfoPtr_PrevColorIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DyeableCastleObject>.NativeClassPtr, nameof (PrevColorIndex));
      DyeableCastleObject.NativeFieldInfoPtr_ActiveColorIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DyeableCastleObject>.NativeClassPtr, nameof (ActiveColorIndex));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DyeableCastleObject>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
