// Decompiled with JetBrains decompiler
// Type: ProjectM.Shared.SpellModTierBlob
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
  public struct SpellModTierBlob
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_AvailableSpellMods;
    private static readonly System.IntPtr NativeFieldInfoPtr_UseCustomTierData;
    private static readonly System.IntPtr NativeFieldInfoPtr_CustomTierData;
    private static readonly System.IntPtr NativeMethodInfoPtr_GenerateSpellModSet_Public_SpellModSet_byref_Random_SpellModSetTierData_0;
    [FieldOffset(0)]
    public BlobArray<SpawnBlobSpellMod> AvailableSpellMods;
    [FieldOffset(8)]
    public bool UseCustomTierData;
    [FieldOffset(12)]
    public SpellModSetTierData CustomTierData;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 799383, RefRangeEnd = 799384, XrefRangeStart = 799331, XrefRangeEnd = 799383, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SpellModSet GenerateSpellModSet(ref Unity.Mathematics.Random random, SpellModSetTierData tierData)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref random;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &tierData;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpellModTierBlob.NativeMethodInfoPtr_GenerateSpellModSet_Public_SpellModSet_byref_Random_SpellModSetTierData_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(SpellModSet*) IL2CPP.il2cpp_object_unbox(num);
    }

    static SpellModTierBlob()
    {
      Il2CppClassPointerStore<SpellModTierBlob>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Shared", nameof (SpellModTierBlob));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpellModTierBlob>.NativeClassPtr);
      SpellModTierBlob.NativeFieldInfoPtr_AvailableSpellMods = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellModTierBlob>.NativeClassPtr, nameof (AvailableSpellMods));
      SpellModTierBlob.NativeFieldInfoPtr_UseCustomTierData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellModTierBlob>.NativeClassPtr, nameof (UseCustomTierData));
      SpellModTierBlob.NativeFieldInfoPtr_CustomTierData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellModTierBlob>.NativeClassPtr, nameof (CustomTierData));
      SpellModTierBlob.NativeMethodInfoPtr_GenerateSpellModSet_Public_SpellModSet_byref_Random_SpellModSetTierData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellModTierBlob>.NativeClassPtr, 100670538);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpellModTierBlob>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
