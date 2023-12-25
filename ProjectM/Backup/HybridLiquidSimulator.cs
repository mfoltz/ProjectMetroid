// Decompiled with JetBrains decompiler
// Type: HybridLiquidSimulator
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
public class HybridLiquidSimulator : MonoBehaviour
{
  private static readonly IntPtr NativeFieldInfoPtr_LiquidRenderer;
  private static readonly IntPtr NativeFieldInfoPtr_MaterialBlock;
  private static readonly IntPtr NativeFieldInfoPtr_DefaultSurfaceNormal;
  private static readonly IntPtr NativeFieldInfoPtr_LastPosition;
  private static readonly IntPtr NativeFieldInfoPtr_LastRotation;
  private static readonly IntPtr NativeFieldInfoPtr_Velocity;
  private static readonly IntPtr NativeFieldInfoPtr_AngularVelocity;
  private static readonly IntPtr NativeFieldInfoPtr_QualityModeAccessor;
  private static readonly IntPtr NativeFieldInfoPtr_TimeTracker;
  private static readonly IntPtr NativeFieldInfoPtr_Pulse;
  private static readonly IntPtr NativeFieldInfoPtr_MovementX;
  private static readonly IntPtr NativeFieldInfoPtr_MovementZ;
  private static readonly IntPtr NativeFieldInfoPtr_AddMovementX;
  private static readonly IntPtr NativeFieldInfoPtr_AddMovementZ;
  private static readonly IntPtr NativeFieldInfoPtr_SURFACE_POSITION;
  private static readonly IntPtr NativeFieldInfoPtr_SURFACE_NORMAL;
  private static readonly IntPtr NativeFieldInfoPtr_QualityMode;
  private static readonly IntPtr NativeFieldInfoPtr_MaxFill;
  private static readonly IntPtr NativeFieldInfoPtr_MinFill;
  private static readonly IntPtr NativeFieldInfoPtr_FillPos;
  private static readonly IntPtr NativeFieldInfoPtr_FillPercent;
  private static readonly IntPtr NativeFieldInfoPtr_MaxRotAtMax;
  private static readonly IntPtr NativeFieldInfoPtr_MaxRotAtMin;
  private static readonly IntPtr NativeFieldInfoPtr_CurrentMaxRot;
  private static readonly IntPtr NativeFieldInfoPtr_MovementFactorAtMax;
  private static readonly IntPtr NativeFieldInfoPtr_MovementFactorAtMin;
  private static readonly IntPtr NativeFieldInfoPtr_MaxMovementFactor;
  private static readonly IntPtr NativeFieldInfoPtr_SpeedFactorAtMax;
  private static readonly IntPtr NativeFieldInfoPtr_SpeedFactorAtMin;
  private static readonly IntPtr NativeFieldInfoPtr_Speed;
  private static readonly IntPtr NativeFieldInfoPtr_RecoveryAtMax;
  private static readonly IntPtr NativeFieldInfoPtr_RecoveryAtMin;
  private static readonly IntPtr NativeFieldInfoPtr_RecoveryFactor;
  private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_ResetSimulation_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_CalculateFillConstants_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 915389, XrefRangeEnd = 915410, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Start()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(HybridLiquidSimulator.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 915410, XrefRangeEnd = 915414, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(HybridLiquidSimulator.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ResetSimulation()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(HybridLiquidSimulator.NativeMethodInfoPtr_ResetSimulation_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 915428, RefRangeEnd = 915429, XrefRangeStart = 915414, XrefRangeEnd = 915428, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CalculateFillConstants()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(HybridLiquidSimulator.NativeMethodInfoPtr_CalculateFillConstants_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 915429, XrefRangeEnd = 915456, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(HybridLiquidSimulator.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 915456, XrefRangeEnd = 915464, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe HybridLiquidSimulator()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HybridLiquidSimulator>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(HybridLiquidSimulator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static HybridLiquidSimulator()
  {
    Il2CppClassPointerStore<HybridLiquidSimulator>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "", nameof (HybridLiquidSimulator));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HybridLiquidSimulator>.NativeClassPtr);
    HybridLiquidSimulator.NativeFieldInfoPtr_LiquidRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridLiquidSimulator>.NativeClassPtr, nameof (LiquidRenderer));
    HybridLiquidSimulator.NativeFieldInfoPtr_MaterialBlock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridLiquidSimulator>.NativeClassPtr, nameof (MaterialBlock));
    HybridLiquidSimulator.NativeFieldInfoPtr_DefaultSurfaceNormal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridLiquidSimulator>.NativeClassPtr, nameof (DefaultSurfaceNormal));
    HybridLiquidSimulator.NativeFieldInfoPtr_LastPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridLiquidSimulator>.NativeClassPtr, nameof (LastPosition));
    HybridLiquidSimulator.NativeFieldInfoPtr_LastRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridLiquidSimulator>.NativeClassPtr, nameof (LastRotation));
    HybridLiquidSimulator.NativeFieldInfoPtr_Velocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridLiquidSimulator>.NativeClassPtr, nameof (Velocity));
    HybridLiquidSimulator.NativeFieldInfoPtr_AngularVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridLiquidSimulator>.NativeClassPtr, nameof (AngularVelocity));
    HybridLiquidSimulator.NativeFieldInfoPtr_QualityModeAccessor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridLiquidSimulator>.NativeClassPtr, nameof (QualityModeAccessor));
    HybridLiquidSimulator.NativeFieldInfoPtr_TimeTracker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridLiquidSimulator>.NativeClassPtr, nameof (TimeTracker));
    HybridLiquidSimulator.NativeFieldInfoPtr_Pulse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridLiquidSimulator>.NativeClassPtr, nameof (Pulse));
    HybridLiquidSimulator.NativeFieldInfoPtr_MovementX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridLiquidSimulator>.NativeClassPtr, nameof (MovementX));
    HybridLiquidSimulator.NativeFieldInfoPtr_MovementZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridLiquidSimulator>.NativeClassPtr, nameof (MovementZ));
    HybridLiquidSimulator.NativeFieldInfoPtr_AddMovementX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridLiquidSimulator>.NativeClassPtr, nameof (AddMovementX));
    HybridLiquidSimulator.NativeFieldInfoPtr_AddMovementZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridLiquidSimulator>.NativeClassPtr, nameof (AddMovementZ));
    HybridLiquidSimulator.NativeFieldInfoPtr_SURFACE_POSITION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridLiquidSimulator>.NativeClassPtr, nameof (SURFACE_POSITION));
    HybridLiquidSimulator.NativeFieldInfoPtr_SURFACE_NORMAL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridLiquidSimulator>.NativeClassPtr, nameof (SURFACE_NORMAL));
    HybridLiquidSimulator.NativeFieldInfoPtr_QualityMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridLiquidSimulator>.NativeClassPtr, nameof (QualityMode));
    HybridLiquidSimulator.NativeFieldInfoPtr_MaxFill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridLiquidSimulator>.NativeClassPtr, nameof (MaxFill));
    HybridLiquidSimulator.NativeFieldInfoPtr_MinFill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridLiquidSimulator>.NativeClassPtr, nameof (MinFill));
    HybridLiquidSimulator.NativeFieldInfoPtr_FillPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridLiquidSimulator>.NativeClassPtr, nameof (FillPos));
    HybridLiquidSimulator.NativeFieldInfoPtr_FillPercent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridLiquidSimulator>.NativeClassPtr, nameof (FillPercent));
    HybridLiquidSimulator.NativeFieldInfoPtr_MaxRotAtMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridLiquidSimulator>.NativeClassPtr, nameof (MaxRotAtMax));
    HybridLiquidSimulator.NativeFieldInfoPtr_MaxRotAtMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridLiquidSimulator>.NativeClassPtr, nameof (MaxRotAtMin));
    HybridLiquidSimulator.NativeFieldInfoPtr_CurrentMaxRot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridLiquidSimulator>.NativeClassPtr, nameof (CurrentMaxRot));
    HybridLiquidSimulator.NativeFieldInfoPtr_MovementFactorAtMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridLiquidSimulator>.NativeClassPtr, nameof (MovementFactorAtMax));
    HybridLiquidSimulator.NativeFieldInfoPtr_MovementFactorAtMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridLiquidSimulator>.NativeClassPtr, nameof (MovementFactorAtMin));
    HybridLiquidSimulator.NativeFieldInfoPtr_MaxMovementFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridLiquidSimulator>.NativeClassPtr, nameof (MaxMovementFactor));
    HybridLiquidSimulator.NativeFieldInfoPtr_SpeedFactorAtMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridLiquidSimulator>.NativeClassPtr, nameof (SpeedFactorAtMax));
    HybridLiquidSimulator.NativeFieldInfoPtr_SpeedFactorAtMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridLiquidSimulator>.NativeClassPtr, nameof (SpeedFactorAtMin));
    HybridLiquidSimulator.NativeFieldInfoPtr_Speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridLiquidSimulator>.NativeClassPtr, nameof (Speed));
    HybridLiquidSimulator.NativeFieldInfoPtr_RecoveryAtMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridLiquidSimulator>.NativeClassPtr, nameof (RecoveryAtMax));
    HybridLiquidSimulator.NativeFieldInfoPtr_RecoveryAtMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridLiquidSimulator>.NativeClassPtr, nameof (RecoveryAtMin));
    HybridLiquidSimulator.NativeFieldInfoPtr_RecoveryFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridLiquidSimulator>.NativeClassPtr, nameof (RecoveryFactor));
    HybridLiquidSimulator.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridLiquidSimulator>.NativeClassPtr, 100663581);
    HybridLiquidSimulator.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridLiquidSimulator>.NativeClassPtr, 100663582);
    HybridLiquidSimulator.NativeMethodInfoPtr_ResetSimulation_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridLiquidSimulator>.NativeClassPtr, 100663583);
    HybridLiquidSimulator.NativeMethodInfoPtr_CalculateFillConstants_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridLiquidSimulator>.NativeClassPtr, 100663584);
    HybridLiquidSimulator.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridLiquidSimulator>.NativeClassPtr, 100663585);
    HybridLiquidSimulator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridLiquidSimulator>.NativeClassPtr, 100663586);
  }

  public HybridLiquidSimulator(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Renderer LiquidRenderer
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridLiquidSimulator.NativeFieldInfoPtr_LiquidRenderer));
      return pointer == IntPtr.Zero ? (Renderer) null : new Renderer(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HybridLiquidSimulator.NativeFieldInfoPtr_LiquidRenderer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe MaterialPropertyBlock MaterialBlock
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridLiquidSimulator.NativeFieldInfoPtr_MaterialBlock));
      return pointer == IntPtr.Zero ? (MaterialPropertyBlock) null : new MaterialPropertyBlock(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HybridLiquidSimulator.NativeFieldInfoPtr_MaterialBlock), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Vector4 DefaultSurfaceNormal
  {
    get
    {
      return *(Vector4*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridLiquidSimulator.NativeFieldInfoPtr_DefaultSurfaceNormal));
    }
    [param: In] set
    {
      *(Vector4*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridLiquidSimulator.NativeFieldInfoPtr_DefaultSurfaceNormal)) = value;
    }
  }

  public unsafe Vector3 LastPosition
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridLiquidSimulator.NativeFieldInfoPtr_LastPosition));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridLiquidSimulator.NativeFieldInfoPtr_LastPosition)) = value;
    }
  }

  public unsafe Vector3 LastRotation
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridLiquidSimulator.NativeFieldInfoPtr_LastRotation));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridLiquidSimulator.NativeFieldInfoPtr_LastRotation)) = value;
    }
  }

  public unsafe Vector3 Velocity
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridLiquidSimulator.NativeFieldInfoPtr_Velocity));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridLiquidSimulator.NativeFieldInfoPtr_Velocity)) = value;
    }
  }

  public unsafe Vector3 AngularVelocity
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridLiquidSimulator.NativeFieldInfoPtr_AngularVelocity));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridLiquidSimulator.NativeFieldInfoPtr_AngularVelocity)) = value;
    }
  }

  public unsafe int QualityModeAccessor
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridLiquidSimulator.NativeFieldInfoPtr_QualityModeAccessor));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridLiquidSimulator.NativeFieldInfoPtr_QualityModeAccessor)) = value;
    }
  }

  public unsafe float TimeTracker
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridLiquidSimulator.NativeFieldInfoPtr_TimeTracker));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridLiquidSimulator.NativeFieldInfoPtr_TimeTracker)) = value;
    }
  }

  public unsafe float Pulse
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridLiquidSimulator.NativeFieldInfoPtr_Pulse));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridLiquidSimulator.NativeFieldInfoPtr_Pulse)) = value;
    }
  }

  public unsafe float MovementX
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridLiquidSimulator.NativeFieldInfoPtr_MovementX));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridLiquidSimulator.NativeFieldInfoPtr_MovementX)) = value;
    }
  }

  public unsafe float MovementZ
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridLiquidSimulator.NativeFieldInfoPtr_MovementZ));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridLiquidSimulator.NativeFieldInfoPtr_MovementZ)) = value;
    }
  }

  public unsafe float AddMovementX
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridLiquidSimulator.NativeFieldInfoPtr_AddMovementX));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridLiquidSimulator.NativeFieldInfoPtr_AddMovementX)) = value;
    }
  }

  public unsafe float AddMovementZ
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridLiquidSimulator.NativeFieldInfoPtr_AddMovementZ));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridLiquidSimulator.NativeFieldInfoPtr_AddMovementZ)) = value;
    }
  }

  public unsafe int SURFACE_POSITION
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridLiquidSimulator.NativeFieldInfoPtr_SURFACE_POSITION));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridLiquidSimulator.NativeFieldInfoPtr_SURFACE_POSITION)) = value;
    }
  }

  public unsafe int SURFACE_NORMAL
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridLiquidSimulator.NativeFieldInfoPtr_SURFACE_NORMAL));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridLiquidSimulator.NativeFieldInfoPtr_SURFACE_NORMAL)) = value;
    }
  }

  public unsafe HybridLiquidSimulator.LiquidQualityMode QualityMode
  {
    get
    {
      return *(HybridLiquidSimulator.LiquidQualityMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridLiquidSimulator.NativeFieldInfoPtr_QualityMode));
    }
    [param: In] set
    {
      *(HybridLiquidSimulator.LiquidQualityMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridLiquidSimulator.NativeFieldInfoPtr_QualityMode)) = value;
    }
  }

  public unsafe Vector3 MaxFill
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridLiquidSimulator.NativeFieldInfoPtr_MaxFill));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridLiquidSimulator.NativeFieldInfoPtr_MaxFill)) = value;
    }
  }

  public unsafe Vector3 MinFill
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridLiquidSimulator.NativeFieldInfoPtr_MinFill));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridLiquidSimulator.NativeFieldInfoPtr_MinFill)) = value;
    }
  }

  public unsafe Vector3 FillPos
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridLiquidSimulator.NativeFieldInfoPtr_FillPos));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridLiquidSimulator.NativeFieldInfoPtr_FillPos)) = value;
    }
  }

  public unsafe float FillPercent
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridLiquidSimulator.NativeFieldInfoPtr_FillPercent));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridLiquidSimulator.NativeFieldInfoPtr_FillPercent)) = value;
    }
  }

  public unsafe float MaxRotAtMax
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridLiquidSimulator.NativeFieldInfoPtr_MaxRotAtMax));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridLiquidSimulator.NativeFieldInfoPtr_MaxRotAtMax)) = value;
    }
  }

  public unsafe float MaxRotAtMin
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridLiquidSimulator.NativeFieldInfoPtr_MaxRotAtMin));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridLiquidSimulator.NativeFieldInfoPtr_MaxRotAtMin)) = value;
    }
  }

  public unsafe float CurrentMaxRot
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridLiquidSimulator.NativeFieldInfoPtr_CurrentMaxRot));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridLiquidSimulator.NativeFieldInfoPtr_CurrentMaxRot)) = value;
    }
  }

  public unsafe float MovementFactorAtMax
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridLiquidSimulator.NativeFieldInfoPtr_MovementFactorAtMax));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridLiquidSimulator.NativeFieldInfoPtr_MovementFactorAtMax)) = value;
    }
  }

  public unsafe float MovementFactorAtMin
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridLiquidSimulator.NativeFieldInfoPtr_MovementFactorAtMin));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridLiquidSimulator.NativeFieldInfoPtr_MovementFactorAtMin)) = value;
    }
  }

  public unsafe float MaxMovementFactor
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridLiquidSimulator.NativeFieldInfoPtr_MaxMovementFactor));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridLiquidSimulator.NativeFieldInfoPtr_MaxMovementFactor)) = value;
    }
  }

  public unsafe float SpeedFactorAtMax
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridLiquidSimulator.NativeFieldInfoPtr_SpeedFactorAtMax));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridLiquidSimulator.NativeFieldInfoPtr_SpeedFactorAtMax)) = value;
    }
  }

  public unsafe float SpeedFactorAtMin
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridLiquidSimulator.NativeFieldInfoPtr_SpeedFactorAtMin));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridLiquidSimulator.NativeFieldInfoPtr_SpeedFactorAtMin)) = value;
    }
  }

  public unsafe float Speed
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridLiquidSimulator.NativeFieldInfoPtr_Speed));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridLiquidSimulator.NativeFieldInfoPtr_Speed)) = value;
    }
  }

  public unsafe float RecoveryAtMax
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridLiquidSimulator.NativeFieldInfoPtr_RecoveryAtMax));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridLiquidSimulator.NativeFieldInfoPtr_RecoveryAtMax)) = value;
    }
  }

  public unsafe float RecoveryAtMin
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridLiquidSimulator.NativeFieldInfoPtr_RecoveryAtMin));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridLiquidSimulator.NativeFieldInfoPtr_RecoveryAtMin)) = value;
    }
  }

  public unsafe float RecoveryFactor
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridLiquidSimulator.NativeFieldInfoPtr_RecoveryFactor));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridLiquidSimulator.NativeFieldInfoPtr_RecoveryFactor)) = value;
    }
  }

  public enum LiquidQualityMode
  {
    Low = 0,
    High = 2,
  }
}
