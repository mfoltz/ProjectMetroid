// Decompiled with JetBrains decompiler
// Type: ProjectM.FinalizePersistenceLoadSystem
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public class FinalizePersistenceLoadSystem : ComponentSystemGroup
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__LoadedTagQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__PersistenceDebuggingSingleton;
    private static readonly System.IntPtr NativeFieldInfoPtr__ReactToPersistenceLoadedGroup;
    private static readonly System.IntPtr NativeFieldInfoPtr__LoadPersistenceSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__WasLoadedEventEntity;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ProcessLoadedEntities_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1055461, XrefRangeEnd = 1055488, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), FinalizePersistenceLoadSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1055488, XrefRangeEnd = 1055491, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), FinalizePersistenceLoadSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1055491, XrefRangeEnd = 1055500, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), FinalizePersistenceLoadSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1055535, RefRangeEnd = 1055536, XrefRangeStart = 1055500, XrefRangeEnd = 1055535, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ProcessLoadedEntities()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(FinalizePersistenceLoadSystem.NativeMethodInfoPtr_ProcessLoadedEntities_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1055536, XrefRangeEnd = 1055541, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe FinalizePersistenceLoadSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FinalizePersistenceLoadSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(FinalizePersistenceLoadSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), FinalizePersistenceLoadSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static FinalizePersistenceLoadSystem()
    {
      Il2CppClassPointerStore<FinalizePersistenceLoadSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (FinalizePersistenceLoadSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FinalizePersistenceLoadSystem>.NativeClassPtr);
      FinalizePersistenceLoadSystem.NativeFieldInfoPtr__LoadedTagQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalizePersistenceLoadSystem>.NativeClassPtr, nameof (_LoadedTagQuery));
      FinalizePersistenceLoadSystem.NativeFieldInfoPtr__PersistenceDebuggingSingleton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalizePersistenceLoadSystem>.NativeClassPtr, nameof (_PersistenceDebuggingSingleton));
      FinalizePersistenceLoadSystem.NativeFieldInfoPtr__ReactToPersistenceLoadedGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalizePersistenceLoadSystem>.NativeClassPtr, nameof (_ReactToPersistenceLoadedGroup));
      FinalizePersistenceLoadSystem.NativeFieldInfoPtr__LoadPersistenceSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalizePersistenceLoadSystem>.NativeClassPtr, nameof (_LoadPersistenceSystem));
      FinalizePersistenceLoadSystem.NativeFieldInfoPtr__WasLoadedEventEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalizePersistenceLoadSystem>.NativeClassPtr, nameof (_WasLoadedEventEntity));
      FinalizePersistenceLoadSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalizePersistenceLoadSystem>.NativeClassPtr, 100683000);
      FinalizePersistenceLoadSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalizePersistenceLoadSystem>.NativeClassPtr, 100683001);
      FinalizePersistenceLoadSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalizePersistenceLoadSystem>.NativeClassPtr, 100683002);
      FinalizePersistenceLoadSystem.NativeMethodInfoPtr_ProcessLoadedEntities_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalizePersistenceLoadSystem>.NativeClassPtr, 100683003);
      FinalizePersistenceLoadSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalizePersistenceLoadSystem>.NativeClassPtr, 100683004);
      FinalizePersistenceLoadSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalizePersistenceLoadSystem>.NativeClassPtr, 100683005);
    }

    public FinalizePersistenceLoadSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe EntityQuery _LoadedTagQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalizePersistenceLoadSystem.NativeFieldInfoPtr__LoadedTagQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalizePersistenceLoadSystem.NativeFieldInfoPtr__LoadedTagQuery)) = value;
      }
    }

    public unsafe SingletonAccessor<PersistenceDebuggingSingleton> _PersistenceDebuggingSingleton
    {
      get
      {
        return *(SingletonAccessor<PersistenceDebuggingSingleton>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalizePersistenceLoadSystem.NativeFieldInfoPtr__PersistenceDebuggingSingleton));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalizePersistenceLoadSystem.NativeFieldInfoPtr__PersistenceDebuggingSingleton), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SingletonAccessor<PersistenceDebuggingSingleton>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe ReactToPersistenceLoadedGroup _ReactToPersistenceLoadedGroup
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalizePersistenceLoadSystem.NativeFieldInfoPtr__ReactToPersistenceLoadedGroup));
        return pointer == System.IntPtr.Zero ? (ReactToPersistenceLoadedGroup) null : new ReactToPersistenceLoadedGroup(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FinalizePersistenceLoadSystem.NativeFieldInfoPtr__ReactToPersistenceLoadedGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LoadPersistenceSystemV2 _LoadPersistenceSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalizePersistenceLoadSystem.NativeFieldInfoPtr__LoadPersistenceSystem));
        return pointer == System.IntPtr.Zero ? (LoadPersistenceSystemV2) null : new LoadPersistenceSystemV2(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FinalizePersistenceLoadSystem.NativeFieldInfoPtr__LoadPersistenceSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Entity _WasLoadedEventEntity
    {
      get
      {
        return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalizePersistenceLoadSystem.NativeFieldInfoPtr__WasLoadedEventEntity));
      }
      [param: In] set
      {
        *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalizePersistenceLoadSystem.NativeFieldInfoPtr__WasLoadedEventEntity)) = value;
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct KeepDataAfterPersistenceTestSingleton
    {
      static KeepDataAfterPersistenceTestSingleton()
      {
        Il2CppClassPointerStore<FinalizePersistenceLoadSystem.KeepDataAfterPersistenceTestSingleton>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FinalizePersistenceLoadSystem>.NativeClassPtr, nameof (KeepDataAfterPersistenceTestSingleton));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FinalizePersistenceLoadSystem.KeepDataAfterPersistenceTestSingleton>.NativeClassPtr);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FinalizePersistenceLoadSystem.KeepDataAfterPersistenceTestSingleton>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct LoadedFromPersistenceTag
    {
      static LoadedFromPersistenceTag()
      {
        Il2CppClassPointerStore<FinalizePersistenceLoadSystem.LoadedFromPersistenceTag>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FinalizePersistenceLoadSystem>.NativeClassPtr, nameof (LoadedFromPersistenceTag));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FinalizePersistenceLoadSystem.LoadedFromPersistenceTag>.NativeClassPtr);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FinalizePersistenceLoadSystem.LoadedFromPersistenceTag>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
