// Decompiled with JetBrains decompiler
// Type: ProjectM.FleeingServantBehaviourComponent
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
  public class FleeingServantBehaviourComponent : BehaviourTreeComponent
  {
    private static readonly IntPtr NativeFieldInfoPtr_GenericFleeingBehaviour;
    private static readonly IntPtr NativeFieldInfoPtr_CastOptionsOverride;
    private static readonly IntPtr NativeFieldInfoPtr_DecayDamagePercentage;
    private static readonly IntPtr NativeFieldInfoPtr_DecayDamageFrequency;
    private static readonly IntPtr NativeFieldInfoPtr_RegenerateHealthPercentage;
    private static readonly IntPtr NativeFieldInfoPtr_RegenerateHealthFrequency;
    private static readonly IntPtr NativeFieldInfoPtr_MIN_DESTINATION_WAIT_TIME;
    private static readonly IntPtr NativeFieldInfoPtr_MAX_DESTINATION_WAIT_TIME;
    private static readonly IntPtr NativeMethodInfoPtr_BuildTree_Protected_Virtual_BehaviourTreeNodeAuthoring_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr_Initialize_Private_BehaviourTreeNodeAuthoring_0;
    private static readonly IntPtr NativeMethodInfoPtr_Idle_Private_BehaviourTreeNodeAuthoring_0;
    private static readonly IntPtr NativeMethodInfoPtr_WalkToDestination_Private_BehaviourTreeNodeAuthoring_0;
    private static readonly IntPtr NativeMethodInfoPtr_TeleportToDestination_Private_BehaviourTreeNodeAuthoring_0;
    private static readonly IntPtr NativeMethodInfoPtr_CombatTransition_Private_BehaviourTreeNodeAuthoring_0;
    private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1327494, XrefRangeEnd = 1327533, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe BehaviourTreeNodeAuthoring BuildTree(
      GameObjectConversionSystem conversionSystem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conversionSystem);
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), FleeingServantBehaviourComponent.NativeMethodInfoPtr_BuildTree_Protected_Virtual_BehaviourTreeNodeAuthoring_GameObjectConversionSystem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (BehaviourTreeNodeAuthoring) null : new BehaviourTreeNodeAuthoring(pointer);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1327557, RefRangeEnd = 1327558, XrefRangeStart = 1327533, XrefRangeEnd = 1327557, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BehaviourTreeNodeAuthoring Initialize()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(FleeingServantBehaviourComponent.NativeMethodInfoPtr_Initialize_Private_BehaviourTreeNodeAuthoring_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (BehaviourTreeNodeAuthoring) null : new BehaviourTreeNodeAuthoring(pointer);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1327650, RefRangeEnd = 1327651, XrefRangeStart = 1327558, XrefRangeEnd = 1327650, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BehaviourTreeNodeAuthoring Idle()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(FleeingServantBehaviourComponent.NativeMethodInfoPtr_Idle_Private_BehaviourTreeNodeAuthoring_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (BehaviourTreeNodeAuthoring) null : new BehaviourTreeNodeAuthoring(pointer);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1327782, RefRangeEnd = 1327783, XrefRangeStart = 1327651, XrefRangeEnd = 1327782, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BehaviourTreeNodeAuthoring WalkToDestination()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(FleeingServantBehaviourComponent.NativeMethodInfoPtr_WalkToDestination_Private_BehaviourTreeNodeAuthoring_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (BehaviourTreeNodeAuthoring) null : new BehaviourTreeNodeAuthoring(pointer);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1327832, RefRangeEnd = 1327833, XrefRangeStart = 1327783, XrefRangeEnd = 1327832, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BehaviourTreeNodeAuthoring TeleportToDestination()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(FleeingServantBehaviourComponent.NativeMethodInfoPtr_TeleportToDestination_Private_BehaviourTreeNodeAuthoring_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (BehaviourTreeNodeAuthoring) null : new BehaviourTreeNodeAuthoring(pointer);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1327883, RefRangeEnd = 1327885, XrefRangeStart = 1327833, XrefRangeEnd = 1327883, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BehaviourTreeNodeAuthoring CombatTransition()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(FleeingServantBehaviourComponent.NativeMethodInfoPtr_CombatTransition_Private_BehaviourTreeNodeAuthoring_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
      IL2CPP.il2cpp_runtime_invoke(FleeingServantBehaviourComponent.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1327885, XrefRangeEnd = 1327886, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe FleeingServantBehaviourComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FleeingServantBehaviourComponent>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(FleeingServantBehaviourComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static FleeingServantBehaviourComponent()
    {
      Il2CppClassPointerStore<FleeingServantBehaviourComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Behaviours.dll", "ProjectM", nameof (FleeingServantBehaviourComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FleeingServantBehaviourComponent>.NativeClassPtr);
      FleeingServantBehaviourComponent.NativeFieldInfoPtr_GenericFleeingBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FleeingServantBehaviourComponent>.NativeClassPtr, nameof (GenericFleeingBehaviour));
      FleeingServantBehaviourComponent.NativeFieldInfoPtr_CastOptionsOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FleeingServantBehaviourComponent>.NativeClassPtr, nameof (CastOptionsOverride));
      FleeingServantBehaviourComponent.NativeFieldInfoPtr_DecayDamagePercentage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FleeingServantBehaviourComponent>.NativeClassPtr, nameof (DecayDamagePercentage));
      FleeingServantBehaviourComponent.NativeFieldInfoPtr_DecayDamageFrequency = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FleeingServantBehaviourComponent>.NativeClassPtr, nameof (DecayDamageFrequency));
      FleeingServantBehaviourComponent.NativeFieldInfoPtr_RegenerateHealthPercentage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FleeingServantBehaviourComponent>.NativeClassPtr, nameof (RegenerateHealthPercentage));
      FleeingServantBehaviourComponent.NativeFieldInfoPtr_RegenerateHealthFrequency = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FleeingServantBehaviourComponent>.NativeClassPtr, nameof (RegenerateHealthFrequency));
      FleeingServantBehaviourComponent.NativeFieldInfoPtr_MIN_DESTINATION_WAIT_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FleeingServantBehaviourComponent>.NativeClassPtr, nameof (MIN_DESTINATION_WAIT_TIME));
      FleeingServantBehaviourComponent.NativeFieldInfoPtr_MAX_DESTINATION_WAIT_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FleeingServantBehaviourComponent>.NativeClassPtr, nameof (MAX_DESTINATION_WAIT_TIME));
      FleeingServantBehaviourComponent.NativeMethodInfoPtr_BuildTree_Protected_Virtual_BehaviourTreeNodeAuthoring_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FleeingServantBehaviourComponent>.NativeClassPtr, 100663713);
      FleeingServantBehaviourComponent.NativeMethodInfoPtr_Initialize_Private_BehaviourTreeNodeAuthoring_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FleeingServantBehaviourComponent>.NativeClassPtr, 100663714);
      FleeingServantBehaviourComponent.NativeMethodInfoPtr_Idle_Private_BehaviourTreeNodeAuthoring_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FleeingServantBehaviourComponent>.NativeClassPtr, 100663715);
      FleeingServantBehaviourComponent.NativeMethodInfoPtr_WalkToDestination_Private_BehaviourTreeNodeAuthoring_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FleeingServantBehaviourComponent>.NativeClassPtr, 100663716);
      FleeingServantBehaviourComponent.NativeMethodInfoPtr_TeleportToDestination_Private_BehaviourTreeNodeAuthoring_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FleeingServantBehaviourComponent>.NativeClassPtr, 100663717);
      FleeingServantBehaviourComponent.NativeMethodInfoPtr_CombatTransition_Private_BehaviourTreeNodeAuthoring_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FleeingServantBehaviourComponent>.NativeClassPtr, 100663718);
      FleeingServantBehaviourComponent.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FleeingServantBehaviourComponent>.NativeClassPtr, 100663719);
      FleeingServantBehaviourComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FleeingServantBehaviourComponent>.NativeClassPtr, 100663720);
    }

    public FleeingServantBehaviourComponent(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe GenericFleeingBehaviourComponent GenericFleeingBehaviour
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FleeingServantBehaviourComponent.NativeFieldInfoPtr_GenericFleeingBehaviour));
        return pointer == IntPtr.Zero ? (GenericFleeingBehaviourComponent) null : new GenericFleeingBehaviourComponent(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FleeingServantBehaviourComponent.NativeFieldInfoPtr_GenericFleeingBehaviour), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe PrefabGuidComponent CastOptionsOverride
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FleeingServantBehaviourComponent.NativeFieldInfoPtr_CastOptionsOverride));
        return pointer == IntPtr.Zero ? (PrefabGuidComponent) null : new PrefabGuidComponent(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FleeingServantBehaviourComponent.NativeFieldInfoPtr_CastOptionsOverride), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float DecayDamagePercentage
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FleeingServantBehaviourComponent.NativeFieldInfoPtr_DecayDamagePercentage));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FleeingServantBehaviourComponent.NativeFieldInfoPtr_DecayDamagePercentage)) = value;
      }
    }

    public unsafe float DecayDamageFrequency
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FleeingServantBehaviourComponent.NativeFieldInfoPtr_DecayDamageFrequency));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FleeingServantBehaviourComponent.NativeFieldInfoPtr_DecayDamageFrequency)) = value;
      }
    }

    public unsafe float RegenerateHealthPercentage
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FleeingServantBehaviourComponent.NativeFieldInfoPtr_RegenerateHealthPercentage));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FleeingServantBehaviourComponent.NativeFieldInfoPtr_RegenerateHealthPercentage)) = value;
      }
    }

    public unsafe float RegenerateHealthFrequency
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FleeingServantBehaviourComponent.NativeFieldInfoPtr_RegenerateHealthFrequency));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FleeingServantBehaviourComponent.NativeFieldInfoPtr_RegenerateHealthFrequency)) = value;
      }
    }

    public static unsafe float MIN_DESTINATION_WAIT_TIME
    {
      get
      {
        float destinationWaitTime;
        IL2CPP.il2cpp_field_static_get_value(FleeingServantBehaviourComponent.NativeFieldInfoPtr_MIN_DESTINATION_WAIT_TIME, (void*) &destinationWaitTime);
        return destinationWaitTime;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(FleeingServantBehaviourComponent.NativeFieldInfoPtr_MIN_DESTINATION_WAIT_TIME, (void*) &value);
      }
    }

    public static unsafe float MAX_DESTINATION_WAIT_TIME
    {
      get
      {
        float destinationWaitTime;
        IL2CPP.il2cpp_field_static_get_value(FleeingServantBehaviourComponent.NativeFieldInfoPtr_MAX_DESTINATION_WAIT_TIME, (void*) &destinationWaitTime);
        return destinationWaitTime;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(FleeingServantBehaviourComponent.NativeFieldInfoPtr_MAX_DESTINATION_WAIT_TIME, (void*) &value);
      }
    }
  }
}
