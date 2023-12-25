// Decompiled with JetBrains decompiler
// Type: ProjectM.OldCritter.CritterSpawn
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM.OldCritter
{
  public class CritterSpawn : MonoBehaviour
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_DistanceMultiplier;
    private static readonly System.IntPtr NativeFieldInfoPtr_MovementRadius;
    private static readonly System.IntPtr NativeFieldInfoPtr_EscapeSpeedMultiplier;
    private static readonly System.IntPtr NativeFieldInfoPtr_AngleFactor;
    private static readonly System.IntPtr NativeFieldInfoPtr_DistanceFactor;
    private static readonly System.IntPtr NativeFieldInfoPtr_SteeringFactorCurve;
    private static readonly System.IntPtr NativeFieldInfoPtr_SteeringFactor;
    private static readonly System.IntPtr NativeFieldInfoPtr_AvoidThreshold;
    private static readonly System.IntPtr NativeFieldInfoPtr_OutOfBoundsCallFrequency;
    private static readonly System.IntPtr NativeFieldInfoPtr_MinDistanceToGoalPoint;
    private static readonly System.IntPtr NativeFieldInfoPtr_LODCollider;
    private static readonly System.IntPtr NativeFieldInfoPtr__IsSpawned;
    private static readonly System.IntPtr NativeFieldInfoPtr__WantToEscape;
    private static readonly System.IntPtr NativeFieldInfoPtr__HasEscaped;
    private static readonly System.IntPtr NativeFieldInfoPtr__Critters;
    private static readonly System.IntPtr NativeFieldInfoPtr__SelfPosition;
    private static readonly System.IntPtr NativeFieldInfoPtr__CritterPositions;
    private static readonly System.IntPtr NativeFieldInfoPtr__OriginalCritterPositions;
    private static readonly System.IntPtr NativeFieldInfoPtr__OriginalMovementSpeed;
    private static readonly System.IntPtr NativeFieldInfoPtr__OriginalRotationSpeed;
    private static readonly System.IntPtr NativeFieldInfoPtr__OriginalCritterRotations;
    private static readonly System.IntPtr NativeMethodInfoPtr_Reset_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnTriggerEnter_Private_Void_Collider_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDrawGizmosSelected_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1125292, XrefRangeEnd = 1125299, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CritterSpawn.NativeMethodInfoPtr_Reset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1125299, XrefRangeEnd = 1125329, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Awake()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CritterSpawn.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1125329, XrefRangeEnd = 1125331, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnTriggerEnter(Collider collider)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) collider);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CritterSpawn.NativeMethodInfoPtr_OnTriggerEnter_Private_Void_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1125331, XrefRangeEnd = 1125339, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Update()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CritterSpawn.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1125339, XrefRangeEnd = 1125348, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnDrawGizmosSelected()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CritterSpawn.NativeMethodInfoPtr_OnDrawGizmosSelected_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1125348, XrefRangeEnd = 1125349, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CritterSpawn()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CritterSpawn>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CritterSpawn.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static CritterSpawn()
    {
      Il2CppClassPointerStore<CritterSpawn>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.OldCritter", nameof (CritterSpawn));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CritterSpawn>.NativeClassPtr);
      CritterSpawn.NativeFieldInfoPtr_DistanceMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterSpawn>.NativeClassPtr, nameof (DistanceMultiplier));
      CritterSpawn.NativeFieldInfoPtr_MovementRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterSpawn>.NativeClassPtr, nameof (MovementRadius));
      CritterSpawn.NativeFieldInfoPtr_EscapeSpeedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterSpawn>.NativeClassPtr, nameof (EscapeSpeedMultiplier));
      CritterSpawn.NativeFieldInfoPtr_AngleFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterSpawn>.NativeClassPtr, nameof (AngleFactor));
      CritterSpawn.NativeFieldInfoPtr_DistanceFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterSpawn>.NativeClassPtr, nameof (DistanceFactor));
      CritterSpawn.NativeFieldInfoPtr_SteeringFactorCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterSpawn>.NativeClassPtr, nameof (SteeringFactorCurve));
      CritterSpawn.NativeFieldInfoPtr_SteeringFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterSpawn>.NativeClassPtr, nameof (SteeringFactor));
      CritterSpawn.NativeFieldInfoPtr_AvoidThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterSpawn>.NativeClassPtr, nameof (AvoidThreshold));
      CritterSpawn.NativeFieldInfoPtr_OutOfBoundsCallFrequency = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterSpawn>.NativeClassPtr, nameof (OutOfBoundsCallFrequency));
      CritterSpawn.NativeFieldInfoPtr_MinDistanceToGoalPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterSpawn>.NativeClassPtr, nameof (MinDistanceToGoalPoint));
      CritterSpawn.NativeFieldInfoPtr_LODCollider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterSpawn>.NativeClassPtr, nameof (LODCollider));
      CritterSpawn.NativeFieldInfoPtr__IsSpawned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterSpawn>.NativeClassPtr, nameof (_IsSpawned));
      CritterSpawn.NativeFieldInfoPtr__WantToEscape = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterSpawn>.NativeClassPtr, nameof (_WantToEscape));
      CritterSpawn.NativeFieldInfoPtr__HasEscaped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterSpawn>.NativeClassPtr, nameof (_HasEscaped));
      CritterSpawn.NativeFieldInfoPtr__Critters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterSpawn>.NativeClassPtr, nameof (_Critters));
      CritterSpawn.NativeFieldInfoPtr__SelfPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterSpawn>.NativeClassPtr, nameof (_SelfPosition));
      CritterSpawn.NativeFieldInfoPtr__CritterPositions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterSpawn>.NativeClassPtr, nameof (_CritterPositions));
      CritterSpawn.NativeFieldInfoPtr__OriginalCritterPositions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterSpawn>.NativeClassPtr, nameof (_OriginalCritterPositions));
      CritterSpawn.NativeFieldInfoPtr__OriginalMovementSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterSpawn>.NativeClassPtr, nameof (_OriginalMovementSpeed));
      CritterSpawn.NativeFieldInfoPtr__OriginalRotationSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterSpawn>.NativeClassPtr, nameof (_OriginalRotationSpeed));
      CritterSpawn.NativeFieldInfoPtr__OriginalCritterRotations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterSpawn>.NativeClassPtr, nameof (_OriginalCritterRotations));
      CritterSpawn.NativeMethodInfoPtr_Reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterSpawn>.NativeClassPtr, 100689263);
      CritterSpawn.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterSpawn>.NativeClassPtr, 100689264);
      CritterSpawn.NativeMethodInfoPtr_OnTriggerEnter_Private_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterSpawn>.NativeClassPtr, 100689265);
      CritterSpawn.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterSpawn>.NativeClassPtr, 100689266);
      CritterSpawn.NativeMethodInfoPtr_OnDrawGizmosSelected_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterSpawn>.NativeClassPtr, 100689267);
      CritterSpawn.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterSpawn>.NativeClassPtr, 100689268);
    }

    public CritterSpawn(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe float DistanceMultiplier
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterSpawn.NativeFieldInfoPtr_DistanceMultiplier));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterSpawn.NativeFieldInfoPtr_DistanceMultiplier)) = value;
      }
    }

    public unsafe float MovementRadius
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterSpawn.NativeFieldInfoPtr_MovementRadius));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterSpawn.NativeFieldInfoPtr_MovementRadius)) = value;
      }
    }

    public unsafe float EscapeSpeedMultiplier
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterSpawn.NativeFieldInfoPtr_EscapeSpeedMultiplier));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterSpawn.NativeFieldInfoPtr_EscapeSpeedMultiplier)) = value;
      }
    }

    public unsafe AnimationCurve AngleFactor
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterSpawn.NativeFieldInfoPtr_AngleFactor));
        return pointer == System.IntPtr.Zero ? (AnimationCurve) null : new AnimationCurve(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CritterSpawn.NativeFieldInfoPtr_AngleFactor), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe AnimationCurve DistanceFactor
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterSpawn.NativeFieldInfoPtr_DistanceFactor));
        return pointer == System.IntPtr.Zero ? (AnimationCurve) null : new AnimationCurve(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CritterSpawn.NativeFieldInfoPtr_DistanceFactor), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe AnimationCurve SteeringFactorCurve
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterSpawn.NativeFieldInfoPtr_SteeringFactorCurve));
        return pointer == System.IntPtr.Zero ? (AnimationCurve) null : new AnimationCurve(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CritterSpawn.NativeFieldInfoPtr_SteeringFactorCurve), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float SteeringFactor
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterSpawn.NativeFieldInfoPtr_SteeringFactor));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterSpawn.NativeFieldInfoPtr_SteeringFactor)) = value;
      }
    }

    public unsafe float AvoidThreshold
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterSpawn.NativeFieldInfoPtr_AvoidThreshold));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterSpawn.NativeFieldInfoPtr_AvoidThreshold)) = value;
      }
    }

    public unsafe float OutOfBoundsCallFrequency
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterSpawn.NativeFieldInfoPtr_OutOfBoundsCallFrequency));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterSpawn.NativeFieldInfoPtr_OutOfBoundsCallFrequency)) = value;
      }
    }

    public unsafe float MinDistanceToGoalPoint
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterSpawn.NativeFieldInfoPtr_MinDistanceToGoalPoint));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterSpawn.NativeFieldInfoPtr_MinDistanceToGoalPoint)) = value;
      }
    }

    public unsafe CritterLODCollider LODCollider
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterSpawn.NativeFieldInfoPtr_LODCollider));
        return pointer == System.IntPtr.Zero ? (CritterLODCollider) null : new CritterLODCollider(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CritterSpawn.NativeFieldInfoPtr_LODCollider), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool _IsSpawned
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterSpawn.NativeFieldInfoPtr__IsSpawned));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterSpawn.NativeFieldInfoPtr__IsSpawned)) = value;
      }
    }

    public unsafe bool _WantToEscape
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterSpawn.NativeFieldInfoPtr__WantToEscape));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterSpawn.NativeFieldInfoPtr__WantToEscape)) = value;
      }
    }

    public unsafe bool _HasEscaped
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterSpawn.NativeFieldInfoPtr__HasEscaped));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterSpawn.NativeFieldInfoPtr__HasEscaped)) = value;
      }
    }

    public unsafe Il2CppReferenceArray<Critter> _Critters
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterSpawn.NativeFieldInfoPtr__Critters));
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<Critter>) null : new Il2CppReferenceArray<Critter>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CritterSpawn.NativeFieldInfoPtr__Critters), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Vector3 _SelfPosition
    {
      get
      {
        return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterSpawn.NativeFieldInfoPtr__SelfPosition));
      }
      [param: In] set
      {
        *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterSpawn.NativeFieldInfoPtr__SelfPosition)) = value;
      }
    }

    public unsafe Il2CppStructArray<Vector3> _CritterPositions
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterSpawn.NativeFieldInfoPtr__CritterPositions));
        return nativeObject == System.IntPtr.Zero ? (Il2CppStructArray<Vector3>) null : new Il2CppStructArray<Vector3>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CritterSpawn.NativeFieldInfoPtr__CritterPositions), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppStructArray<Vector3> _OriginalCritterPositions
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterSpawn.NativeFieldInfoPtr__OriginalCritterPositions));
        return nativeObject == System.IntPtr.Zero ? (Il2CppStructArray<Vector3>) null : new Il2CppStructArray<Vector3>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CritterSpawn.NativeFieldInfoPtr__OriginalCritterPositions), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppStructArray<float> _OriginalMovementSpeed
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterSpawn.NativeFieldInfoPtr__OriginalMovementSpeed));
        return nativeObject == System.IntPtr.Zero ? (Il2CppStructArray<float>) null : new Il2CppStructArray<float>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CritterSpawn.NativeFieldInfoPtr__OriginalMovementSpeed), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppStructArray<float> _OriginalRotationSpeed
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterSpawn.NativeFieldInfoPtr__OriginalRotationSpeed));
        return nativeObject == System.IntPtr.Zero ? (Il2CppStructArray<float>) null : new Il2CppStructArray<float>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CritterSpawn.NativeFieldInfoPtr__OriginalRotationSpeed), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppStructArray<Quaternion> _OriginalCritterRotations
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterSpawn.NativeFieldInfoPtr__OriginalCritterRotations));
        return nativeObject == System.IntPtr.Zero ? (Il2CppStructArray<Quaternion>) null : new Il2CppStructArray<Quaternion>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CritterSpawn.NativeFieldInfoPtr__OriginalCritterRotations), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static class Hashes : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_float_baseLayerAnimSpeed;
      private static readonly System.IntPtr NativeFieldInfoPtr_float_animSpeedMultiplier;
      private static readonly System.IntPtr NativeFieldInfoPtr_bool_escape;
      private static readonly System.IntPtr NativeFieldInfoPtr_bool_turnLeft;

      static Hashes()
      {
        Il2CppClassPointerStore<CritterSpawn.Hashes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CritterSpawn>.NativeClassPtr, nameof (Hashes));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CritterSpawn.Hashes>.NativeClassPtr);
        CritterSpawn.Hashes.NativeFieldInfoPtr_float_baseLayerAnimSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterSpawn.Hashes>.NativeClassPtr, nameof (float_baseLayerAnimSpeed));
        CritterSpawn.Hashes.NativeFieldInfoPtr_float_animSpeedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterSpawn.Hashes>.NativeClassPtr, nameof (float_animSpeedMultiplier));
        CritterSpawn.Hashes.NativeFieldInfoPtr_bool_escape = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterSpawn.Hashes>.NativeClassPtr, nameof (bool_escape));
        CritterSpawn.Hashes.NativeFieldInfoPtr_bool_turnLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterSpawn.Hashes>.NativeClassPtr, nameof (bool_turnLeft));
      }

      public Hashes(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static unsafe int float_baseLayerAnimSpeed
      {
        get
        {
          int baseLayerAnimSpeed;
          IL2CPP.il2cpp_field_static_get_value(CritterSpawn.Hashes.NativeFieldInfoPtr_float_baseLayerAnimSpeed, (void*) &baseLayerAnimSpeed);
          return baseLayerAnimSpeed;
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(CritterSpawn.Hashes.NativeFieldInfoPtr_float_baseLayerAnimSpeed, (void*) &value);
        }
      }

      public static unsafe int float_animSpeedMultiplier
      {
        get
        {
          int animSpeedMultiplier;
          IL2CPP.il2cpp_field_static_get_value(CritterSpawn.Hashes.NativeFieldInfoPtr_float_animSpeedMultiplier, (void*) &animSpeedMultiplier);
          return animSpeedMultiplier;
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(CritterSpawn.Hashes.NativeFieldInfoPtr_float_animSpeedMultiplier, (void*) &value);
        }
      }

      public static unsafe int bool_escape
      {
        get
        {
          int boolEscape;
          IL2CPP.il2cpp_field_static_get_value(CritterSpawn.Hashes.NativeFieldInfoPtr_bool_escape, (void*) &boolEscape);
          return boolEscape;
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(CritterSpawn.Hashes.NativeFieldInfoPtr_bool_escape, (void*) &value);
        }
      }

      public static unsafe int bool_turnLeft
      {
        get
        {
          int boolTurnLeft;
          IL2CPP.il2cpp_field_static_get_value(CritterSpawn.Hashes.NativeFieldInfoPtr_bool_turnLeft, (void*) &boolTurnLeft);
          return boolTurnLeft;
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(CritterSpawn.Hashes.NativeFieldInfoPtr_bool_turnLeft, (void*) &value);
        }
      }
    }
  }
}
