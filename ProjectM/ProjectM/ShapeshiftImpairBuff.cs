// Decompiled with JetBrains decompiler
// Type: ProjectM.ShapeshiftImpairBuff
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using ProjectM.Shared;
using Stunlock.Localization;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ShapeshiftImpairBuff
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_FailKey;
    private static readonly System.IntPtr NativeFieldInfoPtr_Condition;
    [FieldOffset(0)]
    public LocalizationKey FailKey;
    [FieldOffset(16)]
    public BlobAssetReference<ConditionBlob> Condition;

    static ShapeshiftImpairBuff()
    {
      Il2CppClassPointerStore<ShapeshiftImpairBuff>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (ShapeshiftImpairBuff));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShapeshiftImpairBuff>.NativeClassPtr);
      ShapeshiftImpairBuff.NativeFieldInfoPtr_FailKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShapeshiftImpairBuff>.NativeClassPtr, nameof (FailKey));
      ShapeshiftImpairBuff.NativeFieldInfoPtr_Condition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShapeshiftImpairBuff>.NativeClassPtr, nameof (Condition));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ShapeshiftImpairBuff>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
