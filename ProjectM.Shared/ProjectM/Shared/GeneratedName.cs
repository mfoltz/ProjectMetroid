// Decompiled with JetBrains decompiler
// Type: ProjectM.Shared.GeneratedName
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.Shared
{
  [StructLayout(LayoutKind.Explicit)]
  public struct GeneratedName
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_RandomNamePrefix;
    private static readonly System.IntPtr NativeFieldInfoPtr_RandomNamePostfix;
    private static readonly System.IntPtr NativeFieldInfoPtr_NameGeneratorPrefixSource;
    private static readonly System.IntPtr NativeFieldInfoPtr_NameGeneratorPostfixSource;
    private static readonly System.IntPtr NativeMethodInfoPtr_BuildName_Public_String_ManagedDataRegistry_BlobAssetReference_1_SpellModSetGlobalTierData_0;
    [FieldOffset(0)]
    public byte RandomNamePrefix;
    [FieldOffset(1)]
    public byte RandomNamePostfix;
    [FieldOffset(4)]
    public PrefabGUID NameGeneratorPrefixSource;
    [FieldOffset(8)]
    public PrefabGUID NameGeneratorPostfixSource;

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 798403, RefRangeEnd = 798407, XrefRangeStart = 798402, XrefRangeEnd = 798403, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe string BuildName(
      ManagedDataRegistry managedDataRegistry,
      BlobAssetReference<SpellModSetGlobalTierData> globalSpellModData)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) managedDataRegistry));
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &globalSpellModData;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(GeneratedName.NativeMethodInfoPtr_BuildName_Public_String_ManagedDataRegistry_BlobAssetReference_1_SpellModSetGlobalTierData_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    static GeneratedName()
    {
      Il2CppClassPointerStore<GeneratedName>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Shared", nameof (GeneratedName));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GeneratedName>.NativeClassPtr);
      GeneratedName.NativeFieldInfoPtr_RandomNamePrefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneratedName>.NativeClassPtr, nameof (RandomNamePrefix));
      GeneratedName.NativeFieldInfoPtr_RandomNamePostfix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneratedName>.NativeClassPtr, nameof (RandomNamePostfix));
      GeneratedName.NativeFieldInfoPtr_NameGeneratorPrefixSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneratedName>.NativeClassPtr, nameof (NameGeneratorPrefixSource));
      GeneratedName.NativeFieldInfoPtr_NameGeneratorPostfixSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneratedName>.NativeClassPtr, nameof (NameGeneratorPostfixSource));
      GeneratedName.NativeMethodInfoPtr_BuildName_Public_String_ManagedDataRegistry_BlobAssetReference_1_SpellModSetGlobalTierData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedName>.NativeClassPtr, 100670388);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GeneratedName>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
