// Decompiled with JetBrains decompiler
// Type: ProjectM.GenericFleeingBehaviourComponent
// Assembly: ProjectM.Behaviours, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0B013578-4768-467C-9297-D6D62C4210E8
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Behaviours.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Behaviours;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  public class GenericFleeingBehaviourComponent : BehaviourTreeComponent
  {
    private static readonly IntPtr NativeFieldInfoPtr_TargetDistanceMin;
    private static readonly IntPtr NativeFieldInfoPtr_TargetDistanceMax;
    private static readonly IntPtr NativeFieldInfoPtr_MaxWanderDistanceFromHome;
    private static readonly IntPtr NativeFieldInfoPtr_UpdateFrequencyMin;
    private static readonly IntPtr NativeFieldInfoPtr_UpdateFrequencyMax;
    private static readonly IntPtr NativeFieldInfoPtr_IdleChillTimeMin;
    private static readonly IntPtr NativeFieldInfoPtr_IdleChillTimeMax;
    private static readonly IntPtr NativeFieldInfoPtr_LeaveCombatDelay_NoAggro;
    private static readonly IntPtr NativeFieldInfoPtr_AlertAllies;
    private static readonly IntPtr NativeFieldInfoPtr_ForceAimInMoveDirection;
    private static readonly IntPtr NativeFieldInfoPtr_RelocationSettings;
    private static readonly IntPtr NativeFieldInfoPtr_CastOptionsPrefab;
    private static readonly IntPtr NativeMethodInfoPtr_BuildTree_Protected_Virtual_BehaviourTreeNodeAuthoring_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr_Initialize_Private_BehaviourTreeNodeAuthoring_0;
    private static readonly IntPtr NativeMethodInfoPtr_Idle_Private_BehaviourTreeNodeAuthoring_0;
    private static readonly IntPtr NativeMethodInfoPtr_Combat_Public_BehaviourTreeNodeAuthoring_0;
    private static readonly IntPtr NativeMethodInfoPtr_Relocate_Public_BehaviourTreeNodeAuthoring_0;
    private static readonly IntPtr NativeMethodInfoPtr_RelocationCheck_Private_BehaviourTreeNodeAuthoring_0;
    private static readonly IntPtr NativeMethodInfoPtr_RenewPath_Public_Static_BehaviourTreeNodeAuthoring_Single_Single_0;
    private static readonly IntPtr NativeMethodInfoPtr_TryGetAggroTarget_Internal_Static_BehaviourTreeNodeAuthoring_String_0;
    private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1327974, XrefRangeEnd = 1328010, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe BehaviourTreeNodeAuthoring BuildTree(
      GameObjectConversionSystem conversionSystem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conversionSystem);
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), GenericFleeingBehaviourComponent.NativeMethodInfoPtr_BuildTree_Protected_Virtual_BehaviourTreeNodeAuthoring_GameObjectConversionSystem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (BehaviourTreeNodeAuthoring) null : new BehaviourTreeNodeAuthoring(pointer);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1328043, RefRangeEnd = 1328044, XrefRangeStart = 1328010, XrefRangeEnd = 1328043, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BehaviourTreeNodeAuthoring Initialize()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(GenericFleeingBehaviourComponent.NativeMethodInfoPtr_Initialize_Private_BehaviourTreeNodeAuthoring_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (BehaviourTreeNodeAuthoring) null : new BehaviourTreeNodeAuthoring(pointer);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1328148, RefRangeEnd = 1328149, XrefRangeStart = 1328044, XrefRangeEnd = 1328148, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BehaviourTreeNodeAuthoring Idle()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(GenericFleeingBehaviourComponent.NativeMethodInfoPtr_Idle_Private_BehaviourTreeNodeAuthoring_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (BehaviourTreeNodeAuthoring) null : new BehaviourTreeNodeAuthoring(pointer);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1328309, RefRangeEnd = 1328311, XrefRangeStart = 1328149, XrefRangeEnd = 1328309, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BehaviourTreeNodeAuthoring Combat()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(GenericFleeingBehaviourComponent.NativeMethodInfoPtr_Combat_Public_BehaviourTreeNodeAuthoring_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (BehaviourTreeNodeAuthoring) null : new BehaviourTreeNodeAuthoring(pointer);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1328312, RefRangeEnd = 1328313, XrefRangeStart = 1328311, XrefRangeEnd = 1328312, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BehaviourTreeNodeAuthoring Relocate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(GenericFleeingBehaviourComponent.NativeMethodInfoPtr_Relocate_Public_BehaviourTreeNodeAuthoring_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (BehaviourTreeNodeAuthoring) null : new BehaviourTreeNodeAuthoring(pointer);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1328356, RefRangeEnd = 1328357, XrefRangeStart = 1328313, XrefRangeEnd = 1328356, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BehaviourTreeNodeAuthoring RelocationCheck()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(GenericFleeingBehaviourComponent.NativeMethodInfoPtr_RelocationCheck_Private_BehaviourTreeNodeAuthoring_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (BehaviourTreeNodeAuthoring) null : new BehaviourTreeNodeAuthoring(pointer);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 1328404, RefRangeEnd = 1328408, XrefRangeStart = 1328357, XrefRangeEnd = 1328404, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe BehaviourTreeNodeAuthoring RenewPath(float minDistance, float maxDistance)
    {
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = (IntPtr) &minDistance;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &maxDistance;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(GenericFleeingBehaviourComponent.NativeMethodInfoPtr_RenewPath_Public_Static_BehaviourTreeNodeAuthoring_Single_Single_0, IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (BehaviourTreeNodeAuthoring) null : new BehaviourTreeNodeAuthoring(pointer);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1328421, RefRangeEnd = 1328424, XrefRangeStart = 1328408, XrefRangeEnd = 1328421, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe BehaviourTreeNodeAuthoring TryGetAggroTarget(string sourceEntity = null)
    {
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(sourceEntity);
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(GenericFleeingBehaviourComponent.NativeMethodInfoPtr_TryGetAggroTarget_Internal_Static_BehaviourTreeNodeAuthoring_String_0, IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (BehaviourTreeNodeAuthoring) null : new BehaviourTreeNodeAuthoring(pointer);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Start()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GenericFleeingBehaviourComponent.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1328424, XrefRangeEnd = 1328425, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe GenericFleeingBehaviourComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenericFleeingBehaviourComponent>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GenericFleeingBehaviourComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static GenericFleeingBehaviourComponent()
    {
      Il2CppClassPointerStore<GenericFleeingBehaviourComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Behaviours.dll", "ProjectM", nameof (GenericFleeingBehaviourComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenericFleeingBehaviourComponent>.NativeClassPtr);
      GenericFleeingBehaviourComponent.NativeFieldInfoPtr_TargetDistanceMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericFleeingBehaviourComponent>.NativeClassPtr, nameof (TargetDistanceMin));
      GenericFleeingBehaviourComponent.NativeFieldInfoPtr_TargetDistanceMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericFleeingBehaviourComponent>.NativeClassPtr, nameof (TargetDistanceMax));
      GenericFleeingBehaviourComponent.NativeFieldInfoPtr_MaxWanderDistanceFromHome = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericFleeingBehaviourComponent>.NativeClassPtr, nameof (MaxWanderDistanceFromHome));
      GenericFleeingBehaviourComponent.NativeFieldInfoPtr_UpdateFrequencyMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericFleeingBehaviourComponent>.NativeClassPtr, nameof (UpdateFrequencyMin));
      GenericFleeingBehaviourComponent.NativeFieldInfoPtr_UpdateFrequencyMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericFleeingBehaviourComponent>.NativeClassPtr, nameof (UpdateFrequencyMax));
      GenericFleeingBehaviourComponent.NativeFieldInfoPtr_IdleChillTimeMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericFleeingBehaviourComponent>.NativeClassPtr, nameof (IdleChillTimeMin));
      GenericFleeingBehaviourComponent.NativeFieldInfoPtr_IdleChillTimeMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericFleeingBehaviourComponent>.NativeClassPtr, nameof (IdleChillTimeMax));
      GenericFleeingBehaviourComponent.NativeFieldInfoPtr_LeaveCombatDelay_NoAggro = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericFleeingBehaviourComponent>.NativeClassPtr, nameof (LeaveCombatDelay_NoAggro));
      GenericFleeingBehaviourComponent.NativeFieldInfoPtr_AlertAllies = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericFleeingBehaviourComponent>.NativeClassPtr, nameof (AlertAllies));
      GenericFleeingBehaviourComponent.NativeFieldInfoPtr_ForceAimInMoveDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericFleeingBehaviourComponent>.NativeClassPtr, nameof (ForceAimInMoveDirection));
      GenericFleeingBehaviourComponent.NativeFieldInfoPtr_RelocationSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericFleeingBehaviourComponent>.NativeClassPtr, nameof (RelocationSettings));
      GenericFleeingBehaviourComponent.NativeFieldInfoPtr_CastOptionsPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericFleeingBehaviourComponent>.NativeClassPtr, nameof (CastOptionsPrefab));
      GenericFleeingBehaviourComponent.NativeMethodInfoPtr_BuildTree_Protected_Virtual_BehaviourTreeNodeAuthoring_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericFleeingBehaviourComponent>.NativeClassPtr, 100663727);
      GenericFleeingBehaviourComponent.NativeMethodInfoPtr_Initialize_Private_BehaviourTreeNodeAuthoring_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericFleeingBehaviourComponent>.NativeClassPtr, 100663728);
      GenericFleeingBehaviourComponent.NativeMethodInfoPtr_Idle_Private_BehaviourTreeNodeAuthoring_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericFleeingBehaviourComponent>.NativeClassPtr, 100663729);
      GenericFleeingBehaviourComponent.NativeMethodInfoPtr_Combat_Public_BehaviourTreeNodeAuthoring_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericFleeingBehaviourComponent>.NativeClassPtr, 100663730);
      GenericFleeingBehaviourComponent.NativeMethodInfoPtr_Relocate_Public_BehaviourTreeNodeAuthoring_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericFleeingBehaviourComponent>.NativeClassPtr, 100663731);
      GenericFleeingBehaviourComponent.NativeMethodInfoPtr_RelocationCheck_Private_BehaviourTreeNodeAuthoring_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericFleeingBehaviourComponent>.NativeClassPtr, 100663732);
      GenericFleeingBehaviourComponent.NativeMethodInfoPtr_RenewPath_Public_Static_BehaviourTreeNodeAuthoring_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericFleeingBehaviourComponent>.NativeClassPtr, 100663733);
      GenericFleeingBehaviourComponent.NativeMethodInfoPtr_TryGetAggroTarget_Internal_Static_BehaviourTreeNodeAuthoring_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericFleeingBehaviourComponent>.NativeClassPtr, 100663734);
      GenericFleeingBehaviourComponent.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericFleeingBehaviourComponent>.NativeClassPtr, 100663735);
      GenericFleeingBehaviourComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericFleeingBehaviourComponent>.NativeClassPtr, 100663736);
    }

    public GenericFleeingBehaviourComponent(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe float TargetDistanceMin
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GenericFleeingBehaviourComponent.NativeFieldInfoPtr_TargetDistanceMin));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GenericFleeingBehaviourComponent.NativeFieldInfoPtr_TargetDistanceMin)) = value;
      }
    }

    public unsafe float TargetDistanceMax
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GenericFleeingBehaviourComponent.NativeFieldInfoPtr_TargetDistanceMax));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GenericFleeingBehaviourComponent.NativeFieldInfoPtr_TargetDistanceMax)) = value;
      }
    }

    public unsafe float MaxWanderDistanceFromHome
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GenericFleeingBehaviourComponent.NativeFieldInfoPtr_MaxWanderDistanceFromHome));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GenericFleeingBehaviourComponent.NativeFieldInfoPtr_MaxWanderDistanceFromHome)) = value;
      }
    }

    public unsafe float UpdateFrequencyMin
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GenericFleeingBehaviourComponent.NativeFieldInfoPtr_UpdateFrequencyMin));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GenericFleeingBehaviourComponent.NativeFieldInfoPtr_UpdateFrequencyMin)) = value;
      }
    }

    public unsafe float UpdateFrequencyMax
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GenericFleeingBehaviourComponent.NativeFieldInfoPtr_UpdateFrequencyMax));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GenericFleeingBehaviourComponent.NativeFieldInfoPtr_UpdateFrequencyMax)) = value;
      }
    }

    public unsafe float IdleChillTimeMin
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GenericFleeingBehaviourComponent.NativeFieldInfoPtr_IdleChillTimeMin));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GenericFleeingBehaviourComponent.NativeFieldInfoPtr_IdleChillTimeMin)) = value;
      }
    }

    public unsafe float IdleChillTimeMax
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GenericFleeingBehaviourComponent.NativeFieldInfoPtr_IdleChillTimeMax));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GenericFleeingBehaviourComponent.NativeFieldInfoPtr_IdleChillTimeMax)) = value;
      }
    }

    public unsafe float LeaveCombatDelay_NoAggro
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GenericFleeingBehaviourComponent.NativeFieldInfoPtr_LeaveCombatDelay_NoAggro));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GenericFleeingBehaviourComponent.NativeFieldInfoPtr_LeaveCombatDelay_NoAggro)) = value;
      }
    }

    public unsafe bool AlertAllies
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GenericFleeingBehaviourComponent.NativeFieldInfoPtr_AlertAllies));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GenericFleeingBehaviourComponent.NativeFieldInfoPtr_AlertAllies)) = value;
      }
    }

    public unsafe bool ForceAimInMoveDirection
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GenericFleeingBehaviourComponent.NativeFieldInfoPtr_ForceAimInMoveDirection));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GenericFleeingBehaviourComponent.NativeFieldInfoPtr_ForceAimInMoveDirection)) = value;
      }
    }

    public unsafe RelocationSettingsAsset RelocationSettings
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GenericFleeingBehaviourComponent.NativeFieldInfoPtr_RelocationSettings));
        return pointer == IntPtr.Zero ? (RelocationSettingsAsset) null : new RelocationSettingsAsset(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GenericFleeingBehaviourComponent.NativeFieldInfoPtr_RelocationSettings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe PrefabGuidComponent CastOptionsPrefab
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GenericFleeingBehaviourComponent.NativeFieldInfoPtr_CastOptionsPrefab));
        return pointer == IntPtr.Zero ? (PrefabGuidComponent) null : new PrefabGuidComponent(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GenericFleeingBehaviourComponent.NativeFieldInfoPtr_CastOptionsPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
