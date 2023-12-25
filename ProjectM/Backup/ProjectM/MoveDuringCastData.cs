// Decompiled with JetBrains decompiler
// Type: ProjectM.MoveDuringCastData
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Mathematics;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct MoveDuringCastData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ManualDuration;
    private static readonly System.IntPtr NativeFieldInfoPtr_ForceMovementLength;
    private static readonly System.IntPtr NativeFieldInfoPtr_CurveX;
    private static readonly System.IntPtr NativeFieldInfoPtr_CurveY;
    private static readonly System.IntPtr NativeFieldInfoPtr_CurveZ;
    private static readonly System.IntPtr NativeFieldInfoPtr_ModelOffsetCurveX;
    private static readonly System.IntPtr NativeFieldInfoPtr_ModelOffsetCurveY;
    private static readonly System.IntPtr NativeFieldInfoPtr_ModelOffsetCurveZ;
    private static readonly System.IntPtr NativeFieldInfoPtr_ForceMoveType;
    private static readonly System.IntPtr NativeFieldInfoPtr_MoveType;
    private static readonly System.IntPtr NativeFieldInfoPtr_OnlyForceMoveIfAnyMoveInput;
    private static readonly System.IntPtr NativeFieldInfoPtr_UseManualDuration;
    private static readonly System.IntPtr NativeFieldInfoPtr_ExcludePostCastDuration;
    private static readonly System.IntPtr NativeFieldInfoPtr_IgnoreMovementImpair;
    private static readonly System.IntPtr NativeFieldInfoPtr_IgnoreMovementSpeedChanges;
    private static readonly System.IntPtr NativeMethodInfoPtr_EvaluateCurves_Public_float3_Single_CurveCollection_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_EvaluateModelOffsetCurves_Public_float3_Single_CurveCollection_0;
    [FieldOffset(0)]
    public float ManualDuration;
    [FieldOffset(4)]
    public float ForceMovementLength;
    [FieldOffset(8)]
    public CurveReference CurveX;
    [FieldOffset(16)]
    public CurveReference CurveY;
    [FieldOffset(24)]
    public CurveReference CurveZ;
    [FieldOffset(32)]
    public CurveReference ModelOffsetCurveX;
    [FieldOffset(40)]
    public CurveReference ModelOffsetCurveY;
    [FieldOffset(48)]
    public CurveReference ModelOffsetCurveZ;
    [FieldOffset(56)]
    public ForceMoveDuringCastType ForceMoveType;
    [FieldOffset(60)]
    public AbilityMoveType MoveType;
    [FieldOffset(64)]
    public bool OnlyForceMoveIfAnyMoveInput;
    [FieldOffset(65)]
    public bool UseManualDuration;
    [FieldOffset(66)]
    public bool ExcludePostCastDuration;
    [FieldOffset(67)]
    public bool IgnoreMovementImpair;
    [FieldOffset(68)]
    public bool IgnoreMovementSpeedChanges;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 996199, XrefRangeEnd = 996202, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe float3 EvaluateCurves(float t, CurveCollection curveCollection)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &t;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &curveCollection;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MoveDuringCastData.NativeMethodInfoPtr_EvaluateCurves_Public_float3_Single_CurveCollection_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float3*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 996212, RefRangeEnd = 996213, XrefRangeStart = 996202, XrefRangeEnd = 996212, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe float3 EvaluateModelOffsetCurves(float t, CurveCollection curveCollection)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &t;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &curveCollection;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MoveDuringCastData.NativeMethodInfoPtr_EvaluateModelOffsetCurves_Public_float3_Single_CurveCollection_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float3*) IL2CPP.il2cpp_object_unbox(num);
    }

    static MoveDuringCastData()
    {
      Il2CppClassPointerStore<MoveDuringCastData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (MoveDuringCastData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MoveDuringCastData>.NativeClassPtr);
      MoveDuringCastData.NativeFieldInfoPtr_ManualDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveDuringCastData>.NativeClassPtr, nameof (ManualDuration));
      MoveDuringCastData.NativeFieldInfoPtr_ForceMovementLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveDuringCastData>.NativeClassPtr, nameof (ForceMovementLength));
      MoveDuringCastData.NativeFieldInfoPtr_CurveX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveDuringCastData>.NativeClassPtr, nameof (CurveX));
      MoveDuringCastData.NativeFieldInfoPtr_CurveY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveDuringCastData>.NativeClassPtr, nameof (CurveY));
      MoveDuringCastData.NativeFieldInfoPtr_CurveZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveDuringCastData>.NativeClassPtr, nameof (CurveZ));
      MoveDuringCastData.NativeFieldInfoPtr_ModelOffsetCurveX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveDuringCastData>.NativeClassPtr, nameof (ModelOffsetCurveX));
      MoveDuringCastData.NativeFieldInfoPtr_ModelOffsetCurveY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveDuringCastData>.NativeClassPtr, nameof (ModelOffsetCurveY));
      MoveDuringCastData.NativeFieldInfoPtr_ModelOffsetCurveZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveDuringCastData>.NativeClassPtr, nameof (ModelOffsetCurveZ));
      MoveDuringCastData.NativeFieldInfoPtr_ForceMoveType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveDuringCastData>.NativeClassPtr, nameof (ForceMoveType));
      MoveDuringCastData.NativeFieldInfoPtr_MoveType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveDuringCastData>.NativeClassPtr, nameof (MoveType));
      MoveDuringCastData.NativeFieldInfoPtr_OnlyForceMoveIfAnyMoveInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveDuringCastData>.NativeClassPtr, nameof (OnlyForceMoveIfAnyMoveInput));
      MoveDuringCastData.NativeFieldInfoPtr_UseManualDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveDuringCastData>.NativeClassPtr, nameof (UseManualDuration));
      MoveDuringCastData.NativeFieldInfoPtr_ExcludePostCastDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveDuringCastData>.NativeClassPtr, nameof (ExcludePostCastDuration));
      MoveDuringCastData.NativeFieldInfoPtr_IgnoreMovementImpair = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveDuringCastData>.NativeClassPtr, nameof (IgnoreMovementImpair));
      MoveDuringCastData.NativeFieldInfoPtr_IgnoreMovementSpeedChanges = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveDuringCastData>.NativeClassPtr, nameof (IgnoreMovementSpeedChanges));
      MoveDuringCastData.NativeMethodInfoPtr_EvaluateCurves_Public_float3_Single_CurveCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveDuringCastData>.NativeClassPtr, 100676968);
      MoveDuringCastData.NativeMethodInfoPtr_EvaluateModelOffsetCurves_Public_float3_Single_CurveCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveDuringCastData>.NativeClassPtr, 100676969);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MoveDuringCastData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
