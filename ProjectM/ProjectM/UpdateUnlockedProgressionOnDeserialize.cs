// Decompiled with JetBrains decompiler
// Type: ProjectM.UpdateUnlockedProgressionOnDeserialize
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Network;
using ProjectM.Shared;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Profiling;

#nullable disable
namespace ProjectM
{
  public class UpdateUnlockedProgressionOnDeserialize : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__PrefabCollectionSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__ProgressionDependencySystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__LocalUserAccessor;
    private static readonly System.IntPtr NativeFieldInfoPtr__LocalUserQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__UnlockedProgressionElementQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___UpdateUnlockedProgressionOnDeserialize_UserChanged_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___UpdateUnlockedProgressionOnDeserialize_UserChanged_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___UpdateUnlockedProgressionOnDeserialize_ProgressionChanged_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___UpdateUnlockedProgressionOnDeserialize_ProgressionChanged_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForUpdateUnlockedProgressionOnDeserialize_UserChanged_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForUpdateUnlockedProgressionOnDeserialize_ProgressionChanged_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_1;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1030490, XrefRangeEnd = 1030504, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UpdateUnlockedProgressionOnDeserialize.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1030504, XrefRangeEnd = 1030549, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UpdateUnlockedProgressionOnDeserialize.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe UpdateUnlockedProgressionOnDeserialize()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UpdateUnlockedProgressionOnDeserialize>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UpdateUnlockedProgressionOnDeserialize.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1030549, XrefRangeEnd = 1030583, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UpdateUnlockedProgressionOnDeserialize.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1030608, RefRangeEnd = 1030609, XrefRangeStart = 1030583, XrefRangeEnd = 1030608, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForUpdateUnlockedProgressionOnDeserialize_UserChanged_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UpdateUnlockedProgressionOnDeserialize.NativeMethodInfoPtr___GetEntityQuery_ForUpdateUnlockedProgressionOnDeserialize_UserChanged_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1030631, RefRangeEnd = 1030632, XrefRangeStart = 1030609, XrefRangeEnd = 1030631, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForUpdateUnlockedProgressionOnDeserialize_ProgressionChanged_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UpdateUnlockedProgressionOnDeserialize.NativeMethodInfoPtr___GetEntityQuery_ForUpdateUnlockedProgressionOnDeserialize_ProgressionChanged_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1030636, RefRangeEnd = 1030637, XrefRangeStart = 1030632, XrefRangeEnd = 1030636, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UpdateUnlockedProgressionOnDeserialize.NativeMethodInfoPtr_Method_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1030641, RefRangeEnd = 1030642, XrefRangeStart = 1030637, XrefRangeEnd = 1030641, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_1()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UpdateUnlockedProgressionOnDeserialize.NativeMethodInfoPtr_Method_Public_Static_Void_1, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static UpdateUnlockedProgressionOnDeserialize()
    {
      Il2CppClassPointerStore<UpdateUnlockedProgressionOnDeserialize>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (UpdateUnlockedProgressionOnDeserialize));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpdateUnlockedProgressionOnDeserialize>.NativeClassPtr);
      UpdateUnlockedProgressionOnDeserialize.NativeFieldInfoPtr__PrefabCollectionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateUnlockedProgressionOnDeserialize>.NativeClassPtr, nameof (_PrefabCollectionSystem));
      UpdateUnlockedProgressionOnDeserialize.NativeFieldInfoPtr__ProgressionDependencySystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateUnlockedProgressionOnDeserialize>.NativeClassPtr, nameof (_ProgressionDependencySystem));
      UpdateUnlockedProgressionOnDeserialize.NativeFieldInfoPtr__LocalUserAccessor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateUnlockedProgressionOnDeserialize>.NativeClassPtr, nameof (_LocalUserAccessor));
      UpdateUnlockedProgressionOnDeserialize.NativeFieldInfoPtr__LocalUserQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateUnlockedProgressionOnDeserialize>.NativeClassPtr, nameof (_LocalUserQuery));
      UpdateUnlockedProgressionOnDeserialize.NativeFieldInfoPtr__UnlockedProgressionElementQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateUnlockedProgressionOnDeserialize>.NativeClassPtr, nameof (_UnlockedProgressionElementQuery));
      UpdateUnlockedProgressionOnDeserialize.NativeFieldInfoPtr___UpdateUnlockedProgressionOnDeserialize_UserChanged_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateUnlockedProgressionOnDeserialize>.NativeClassPtr, "<>UpdateUnlockedProgressionOnDeserialize_UserChanged_entityQuery");
      UpdateUnlockedProgressionOnDeserialize.NativeFieldInfoPtr___UpdateUnlockedProgressionOnDeserialize_UserChanged_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateUnlockedProgressionOnDeserialize>.NativeClassPtr, "<>UpdateUnlockedProgressionOnDeserialize_UserChanged_profilerMarker");
      UpdateUnlockedProgressionOnDeserialize.NativeFieldInfoPtr___UpdateUnlockedProgressionOnDeserialize_ProgressionChanged_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateUnlockedProgressionOnDeserialize>.NativeClassPtr, "<>UpdateUnlockedProgressionOnDeserialize_ProgressionChanged_entityQuery");
      UpdateUnlockedProgressionOnDeserialize.NativeFieldInfoPtr___UpdateUnlockedProgressionOnDeserialize_ProgressionChanged_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateUnlockedProgressionOnDeserialize>.NativeClassPtr, "<>UpdateUnlockedProgressionOnDeserialize_ProgressionChanged_profilerMarker");
      UpdateUnlockedProgressionOnDeserialize.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateUnlockedProgressionOnDeserialize>.NativeClassPtr, 100680388);
      UpdateUnlockedProgressionOnDeserialize.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateUnlockedProgressionOnDeserialize>.NativeClassPtr, 100680389);
      UpdateUnlockedProgressionOnDeserialize.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateUnlockedProgressionOnDeserialize>.NativeClassPtr, 100680390);
      UpdateUnlockedProgressionOnDeserialize.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateUnlockedProgressionOnDeserialize>.NativeClassPtr, 100680391);
      UpdateUnlockedProgressionOnDeserialize.NativeMethodInfoPtr___GetEntityQuery_ForUpdateUnlockedProgressionOnDeserialize_UserChanged_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateUnlockedProgressionOnDeserialize>.NativeClassPtr, 100680392);
      UpdateUnlockedProgressionOnDeserialize.NativeMethodInfoPtr___GetEntityQuery_ForUpdateUnlockedProgressionOnDeserialize_ProgressionChanged_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateUnlockedProgressionOnDeserialize>.NativeClassPtr, 100680393);
      UpdateUnlockedProgressionOnDeserialize.NativeMethodInfoPtr_Method_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateUnlockedProgressionOnDeserialize>.NativeClassPtr, 100680394);
      UpdateUnlockedProgressionOnDeserialize.NativeMethodInfoPtr_Method_Public_Static_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateUnlockedProgressionOnDeserialize>.NativeClassPtr, 100680395);
    }

    public UpdateUnlockedProgressionOnDeserialize(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe PrefabCollectionSystem _PrefabCollectionSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdateUnlockedProgressionOnDeserialize.NativeFieldInfoPtr__PrefabCollectionSystem));
        return pointer == System.IntPtr.Zero ? (PrefabCollectionSystem) null : new PrefabCollectionSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UpdateUnlockedProgressionOnDeserialize.NativeFieldInfoPtr__PrefabCollectionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ProgressionDependencySystem _ProgressionDependencySystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdateUnlockedProgressionOnDeserialize.NativeFieldInfoPtr__ProgressionDependencySystem));
        return pointer == System.IntPtr.Zero ? (ProgressionDependencySystem) null : new ProgressionDependencySystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UpdateUnlockedProgressionOnDeserialize.NativeFieldInfoPtr__ProgressionDependencySystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SingletonAccessor<LocalUser> _LocalUserAccessor
    {
      get
      {
        return *(SingletonAccessor<LocalUser>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdateUnlockedProgressionOnDeserialize.NativeFieldInfoPtr__LocalUserAccessor));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdateUnlockedProgressionOnDeserialize.NativeFieldInfoPtr__LocalUserAccessor), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SingletonAccessor<LocalUser>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe EntityQuery _LocalUserQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdateUnlockedProgressionOnDeserialize.NativeFieldInfoPtr__LocalUserQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdateUnlockedProgressionOnDeserialize.NativeFieldInfoPtr__LocalUserQuery)) = value;
      }
    }

    public unsafe EntityQuery _UnlockedProgressionElementQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdateUnlockedProgressionOnDeserialize.NativeFieldInfoPtr__UnlockedProgressionElementQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdateUnlockedProgressionOnDeserialize.NativeFieldInfoPtr__UnlockedProgressionElementQuery)) = value;
      }
    }

    public unsafe EntityQuery __UpdateUnlockedProgressionOnDeserialize_UserChanged_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdateUnlockedProgressionOnDeserialize.NativeFieldInfoPtr___UpdateUnlockedProgressionOnDeserialize_UserChanged_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdateUnlockedProgressionOnDeserialize.NativeFieldInfoPtr___UpdateUnlockedProgressionOnDeserialize_UserChanged_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __UpdateUnlockedProgressionOnDeserialize_UserChanged_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdateUnlockedProgressionOnDeserialize.NativeFieldInfoPtr___UpdateUnlockedProgressionOnDeserialize_UserChanged_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdateUnlockedProgressionOnDeserialize.NativeFieldInfoPtr___UpdateUnlockedProgressionOnDeserialize_UserChanged_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __UpdateUnlockedProgressionOnDeserialize_ProgressionChanged_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdateUnlockedProgressionOnDeserialize.NativeFieldInfoPtr___UpdateUnlockedProgressionOnDeserialize_ProgressionChanged_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdateUnlockedProgressionOnDeserialize.NativeFieldInfoPtr___UpdateUnlockedProgressionOnDeserialize_ProgressionChanged_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __UpdateUnlockedProgressionOnDeserialize_ProgressionChanged_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdateUnlockedProgressionOnDeserialize.NativeFieldInfoPtr___UpdateUnlockedProgressionOnDeserialize_ProgressionChanged_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdateUnlockedProgressionOnDeserialize.NativeFieldInfoPtr___UpdateUnlockedProgressionOnDeserialize_ProgressionChanged_profilerMarker)) = value;
      }
    }

    [ObfuscatedName("ProjectM.UpdateUnlockedProgressionOnDeserialize/<>c__DisplayClass6_0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass6_0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr_jobData;
      private static readonly System.IntPtr NativeFieldInfoPtr_userContentFlags;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_User_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_Entity_byref_DynamicBuffer_1_UnlockedProgressionElement_0;
      [FieldOffset(0)]
      public EntityManager entityManager;
      [FieldOffset(8)]
      public ProgressionUtility.UpdateUnlockedJobData jobData;
      [FieldOffset(728)]
      public UserContentFlags userContentFlags;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass6_0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0(Entity entity, [In] ref User user)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref user;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass6_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_User_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__1(
        Entity progressionEntity,
        [In] ref DynamicBuffer<UnlockedProgressionElement> unlockedProgresionElements)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &progressionEntity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref unlockedProgresionElements;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass6_0.NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_Entity_byref_DynamicBuffer_1_UnlockedProgressionElement_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass6_0()
      {
        Il2CppClassPointerStore<UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UpdateUnlockedProgressionOnDeserialize>.NativeClassPtr, "<>c__DisplayClass6_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass6_0>.NativeClassPtr);
        UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass6_0.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass6_0>.NativeClassPtr, nameof (entityManager));
        UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass6_0.NativeFieldInfoPtr_jobData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass6_0>.NativeClassPtr, nameof (jobData));
        UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass6_0.NativeFieldInfoPtr_userContentFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass6_0>.NativeClassPtr, nameof (userContentFlags));
        UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass6_0>.NativeClassPtr, 100680396);
        UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass6_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_User_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass6_0>.NativeClassPtr, 100680397);
        UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass6_0.NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_Entity_byref_DynamicBuffer_1_UnlockedProgressionElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass6_0>.NativeClassPtr, 100680398);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass6_0>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.UpdateUnlockedProgressionOnDeserialize/ProjectM.<>c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_UserChanged")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_UserChanged
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr_jobData;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_User_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass6_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass6_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_UpdateUnlockedProgressionOnDeserialize_byref___c__DisplayClass6_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public EntityManager entityManager;
      [FieldOffset(8)]
      public ProgressionUtility.UpdateUnlockedJobData jobData;
      [FieldOffset(728)]
      public UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_UserChanged.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(768)]
      public unsafe UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_UserChanged.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1030343, XrefRangeEnd = 1030353, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(Entity entity, [In] ref User user)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref user;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_UserChanged.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_User_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1030353, RefRangeEnd = 1030354, XrefRangeStart = 1030353, XrefRangeEnd = 1030353, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass6_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_UserChanged.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass6_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1030354, RefRangeEnd = 1030355, XrefRangeStart = 1030354, XrefRangeEnd = 1030354, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass6_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_UserChanged.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass6_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1030355, XrefRangeEnd = 1030357, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute(
        ArchetypeChunk chunk,
        int chunkIndex,
        int firstEntityIndex)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_UserChanged.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1030363, RefRangeEnd = 1030364, XrefRangeStart = 1030357, XrefRangeEnd = 1030363, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_UserChanged.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_UserChanged.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1030366, RefRangeEnd = 1030367, XrefRangeStart = 1030364, XrefRangeEnd = 1030366, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        UpdateUnlockedProgressionOnDeserialize componentSystem,
        ref UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass6_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_UserChanged.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_UpdateUnlockedProgressionOnDeserialize_byref___c__DisplayClass6_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1030367, XrefRangeEnd = 1030371, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_UserChanged.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1030371, XrefRangeEnd = 1030377, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_UserChanged.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_UserChanged()
      {
        Il2CppClassPointerStore<UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_UserChanged>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UpdateUnlockedProgressionOnDeserialize>.NativeClassPtr, "<>c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_UserChanged");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_UserChanged>.NativeClassPtr);
        UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_UserChanged.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_UserChanged>.NativeClassPtr, nameof (entityManager));
        UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_UserChanged.NativeFieldInfoPtr_jobData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_UserChanged>.NativeClassPtr, nameof (jobData));
        UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_UserChanged.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_UserChanged>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_UserChanged.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_UserChanged>.NativeClassPtr, nameof (_runtimes));
        UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_UserChanged.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_UserChanged>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_UserChanged.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_UserChanged>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_UserChanged.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_User_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_UserChanged>.NativeClassPtr, 100680399);
        UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_UserChanged.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass6_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_UserChanged>.NativeClassPtr, 100680400);
        UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_UserChanged.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass6_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_UserChanged>.NativeClassPtr, 100680401);
        UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_UserChanged.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_UserChanged>.NativeClassPtr, 100680402);
        UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_UserChanged.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_UserChanged>.NativeClassPtr, 100680403);
        UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_UserChanged.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_UpdateUnlockedProgressionOnDeserialize_byref___c__DisplayClass6_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_UserChanged>.NativeClassPtr, 100680404);
        UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_UserChanged.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_UserChanged>.NativeClassPtr, 100680405);
        UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_UserChanged.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_UserChanged>.NativeClassPtr, 100680406);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_UserChanged>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_UserChanged.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_UserChanged.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_UserChanged.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_UserChanged.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_user;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_UpdateUnlockedProgressionOnDeserialize_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<User> forParameter_user;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1030262, RefRangeEnd = 1030263, XrefRangeStart = 1030258, XrefRangeEnd = 1030262, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(
          UpdateUnlockedProgressionOnDeserialize componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_UserChanged.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_UpdateUnlockedProgressionOnDeserialize_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1030267, RefRangeEnd = 1030268, XrefRangeStart = 1030263, XrefRangeEnd = 1030267, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_UserChanged.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_UserChanged.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_UserChanged.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_UserChanged.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_UserChanged>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_UserChanged.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_UserChanged.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_UserChanged.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_user = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_UserChanged.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_user));
          UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_UserChanged.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_UpdateUnlockedProgressionOnDeserialize_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_UserChanged.LambdaParameterValueProviders>.NativeClassPtr, 100680407);
          UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_UserChanged.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_UserChanged.LambdaParameterValueProviders>.NativeClassPtr, 100680408);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_UserChanged.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_user;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<User>.Runtime runtime_user;

          static Runtimes()
          {
            Il2CppClassPointerStore<UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_UserChanged.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_UserChanged.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_UserChanged.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_UserChanged.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_UserChanged.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_user = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_UserChanged.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_user));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_UserChanged.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.UpdateUnlockedProgressionOnDeserialize/ProjectM.<>c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_UserChanged/ProjectM.RunWithoutJobSystem_00003EEF$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_UserChanged.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_UserChanged.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 396179, RefRangeEnd = 396180, XrefRangeStart = 396179, XrefRangeEnd = 396180, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_UserChanged.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData,
          Il2CppSystem.AsyncCallback _param3,
          Il2CppSystem.Object _param4)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[4];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param3);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param4);
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_UserChanged.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
        }

        [CallerCount(3)]
        [CachedScanResults(RefRangeStart = 29036, RefRangeEnd = 29039, XrefRangeStart = 29036, XrefRangeEnd = 29039, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void EndInvoke(Il2CppSystem.IAsyncResult _param1)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_UserChanged.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_UserChanged.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_UserChanged>.NativeClassPtr, "RunWithoutJobSystem_00003EEF$PostfixBurstDelegate");
          UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_UserChanged.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_UserChanged.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100680409);
          UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_UserChanged.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_UserChanged.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100680410);
          UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_UserChanged.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_UserChanged.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100680411);
          UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_UserChanged.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_UserChanged.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100680412);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.UpdateUnlockedProgressionOnDeserialize/ProjectM.<>c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_UserChanged/ProjectM.RunWithoutJobSystem_00003EEF$BurstDirectCall")]
      public static class ObjectNInternalAbstractSealedInPoDeInUnique : Il2CppSystem.Object
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_Pointer;
        private static readonly System.IntPtr NativeFieldInfoPtr_DeferredCompilation;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Constructor_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1030268, XrefRangeEnd = 1030282, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_UserChanged.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1030282, XrefRangeEnd = 1030300, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_UserChanged.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1030300, XrefRangeEnd = 1030315, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_UserChanged.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_UserChanged.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1030342, RefRangeEnd = 1030343, XrefRangeStart = 1030315, XrefRangeEnd = 1030342, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_UserChanged.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_UserChanged.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_UserChanged>.NativeClassPtr, "RunWithoutJobSystem_00003EEF$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_UserChanged.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_UserChanged.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_UserChanged.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_UserChanged.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_UserChanged.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_UserChanged.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_UserChanged.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100680413);
          UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_UserChanged.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_UserChanged.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100680414);
          UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_UserChanged.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_UserChanged.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100680415);
          UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_UserChanged.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_UserChanged.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100680416);
          UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_UserChanged.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_UserChanged.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100680418);
        }

        public ObjectNInternalAbstractSealedInPoDeInUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }

        public new static unsafe System.IntPtr Pointer
        {
          get
          {
            System.IntPtr pointer;
            IL2CPP.il2cpp_field_static_get_value(UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_UserChanged.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_UserChanged.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_UserChanged.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_UserChanged.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.UpdateUnlockedProgressionOnDeserialize/ProjectM.<>c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_ProgressionChanged")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_ProgressionChanged
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_userContentFlags;
      private static readonly System.IntPtr NativeFieldInfoPtr_jobData;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_DynamicBuffer_1_UnlockedProgressionElement_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass6_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass6_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_UpdateUnlockedProgressionOnDeserialize_byref___c__DisplayClass6_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public UserContentFlags userContentFlags;
      [FieldOffset(8)]
      public ProgressionUtility.UpdateUnlockedJobData jobData;
      [FieldOffset(728)]
      public UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_ProgressionChanged.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(776)]
      public unsafe UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_ProgressionChanged.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1030462, XrefRangeEnd = 1030466, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity progressionEntity,
        [In] ref DynamicBuffer<UnlockedProgressionElement> unlockedProgresionElements)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &progressionEntity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref unlockedProgresionElements;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_ProgressionChanged.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_DynamicBuffer_1_UnlockedProgressionElement_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1030466, RefRangeEnd = 1030467, XrefRangeStart = 1030466, XrefRangeEnd = 1030466, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass6_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_ProgressionChanged.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass6_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1030467, RefRangeEnd = 1030468, XrefRangeStart = 1030467, XrefRangeEnd = 1030467, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass6_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_ProgressionChanged.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass6_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1030468, XrefRangeEnd = 1030470, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute(
        ArchetypeChunk chunk,
        int chunkIndex,
        int firstEntityIndex)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_ProgressionChanged.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1030476, RefRangeEnd = 1030477, XrefRangeStart = 1030470, XrefRangeEnd = 1030476, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_ProgressionChanged.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_ProgressionChanged.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1030479, RefRangeEnd = 1030480, XrefRangeStart = 1030477, XrefRangeEnd = 1030479, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        UpdateUnlockedProgressionOnDeserialize componentSystem,
        ref UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass6_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_ProgressionChanged.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_UpdateUnlockedProgressionOnDeserialize_byref___c__DisplayClass6_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1030480, XrefRangeEnd = 1030484, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_ProgressionChanged.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1030484, XrefRangeEnd = 1030490, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_ProgressionChanged.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_ProgressionChanged()
      {
        Il2CppClassPointerStore<UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_ProgressionChanged>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UpdateUnlockedProgressionOnDeserialize>.NativeClassPtr, "<>c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_ProgressionChanged");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_ProgressionChanged>.NativeClassPtr);
        UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_ProgressionChanged.NativeFieldInfoPtr_userContentFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_ProgressionChanged>.NativeClassPtr, nameof (userContentFlags));
        UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_ProgressionChanged.NativeFieldInfoPtr_jobData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_ProgressionChanged>.NativeClassPtr, nameof (jobData));
        UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_ProgressionChanged.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_ProgressionChanged>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_ProgressionChanged.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_ProgressionChanged>.NativeClassPtr, nameof (_runtimes));
        UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_ProgressionChanged.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_ProgressionChanged>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_ProgressionChanged.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_ProgressionChanged>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_ProgressionChanged.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_DynamicBuffer_1_UnlockedProgressionElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_ProgressionChanged>.NativeClassPtr, 100680419);
        UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_ProgressionChanged.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass6_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_ProgressionChanged>.NativeClassPtr, 100680420);
        UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_ProgressionChanged.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass6_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_ProgressionChanged>.NativeClassPtr, 100680421);
        UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_ProgressionChanged.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_ProgressionChanged>.NativeClassPtr, 100680422);
        UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_ProgressionChanged.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_ProgressionChanged>.NativeClassPtr, 100680423);
        UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_ProgressionChanged.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_UpdateUnlockedProgressionOnDeserialize_byref___c__DisplayClass6_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_ProgressionChanged>.NativeClassPtr, 100680424);
        UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_ProgressionChanged.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_ProgressionChanged>.NativeClassPtr, 100680425);
        UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_ProgressionChanged.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_ProgressionChanged>.NativeClassPtr, 100680426);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_ProgressionChanged>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_ProgressionChanged.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_ProgressionChanged.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_ProgressionChanged.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_ProgressionChanged.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_progressionEntity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_unlockedProgresionElements;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_UpdateUnlockedProgressionOnDeserialize_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_progressionEntity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_DynamicBuffer<UnlockedProgressionElement> forParameter_unlockedProgresionElements;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1030381, RefRangeEnd = 1030382, XrefRangeStart = 1030377, XrefRangeEnd = 1030381, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(
          UpdateUnlockedProgressionOnDeserialize componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_ProgressionChanged.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_UpdateUnlockedProgressionOnDeserialize_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1030386, RefRangeEnd = 1030387, XrefRangeStart = 1030382, XrefRangeEnd = 1030386, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_ProgressionChanged.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_ProgressionChanged.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_ProgressionChanged.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_ProgressionChanged.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_ProgressionChanged>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_ProgressionChanged.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_progressionEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_ProgressionChanged.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_progressionEntity));
          UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_ProgressionChanged.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_unlockedProgresionElements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_ProgressionChanged.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_unlockedProgresionElements));
          UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_ProgressionChanged.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_UpdateUnlockedProgressionOnDeserialize_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_ProgressionChanged.LambdaParameterValueProviders>.NativeClassPtr, 100680427);
          UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_ProgressionChanged.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_ProgressionChanged.LambdaParameterValueProviders>.NativeClassPtr, 100680428);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_ProgressionChanged.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_progressionEntity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_unlockedProgresionElements;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_progressionEntity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_DynamicBuffer<UnlockedProgressionElement>.Runtime runtime_unlockedProgresionElements;

          static Runtimes()
          {
            Il2CppClassPointerStore<UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_ProgressionChanged.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_ProgressionChanged.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_ProgressionChanged.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_progressionEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_ProgressionChanged.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_progressionEntity));
            UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_ProgressionChanged.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_unlockedProgresionElements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_ProgressionChanged.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_unlockedProgresionElements));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_ProgressionChanged.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.UpdateUnlockedProgressionOnDeserialize/ProjectM.<>c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_ProgressionChanged/ProjectM.RunWithoutJobSystem_00003EF8$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_ProgressionChanged.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_ProgressionChanged.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 396179, RefRangeEnd = 396180, XrefRangeStart = 396179, XrefRangeEnd = 396180, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_ProgressionChanged.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData,
          Il2CppSystem.AsyncCallback _param3,
          Il2CppSystem.Object _param4)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[4];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param3);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param4);
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_ProgressionChanged.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
        }

        [CallerCount(3)]
        [CachedScanResults(RefRangeStart = 29036, RefRangeEnd = 29039, XrefRangeStart = 29036, XrefRangeEnd = 29039, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void EndInvoke(Il2CppSystem.IAsyncResult _param1)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_ProgressionChanged.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_ProgressionChanged.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_ProgressionChanged>.NativeClassPtr, "RunWithoutJobSystem_00003EF8$PostfixBurstDelegate");
          UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_ProgressionChanged.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_ProgressionChanged.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100680429);
          UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_ProgressionChanged.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_ProgressionChanged.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100680430);
          UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_ProgressionChanged.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_ProgressionChanged.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100680431);
          UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_ProgressionChanged.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_ProgressionChanged.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100680432);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.UpdateUnlockedProgressionOnDeserialize/ProjectM.<>c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_ProgressionChanged/ProjectM.RunWithoutJobSystem_00003EF8$BurstDirectCall")]
      public static class ObjectNInternalAbstractSealedInPoDeInUnique : Il2CppSystem.Object
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_Pointer;
        private static readonly System.IntPtr NativeFieldInfoPtr_DeferredCompilation;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Constructor_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1030387, XrefRangeEnd = 1030401, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_ProgressionChanged.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1030401, XrefRangeEnd = 1030419, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_ProgressionChanged.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1030419, XrefRangeEnd = 1030434, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_ProgressionChanged.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_ProgressionChanged.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1030461, RefRangeEnd = 1030462, XrefRangeStart = 1030434, XrefRangeEnd = 1030461, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_ProgressionChanged.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_ProgressionChanged.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_ProgressionChanged>.NativeClassPtr, "RunWithoutJobSystem_00003EF8$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_ProgressionChanged.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_ProgressionChanged.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_ProgressionChanged.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_ProgressionChanged.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_ProgressionChanged.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_ProgressionChanged.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_ProgressionChanged.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100680433);
          UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_ProgressionChanged.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_ProgressionChanged.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100680434);
          UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_ProgressionChanged.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_ProgressionChanged.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100680435);
          UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_ProgressionChanged.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_ProgressionChanged.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100680436);
          UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_ProgressionChanged.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_ProgressionChanged.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100680438);
        }

        public ObjectNInternalAbstractSealedInPoDeInUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }

        public new static unsafe System.IntPtr Pointer
        {
          get
          {
            System.IntPtr pointer;
            IL2CPP.il2cpp_field_static_get_value(UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_ProgressionChanged.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_ProgressionChanged.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_ProgressionChanged.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(UpdateUnlockedProgressionOnDeserialize.__c__DisplayClass_UpdateUnlockedProgressionOnDeserialize_ProgressionChanged.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }
  }
}
