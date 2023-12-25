// Decompiled with JetBrains decompiler
// Type: ProjectM.EntityUpdateEventSystem`2
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
  public class EntityUpdateEventSystem<TComponent, TCompareComponent> : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__Barrier;
    private static readonly System.IntPtr NativeFieldInfoPtr__UpdatedQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__UpdatedEventArchetype;
    private static readonly System.IntPtr NativeFieldInfoPtr__EnableDebugLogs;
    private static readonly System.IntPtr NativeFieldInfoPtr__DebugSystemName;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MakeEnabledQuery_Protected_Abstract_Virtual_New_EntityQuery_Il2CppStructArray_1_ComponentType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetBarrier_Protected_Virtual_New_EntityCommandBufferSystem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 994084, XrefRangeEnd = 994101, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), EntityUpdateEventSystem<TComponent, TCompareComponent>.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), EntityUpdateEventSystem<TComponent, TCompareComponent>.NativeMethodInfoPtr_MakeEnabledQuery_Protected_Abstract_Virtual_New_EntityQuery_Il2CppStructArray_1_ComponentType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 994101, XrefRangeEnd = 994117, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), EntityUpdateEventSystem<TComponent, TCompareComponent>.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1474)]
    [CachedScanResults(RefRangeStart = 31223, RefRangeEnd = 32697, XrefRangeStart = 31223, XrefRangeEnd = 32697, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe EntityCommandBufferSystem GetBarrier()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), EntityUpdateEventSystem<TComponent, TCompareComponent>.NativeMethodInfoPtr_GetBarrier_Protected_Virtual_New_EntityCommandBufferSystem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (EntityCommandBufferSystem) null : new EntityCommandBufferSystem(pointer);
    }

    [CallerCount(22)]
    [CachedScanResults(RefRangeStart = 178542, RefRangeEnd = 178564, XrefRangeStart = 178542, XrefRangeEnd = 178564, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe EntityUpdateEventSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EntityUpdateEventSystem<TComponent, TCompareComponent>>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EntityUpdateEventSystem<TComponent, TCompareComponent>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(57)]
    [CachedScanResults(RefRangeStart = 262491, RefRangeEnd = 262548, XrefRangeStart = 262491, XrefRangeEnd = 262548, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), EntityUpdateEventSystem<TComponent, TCompareComponent>.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public virtual EntityQuery MakeEnabledQuery(params ComponentType[] componentTypes)
    {
      // ISSUE: explicit non-virtual call
      return __nonvirtual (((EntityUpdateEventSystem<,>) this).MakeEnabledQuery(new Il2CppStructArray<ComponentType>(componentTypes)));
    }

    static EntityUpdateEventSystem()
    {
      // ISSUE: explicit non-virtual call
      // ISSUE: explicit non-virtual call
      Il2CppClassPointerStore<EntityUpdateEventSystem<TComponent, TCompareComponent>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", "EntityUpdateEventSystem`2"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TComponent>.NativeClassPtr)),
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TCompareComponent>.NativeClassPtr))
      }))).TypeHandle).value);
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntityUpdateEventSystem<TComponent, TCompareComponent>>.NativeClassPtr);
      EntityUpdateEventSystem<TComponent, TCompareComponent>.NativeFieldInfoPtr__Barrier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityUpdateEventSystem<TComponent, TCompareComponent>>.NativeClassPtr, nameof (_Barrier));
      EntityUpdateEventSystem<TComponent, TCompareComponent>.NativeFieldInfoPtr__UpdatedQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityUpdateEventSystem<TComponent, TCompareComponent>>.NativeClassPtr, nameof (_UpdatedQuery));
      EntityUpdateEventSystem<TComponent, TCompareComponent>.NativeFieldInfoPtr__UpdatedEventArchetype = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityUpdateEventSystem<TComponent, TCompareComponent>>.NativeClassPtr, nameof (_UpdatedEventArchetype));
      EntityUpdateEventSystem<TComponent, TCompareComponent>.NativeFieldInfoPtr__EnableDebugLogs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityUpdateEventSystem<TComponent, TCompareComponent>>.NativeClassPtr, nameof (_EnableDebugLogs));
      EntityUpdateEventSystem<TComponent, TCompareComponent>.NativeFieldInfoPtr__DebugSystemName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityUpdateEventSystem<TComponent, TCompareComponent>>.NativeClassPtr, nameof (_DebugSystemName));
      EntityUpdateEventSystem<TComponent, TCompareComponent>.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityUpdateEventSystem<TComponent, TCompareComponent>>.NativeClassPtr, 100676762);
      EntityUpdateEventSystem<TComponent, TCompareComponent>.NativeMethodInfoPtr_MakeEnabledQuery_Protected_Abstract_Virtual_New_EntityQuery_Il2CppStructArray_1_ComponentType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityUpdateEventSystem<TComponent, TCompareComponent>>.NativeClassPtr, 100676763);
      EntityUpdateEventSystem<TComponent, TCompareComponent>.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityUpdateEventSystem<TComponent, TCompareComponent>>.NativeClassPtr, 100676764);
      EntityUpdateEventSystem<TComponent, TCompareComponent>.NativeMethodInfoPtr_GetBarrier_Protected_Virtual_New_EntityCommandBufferSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityUpdateEventSystem<TComponent, TCompareComponent>>.NativeClassPtr, 100676765);
      EntityUpdateEventSystem<TComponent, TCompareComponent>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityUpdateEventSystem<TComponent, TCompareComponent>>.NativeClassPtr, 100676766);
      EntityUpdateEventSystem<TComponent, TCompareComponent>.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityUpdateEventSystem<TComponent, TCompareComponent>>.NativeClassPtr, 100676767);
    }

    public EntityUpdateEventSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe EntityCommandBufferSystem _Barrier
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EntityUpdateEventSystem<TComponent, TCompareComponent>.NativeFieldInfoPtr__Barrier));
        return pointer == System.IntPtr.Zero ? (EntityCommandBufferSystem) null : new EntityCommandBufferSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EntityUpdateEventSystem<TComponent, TCompareComponent>.NativeFieldInfoPtr__Barrier), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityQuery _UpdatedQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EntityUpdateEventSystem<TComponent, TCompareComponent>.NativeFieldInfoPtr__UpdatedQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EntityUpdateEventSystem<TComponent, TCompareComponent>.NativeFieldInfoPtr__UpdatedQuery)) = value;
      }
    }

    public unsafe EntityArchetype _UpdatedEventArchetype
    {
      get
      {
        return *(EntityArchetype*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EntityUpdateEventSystem<TComponent, TCompareComponent>.NativeFieldInfoPtr__UpdatedEventArchetype));
      }
      [param: In] set
      {
        *(EntityArchetype*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EntityUpdateEventSystem<TComponent, TCompareComponent>.NativeFieldInfoPtr__UpdatedEventArchetype)) = value;
      }
    }

    public unsafe bool _EnableDebugLogs
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EntityUpdateEventSystem<TComponent, TCompareComponent>.NativeFieldInfoPtr__EnableDebugLogs));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EntityUpdateEventSystem<TComponent, TCompareComponent>.NativeFieldInfoPtr__EnableDebugLogs)) = value;
      }
    }

    public unsafe FixedString32 _DebugSystemName
    {
      get
      {
        return *(FixedString32*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EntityUpdateEventSystem<TComponent, TCompareComponent>.NativeFieldInfoPtr__DebugSystemName));
      }
      [param: In] set
      {
        *(FixedString32*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EntityUpdateEventSystem<TComponent, TCompareComponent>.NativeFieldInfoPtr__DebugSystemName)) = value;
      }
    }
  }
}
