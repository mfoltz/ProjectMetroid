// Decompiled with JetBrains decompiler
// Type: ProjectM.MoveWithCurveSystem
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;

#nullable disable
namespace ProjectM
{
  public class MoveWithCurveSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__ThisFrameState;
    private static readonly System.IntPtr NativeFieldInfoPtr__LastFrameState;
    private static readonly System.IntPtr NativeFieldInfoPtr__CurveCollectionSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__MovementCurves;
    private static readonly System.IntPtr NativeFieldInfoPtr__Id;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetAddMovementCurveEntry_Public_AddMovementCurveEntry_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1001300, XrefRangeEnd = 1001316, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), MoveWithCurveSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1001316, XrefRangeEnd = 1001327, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), MoveWithCurveSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1001327, RefRangeEnd = 1001329, XrefRangeStart = 1001327, XrefRangeEnd = 1001327, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe AddMovementCurveEntry GetAddMovementCurveEntry()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MoveWithCurveSystem.NativeMethodInfoPtr_GetAddMovementCurveEntry_Public_AddMovementCurveEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(AddMovementCurveEntry*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1001329, XrefRangeEnd = 1001357, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), MoveWithCurveSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe MoveWithCurveSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MoveWithCurveSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MoveWithCurveSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), MoveWithCurveSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static MoveWithCurveSystem()
    {
      Il2CppClassPointerStore<MoveWithCurveSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (MoveWithCurveSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MoveWithCurveSystem>.NativeClassPtr);
      MoveWithCurveSystem.NativeFieldInfoPtr__ThisFrameState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveWithCurveSystem>.NativeClassPtr, nameof (_ThisFrameState));
      MoveWithCurveSystem.NativeFieldInfoPtr__LastFrameState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveWithCurveSystem>.NativeClassPtr, nameof (_LastFrameState));
      MoveWithCurveSystem.NativeFieldInfoPtr__CurveCollectionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveWithCurveSystem>.NativeClassPtr, nameof (_CurveCollectionSystem));
      MoveWithCurveSystem.NativeFieldInfoPtr__MovementCurves = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveWithCurveSystem>.NativeClassPtr, nameof (_MovementCurves));
      MoveWithCurveSystem.NativeFieldInfoPtr__Id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveWithCurveSystem>.NativeClassPtr, nameof (_Id));
      MoveWithCurveSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveWithCurveSystem>.NativeClassPtr, 100677497);
      MoveWithCurveSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveWithCurveSystem>.NativeClassPtr, 100677498);
      MoveWithCurveSystem.NativeMethodInfoPtr_GetAddMovementCurveEntry_Public_AddMovementCurveEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveWithCurveSystem>.NativeClassPtr, 100677499);
      MoveWithCurveSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveWithCurveSystem>.NativeClassPtr, 100677500);
      MoveWithCurveSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveWithCurveSystem>.NativeClassPtr, 100677501);
      MoveWithCurveSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveWithCurveSystem>.NativeClassPtr, 100677502);
    }

    public MoveWithCurveSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe NativeList<MoveWithCurveSystem.CurveState> _ThisFrameState
    {
      get
      {
        return *(NativeList<MoveWithCurveSystem.CurveState>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoveWithCurveSystem.NativeFieldInfoPtr__ThisFrameState));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoveWithCurveSystem.NativeFieldInfoPtr__ThisFrameState), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<MoveWithCurveSystem.CurveState>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe NativeList<MoveWithCurveSystem.CurveState> _LastFrameState
    {
      get
      {
        return *(NativeList<MoveWithCurveSystem.CurveState>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoveWithCurveSystem.NativeFieldInfoPtr__LastFrameState));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoveWithCurveSystem.NativeFieldInfoPtr__LastFrameState), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<MoveWithCurveSystem.CurveState>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe CurveCollectionSystem _CurveCollectionSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoveWithCurveSystem.NativeFieldInfoPtr__CurveCollectionSystem));
        return pointer == System.IntPtr.Zero ? (CurveCollectionSystem) null : new CurveCollectionSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MoveWithCurveSystem.NativeFieldInfoPtr__CurveCollectionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe NativeList<MovementCurveEntry> _MovementCurves
    {
      get
      {
        return *(NativeList<MovementCurveEntry>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoveWithCurveSystem.NativeFieldInfoPtr__MovementCurves));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoveWithCurveSystem.NativeFieldInfoPtr__MovementCurves), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<MovementCurveEntry>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe NativeArray<int> _Id
    {
      get
      {
        return *(NativeArray<int>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoveWithCurveSystem.NativeFieldInfoPtr__Id));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoveWithCurveSystem.NativeFieldInfoPtr__Id), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct CurveState
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Id;
      private static readonly System.IntPtr NativeFieldInfoPtr_Entity;
      private static readonly System.IntPtr NativeFieldInfoPtr_Position;
      [FieldOffset(0)]
      public int Id;
      [FieldOffset(4)]
      public Entity Entity;
      [FieldOffset(12)]
      public float3 Position;

      static CurveState()
      {
        Il2CppClassPointerStore<MoveWithCurveSystem.CurveState>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MoveWithCurveSystem>.NativeClassPtr, nameof (CurveState));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MoveWithCurveSystem.CurveState>.NativeClassPtr);
        MoveWithCurveSystem.CurveState.NativeFieldInfoPtr_Id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveWithCurveSystem.CurveState>.NativeClassPtr, nameof (Id));
        MoveWithCurveSystem.CurveState.NativeFieldInfoPtr_Entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveWithCurveSystem.CurveState>.NativeClassPtr, nameof (Entity));
        MoveWithCurveSystem.CurveState.NativeFieldInfoPtr_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveWithCurveSystem.CurveState>.NativeClassPtr, nameof (Position));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MoveWithCurveSystem.CurveState>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.MoveWithCurveSystem/<>c__DisplayClass9_0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass9_0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_thisFrameState;
      private static readonly System.IntPtr NativeFieldInfoPtr_movementCurves;
      private static readonly System.IntPtr NativeFieldInfoPtr_getTranslation;
      private static readonly System.IntPtr NativeFieldInfoPtr_getPrefabGuid;
      private static readonly System.IntPtr NativeFieldInfoPtr_lastFrameState;
      private static readonly System.IntPtr NativeFieldInfoPtr_currentTime;
      private static readonly System.IntPtr NativeFieldInfoPtr_curveDataMap;
      private static readonly System.IntPtr NativeFieldInfoPtr_isServer;
      private static readonly System.IntPtr NativeFieldInfoPtr_getLastTranslation;
      private static readonly System.IntPtr NativeFieldInfoPtr_getRotation;
      private static readonly System.IntPtr NativeFieldInfoPtr_getTargetDirection;
      private static readonly System.IntPtr NativeFieldInfoPtr_deltaTime;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_0;
      [FieldOffset(0)]
      public NativeList<MoveWithCurveSystem.CurveState> thisFrameState;
      [FieldOffset(16)]
      public NativeList<MovementCurveEntry> movementCurves;
      [FieldOffset(32)]
      public ComponentDataFromEntity<Translation> getTranslation;
      [FieldOffset(64)]
      public ComponentDataFromEntity<PrefabGUID> getPrefabGuid;
      [FieldOffset(96)]
      public NativeList<MoveWithCurveSystem.CurveState> lastFrameState;
      [FieldOffset(112)]
      public double currentTime;
      [FieldOffset(120)]
      public CurveCollection curveDataMap;
      [FieldOffset(136)]
      public bool isServer;
      [FieldOffset(144)]
      public ComponentDataFromEntity<LastTranslation> getLastTranslation;
      [FieldOffset(176)]
      public ComponentDataFromEntity<Rotation> getRotation;
      [FieldOffset(208)]
      public ComponentDataFromEntity<TargetDirection> getTargetDirection;
      [FieldOffset(240)]
      public float deltaTime;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass9_0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MoveWithCurveSystem.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MoveWithCurveSystem.__c__DisplayClass9_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass9_0()
      {
        Il2CppClassPointerStore<MoveWithCurveSystem.__c__DisplayClass9_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MoveWithCurveSystem>.NativeClassPtr, "<>c__DisplayClass9_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MoveWithCurveSystem.__c__DisplayClass9_0>.NativeClassPtr);
        MoveWithCurveSystem.__c__DisplayClass9_0.NativeFieldInfoPtr_thisFrameState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveWithCurveSystem.__c__DisplayClass9_0>.NativeClassPtr, nameof (thisFrameState));
        MoveWithCurveSystem.__c__DisplayClass9_0.NativeFieldInfoPtr_movementCurves = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveWithCurveSystem.__c__DisplayClass9_0>.NativeClassPtr, nameof (movementCurves));
        MoveWithCurveSystem.__c__DisplayClass9_0.NativeFieldInfoPtr_getTranslation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveWithCurveSystem.__c__DisplayClass9_0>.NativeClassPtr, nameof (getTranslation));
        MoveWithCurveSystem.__c__DisplayClass9_0.NativeFieldInfoPtr_getPrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveWithCurveSystem.__c__DisplayClass9_0>.NativeClassPtr, nameof (getPrefabGuid));
        MoveWithCurveSystem.__c__DisplayClass9_0.NativeFieldInfoPtr_lastFrameState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveWithCurveSystem.__c__DisplayClass9_0>.NativeClassPtr, nameof (lastFrameState));
        MoveWithCurveSystem.__c__DisplayClass9_0.NativeFieldInfoPtr_currentTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveWithCurveSystem.__c__DisplayClass9_0>.NativeClassPtr, nameof (currentTime));
        MoveWithCurveSystem.__c__DisplayClass9_0.NativeFieldInfoPtr_curveDataMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveWithCurveSystem.__c__DisplayClass9_0>.NativeClassPtr, nameof (curveDataMap));
        MoveWithCurveSystem.__c__DisplayClass9_0.NativeFieldInfoPtr_isServer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveWithCurveSystem.__c__DisplayClass9_0>.NativeClassPtr, nameof (isServer));
        MoveWithCurveSystem.__c__DisplayClass9_0.NativeFieldInfoPtr_getLastTranslation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveWithCurveSystem.__c__DisplayClass9_0>.NativeClassPtr, nameof (getLastTranslation));
        MoveWithCurveSystem.__c__DisplayClass9_0.NativeFieldInfoPtr_getRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveWithCurveSystem.__c__DisplayClass9_0>.NativeClassPtr, nameof (getRotation));
        MoveWithCurveSystem.__c__DisplayClass9_0.NativeFieldInfoPtr_getTargetDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveWithCurveSystem.__c__DisplayClass9_0>.NativeClassPtr, nameof (getTargetDirection));
        MoveWithCurveSystem.__c__DisplayClass9_0.NativeFieldInfoPtr_deltaTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveWithCurveSystem.__c__DisplayClass9_0>.NativeClassPtr, nameof (deltaTime));
        MoveWithCurveSystem.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveWithCurveSystem.__c__DisplayClass9_0>.NativeClassPtr, 100677503);
        MoveWithCurveSystem.__c__DisplayClass9_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveWithCurveSystem.__c__DisplayClass9_0>.NativeClassPtr, 100677504);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MoveWithCurveSystem.__c__DisplayClass9_0>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.MoveWithCurveSystem/ProjectM.<>c__DisplayClass_MoveWithCurveJob")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_MoveWithCurveJob
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_thisFrameState;
      private static readonly System.IntPtr NativeFieldInfoPtr_movementCurves;
      private static readonly System.IntPtr NativeFieldInfoPtr_getTranslation;
      private static readonly System.IntPtr NativeFieldInfoPtr_getPrefabGuid;
      private static readonly System.IntPtr NativeFieldInfoPtr_lastFrameState;
      private static readonly System.IntPtr NativeFieldInfoPtr_currentTime;
      private static readonly System.IntPtr NativeFieldInfoPtr_curveDataMap;
      private static readonly System.IntPtr NativeFieldInfoPtr_isServer;
      private static readonly System.IntPtr NativeFieldInfoPtr_getLastTranslation;
      private static readonly System.IntPtr NativeFieldInfoPtr_getRotation;
      private static readonly System.IntPtr NativeFieldInfoPtr_getTargetDirection;
      private static readonly System.IntPtr NativeFieldInfoPtr_deltaTime;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_MoveWithCurveSystem_byref___c__DisplayClass9_0_0;
      [FieldOffset(0)]
      public NativeList<MoveWithCurveSystem.CurveState> thisFrameState;
      [FieldOffset(16)]
      public NativeList<MovementCurveEntry> movementCurves;
      [FieldOffset(32)]
      public ComponentDataFromEntity<Translation> getTranslation;
      [FieldOffset(64)]
      public ComponentDataFromEntity<PrefabGUID> getPrefabGuid;
      [FieldOffset(96)]
      public NativeList<MoveWithCurveSystem.CurveState> lastFrameState;
      [FieldOffset(112)]
      public double currentTime;
      [FieldOffset(120)]
      public CurveCollection curveDataMap;
      [FieldOffset(136)]
      public bool isServer;
      [FieldOffset(144)]
      public ComponentDataFromEntity<LastTranslation> getLastTranslation;
      [FieldOffset(176)]
      public ComponentDataFromEntity<Rotation> getRotation;
      [FieldOffset(208)]
      public ComponentDataFromEntity<TargetDirection> getTargetDirection;
      [FieldOffset(240)]
      public float deltaTime;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1001106, XrefRangeEnd = 1001295, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MoveWithCurveSystem.__c__DisplayClass_MoveWithCurveJob.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1001295, RefRangeEnd = 1001296, XrefRangeStart = 1001295, XrefRangeEnd = 1001295, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref MoveWithCurveSystem.__c__DisplayClass9_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MoveWithCurveSystem.__c__DisplayClass_MoveWithCurveJob.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1001297, RefRangeEnd = 1001298, XrefRangeStart = 1001296, XrefRangeEnd = 1001297, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MoveWithCurveSystem.__c__DisplayClass_MoveWithCurveJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1001299, RefRangeEnd = 1001300, XrefRangeStart = 1001298, XrefRangeEnd = 1001299, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        MoveWithCurveSystem componentSystem,
        ref MoveWithCurveSystem.__c__DisplayClass9_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MoveWithCurveSystem.__c__DisplayClass_MoveWithCurveJob.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_MoveWithCurveSystem_byref___c__DisplayClass9_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_MoveWithCurveJob()
      {
        Il2CppClassPointerStore<MoveWithCurveSystem.__c__DisplayClass_MoveWithCurveJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MoveWithCurveSystem>.NativeClassPtr, "<>c__DisplayClass_MoveWithCurveJob");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MoveWithCurveSystem.__c__DisplayClass_MoveWithCurveJob>.NativeClassPtr);
        MoveWithCurveSystem.__c__DisplayClass_MoveWithCurveJob.NativeFieldInfoPtr_thisFrameState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveWithCurveSystem.__c__DisplayClass_MoveWithCurveJob>.NativeClassPtr, nameof (thisFrameState));
        MoveWithCurveSystem.__c__DisplayClass_MoveWithCurveJob.NativeFieldInfoPtr_movementCurves = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveWithCurveSystem.__c__DisplayClass_MoveWithCurveJob>.NativeClassPtr, nameof (movementCurves));
        MoveWithCurveSystem.__c__DisplayClass_MoveWithCurveJob.NativeFieldInfoPtr_getTranslation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveWithCurveSystem.__c__DisplayClass_MoveWithCurveJob>.NativeClassPtr, nameof (getTranslation));
        MoveWithCurveSystem.__c__DisplayClass_MoveWithCurveJob.NativeFieldInfoPtr_getPrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveWithCurveSystem.__c__DisplayClass_MoveWithCurveJob>.NativeClassPtr, nameof (getPrefabGuid));
        MoveWithCurveSystem.__c__DisplayClass_MoveWithCurveJob.NativeFieldInfoPtr_lastFrameState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveWithCurveSystem.__c__DisplayClass_MoveWithCurveJob>.NativeClassPtr, nameof (lastFrameState));
        MoveWithCurveSystem.__c__DisplayClass_MoveWithCurveJob.NativeFieldInfoPtr_currentTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveWithCurveSystem.__c__DisplayClass_MoveWithCurveJob>.NativeClassPtr, nameof (currentTime));
        MoveWithCurveSystem.__c__DisplayClass_MoveWithCurveJob.NativeFieldInfoPtr_curveDataMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveWithCurveSystem.__c__DisplayClass_MoveWithCurveJob>.NativeClassPtr, nameof (curveDataMap));
        MoveWithCurveSystem.__c__DisplayClass_MoveWithCurveJob.NativeFieldInfoPtr_isServer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveWithCurveSystem.__c__DisplayClass_MoveWithCurveJob>.NativeClassPtr, nameof (isServer));
        MoveWithCurveSystem.__c__DisplayClass_MoveWithCurveJob.NativeFieldInfoPtr_getLastTranslation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveWithCurveSystem.__c__DisplayClass_MoveWithCurveJob>.NativeClassPtr, nameof (getLastTranslation));
        MoveWithCurveSystem.__c__DisplayClass_MoveWithCurveJob.NativeFieldInfoPtr_getRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveWithCurveSystem.__c__DisplayClass_MoveWithCurveJob>.NativeClassPtr, nameof (getRotation));
        MoveWithCurveSystem.__c__DisplayClass_MoveWithCurveJob.NativeFieldInfoPtr_getTargetDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveWithCurveSystem.__c__DisplayClass_MoveWithCurveJob>.NativeClassPtr, nameof (getTargetDirection));
        MoveWithCurveSystem.__c__DisplayClass_MoveWithCurveJob.NativeFieldInfoPtr_deltaTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveWithCurveSystem.__c__DisplayClass_MoveWithCurveJob>.NativeClassPtr, nameof (deltaTime));
        MoveWithCurveSystem.__c__DisplayClass_MoveWithCurveJob.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveWithCurveSystem.__c__DisplayClass_MoveWithCurveJob>.NativeClassPtr, 100677505);
        MoveWithCurveSystem.__c__DisplayClass_MoveWithCurveJob.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveWithCurveSystem.__c__DisplayClass_MoveWithCurveJob>.NativeClassPtr, 100677506);
        MoveWithCurveSystem.__c__DisplayClass_MoveWithCurveJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveWithCurveSystem.__c__DisplayClass_MoveWithCurveJob>.NativeClassPtr, 100677507);
        MoveWithCurveSystem.__c__DisplayClass_MoveWithCurveJob.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_MoveWithCurveSystem_byref___c__DisplayClass9_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveWithCurveSystem.__c__DisplayClass_MoveWithCurveJob>.NativeClassPtr, 100677508);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MoveWithCurveSystem.__c__DisplayClass_MoveWithCurveJob>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
