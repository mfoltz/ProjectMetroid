﻿// Decompiled with JetBrains decompiler
// Type: ProjectM.YieldResourcesOnDamageTaken_Editor
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [Serializable]
  public sealed class YieldResourcesOnDamageTaken_Editor : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_DropAsset;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetDropTablePrefabGUID_Public_PrefabGUID_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1008530, XrefRangeEnd = 1008537, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PrefabGUID GetDropTablePrefabGUID()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(YieldResourcesOnDamageTaken_Editor.NativeMethodInfoPtr_GetDropTablePrefabGUID_Public_PrefabGUID_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(PrefabGUID*) IL2CPP.il2cpp_object_unbox(num);
    }

    static YieldResourcesOnDamageTaken_Editor()
    {
      Il2CppClassPointerStore<YieldResourcesOnDamageTaken_Editor>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (YieldResourcesOnDamageTaken_Editor));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<YieldResourcesOnDamageTaken_Editor>.NativeClassPtr);
      YieldResourcesOnDamageTaken_Editor.NativeFieldInfoPtr_DropAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YieldResourcesOnDamageTaken_Editor>.NativeClassPtr, nameof (DropAsset));
      YieldResourcesOnDamageTaken_Editor.NativeMethodInfoPtr_GetDropTablePrefabGUID_Public_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YieldResourcesOnDamageTaken_Editor>.NativeClassPtr, 100678376);
    }

    public YieldResourcesOnDamageTaken_Editor(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public YieldResourcesOnDamageTaken_Editor()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<YieldResourcesOnDamageTaken_Editor>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<YieldResourcesOnDamageTaken_Editor>.NativeClassPtr, data));
    }

    public unsafe DropTableDataAsset DropAsset
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(YieldResourcesOnDamageTaken_Editor.NativeFieldInfoPtr_DropAsset));
        return pointer == System.IntPtr.Zero ? (DropTableDataAsset) null : new DropTableDataAsset(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(YieldResourcesOnDamageTaken_Editor.NativeFieldInfoPtr_DropAsset), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
