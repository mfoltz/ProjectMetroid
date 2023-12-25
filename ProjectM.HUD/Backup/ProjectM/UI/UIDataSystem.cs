// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.UIDataSystem
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using ProjectM.Terrain;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Profiling;

#nullable disable
namespace ProjectM.UI
{
  public class UIDataSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_UI;
    private static readonly System.IntPtr NativeFieldInfoPtr_HybridCameraData;
    private static readonly System.IntPtr NativeFieldInfoPtr_TopdownCameraState;
    private static readonly System.IntPtr NativeFieldInfoPtr_CharacterHUDs;
    private static readonly System.IntPtr NativeFieldInfoPtr_LocalUser;
    private static readonly System.IntPtr NativeFieldInfoPtr_ServerTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_DayNightCycle;
    private static readonly System.IntPtr NativeFieldInfoPtr__PrefabCollectionSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__CommonClientDataSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr___TryInitializeCanvasBase_LambdaJob0_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___TryInitializeCanvasBase_LambdaJob0_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateLocalUserData_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryInitializeCanvasBase_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryInitializeBottomBar_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSingletons_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSingleton_Private_Void_byref_Nullable_1_T_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__TryInitializeCanvasBase_b__15_0_Private_Void_Entity_UICanvasBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForTryInitializeCanvasBase_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1288795, XrefRangeEnd = 1288806, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UIDataSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1288806, XrefRangeEnd = 1288814, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UIDataSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1288814, XrefRangeEnd = 1288847, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UIDataSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1288847, XrefRangeEnd = 1288861, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdateLocalUserData()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UIDataSystem.NativeMethodInfoPtr_UpdateLocalUserData_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1288877, RefRangeEnd = 1288878, XrefRangeStart = 1288861, XrefRangeEnd = 1288877, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void TryInitializeCanvasBase()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UIDataSystem.NativeMethodInfoPtr_TryInitializeCanvasBase_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1288902, RefRangeEnd = 1288903, XrefRangeStart = 1288878, XrefRangeEnd = 1288902, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void TryInitializeBottomBar()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UIDataSystem.NativeMethodInfoPtr_TryInitializeBottomBar_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1288903, XrefRangeEnd = 1288920, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdateSingletons()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UIDataSystem.NativeMethodInfoPtr_UpdateSingletons_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1288920, RefRangeEnd = 1288922, XrefRangeStart = 1288920, XrefRangeEnd = 1288920, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdateSingleton<T>(out Il2CppSystem.Nullable<T> singleton)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr3 = &zero;
      *numPtr2 = (System.IntPtr) numPtr3;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UIDataSystem.MethodInfoStoreGeneric_UpdateSingleton_Private_Void_byref_Nullable_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref Il2CppSystem.Nullable<T> local = ref singleton;
      System.IntPtr pointer = zero;
      Il2CppSystem.Nullable<> nullable = pointer == System.IntPtr.Zero ? (Il2CppSystem.Nullable<>) null : new Il2CppSystem.Nullable<>(pointer);
      local = (Il2CppSystem.Nullable<T>) nullable;
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe UIDataSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIDataSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UIDataSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1288923, RefRangeEnd = 1288924, XrefRangeStart = 1288922, XrefRangeEnd = 1288923, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _TryInitializeCanvasBase_b__15_0(Entity entity, UICanvasBase canvas)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) canvas);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UIDataSystem.NativeMethodInfoPtr__TryInitializeCanvasBase_b__15_0_Private_Void_Entity_UICanvasBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1288924, XrefRangeEnd = 1288953, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UIDataSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1288953, XrefRangeEnd = 1288969, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForTryInitializeCanvasBase_LambdaJob0_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UIDataSystem.NativeMethodInfoPtr___GetEntityQuery_ForTryInitializeCanvasBase_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    static UIDataSystem()
    {
      Il2CppClassPointerStore<UIDataSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (UIDataSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIDataSystem>.NativeClassPtr);
      UIDataSystem.NativeFieldInfoPtr_UI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDataSystem>.NativeClassPtr, nameof (UI));
      UIDataSystem.NativeFieldInfoPtr_HybridCameraData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDataSystem>.NativeClassPtr, nameof (HybridCameraData));
      UIDataSystem.NativeFieldInfoPtr_TopdownCameraState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDataSystem>.NativeClassPtr, nameof (TopdownCameraState));
      UIDataSystem.NativeFieldInfoPtr_CharacterHUDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDataSystem>.NativeClassPtr, nameof (CharacterHUDs));
      UIDataSystem.NativeFieldInfoPtr_LocalUser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDataSystem>.NativeClassPtr, nameof (LocalUser));
      UIDataSystem.NativeFieldInfoPtr_ServerTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDataSystem>.NativeClassPtr, nameof (ServerTime));
      UIDataSystem.NativeFieldInfoPtr_DayNightCycle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDataSystem>.NativeClassPtr, nameof (DayNightCycle));
      UIDataSystem.NativeFieldInfoPtr__PrefabCollectionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDataSystem>.NativeClassPtr, nameof (_PrefabCollectionSystem));
      UIDataSystem.NativeFieldInfoPtr__CommonClientDataSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDataSystem>.NativeClassPtr, nameof (_CommonClientDataSystem));
      UIDataSystem.NativeFieldInfoPtr___TryInitializeCanvasBase_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDataSystem>.NativeClassPtr, "<>TryInitializeCanvasBase_LambdaJob0_entityQuery");
      UIDataSystem.NativeFieldInfoPtr___TryInitializeCanvasBase_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDataSystem>.NativeClassPtr, "<>TryInitializeCanvasBase_LambdaJob0_profilerMarker");
      UIDataSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDataSystem>.NativeClassPtr, 100669703);
      UIDataSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDataSystem>.NativeClassPtr, 100669704);
      UIDataSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDataSystem>.NativeClassPtr, 100669705);
      UIDataSystem.NativeMethodInfoPtr_UpdateLocalUserData_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDataSystem>.NativeClassPtr, 100669706);
      UIDataSystem.NativeMethodInfoPtr_TryInitializeCanvasBase_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDataSystem>.NativeClassPtr, 100669707);
      UIDataSystem.NativeMethodInfoPtr_TryInitializeBottomBar_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDataSystem>.NativeClassPtr, 100669708);
      UIDataSystem.NativeMethodInfoPtr_UpdateSingletons_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDataSystem>.NativeClassPtr, 100669709);
      UIDataSystem.NativeMethodInfoPtr_UpdateSingleton_Private_Void_byref_Nullable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDataSystem>.NativeClassPtr, 100669710);
      UIDataSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDataSystem>.NativeClassPtr, 100669711);
      UIDataSystem.NativeMethodInfoPtr__TryInitializeCanvasBase_b__15_0_Private_Void_Entity_UICanvasBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDataSystem>.NativeClassPtr, 100669712);
      UIDataSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDataSystem>.NativeClassPtr, 100669713);
      UIDataSystem.NativeMethodInfoPtr___GetEntityQuery_ForTryInitializeCanvasBase_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDataSystem>.NativeClassPtr, 100669714);
    }

    public UIDataSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public UIDataSystem.UIComponents UI
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIDataSystem.NativeFieldInfoPtr_UI);
        return new UIDataSystem.UIComponents(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UIDataSystem.UIComponents>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIDataSystem.NativeFieldInfoPtr_UI), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UIDataSystem.UIComponents>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe Nullable_Unboxed<ProjectM.HybridCameraData> HybridCameraData
    {
      get
      {
        return *(Nullable_Unboxed<ProjectM.HybridCameraData>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIDataSystem.NativeFieldInfoPtr_HybridCameraData));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIDataSystem.NativeFieldInfoPtr_HybridCameraData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable_Unboxed<ProjectM.HybridCameraData>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe Nullable_Unboxed<ProjectM.TopdownCameraState> TopdownCameraState
    {
      get
      {
        return *(Nullable_Unboxed<ProjectM.TopdownCameraState>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIDataSystem.NativeFieldInfoPtr_TopdownCameraState));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIDataSystem.NativeFieldInfoPtr_TopdownCameraState), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable_Unboxed<ProjectM.TopdownCameraState>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe CharacterHUDEntryCollection CharacterHUDs
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIDataSystem.NativeFieldInfoPtr_CharacterHUDs));
        return pointer == System.IntPtr.Zero ? (CharacterHUDEntryCollection) null : new CharacterHUDEntryCollection(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIDataSystem.NativeFieldInfoPtr_CharacterHUDs), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe UIDataSystem.LocalUserData LocalUser
    {
      get
      {
        return *(UIDataSystem.LocalUserData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIDataSystem.NativeFieldInfoPtr_LocalUser));
      }
      [param: In] set
      {
        *(UIDataSystem.LocalUserData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIDataSystem.NativeFieldInfoPtr_LocalUser)) = value;
      }
    }

    public unsafe Nullable_Unboxed<ProjectM.ServerTime> ServerTime
    {
      get
      {
        return *(Nullable_Unboxed<ProjectM.ServerTime>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIDataSystem.NativeFieldInfoPtr_ServerTime));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIDataSystem.NativeFieldInfoPtr_ServerTime), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable_Unboxed<ProjectM.ServerTime>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe Nullable_Unboxed<ProjectM.DayNightCycle> DayNightCycle
    {
      get
      {
        return *(Nullable_Unboxed<ProjectM.DayNightCycle>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIDataSystem.NativeFieldInfoPtr_DayNightCycle));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIDataSystem.NativeFieldInfoPtr_DayNightCycle), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable_Unboxed<ProjectM.DayNightCycle>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe PrefabCollectionSystem _PrefabCollectionSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIDataSystem.NativeFieldInfoPtr__PrefabCollectionSystem));
        return pointer == System.IntPtr.Zero ? (PrefabCollectionSystem) null : new PrefabCollectionSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIDataSystem.NativeFieldInfoPtr__PrefabCollectionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CommonClientDataSystem _CommonClientDataSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIDataSystem.NativeFieldInfoPtr__CommonClientDataSystem));
        return pointer == System.IntPtr.Zero ? (CommonClientDataSystem) null : new CommonClientDataSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIDataSystem.NativeFieldInfoPtr__CommonClientDataSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityQuery __TryInitializeCanvasBase_LambdaJob0_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIDataSystem.NativeFieldInfoPtr___TryInitializeCanvasBase_LambdaJob0_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIDataSystem.NativeFieldInfoPtr___TryInitializeCanvasBase_LambdaJob0_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __TryInitializeCanvasBase_LambdaJob0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIDataSystem.NativeFieldInfoPtr___TryInitializeCanvasBase_LambdaJob0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIDataSystem.NativeFieldInfoPtr___TryInitializeCanvasBase_LambdaJob0_profilerMarker)) = value;
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct LocalUserData
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_ProgressionEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr_MapZoneEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr_WorldZone;
      private static readonly System.IntPtr NativeMethodInfoPtr_get_HasProgressionEntity_Public_get_Boolean_0;
      [FieldOffset(0)]
      public Entity ProgressionEntity;
      [FieldOffset(8)]
      public Entity MapZoneEntity;
      [FieldOffset(16)]
      public WorldZone WorldZone;

      public unsafe bool HasProgressionEntity
      {
        [CallerCount(18), CachedScanResults(RefRangeStart = 750559, RefRangeEnd = 750577, XrefRangeStart = 750559, XrefRangeEnd = 750577, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UIDataSystem.LocalUserData.NativeMethodInfoPtr_get_HasProgressionEntity_Public_get_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      static LocalUserData()
      {
        Il2CppClassPointerStore<UIDataSystem.LocalUserData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIDataSystem>.NativeClassPtr, nameof (LocalUserData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIDataSystem.LocalUserData>.NativeClassPtr);
        UIDataSystem.LocalUserData.NativeFieldInfoPtr_ProgressionEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDataSystem.LocalUserData>.NativeClassPtr, nameof (ProgressionEntity));
        UIDataSystem.LocalUserData.NativeFieldInfoPtr_MapZoneEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDataSystem.LocalUserData>.NativeClassPtr, nameof (MapZoneEntity));
        UIDataSystem.LocalUserData.NativeFieldInfoPtr_WorldZone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDataSystem.LocalUserData>.NativeClassPtr, nameof (WorldZone));
        UIDataSystem.LocalUserData.NativeMethodInfoPtr_get_HasProgressionEntity_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDataSystem.LocalUserData>.NativeClassPtr, 100669715);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UIDataSystem.LocalUserData>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    public sealed class UIComponents : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_CanvasBase;
      private static readonly System.IntPtr NativeFieldInfoPtr_BottomBar;
      private static readonly System.IntPtr NativeFieldInfoPtr_AbilityBar;
      private static readonly System.IntPtr NativeFieldInfoPtr_ActionBar;
      private static readonly System.IntPtr NativeFieldInfoPtr_BiteParent;
      private static readonly System.IntPtr NativeFieldInfoPtr_BuffBarParent;

      static UIComponents()
      {
        Il2CppClassPointerStore<UIDataSystem.UIComponents>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIDataSystem>.NativeClassPtr, nameof (UIComponents));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIDataSystem.UIComponents>.NativeClassPtr);
        UIDataSystem.UIComponents.NativeFieldInfoPtr_CanvasBase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDataSystem.UIComponents>.NativeClassPtr, nameof (CanvasBase));
        UIDataSystem.UIComponents.NativeFieldInfoPtr_BottomBar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDataSystem.UIComponents>.NativeClassPtr, nameof (BottomBar));
        UIDataSystem.UIComponents.NativeFieldInfoPtr_AbilityBar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDataSystem.UIComponents>.NativeClassPtr, nameof (AbilityBar));
        UIDataSystem.UIComponents.NativeFieldInfoPtr_ActionBar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDataSystem.UIComponents>.NativeClassPtr, nameof (ActionBar));
        UIDataSystem.UIComponents.NativeFieldInfoPtr_BiteParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDataSystem.UIComponents>.NativeClassPtr, nameof (BiteParent));
        UIDataSystem.UIComponents.NativeFieldInfoPtr_BuffBarParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDataSystem.UIComponents>.NativeClassPtr, nameof (BuffBarParent));
      }

      public UIComponents(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public UIComponents()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UIDataSystem.UIComponents>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UIDataSystem.UIComponents>.NativeClassPtr, data));
      }

      public unsafe UICanvasBase CanvasBase
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIDataSystem.UIComponents.NativeFieldInfoPtr_CanvasBase));
          return pointer == System.IntPtr.Zero ? (UICanvasBase) null : new UICanvasBase(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIDataSystem.UIComponents.NativeFieldInfoPtr_CanvasBase), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe BottomBarParent BottomBar
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIDataSystem.UIComponents.NativeFieldInfoPtr_BottomBar));
          return pointer == System.IntPtr.Zero ? (BottomBarParent) null : new BottomBarParent(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIDataSystem.UIComponents.NativeFieldInfoPtr_BottomBar), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe AbilityBarParent AbilityBar
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIDataSystem.UIComponents.NativeFieldInfoPtr_AbilityBar));
          return pointer == System.IntPtr.Zero ? (AbilityBarParent) null : new AbilityBarParent(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIDataSystem.UIComponents.NativeFieldInfoPtr_AbilityBar), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe ActionBarParent ActionBar
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIDataSystem.UIComponents.NativeFieldInfoPtr_ActionBar));
          return pointer == System.IntPtr.Zero ? (ActionBarParent) null : new ActionBarParent(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIDataSystem.UIComponents.NativeFieldInfoPtr_ActionBar), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe BiteParent BiteParent
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIDataSystem.UIComponents.NativeFieldInfoPtr_BiteParent));
          return pointer == System.IntPtr.Zero ? (BiteParent) null : new BiteParent(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIDataSystem.UIComponents.NativeFieldInfoPtr_BiteParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe BuffBarParent BuffBarParent
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIDataSystem.UIComponents.NativeFieldInfoPtr_BuffBarParent));
          return pointer == System.IntPtr.Zero ? (BuffBarParent) null : new BuffBarParent(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIDataSystem.UIComponents.NativeFieldInfoPtr_BuffBarParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.UI.UIDataSystem/ProjectM.UI.<>c__DisplayClass_TryInitializeCanvasBase_LambdaJob0")]
    public sealed class __c__DisplayClass_TryInitializeCanvasBase_LambdaJob0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_hostInstance;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Public_Void_Entity_UICanvasBase_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_UIDataSystem_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1288776, RefRangeEnd = 1288777, XrefRangeStart = 1288774, XrefRangeEnd = 1288776, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(Entity entity, UICanvasBase canvas)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) canvas);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UIDataSystem.__c__DisplayClass_TryInitializeCanvasBase_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Public_Void_Entity_UICanvasBase_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1288777, XrefRangeEnd = 1288779, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(UIDataSystem.__c__DisplayClass_TryInitializeCanvasBase_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1288785, RefRangeEnd = 1288786, XrefRangeStart = 1288779, XrefRangeEnd = 1288785, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref UIDataSystem.__c__DisplayClass_TryInitializeCanvasBase_LambdaJob0.LambdaParameterValueProviders.Runtimes runtimes)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) runtimes);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UIDataSystem.__c__DisplayClass_TryInitializeCanvasBase_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1288788, RefRangeEnd = 1288789, XrefRangeStart = 1288786, XrefRangeEnd = 1288788, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(UIDataSystem componentSystem)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UIDataSystem.__c__DisplayClass_TryInitializeCanvasBase_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_UIDataSystem_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1288789, XrefRangeEnd = 1288795, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UIDataSystem.__c__DisplayClass_TryInitializeCanvasBase_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_TryInitializeCanvasBase_LambdaJob0()
      {
        Il2CppClassPointerStore<UIDataSystem.__c__DisplayClass_TryInitializeCanvasBase_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIDataSystem>.NativeClassPtr, "<>c__DisplayClass_TryInitializeCanvasBase_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIDataSystem.__c__DisplayClass_TryInitializeCanvasBase_LambdaJob0>.NativeClassPtr);
        UIDataSystem.__c__DisplayClass_TryInitializeCanvasBase_LambdaJob0.NativeFieldInfoPtr_hostInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDataSystem.__c__DisplayClass_TryInitializeCanvasBase_LambdaJob0>.NativeClassPtr, nameof (hostInstance));
        UIDataSystem.__c__DisplayClass_TryInitializeCanvasBase_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDataSystem.__c__DisplayClass_TryInitializeCanvasBase_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        UIDataSystem.__c__DisplayClass_TryInitializeCanvasBase_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDataSystem.__c__DisplayClass_TryInitializeCanvasBase_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
        UIDataSystem.__c__DisplayClass_TryInitializeCanvasBase_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDataSystem.__c__DisplayClass_TryInitializeCanvasBase_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        UIDataSystem.__c__DisplayClass_TryInitializeCanvasBase_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Public_Void_Entity_UICanvasBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDataSystem.__c__DisplayClass_TryInitializeCanvasBase_LambdaJob0>.NativeClassPtr, 100669716);
        UIDataSystem.__c__DisplayClass_TryInitializeCanvasBase_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDataSystem.__c__DisplayClass_TryInitializeCanvasBase_LambdaJob0>.NativeClassPtr, 100669717);
        UIDataSystem.__c__DisplayClass_TryInitializeCanvasBase_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDataSystem.__c__DisplayClass_TryInitializeCanvasBase_LambdaJob0>.NativeClassPtr, 100669718);
        UIDataSystem.__c__DisplayClass_TryInitializeCanvasBase_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_UIDataSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDataSystem.__c__DisplayClass_TryInitializeCanvasBase_LambdaJob0>.NativeClassPtr, 100669719);
        UIDataSystem.__c__DisplayClass_TryInitializeCanvasBase_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDataSystem.__c__DisplayClass_TryInitializeCanvasBase_LambdaJob0>.NativeClassPtr, 100669720);
      }

      public __c__DisplayClass_TryInitializeCanvasBase_LambdaJob0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass_TryInitializeCanvasBase_LambdaJob0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UIDataSystem.__c__DisplayClass_TryInitializeCanvasBase_LambdaJob0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UIDataSystem.__c__DisplayClass_TryInitializeCanvasBase_LambdaJob0>.NativeClassPtr, data));
      }

      public unsafe UIDataSystem hostInstance
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIDataSystem.__c__DisplayClass_TryInitializeCanvasBase_LambdaJob0.NativeFieldInfoPtr_hostInstance));
          return pointer == System.IntPtr.Zero ? (UIDataSystem) null : new UIDataSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIDataSystem.__c__DisplayClass_TryInitializeCanvasBase_LambdaJob0.NativeFieldInfoPtr_hostInstance), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe UIDataSystem.__c__DisplayClass_TryInitializeCanvasBase_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders
      {
        get
        {
          return *(UIDataSystem.__c__DisplayClass_TryInitializeCanvasBase_LambdaJob0.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIDataSystem.__c__DisplayClass_TryInitializeCanvasBase_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders));
        }
        [param: In] set
        {
          *(UIDataSystem.__c__DisplayClass_TryInitializeCanvasBase_LambdaJob0.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIDataSystem.__c__DisplayClass_TryInitializeCanvasBase_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders)) = value;
        }
      }

      public unsafe UIDataSystem.__c__DisplayClass_TryInitializeCanvasBase_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes
      {
        get
        {
          return (UIDataSystem.__c__DisplayClass_TryInitializeCanvasBase_LambdaJob0.LambdaParameterValueProviders.Runtimes*) (void*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIDataSystem.__c__DisplayClass_TryInitializeCanvasBase_LambdaJob0.NativeFieldInfoPtr__runtimes));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIDataSystem.__c__DisplayClass_TryInitializeCanvasBase_LambdaJob0.NativeFieldInfoPtr__runtimes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) (System.IntPtr) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(UIDataSystem.__c__DisplayClass_TryInitializeCanvasBase_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(UIDataSystem.__c__DisplayClass_TryInitializeCanvasBase_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_canvas;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_UIDataSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_ManagedComponentData<UICanvasBase> forParameter_canvas;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1288767, RefRangeEnd = 1288768, XrefRangeStart = 1288763, XrefRangeEnd = 1288767, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(UIDataSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(UIDataSystem.__c__DisplayClass_TryInitializeCanvasBase_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_UIDataSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1288773, RefRangeEnd = 1288774, XrefRangeStart = 1288768, XrefRangeEnd = 1288773, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe UIDataSystem.__c__DisplayClass_TryInitializeCanvasBase_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(UIDataSystem.__c__DisplayClass_TryInitializeCanvasBase_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return new UIDataSystem.__c__DisplayClass_TryInitializeCanvasBase_LambdaJob0.LambdaParameterValueProviders.Runtimes(pointer);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<UIDataSystem.__c__DisplayClass_TryInitializeCanvasBase_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIDataSystem.__c__DisplayClass_TryInitializeCanvasBase_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          UIDataSystem.__c__DisplayClass_TryInitializeCanvasBase_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDataSystem.__c__DisplayClass_TryInitializeCanvasBase_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          UIDataSystem.__c__DisplayClass_TryInitializeCanvasBase_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDataSystem.__c__DisplayClass_TryInitializeCanvasBase_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_canvas));
          UIDataSystem.__c__DisplayClass_TryInitializeCanvasBase_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_UIDataSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDataSystem.__c__DisplayClass_TryInitializeCanvasBase_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100669721);
          UIDataSystem.__c__DisplayClass_TryInitializeCanvasBase_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDataSystem.__c__DisplayClass_TryInitializeCanvasBase_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100669722);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UIDataSystem.__c__DisplayClass_TryInitializeCanvasBase_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        public sealed class Runtimes : Il2CppSystem.ValueType
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_canvas;

          static Runtimes()
          {
            Il2CppClassPointerStore<UIDataSystem.__c__DisplayClass_TryInitializeCanvasBase_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIDataSystem.__c__DisplayClass_TryInitializeCanvasBase_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            UIDataSystem.__c__DisplayClass_TryInitializeCanvasBase_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDataSystem.__c__DisplayClass_TryInitializeCanvasBase_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            UIDataSystem.__c__DisplayClass_TryInitializeCanvasBase_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDataSystem.__c__DisplayClass_TryInitializeCanvasBase_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_canvas));
          }

          public Runtimes(System.IntPtr pointer)
            : base(pointer)
          {
          }

          public Runtimes()
          {
            // ISSUE: cast to a reference type
            // ISSUE: untyped stack allocation
            System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UIDataSystem.__c__DisplayClass_TryInitializeCanvasBase_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (uint&) System.IntPtr.Zero));
            // ISSUE: explicit constructor call
            base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UIDataSystem.__c__DisplayClass_TryInitializeCanvasBase_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, data));
          }

          public unsafe LambdaParameterValueProvider_Entity.Runtime runtime_entity
          {
            get
            {
              return *(LambdaParameterValueProvider_Entity.Runtime*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIDataSystem.__c__DisplayClass_TryInitializeCanvasBase_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity));
            }
            [param: In] set
            {
              *(LambdaParameterValueProvider_Entity.Runtime*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIDataSystem.__c__DisplayClass_TryInitializeCanvasBase_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity)) = value;
            }
          }

          public LambdaParameterValueProvider_ManagedComponentData<UICanvasBase>.Runtime runtime_canvas
          {
            get
            {
              System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIDataSystem.__c__DisplayClass_TryInitializeCanvasBase_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_canvas);
              return new LambdaParameterValueProvider_ManagedComponentData<UICanvasBase>.Runtime(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LambdaParameterValueProvider_ManagedComponentData<UICanvasBase>.Runtime>.NativeClassPtr, data));
            }
            [param: In] set
            {
              __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIDataSystem.__c__DisplayClass_TryInitializeCanvasBase_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_canvas), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<LambdaParameterValueProvider_ManagedComponentData<UICanvasBase>.Runtime>.NativeClassPtr, (uint&) System.IntPtr.Zero));
            }
          }
        }
      }
    }

    private sealed class MethodInfoStoreGeneric_UpdateSingleton_Private_Void_byref_Nullable_1_T_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(UIDataSystem.NativeMethodInfoPtr_UpdateSingleton_Private_Void_byref_Nullable_1_T_0, Il2CppClassPointerStore<UIDataSystem>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }
  }
}
