// Decompiled with JetBrains decompiler
// Type: ProjectM.CombatServantBehaviourComponent
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
  public class CombatServantBehaviourComponent : BehaviourTreeComponent
  {
    private static readonly IntPtr NativeFieldInfoPtr_GenericEnemyBehaviour;
    private static readonly IntPtr NativeFieldInfoPtr_CastOptionsOverride;
    private static readonly IntPtr NativeFieldInfoPtr_DecayDamagePercentage;
    private static readonly IntPtr NativeFieldInfoPtr_DecayDamageFrequency;
    private static readonly IntPtr NativeFieldInfoPtr_MIN_DESTINATION_WAIT_TIME;
    private static readonly IntPtr NativeFieldInfoPtr_MAX_DESTINATION_WAIT_TIME;
    private static readonly IntPtr NativeMethodInfoPtr_BuildTree_Protected_Virtual_BehaviourTreeNodeAuthoring_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr_Initialize_Private_BehaviourTreeNodeAuthoring_0;
    private static readonly IntPtr NativeMethodInfoPtr_Idle_Private_BehaviourTreeNodeAuthoring_0;
    private static readonly IntPtr NativeMethodInfoPtr_WalkToDestination_Private_BehaviourTreeNodeAuthoring_0;
    private static readonly IntPtr NativeMethodInfoPtr_TeleportToDestination_Private_BehaviourTreeNodeAuthoring_0;
    private static readonly IntPtr NativeMethodInfoPtr_Combat_Private_BehaviourTreeNodeAuthoring_0;
    private static readonly IntPtr NativeMethodInfoPtr_CombatTransitionCheck_Private_BehaviourTreeNodeAuthoring_0;
    private static readonly IntPtr NativeMethodInfoPtr_HealthRegAndDecay_Internal_Static_BehaviourTreeNodeAuthoring_Single_Single_Single_0;
    private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1327008, XrefRangeEnd = 1327065, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe BehaviourTreeNodeAuthoring BuildTree(
      GameObjectConversionSystem conversionSystem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conversionSystem);
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CombatServantBehaviourComponent.NativeMethodInfoPtr_BuildTree_Protected_Virtual_BehaviourTreeNodeAuthoring_GameObjectConversionSystem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (BehaviourTreeNodeAuthoring) null : new BehaviourTreeNodeAuthoring(pointer);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1327089, RefRangeEnd = 1327090, XrefRangeStart = 1327065, XrefRangeEnd = 1327089, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BehaviourTreeNodeAuthoring Initialize()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(CombatServantBehaviourComponent.NativeMethodInfoPtr_Initialize_Private_BehaviourTreeNodeAuthoring_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (BehaviourTreeNodeAuthoring) null : new BehaviourTreeNodeAuthoring(pointer);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1327174, RefRangeEnd = 1327175, XrefRangeStart = 1327090, XrefRangeEnd = 1327174, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BehaviourTreeNodeAuthoring Idle()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(CombatServantBehaviourComponent.NativeMethodInfoPtr_Idle_Private_BehaviourTreeNodeAuthoring_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (BehaviourTreeNodeAuthoring) null : new BehaviourTreeNodeAuthoring(pointer);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1327312, RefRangeEnd = 1327313, XrefRangeStart = 1327175, XrefRangeEnd = 1327312, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BehaviourTreeNodeAuthoring WalkToDestination()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(CombatServantBehaviourComponent.NativeMethodInfoPtr_WalkToDestination_Private_BehaviourTreeNodeAuthoring_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (BehaviourTreeNodeAuthoring) null : new BehaviourTreeNodeAuthoring(pointer);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1327353, RefRangeEnd = 1327354, XrefRangeStart = 1327313, XrefRangeEnd = 1327353, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BehaviourTreeNodeAuthoring TeleportToDestination()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(CombatServantBehaviourComponent.NativeMethodInfoPtr_TeleportToDestination_Private_BehaviourTreeNodeAuthoring_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (BehaviourTreeNodeAuthoring) null : new BehaviourTreeNodeAuthoring(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1327354, XrefRangeEnd = 1327373, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BehaviourTreeNodeAuthoring Combat()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(CombatServantBehaviourComponent.NativeMethodInfoPtr_Combat_Private_BehaviourTreeNodeAuthoring_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (BehaviourTreeNodeAuthoring) null : new BehaviourTreeNodeAuthoring(pointer);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1327423, RefRangeEnd = 1327425, XrefRangeStart = 1327373, XrefRangeEnd = 1327423, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BehaviourTreeNodeAuthoring CombatTransitionCheck()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(CombatServantBehaviourComponent.NativeMethodInfoPtr_CombatTransitionCheck_Private_BehaviourTreeNodeAuthoring_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (BehaviourTreeNodeAuthoring) null : new BehaviourTreeNodeAuthoring(pointer);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 1327489, RefRangeEnd = 1327493, XrefRangeStart = 1327425, XrefRangeEnd = 1327489, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe BehaviourTreeNodeAuthoring HealthRegAndDecay(
      float healthFrequency,
      float decayFrequency,
      float decayDamagePercentage)
    {
      IntPtr* numPtr = stackalloc IntPtr[3];
      numPtr[0] = (IntPtr) &healthFrequency;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &decayFrequency;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &decayDamagePercentage;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(CombatServantBehaviourComponent.NativeMethodInfoPtr_HealthRegAndDecay_Internal_Static_BehaviourTreeNodeAuthoring_Single_Single_Single_0, IntPtr.Zero, (void**) numPtr, ref exc);
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
      IL2CPP.il2cpp_runtime_invoke(CombatServantBehaviourComponent.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1327493, XrefRangeEnd = 1327494, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CombatServantBehaviourComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CombatServantBehaviourComponent>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CombatServantBehaviourComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static CombatServantBehaviourComponent()
    {
      Il2CppClassPointerStore<CombatServantBehaviourComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Behaviours.dll", "ProjectM", nameof (CombatServantBehaviourComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CombatServantBehaviourComponent>.NativeClassPtr);
      CombatServantBehaviourComponent.NativeFieldInfoPtr_GenericEnemyBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatServantBehaviourComponent>.NativeClassPtr, nameof (GenericEnemyBehaviour));
      CombatServantBehaviourComponent.NativeFieldInfoPtr_CastOptionsOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatServantBehaviourComponent>.NativeClassPtr, nameof (CastOptionsOverride));
      CombatServantBehaviourComponent.NativeFieldInfoPtr_DecayDamagePercentage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatServantBehaviourComponent>.NativeClassPtr, nameof (DecayDamagePercentage));
      CombatServantBehaviourComponent.NativeFieldInfoPtr_DecayDamageFrequency = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatServantBehaviourComponent>.NativeClassPtr, nameof (DecayDamageFrequency));
      CombatServantBehaviourComponent.NativeFieldInfoPtr_MIN_DESTINATION_WAIT_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatServantBehaviourComponent>.NativeClassPtr, nameof (MIN_DESTINATION_WAIT_TIME));
      CombatServantBehaviourComponent.NativeFieldInfoPtr_MAX_DESTINATION_WAIT_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatServantBehaviourComponent>.NativeClassPtr, nameof (MAX_DESTINATION_WAIT_TIME));
      CombatServantBehaviourComponent.NativeMethodInfoPtr_BuildTree_Protected_Virtual_BehaviourTreeNodeAuthoring_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatServantBehaviourComponent>.NativeClassPtr, 100663703);
      CombatServantBehaviourComponent.NativeMethodInfoPtr_Initialize_Private_BehaviourTreeNodeAuthoring_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatServantBehaviourComponent>.NativeClassPtr, 100663704);
      CombatServantBehaviourComponent.NativeMethodInfoPtr_Idle_Private_BehaviourTreeNodeAuthoring_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatServantBehaviourComponent>.NativeClassPtr, 100663705);
      CombatServantBehaviourComponent.NativeMethodInfoPtr_WalkToDestination_Private_BehaviourTreeNodeAuthoring_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatServantBehaviourComponent>.NativeClassPtr, 100663706);
      CombatServantBehaviourComponent.NativeMethodInfoPtr_TeleportToDestination_Private_BehaviourTreeNodeAuthoring_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatServantBehaviourComponent>.NativeClassPtr, 100663707);
      CombatServantBehaviourComponent.NativeMethodInfoPtr_Combat_Private_BehaviourTreeNodeAuthoring_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatServantBehaviourComponent>.NativeClassPtr, 100663708);
      CombatServantBehaviourComponent.NativeMethodInfoPtr_CombatTransitionCheck_Private_BehaviourTreeNodeAuthoring_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatServantBehaviourComponent>.NativeClassPtr, 100663709);
      CombatServantBehaviourComponent.NativeMethodInfoPtr_HealthRegAndDecay_Internal_Static_BehaviourTreeNodeAuthoring_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatServantBehaviourComponent>.NativeClassPtr, 100663710);
      CombatServantBehaviourComponent.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatServantBehaviourComponent>.NativeClassPtr, 100663711);
      CombatServantBehaviourComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatServantBehaviourComponent>.NativeClassPtr, 100663712);
    }

    public CombatServantBehaviourComponent(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe GenericEnemyBehaviourComponent GenericEnemyBehaviour
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatServantBehaviourComponent.NativeFieldInfoPtr_GenericEnemyBehaviour));
        return pointer == IntPtr.Zero ? (GenericEnemyBehaviourComponent) null : new GenericEnemyBehaviourComponent(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CombatServantBehaviourComponent.NativeFieldInfoPtr_GenericEnemyBehaviour), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe PrefabGuidComponent CastOptionsOverride
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatServantBehaviourComponent.NativeFieldInfoPtr_CastOptionsOverride));
        return pointer == IntPtr.Zero ? (PrefabGuidComponent) null : new PrefabGuidComponent(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CombatServantBehaviourComponent.NativeFieldInfoPtr_CastOptionsOverride), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float DecayDamagePercentage
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatServantBehaviourComponent.NativeFieldInfoPtr_DecayDamagePercentage));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatServantBehaviourComponent.NativeFieldInfoPtr_DecayDamagePercentage)) = value;
      }
    }

    public unsafe float DecayDamageFrequency
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatServantBehaviourComponent.NativeFieldInfoPtr_DecayDamageFrequency));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatServantBehaviourComponent.NativeFieldInfoPtr_DecayDamageFrequency)) = value;
      }
    }

    public static unsafe float MIN_DESTINATION_WAIT_TIME
    {
      get
      {
        float destinationWaitTime;
        IL2CPP.il2cpp_field_static_get_value(CombatServantBehaviourComponent.NativeFieldInfoPtr_MIN_DESTINATION_WAIT_TIME, (void*) &destinationWaitTime);
        return destinationWaitTime;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CombatServantBehaviourComponent.NativeFieldInfoPtr_MIN_DESTINATION_WAIT_TIME, (void*) &value);
      }
    }

    public static unsafe float MAX_DESTINATION_WAIT_TIME
    {
      get
      {
        float destinationWaitTime;
        IL2CPP.il2cpp_field_static_get_value(CombatServantBehaviourComponent.NativeFieldInfoPtr_MAX_DESTINATION_WAIT_TIME, (void*) &destinationWaitTime);
        return destinationWaitTime;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CombatServantBehaviourComponent.NativeFieldInfoPtr_MAX_DESTINATION_WAIT_TIME, (void*) &value);
      }
    }
  }
}
