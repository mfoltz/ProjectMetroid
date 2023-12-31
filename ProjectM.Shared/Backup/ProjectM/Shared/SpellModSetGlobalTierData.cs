// Decompiled with JetBrains decompiler
// Type: ProjectM.Shared.SpellModSetGlobalTierData
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Stunlock.Localization;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.Shared
{
  [Serializable]
  [StructLayout(LayoutKind.Explicit)]
  public struct SpellModSetGlobalTierData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Tiers;
    private static readonly System.IntPtr NativeFieldInfoPtr_WeaponTypes;
    private static readonly System.IntPtr NativeFieldInfoPtr_NamePostfixes;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetTierData_Public_Boolean_Int32_byref_SpellModSetTierData_0;
    [FieldOffset(0)]
    public BlobArray<SpellModSetTierData> Tiers;
    [FieldOffset(8)]
    public BlobArray<SpellModWeaponTypeData> WeaponTypes;
    [FieldOffset(16)]
    public BlobArray<LocalizationKey> NamePostfixes;

    [CallerCount(7)]
    [CachedScanResults(RefRangeStart = 799434, RefRangeEnd = 799441, XrefRangeStart = 799430, XrefRangeEnd = 799434, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGetTierData(int tier, out SpellModSetTierData tierData)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &tier;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref tierData;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpellModSetGlobalTierData.NativeMethodInfoPtr_TryGetTierData_Public_Boolean_Int32_byref_SpellModSetTierData_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static SpellModSetGlobalTierData()
    {
      Il2CppClassPointerStore<SpellModSetGlobalTierData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Shared", nameof (SpellModSetGlobalTierData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpellModSetGlobalTierData>.NativeClassPtr);
      SpellModSetGlobalTierData.NativeFieldInfoPtr_Tiers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellModSetGlobalTierData>.NativeClassPtr, nameof (Tiers));
      SpellModSetGlobalTierData.NativeFieldInfoPtr_WeaponTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellModSetGlobalTierData>.NativeClassPtr, nameof (WeaponTypes));
      SpellModSetGlobalTierData.NativeFieldInfoPtr_NamePostfixes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellModSetGlobalTierData>.NativeClassPtr, nameof (NamePostfixes));
      SpellModSetGlobalTierData.NativeMethodInfoPtr_TryGetTierData_Public_Boolean_Int32_byref_SpellModSetTierData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellModSetGlobalTierData>.NativeClassPtr, 100670543);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpellModSetGlobalTierData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
