// Decompiled with JetBrains decompiler
// Type: ProjectM.CommonClientDataSystem
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using ProjectM.Network;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Mathematics;

#nullable disable
namespace ProjectM
{
  public class CommonClientDataSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_LocalUser;
    private static readonly System.IntPtr NativeFieldInfoPtr_ServerGameBalanceSettings;
    private static readonly System.IntPtr NativeFieldInfoPtr__GameDataSystem_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__PrefabCollectionSystem_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__ProgressionDependencySystem_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__SingletonEntityQuery_LocalUser_2;
    private static readonly System.IntPtr NativeFieldInfoPtr__SingletonEntityQuery_LocalCharacter_3;
    private static readonly System.IntPtr NativeFieldInfoPtr__SingletonEntityQuery_LocalControlled_4;
    private static readonly System.IntPtr NativeFieldInfoPtr__SingletonEntityQuery_ServerGameBalanceSettings_5;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_GameDataSystem_Public_get_GameDataSystem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_GameDataSystem_Private_set_Void_GameDataSystem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_PrefabCollectionSystem_Public_get_PrefabCollectionSystem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_PrefabCollectionSystem_Private_set_Void_PrefabCollectionSystem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ProgressionDependencySystem_Public_get_ProgressionDependencySystem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_ProgressionDependencySystem_Private_set_Void_ProgressionDependencySystem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_HasGameDataSystem_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_HasPrefabCollectionSystem_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_HasProgressionDependencySystem_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateLocalUserData_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSingletons_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    public unsafe GameDataSystem GameDataSystem
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CommonClientDataSystem.NativeMethodInfoPtr_get_GameDataSystem_Public_get_GameDataSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (GameDataSystem) null : new GameDataSystem(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 750666, XrefRangeEnd = 750667, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CommonClientDataSystem.NativeMethodInfoPtr_set_GameDataSystem_Private_set_Void_GameDataSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe PrefabCollectionSystem PrefabCollectionSystem
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CommonClientDataSystem.NativeMethodInfoPtr_get_PrefabCollectionSystem_Public_get_PrefabCollectionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (PrefabCollectionSystem) null : new PrefabCollectionSystem(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 750667, XrefRangeEnd = 750668, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CommonClientDataSystem.NativeMethodInfoPtr_set_PrefabCollectionSystem_Private_set_Void_PrefabCollectionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe ProgressionDependencySystem ProgressionDependencySystem
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CommonClientDataSystem.NativeMethodInfoPtr_get_ProgressionDependencySystem_Public_get_ProgressionDependencySystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (ProgressionDependencySystem) null : new ProgressionDependencySystem(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 750668, XrefRangeEnd = 750669, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CommonClientDataSystem.NativeMethodInfoPtr_set_ProgressionDependencySystem_Private_set_Void_ProgressionDependencySystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe bool HasGameDataSystem
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 750669, RefRangeEnd = 750670, XrefRangeStart = 750669, XrefRangeEnd = 750669, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CommonClientDataSystem.NativeMethodInfoPtr_get_HasGameDataSystem_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe bool HasPrefabCollectionSystem
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 750670, RefRangeEnd = 750671, XrefRangeStart = 750670, XrefRangeEnd = 750670, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CommonClientDataSystem.NativeMethodInfoPtr_get_HasPrefabCollectionSystem_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe bool HasProgressionDependencySystem
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CommonClientDataSystem.NativeMethodInfoPtr_get_HasProgressionDependencySystem_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 750671, XrefRangeEnd = 750687, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CommonClientDataSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 750687, XrefRangeEnd = 750702, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CommonClientDataSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 750746, RefRangeEnd = 750747, XrefRangeStart = 750702, XrefRangeEnd = 750746, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdateLocalUserData()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CommonClientDataSystem.NativeMethodInfoPtr_UpdateLocalUserData_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 750747, XrefRangeEnd = 750761, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdateSingletons()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CommonClientDataSystem.NativeMethodInfoPtr_UpdateSingletons_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CommonClientDataSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CommonClientDataSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CommonClientDataSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 750761, XrefRangeEnd = 750787, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CommonClientDataSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static CommonClientDataSystem()
    {
      Il2CppClassPointerStore<CommonClientDataSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (CommonClientDataSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CommonClientDataSystem>.NativeClassPtr);
      CommonClientDataSystem.NativeFieldInfoPtr_LocalUser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommonClientDataSystem>.NativeClassPtr, nameof (LocalUser));
      CommonClientDataSystem.NativeFieldInfoPtr_ServerGameBalanceSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommonClientDataSystem>.NativeClassPtr, nameof (ServerGameBalanceSettings));
      CommonClientDataSystem.NativeFieldInfoPtr__GameDataSystem_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommonClientDataSystem>.NativeClassPtr, "<GameDataSystem>k__BackingField");
      CommonClientDataSystem.NativeFieldInfoPtr__PrefabCollectionSystem_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommonClientDataSystem>.NativeClassPtr, "<PrefabCollectionSystem>k__BackingField");
      CommonClientDataSystem.NativeFieldInfoPtr__ProgressionDependencySystem_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommonClientDataSystem>.NativeClassPtr, "<ProgressionDependencySystem>k__BackingField");
      CommonClientDataSystem.NativeFieldInfoPtr__SingletonEntityQuery_LocalUser_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommonClientDataSystem>.NativeClassPtr, nameof (_SingletonEntityQuery_LocalUser_2));
      CommonClientDataSystem.NativeFieldInfoPtr__SingletonEntityQuery_LocalCharacter_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommonClientDataSystem>.NativeClassPtr, nameof (_SingletonEntityQuery_LocalCharacter_3));
      CommonClientDataSystem.NativeFieldInfoPtr__SingletonEntityQuery_LocalControlled_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommonClientDataSystem>.NativeClassPtr, nameof (_SingletonEntityQuery_LocalControlled_4));
      CommonClientDataSystem.NativeFieldInfoPtr__SingletonEntityQuery_ServerGameBalanceSettings_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommonClientDataSystem>.NativeClassPtr, nameof (_SingletonEntityQuery_ServerGameBalanceSettings_5));
      CommonClientDataSystem.NativeMethodInfoPtr_get_GameDataSystem_Public_get_GameDataSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommonClientDataSystem>.NativeClassPtr, 100666072);
      CommonClientDataSystem.NativeMethodInfoPtr_set_GameDataSystem_Private_set_Void_GameDataSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommonClientDataSystem>.NativeClassPtr, 100666073);
      CommonClientDataSystem.NativeMethodInfoPtr_get_PrefabCollectionSystem_Public_get_PrefabCollectionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommonClientDataSystem>.NativeClassPtr, 100666074);
      CommonClientDataSystem.NativeMethodInfoPtr_set_PrefabCollectionSystem_Private_set_Void_PrefabCollectionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommonClientDataSystem>.NativeClassPtr, 100666075);
      CommonClientDataSystem.NativeMethodInfoPtr_get_ProgressionDependencySystem_Public_get_ProgressionDependencySystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommonClientDataSystem>.NativeClassPtr, 100666076);
      CommonClientDataSystem.NativeMethodInfoPtr_set_ProgressionDependencySystem_Private_set_Void_ProgressionDependencySystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommonClientDataSystem>.NativeClassPtr, 100666077);
      CommonClientDataSystem.NativeMethodInfoPtr_get_HasGameDataSystem_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommonClientDataSystem>.NativeClassPtr, 100666078);
      CommonClientDataSystem.NativeMethodInfoPtr_get_HasPrefabCollectionSystem_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommonClientDataSystem>.NativeClassPtr, 100666079);
      CommonClientDataSystem.NativeMethodInfoPtr_get_HasProgressionDependencySystem_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommonClientDataSystem>.NativeClassPtr, 100666080);
      CommonClientDataSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommonClientDataSystem>.NativeClassPtr, 100666081);
      CommonClientDataSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommonClientDataSystem>.NativeClassPtr, 100666082);
      CommonClientDataSystem.NativeMethodInfoPtr_UpdateLocalUserData_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommonClientDataSystem>.NativeClassPtr, 100666083);
      CommonClientDataSystem.NativeMethodInfoPtr_UpdateSingletons_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommonClientDataSystem>.NativeClassPtr, 100666084);
      CommonClientDataSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommonClientDataSystem>.NativeClassPtr, 100666085);
      CommonClientDataSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommonClientDataSystem>.NativeClassPtr, 100666086);
    }

    public CommonClientDataSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe CommonClientDataSystem.LocalUserData LocalUser
    {
      get
      {
        return *(CommonClientDataSystem.LocalUserData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CommonClientDataSystem.NativeFieldInfoPtr_LocalUser));
      }
      [param: In] set
      {
        *(CommonClientDataSystem.LocalUserData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CommonClientDataSystem.NativeFieldInfoPtr_LocalUser)) = value;
      }
    }

    public unsafe Nullable_Unboxed<ProjectM.ServerGameBalanceSettings> ServerGameBalanceSettings
    {
      get
      {
        return *(Nullable_Unboxed<ProjectM.ServerGameBalanceSettings>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CommonClientDataSystem.NativeFieldInfoPtr_ServerGameBalanceSettings));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CommonClientDataSystem.NativeFieldInfoPtr_ServerGameBalanceSettings), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable_Unboxed<ProjectM.ServerGameBalanceSettings>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe GameDataSystem _GameDataSystem_k__BackingField
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CommonClientDataSystem.NativeFieldInfoPtr__GameDataSystem_k__BackingField));
        return pointer == System.IntPtr.Zero ? (GameDataSystem) null : new GameDataSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CommonClientDataSystem.NativeFieldInfoPtr__GameDataSystem_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe PrefabCollectionSystem _PrefabCollectionSystem_k__BackingField
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CommonClientDataSystem.NativeFieldInfoPtr__PrefabCollectionSystem_k__BackingField));
        return pointer == System.IntPtr.Zero ? (PrefabCollectionSystem) null : new PrefabCollectionSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CommonClientDataSystem.NativeFieldInfoPtr__PrefabCollectionSystem_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ProgressionDependencySystem _ProgressionDependencySystem_k__BackingField
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CommonClientDataSystem.NativeFieldInfoPtr__ProgressionDependencySystem_k__BackingField));
        return pointer == System.IntPtr.Zero ? (ProgressionDependencySystem) null : new ProgressionDependencySystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CommonClientDataSystem.NativeFieldInfoPtr__ProgressionDependencySystem_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityQuery _SingletonEntityQuery_LocalUser_2
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CommonClientDataSystem.NativeFieldInfoPtr__SingletonEntityQuery_LocalUser_2));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CommonClientDataSystem.NativeFieldInfoPtr__SingletonEntityQuery_LocalUser_2)) = value;
      }
    }

    public unsafe EntityQuery _SingletonEntityQuery_LocalCharacter_3
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CommonClientDataSystem.NativeFieldInfoPtr__SingletonEntityQuery_LocalCharacter_3));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CommonClientDataSystem.NativeFieldInfoPtr__SingletonEntityQuery_LocalCharacter_3)) = value;
      }
    }

    public unsafe EntityQuery _SingletonEntityQuery_LocalControlled_4
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CommonClientDataSystem.NativeFieldInfoPtr__SingletonEntityQuery_LocalControlled_4));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CommonClientDataSystem.NativeFieldInfoPtr__SingletonEntityQuery_LocalControlled_4)) = value;
      }
    }

    public unsafe EntityQuery _SingletonEntityQuery_ServerGameBalanceSettings_5
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CommonClientDataSystem.NativeFieldInfoPtr__SingletonEntityQuery_ServerGameBalanceSettings_5));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CommonClientDataSystem.NativeFieldInfoPtr__SingletonEntityQuery_ServerGameBalanceSettings_5)) = value;
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct LocalUserData
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_UserEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr_CharacterEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr_ControlledEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr_CameraEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr_ClanEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr_CharacterPosition;
      private static readonly System.IntPtr NativeFieldInfoPtr_CharacterRotation;
      private static readonly System.IntPtr NativeFieldInfoPtr_ControlledPosition;
      private static readonly System.IntPtr NativeFieldInfoPtr_ControlledRotation;
      private static readonly System.IntPtr NativeFieldInfoPtr_User;
      private static readonly System.IntPtr NativeFieldInfoPtr_UserTeam;
      private static readonly System.IntPtr NativeMethodInfoPtr_get_HasUser_Public_get_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_get_HasCharacter_Public_get_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_get_HasControlled_Public_get_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_get_HasCamera_Public_get_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_TryGetUser_Public_Boolean_byref_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_TryGetCharacter_Public_Boolean_byref_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_TryGetControlled_Public_Boolean_byref_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IsAdmin_Public_Boolean_SingletonAccessor_1_SyncedServerDebugSettings_0;
      [FieldOffset(0)]
      public Entity UserEntity;
      [FieldOffset(8)]
      public Entity CharacterEntity;
      [FieldOffset(16)]
      public Entity ControlledEntity;
      [FieldOffset(24)]
      public Entity CameraEntity;
      [FieldOffset(32)]
      public Entity ClanEntity;
      [FieldOffset(40)]
      public float3 CharacterPosition;
      [FieldOffset(52)]
      public quaternion CharacterRotation;
      [FieldOffset(68)]
      public float3 ControlledPosition;
      [FieldOffset(80)]
      public quaternion ControlledRotation;
      [FieldOffset(96)]
      public User User;
      [FieldOffset(248)]
      public Team UserTeam;

      public unsafe bool HasUser
      {
        [CallerCount(18), CachedScanResults(RefRangeStart = 750559, RefRangeEnd = 750577, XrefRangeStart = 750557, XrefRangeEnd = 750559, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CommonClientDataSystem.LocalUserData.NativeMethodInfoPtr_get_HasUser_Public_get_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      public unsafe bool HasCharacter
      {
        [CallerCount(11), CachedScanResults(RefRangeStart = 750579, RefRangeEnd = 750590, XrefRangeStart = 750577, XrefRangeEnd = 750579, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CommonClientDataSystem.LocalUserData.NativeMethodInfoPtr_get_HasCharacter_Public_get_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      public unsafe bool HasControlled
      {
        [CallerCount(14), CachedScanResults(RefRangeStart = 750592, RefRangeEnd = 750606, XrefRangeStart = 750590, XrefRangeEnd = 750592, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CommonClientDataSystem.LocalUserData.NativeMethodInfoPtr_get_HasControlled_Public_get_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      public unsafe bool HasCamera
      {
        [CallerCount(4), CachedScanResults(RefRangeStart = 750608, RefRangeEnd = 750612, XrefRangeStart = 750606, XrefRangeEnd = 750608, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CommonClientDataSystem.LocalUserData.NativeMethodInfoPtr_get_HasCamera_Public_get_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(19)]
      [CachedScanResults(RefRangeStart = 750614, RefRangeEnd = 750633, XrefRangeStart = 750612, XrefRangeEnd = 750614, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe bool TryGetUser(out Entity result)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref result;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CommonClientDataSystem.LocalUserData.NativeMethodInfoPtr_TryGetUser_Public_Boolean_byref_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 750635, RefRangeEnd = 750637, XrefRangeStart = 750633, XrefRangeEnd = 750635, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe bool TryGetCharacter(out Entity result)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref result;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CommonClientDataSystem.LocalUserData.NativeMethodInfoPtr_TryGetCharacter_Public_Boolean_byref_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(21)]
      [CachedScanResults(RefRangeStart = 750639, RefRangeEnd = 750660, XrefRangeStart = 750637, XrefRangeEnd = 750639, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe bool TryGetControlled(out Entity result)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref result;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CommonClientDataSystem.LocalUserData.NativeMethodInfoPtr_TryGetControlled_Public_Boolean_byref_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(5)]
      [CachedScanResults(RefRangeStart = 750661, RefRangeEnd = 750666, XrefRangeStart = 750660, XrefRangeEnd = 750661, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe bool IsAdmin(
        SingletonAccessor<SyncedServerDebugSettings> syncedServerDebugSettingsAccessor)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &syncedServerDebugSettingsAccessor;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CommonClientDataSystem.LocalUserData.NativeMethodInfoPtr_IsAdmin_Public_Boolean_SingletonAccessor_1_SyncedServerDebugSettings_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      static LocalUserData()
      {
        Il2CppClassPointerStore<CommonClientDataSystem.LocalUserData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CommonClientDataSystem>.NativeClassPtr, nameof (LocalUserData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CommonClientDataSystem.LocalUserData>.NativeClassPtr);
        CommonClientDataSystem.LocalUserData.NativeFieldInfoPtr_UserEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommonClientDataSystem.LocalUserData>.NativeClassPtr, nameof (UserEntity));
        CommonClientDataSystem.LocalUserData.NativeFieldInfoPtr_CharacterEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommonClientDataSystem.LocalUserData>.NativeClassPtr, nameof (CharacterEntity));
        CommonClientDataSystem.LocalUserData.NativeFieldInfoPtr_ControlledEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommonClientDataSystem.LocalUserData>.NativeClassPtr, nameof (ControlledEntity));
        CommonClientDataSystem.LocalUserData.NativeFieldInfoPtr_CameraEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommonClientDataSystem.LocalUserData>.NativeClassPtr, nameof (CameraEntity));
        CommonClientDataSystem.LocalUserData.NativeFieldInfoPtr_ClanEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommonClientDataSystem.LocalUserData>.NativeClassPtr, nameof (ClanEntity));
        CommonClientDataSystem.LocalUserData.NativeFieldInfoPtr_CharacterPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommonClientDataSystem.LocalUserData>.NativeClassPtr, nameof (CharacterPosition));
        CommonClientDataSystem.LocalUserData.NativeFieldInfoPtr_CharacterRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommonClientDataSystem.LocalUserData>.NativeClassPtr, nameof (CharacterRotation));
        CommonClientDataSystem.LocalUserData.NativeFieldInfoPtr_ControlledPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommonClientDataSystem.LocalUserData>.NativeClassPtr, nameof (ControlledPosition));
        CommonClientDataSystem.LocalUserData.NativeFieldInfoPtr_ControlledRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommonClientDataSystem.LocalUserData>.NativeClassPtr, nameof (ControlledRotation));
        CommonClientDataSystem.LocalUserData.NativeFieldInfoPtr_User = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommonClientDataSystem.LocalUserData>.NativeClassPtr, nameof (User));
        CommonClientDataSystem.LocalUserData.NativeFieldInfoPtr_UserTeam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommonClientDataSystem.LocalUserData>.NativeClassPtr, nameof (UserTeam));
        CommonClientDataSystem.LocalUserData.NativeMethodInfoPtr_get_HasUser_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommonClientDataSystem.LocalUserData>.NativeClassPtr, 100666087);
        CommonClientDataSystem.LocalUserData.NativeMethodInfoPtr_get_HasCharacter_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommonClientDataSystem.LocalUserData>.NativeClassPtr, 100666088);
        CommonClientDataSystem.LocalUserData.NativeMethodInfoPtr_get_HasControlled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommonClientDataSystem.LocalUserData>.NativeClassPtr, 100666089);
        CommonClientDataSystem.LocalUserData.NativeMethodInfoPtr_get_HasCamera_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommonClientDataSystem.LocalUserData>.NativeClassPtr, 100666090);
        CommonClientDataSystem.LocalUserData.NativeMethodInfoPtr_TryGetUser_Public_Boolean_byref_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommonClientDataSystem.LocalUserData>.NativeClassPtr, 100666091);
        CommonClientDataSystem.LocalUserData.NativeMethodInfoPtr_TryGetCharacter_Public_Boolean_byref_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommonClientDataSystem.LocalUserData>.NativeClassPtr, 100666092);
        CommonClientDataSystem.LocalUserData.NativeMethodInfoPtr_TryGetControlled_Public_Boolean_byref_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommonClientDataSystem.LocalUserData>.NativeClassPtr, 100666093);
        CommonClientDataSystem.LocalUserData.NativeMethodInfoPtr_IsAdmin_Public_Boolean_SingletonAccessor_1_SyncedServerDebugSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommonClientDataSystem.LocalUserData>.NativeClassPtr, 100666094);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CommonClientDataSystem.LocalUserData>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
