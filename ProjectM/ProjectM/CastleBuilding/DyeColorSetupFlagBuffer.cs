﻿// Decompiled with JetBrains decompiler
// Type: ProjectM.CastleBuilding.DyeColorSetupFlagBuffer
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.CastleBuilding
{
  [StructLayout(LayoutKind.Explicit)]
  public struct DyeColorSetupFlagBuffer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_SubSwatchAssetEntryIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_SwatchGuidHash;
    private static readonly System.IntPtr NativeFieldInfoPtr_DyeColorSetupFlag;
    private static readonly System.IntPtr NativeFieldInfoPtr_DyeColorSwatchEntryIndex;
    [FieldOffset(0)]
    public int SubSwatchAssetEntryIndex;
    [FieldOffset(4)]
    public int SwatchGuidHash;
    [FieldOffset(8)]
    public int DyeColorSetupFlag;
    [FieldOffset(12)]
    public int DyeColorSwatchEntryIndex;

    static DyeColorSetupFlagBuffer()
    {
      Il2CppClassPointerStore<DyeColorSetupFlagBuffer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.CastleBuilding", nameof (DyeColorSetupFlagBuffer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DyeColorSetupFlagBuffer>.NativeClassPtr);
      DyeColorSetupFlagBuffer.NativeFieldInfoPtr_SubSwatchAssetEntryIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DyeColorSetupFlagBuffer>.NativeClassPtr, nameof (SubSwatchAssetEntryIndex));
      DyeColorSetupFlagBuffer.NativeFieldInfoPtr_SwatchGuidHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DyeColorSetupFlagBuffer>.NativeClassPtr, nameof (SwatchGuidHash));
      DyeColorSetupFlagBuffer.NativeFieldInfoPtr_DyeColorSetupFlag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DyeColorSetupFlagBuffer>.NativeClassPtr, nameof (DyeColorSetupFlag));
      DyeColorSetupFlagBuffer.NativeFieldInfoPtr_DyeColorSwatchEntryIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DyeColorSetupFlagBuffer>.NativeClassPtr, nameof (DyeColorSwatchEntryIndex));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DyeColorSetupFlagBuffer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
