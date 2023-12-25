// Decompiled with JetBrains decompiler
// Type: ProjectM.HandleCreateCharacterEventSystem
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Reflection;
using ProjectM.Network;
using ProjectM.Shared;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Profiling;

#nullable disable
namespace ProjectM
{
  public class HandleCreateCharacterEventSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__PrefabCollectionSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__BootstrapSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__CreateCharacterEventQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___TryIsNameValid_LambdaJob0_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___TryIsNameValid_LambdaJob0_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryIsNameValid_Private_Boolean_Entity_String_byref_CreateCharacterFailureReason_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CheckFeaturesRequirements_Private_Byte_Byte_UserContentFlags_DynamicBuffer_1_T_Byte_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CheckAndClampFeature_Private_Byte_Byte_Byte_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateFadeToBlackEntity_Private_Entity_EntityManager_PrefabLookupMap_FromCharacter_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForTryIsNameValid_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 979072, XrefRangeEnd = 979093, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), HandleCreateCharacterEventSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 979093, XrefRangeEnd = 979269, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), HandleCreateCharacterEventSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 979289, RefRangeEnd = 979290, XrefRangeStart = 979269, XrefRangeEnd = 979289, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryIsNameValid(
      Entity userEntity,
      string characterNameString,
      out CreateCharacterFailureReason invalidReason)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &userEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(characterNameString);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref invalidReason;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HandleCreateCharacterEventSystem.NativeMethodInfoPtr_TryIsNameValid_Private_Boolean_Entity_String_byref_CreateCharacterFailureReason_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 979310, RefRangeEnd = 979311, XrefRangeStart = 979290, XrefRangeEnd = 979310, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe byte CheckFeaturesRequirements<T>(
      byte index,
      UserContentFlags userContent,
      DynamicBuffer<T> features,
      byte defaultIndex)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &index;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &userContent;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &features;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &defaultIndex;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HandleCreateCharacterEventSystem.MethodInfoStoreGeneric_CheckFeaturesRequirements_Private_Byte_Byte_UserContentFlags_DynamicBuffer_1_T_Byte_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(byte*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 979318, RefRangeEnd = 979321, XrefRangeStart = 979311, XrefRangeEnd = 979318, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe byte CheckAndClampFeature(byte index, byte featureCount)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &index;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &featureCount;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HandleCreateCharacterEventSystem.NativeMethodInfoPtr_CheckAndClampFeature_Private_Byte_Byte_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(byte*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 979335, RefRangeEnd = 979336, XrefRangeStart = 979321, XrefRangeEnd = 979335, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Entity CreateFadeToBlackEntity(
      EntityManager entityManager,
      PrefabLookupMap prefabLookupMap,
      FromCharacter fromCharacter)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &prefabLookupMap;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &fromCharacter;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HandleCreateCharacterEventSystem.NativeMethodInfoPtr_CreateFadeToBlackEntity_Private_Entity_EntityManager_PrefabLookupMap_FromCharacter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe HandleCreateCharacterEventSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HandleCreateCharacterEventSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HandleCreateCharacterEventSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 979336, XrefRangeEnd = 979365, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), HandleCreateCharacterEventSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 979365, XrefRangeEnd = 979381, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForTryIsNameValid_LambdaJob0_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HandleCreateCharacterEventSystem.NativeMethodInfoPtr___GetEntityQuery_ForTryIsNameValid_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    static HandleCreateCharacterEventSystem()
    {
      Il2CppClassPointerStore<HandleCreateCharacterEventSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (HandleCreateCharacterEventSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HandleCreateCharacterEventSystem>.NativeClassPtr);
      HandleCreateCharacterEventSystem.NativeFieldInfoPtr__PrefabCollectionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleCreateCharacterEventSystem>.NativeClassPtr, nameof (_PrefabCollectionSystem));
      HandleCreateCharacterEventSystem.NativeFieldInfoPtr__BootstrapSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleCreateCharacterEventSystem>.NativeClassPtr, nameof (_BootstrapSystem));
      HandleCreateCharacterEventSystem.NativeFieldInfoPtr__CreateCharacterEventQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleCreateCharacterEventSystem>.NativeClassPtr, nameof (_CreateCharacterEventQuery));
      HandleCreateCharacterEventSystem.NativeFieldInfoPtr___TryIsNameValid_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleCreateCharacterEventSystem>.NativeClassPtr, "<>TryIsNameValid_LambdaJob0_entityQuery");
      HandleCreateCharacterEventSystem.NativeFieldInfoPtr___TryIsNameValid_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleCreateCharacterEventSystem>.NativeClassPtr, "<>TryIsNameValid_LambdaJob0_profilerMarker");
      HandleCreateCharacterEventSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleCreateCharacterEventSystem>.NativeClassPtr, 100675631);
      HandleCreateCharacterEventSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleCreateCharacterEventSystem>.NativeClassPtr, 100675632);
      HandleCreateCharacterEventSystem.NativeMethodInfoPtr_TryIsNameValid_Private_Boolean_Entity_String_byref_CreateCharacterFailureReason_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleCreateCharacterEventSystem>.NativeClassPtr, 100675633);
      HandleCreateCharacterEventSystem.NativeMethodInfoPtr_CheckFeaturesRequirements_Private_Byte_Byte_UserContentFlags_DynamicBuffer_1_T_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleCreateCharacterEventSystem>.NativeClassPtr, 100675634);
      HandleCreateCharacterEventSystem.NativeMethodInfoPtr_CheckAndClampFeature_Private_Byte_Byte_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleCreateCharacterEventSystem>.NativeClassPtr, 100675635);
      HandleCreateCharacterEventSystem.NativeMethodInfoPtr_CreateFadeToBlackEntity_Private_Entity_EntityManager_PrefabLookupMap_FromCharacter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleCreateCharacterEventSystem>.NativeClassPtr, 100675636);
      HandleCreateCharacterEventSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleCreateCharacterEventSystem>.NativeClassPtr, 100675637);
      HandleCreateCharacterEventSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleCreateCharacterEventSystem>.NativeClassPtr, 100675638);
      HandleCreateCharacterEventSystem.NativeMethodInfoPtr___GetEntityQuery_ForTryIsNameValid_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleCreateCharacterEventSystem>.NativeClassPtr, 100675639);
    }

    public HandleCreateCharacterEventSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe PrefabCollectionSystem _PrefabCollectionSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleCreateCharacterEventSystem.NativeFieldInfoPtr__PrefabCollectionSystem));
        return pointer == System.IntPtr.Zero ? (PrefabCollectionSystem) null : new PrefabCollectionSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HandleCreateCharacterEventSystem.NativeFieldInfoPtr__PrefabCollectionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ServerBootstrapSystem _BootstrapSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleCreateCharacterEventSystem.NativeFieldInfoPtr__BootstrapSystem));
        return pointer == System.IntPtr.Zero ? (ServerBootstrapSystem) null : new ServerBootstrapSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HandleCreateCharacterEventSystem.NativeFieldInfoPtr__BootstrapSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityQuery _CreateCharacterEventQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleCreateCharacterEventSystem.NativeFieldInfoPtr__CreateCharacterEventQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleCreateCharacterEventSystem.NativeFieldInfoPtr__CreateCharacterEventQuery)) = value;
      }
    }

    public unsafe EntityQuery __TryIsNameValid_LambdaJob0_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleCreateCharacterEventSystem.NativeFieldInfoPtr___TryIsNameValid_LambdaJob0_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleCreateCharacterEventSystem.NativeFieldInfoPtr___TryIsNameValid_LambdaJob0_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __TryIsNameValid_LambdaJob0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleCreateCharacterEventSystem.NativeFieldInfoPtr___TryIsNameValid_LambdaJob0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleCreateCharacterEventSystem.NativeFieldInfoPtr___TryIsNameValid_LambdaJob0_profilerMarker)) = value;
      }
    }

    [ObfuscatedName("ProjectM.HandleCreateCharacterEventSystem/<>c__DisplayClass5_0")]
    public sealed class __c__DisplayClass5_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_collision;
      private static readonly System.IntPtr NativeFieldInfoPtr_userEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr_characterNameString;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__TryIsNameValid_b__0_Internal_Void_Entity_byref_User_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass5_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HandleCreateCharacterEventSystem.__c__DisplayClass5_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(HandleCreateCharacterEventSystem.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _TryIsNameValid_b__0(Entity entity, [In] ref User user)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref user;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(HandleCreateCharacterEventSystem.__c__DisplayClass5_0.NativeMethodInfoPtr__TryIsNameValid_b__0_Internal_Void_Entity_byref_User_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass5_0()
      {
        Il2CppClassPointerStore<HandleCreateCharacterEventSystem.__c__DisplayClass5_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HandleCreateCharacterEventSystem>.NativeClassPtr, "<>c__DisplayClass5_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HandleCreateCharacterEventSystem.__c__DisplayClass5_0>.NativeClassPtr);
        HandleCreateCharacterEventSystem.__c__DisplayClass5_0.NativeFieldInfoPtr_collision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleCreateCharacterEventSystem.__c__DisplayClass5_0>.NativeClassPtr, nameof (collision));
        HandleCreateCharacterEventSystem.__c__DisplayClass5_0.NativeFieldInfoPtr_userEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleCreateCharacterEventSystem.__c__DisplayClass5_0>.NativeClassPtr, nameof (userEntity));
        HandleCreateCharacterEventSystem.__c__DisplayClass5_0.NativeFieldInfoPtr_characterNameString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleCreateCharacterEventSystem.__c__DisplayClass5_0>.NativeClassPtr, nameof (characterNameString));
        HandleCreateCharacterEventSystem.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleCreateCharacterEventSystem.__c__DisplayClass5_0>.NativeClassPtr, 100675640);
        HandleCreateCharacterEventSystem.__c__DisplayClass5_0.NativeMethodInfoPtr__TryIsNameValid_b__0_Internal_Void_Entity_byref_User_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleCreateCharacterEventSystem.__c__DisplayClass5_0>.NativeClassPtr, 100675641);
      }

      public __c__DisplayClass5_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass5_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<HandleCreateCharacterEventSystem.__c__DisplayClass5_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HandleCreateCharacterEventSystem.__c__DisplayClass5_0>.NativeClassPtr, data));
      }

      public unsafe bool collision
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleCreateCharacterEventSystem.__c__DisplayClass5_0.NativeFieldInfoPtr_collision));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleCreateCharacterEventSystem.__c__DisplayClass5_0.NativeFieldInfoPtr_collision)) = value;
        }
      }

      public unsafe Entity userEntity
      {
        get
        {
          return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleCreateCharacterEventSystem.__c__DisplayClass5_0.NativeFieldInfoPtr_userEntity));
        }
        [param: In] set
        {
          *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleCreateCharacterEventSystem.__c__DisplayClass5_0.NativeFieldInfoPtr_userEntity)) = value;
        }
      }

      public unsafe string characterNameString
      {
        get
        {
          return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleCreateCharacterEventSystem.__c__DisplayClass5_0.NativeFieldInfoPtr_characterNameString)));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HandleCreateCharacterEventSystem.__c__DisplayClass5_0.NativeFieldInfoPtr_characterNameString), IL2CPP.ManagedStringToIl2Cpp(value));
        }
      }
    }

    [ObfuscatedName("ProjectM.HandleCreateCharacterEventSystem/ProjectM.<>c__DisplayClass_TryIsNameValid_LambdaJob0")]
    public sealed class __c__DisplayClass_TryIsNameValid_LambdaJob0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_collision;
      private static readonly System.IntPtr NativeFieldInfoPtr_userEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr_characterNameString;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_User_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass5_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass5_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_HandleCreateCharacterEventSystem_byref___c__DisplayClass5_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 979049, RefRangeEnd = 979050, XrefRangeStart = 979046, XrefRangeEnd = 979049, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(Entity entity, [In] ref User user)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref user;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(HandleCreateCharacterEventSystem.__c__DisplayClass_TryIsNameValid_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_User_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 979051, RefRangeEnd = 979052, XrefRangeStart = 979050, XrefRangeEnd = 979051, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref HandleCreateCharacterEventSystem.__c__DisplayClass5_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(HandleCreateCharacterEventSystem.__c__DisplayClass_TryIsNameValid_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass5_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 979053, RefRangeEnd = 979054, XrefRangeStart = 979052, XrefRangeEnd = 979053, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref HandleCreateCharacterEventSystem.__c__DisplayClass5_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(HandleCreateCharacterEventSystem.__c__DisplayClass_TryIsNameValid_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass5_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 979054, XrefRangeEnd = 979056, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute(
        ArchetypeChunk chunk,
        int chunkIndex,
        int firstEntityIndex)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(HandleCreateCharacterEventSystem.__c__DisplayClass_TryIsNameValid_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 979062, RefRangeEnd = 979063, XrefRangeStart = 979056, XrefRangeEnd = 979062, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref HandleCreateCharacterEventSystem.__c__DisplayClass_TryIsNameValid_LambdaJob0.LambdaParameterValueProviders.Runtimes runtimes)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(HandleCreateCharacterEventSystem.__c__DisplayClass_TryIsNameValid_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 979065, RefRangeEnd = 979066, XrefRangeStart = 979063, XrefRangeEnd = 979065, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        HandleCreateCharacterEventSystem componentSystem,
        ref HandleCreateCharacterEventSystem.__c__DisplayClass5_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(HandleCreateCharacterEventSystem.__c__DisplayClass_TryIsNameValid_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_HandleCreateCharacterEventSystem_byref___c__DisplayClass5_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 979066, XrefRangeEnd = 979072, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(HandleCreateCharacterEventSystem.__c__DisplayClass_TryIsNameValid_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_TryIsNameValid_LambdaJob0()
      {
        Il2CppClassPointerStore<HandleCreateCharacterEventSystem.__c__DisplayClass_TryIsNameValid_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HandleCreateCharacterEventSystem>.NativeClassPtr, "<>c__DisplayClass_TryIsNameValid_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HandleCreateCharacterEventSystem.__c__DisplayClass_TryIsNameValid_LambdaJob0>.NativeClassPtr);
        HandleCreateCharacterEventSystem.__c__DisplayClass_TryIsNameValid_LambdaJob0.NativeFieldInfoPtr_collision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleCreateCharacterEventSystem.__c__DisplayClass_TryIsNameValid_LambdaJob0>.NativeClassPtr, nameof (collision));
        HandleCreateCharacterEventSystem.__c__DisplayClass_TryIsNameValid_LambdaJob0.NativeFieldInfoPtr_userEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleCreateCharacterEventSystem.__c__DisplayClass_TryIsNameValid_LambdaJob0>.NativeClassPtr, nameof (userEntity));
        HandleCreateCharacterEventSystem.__c__DisplayClass_TryIsNameValid_LambdaJob0.NativeFieldInfoPtr_characterNameString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleCreateCharacterEventSystem.__c__DisplayClass_TryIsNameValid_LambdaJob0>.NativeClassPtr, nameof (characterNameString));
        HandleCreateCharacterEventSystem.__c__DisplayClass_TryIsNameValid_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleCreateCharacterEventSystem.__c__DisplayClass_TryIsNameValid_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        HandleCreateCharacterEventSystem.__c__DisplayClass_TryIsNameValid_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleCreateCharacterEventSystem.__c__DisplayClass_TryIsNameValid_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
        HandleCreateCharacterEventSystem.__c__DisplayClass_TryIsNameValid_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleCreateCharacterEventSystem.__c__DisplayClass_TryIsNameValid_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        HandleCreateCharacterEventSystem.__c__DisplayClass_TryIsNameValid_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_User_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleCreateCharacterEventSystem.__c__DisplayClass_TryIsNameValid_LambdaJob0>.NativeClassPtr, 100675642);
        HandleCreateCharacterEventSystem.__c__DisplayClass_TryIsNameValid_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass5_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleCreateCharacterEventSystem.__c__DisplayClass_TryIsNameValid_LambdaJob0>.NativeClassPtr, 100675643);
        HandleCreateCharacterEventSystem.__c__DisplayClass_TryIsNameValid_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass5_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleCreateCharacterEventSystem.__c__DisplayClass_TryIsNameValid_LambdaJob0>.NativeClassPtr, 100675644);
        HandleCreateCharacterEventSystem.__c__DisplayClass_TryIsNameValid_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleCreateCharacterEventSystem.__c__DisplayClass_TryIsNameValid_LambdaJob0>.NativeClassPtr, 100675645);
        HandleCreateCharacterEventSystem.__c__DisplayClass_TryIsNameValid_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleCreateCharacterEventSystem.__c__DisplayClass_TryIsNameValid_LambdaJob0>.NativeClassPtr, 100675646);
        HandleCreateCharacterEventSystem.__c__DisplayClass_TryIsNameValid_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_HandleCreateCharacterEventSystem_byref___c__DisplayClass5_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleCreateCharacterEventSystem.__c__DisplayClass_TryIsNameValid_LambdaJob0>.NativeClassPtr, 100675647);
        HandleCreateCharacterEventSystem.__c__DisplayClass_TryIsNameValid_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleCreateCharacterEventSystem.__c__DisplayClass_TryIsNameValid_LambdaJob0>.NativeClassPtr, 100675648);
      }

      public __c__DisplayClass_TryIsNameValid_LambdaJob0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass_TryIsNameValid_LambdaJob0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<HandleCreateCharacterEventSystem.__c__DisplayClass_TryIsNameValid_LambdaJob0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HandleCreateCharacterEventSystem.__c__DisplayClass_TryIsNameValid_LambdaJob0>.NativeClassPtr, data));
      }

      public unsafe bool collision
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleCreateCharacterEventSystem.__c__DisplayClass_TryIsNameValid_LambdaJob0.NativeFieldInfoPtr_collision));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleCreateCharacterEventSystem.__c__DisplayClass_TryIsNameValid_LambdaJob0.NativeFieldInfoPtr_collision)) = value;
        }
      }

      public unsafe Entity userEntity
      {
        get
        {
          return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleCreateCharacterEventSystem.__c__DisplayClass_TryIsNameValid_LambdaJob0.NativeFieldInfoPtr_userEntity));
        }
        [param: In] set
        {
          *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleCreateCharacterEventSystem.__c__DisplayClass_TryIsNameValid_LambdaJob0.NativeFieldInfoPtr_userEntity)) = value;
        }
      }

      public unsafe string characterNameString
      {
        get
        {
          return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleCreateCharacterEventSystem.__c__DisplayClass_TryIsNameValid_LambdaJob0.NativeFieldInfoPtr_characterNameString)));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HandleCreateCharacterEventSystem.__c__DisplayClass_TryIsNameValid_LambdaJob0.NativeFieldInfoPtr_characterNameString), IL2CPP.ManagedStringToIl2Cpp(value));
        }
      }

      public unsafe HandleCreateCharacterEventSystem.__c__DisplayClass_TryIsNameValid_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders
      {
        get
        {
          return *(HandleCreateCharacterEventSystem.__c__DisplayClass_TryIsNameValid_LambdaJob0.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleCreateCharacterEventSystem.__c__DisplayClass_TryIsNameValid_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders));
        }
        [param: In] set
        {
          *(HandleCreateCharacterEventSystem.__c__DisplayClass_TryIsNameValid_LambdaJob0.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleCreateCharacterEventSystem.__c__DisplayClass_TryIsNameValid_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders)) = value;
        }
      }

      public unsafe HandleCreateCharacterEventSystem.__c__DisplayClass_TryIsNameValid_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes
      {
        get
        {
          return (HandleCreateCharacterEventSystem.__c__DisplayClass_TryIsNameValid_LambdaJob0.LambdaParameterValueProviders.Runtimes*) (void*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleCreateCharacterEventSystem.__c__DisplayClass_TryIsNameValid_LambdaJob0.NativeFieldInfoPtr__runtimes));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HandleCreateCharacterEventSystem.__c__DisplayClass_TryIsNameValid_LambdaJob0.NativeFieldInfoPtr__runtimes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) (System.IntPtr) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(HandleCreateCharacterEventSystem.__c__DisplayClass_TryIsNameValid_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(HandleCreateCharacterEventSystem.__c__DisplayClass_TryIsNameValid_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_user;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_HandleCreateCharacterEventSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<User> forParameter_user;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 979040, RefRangeEnd = 979041, XrefRangeStart = 979036, XrefRangeEnd = 979040, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(HandleCreateCharacterEventSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(HandleCreateCharacterEventSystem.__c__DisplayClass_TryIsNameValid_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_HandleCreateCharacterEventSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 979045, RefRangeEnd = 979046, XrefRangeStart = 979041, XrefRangeEnd = 979045, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe HandleCreateCharacterEventSystem.__c__DisplayClass_TryIsNameValid_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HandleCreateCharacterEventSystem.__c__DisplayClass_TryIsNameValid_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(HandleCreateCharacterEventSystem.__c__DisplayClass_TryIsNameValid_LambdaJob0.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<HandleCreateCharacterEventSystem.__c__DisplayClass_TryIsNameValid_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HandleCreateCharacterEventSystem.__c__DisplayClass_TryIsNameValid_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          HandleCreateCharacterEventSystem.__c__DisplayClass_TryIsNameValid_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleCreateCharacterEventSystem.__c__DisplayClass_TryIsNameValid_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          HandleCreateCharacterEventSystem.__c__DisplayClass_TryIsNameValid_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_user = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleCreateCharacterEventSystem.__c__DisplayClass_TryIsNameValid_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_user));
          HandleCreateCharacterEventSystem.__c__DisplayClass_TryIsNameValid_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_HandleCreateCharacterEventSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleCreateCharacterEventSystem.__c__DisplayClass_TryIsNameValid_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100675649);
          HandleCreateCharacterEventSystem.__c__DisplayClass_TryIsNameValid_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleCreateCharacterEventSystem.__c__DisplayClass_TryIsNameValid_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100675650);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HandleCreateCharacterEventSystem.__c__DisplayClass_TryIsNameValid_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
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
            Il2CppClassPointerStore<HandleCreateCharacterEventSystem.__c__DisplayClass_TryIsNameValid_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HandleCreateCharacterEventSystem.__c__DisplayClass_TryIsNameValid_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            HandleCreateCharacterEventSystem.__c__DisplayClass_TryIsNameValid_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleCreateCharacterEventSystem.__c__DisplayClass_TryIsNameValid_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            HandleCreateCharacterEventSystem.__c__DisplayClass_TryIsNameValid_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_user = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleCreateCharacterEventSystem.__c__DisplayClass_TryIsNameValid_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_user));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HandleCreateCharacterEventSystem.__c__DisplayClass_TryIsNameValid_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }

    private sealed class MethodInfoStoreGeneric_CheckFeaturesRequirements_Private_Byte_Byte_UserContentFlags_DynamicBuffer_1_T_Byte_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(HandleCreateCharacterEventSystem.NativeMethodInfoPtr_CheckFeaturesRequirements_Private_Byte_Byte_UserContentFlags_DynamicBuffer_1_T_Byte_0, Il2CppClassPointerStore<HandleCreateCharacterEventSystem>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }
  }
}
