// Decompiled with JetBrains decompiler
// Type: ProjectM.TargetAoE
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using ProjectM.Gameplay;
using ProjectM.Shared;
using ProjectM.Tiles;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Mathematics;
using Unity.Physics;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct TargetAoE
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_TargetPositionType;
    private static readonly System.IntPtr NativeFieldInfoPtr_HandleCollisionType;
    private static readonly System.IntPtr NativeFieldInfoPtr_StartPosition;
    private static readonly System.IntPtr NativeFieldInfoPtr_EndPosition;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxRange;
    private static readonly System.IntPtr NativeFieldInfoPtr_MinRange;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_MinTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxRandomTimeAdded;
    private static readonly System.IntPtr NativeFieldInfoPtr_ThrowMaxHeightDiff;
    private static readonly System.IntPtr NativeFieldInfoPtr_ThrowArcHeight;
    private static readonly System.IntPtr NativeFieldInfoPtr_RandomOffsetMin;
    private static readonly System.IntPtr NativeFieldInfoPtr_RandomOffsetRadius;
    private static readonly System.IntPtr NativeFieldInfoPtr_MapCollisionRadius;
    private static readonly System.IntPtr NativeFieldInfoPtr_UseRandomOffset;
    private static readonly System.IntPtr NativeFieldInfoPtr_FindValidPositionFromMax;
    private static readonly System.IntPtr NativeMethodInfoPtr_CalculateEndPosition_Public_float3_float3_FixedList64_1_float3_byref_TileWorld_byref_CollisionWorld_byref_Random_byref_Single_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetCollisionInfo_Public_GameplayLocationCollisionInfo_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ApplyArithmetic_Public_Virtual_Final_New_Void_SpellModArithmetic_Single_0;
    [FieldOffset(0)]
    public TargetAoE.TargetPositionTypeEnum TargetPositionType;
    [FieldOffset(4)]
    public TargetAoE.HandleCollisionTypeEnum HandleCollisionType;
    [FieldOffset(8)]
    public float3 StartPosition;
    [FieldOffset(20)]
    public float3 EndPosition;
    [FieldOffset(32)]
    public float MaxRange;
    [FieldOffset(36)]
    public float MinRange;
    [FieldOffset(40)]
    public float MaxTime;
    [FieldOffset(44)]
    public float MinTime;
    [FieldOffset(48)]
    public float MaxRandomTimeAdded;
    [FieldOffset(52)]
    public float ThrowMaxHeightDiff;
    [FieldOffset(56)]
    public float ThrowArcHeight;
    [FieldOffset(60)]
    public float RandomOffsetMin;
    [FieldOffset(64)]
    public float RandomOffsetRadius;
    [FieldOffset(68)]
    public float MapCollisionRadius;
    [FieldOffset(72)]
    public bool UseRandomOffset;
    [FieldOffset(73)]
    public bool FindValidPositionFromMax;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 727037, RefRangeEnd = 727038, XrefRangeStart = 727010, XrefRangeEnd = 727037, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe float3 CalculateEndPosition(
      float3 startPosition,
      FixedList64<float3> aimPositions,
      [In] ref TileWorld tileWorld,
      ref CollisionWorld collisionWorld,
      ref Unity.Mathematics.Random random,
      out float rangeFactor,
      bool allowRandomOffset = true)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[7];
      numPtr[0] = (System.IntPtr) &startPosition;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &aimPositions;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref tileWorld;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref collisionWorld;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref random;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref rangeFactor;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &allowRandomOffset;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TargetAoE.NativeMethodInfoPtr_CalculateEndPosition_Public_float3_float3_FixedList64_1_float3_byref_TileWorld_byref_CollisionWorld_byref_Random_byref_Single_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float3*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public unsafe GameplayLocationCollisionInfo GetCollisionInfo()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TargetAoE.NativeMethodInfoPtr_GetCollisionInfo_Public_GameplayLocationCollisionInfo_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(GameplayLocationCollisionInfo*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 727042, RefRangeEnd = 727043, XrefRangeStart = 727038, XrefRangeEnd = 727042, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void ApplyArithmetic(SpellModArithmetic spellMod, float value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &spellMod;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TargetAoE.NativeMethodInfoPtr_ApplyArithmetic_Public_Virtual_Final_New_Void_SpellModArithmetic_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static TargetAoE()
    {
      Il2CppClassPointerStore<TargetAoE>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (TargetAoE));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TargetAoE>.NativeClassPtr);
      TargetAoE.NativeFieldInfoPtr_TargetPositionType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetAoE>.NativeClassPtr, nameof (TargetPositionType));
      TargetAoE.NativeFieldInfoPtr_HandleCollisionType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetAoE>.NativeClassPtr, nameof (HandleCollisionType));
      TargetAoE.NativeFieldInfoPtr_StartPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetAoE>.NativeClassPtr, nameof (StartPosition));
      TargetAoE.NativeFieldInfoPtr_EndPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetAoE>.NativeClassPtr, nameof (EndPosition));
      TargetAoE.NativeFieldInfoPtr_MaxRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetAoE>.NativeClassPtr, nameof (MaxRange));
      TargetAoE.NativeFieldInfoPtr_MinRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetAoE>.NativeClassPtr, nameof (MinRange));
      TargetAoE.NativeFieldInfoPtr_MaxTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetAoE>.NativeClassPtr, nameof (MaxTime));
      TargetAoE.NativeFieldInfoPtr_MinTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetAoE>.NativeClassPtr, nameof (MinTime));
      TargetAoE.NativeFieldInfoPtr_MaxRandomTimeAdded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetAoE>.NativeClassPtr, nameof (MaxRandomTimeAdded));
      TargetAoE.NativeFieldInfoPtr_ThrowMaxHeightDiff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetAoE>.NativeClassPtr, nameof (ThrowMaxHeightDiff));
      TargetAoE.NativeFieldInfoPtr_ThrowArcHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetAoE>.NativeClassPtr, nameof (ThrowArcHeight));
      TargetAoE.NativeFieldInfoPtr_RandomOffsetMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetAoE>.NativeClassPtr, nameof (RandomOffsetMin));
      TargetAoE.NativeFieldInfoPtr_RandomOffsetRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetAoE>.NativeClassPtr, nameof (RandomOffsetRadius));
      TargetAoE.NativeFieldInfoPtr_MapCollisionRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetAoE>.NativeClassPtr, nameof (MapCollisionRadius));
      TargetAoE.NativeFieldInfoPtr_UseRandomOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetAoE>.NativeClassPtr, nameof (UseRandomOffset));
      TargetAoE.NativeFieldInfoPtr_FindValidPositionFromMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetAoE>.NativeClassPtr, nameof (FindValidPositionFromMax));
      TargetAoE.NativeMethodInfoPtr_CalculateEndPosition_Public_float3_float3_FixedList64_1_float3_byref_TileWorld_byref_CollisionWorld_byref_Random_byref_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetAoE>.NativeClassPtr, 100664296);
      TargetAoE.NativeMethodInfoPtr_GetCollisionInfo_Public_GameplayLocationCollisionInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetAoE>.NativeClassPtr, 100664297);
      TargetAoE.NativeMethodInfoPtr_ApplyArithmetic_Public_Virtual_Final_New_Void_SpellModArithmetic_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetAoE>.NativeClassPtr, 100664298);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TargetAoE>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public enum TargetPositionTypeEnum
    {
      AimPosition,
      SpellTarget,
      Self,
      ForceSetOwner,
      RandomDirection,
    }

    public enum HandleCollisionTypeEnum
    {
      None,
      StopOnCollision,
    }
  }
}
