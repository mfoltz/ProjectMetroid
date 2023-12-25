// Decompiled with JetBrains decompiler
// Type: ProjectM.YieldResourcesOnPickup_Editor
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
  public sealed class YieldResourcesOnPickup_Editor : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_DropTableAsset;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetDropTablePrefabGUID_Public_PrefabGUID_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1008994, XrefRangeEnd = 1009001, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PrefabGUID GetDropTablePrefabGUID()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(YieldResourcesOnPickup_Editor.NativeMethodInfoPtr_GetDropTablePrefabGUID_Public_PrefabGUID_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(PrefabGUID*) IL2CPP.il2cpp_object_unbox(num);
    }

    static YieldResourcesOnPickup_Editor()
    {
      Il2CppClassPointerStore<YieldResourcesOnPickup_Editor>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (YieldResourcesOnPickup_Editor));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<YieldResourcesOnPickup_Editor>.NativeClassPtr);
      YieldResourcesOnPickup_Editor.NativeFieldInfoPtr_DropTableAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YieldResourcesOnPickup_Editor>.NativeClassPtr, nameof (DropTableAsset));
      YieldResourcesOnPickup_Editor.NativeMethodInfoPtr_GetDropTablePrefabGUID_Public_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YieldResourcesOnPickup_Editor>.NativeClassPtr, 100678424);
    }

    public YieldResourcesOnPickup_Editor(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public YieldResourcesOnPickup_Editor()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<YieldResourcesOnPickup_Editor>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<YieldResourcesOnPickup_Editor>.NativeClassPtr, data));
    }

    public unsafe DropTableDataAsset DropTableAsset
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(YieldResourcesOnPickup_Editor.NativeFieldInfoPtr_DropTableAsset));
        return pointer == System.IntPtr.Zero ? (DropTableDataAsset) null : new DropTableDataAsset(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(YieldResourcesOnPickup_Editor.NativeFieldInfoPtr_DropTableAsset), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
