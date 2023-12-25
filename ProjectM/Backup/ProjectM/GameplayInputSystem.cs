// Decompiled with JetBrains decompiler
// Type: ProjectM.GameplayInputSystem
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Network;
using ProjectM.Tiles;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Mathematics;
using Unity.Profiling;
using Unity.Transforms;

#nullable disable
namespace ProjectM
{
  public class GameplayInputSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__InputSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__LastValidAimDirection;
    private static readonly System.IntPtr NativeFieldInfoPtr__InputState;
    private static readonly System.IntPtr NativeFieldInfoPtr__LastInputState;
    private static readonly System.IntPtr NativeFieldInfoPtr__TileWorldSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__IsAutoMoving;
    private static readonly System.IntPtr NativeFieldInfoPtr___UpdatePlayerInputs_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___UpdatePlayerInputs_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr__SingletonEntityQuery_LocalCharacter_29;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetConsumedInputs_Public_Virtual_Final_New_Void_byref_BlockInputState_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnStartRunning_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnStopRunning_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HandleInput_Public_Virtual_Final_New_Void_InputState_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetProjectileAimPosition_Private_Static_float3_InputState_float3_byref_TileWorld_byref_AimDirectionType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForUpdatePlayerInputs_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_0;

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void GetConsumedInputs(ref BlockInputState blockInputState)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref blockInputState;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GameplayInputSystem.NativeMethodInfoPtr_GetConsumedInputs_Public_Virtual_Final_New_Void_byref_BlockInputState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1046186, XrefRangeEnd = 1046194, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), GameplayInputSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1046194, XrefRangeEnd = 1046196, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnStartRunning()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), GameplayInputSystem.NativeMethodInfoPtr_OnStartRunning_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1046196, XrefRangeEnd = 1046198, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnStopRunning()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), GameplayInputSystem.NativeMethodInfoPtr_OnStopRunning_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1046198, XrefRangeEnd = 1046201, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void HandleInput(InputState inputState)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &inputState;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GameplayInputSystem.NativeMethodInfoPtr_HandleInput_Public_Virtual_Final_New_Void_InputState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1046201, XrefRangeEnd = 1046230, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), GameplayInputSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1046239, RefRangeEnd = 1046240, XrefRangeStart = 1046230, XrefRangeEnd = 1046239, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe float3 GetProjectileAimPosition(
      InputState inputState,
      float3 characterPosition,
      ref TileWorld tileWorld,
      out AimDirectionType projectileAimType)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &inputState;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &characterPosition;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref tileWorld;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref projectileAimType;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameplayInputSystem.NativeMethodInfoPtr_GetProjectileAimPosition_Private_Static_float3_InputState_float3_byref_TileWorld_byref_AimDirectionType_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float3*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1046240, XrefRangeEnd = 1046241, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe GameplayInputSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameplayInputSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GameplayInputSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1046241, XrefRangeEnd = 1046266, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), GameplayInputSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1046291, RefRangeEnd = 1046292, XrefRangeStart = 1046266, XrefRangeEnd = 1046291, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForUpdatePlayerInputs_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameplayInputSystem.NativeMethodInfoPtr___GetEntityQuery_ForUpdatePlayerInputs_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1046296, RefRangeEnd = 1046297, XrefRangeStart = 1046292, XrefRangeEnd = 1046296, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GameplayInputSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static GameplayInputSystem()
    {
      Il2CppClassPointerStore<GameplayInputSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (GameplayInputSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameplayInputSystem>.NativeClassPtr);
      GameplayInputSystem.NativeFieldInfoPtr__InputSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayInputSystem>.NativeClassPtr, nameof (_InputSystem));
      GameplayInputSystem.NativeFieldInfoPtr__LastValidAimDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayInputSystem>.NativeClassPtr, nameof (_LastValidAimDirection));
      GameplayInputSystem.NativeFieldInfoPtr__InputState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayInputSystem>.NativeClassPtr, nameof (_InputState));
      GameplayInputSystem.NativeFieldInfoPtr__LastInputState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayInputSystem>.NativeClassPtr, nameof (_LastInputState));
      GameplayInputSystem.NativeFieldInfoPtr__TileWorldSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayInputSystem>.NativeClassPtr, nameof (_TileWorldSystem));
      GameplayInputSystem.NativeFieldInfoPtr__IsAutoMoving = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayInputSystem>.NativeClassPtr, nameof (_IsAutoMoving));
      GameplayInputSystem.NativeFieldInfoPtr___UpdatePlayerInputs_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayInputSystem>.NativeClassPtr, "<>UpdatePlayerInputs_entityQuery");
      GameplayInputSystem.NativeFieldInfoPtr___UpdatePlayerInputs_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayInputSystem>.NativeClassPtr, "<>UpdatePlayerInputs_profilerMarker");
      GameplayInputSystem.NativeFieldInfoPtr__SingletonEntityQuery_LocalCharacter_29 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayInputSystem>.NativeClassPtr, nameof (_SingletonEntityQuery_LocalCharacter_29));
      GameplayInputSystem.NativeMethodInfoPtr_GetConsumedInputs_Public_Virtual_Final_New_Void_byref_BlockInputState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayInputSystem>.NativeClassPtr, 100681956);
      GameplayInputSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayInputSystem>.NativeClassPtr, 100681957);
      GameplayInputSystem.NativeMethodInfoPtr_OnStartRunning_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayInputSystem>.NativeClassPtr, 100681958);
      GameplayInputSystem.NativeMethodInfoPtr_OnStopRunning_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayInputSystem>.NativeClassPtr, 100681959);
      GameplayInputSystem.NativeMethodInfoPtr_HandleInput_Public_Virtual_Final_New_Void_InputState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayInputSystem>.NativeClassPtr, 100681960);
      GameplayInputSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayInputSystem>.NativeClassPtr, 100681961);
      GameplayInputSystem.NativeMethodInfoPtr_GetProjectileAimPosition_Private_Static_float3_InputState_float3_byref_TileWorld_byref_AimDirectionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayInputSystem>.NativeClassPtr, 100681962);
      GameplayInputSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayInputSystem>.NativeClassPtr, 100681963);
      GameplayInputSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayInputSystem>.NativeClassPtr, 100681964);
      GameplayInputSystem.NativeMethodInfoPtr___GetEntityQuery_ForUpdatePlayerInputs_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayInputSystem>.NativeClassPtr, 100681965);
      GameplayInputSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayInputSystem>.NativeClassPtr, 100681966);
    }

    public GameplayInputSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe InputSystem _InputSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameplayInputSystem.NativeFieldInfoPtr__InputSystem));
        return pointer == System.IntPtr.Zero ? (InputSystem) null : new InputSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameplayInputSystem.NativeFieldInfoPtr__InputSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float3 _LastValidAimDirection
    {
      get
      {
        return *(float3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameplayInputSystem.NativeFieldInfoPtr__LastValidAimDirection));
      }
      [param: In] set
      {
        *(float3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameplayInputSystem.NativeFieldInfoPtr__LastValidAimDirection)) = value;
      }
    }

    public unsafe InputState _InputState
    {
      get
      {
        return *(InputState*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameplayInputSystem.NativeFieldInfoPtr__InputState));
      }
      [param: In] set
      {
        *(InputState*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameplayInputSystem.NativeFieldInfoPtr__InputState)) = value;
      }
    }

    public unsafe InputState _LastInputState
    {
      get
      {
        return *(InputState*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameplayInputSystem.NativeFieldInfoPtr__LastInputState));
      }
      [param: In] set
      {
        *(InputState*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameplayInputSystem.NativeFieldInfoPtr__LastInputState)) = value;
      }
    }

    public unsafe TileWorldSystem _TileWorldSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameplayInputSystem.NativeFieldInfoPtr__TileWorldSystem));
        return pointer == System.IntPtr.Zero ? (TileWorldSystem) null : new TileWorldSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameplayInputSystem.NativeFieldInfoPtr__TileWorldSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool _IsAutoMoving
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameplayInputSystem.NativeFieldInfoPtr__IsAutoMoving));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameplayInputSystem.NativeFieldInfoPtr__IsAutoMoving)) = value;
      }
    }

    public unsafe EntityQuery __UpdatePlayerInputs_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameplayInputSystem.NativeFieldInfoPtr___UpdatePlayerInputs_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameplayInputSystem.NativeFieldInfoPtr___UpdatePlayerInputs_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __UpdatePlayerInputs_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameplayInputSystem.NativeFieldInfoPtr___UpdatePlayerInputs_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameplayInputSystem.NativeFieldInfoPtr___UpdatePlayerInputs_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery _SingletonEntityQuery_LocalCharacter_29
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameplayInputSystem.NativeFieldInfoPtr__SingletonEntityQuery_LocalCharacter_29));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameplayInputSystem.NativeFieldInfoPtr__SingletonEntityQuery_LocalCharacter_29)) = value;
      }
    }

    [ObfuscatedName("ProjectM.GameplayInputSystem/<>c__DisplayClass11_0")]
    public sealed class __c__DisplayClass11_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_lastInputState;
      private static readonly System.IntPtr NativeFieldInfoPtr_inputState;
      private static readonly System.IntPtr NativeFieldInfoPtr_isAutoMoving;
      private static readonly System.IntPtr NativeFieldInfoPtr_resetMovementCameraDirection;
      private static readonly System.IntPtr NativeFieldInfoPtr_lastValidAimDirection;
      private static readonly System.IntPtr NativeFieldInfoPtr_tileWorld;
      private static readonly System.IntPtr NativeFieldInfoPtr_localCharacter;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_CameraUser_byref_Translation_byref_Controller_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass11_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameplayInputSystem.__c__DisplayClass11_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameplayInputSystem.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0(
        Entity entity,
        [In] ref CameraUser cameraUser,
        [In] ref Translation translation,
        [In] ref Controller controller)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref cameraUser;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref translation;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref controller;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameplayInputSystem.__c__DisplayClass11_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_CameraUser_byref_Translation_byref_Controller_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass11_0()
      {
        Il2CppClassPointerStore<GameplayInputSystem.__c__DisplayClass11_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameplayInputSystem>.NativeClassPtr, "<>c__DisplayClass11_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameplayInputSystem.__c__DisplayClass11_0>.NativeClassPtr);
        GameplayInputSystem.__c__DisplayClass11_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayInputSystem.__c__DisplayClass11_0>.NativeClassPtr, "<>4__this");
        GameplayInputSystem.__c__DisplayClass11_0.NativeFieldInfoPtr_lastInputState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayInputSystem.__c__DisplayClass11_0>.NativeClassPtr, nameof (lastInputState));
        GameplayInputSystem.__c__DisplayClass11_0.NativeFieldInfoPtr_inputState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayInputSystem.__c__DisplayClass11_0>.NativeClassPtr, nameof (inputState));
        GameplayInputSystem.__c__DisplayClass11_0.NativeFieldInfoPtr_isAutoMoving = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayInputSystem.__c__DisplayClass11_0>.NativeClassPtr, nameof (isAutoMoving));
        GameplayInputSystem.__c__DisplayClass11_0.NativeFieldInfoPtr_resetMovementCameraDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayInputSystem.__c__DisplayClass11_0>.NativeClassPtr, nameof (resetMovementCameraDirection));
        GameplayInputSystem.__c__DisplayClass11_0.NativeFieldInfoPtr_lastValidAimDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayInputSystem.__c__DisplayClass11_0>.NativeClassPtr, nameof (lastValidAimDirection));
        GameplayInputSystem.__c__DisplayClass11_0.NativeFieldInfoPtr_tileWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayInputSystem.__c__DisplayClass11_0>.NativeClassPtr, nameof (tileWorld));
        GameplayInputSystem.__c__DisplayClass11_0.NativeFieldInfoPtr_localCharacter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayInputSystem.__c__DisplayClass11_0>.NativeClassPtr, nameof (localCharacter));
        GameplayInputSystem.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayInputSystem.__c__DisplayClass11_0>.NativeClassPtr, 100681967);
        GameplayInputSystem.__c__DisplayClass11_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_CameraUser_byref_Translation_byref_Controller_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayInputSystem.__c__DisplayClass11_0>.NativeClassPtr, 100681968);
      }

      public __c__DisplayClass11_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass11_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GameplayInputSystem.__c__DisplayClass11_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameplayInputSystem.__c__DisplayClass11_0>.NativeClassPtr, data));
      }

      public unsafe GameplayInputSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameplayInputSystem.__c__DisplayClass11_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (GameplayInputSystem) null : new GameplayInputSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameplayInputSystem.__c__DisplayClass11_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe InputState lastInputState
      {
        get
        {
          return *(InputState*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameplayInputSystem.__c__DisplayClass11_0.NativeFieldInfoPtr_lastInputState));
        }
        [param: In] set
        {
          *(InputState*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameplayInputSystem.__c__DisplayClass11_0.NativeFieldInfoPtr_lastInputState)) = value;
        }
      }

      public unsafe InputState inputState
      {
        get
        {
          return *(InputState*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameplayInputSystem.__c__DisplayClass11_0.NativeFieldInfoPtr_inputState));
        }
        [param: In] set
        {
          *(InputState*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameplayInputSystem.__c__DisplayClass11_0.NativeFieldInfoPtr_inputState)) = value;
        }
      }

      public unsafe bool isAutoMoving
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameplayInputSystem.__c__DisplayClass11_0.NativeFieldInfoPtr_isAutoMoving));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameplayInputSystem.__c__DisplayClass11_0.NativeFieldInfoPtr_isAutoMoving)) = value;
        }
      }

      public unsafe bool resetMovementCameraDirection
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameplayInputSystem.__c__DisplayClass11_0.NativeFieldInfoPtr_resetMovementCameraDirection));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameplayInputSystem.__c__DisplayClass11_0.NativeFieldInfoPtr_resetMovementCameraDirection)) = value;
        }
      }

      public unsafe float3 lastValidAimDirection
      {
        get
        {
          return *(float3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameplayInputSystem.__c__DisplayClass11_0.NativeFieldInfoPtr_lastValidAimDirection));
        }
        [param: In] set
        {
          *(float3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameplayInputSystem.__c__DisplayClass11_0.NativeFieldInfoPtr_lastValidAimDirection)) = value;
        }
      }

      public unsafe TileWorld tileWorld
      {
        get
        {
          return *(TileWorld*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameplayInputSystem.__c__DisplayClass11_0.NativeFieldInfoPtr_tileWorld));
        }
        [param: In] set
        {
          *(TileWorld*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameplayInputSystem.__c__DisplayClass11_0.NativeFieldInfoPtr_tileWorld)) = value;
        }
      }

      public unsafe Entity localCharacter
      {
        get
        {
          return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameplayInputSystem.__c__DisplayClass11_0.NativeFieldInfoPtr_localCharacter));
        }
        [param: In] set
        {
          *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameplayInputSystem.__c__DisplayClass11_0.NativeFieldInfoPtr_localCharacter)) = value;
        }
      }
    }

    [ObfuscatedName("ProjectM.GameplayInputSystem/ProjectM.<>c__DisplayClass_UpdatePlayerInputs")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_UpdatePlayerInputs
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_lastInputState;
      private static readonly System.IntPtr NativeFieldInfoPtr_inputState;
      private static readonly System.IntPtr NativeFieldInfoPtr_isAutoMoving;
      private static readonly System.IntPtr NativeFieldInfoPtr_resetMovementCameraDirection;
      private static readonly System.IntPtr NativeFieldInfoPtr_lastValidAimDirection;
      private static readonly System.IntPtr NativeFieldInfoPtr_tileWorld;
      private static readonly System.IntPtr NativeFieldInfoPtr_localCharacter;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_HybridCameraData_0;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_EntityInput_1;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_Picker_2;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_NetworkId_3;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_CameraUser_byref_Translation_byref_Controller_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass11_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass11_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GameplayInputSystem_byref___c__DisplayClass11_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public InputState lastInputState;
      [FieldOffset(160)]
      public InputState inputState;
      [FieldOffset(320)]
      public bool isAutoMoving;
      [FieldOffset(321)]
      public bool resetMovementCameraDirection;
      [FieldOffset(324)]
      public float3 lastValidAimDirection;
      [FieldOffset(336)]
      public TileWorld tileWorld;
      [FieldOffset(360)]
      public Entity localCharacter;
      [FieldOffset(368)]
      public ComponentDataFromEntity<HybridCameraData> _ComponentDataFromEntity_HybridCameraData_0;
      [FieldOffset(400)]
      public ComponentDataFromEntity<EntityInput> _ComponentDataFromEntity_EntityInput_1;
      [FieldOffset(432)]
      public ComponentDataFromEntity<Picker> _ComponentDataFromEntity_Picker_2;
      [FieldOffset(464)]
      public ComponentDataFromEntity<NetworkId> _ComponentDataFromEntity_NetworkId_3;
      [FieldOffset(496)]
      public GameplayInputSystem.__c__DisplayClass_UpdatePlayerInputs.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(600)]
      public unsafe GameplayInputSystem.__c__DisplayClass_UpdatePlayerInputs.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1046047, XrefRangeEnd = 1046144, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        [In] ref CameraUser cameraUser,
        [In] ref Translation translation,
        [In] ref Controller controller)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref cameraUser;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref translation;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref controller;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameplayInputSystem.__c__DisplayClass_UpdatePlayerInputs.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_CameraUser_byref_Translation_byref_Controller_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1046144, RefRangeEnd = 1046145, XrefRangeStart = 1046144, XrefRangeEnd = 1046144, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref GameplayInputSystem.__c__DisplayClass11_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameplayInputSystem.__c__DisplayClass_UpdatePlayerInputs.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass11_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1046145, RefRangeEnd = 1046146, XrefRangeStart = 1046145, XrefRangeEnd = 1046145, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref GameplayInputSystem.__c__DisplayClass11_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameplayInputSystem.__c__DisplayClass_UpdatePlayerInputs.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass11_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1046146, XrefRangeEnd = 1046148, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(GameplayInputSystem.__c__DisplayClass_UpdatePlayerInputs.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1046160, RefRangeEnd = 1046161, XrefRangeStart = 1046148, XrefRangeEnd = 1046160, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref GameplayInputSystem.__c__DisplayClass_UpdatePlayerInputs.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameplayInputSystem.__c__DisplayClass_UpdatePlayerInputs.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1046175, RefRangeEnd = 1046176, XrefRangeStart = 1046161, XrefRangeEnd = 1046175, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        GameplayInputSystem componentSystem,
        ref GameplayInputSystem.__c__DisplayClass11_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameplayInputSystem.__c__DisplayClass_UpdatePlayerInputs.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GameplayInputSystem_byref___c__DisplayClass11_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1046176, XrefRangeEnd = 1046180, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameplayInputSystem.__c__DisplayClass_UpdatePlayerInputs.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1046180, XrefRangeEnd = 1046186, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameplayInputSystem.__c__DisplayClass_UpdatePlayerInputs.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_UpdatePlayerInputs()
      {
        Il2CppClassPointerStore<GameplayInputSystem.__c__DisplayClass_UpdatePlayerInputs>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameplayInputSystem>.NativeClassPtr, "<>c__DisplayClass_UpdatePlayerInputs");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameplayInputSystem.__c__DisplayClass_UpdatePlayerInputs>.NativeClassPtr);
        GameplayInputSystem.__c__DisplayClass_UpdatePlayerInputs.NativeFieldInfoPtr_lastInputState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayInputSystem.__c__DisplayClass_UpdatePlayerInputs>.NativeClassPtr, nameof (lastInputState));
        GameplayInputSystem.__c__DisplayClass_UpdatePlayerInputs.NativeFieldInfoPtr_inputState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayInputSystem.__c__DisplayClass_UpdatePlayerInputs>.NativeClassPtr, nameof (inputState));
        GameplayInputSystem.__c__DisplayClass_UpdatePlayerInputs.NativeFieldInfoPtr_isAutoMoving = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayInputSystem.__c__DisplayClass_UpdatePlayerInputs>.NativeClassPtr, nameof (isAutoMoving));
        GameplayInputSystem.__c__DisplayClass_UpdatePlayerInputs.NativeFieldInfoPtr_resetMovementCameraDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayInputSystem.__c__DisplayClass_UpdatePlayerInputs>.NativeClassPtr, nameof (resetMovementCameraDirection));
        GameplayInputSystem.__c__DisplayClass_UpdatePlayerInputs.NativeFieldInfoPtr_lastValidAimDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayInputSystem.__c__DisplayClass_UpdatePlayerInputs>.NativeClassPtr, nameof (lastValidAimDirection));
        GameplayInputSystem.__c__DisplayClass_UpdatePlayerInputs.NativeFieldInfoPtr_tileWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayInputSystem.__c__DisplayClass_UpdatePlayerInputs>.NativeClassPtr, nameof (tileWorld));
        GameplayInputSystem.__c__DisplayClass_UpdatePlayerInputs.NativeFieldInfoPtr_localCharacter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayInputSystem.__c__DisplayClass_UpdatePlayerInputs>.NativeClassPtr, nameof (localCharacter));
        GameplayInputSystem.__c__DisplayClass_UpdatePlayerInputs.NativeFieldInfoPtr__ComponentDataFromEntity_HybridCameraData_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayInputSystem.__c__DisplayClass_UpdatePlayerInputs>.NativeClassPtr, nameof (_ComponentDataFromEntity_HybridCameraData_0));
        GameplayInputSystem.__c__DisplayClass_UpdatePlayerInputs.NativeFieldInfoPtr__ComponentDataFromEntity_EntityInput_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayInputSystem.__c__DisplayClass_UpdatePlayerInputs>.NativeClassPtr, nameof (_ComponentDataFromEntity_EntityInput_1));
        GameplayInputSystem.__c__DisplayClass_UpdatePlayerInputs.NativeFieldInfoPtr__ComponentDataFromEntity_Picker_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayInputSystem.__c__DisplayClass_UpdatePlayerInputs>.NativeClassPtr, nameof (_ComponentDataFromEntity_Picker_2));
        GameplayInputSystem.__c__DisplayClass_UpdatePlayerInputs.NativeFieldInfoPtr__ComponentDataFromEntity_NetworkId_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayInputSystem.__c__DisplayClass_UpdatePlayerInputs>.NativeClassPtr, nameof (_ComponentDataFromEntity_NetworkId_3));
        GameplayInputSystem.__c__DisplayClass_UpdatePlayerInputs.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayInputSystem.__c__DisplayClass_UpdatePlayerInputs>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        GameplayInputSystem.__c__DisplayClass_UpdatePlayerInputs.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayInputSystem.__c__DisplayClass_UpdatePlayerInputs>.NativeClassPtr, nameof (_runtimes));
        GameplayInputSystem.__c__DisplayClass_UpdatePlayerInputs.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayInputSystem.__c__DisplayClass_UpdatePlayerInputs>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        GameplayInputSystem.__c__DisplayClass_UpdatePlayerInputs.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayInputSystem.__c__DisplayClass_UpdatePlayerInputs>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        GameplayInputSystem.__c__DisplayClass_UpdatePlayerInputs.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_CameraUser_byref_Translation_byref_Controller_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayInputSystem.__c__DisplayClass_UpdatePlayerInputs>.NativeClassPtr, 100681969);
        GameplayInputSystem.__c__DisplayClass_UpdatePlayerInputs.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass11_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayInputSystem.__c__DisplayClass_UpdatePlayerInputs>.NativeClassPtr, 100681970);
        GameplayInputSystem.__c__DisplayClass_UpdatePlayerInputs.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass11_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayInputSystem.__c__DisplayClass_UpdatePlayerInputs>.NativeClassPtr, 100681971);
        GameplayInputSystem.__c__DisplayClass_UpdatePlayerInputs.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayInputSystem.__c__DisplayClass_UpdatePlayerInputs>.NativeClassPtr, 100681972);
        GameplayInputSystem.__c__DisplayClass_UpdatePlayerInputs.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayInputSystem.__c__DisplayClass_UpdatePlayerInputs>.NativeClassPtr, 100681973);
        GameplayInputSystem.__c__DisplayClass_UpdatePlayerInputs.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GameplayInputSystem_byref___c__DisplayClass11_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayInputSystem.__c__DisplayClass_UpdatePlayerInputs>.NativeClassPtr, 100681974);
        GameplayInputSystem.__c__DisplayClass_UpdatePlayerInputs.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayInputSystem.__c__DisplayClass_UpdatePlayerInputs>.NativeClassPtr, 100681975);
        GameplayInputSystem.__c__DisplayClass_UpdatePlayerInputs.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayInputSystem.__c__DisplayClass_UpdatePlayerInputs>.NativeClassPtr, 100681976);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameplayInputSystem.__c__DisplayClass_UpdatePlayerInputs>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(GameplayInputSystem.__c__DisplayClass_UpdatePlayerInputs.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(GameplayInputSystem.__c__DisplayClass_UpdatePlayerInputs.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(GameplayInputSystem.__c__DisplayClass_UpdatePlayerInputs.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(GameplayInputSystem.__c__DisplayClass_UpdatePlayerInputs.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_cameraUser;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_translation;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_controller;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GameplayInputSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<CameraUser> forParameter_cameraUser;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_IComponentData<Translation> forParameter_translation;
        [FieldOffset(72)]
        public LambdaParameterValueProvider_IComponentData<Controller> forParameter_controller;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1045960, RefRangeEnd = 1045961, XrefRangeStart = 1045950, XrefRangeEnd = 1045960, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(GameplayInputSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GameplayInputSystem.__c__DisplayClass_UpdatePlayerInputs.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GameplayInputSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1045971, RefRangeEnd = 1045972, XrefRangeStart = 1045961, XrefRangeEnd = 1045971, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe GameplayInputSystem.__c__DisplayClass_UpdatePlayerInputs.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameplayInputSystem.__c__DisplayClass_UpdatePlayerInputs.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(GameplayInputSystem.__c__DisplayClass_UpdatePlayerInputs.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<GameplayInputSystem.__c__DisplayClass_UpdatePlayerInputs.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameplayInputSystem.__c__DisplayClass_UpdatePlayerInputs>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          GameplayInputSystem.__c__DisplayClass_UpdatePlayerInputs.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayInputSystem.__c__DisplayClass_UpdatePlayerInputs.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          GameplayInputSystem.__c__DisplayClass_UpdatePlayerInputs.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_cameraUser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayInputSystem.__c__DisplayClass_UpdatePlayerInputs.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_cameraUser));
          GameplayInputSystem.__c__DisplayClass_UpdatePlayerInputs.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayInputSystem.__c__DisplayClass_UpdatePlayerInputs.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_translation));
          GameplayInputSystem.__c__DisplayClass_UpdatePlayerInputs.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_controller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayInputSystem.__c__DisplayClass_UpdatePlayerInputs.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_controller));
          GameplayInputSystem.__c__DisplayClass_UpdatePlayerInputs.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GameplayInputSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayInputSystem.__c__DisplayClass_UpdatePlayerInputs.LambdaParameterValueProviders>.NativeClassPtr, 100681977);
          GameplayInputSystem.__c__DisplayClass_UpdatePlayerInputs.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayInputSystem.__c__DisplayClass_UpdatePlayerInputs.LambdaParameterValueProviders>.NativeClassPtr, 100681978);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameplayInputSystem.__c__DisplayClass_UpdatePlayerInputs.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_cameraUser;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_translation;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_controller;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<CameraUser>.Runtime runtime_cameraUser;
          [FieldOffset(16)]
          public LambdaParameterValueProvider_IComponentData<Translation>.Runtime runtime_translation;
          [FieldOffset(24)]
          public LambdaParameterValueProvider_IComponentData<Controller>.Runtime runtime_controller;

          static Runtimes()
          {
            Il2CppClassPointerStore<GameplayInputSystem.__c__DisplayClass_UpdatePlayerInputs.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameplayInputSystem.__c__DisplayClass_UpdatePlayerInputs.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            GameplayInputSystem.__c__DisplayClass_UpdatePlayerInputs.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayInputSystem.__c__DisplayClass_UpdatePlayerInputs.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            GameplayInputSystem.__c__DisplayClass_UpdatePlayerInputs.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_cameraUser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayInputSystem.__c__DisplayClass_UpdatePlayerInputs.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_cameraUser));
            GameplayInputSystem.__c__DisplayClass_UpdatePlayerInputs.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayInputSystem.__c__DisplayClass_UpdatePlayerInputs.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_translation));
            GameplayInputSystem.__c__DisplayClass_UpdatePlayerInputs.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_controller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayInputSystem.__c__DisplayClass_UpdatePlayerInputs.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_controller));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameplayInputSystem.__c__DisplayClass_UpdatePlayerInputs.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.GameplayInputSystem/ProjectM.<>c__DisplayClass_UpdatePlayerInputs/ProjectM.RunWithoutJobSystem_00004356$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameplayInputSystem.__c__DisplayClass_UpdatePlayerInputs.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GameplayInputSystem.__c__DisplayClass_UpdatePlayerInputs.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(GameplayInputSystem.__c__DisplayClass_UpdatePlayerInputs.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameplayInputSystem.__c__DisplayClass_UpdatePlayerInputs.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(GameplayInputSystem.__c__DisplayClass_UpdatePlayerInputs.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<GameplayInputSystem.__c__DisplayClass_UpdatePlayerInputs.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameplayInputSystem.__c__DisplayClass_UpdatePlayerInputs>.NativeClassPtr, "RunWithoutJobSystem_00004356$PostfixBurstDelegate");
          GameplayInputSystem.__c__DisplayClass_UpdatePlayerInputs.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayInputSystem.__c__DisplayClass_UpdatePlayerInputs.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100681979);
          GameplayInputSystem.__c__DisplayClass_UpdatePlayerInputs.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayInputSystem.__c__DisplayClass_UpdatePlayerInputs.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100681980);
          GameplayInputSystem.__c__DisplayClass_UpdatePlayerInputs.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayInputSystem.__c__DisplayClass_UpdatePlayerInputs.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100681981);
          GameplayInputSystem.__c__DisplayClass_UpdatePlayerInputs.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayInputSystem.__c__DisplayClass_UpdatePlayerInputs.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100681982);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.GameplayInputSystem/ProjectM.<>c__DisplayClass_UpdatePlayerInputs/ProjectM.RunWithoutJobSystem_00004356$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1045972, XrefRangeEnd = 1045986, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GameplayInputSystem.__c__DisplayClass_UpdatePlayerInputs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1045986, XrefRangeEnd = 1046004, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameplayInputSystem.__c__DisplayClass_UpdatePlayerInputs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1046004, XrefRangeEnd = 1046019, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GameplayInputSystem.__c__DisplayClass_UpdatePlayerInputs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GameplayInputSystem.__c__DisplayClass_UpdatePlayerInputs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1046046, RefRangeEnd = 1046047, XrefRangeStart = 1046019, XrefRangeEnd = 1046046, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GameplayInputSystem.__c__DisplayClass_UpdatePlayerInputs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<GameplayInputSystem.__c__DisplayClass_UpdatePlayerInputs.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameplayInputSystem.__c__DisplayClass_UpdatePlayerInputs>.NativeClassPtr, "RunWithoutJobSystem_00004356$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameplayInputSystem.__c__DisplayClass_UpdatePlayerInputs.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          GameplayInputSystem.__c__DisplayClass_UpdatePlayerInputs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayInputSystem.__c__DisplayClass_UpdatePlayerInputs.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          GameplayInputSystem.__c__DisplayClass_UpdatePlayerInputs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayInputSystem.__c__DisplayClass_UpdatePlayerInputs.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          GameplayInputSystem.__c__DisplayClass_UpdatePlayerInputs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayInputSystem.__c__DisplayClass_UpdatePlayerInputs.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100681983);
          GameplayInputSystem.__c__DisplayClass_UpdatePlayerInputs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayInputSystem.__c__DisplayClass_UpdatePlayerInputs.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100681984);
          GameplayInputSystem.__c__DisplayClass_UpdatePlayerInputs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayInputSystem.__c__DisplayClass_UpdatePlayerInputs.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100681985);
          GameplayInputSystem.__c__DisplayClass_UpdatePlayerInputs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayInputSystem.__c__DisplayClass_UpdatePlayerInputs.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100681986);
          GameplayInputSystem.__c__DisplayClass_UpdatePlayerInputs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayInputSystem.__c__DisplayClass_UpdatePlayerInputs.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100681988);
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
            IL2CPP.il2cpp_field_static_get_value(GameplayInputSystem.__c__DisplayClass_UpdatePlayerInputs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(GameplayInputSystem.__c__DisplayClass_UpdatePlayerInputs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(GameplayInputSystem.__c__DisplayClass_UpdatePlayerInputs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(GameplayInputSystem.__c__DisplayClass_UpdatePlayerInputs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }
  }
}
