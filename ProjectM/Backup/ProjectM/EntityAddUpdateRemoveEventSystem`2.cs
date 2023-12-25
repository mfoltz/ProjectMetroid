// Decompiled with JetBrains decompiler
// Type: ProjectM.EntityAddUpdateRemoveEventSystem`2
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public class EntityAddUpdateRemoveEventSystem<TComponent, TCompareComponent> : SystemBase where TCompareComponent : unmanaged
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__Barrier;
    private static readonly System.IntPtr NativeFieldInfoPtr__AddedQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__RemovedQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__LastFrameEventsQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__AddedEventArchetype;
    private static readonly System.IntPtr NativeFieldInfoPtr__RemovedEventArchetype;
    private static readonly System.IntPtr NativeFieldInfoPtr__EnableDebugLogs;
    private static readonly System.IntPtr NativeFieldInfoPtr__DebugSystemName;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MakeEnabledQuery_Protected_Abstract_Virtual_New_EntityQuery_Il2CppStructArray_1_ComponentType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MakeRemovedQuery_Protected_Abstract_Virtual_New_EntityQuery_Il2CppStructArray_1_ComponentType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetBarrier_Protected_Virtual_New_EntityCommandBufferSystem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 994010, XrefRangeEnd = 994038, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), EntityAddUpdateRemoveEventSystem<TComponent, TCompareComponent>.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public virtual unsafe EntityQuery MakeEnabledQuery(
      [Optional] Il2CppStructArray<ComponentType> componentTypes)
    {
      if (componentTypes == null)
        componentTypes = new Il2CppStructArray<ComponentType>(0L);
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentTypes);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), EntityAddUpdateRemoveEventSystem<TComponent, TCompareComponent>.NativeMethodInfoPtr_MakeEnabledQuery_Protected_Abstract_Virtual_New_EntityQuery_Il2CppStructArray_1_ComponentType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public virtual unsafe EntityQuery MakeRemovedQuery(
      [Optional] Il2CppStructArray<ComponentType> componentTypes)
    {
      if (componentTypes == null)
        componentTypes = new Il2CppStructArray<ComponentType>(0L);
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentTypes);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), EntityAddUpdateRemoveEventSystem<TComponent, TCompareComponent>.NativeMethodInfoPtr_MakeRemovedQuery_Protected_Abstract_Virtual_New_EntityQuery_Il2CppStructArray_1_ComponentType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 994038, XrefRangeEnd = 994066, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), EntityAddUpdateRemoveEventSystem<TComponent, TCompareComponent>.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1474)]
    [CachedScanResults(RefRangeStart = 31223, RefRangeEnd = 32697, XrefRangeStart = 31223, XrefRangeEnd = 32697, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe EntityCommandBufferSystem GetBarrier()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), EntityAddUpdateRemoveEventSystem<TComponent, TCompareComponent>.NativeMethodInfoPtr_GetBarrier_Protected_Virtual_New_EntityCommandBufferSystem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (EntityCommandBufferSystem) null : new EntityCommandBufferSystem(pointer);
    }

    [CallerCount(22)]
    [CachedScanResults(RefRangeStart = 178542, RefRangeEnd = 178564, XrefRangeStart = 178542, XrefRangeEnd = 178564, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe EntityAddUpdateRemoveEventSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EntityAddUpdateRemoveEventSystem<TComponent, TCompareComponent>>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EntityAddUpdateRemoveEventSystem<TComponent, TCompareComponent>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(57)]
    [CachedScanResults(RefRangeStart = 262491, RefRangeEnd = 262548, XrefRangeStart = 262491, XrefRangeEnd = 262548, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), EntityAddUpdateRemoveEventSystem<TComponent, TCompareComponent>.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public virtual EntityQuery MakeEnabledQuery(params ComponentType[] componentTypes)
    {
      // ISSUE: explicit non-virtual call
      return __nonvirtual (((EntityAddUpdateRemoveEventSystem<,>) this).MakeEnabledQuery(new Il2CppStructArray<ComponentType>(componentTypes)));
    }

    public virtual EntityQuery MakeRemovedQuery(params ComponentType[] componentTypes)
    {
      // ISSUE: explicit non-virtual call
      return __nonvirtual (((EntityAddUpdateRemoveEventSystem<,>) this).MakeRemovedQuery(new Il2CppStructArray<ComponentType>(componentTypes)));
    }

    static EntityAddUpdateRemoveEventSystem()
    {
      // ISSUE: explicit non-virtual call
      // ISSUE: explicit non-virtual call
      Il2CppClassPointerStore<EntityAddUpdateRemoveEventSystem<TComponent, TCompareComponent>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", "EntityAddUpdateRemoveEventSystem`2"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TComponent>.NativeClassPtr)),
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TCompareComponent>.NativeClassPtr))
      }))).TypeHandle).value);
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntityAddUpdateRemoveEventSystem<TComponent, TCompareComponent>>.NativeClassPtr);
      EntityAddUpdateRemoveEventSystem<TComponent, TCompareComponent>.NativeFieldInfoPtr__Barrier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityAddUpdateRemoveEventSystem<TComponent, TCompareComponent>>.NativeClassPtr, nameof (_Barrier));
      EntityAddUpdateRemoveEventSystem<TComponent, TCompareComponent>.NativeFieldInfoPtr__AddedQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityAddUpdateRemoveEventSystem<TComponent, TCompareComponent>>.NativeClassPtr, nameof (_AddedQuery));
      EntityAddUpdateRemoveEventSystem<TComponent, TCompareComponent>.NativeFieldInfoPtr__RemovedQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityAddUpdateRemoveEventSystem<TComponent, TCompareComponent>>.NativeClassPtr, nameof (_RemovedQuery));
      EntityAddUpdateRemoveEventSystem<TComponent, TCompareComponent>.NativeFieldInfoPtr__LastFrameEventsQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityAddUpdateRemoveEventSystem<TComponent, TCompareComponent>>.NativeClassPtr, nameof (_LastFrameEventsQuery));
      EntityAddUpdateRemoveEventSystem<TComponent, TCompareComponent>.NativeFieldInfoPtr__AddedEventArchetype = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityAddUpdateRemoveEventSystem<TComponent, TCompareComponent>>.NativeClassPtr, nameof (_AddedEventArchetype));
      EntityAddUpdateRemoveEventSystem<TComponent, TCompareComponent>.NativeFieldInfoPtr__RemovedEventArchetype = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityAddUpdateRemoveEventSystem<TComponent, TCompareComponent>>.NativeClassPtr, nameof (_RemovedEventArchetype));
      EntityAddUpdateRemoveEventSystem<TComponent, TCompareComponent>.NativeFieldInfoPtr__EnableDebugLogs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityAddUpdateRemoveEventSystem<TComponent, TCompareComponent>>.NativeClassPtr, nameof (_EnableDebugLogs));
      EntityAddUpdateRemoveEventSystem<TComponent, TCompareComponent>.NativeFieldInfoPtr__DebugSystemName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityAddUpdateRemoveEventSystem<TComponent, TCompareComponent>>.NativeClassPtr, nameof (_DebugSystemName));
      EntityAddUpdateRemoveEventSystem<TComponent, TCompareComponent>.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityAddUpdateRemoveEventSystem<TComponent, TCompareComponent>>.NativeClassPtr, 100676753);
      EntityAddUpdateRemoveEventSystem<TComponent, TCompareComponent>.NativeMethodInfoPtr_MakeEnabledQuery_Protected_Abstract_Virtual_New_EntityQuery_Il2CppStructArray_1_ComponentType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityAddUpdateRemoveEventSystem<TComponent, TCompareComponent>>.NativeClassPtr, 100676754);
      EntityAddUpdateRemoveEventSystem<TComponent, TCompareComponent>.NativeMethodInfoPtr_MakeRemovedQuery_Protected_Abstract_Virtual_New_EntityQuery_Il2CppStructArray_1_ComponentType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityAddUpdateRemoveEventSystem<TComponent, TCompareComponent>>.NativeClassPtr, 100676755);
      EntityAddUpdateRemoveEventSystem<TComponent, TCompareComponent>.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityAddUpdateRemoveEventSystem<TComponent, TCompareComponent>>.NativeClassPtr, 100676756);
      EntityAddUpdateRemoveEventSystem<TComponent, TCompareComponent>.NativeMethodInfoPtr_GetBarrier_Protected_Virtual_New_EntityCommandBufferSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityAddUpdateRemoveEventSystem<TComponent, TCompareComponent>>.NativeClassPtr, 100676757);
      EntityAddUpdateRemoveEventSystem<TComponent, TCompareComponent>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityAddUpdateRemoveEventSystem<TComponent, TCompareComponent>>.NativeClassPtr, 100676758);
      EntityAddUpdateRemoveEventSystem<TComponent, TCompareComponent>.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityAddUpdateRemoveEventSystem<TComponent, TCompareComponent>>.NativeClassPtr, 100676759);
    }

    public EntityAddUpdateRemoveEventSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe EntityCommandBufferSystem _Barrier
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EntityAddUpdateRemoveEventSystem<TComponent, TCompareComponent>.NativeFieldInfoPtr__Barrier));
        return pointer == System.IntPtr.Zero ? (EntityCommandBufferSystem) null : new EntityCommandBufferSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EntityAddUpdateRemoveEventSystem<TComponent, TCompareComponent>.NativeFieldInfoPtr__Barrier), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityQuery _AddedQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EntityAddUpdateRemoveEventSystem<TComponent, TCompareComponent>.NativeFieldInfoPtr__AddedQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EntityAddUpdateRemoveEventSystem<TComponent, TCompareComponent>.NativeFieldInfoPtr__AddedQuery)) = value;
      }
    }

    public unsafe EntityQuery _RemovedQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EntityAddUpdateRemoveEventSystem<TComponent, TCompareComponent>.NativeFieldInfoPtr__RemovedQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EntityAddUpdateRemoveEventSystem<TComponent, TCompareComponent>.NativeFieldInfoPtr__RemovedQuery)) = value;
      }
    }

    public unsafe EntityQuery _LastFrameEventsQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EntityAddUpdateRemoveEventSystem<TComponent, TCompareComponent>.NativeFieldInfoPtr__LastFrameEventsQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EntityAddUpdateRemoveEventSystem<TComponent, TCompareComponent>.NativeFieldInfoPtr__LastFrameEventsQuery)) = value;
      }
    }

    public unsafe EntityArchetype _AddedEventArchetype
    {
      get
      {
        return *(EntityArchetype*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EntityAddUpdateRemoveEventSystem<TComponent, TCompareComponent>.NativeFieldInfoPtr__AddedEventArchetype));
      }
      [param: In] set
      {
        *(EntityArchetype*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EntityAddUpdateRemoveEventSystem<TComponent, TCompareComponent>.NativeFieldInfoPtr__AddedEventArchetype)) = value;
      }
    }

    public unsafe EntityArchetype _RemovedEventArchetype
    {
      get
      {
        return *(EntityArchetype*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EntityAddUpdateRemoveEventSystem<TComponent, TCompareComponent>.NativeFieldInfoPtr__RemovedEventArchetype));
      }
      [param: In] set
      {
        *(EntityArchetype*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EntityAddUpdateRemoveEventSystem<TComponent, TCompareComponent>.NativeFieldInfoPtr__RemovedEventArchetype)) = value;
      }
    }

    public unsafe bool _EnableDebugLogs
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EntityAddUpdateRemoveEventSystem<TComponent, TCompareComponent>.NativeFieldInfoPtr__EnableDebugLogs));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EntityAddUpdateRemoveEventSystem<TComponent, TCompareComponent>.NativeFieldInfoPtr__EnableDebugLogs)) = value;
      }
    }

    public unsafe FixedString32 _DebugSystemName
    {
      get
      {
        return *(FixedString32*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EntityAddUpdateRemoveEventSystem<TComponent, TCompareComponent>.NativeFieldInfoPtr__DebugSystemName));
      }
      [param: In] set
      {
        *(FixedString32*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EntityAddUpdateRemoveEventSystem<TComponent, TCompareComponent>.NativeFieldInfoPtr__DebugSystemName)) = value;
      }
    }

    public struct EntityEvent
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Entity;
      public Entity Entity;

      static EntityEvent()
      {
        // ISSUE: explicit non-virtual call
        // ISSUE: explicit non-virtual call
        Il2CppClassPointerStore<EntityAddUpdateRemoveEventSystem<TComponent, TCompareComponent>.EntityEvent>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EntityAddUpdateRemoveEventSystem<TComponent, TCompareComponent>>.NativeClassPtr, nameof (EntityEvent<>)))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
        {
          Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TComponent>.NativeClassPtr)),
          Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TCompareComponent>.NativeClassPtr))
        }))).TypeHandle).value);
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntityAddUpdateRemoveEventSystem<TComponent, TCompareComponent>.EntityEvent>.NativeClassPtr);
        EntityAddUpdateRemoveEventSystem<TComponent, TCompareComponent>.EntityEvent.NativeFieldInfoPtr_Entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityAddUpdateRemoveEventSystem<TComponent, TCompareComponent>.EntityEvent>.NativeClassPtr, nameof (Entity));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EntityAddUpdateRemoveEventSystem<TComponent, TCompareComponent>.EntityEvent>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    public struct AddedEvent
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Data;
      public TCompareComponent Data;

      static AddedEvent()
      {
        // ISSUE: explicit non-virtual call
        // ISSUE: explicit non-virtual call
        Il2CppClassPointerStore<EntityAddUpdateRemoveEventSystem<TComponent, TCompareComponent>.AddedEvent>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EntityAddUpdateRemoveEventSystem<TComponent, TCompareComponent>>.NativeClassPtr, nameof (AddedEvent<>)))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
        {
          Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TComponent>.NativeClassPtr)),
          Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TCompareComponent>.NativeClassPtr))
        }))).TypeHandle).value);
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntityAddUpdateRemoveEventSystem<TComponent, TCompareComponent>.AddedEvent>.NativeClassPtr);
        EntityAddUpdateRemoveEventSystem<TComponent, TCompareComponent>.AddedEvent.NativeFieldInfoPtr_Data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityAddUpdateRemoveEventSystem<TComponent, TCompareComponent>.AddedEvent>.NativeClassPtr, nameof (Data));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EntityAddUpdateRemoveEventSystem<TComponent, TCompareComponent>.AddedEvent>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    public struct UpdatedEvent
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_PreviousData;
      private static readonly System.IntPtr NativeFieldInfoPtr_NewData;
      public TCompareComponent PreviousData;
      public TCompareComponent NewData;

      static UpdatedEvent()
      {
        // ISSUE: explicit non-virtual call
        // ISSUE: explicit non-virtual call
        Il2CppClassPointerStore<EntityAddUpdateRemoveEventSystem<TComponent, TCompareComponent>.UpdatedEvent>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EntityAddUpdateRemoveEventSystem<TComponent, TCompareComponent>>.NativeClassPtr, nameof (UpdatedEvent<>)))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
        {
          Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TComponent>.NativeClassPtr)),
          Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TCompareComponent>.NativeClassPtr))
        }))).TypeHandle).value);
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntityAddUpdateRemoveEventSystem<TComponent, TCompareComponent>.UpdatedEvent>.NativeClassPtr);
        EntityAddUpdateRemoveEventSystem<TComponent, TCompareComponent>.UpdatedEvent.NativeFieldInfoPtr_PreviousData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityAddUpdateRemoveEventSystem<TComponent, TCompareComponent>.UpdatedEvent>.NativeClassPtr, nameof (PreviousData));
        EntityAddUpdateRemoveEventSystem<TComponent, TCompareComponent>.UpdatedEvent.NativeFieldInfoPtr_NewData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityAddUpdateRemoveEventSystem<TComponent, TCompareComponent>.UpdatedEvent>.NativeClassPtr, nameof (NewData));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EntityAddUpdateRemoveEventSystem<TComponent, TCompareComponent>.UpdatedEvent>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    public struct RemovedEvent
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_PreviousData;
      public TCompareComponent PreviousData;

      static RemovedEvent()
      {
        // ISSUE: explicit non-virtual call
        // ISSUE: explicit non-virtual call
        Il2CppClassPointerStore<EntityAddUpdateRemoveEventSystem<TComponent, TCompareComponent>.RemovedEvent>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EntityAddUpdateRemoveEventSystem<TComponent, TCompareComponent>>.NativeClassPtr, nameof (RemovedEvent<>)))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
        {
          Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TComponent>.NativeClassPtr)),
          Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TCompareComponent>.NativeClassPtr))
        }))).TypeHandle).value);
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntityAddUpdateRemoveEventSystem<TComponent, TCompareComponent>.RemovedEvent>.NativeClassPtr);
        EntityAddUpdateRemoveEventSystem<TComponent, TCompareComponent>.RemovedEvent.NativeFieldInfoPtr_PreviousData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityAddUpdateRemoveEventSystem<TComponent, TCompareComponent>.RemovedEvent>.NativeClassPtr, nameof (PreviousData));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EntityAddUpdateRemoveEventSystem<TComponent, TCompareComponent>.RemovedEvent>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    public struct EventData
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_PreviousData;
      public TCompareComponent PreviousData;

      static EventData()
      {
        // ISSUE: explicit non-virtual call
        // ISSUE: explicit non-virtual call
        Il2CppClassPointerStore<EntityAddUpdateRemoveEventSystem<TComponent, TCompareComponent>.EventData>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EntityAddUpdateRemoveEventSystem<TComponent, TCompareComponent>>.NativeClassPtr, nameof (EventData<>)))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
        {
          Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TComponent>.NativeClassPtr)),
          Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TCompareComponent>.NativeClassPtr))
        }))).TypeHandle).value);
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntityAddUpdateRemoveEventSystem<TComponent, TCompareComponent>.EventData>.NativeClassPtr);
        EntityAddUpdateRemoveEventSystem<TComponent, TCompareComponent>.EventData.NativeFieldInfoPtr_PreviousData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityAddUpdateRemoveEventSystem<TComponent, TCompareComponent>.EventData>.NativeClassPtr, nameof (PreviousData));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EntityAddUpdateRemoveEventSystem<TComponent, TCompareComponent>.EventData>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
