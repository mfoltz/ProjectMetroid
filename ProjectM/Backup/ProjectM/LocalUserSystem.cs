// Decompiled with JetBrains decompiler
// Type: ProjectM.LocalUserSystem
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Transforms;

#nullable disable
namespace ProjectM
{
  public class LocalUserSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__CameraRequest;
    private static readonly System.IntPtr NativeFieldInfoPtr__SetLocalUserEventQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__UserQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__RunSystemQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__PrefabCollectionSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__CameraEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr__CameraType;
    private static readonly System.IntPtr NativeFieldInfoPtr__SingletonEntityQuery_ClientNetworkState_20;
    private static readonly System.IntPtr NativeFieldInfoPtr__SingletonEntityQuery_CameraRequest_21;
    private static readonly System.IntPtr NativeFieldInfoPtr__SingletonEntityQuery_LocalUser_22;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ClearCameraRequest_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetOrbitCamera_Public_Void_Nullable_Unboxed_1_Entity_Nullable_Unboxed_1_Translation_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetFreeCamera_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetStaticCamera_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetTopDownCamera_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateCamera_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MakeLocalUserAndAssignCamera_Private_Void_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryAssignCameraToLocalUser_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryUnassignCamera_Private_Void_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1023552, XrefRangeEnd = 1023638, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LocalUserSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ClearCameraRequest()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LocalUserSystem.NativeMethodInfoPtr_ClearCameraRequest_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1023638, XrefRangeEnd = 1023656, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetOrbitCamera(
      Nullable_Unboxed<Entity> targetEntity = default (Nullable_Unboxed<Entity>),
      Nullable_Unboxed<Translation> targetPosition = default (Nullable_Unboxed<Translation>))
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &targetEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &targetPosition;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LocalUserSystem.NativeMethodInfoPtr_SetOrbitCamera_Public_Void_Nullable_Unboxed_1_Entity_Nullable_Unboxed_1_Translation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1023656, XrefRangeEnd = 1023674, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetFreeCamera()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LocalUserSystem.NativeMethodInfoPtr_SetFreeCamera_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1023674, XrefRangeEnd = 1023692, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetStaticCamera()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LocalUserSystem.NativeMethodInfoPtr_SetStaticCamera_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1023692, XrefRangeEnd = 1023710, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetTopDownCamera()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LocalUserSystem.NativeMethodInfoPtr_SetTopDownCamera_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1023710, XrefRangeEnd = 1023735, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LocalUserSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1023822, RefRangeEnd = 1023823, XrefRangeStart = 1023735, XrefRangeEnd = 1023822, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdateCamera()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LocalUserSystem.NativeMethodInfoPtr_UpdateCamera_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1023893, RefRangeEnd = 1023894, XrefRangeStart = 1023823, XrefRangeEnd = 1023893, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void MakeLocalUserAndAssignCamera(Entity userEntity)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &userEntity;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LocalUserSystem.NativeMethodInfoPtr_MakeLocalUserAndAssignCamera_Private_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1023927, RefRangeEnd = 1023929, XrefRangeStart = 1023894, XrefRangeEnd = 1023927, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void TryAssignCameraToLocalUser()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LocalUserSystem.NativeMethodInfoPtr_TryAssignCameraToLocalUser_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1023945, RefRangeEnd = 1023948, XrefRangeStart = 1023929, XrefRangeEnd = 1023945, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void TryUnassignCamera(Entity lastCamera)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &lastCamera;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LocalUserSystem.NativeMethodInfoPtr_TryUnassignCamera_Private_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe LocalUserSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalUserSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LocalUserSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1023948, XrefRangeEnd = 1023968, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LocalUserSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static LocalUserSystem()
    {
      Il2CppClassPointerStore<LocalUserSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (LocalUserSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalUserSystem>.NativeClassPtr);
      LocalUserSystem.NativeFieldInfoPtr__CameraRequest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalUserSystem>.NativeClassPtr, nameof (_CameraRequest));
      LocalUserSystem.NativeFieldInfoPtr__SetLocalUserEventQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalUserSystem>.NativeClassPtr, nameof (_SetLocalUserEventQuery));
      LocalUserSystem.NativeFieldInfoPtr__UserQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalUserSystem>.NativeClassPtr, nameof (_UserQuery));
      LocalUserSystem.NativeFieldInfoPtr__RunSystemQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalUserSystem>.NativeClassPtr, nameof (_RunSystemQuery));
      LocalUserSystem.NativeFieldInfoPtr__PrefabCollectionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalUserSystem>.NativeClassPtr, nameof (_PrefabCollectionSystem));
      LocalUserSystem.NativeFieldInfoPtr__CameraEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalUserSystem>.NativeClassPtr, nameof (_CameraEntity));
      LocalUserSystem.NativeFieldInfoPtr__CameraType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalUserSystem>.NativeClassPtr, nameof (_CameraType));
      LocalUserSystem.NativeFieldInfoPtr__SingletonEntityQuery_ClientNetworkState_20 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalUserSystem>.NativeClassPtr, nameof (_SingletonEntityQuery_ClientNetworkState_20));
      LocalUserSystem.NativeFieldInfoPtr__SingletonEntityQuery_CameraRequest_21 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalUserSystem>.NativeClassPtr, nameof (_SingletonEntityQuery_CameraRequest_21));
      LocalUserSystem.NativeFieldInfoPtr__SingletonEntityQuery_LocalUser_22 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalUserSystem>.NativeClassPtr, nameof (_SingletonEntityQuery_LocalUser_22));
      LocalUserSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalUserSystem>.NativeClassPtr, 100679945);
      LocalUserSystem.NativeMethodInfoPtr_ClearCameraRequest_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalUserSystem>.NativeClassPtr, 100679946);
      LocalUserSystem.NativeMethodInfoPtr_SetOrbitCamera_Public_Void_Nullable_Unboxed_1_Entity_Nullable_Unboxed_1_Translation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalUserSystem>.NativeClassPtr, 100679947);
      LocalUserSystem.NativeMethodInfoPtr_SetFreeCamera_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalUserSystem>.NativeClassPtr, 100679948);
      LocalUserSystem.NativeMethodInfoPtr_SetStaticCamera_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalUserSystem>.NativeClassPtr, 100679949);
      LocalUserSystem.NativeMethodInfoPtr_SetTopDownCamera_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalUserSystem>.NativeClassPtr, 100679950);
      LocalUserSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalUserSystem>.NativeClassPtr, 100679951);
      LocalUserSystem.NativeMethodInfoPtr_UpdateCamera_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalUserSystem>.NativeClassPtr, 100679952);
      LocalUserSystem.NativeMethodInfoPtr_MakeLocalUserAndAssignCamera_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalUserSystem>.NativeClassPtr, 100679953);
      LocalUserSystem.NativeMethodInfoPtr_TryAssignCameraToLocalUser_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalUserSystem>.NativeClassPtr, 100679954);
      LocalUserSystem.NativeMethodInfoPtr_TryUnassignCamera_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalUserSystem>.NativeClassPtr, 100679955);
      LocalUserSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalUserSystem>.NativeClassPtr, 100679956);
      LocalUserSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalUserSystem>.NativeClassPtr, 100679957);
    }

    public LocalUserSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe EntityQuery _CameraRequest
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LocalUserSystem.NativeFieldInfoPtr__CameraRequest));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LocalUserSystem.NativeFieldInfoPtr__CameraRequest)) = value;
      }
    }

    public unsafe EntityQuery _SetLocalUserEventQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LocalUserSystem.NativeFieldInfoPtr__SetLocalUserEventQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LocalUserSystem.NativeFieldInfoPtr__SetLocalUserEventQuery)) = value;
      }
    }

    public unsafe EntityQuery _UserQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LocalUserSystem.NativeFieldInfoPtr__UserQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LocalUserSystem.NativeFieldInfoPtr__UserQuery)) = value;
      }
    }

    public unsafe EntityQuery _RunSystemQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LocalUserSystem.NativeFieldInfoPtr__RunSystemQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LocalUserSystem.NativeFieldInfoPtr__RunSystemQuery)) = value;
      }
    }

    public unsafe PrefabCollectionSystem _PrefabCollectionSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LocalUserSystem.NativeFieldInfoPtr__PrefabCollectionSystem));
        return pointer == System.IntPtr.Zero ? (PrefabCollectionSystem) null : new PrefabCollectionSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LocalUserSystem.NativeFieldInfoPtr__PrefabCollectionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Entity _CameraEntity
    {
      get
      {
        return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LocalUserSystem.NativeFieldInfoPtr__CameraEntity));
      }
      [param: In] set
      {
        *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LocalUserSystem.NativeFieldInfoPtr__CameraEntity)) = value;
      }
    }

    public unsafe CameraType _CameraType
    {
      get
      {
        return *(CameraType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LocalUserSystem.NativeFieldInfoPtr__CameraType));
      }
      [param: In] set
      {
        *(CameraType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LocalUserSystem.NativeFieldInfoPtr__CameraType)) = value;
      }
    }

    public unsafe EntityQuery _SingletonEntityQuery_ClientNetworkState_20
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LocalUserSystem.NativeFieldInfoPtr__SingletonEntityQuery_ClientNetworkState_20));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LocalUserSystem.NativeFieldInfoPtr__SingletonEntityQuery_ClientNetworkState_20)) = value;
      }
    }

    public unsafe EntityQuery _SingletonEntityQuery_CameraRequest_21
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LocalUserSystem.NativeFieldInfoPtr__SingletonEntityQuery_CameraRequest_21));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LocalUserSystem.NativeFieldInfoPtr__SingletonEntityQuery_CameraRequest_21)) = value;
      }
    }

    public unsafe EntityQuery _SingletonEntityQuery_LocalUser_22
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LocalUserSystem.NativeFieldInfoPtr__SingletonEntityQuery_LocalUser_22));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LocalUserSystem.NativeFieldInfoPtr__SingletonEntityQuery_LocalUser_22)) = value;
      }
    }
  }
}
