// Decompiled with JetBrains decompiler
// Type: ProjectM.FactionCollectionAsset
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class FactionCollectionAsset : ScriptableObject
  {
    private static readonly IntPtr NativeFieldInfoPtr_Factions;
    private static readonly IntPtr NativeMethodInfoPtr_TryGetIndexOfFaction_Public_Boolean_FactionAsset_byref_Int32_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 723115, XrefRangeEnd = 723120, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGetIndexOfFaction(FactionAsset faction, out int result)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) faction);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref result;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(FactionCollectionAsset.NativeMethodInfoPtr_TryGetIndexOfFaction_Public_Boolean_FactionAsset_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(11)]
    [CachedScanResults(RefRangeStart = 247159, RefRangeEnd = 247170, XrefRangeStart = 247159, XrefRangeEnd = 247170, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe FactionCollectionAsset()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FactionCollectionAsset>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(FactionCollectionAsset.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static FactionCollectionAsset()
    {
      Il2CppClassPointerStore<FactionCollectionAsset>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (FactionCollectionAsset));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FactionCollectionAsset>.NativeClassPtr);
      FactionCollectionAsset.NativeFieldInfoPtr_Factions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FactionCollectionAsset>.NativeClassPtr, nameof (Factions));
      FactionCollectionAsset.NativeMethodInfoPtr_TryGetIndexOfFaction_Public_Boolean_FactionAsset_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FactionCollectionAsset>.NativeClassPtr, 100663907);
      FactionCollectionAsset.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FactionCollectionAsset>.NativeClassPtr, 100663908);
    }

    public FactionCollectionAsset(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Il2CppReferenceArray<FactionAsset> Factions
    {
      get
      {
        IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FactionCollectionAsset.NativeFieldInfoPtr_Factions));
        return nativeObject == IntPtr.Zero ? (Il2CppReferenceArray<FactionAsset>) null : new Il2CppReferenceArray<FactionAsset>(nativeObject);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FactionCollectionAsset.NativeFieldInfoPtr_Factions), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
