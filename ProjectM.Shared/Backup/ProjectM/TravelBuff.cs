// Decompiled with JetBrains decompiler
// Type: ProjectM.TravelBuff
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using ProjectM.Gameplay;
using ProjectM.Tiles;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Mathematics;
using Unity.Physics;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct TravelBuff
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_StartPosition;
    private static readonly System.IntPtr NativeFieldInfoPtr_EndPosition;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxHeightDiff;
    private static readonly System.IntPtr NativeFieldInfoPtr_ExtraDistanceAllowed;
    private static readonly System.IntPtr NativeFieldInfoPtr_Height;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxRange;
    private static readonly System.IntPtr NativeFieldInfoPtr_Curve;
    private static readonly System.IntPtr NativeFieldInfoPtr_HeightCurve;
    private static readonly System.IntPtr NativeFieldInfoPtr_RotationMode;
    private static readonly System.IntPtr NativeFieldInfoPtr_CurveId;
    private static readonly System.IntPtr NativeFieldInfoPtr_DenyLowerHeight;
    private static readonly System.IntPtr NativeFieldInfoPtr_StopAtHighCollision;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetTargetPositionFromInput_Public_float3_byref_FixedList64_1_float3_byref_TravelBuffSpawn_byref_float3_byref_MapCollision_byref_Random_byref_TileWorld_byref_CollisionWorld_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetCollisionInfo_Public_GameplayLocationCollisionInfo_Single_0;
    [FieldOffset(0)]
    public float3 StartPosition;
    [FieldOffset(12)]
    public float3 EndPosition;
    [FieldOffset(24)]
    public float MaxHeightDiff;
    [FieldOffset(28)]
    public float ExtraDistanceAllowed;
    [FieldOffset(32)]
    public float Height;
    [FieldOffset(36)]
    public float MaxRange;
    [FieldOffset(40)]
    public CurveReference Curve;
    [FieldOffset(48)]
    public CurveReference HeightCurve;
    [FieldOffset(56)]
    public MovementCurveRotationMode RotationMode;
    [FieldOffset(60)]
    public int CurveId;
    [FieldOffset(64)]
    public bool DenyLowerHeight;
    [FieldOffset(65)]
    public bool StopAtHighCollision;

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 727107, RefRangeEnd = 727109, XrefRangeStart = 727081, XrefRangeEnd = 727107, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe float3 GetTargetPositionFromInput(
      [In] ref FixedList64<float3> aimPositions,
      [In] ref TravelBuffSpawn travelBuffSpawn,
      [In] ref float3 startPosition,
      ref MapCollision mapCollision,
      ref Unity.Mathematics.Random random,
      ref TileWorld tileWorld,
      ref CollisionWorld collisionWorld)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[7];
      numPtr[0] = (System.IntPtr) ref aimPositions;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref travelBuffSpawn;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref startPosition;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref mapCollision;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref random;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref tileWorld;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) ref collisionWorld;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TravelBuff.NativeMethodInfoPtr_GetTargetPositionFromInput_Public_float3_byref_FixedList64_1_float3_byref_TravelBuffSpawn_byref_float3_byref_MapCollision_byref_Random_byref_TileWorld_byref_CollisionWorld_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float3*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public unsafe GameplayLocationCollisionInfo GetCollisionInfo(float radius)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &radius;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TravelBuff.NativeMethodInfoPtr_GetCollisionInfo_Public_GameplayLocationCollisionInfo_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(GameplayLocationCollisionInfo*) IL2CPP.il2cpp_object_unbox(num);
    }

    static TravelBuff()
    {
      Il2CppClassPointerStore<TravelBuff>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (TravelBuff));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TravelBuff>.NativeClassPtr);
      TravelBuff.NativeFieldInfoPtr_StartPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TravelBuff>.NativeClassPtr, nameof (StartPosition));
      TravelBuff.NativeFieldInfoPtr_EndPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TravelBuff>.NativeClassPtr, nameof (EndPosition));
      TravelBuff.NativeFieldInfoPtr_MaxHeightDiff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TravelBuff>.NativeClassPtr, nameof (MaxHeightDiff));
      TravelBuff.NativeFieldInfoPtr_ExtraDistanceAllowed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TravelBuff>.NativeClassPtr, nameof (ExtraDistanceAllowed));
      TravelBuff.NativeFieldInfoPtr_Height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TravelBuff>.NativeClassPtr, nameof (Height));
      TravelBuff.NativeFieldInfoPtr_MaxRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TravelBuff>.NativeClassPtr, nameof (MaxRange));
      TravelBuff.NativeFieldInfoPtr_Curve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TravelBuff>.NativeClassPtr, nameof (Curve));
      TravelBuff.NativeFieldInfoPtr_HeightCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TravelBuff>.NativeClassPtr, nameof (HeightCurve));
      TravelBuff.NativeFieldInfoPtr_RotationMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TravelBuff>.NativeClassPtr, nameof (RotationMode));
      TravelBuff.NativeFieldInfoPtr_CurveId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TravelBuff>.NativeClassPtr, nameof (CurveId));
      TravelBuff.NativeFieldInfoPtr_DenyLowerHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TravelBuff>.NativeClassPtr, nameof (DenyLowerHeight));
      TravelBuff.NativeFieldInfoPtr_StopAtHighCollision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TravelBuff>.NativeClassPtr, nameof (StopAtHighCollision));
      TravelBuff.NativeMethodInfoPtr_GetTargetPositionFromInput_Public_float3_byref_FixedList64_1_float3_byref_TravelBuffSpawn_byref_float3_byref_MapCollision_byref_Random_byref_TileWorld_byref_CollisionWorld_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TravelBuff>.NativeClassPtr, 100664305);
      TravelBuff.NativeMethodInfoPtr_GetCollisionInfo_Public_GameplayLocationCollisionInfo_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TravelBuff>.NativeClassPtr, 100664306);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TravelBuff>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
