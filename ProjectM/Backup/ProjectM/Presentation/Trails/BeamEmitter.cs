// Decompiled with JetBrains decompiler
// Type: ProjectM.Presentation.Trails.BeamEmitter
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
namespace ProjectM.Presentation.Trails
{
  public class BeamEmitter : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr__ParticleSystemID;
    private static readonly IntPtr NativeFieldInfoPtr__IsPlaying;
    private static readonly IntPtr NativeFieldInfoPtr_StartPos;
    private static readonly IntPtr NativeFieldInfoPtr_EndPos;
    private static readonly IntPtr NativeFieldInfoPtr_Interpolate;
    private static readonly IntPtr NativeFieldInfoPtr_MinMoveDistance;
    private static readonly IntPtr NativeFieldInfoPtr_XCurve;
    private static readonly IntPtr NativeFieldInfoPtr_YCurve;
    private static readonly IntPtr NativeFieldInfoPtr_ZCurve;
    private static readonly IntPtr NativeFieldInfoPtr_StartColor;
    private static readonly IntPtr NativeFieldInfoPtr_Lifetime;
    private static readonly IntPtr NativeFieldInfoPtr_Width;
    private static readonly IntPtr NativeFieldInfoPtr_Type;
    private static readonly IntPtr NativeFieldInfoPtr_UVModeX;
    private static readonly IntPtr NativeFieldInfoPtr_ColorOverLifetime;
    private static readonly IntPtr NativeFieldInfoPtr_SizeOverLifetime;
    private static readonly IntPtr NativeFieldInfoPtr_TilesU;
    private static readonly IntPtr NativeFieldInfoPtr_TilesV;
    private static readonly IntPtr NativeFieldInfoPtr_CyclesPerSecond;
    private static readonly IntPtr NativeFieldInfoPtr_Material;
    private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_UpdateBeam_Private_Void_Vector3_Vector3_Vector3_Single_Single_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetEmitterData_Private_EmitterData_0;
    private static readonly IntPtr NativeMethodInfoPtr_Play_Public_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_Stop_Public_Void_Boolean_0;
    private static readonly IntPtr NativeMethodInfoPtr_IsPlaying_Public_Boolean_0;
    private static readonly IntPtr NativeMethodInfoPtr_IsAlive_Public_Boolean_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1113594, XrefRangeEnd = 1113609, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Awake()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BeamEmitter.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1113609, XrefRangeEnd = 1113638, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void LateUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BeamEmitter.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1113661, RefRangeEnd = 1113662, XrefRangeStart = 1113638, XrefRangeEnd = 1113661, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdateBeam(
      Vector3 startPos,
      Vector3 endPos,
      Vector3 upVector,
      float startTime,
      float minMoveDistance)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[5];
      numPtr[0] = (IntPtr) &startPos;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &endPos;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &upVector;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) &startTime;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(4) * sizeof (IntPtr))) = (IntPtr) &minMoveDistance;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BeamEmitter.NativeMethodInfoPtr_UpdateBeam_Private_Void_Vector3_Vector3_Vector3_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1113662, XrefRangeEnd = 1113673, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe EmitterData GetEmitterData()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(BeamEmitter.NativeMethodInfoPtr_GetEmitterData_Private_EmitterData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return new EmitterData(pointer);
    }

    [CallerCount(0)]
    public unsafe void Play()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BeamEmitter.NativeMethodInfoPtr_Play_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1113673, XrefRangeEnd = 1113686, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Stop(bool clearParticles)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) &clearParticles;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BeamEmitter.NativeMethodInfoPtr_Stop_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe bool IsPlaying()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(BeamEmitter.NativeMethodInfoPtr_IsPlaying_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1113686, XrefRangeEnd = 1113692, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsAlive()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(BeamEmitter.NativeMethodInfoPtr_IsAlive_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1113692, XrefRangeEnd = 1113698, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnDrawGizmos()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BeamEmitter.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1113698, XrefRangeEnd = 1113708, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BeamEmitter()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BeamEmitter>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BeamEmitter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static BeamEmitter()
    {
      Il2CppClassPointerStore<BeamEmitter>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Presentation.Trails", nameof (BeamEmitter));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BeamEmitter>.NativeClassPtr);
      BeamEmitter.NativeFieldInfoPtr__ParticleSystemID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeamEmitter>.NativeClassPtr, nameof (_ParticleSystemID));
      BeamEmitter.NativeFieldInfoPtr__IsPlaying = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeamEmitter>.NativeClassPtr, nameof (_IsPlaying));
      BeamEmitter.NativeFieldInfoPtr_StartPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeamEmitter>.NativeClassPtr, nameof (StartPos));
      BeamEmitter.NativeFieldInfoPtr_EndPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeamEmitter>.NativeClassPtr, nameof (EndPos));
      BeamEmitter.NativeFieldInfoPtr_Interpolate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeamEmitter>.NativeClassPtr, nameof (Interpolate));
      BeamEmitter.NativeFieldInfoPtr_MinMoveDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeamEmitter>.NativeClassPtr, nameof (MinMoveDistance));
      BeamEmitter.NativeFieldInfoPtr_XCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeamEmitter>.NativeClassPtr, nameof (XCurve));
      BeamEmitter.NativeFieldInfoPtr_YCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeamEmitter>.NativeClassPtr, nameof (YCurve));
      BeamEmitter.NativeFieldInfoPtr_ZCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeamEmitter>.NativeClassPtr, nameof (ZCurve));
      BeamEmitter.NativeFieldInfoPtr_StartColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeamEmitter>.NativeClassPtr, nameof (StartColor));
      BeamEmitter.NativeFieldInfoPtr_Lifetime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeamEmitter>.NativeClassPtr, nameof (Lifetime));
      BeamEmitter.NativeFieldInfoPtr_Width = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeamEmitter>.NativeClassPtr, nameof (Width));
      BeamEmitter.NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeamEmitter>.NativeClassPtr, nameof (Type));
      BeamEmitter.NativeFieldInfoPtr_UVModeX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeamEmitter>.NativeClassPtr, nameof (UVModeX));
      BeamEmitter.NativeFieldInfoPtr_ColorOverLifetime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeamEmitter>.NativeClassPtr, nameof (ColorOverLifetime));
      BeamEmitter.NativeFieldInfoPtr_SizeOverLifetime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeamEmitter>.NativeClassPtr, nameof (SizeOverLifetime));
      BeamEmitter.NativeFieldInfoPtr_TilesU = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeamEmitter>.NativeClassPtr, nameof (TilesU));
      BeamEmitter.NativeFieldInfoPtr_TilesV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeamEmitter>.NativeClassPtr, nameof (TilesV));
      BeamEmitter.NativeFieldInfoPtr_CyclesPerSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeamEmitter>.NativeClassPtr, nameof (CyclesPerSecond));
      BeamEmitter.NativeFieldInfoPtr_Material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeamEmitter>.NativeClassPtr, nameof (Material));
      BeamEmitter.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamEmitter>.NativeClassPtr, 100688130);
      BeamEmitter.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamEmitter>.NativeClassPtr, 100688131);
      BeamEmitter.NativeMethodInfoPtr_UpdateBeam_Private_Void_Vector3_Vector3_Vector3_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamEmitter>.NativeClassPtr, 100688132);
      BeamEmitter.NativeMethodInfoPtr_GetEmitterData_Private_EmitterData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamEmitter>.NativeClassPtr, 100688133);
      BeamEmitter.NativeMethodInfoPtr_Play_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamEmitter>.NativeClassPtr, 100688134);
      BeamEmitter.NativeMethodInfoPtr_Stop_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamEmitter>.NativeClassPtr, 100688135);
      BeamEmitter.NativeMethodInfoPtr_IsPlaying_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamEmitter>.NativeClassPtr, 100688136);
      BeamEmitter.NativeMethodInfoPtr_IsAlive_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamEmitter>.NativeClassPtr, 100688137);
      BeamEmitter.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamEmitter>.NativeClassPtr, 100688138);
      BeamEmitter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamEmitter>.NativeClassPtr, 100688139);
    }

    public BeamEmitter(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe TrailSystemID _ParticleSystemID
    {
      get
      {
        return *(TrailSystemID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BeamEmitter.NativeFieldInfoPtr__ParticleSystemID));
      }
      [param: In] set
      {
        *(TrailSystemID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BeamEmitter.NativeFieldInfoPtr__ParticleSystemID)) = value;
      }
    }

    public unsafe bool _IsPlaying
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BeamEmitter.NativeFieldInfoPtr__IsPlaying));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BeamEmitter.NativeFieldInfoPtr__IsPlaying)) = value;
      }
    }

    public unsafe Vector3 StartPos
    {
      get
      {
        return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BeamEmitter.NativeFieldInfoPtr_StartPos));
      }
      [param: In] set
      {
        *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BeamEmitter.NativeFieldInfoPtr_StartPos)) = value;
      }
    }

    public unsafe Vector3 EndPos
    {
      get
      {
        return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BeamEmitter.NativeFieldInfoPtr_EndPos));
      }
      [param: In] set
      {
        *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BeamEmitter.NativeFieldInfoPtr_EndPos)) = value;
      }
    }

    public unsafe bool Interpolate
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BeamEmitter.NativeFieldInfoPtr_Interpolate));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BeamEmitter.NativeFieldInfoPtr_Interpolate)) = value;
      }
    }

    public unsafe float MinMoveDistance
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BeamEmitter.NativeFieldInfoPtr_MinMoveDistance));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BeamEmitter.NativeFieldInfoPtr_MinMoveDistance)) = value;
      }
    }

    public unsafe AnimationCurve XCurve
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BeamEmitter.NativeFieldInfoPtr_XCurve));
        return pointer == IntPtr.Zero ? (AnimationCurve) null : new AnimationCurve(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BeamEmitter.NativeFieldInfoPtr_XCurve), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe AnimationCurve YCurve
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BeamEmitter.NativeFieldInfoPtr_YCurve));
        return pointer == IntPtr.Zero ? (AnimationCurve) null : new AnimationCurve(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BeamEmitter.NativeFieldInfoPtr_YCurve), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe AnimationCurve ZCurve
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BeamEmitter.NativeFieldInfoPtr_ZCurve));
        return pointer == IntPtr.Zero ? (AnimationCurve) null : new AnimationCurve(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BeamEmitter.NativeFieldInfoPtr_ZCurve), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Color StartColor
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BeamEmitter.NativeFieldInfoPtr_StartColor));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BeamEmitter.NativeFieldInfoPtr_StartColor)) = value;
      }
    }

    public unsafe float Lifetime
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BeamEmitter.NativeFieldInfoPtr_Lifetime));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BeamEmitter.NativeFieldInfoPtr_Lifetime)) = value;
      }
    }

    public unsafe float Width
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BeamEmitter.NativeFieldInfoPtr_Width));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BeamEmitter.NativeFieldInfoPtr_Width)) = value;
      }
    }

    public unsafe MeshType Type
    {
      get
      {
        return *(MeshType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BeamEmitter.NativeFieldInfoPtr_Type));
      }
      [param: In] set
      {
        *(MeshType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BeamEmitter.NativeFieldInfoPtr_Type)) = value;
      }
    }

    public unsafe UVMode UVModeX
    {
      get
      {
        return *(UVMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BeamEmitter.NativeFieldInfoPtr_UVModeX));
      }
      [param: In] set
      {
        *(UVMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BeamEmitter.NativeFieldInfoPtr_UVModeX)) = value;
      }
    }

    public unsafe Gradient ColorOverLifetime
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BeamEmitter.NativeFieldInfoPtr_ColorOverLifetime));
        return pointer == IntPtr.Zero ? (Gradient) null : new Gradient(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BeamEmitter.NativeFieldInfoPtr_ColorOverLifetime), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe AnimationCurve SizeOverLifetime
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BeamEmitter.NativeFieldInfoPtr_SizeOverLifetime));
        return pointer == IntPtr.Zero ? (AnimationCurve) null : new AnimationCurve(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BeamEmitter.NativeFieldInfoPtr_SizeOverLifetime), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int TilesU
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BeamEmitter.NativeFieldInfoPtr_TilesU));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BeamEmitter.NativeFieldInfoPtr_TilesU)) = value;
      }
    }

    public unsafe int TilesV
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BeamEmitter.NativeFieldInfoPtr_TilesV));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BeamEmitter.NativeFieldInfoPtr_TilesV)) = value;
      }
    }

    public unsafe float CyclesPerSecond
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BeamEmitter.NativeFieldInfoPtr_CyclesPerSecond));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BeamEmitter.NativeFieldInfoPtr_CyclesPerSecond)) = value;
      }
    }

    public unsafe Material Material
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BeamEmitter.NativeFieldInfoPtr_Material));
        return pointer == IntPtr.Zero ? (Material) null : new Material(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BeamEmitter.NativeFieldInfoPtr_Material), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
