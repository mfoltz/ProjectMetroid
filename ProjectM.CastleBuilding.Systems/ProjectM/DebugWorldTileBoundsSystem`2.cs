// Decompiled with JetBrains decompiler
// Type: ProjectM.DebugWorldTileBoundsSystem`2
// Assembly: ProjectM.CastleBuilding.Systems, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DA7B9521-B45B-4FC8-A2B0-77040A5D8FB7
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.CastleBuilding.Systems.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Text;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public class DebugWorldTileBoundsSystem<TDebugWorldTileBounds, TTileTypeTag> : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__DebugQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__TilesQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__PrefabCollectionSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__StringBuilder;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1191227, XrefRangeEnd = 1191251, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DebugWorldTileBoundsSystem<TDebugWorldTileBounds, TTileTypeTag>.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1191251, XrefRangeEnd = 1191323, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DebugWorldTileBoundsSystem<TDebugWorldTileBounds, TTileTypeTag>.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(22)]
    [CachedScanResults(RefRangeStart = 178542, RefRangeEnd = 178564, XrefRangeStart = 178542, XrefRangeEnd = 178564, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe DebugWorldTileBoundsSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugWorldTileBoundsSystem<TDebugWorldTileBounds, TTileTypeTag>>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugWorldTileBoundsSystem<TDebugWorldTileBounds, TTileTypeTag>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(57)]
    [CachedScanResults(RefRangeStart = 262491, RefRangeEnd = 262548, XrefRangeStart = 262491, XrefRangeEnd = 262548, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DebugWorldTileBoundsSystem<TDebugWorldTileBounds, TTileTypeTag>.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static DebugWorldTileBoundsSystem()
    {
      // ISSUE: explicit non-virtual call
      // ISSUE: explicit non-virtual call
      Il2CppClassPointerStore<DebugWorldTileBoundsSystem<TDebugWorldTileBounds, TTileTypeTag>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("ProjectM.CastleBuilding.Systems.dll", "ProjectM", "DebugWorldTileBoundsSystem`2"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TDebugWorldTileBounds>.NativeClassPtr)),
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TTileTypeTag>.NativeClassPtr))
      }))).TypeHandle).value);
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugWorldTileBoundsSystem<TDebugWorldTileBounds, TTileTypeTag>>.NativeClassPtr);
      DebugWorldTileBoundsSystem<TDebugWorldTileBounds, TTileTypeTag>.NativeFieldInfoPtr__DebugQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugWorldTileBoundsSystem<TDebugWorldTileBounds, TTileTypeTag>>.NativeClassPtr, nameof (_DebugQuery));
      DebugWorldTileBoundsSystem<TDebugWorldTileBounds, TTileTypeTag>.NativeFieldInfoPtr__TilesQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugWorldTileBoundsSystem<TDebugWorldTileBounds, TTileTypeTag>>.NativeClassPtr, nameof (_TilesQuery));
      DebugWorldTileBoundsSystem<TDebugWorldTileBounds, TTileTypeTag>.NativeFieldInfoPtr__PrefabCollectionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugWorldTileBoundsSystem<TDebugWorldTileBounds, TTileTypeTag>>.NativeClassPtr, nameof (_PrefabCollectionSystem));
      DebugWorldTileBoundsSystem<TDebugWorldTileBounds, TTileTypeTag>.NativeFieldInfoPtr__StringBuilder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugWorldTileBoundsSystem<TDebugWorldTileBounds, TTileTypeTag>>.NativeClassPtr, nameof (_StringBuilder));
      DebugWorldTileBoundsSystem<TDebugWorldTileBounds, TTileTypeTag>.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugWorldTileBoundsSystem<TDebugWorldTileBounds, TTileTypeTag>>.NativeClassPtr, 100663440);
      DebugWorldTileBoundsSystem<TDebugWorldTileBounds, TTileTypeTag>.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugWorldTileBoundsSystem<TDebugWorldTileBounds, TTileTypeTag>>.NativeClassPtr, 100663441);
      DebugWorldTileBoundsSystem<TDebugWorldTileBounds, TTileTypeTag>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugWorldTileBoundsSystem<TDebugWorldTileBounds, TTileTypeTag>>.NativeClassPtr, 100663442);
      DebugWorldTileBoundsSystem<TDebugWorldTileBounds, TTileTypeTag>.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugWorldTileBoundsSystem<TDebugWorldTileBounds, TTileTypeTag>>.NativeClassPtr, 100663443);
    }

    public DebugWorldTileBoundsSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe EntityQuery _DebugQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugWorldTileBoundsSystem<TDebugWorldTileBounds, TTileTypeTag>.NativeFieldInfoPtr__DebugQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugWorldTileBoundsSystem<TDebugWorldTileBounds, TTileTypeTag>.NativeFieldInfoPtr__DebugQuery)) = value;
      }
    }

    public unsafe EntityQuery _TilesQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugWorldTileBoundsSystem<TDebugWorldTileBounds, TTileTypeTag>.NativeFieldInfoPtr__TilesQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugWorldTileBoundsSystem<TDebugWorldTileBounds, TTileTypeTag>.NativeFieldInfoPtr__TilesQuery)) = value;
      }
    }

    public unsafe PrefabCollectionSystem _PrefabCollectionSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugWorldTileBoundsSystem<TDebugWorldTileBounds, TTileTypeTag>.NativeFieldInfoPtr__PrefabCollectionSystem));
        return pointer == System.IntPtr.Zero ? (PrefabCollectionSystem) null : new PrefabCollectionSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DebugWorldTileBoundsSystem<TDebugWorldTileBounds, TTileTypeTag>.NativeFieldInfoPtr__PrefabCollectionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe StringBuilder _StringBuilder
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugWorldTileBoundsSystem<TDebugWorldTileBounds, TTileTypeTag>.NativeFieldInfoPtr__StringBuilder));
        return pointer == System.IntPtr.Zero ? (StringBuilder) null : new StringBuilder(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DebugWorldTileBoundsSystem<TDebugWorldTileBounds, TTileTypeTag>.NativeFieldInfoPtr__StringBuilder), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
