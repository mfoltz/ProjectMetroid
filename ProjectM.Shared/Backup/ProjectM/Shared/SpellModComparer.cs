// Decompiled with JetBrains decompiler
// Type: ProjectM.Shared.SpellModComparer
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;

#nullable disable
namespace ProjectM.Shared
{
  [StructLayout(LayoutKind.Explicit)]
  public struct SpellModComparer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__AvailableSpellMods;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_byref_BlobArray_1_SpawnBlobSpellMod_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_SpawnBlobSpellMod_SpawnBlobSpellMod_0;
    [FieldOffset(0)]
    public NativeList<SpawnBlobSpellMod> _AvailableSpellMods;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 799384, XrefRangeEnd = 799394, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SpellModComparer(
      ref BlobArray<SpawnBlobSpellMod> availableSpellMods)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref availableSpellMods;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SpellModComparer.NativeMethodInfoPtr__ctor_Public_Void_byref_BlobArray_1_SpawnBlobSpellMod_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 799394, XrefRangeEnd = 799418, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe int Compare(SpawnBlobSpellMod a, SpawnBlobSpellMod b)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &a;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpellModComparer.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_SpawnBlobSpellMod_SpawnBlobSpellMod_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    static SpellModComparer()
    {
      Il2CppClassPointerStore<SpellModComparer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Shared", nameof (SpellModComparer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpellModComparer>.NativeClassPtr);
      SpellModComparer.NativeFieldInfoPtr__AvailableSpellMods = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellModComparer>.NativeClassPtr, nameof (_AvailableSpellMods));
      SpellModComparer.NativeMethodInfoPtr__ctor_Public_Void_byref_BlobArray_1_SpawnBlobSpellMod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellModComparer>.NativeClassPtr, 100670539);
      SpellModComparer.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_SpawnBlobSpellMod_SpawnBlobSpellMod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellModComparer>.NativeClassPtr, 100670540);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpellModComparer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
