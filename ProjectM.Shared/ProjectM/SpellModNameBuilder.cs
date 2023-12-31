// Decompiled with JetBrains decompiler
// Type: ProjectM.SpellModNameBuilder
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Shared;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public static class SpellModNameBuilder : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_BuildName_Public_Static_String_GeneratedName_ManagedNameGeneratorData_BlobAssetReference_1_SpellModSetGlobalTierData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_BuildName_Public_Static_String_PrefabGUID_GeneratedName_ManagedDataRegistry_BlobAssetReference_1_SpellModSetGlobalTierData_0;

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 728845, RefRangeEnd = 728848, XrefRangeStart = 728801, XrefRangeEnd = 728845, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe string BuildName(
      GeneratedName generatedName,
      ManagedNameGeneratorData managedSpellSchoolData,
      BlobAssetReference<SpellModSetGlobalTierData> globalSpellModData)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &generatedName;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) managedSpellSchoolData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &globalSpellModData;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(SpellModNameBuilder.NativeMethodInfoPtr_BuildName_Public_Static_String_GeneratedName_ManagedNameGeneratorData_BlobAssetReference_1_SpellModSetGlobalTierData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 728896, RefRangeEnd = 728897, XrefRangeStart = 728848, XrefRangeEnd = 728896, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe string BuildName(
      PrefabGUID spellSchoolPrefabGuid,
      GeneratedName generatedName,
      ManagedDataRegistry managedDataRegistry,
      BlobAssetReference<SpellModSetGlobalTierData> globalSpellModData)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &spellSchoolPrefabGuid;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &generatedName;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) managedDataRegistry));
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &globalSpellModData;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(SpellModNameBuilder.NativeMethodInfoPtr_BuildName_Public_Static_String_PrefabGUID_GeneratedName_ManagedDataRegistry_BlobAssetReference_1_SpellModSetGlobalTierData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    static SpellModNameBuilder()
    {
      Il2CppClassPointerStore<SpellModNameBuilder>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (SpellModNameBuilder));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpellModNameBuilder>.NativeClassPtr);
      SpellModNameBuilder.NativeMethodInfoPtr_BuildName_Public_Static_String_GeneratedName_ManagedNameGeneratorData_BlobAssetReference_1_SpellModSetGlobalTierData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellModNameBuilder>.NativeClassPtr, 100664540);
      SpellModNameBuilder.NativeMethodInfoPtr_BuildName_Public_Static_String_PrefabGUID_GeneratedName_ManagedDataRegistry_BlobAssetReference_1_SpellModSetGlobalTierData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellModNameBuilder>.NativeClassPtr, 100664541);
    }

    public SpellModNameBuilder(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
