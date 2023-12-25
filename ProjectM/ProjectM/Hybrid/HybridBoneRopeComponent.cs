// Decompiled with JetBrains decompiler
// Type: ProjectM.Hybrid.HybridBoneRopeComponent
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;

#nullable disable
namespace ProjectM.Hybrid
{
  public class HybridBoneRopeComponent : MonoBehaviour
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Branches;
    private static readonly System.IntPtr NativeFieldInfoPtr_Gravity;
    private static readonly System.IntPtr NativeFieldInfoPtr_Weight;
    private static readonly System.IntPtr NativeFieldInfoPtr_HasInitialized;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddComponent_Public_Virtual_Final_New_Void_World_PrefabLookupMap_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Init_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetDirection_Private_Vector3_Vector3_Vector3_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ResetAnimator_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void AddComponent(
      World world,
      PrefabLookupMap prefabLookupMap,
      Entity hybridEntity)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) world);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &prefabLookupMap;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &hybridEntity;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HybridBoneRopeComponent.NativeMethodInfoPtr_AddComponent_Public_Virtual_Final_New_Void_World_PrefabLookupMap_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1156444, RefRangeEnd = 1156445, XrefRangeStart = 1156438, XrefRangeEnd = 1156444, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Init()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HybridBoneRopeComponent.NativeMethodInfoPtr_Init_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1156445, RefRangeEnd = 1156447, XrefRangeStart = 1156445, XrefRangeEnd = 1156445, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Vector3 GetDirection(Vector3 from, Vector3 to)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &from;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &to;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HybridBoneRopeComponent.NativeMethodInfoPtr_GetDirection_Private_Vector3_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1156452, RefRangeEnd = 1156453, XrefRangeStart = 1156447, XrefRangeEnd = 1156452, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ResetAnimator()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HybridBoneRopeComponent.NativeMethodInfoPtr_ResetAnimator_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1156453, XrefRangeEnd = 1156454, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe HybridBoneRopeComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HybridBoneRopeComponent>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HybridBoneRopeComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static HybridBoneRopeComponent()
    {
      Il2CppClassPointerStore<HybridBoneRopeComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Hybrid", nameof (HybridBoneRopeComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HybridBoneRopeComponent>.NativeClassPtr);
      HybridBoneRopeComponent.NativeFieldInfoPtr_Branches = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridBoneRopeComponent>.NativeClassPtr, nameof (Branches));
      HybridBoneRopeComponent.NativeFieldInfoPtr_Gravity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridBoneRopeComponent>.NativeClassPtr, nameof (Gravity));
      HybridBoneRopeComponent.NativeFieldInfoPtr_Weight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridBoneRopeComponent>.NativeClassPtr, nameof (Weight));
      HybridBoneRopeComponent.NativeFieldInfoPtr_HasInitialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridBoneRopeComponent>.NativeClassPtr, nameof (HasInitialized));
      HybridBoneRopeComponent.NativeMethodInfoPtr_AddComponent_Public_Virtual_Final_New_Void_World_PrefabLookupMap_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridBoneRopeComponent>.NativeClassPtr, 100692030);
      HybridBoneRopeComponent.NativeMethodInfoPtr_Init_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridBoneRopeComponent>.NativeClassPtr, 100692031);
      HybridBoneRopeComponent.NativeMethodInfoPtr_GetDirection_Private_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridBoneRopeComponent>.NativeClassPtr, 100692032);
      HybridBoneRopeComponent.NativeMethodInfoPtr_ResetAnimator_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridBoneRopeComponent>.NativeClassPtr, 100692033);
      HybridBoneRopeComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridBoneRopeComponent>.NativeClassPtr, 100692034);
    }

    public HybridBoneRopeComponent(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Il2CppReferenceArray<HybridBoneRopeComponent.RopeBranch> Branches
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridBoneRopeComponent.NativeFieldInfoPtr_Branches));
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<HybridBoneRopeComponent.RopeBranch>) null : new Il2CppReferenceArray<HybridBoneRopeComponent.RopeBranch>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HybridBoneRopeComponent.NativeFieldInfoPtr_Branches), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float Gravity
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridBoneRopeComponent.NativeFieldInfoPtr_Gravity));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridBoneRopeComponent.NativeFieldInfoPtr_Gravity)) = value;
      }
    }

    public unsafe float Weight
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridBoneRopeComponent.NativeFieldInfoPtr_Weight));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridBoneRopeComponent.NativeFieldInfoPtr_Weight)) = value;
      }
    }

    public unsafe bool HasInitialized
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridBoneRopeComponent.NativeFieldInfoPtr_HasInitialized));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridBoneRopeComponent.NativeFieldInfoPtr_HasInitialized)) = value;
      }
    }

    [Serializable]
    public sealed class RopeSegment : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Bone;
      private static readonly System.IntPtr NativeFieldInfoPtr_ChainDirection;
      private static readonly System.IntPtr NativeFieldInfoPtr_UpDirection;
      private static readonly System.IntPtr NativeFieldInfoPtr_MaxAngle;
      private static readonly System.IntPtr NativeFieldInfoPtr_Thickness;
      private static readonly System.IntPtr NativeFieldInfoPtr_IsStatic;
      private static readonly System.IntPtr NativeFieldInfoPtr_IsAnimated;
      private static readonly System.IntPtr NativeFieldInfoPtr_Position;
      private static readonly System.IntPtr NativeFieldInfoPtr_SavedChainDirection;
      private static readonly System.IntPtr NativeFieldInfoPtr_SavedUpDirection;
      private static readonly System.IntPtr NativeFieldInfoPtr_AnimatedPosition;
      private static readonly System.IntPtr NativeFieldInfoPtr_AnimatedRotation;
      private static readonly System.IntPtr NativeFieldInfoPtr_StaticLocalPosition;
      private static readonly System.IntPtr NativeFieldInfoPtr_StaticLocalRotation;
      private static readonly System.IntPtr NativeFieldInfoPtr_MaxDistance;
      private static readonly System.IntPtr NativeMethodInfoPtr_Init_Public_Void_Single_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_GetMaxAngleInLength_Public_Single_Single_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SaveLocalTransformToStatic_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SaveTransformToAnimated_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_GetChainDirection_Public_Vector3_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_GetBoneChainDirection_Public_Vector3_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_GetUpDirection_Public_Vector3_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1156341, RefRangeEnd = 1156342, XrefRangeStart = 1156335, XrefRangeEnd = 1156341, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void Init(float distanceToParent, bool isRoot)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &distanceToParent;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &isRoot;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(HybridBoneRopeComponent.RopeSegment.NativeMethodInfoPtr_Init_Public_Void_Single_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1156350, RefRangeEnd = 1156352, XrefRangeStart = 1156342, XrefRangeEnd = 1156350, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe float GetMaxAngleInLength(float maxDistance)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &maxDistance;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HybridBoneRopeComponent.RopeSegment.NativeMethodInfoPtr_GetMaxAngleInLength_Public_Single_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(float*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1156352, XrefRangeEnd = 1156354, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SaveLocalTransformToStatic()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(HybridBoneRopeComponent.RopeSegment.NativeMethodInfoPtr_SaveLocalTransformToStatic_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1156360, RefRangeEnd = 1156362, XrefRangeStart = 1156354, XrefRangeEnd = 1156360, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SaveTransformToAnimated()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(HybridBoneRopeComponent.RopeSegment.NativeMethodInfoPtr_SaveTransformToAnimated_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1156363, RefRangeEnd = 1156365, XrefRangeStart = 1156362, XrefRangeEnd = 1156363, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Vector3 GetChainDirection()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HybridBoneRopeComponent.RopeSegment.NativeMethodInfoPtr_GetChainDirection_Public_Vector3_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(3)]
      [CachedScanResults(RefRangeStart = 1156395, RefRangeEnd = 1156398, XrefRangeStart = 1156365, XrefRangeEnd = 1156395, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Vector3 GetBoneChainDirection()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HybridBoneRopeComponent.RopeSegment.NativeMethodInfoPtr_GetBoneChainDirection_Public_Vector3_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1156428, RefRangeEnd = 1156430, XrefRangeStart = 1156398, XrefRangeEnd = 1156428, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Vector3 GetUpDirection()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HybridBoneRopeComponent.RopeSegment.NativeMethodInfoPtr_GetUpDirection_Public_Vector3_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
      }

      static RopeSegment()
      {
        Il2CppClassPointerStore<HybridBoneRopeComponent.RopeSegment>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HybridBoneRopeComponent>.NativeClassPtr, nameof (RopeSegment));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HybridBoneRopeComponent.RopeSegment>.NativeClassPtr);
        HybridBoneRopeComponent.RopeSegment.NativeFieldInfoPtr_Bone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridBoneRopeComponent.RopeSegment>.NativeClassPtr, nameof (Bone));
        HybridBoneRopeComponent.RopeSegment.NativeFieldInfoPtr_ChainDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridBoneRopeComponent.RopeSegment>.NativeClassPtr, nameof (ChainDirection));
        HybridBoneRopeComponent.RopeSegment.NativeFieldInfoPtr_UpDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridBoneRopeComponent.RopeSegment>.NativeClassPtr, nameof (UpDirection));
        HybridBoneRopeComponent.RopeSegment.NativeFieldInfoPtr_MaxAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridBoneRopeComponent.RopeSegment>.NativeClassPtr, nameof (MaxAngle));
        HybridBoneRopeComponent.RopeSegment.NativeFieldInfoPtr_Thickness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridBoneRopeComponent.RopeSegment>.NativeClassPtr, nameof (Thickness));
        HybridBoneRopeComponent.RopeSegment.NativeFieldInfoPtr_IsStatic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridBoneRopeComponent.RopeSegment>.NativeClassPtr, nameof (IsStatic));
        HybridBoneRopeComponent.RopeSegment.NativeFieldInfoPtr_IsAnimated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridBoneRopeComponent.RopeSegment>.NativeClassPtr, nameof (IsAnimated));
        HybridBoneRopeComponent.RopeSegment.NativeFieldInfoPtr_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridBoneRopeComponent.RopeSegment>.NativeClassPtr, nameof (Position));
        HybridBoneRopeComponent.RopeSegment.NativeFieldInfoPtr_SavedChainDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridBoneRopeComponent.RopeSegment>.NativeClassPtr, nameof (SavedChainDirection));
        HybridBoneRopeComponent.RopeSegment.NativeFieldInfoPtr_SavedUpDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridBoneRopeComponent.RopeSegment>.NativeClassPtr, nameof (SavedUpDirection));
        HybridBoneRopeComponent.RopeSegment.NativeFieldInfoPtr_AnimatedPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridBoneRopeComponent.RopeSegment>.NativeClassPtr, nameof (AnimatedPosition));
        HybridBoneRopeComponent.RopeSegment.NativeFieldInfoPtr_AnimatedRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridBoneRopeComponent.RopeSegment>.NativeClassPtr, nameof (AnimatedRotation));
        HybridBoneRopeComponent.RopeSegment.NativeFieldInfoPtr_StaticLocalPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridBoneRopeComponent.RopeSegment>.NativeClassPtr, nameof (StaticLocalPosition));
        HybridBoneRopeComponent.RopeSegment.NativeFieldInfoPtr_StaticLocalRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridBoneRopeComponent.RopeSegment>.NativeClassPtr, nameof (StaticLocalRotation));
        HybridBoneRopeComponent.RopeSegment.NativeFieldInfoPtr_MaxDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridBoneRopeComponent.RopeSegment>.NativeClassPtr, nameof (MaxDistance));
        HybridBoneRopeComponent.RopeSegment.NativeMethodInfoPtr_Init_Public_Void_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridBoneRopeComponent.RopeSegment>.NativeClassPtr, 100692035);
        HybridBoneRopeComponent.RopeSegment.NativeMethodInfoPtr_GetMaxAngleInLength_Public_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridBoneRopeComponent.RopeSegment>.NativeClassPtr, 100692036);
        HybridBoneRopeComponent.RopeSegment.NativeMethodInfoPtr_SaveLocalTransformToStatic_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridBoneRopeComponent.RopeSegment>.NativeClassPtr, 100692037);
        HybridBoneRopeComponent.RopeSegment.NativeMethodInfoPtr_SaveTransformToAnimated_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridBoneRopeComponent.RopeSegment>.NativeClassPtr, 100692038);
        HybridBoneRopeComponent.RopeSegment.NativeMethodInfoPtr_GetChainDirection_Public_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridBoneRopeComponent.RopeSegment>.NativeClassPtr, 100692039);
        HybridBoneRopeComponent.RopeSegment.NativeMethodInfoPtr_GetBoneChainDirection_Public_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridBoneRopeComponent.RopeSegment>.NativeClassPtr, 100692040);
        HybridBoneRopeComponent.RopeSegment.NativeMethodInfoPtr_GetUpDirection_Public_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridBoneRopeComponent.RopeSegment>.NativeClassPtr, 100692041);
      }

      public RopeSegment(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public RopeSegment()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<HybridBoneRopeComponent.RopeSegment>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HybridBoneRopeComponent.RopeSegment>.NativeClassPtr, data));
      }

      public unsafe Transform Bone
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridBoneRopeComponent.RopeSegment.NativeFieldInfoPtr_Bone));
          return pointer == System.IntPtr.Zero ? (Transform) null : new Transform(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HybridBoneRopeComponent.RopeSegment.NativeFieldInfoPtr_Bone), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Vector3 ChainDirection
      {
        get
        {
          return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridBoneRopeComponent.RopeSegment.NativeFieldInfoPtr_ChainDirection));
        }
        [param: In] set
        {
          *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridBoneRopeComponent.RopeSegment.NativeFieldInfoPtr_ChainDirection)) = value;
        }
      }

      public unsafe Vector3 UpDirection
      {
        get
        {
          return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridBoneRopeComponent.RopeSegment.NativeFieldInfoPtr_UpDirection));
        }
        [param: In] set
        {
          *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridBoneRopeComponent.RopeSegment.NativeFieldInfoPtr_UpDirection)) = value;
        }
      }

      public unsafe float MaxAngle
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridBoneRopeComponent.RopeSegment.NativeFieldInfoPtr_MaxAngle));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridBoneRopeComponent.RopeSegment.NativeFieldInfoPtr_MaxAngle)) = value;
        }
      }

      public unsafe float Thickness
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridBoneRopeComponent.RopeSegment.NativeFieldInfoPtr_Thickness));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridBoneRopeComponent.RopeSegment.NativeFieldInfoPtr_Thickness)) = value;
        }
      }

      public unsafe bool IsStatic
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridBoneRopeComponent.RopeSegment.NativeFieldInfoPtr_IsStatic));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridBoneRopeComponent.RopeSegment.NativeFieldInfoPtr_IsStatic)) = value;
        }
      }

      public unsafe bool IsAnimated
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridBoneRopeComponent.RopeSegment.NativeFieldInfoPtr_IsAnimated));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridBoneRopeComponent.RopeSegment.NativeFieldInfoPtr_IsAnimated)) = value;
        }
      }

      public unsafe Vector3 Position
      {
        get
        {
          return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridBoneRopeComponent.RopeSegment.NativeFieldInfoPtr_Position));
        }
        [param: In] set
        {
          *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridBoneRopeComponent.RopeSegment.NativeFieldInfoPtr_Position)) = value;
        }
      }

      public unsafe Vector3 SavedChainDirection
      {
        get
        {
          return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridBoneRopeComponent.RopeSegment.NativeFieldInfoPtr_SavedChainDirection));
        }
        [param: In] set
        {
          *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridBoneRopeComponent.RopeSegment.NativeFieldInfoPtr_SavedChainDirection)) = value;
        }
      }

      public unsafe Vector3 SavedUpDirection
      {
        get
        {
          return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridBoneRopeComponent.RopeSegment.NativeFieldInfoPtr_SavedUpDirection));
        }
        [param: In] set
        {
          *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridBoneRopeComponent.RopeSegment.NativeFieldInfoPtr_SavedUpDirection)) = value;
        }
      }

      public unsafe Vector3 AnimatedPosition
      {
        get
        {
          return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridBoneRopeComponent.RopeSegment.NativeFieldInfoPtr_AnimatedPosition));
        }
        [param: In] set
        {
          *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridBoneRopeComponent.RopeSegment.NativeFieldInfoPtr_AnimatedPosition)) = value;
        }
      }

      public unsafe Quaternion AnimatedRotation
      {
        get
        {
          return *(Quaternion*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridBoneRopeComponent.RopeSegment.NativeFieldInfoPtr_AnimatedRotation));
        }
        [param: In] set
        {
          *(Quaternion*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridBoneRopeComponent.RopeSegment.NativeFieldInfoPtr_AnimatedRotation)) = value;
        }
      }

      public unsafe Vector3 StaticLocalPosition
      {
        get
        {
          return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridBoneRopeComponent.RopeSegment.NativeFieldInfoPtr_StaticLocalPosition));
        }
        [param: In] set
        {
          *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridBoneRopeComponent.RopeSegment.NativeFieldInfoPtr_StaticLocalPosition)) = value;
        }
      }

      public unsafe Quaternion StaticLocalRotation
      {
        get
        {
          return *(Quaternion*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridBoneRopeComponent.RopeSegment.NativeFieldInfoPtr_StaticLocalRotation));
        }
        [param: In] set
        {
          *(Quaternion*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridBoneRopeComponent.RopeSegment.NativeFieldInfoPtr_StaticLocalRotation)) = value;
        }
      }

      public unsafe float MaxDistance
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridBoneRopeComponent.RopeSegment.NativeFieldInfoPtr_MaxDistance));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridBoneRopeComponent.RopeSegment.NativeFieldInfoPtr_MaxDistance)) = value;
        }
      }
    }

    [Serializable]
    public sealed class RopeBranch : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Name;
      private static readonly System.IntPtr NativeFieldInfoPtr_Segments;
      private static readonly System.IntPtr NativeFieldInfoPtr_HasNormalizedNormal;
      private static readonly System.IntPtr NativeFieldInfoPtr_IsActive;
      private static readonly System.IntPtr NativeFieldInfoPtr_UpNormal;
      private static readonly System.IntPtr NativeFieldInfoPtr_RootLocalRotation;
      private static readonly System.IntPtr NativeMethodInfoPtr_Init_Public_Void_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1156437, RefRangeEnd = 1156438, XrefRangeStart = 1156430, XrefRangeEnd = 1156437, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void Init()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(HybridBoneRopeComponent.RopeBranch.NativeMethodInfoPtr_Init_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static RopeBranch()
      {
        Il2CppClassPointerStore<HybridBoneRopeComponent.RopeBranch>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HybridBoneRopeComponent>.NativeClassPtr, nameof (RopeBranch));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HybridBoneRopeComponent.RopeBranch>.NativeClassPtr);
        HybridBoneRopeComponent.RopeBranch.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridBoneRopeComponent.RopeBranch>.NativeClassPtr, nameof (Name));
        HybridBoneRopeComponent.RopeBranch.NativeFieldInfoPtr_Segments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridBoneRopeComponent.RopeBranch>.NativeClassPtr, nameof (Segments));
        HybridBoneRopeComponent.RopeBranch.NativeFieldInfoPtr_HasNormalizedNormal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridBoneRopeComponent.RopeBranch>.NativeClassPtr, nameof (HasNormalizedNormal));
        HybridBoneRopeComponent.RopeBranch.NativeFieldInfoPtr_IsActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridBoneRopeComponent.RopeBranch>.NativeClassPtr, nameof (IsActive));
        HybridBoneRopeComponent.RopeBranch.NativeFieldInfoPtr_UpNormal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridBoneRopeComponent.RopeBranch>.NativeClassPtr, nameof (UpNormal));
        HybridBoneRopeComponent.RopeBranch.NativeFieldInfoPtr_RootLocalRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridBoneRopeComponent.RopeBranch>.NativeClassPtr, nameof (RootLocalRotation));
        HybridBoneRopeComponent.RopeBranch.NativeMethodInfoPtr_Init_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridBoneRopeComponent.RopeBranch>.NativeClassPtr, 100692042);
      }

      public RopeBranch(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public RopeBranch()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<HybridBoneRopeComponent.RopeBranch>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HybridBoneRopeComponent.RopeBranch>.NativeClassPtr, data));
      }

      public unsafe string Name
      {
        get
        {
          return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridBoneRopeComponent.RopeBranch.NativeFieldInfoPtr_Name)));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HybridBoneRopeComponent.RopeBranch.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
        }
      }

      public unsafe Il2CppReferenceArray<HybridBoneRopeComponent.RopeSegment> Segments
      {
        get
        {
          System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridBoneRopeComponent.RopeBranch.NativeFieldInfoPtr_Segments));
          return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<HybridBoneRopeComponent.RopeSegment>) null : new Il2CppReferenceArray<HybridBoneRopeComponent.RopeSegment>(nativeObject);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HybridBoneRopeComponent.RopeBranch.NativeFieldInfoPtr_Segments), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe bool HasNormalizedNormal
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridBoneRopeComponent.RopeBranch.NativeFieldInfoPtr_HasNormalizedNormal));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridBoneRopeComponent.RopeBranch.NativeFieldInfoPtr_HasNormalizedNormal)) = value;
        }
      }

      public unsafe bool IsActive
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridBoneRopeComponent.RopeBranch.NativeFieldInfoPtr_IsActive));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridBoneRopeComponent.RopeBranch.NativeFieldInfoPtr_IsActive)) = value;
        }
      }

      public unsafe Vector3 UpNormal
      {
        get
        {
          return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridBoneRopeComponent.RopeBranch.NativeFieldInfoPtr_UpNormal));
        }
        [param: In] set
        {
          *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridBoneRopeComponent.RopeBranch.NativeFieldInfoPtr_UpNormal)) = value;
        }
      }

      public unsafe Quaternion RootLocalRotation
      {
        get
        {
          return *(Quaternion*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridBoneRopeComponent.RopeBranch.NativeFieldInfoPtr_RootLocalRotation));
        }
        [param: In] set
        {
          *(Quaternion*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridBoneRopeComponent.RopeBranch.NativeFieldInfoPtr_RootLocalRotation)) = value;
        }
      }
    }
  }
}
