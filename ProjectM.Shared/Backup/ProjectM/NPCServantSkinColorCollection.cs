// Decompiled with JetBrains decompiler
// Type: ProjectM.NPCServantSkinColorCollection
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
  public class NPCServantSkinColorCollection : ScriptableObject
  {
    private static readonly IntPtr NativeFieldInfoPtr_ServantSkinColors;
    private static readonly IntPtr NativeFieldInfoPtr_NonServantColors;
    private static readonly IntPtr NativeFieldInfoPtr_ColorCollectionMode;
    private static readonly IntPtr NativeMethodInfoPtr_Reset_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 746966, XrefRangeEnd = 746978, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NPCServantSkinColorCollection.NativeMethodInfoPtr_Reset_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(11)]
    [CachedScanResults(RefRangeStart = 247159, RefRangeEnd = 247170, XrefRangeStart = 247159, XrefRangeEnd = 247170, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe NPCServantSkinColorCollection()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCServantSkinColorCollection>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NPCServantSkinColorCollection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static NPCServantSkinColorCollection()
    {
      Il2CppClassPointerStore<NPCServantSkinColorCollection>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (NPCServantSkinColorCollection));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCServantSkinColorCollection>.NativeClassPtr);
      NPCServantSkinColorCollection.NativeFieldInfoPtr_ServantSkinColors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCServantSkinColorCollection>.NativeClassPtr, nameof (ServantSkinColors));
      NPCServantSkinColorCollection.NativeFieldInfoPtr_NonServantColors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCServantSkinColorCollection>.NativeClassPtr, nameof (NonServantColors));
      NPCServantSkinColorCollection.NativeFieldInfoPtr_ColorCollectionMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCServantSkinColorCollection>.NativeClassPtr, nameof (ColorCollectionMode));
      NPCServantSkinColorCollection.NativeMethodInfoPtr_Reset_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCServantSkinColorCollection>.NativeClassPtr, 100665763);
      NPCServantSkinColorCollection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCServantSkinColorCollection>.NativeClassPtr, 100665764);
    }

    public NPCServantSkinColorCollection(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Il2CppReferenceArray<ServantSkinColor> ServantSkinColors
    {
      get
      {
        IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NPCServantSkinColorCollection.NativeFieldInfoPtr_ServantSkinColors));
        return nativeObject == IntPtr.Zero ? (Il2CppReferenceArray<ServantSkinColor>) null : new Il2CppReferenceArray<ServantSkinColor>(nativeObject);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NPCServantSkinColorCollection.NativeFieldInfoPtr_ServantSkinColors), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppReferenceArray<GradientCollectionEntry> NonServantColors
    {
      get
      {
        IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NPCServantSkinColorCollection.NativeFieldInfoPtr_NonServantColors));
        return nativeObject == IntPtr.Zero ? (Il2CppReferenceArray<GradientCollectionEntry>) null : new Il2CppReferenceArray<GradientCollectionEntry>(nativeObject);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NPCServantSkinColorCollection.NativeFieldInfoPtr_NonServantColors), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ColorCollectionMode ColorCollectionMode
    {
      get
      {
        return *(ColorCollectionMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NPCServantSkinColorCollection.NativeFieldInfoPtr_ColorCollectionMode));
      }
      [param: In] set
      {
        *(ColorCollectionMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NPCServantSkinColorCollection.NativeFieldInfoPtr_ColorCollectionMode)) = value;
      }
    }
  }
}
