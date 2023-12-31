// Decompiled with JetBrains decompiler
// Type: ProjectM.Shared.SpellModSetGeneratorBlob
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.Shared
{
  [StructLayout(LayoutKind.Explicit)]
  public struct SpellModSetGeneratorBlob
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_AbilityGroup;
    private static readonly System.IntPtr NativeFieldInfoPtr_Tiers;
    private static readonly System.IntPtr NativeMethodInfoPtr_GenerateSpellModSetComponent_Public_SpellModSetComponent_byref_Random_Int32_SpellModSetTierData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GenerateSpellModSet_Public_SpellModSet_byref_Random_Int32_SpellModSetTierData_0;
    [FieldOffset(0)]
    public PrefabGUID AbilityGroup;
    [FieldOffset(4)]
    public BlobArray<SpellModTierBlob> Tiers;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 799419, RefRangeEnd = 799420, XrefRangeStart = 799418, XrefRangeEnd = 799419, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SpellModSetComponent GenerateSpellModSetComponent(
      ref Unity.Mathematics.Random random,
      int tier,
      SpellModSetTierData tierData)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref random;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &tier;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &tierData;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpellModSetGeneratorBlob.NativeMethodInfoPtr_GenerateSpellModSetComponent_Public_SpellModSetComponent_byref_Random_Int32_SpellModSetTierData_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(SpellModSetComponent*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 799426, RefRangeEnd = 799430, XrefRangeStart = 799420, XrefRangeEnd = 799426, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SpellModSet GenerateSpellModSet(
      ref Unity.Mathematics.Random random,
      int tier,
      SpellModSetTierData tierData)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref random;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &tier;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &tierData;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpellModSetGeneratorBlob.NativeMethodInfoPtr_GenerateSpellModSet_Public_SpellModSet_byref_Random_Int32_SpellModSetTierData_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(SpellModSet*) IL2CPP.il2cpp_object_unbox(num);
    }

    static SpellModSetGeneratorBlob()
    {
      Il2CppClassPointerStore<SpellModSetGeneratorBlob>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Shared", nameof (SpellModSetGeneratorBlob));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpellModSetGeneratorBlob>.NativeClassPtr);
      SpellModSetGeneratorBlob.NativeFieldInfoPtr_AbilityGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellModSetGeneratorBlob>.NativeClassPtr, nameof (AbilityGroup));
      SpellModSetGeneratorBlob.NativeFieldInfoPtr_Tiers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellModSetGeneratorBlob>.NativeClassPtr, nameof (Tiers));
      SpellModSetGeneratorBlob.NativeMethodInfoPtr_GenerateSpellModSetComponent_Public_SpellModSetComponent_byref_Random_Int32_SpellModSetTierData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellModSetGeneratorBlob>.NativeClassPtr, 100670541);
      SpellModSetGeneratorBlob.NativeMethodInfoPtr_GenerateSpellModSet_Public_SpellModSet_byref_Random_Int32_SpellModSetTierData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellModSetGeneratorBlob>.NativeClassPtr, 100670542);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpellModSetGeneratorBlob>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
