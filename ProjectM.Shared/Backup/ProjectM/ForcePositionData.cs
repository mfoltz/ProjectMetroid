// Decompiled with JetBrains decompiler
// Type: ProjectM.ForcePositionData
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using System.Runtime.InteropServices;
using Unity.Mathematics;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ForcePositionData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_AbilityCastStartTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_AbilityDuration;
    private static readonly System.IntPtr NativeFieldInfoPtr_MovementLength;
    private static readonly System.IntPtr NativeFieldInfoPtr_CurveX;
    private static readonly System.IntPtr NativeFieldInfoPtr_CurveY;
    private static readonly System.IntPtr NativeFieldInfoPtr_CurveZ;
    private static readonly System.IntPtr NativeFieldInfoPtr_PositionRotation;
    private static readonly System.IntPtr NativeFieldInfoPtr_UseForcePosition;
    private static readonly System.IntPtr NativeMethodInfoPtr_EvaluateCurves_Public_float3_Single_CurveCollection_0;
    [FieldOffset(0)]
    public double AbilityCastStartTime;
    [FieldOffset(8)]
    public float AbilityDuration;
    [FieldOffset(12)]
    public float MovementLength;
    [FieldOffset(16)]
    public CurveReference CurveX;
    [FieldOffset(24)]
    public CurveReference CurveY;
    [FieldOffset(32)]
    public CurveReference CurveZ;
    [FieldOffset(40)]
    public Nullable_Unboxed<Quaternion> PositionRotation;
    [FieldOffset(60)]
    public bool UseForcePosition;

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 727421, RefRangeEnd = 727423, XrefRangeStart = 727417, XrefRangeEnd = 727421, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe float3 EvaluateCurves(float t, CurveCollection curveCollection)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &t;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &curveCollection;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ForcePositionData.NativeMethodInfoPtr_EvaluateCurves_Public_float3_Single_CurveCollection_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float3*) IL2CPP.il2cpp_object_unbox(num);
    }

    static ForcePositionData()
    {
      Il2CppClassPointerStore<ForcePositionData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (ForcePositionData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ForcePositionData>.NativeClassPtr);
      ForcePositionData.NativeFieldInfoPtr_AbilityCastStartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForcePositionData>.NativeClassPtr, nameof (AbilityCastStartTime));
      ForcePositionData.NativeFieldInfoPtr_AbilityDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForcePositionData>.NativeClassPtr, nameof (AbilityDuration));
      ForcePositionData.NativeFieldInfoPtr_MovementLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForcePositionData>.NativeClassPtr, nameof (MovementLength));
      ForcePositionData.NativeFieldInfoPtr_CurveX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForcePositionData>.NativeClassPtr, nameof (CurveX));
      ForcePositionData.NativeFieldInfoPtr_CurveY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForcePositionData>.NativeClassPtr, nameof (CurveY));
      ForcePositionData.NativeFieldInfoPtr_CurveZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForcePositionData>.NativeClassPtr, nameof (CurveZ));
      ForcePositionData.NativeFieldInfoPtr_PositionRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForcePositionData>.NativeClassPtr, nameof (PositionRotation));
      ForcePositionData.NativeFieldInfoPtr_UseForcePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForcePositionData>.NativeClassPtr, nameof (UseForcePosition));
      ForcePositionData.NativeMethodInfoPtr_EvaluateCurves_Public_float3_Single_CurveCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForcePositionData>.NativeClassPtr, 100664371);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ForcePositionData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
