// Decompiled with JetBrains decompiler
// Type: ProjectM.Shared.SpellModGlobalTierBlobReference
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.Shared
{
  [StructLayout(LayoutKind.Explicit)]
  public struct SpellModGlobalTierBlobReference
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_TierData;
    private static readonly System.IntPtr NativeFieldInfoPtr_SettingType;
    [FieldOffset(0)]
    public BlobAssetReference<SpellModSetGlobalTierData> TierData;
    [FieldOffset(8)]
    public SpellModGlobalTierBlobReference.ModSettingType SettingType;

    static SpellModGlobalTierBlobReference()
    {
      Il2CppClassPointerStore<SpellModGlobalTierBlobReference>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Shared", nameof (SpellModGlobalTierBlobReference));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpellModGlobalTierBlobReference>.NativeClassPtr);
      SpellModGlobalTierBlobReference.NativeFieldInfoPtr_TierData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellModGlobalTierBlobReference>.NativeClassPtr, nameof (TierData));
      SpellModGlobalTierBlobReference.NativeFieldInfoPtr_SettingType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellModGlobalTierBlobReference>.NativeClassPtr, nameof (SettingType));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpellModGlobalTierBlobReference>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public enum ModSettingType
    {
      Jewels_SpellMods,
      LegendaryItems_StatMods,
      LegendaryItems_SpellMods,
    }
  }
}
