// Decompiled with JetBrains decompiler
// Type: ProjectM.Presentation.Trails.TrailEmitter
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM.Presentation.Trails
{
  public class TrailEmitter : MonoBehaviour
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__TrailSystemID;
    private static readonly System.IntPtr NativeFieldInfoPtr_Interpolate;
    private static readonly System.IntPtr NativeFieldInfoPtr_InterpolateRotation;
    private static readonly System.IntPtr NativeFieldInfoPtr_MinMoveDistance;
    private static readonly System.IntPtr NativeFieldInfoPtr_StartColor;
    private static readonly System.IntPtr NativeFieldInfoPtr_Lifetime;
    private static readonly System.IntPtr NativeFieldInfoPtr_Width;
    private static readonly System.IntPtr NativeFieldInfoPtr_FadeOutTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_Type;
    private static readonly System.IntPtr NativeFieldInfoPtr_UVModeX;
    private static readonly System.IntPtr NativeFieldInfoPtr_ColorOverLifetime;
    private static readonly System.IntPtr NativeFieldInfoPtr_SizeOverLifetime;
    private static readonly System.IntPtr NativeFieldInfoPtr_OffsetXOverLifetime;
    private static readonly System.IntPtr NativeFieldInfoPtr_OffsetYOverLifetime;
    private static readonly System.IntPtr NativeFieldInfoPtr_OffsetZOverLifetime;
    private static readonly System.IntPtr NativeFieldInfoPtr_TilesU;
    private static readonly System.IntPtr NativeFieldInfoPtr_TilesV;
    private static readonly System.IntPtr NativeFieldInfoPtr_CyclesPerSecond;
    private static readonly System.IntPtr NativeFieldInfoPtr_Material;
    private static readonly System.IntPtr NativeFieldInfoPtr__LastEmittedPosition;
    private static readonly System.IntPtr NativeFieldInfoPtr__LastEmittedRotation;
    private static readonly System.IntPtr NativeFieldInfoPtr__IsPlaying;
    private static readonly System.IntPtr NativeFieldInfoPtr__IsStopping;
    private static readonly System.IntPtr NativeFieldInfoPtr__TimeStopped;
    private static readonly System.IntPtr NativeFieldInfoPtr__OldPos;
    private static readonly System.IntPtr NativeFieldInfoPtr__OlderPos;
    private static readonly System.IntPtr NativeFieldInfoPtr__Transform;
    private static readonly System.IntPtr NativeMethodInfoPtr_CubicInterpolate_Private_Static_Single_Single_Single_Single_Single_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetEmitterData_Private_EmitterData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Play_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Stop_Public_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsPlaying_Public_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsAlive_Public_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ParticlesAlive_Public_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    public static unsafe float CubicInterpolate(float y0, float y1, float y2, float y3, float mu)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &y0;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &y1;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &y2;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &y3;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &mu;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TrailEmitter.NativeMethodInfoPtr_CubicInterpolate_Private_Static_Single_Single_Single_Single_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1113879, XrefRangeEnd = 1113917, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Awake()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TrailEmitter.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1113917, XrefRangeEnd = 1113934, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnDisable()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TrailEmitter.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1113934, XrefRangeEnd = 1113981, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Update()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TrailEmitter.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1113992, RefRangeEnd = 1113994, XrefRangeStart = 1113981, XrefRangeEnd = 1113992, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe EmitterData GetEmitterData()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(TrailEmitter.NativeMethodInfoPtr_GetEmitterData_Private_EmitterData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return new EmitterData(pointer);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1114015, RefRangeEnd = 1114016, XrefRangeStart = 1113994, XrefRangeEnd = 1114015, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Play()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TrailEmitter.NativeMethodInfoPtr_Play_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1114016, XrefRangeEnd = 1114034, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Stop(bool clearParticles)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &clearParticles;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TrailEmitter.NativeMethodInfoPtr_Stop_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe bool IsPlaying()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TrailEmitter.NativeMethodInfoPtr_IsPlaying_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1114034, XrefRangeEnd = 1114039, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsAlive()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TrailEmitter.NativeMethodInfoPtr_IsAlive_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1114039, XrefRangeEnd = 1114045, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe int ParticlesAlive()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TrailEmitter.NativeMethodInfoPtr_ParticlesAlive_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1114045, XrefRangeEnd = 1114070, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnDrawGizmos()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TrailEmitter.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1114070, XrefRangeEnd = 1114080, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TrailEmitter()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrailEmitter>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TrailEmitter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static TrailEmitter()
    {
      Il2CppClassPointerStore<TrailEmitter>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Presentation.Trails", nameof (TrailEmitter));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrailEmitter>.NativeClassPtr);
      TrailEmitter.NativeFieldInfoPtr__TrailSystemID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrailEmitter>.NativeClassPtr, nameof (_TrailSystemID));
      TrailEmitter.NativeFieldInfoPtr_Interpolate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrailEmitter>.NativeClassPtr, nameof (Interpolate));
      TrailEmitter.NativeFieldInfoPtr_InterpolateRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrailEmitter>.NativeClassPtr, nameof (InterpolateRotation));
      TrailEmitter.NativeFieldInfoPtr_MinMoveDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrailEmitter>.NativeClassPtr, nameof (MinMoveDistance));
      TrailEmitter.NativeFieldInfoPtr_StartColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrailEmitter>.NativeClassPtr, nameof (StartColor));
      TrailEmitter.NativeFieldInfoPtr_Lifetime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrailEmitter>.NativeClassPtr, nameof (Lifetime));
      TrailEmitter.NativeFieldInfoPtr_Width = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrailEmitter>.NativeClassPtr, nameof (Width));
      TrailEmitter.NativeFieldInfoPtr_FadeOutTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrailEmitter>.NativeClassPtr, nameof (FadeOutTime));
      TrailEmitter.NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrailEmitter>.NativeClassPtr, nameof (Type));
      TrailEmitter.NativeFieldInfoPtr_UVModeX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrailEmitter>.NativeClassPtr, nameof (UVModeX));
      TrailEmitter.NativeFieldInfoPtr_ColorOverLifetime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrailEmitter>.NativeClassPtr, nameof (ColorOverLifetime));
      TrailEmitter.NativeFieldInfoPtr_SizeOverLifetime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrailEmitter>.NativeClassPtr, nameof (SizeOverLifetime));
      TrailEmitter.NativeFieldInfoPtr_OffsetXOverLifetime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrailEmitter>.NativeClassPtr, nameof (OffsetXOverLifetime));
      TrailEmitter.NativeFieldInfoPtr_OffsetYOverLifetime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrailEmitter>.NativeClassPtr, nameof (OffsetYOverLifetime));
      TrailEmitter.NativeFieldInfoPtr_OffsetZOverLifetime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrailEmitter>.NativeClassPtr, nameof (OffsetZOverLifetime));
      TrailEmitter.NativeFieldInfoPtr_TilesU = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrailEmitter>.NativeClassPtr, nameof (TilesU));
      TrailEmitter.NativeFieldInfoPtr_TilesV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrailEmitter>.NativeClassPtr, nameof (TilesV));
      TrailEmitter.NativeFieldInfoPtr_CyclesPerSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrailEmitter>.NativeClassPtr, nameof (CyclesPerSecond));
      TrailEmitter.NativeFieldInfoPtr_Material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrailEmitter>.NativeClassPtr, nameof (Material));
      TrailEmitter.NativeFieldInfoPtr__LastEmittedPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrailEmitter>.NativeClassPtr, nameof (_LastEmittedPosition));
      TrailEmitter.NativeFieldInfoPtr__LastEmittedRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrailEmitter>.NativeClassPtr, nameof (_LastEmittedRotation));
      TrailEmitter.NativeFieldInfoPtr__IsPlaying = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrailEmitter>.NativeClassPtr, nameof (_IsPlaying));
      TrailEmitter.NativeFieldInfoPtr__IsStopping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrailEmitter>.NativeClassPtr, nameof (_IsStopping));
      TrailEmitter.NativeFieldInfoPtr__TimeStopped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrailEmitter>.NativeClassPtr, nameof (_TimeStopped));
      TrailEmitter.NativeFieldInfoPtr__OldPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrailEmitter>.NativeClassPtr, nameof (_OldPos));
      TrailEmitter.NativeFieldInfoPtr__OlderPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrailEmitter>.NativeClassPtr, nameof (_OlderPos));
      TrailEmitter.NativeFieldInfoPtr__Transform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrailEmitter>.NativeClassPtr, nameof (_Transform));
      TrailEmitter.NativeMethodInfoPtr_CubicInterpolate_Private_Static_Single_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailEmitter>.NativeClassPtr, 100688171);
      TrailEmitter.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailEmitter>.NativeClassPtr, 100688172);
      TrailEmitter.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailEmitter>.NativeClassPtr, 100688173);
      TrailEmitter.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailEmitter>.NativeClassPtr, 100688174);
      TrailEmitter.NativeMethodInfoPtr_GetEmitterData_Private_EmitterData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailEmitter>.NativeClassPtr, 100688175);
      TrailEmitter.NativeMethodInfoPtr_Play_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailEmitter>.NativeClassPtr, 100688176);
      TrailEmitter.NativeMethodInfoPtr_Stop_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailEmitter>.NativeClassPtr, 100688177);
      TrailEmitter.NativeMethodInfoPtr_IsPlaying_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailEmitter>.NativeClassPtr, 100688178);
      TrailEmitter.NativeMethodInfoPtr_IsAlive_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailEmitter>.NativeClassPtr, 100688179);
      TrailEmitter.NativeMethodInfoPtr_ParticlesAlive_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailEmitter>.NativeClassPtr, 100688180);
      TrailEmitter.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailEmitter>.NativeClassPtr, 100688181);
      TrailEmitter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailEmitter>.NativeClassPtr, 100688182);
    }

    public TrailEmitter(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe TrailSystemID _TrailSystemID
    {
      get
      {
        return *(TrailSystemID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrailEmitter.NativeFieldInfoPtr__TrailSystemID));
      }
      [param: In] set
      {
        *(TrailSystemID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrailEmitter.NativeFieldInfoPtr__TrailSystemID)) = value;
      }
    }

    public unsafe bool Interpolate
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrailEmitter.NativeFieldInfoPtr_Interpolate));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrailEmitter.NativeFieldInfoPtr_Interpolate)) = value;
      }
    }

    public unsafe bool InterpolateRotation
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrailEmitter.NativeFieldInfoPtr_InterpolateRotation));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrailEmitter.NativeFieldInfoPtr_InterpolateRotation)) = value;
      }
    }

    public unsafe float MinMoveDistance
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrailEmitter.NativeFieldInfoPtr_MinMoveDistance));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrailEmitter.NativeFieldInfoPtr_MinMoveDistance)) = value;
      }
    }

    public unsafe Color StartColor
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrailEmitter.NativeFieldInfoPtr_StartColor));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrailEmitter.NativeFieldInfoPtr_StartColor)) = value;
      }
    }

    public unsafe float Lifetime
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrailEmitter.NativeFieldInfoPtr_Lifetime));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrailEmitter.NativeFieldInfoPtr_Lifetime)) = value;
      }
    }

    public unsafe float Width
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrailEmitter.NativeFieldInfoPtr_Width));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrailEmitter.NativeFieldInfoPtr_Width)) = value;
      }
    }

    public unsafe float FadeOutTime
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrailEmitter.NativeFieldInfoPtr_FadeOutTime));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrailEmitter.NativeFieldInfoPtr_FadeOutTime)) = value;
      }
    }

    public unsafe MeshType Type
    {
      get
      {
        return *(MeshType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrailEmitter.NativeFieldInfoPtr_Type));
      }
      [param: In] set
      {
        *(MeshType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrailEmitter.NativeFieldInfoPtr_Type)) = value;
      }
    }

    public unsafe UVMode UVModeX
    {
      get
      {
        return *(UVMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrailEmitter.NativeFieldInfoPtr_UVModeX));
      }
      [param: In] set
      {
        *(UVMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrailEmitter.NativeFieldInfoPtr_UVModeX)) = value;
      }
    }

    public unsafe Gradient ColorOverLifetime
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrailEmitter.NativeFieldInfoPtr_ColorOverLifetime));
        return pointer == System.IntPtr.Zero ? (Gradient) null : new Gradient(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TrailEmitter.NativeFieldInfoPtr_ColorOverLifetime), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe AnimationCurve SizeOverLifetime
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrailEmitter.NativeFieldInfoPtr_SizeOverLifetime));
        return pointer == System.IntPtr.Zero ? (AnimationCurve) null : new AnimationCurve(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TrailEmitter.NativeFieldInfoPtr_SizeOverLifetime), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe AnimationCurve OffsetXOverLifetime
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrailEmitter.NativeFieldInfoPtr_OffsetXOverLifetime));
        return pointer == System.IntPtr.Zero ? (AnimationCurve) null : new AnimationCurve(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TrailEmitter.NativeFieldInfoPtr_OffsetXOverLifetime), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe AnimationCurve OffsetYOverLifetime
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrailEmitter.NativeFieldInfoPtr_OffsetYOverLifetime));
        return pointer == System.IntPtr.Zero ? (AnimationCurve) null : new AnimationCurve(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TrailEmitter.NativeFieldInfoPtr_OffsetYOverLifetime), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe AnimationCurve OffsetZOverLifetime
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrailEmitter.NativeFieldInfoPtr_OffsetZOverLifetime));
        return pointer == System.IntPtr.Zero ? (AnimationCurve) null : new AnimationCurve(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TrailEmitter.NativeFieldInfoPtr_OffsetZOverLifetime), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int TilesU
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrailEmitter.NativeFieldInfoPtr_TilesU));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrailEmitter.NativeFieldInfoPtr_TilesU)) = value;
      }
    }

    public unsafe int TilesV
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrailEmitter.NativeFieldInfoPtr_TilesV));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrailEmitter.NativeFieldInfoPtr_TilesV)) = value;
      }
    }

    public unsafe float CyclesPerSecond
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrailEmitter.NativeFieldInfoPtr_CyclesPerSecond));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrailEmitter.NativeFieldInfoPtr_CyclesPerSecond)) = value;
      }
    }

    public unsafe Material Material
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrailEmitter.NativeFieldInfoPtr_Material));
        return pointer == System.IntPtr.Zero ? (Material) null : new Material(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TrailEmitter.NativeFieldInfoPtr_Material), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Vector3 _LastEmittedPosition
    {
      get
      {
        return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrailEmitter.NativeFieldInfoPtr__LastEmittedPosition));
      }
      [param: In] set
      {
        *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrailEmitter.NativeFieldInfoPtr__LastEmittedPosition)) = value;
      }
    }

    public unsafe Quaternion _LastEmittedRotation
    {
      get
      {
        return *(Quaternion*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrailEmitter.NativeFieldInfoPtr__LastEmittedRotation));
      }
      [param: In] set
      {
        *(Quaternion*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrailEmitter.NativeFieldInfoPtr__LastEmittedRotation)) = value;
      }
    }

    public unsafe bool _IsPlaying
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrailEmitter.NativeFieldInfoPtr__IsPlaying));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrailEmitter.NativeFieldInfoPtr__IsPlaying)) = value;
      }
    }

    public unsafe bool _IsStopping
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrailEmitter.NativeFieldInfoPtr__IsStopping));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrailEmitter.NativeFieldInfoPtr__IsStopping)) = value;
      }
    }

    public unsafe Nullable_Unboxed<float> _TimeStopped
    {
      get
      {
        return *(Nullable_Unboxed<float>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrailEmitter.NativeFieldInfoPtr__TimeStopped));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrailEmitter.NativeFieldInfoPtr__TimeStopped), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable_Unboxed<float>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe Vector3 _OldPos
    {
      get
      {
        return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrailEmitter.NativeFieldInfoPtr__OldPos));
      }
      [param: In] set
      {
        *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrailEmitter.NativeFieldInfoPtr__OldPos)) = value;
      }
    }

    public unsafe Vector3 _OlderPos
    {
      get
      {
        return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrailEmitter.NativeFieldInfoPtr__OlderPos));
      }
      [param: In] set
      {
        *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrailEmitter.NativeFieldInfoPtr__OlderPos)) = value;
      }
    }

    public unsafe Transform _Transform
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrailEmitter.NativeFieldInfoPtr__Transform));
        return pointer == System.IntPtr.Zero ? (Transform) null : new Transform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TrailEmitter.NativeFieldInfoPtr__Transform), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
