// Decompiled with JetBrains decompiler
// Type: ProjectM.VillagerBehaviourComponent
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
  public class VillagerBehaviourComponent : BehaviourTreeComponent
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ReturnRange;
    private static readonly System.IntPtr NativeFieldInfoPtr_CoverTimeBeforeFlee;
    private static readonly System.IntPtr NativeFieldInfoPtr_FleeOrReturnRange;
    private static readonly System.IntPtr NativeFieldInfoPtr_FleeData;
    private static readonly System.IntPtr NativeFieldInfoPtr_RegenerateHealthPercentage;
    private static readonly System.IntPtr NativeFieldInfoPtr_RegenerateHealthFrequency;
    private static readonly System.IntPtr NativeFieldInfoPtr_MinCoverTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxCoverTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxWanderDistanceFromHome;
    private static readonly System.IntPtr NativeFieldInfoPtr_MinIdleChillTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxIdleChillTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_CastOptionsPrefab;
    private static readonly System.IntPtr NativeMethodInfoPtr_BuildTree_Protected_Virtual_BehaviourTreeNodeAuthoring_GameObjectConversionSystem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Private_BehaviourTreeNodeAuthoring_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Idle_Private_BehaviourTreeNodeAuthoring_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Combat_Private_BehaviourTreeNodeAuthoring_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryTransitionToFlee_Private_BehaviourTreeNodeAuthoring_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Return_Private_BehaviourTreeNodeAuthoring_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Flee_Private_BehaviourTreeNodeAuthoring_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Cover_Private_BehaviourTreeNodeAuthoring_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1329194, XrefRangeEnd = 1329256, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe BehaviourTreeNodeAuthoring BuildTree(
      GameObjectConversionSystem conversionSystem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conversionSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), VillagerBehaviourComponent.NativeMethodInfoPtr_BuildTree_Protected_Virtual_BehaviourTreeNodeAuthoring_GameObjectConversionSystem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (BehaviourTreeNodeAuthoring) null : new BehaviourTreeNodeAuthoring(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1329256, XrefRangeEnd = 1329280, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BehaviourTreeNodeAuthoring Initialize()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(VillagerBehaviourComponent.NativeMethodInfoPtr_Initialize_Private_BehaviourTreeNodeAuthoring_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (BehaviourTreeNodeAuthoring) null : new BehaviourTreeNodeAuthoring(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1329280, XrefRangeEnd = 1329281, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BehaviourTreeNodeAuthoring Idle()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(VillagerBehaviourComponent.NativeMethodInfoPtr_Idle_Private_BehaviourTreeNodeAuthoring_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (BehaviourTreeNodeAuthoring) null : new BehaviourTreeNodeAuthoring(pointer);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1329346, RefRangeEnd = 1329347, XrefRangeStart = 1329281, XrefRangeEnd = 1329346, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BehaviourTreeNodeAuthoring Combat()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(VillagerBehaviourComponent.NativeMethodInfoPtr_Combat_Private_BehaviourTreeNodeAuthoring_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (BehaviourTreeNodeAuthoring) null : new BehaviourTreeNodeAuthoring(pointer);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 1329406, RefRangeEnd = 1329410, XrefRangeStart = 1329347, XrefRangeEnd = 1329406, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BehaviourTreeNodeAuthoring TryTransitionToFlee()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(VillagerBehaviourComponent.NativeMethodInfoPtr_TryTransitionToFlee_Private_BehaviourTreeNodeAuthoring_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (BehaviourTreeNodeAuthoring) null : new BehaviourTreeNodeAuthoring(pointer);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1329528, RefRangeEnd = 1329529, XrefRangeStart = 1329410, XrefRangeEnd = 1329528, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BehaviourTreeNodeAuthoring Return()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(VillagerBehaviourComponent.NativeMethodInfoPtr_Return_Private_BehaviourTreeNodeAuthoring_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (BehaviourTreeNodeAuthoring) null : new BehaviourTreeNodeAuthoring(pointer);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1329665, RefRangeEnd = 1329666, XrefRangeStart = 1329529, XrefRangeEnd = 1329665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BehaviourTreeNodeAuthoring Flee()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(VillagerBehaviourComponent.NativeMethodInfoPtr_Flee_Private_BehaviourTreeNodeAuthoring_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (BehaviourTreeNodeAuthoring) null : new BehaviourTreeNodeAuthoring(pointer);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1329899, RefRangeEnd = 1329900, XrefRangeStart = 1329666, XrefRangeEnd = 1329899, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BehaviourTreeNodeAuthoring Cover()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(VillagerBehaviourComponent.NativeMethodInfoPtr_Cover_Private_BehaviourTreeNodeAuthoring_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (BehaviourTreeNodeAuthoring) null : new BehaviourTreeNodeAuthoring(pointer);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Start()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VillagerBehaviourComponent.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1329900, XrefRangeEnd = 1329901, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe VillagerBehaviourComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VillagerBehaviourComponent>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VillagerBehaviourComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static VillagerBehaviourComponent()
    {
      Il2CppClassPointerStore<VillagerBehaviourComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Behaviours.dll", "ProjectM", nameof (VillagerBehaviourComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VillagerBehaviourComponent>.NativeClassPtr);
      VillagerBehaviourComponent.NativeFieldInfoPtr_ReturnRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VillagerBehaviourComponent>.NativeClassPtr, nameof (ReturnRange));
      VillagerBehaviourComponent.NativeFieldInfoPtr_CoverTimeBeforeFlee = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VillagerBehaviourComponent>.NativeClassPtr, nameof (CoverTimeBeforeFlee));
      VillagerBehaviourComponent.NativeFieldInfoPtr_FleeOrReturnRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VillagerBehaviourComponent>.NativeClassPtr, nameof (FleeOrReturnRange));
      VillagerBehaviourComponent.NativeFieldInfoPtr_FleeData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VillagerBehaviourComponent>.NativeClassPtr, nameof (FleeData));
      VillagerBehaviourComponent.NativeFieldInfoPtr_RegenerateHealthPercentage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VillagerBehaviourComponent>.NativeClassPtr, nameof (RegenerateHealthPercentage));
      VillagerBehaviourComponent.NativeFieldInfoPtr_RegenerateHealthFrequency = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VillagerBehaviourComponent>.NativeClassPtr, nameof (RegenerateHealthFrequency));
      VillagerBehaviourComponent.NativeFieldInfoPtr_MinCoverTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VillagerBehaviourComponent>.NativeClassPtr, nameof (MinCoverTime));
      VillagerBehaviourComponent.NativeFieldInfoPtr_MaxCoverTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VillagerBehaviourComponent>.NativeClassPtr, nameof (MaxCoverTime));
      VillagerBehaviourComponent.NativeFieldInfoPtr_MaxWanderDistanceFromHome = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VillagerBehaviourComponent>.NativeClassPtr, nameof (MaxWanderDistanceFromHome));
      VillagerBehaviourComponent.NativeFieldInfoPtr_MinIdleChillTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VillagerBehaviourComponent>.NativeClassPtr, nameof (MinIdleChillTime));
      VillagerBehaviourComponent.NativeFieldInfoPtr_MaxIdleChillTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VillagerBehaviourComponent>.NativeClassPtr, nameof (MaxIdleChillTime));
      VillagerBehaviourComponent.NativeFieldInfoPtr_CastOptionsPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VillagerBehaviourComponent>.NativeClassPtr, nameof (CastOptionsPrefab));
      VillagerBehaviourComponent.NativeMethodInfoPtr_BuildTree_Protected_Virtual_BehaviourTreeNodeAuthoring_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VillagerBehaviourComponent>.NativeClassPtr, 100663756);
      VillagerBehaviourComponent.NativeMethodInfoPtr_Initialize_Private_BehaviourTreeNodeAuthoring_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VillagerBehaviourComponent>.NativeClassPtr, 100663757);
      VillagerBehaviourComponent.NativeMethodInfoPtr_Idle_Private_BehaviourTreeNodeAuthoring_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VillagerBehaviourComponent>.NativeClassPtr, 100663758);
      VillagerBehaviourComponent.NativeMethodInfoPtr_Combat_Private_BehaviourTreeNodeAuthoring_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VillagerBehaviourComponent>.NativeClassPtr, 100663759);
      VillagerBehaviourComponent.NativeMethodInfoPtr_TryTransitionToFlee_Private_BehaviourTreeNodeAuthoring_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VillagerBehaviourComponent>.NativeClassPtr, 100663760);
      VillagerBehaviourComponent.NativeMethodInfoPtr_Return_Private_BehaviourTreeNodeAuthoring_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VillagerBehaviourComponent>.NativeClassPtr, 100663761);
      VillagerBehaviourComponent.NativeMethodInfoPtr_Flee_Private_BehaviourTreeNodeAuthoring_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VillagerBehaviourComponent>.NativeClassPtr, 100663762);
      VillagerBehaviourComponent.NativeMethodInfoPtr_Cover_Private_BehaviourTreeNodeAuthoring_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VillagerBehaviourComponent>.NativeClassPtr, 100663763);
      VillagerBehaviourComponent.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VillagerBehaviourComponent>.NativeClassPtr, 100663764);
      VillagerBehaviourComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VillagerBehaviourComponent>.NativeClassPtr, 100663765);
    }

    public VillagerBehaviourComponent(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe float ReturnRange
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VillagerBehaviourComponent.NativeFieldInfoPtr_ReturnRange));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VillagerBehaviourComponent.NativeFieldInfoPtr_ReturnRange)) = value;
      }
    }

    public unsafe float CoverTimeBeforeFlee
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VillagerBehaviourComponent.NativeFieldInfoPtr_CoverTimeBeforeFlee));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VillagerBehaviourComponent.NativeFieldInfoPtr_CoverTimeBeforeFlee)) = value;
      }
    }

    public unsafe float FleeOrReturnRange
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VillagerBehaviourComponent.NativeFieldInfoPtr_FleeOrReturnRange));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VillagerBehaviourComponent.NativeFieldInfoPtr_FleeOrReturnRange)) = value;
      }
    }

    public unsafe VillagerBehaviourComponent.FleeVariables FleeData
    {
      get
      {
        return *(VillagerBehaviourComponent.FleeVariables*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VillagerBehaviourComponent.NativeFieldInfoPtr_FleeData));
      }
      [param: In] set
      {
        *(VillagerBehaviourComponent.FleeVariables*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VillagerBehaviourComponent.NativeFieldInfoPtr_FleeData)) = value;
      }
    }

    public unsafe float RegenerateHealthPercentage
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VillagerBehaviourComponent.NativeFieldInfoPtr_RegenerateHealthPercentage));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VillagerBehaviourComponent.NativeFieldInfoPtr_RegenerateHealthPercentage)) = value;
      }
    }

    public unsafe float RegenerateHealthFrequency
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VillagerBehaviourComponent.NativeFieldInfoPtr_RegenerateHealthFrequency));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VillagerBehaviourComponent.NativeFieldInfoPtr_RegenerateHealthFrequency)) = value;
      }
    }

    public unsafe float MinCoverTime
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VillagerBehaviourComponent.NativeFieldInfoPtr_MinCoverTime));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VillagerBehaviourComponent.NativeFieldInfoPtr_MinCoverTime)) = value;
      }
    }

    public unsafe float MaxCoverTime
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VillagerBehaviourComponent.NativeFieldInfoPtr_MaxCoverTime));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VillagerBehaviourComponent.NativeFieldInfoPtr_MaxCoverTime)) = value;
      }
    }

    public unsafe float MaxWanderDistanceFromHome
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VillagerBehaviourComponent.NativeFieldInfoPtr_MaxWanderDistanceFromHome));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VillagerBehaviourComponent.NativeFieldInfoPtr_MaxWanderDistanceFromHome)) = value;
      }
    }

    public unsafe float MinIdleChillTime
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VillagerBehaviourComponent.NativeFieldInfoPtr_MinIdleChillTime));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VillagerBehaviourComponent.NativeFieldInfoPtr_MinIdleChillTime)) = value;
      }
    }

    public unsafe float MaxIdleChillTime
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VillagerBehaviourComponent.NativeFieldInfoPtr_MaxIdleChillTime));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VillagerBehaviourComponent.NativeFieldInfoPtr_MaxIdleChillTime)) = value;
      }
    }

    public unsafe PrefabGuidComponent CastOptionsPrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VillagerBehaviourComponent.NativeFieldInfoPtr_CastOptionsPrefab));
        return pointer == System.IntPtr.Zero ? (PrefabGuidComponent) null : new PrefabGuidComponent(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VillagerBehaviourComponent.NativeFieldInfoPtr_CastOptionsPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [Serializable]
    [StructLayout(LayoutKind.Explicit)]
    public struct FleeVariables
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_FleeImmediately;
      private static readonly System.IntPtr NativeFieldInfoPtr_MinFleeDistanceFromTarget;
      private static readonly System.IntPtr NativeFieldInfoPtr_MaxFleeDistanceFromTarget;
      private static readonly System.IntPtr NativeFieldInfoPtr_MinFleeReturnTime;
      private static readonly System.IntPtr NativeFieldInfoPtr_MaxFleeReturnTime;
      private static readonly System.IntPtr NativeFieldInfoPtr_FleeCheckEnemyRange;
      [FieldOffset(0)]
      public bool FleeImmediately;
      [FieldOffset(4)]
      public float MinFleeDistanceFromTarget;
      [FieldOffset(8)]
      public float MaxFleeDistanceFromTarget;
      [FieldOffset(12)]
      public float MinFleeReturnTime;
      [FieldOffset(16)]
      public float MaxFleeReturnTime;
      [FieldOffset(20)]
      public float FleeCheckEnemyRange;

      static FleeVariables()
      {
        Il2CppClassPointerStore<VillagerBehaviourComponent.FleeVariables>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VillagerBehaviourComponent>.NativeClassPtr, nameof (FleeVariables));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VillagerBehaviourComponent.FleeVariables>.NativeClassPtr);
        VillagerBehaviourComponent.FleeVariables.NativeFieldInfoPtr_FleeImmediately = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VillagerBehaviourComponent.FleeVariables>.NativeClassPtr, nameof (FleeImmediately));
        VillagerBehaviourComponent.FleeVariables.NativeFieldInfoPtr_MinFleeDistanceFromTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VillagerBehaviourComponent.FleeVariables>.NativeClassPtr, nameof (MinFleeDistanceFromTarget));
        VillagerBehaviourComponent.FleeVariables.NativeFieldInfoPtr_MaxFleeDistanceFromTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VillagerBehaviourComponent.FleeVariables>.NativeClassPtr, nameof (MaxFleeDistanceFromTarget));
        VillagerBehaviourComponent.FleeVariables.NativeFieldInfoPtr_MinFleeReturnTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VillagerBehaviourComponent.FleeVariables>.NativeClassPtr, nameof (MinFleeReturnTime));
        VillagerBehaviourComponent.FleeVariables.NativeFieldInfoPtr_MaxFleeReturnTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VillagerBehaviourComponent.FleeVariables>.NativeClassPtr, nameof (MaxFleeReturnTime));
        VillagerBehaviourComponent.FleeVariables.NativeFieldInfoPtr_FleeCheckEnemyRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VillagerBehaviourComponent.FleeVariables>.NativeClassPtr, nameof (FleeCheckEnemyRange));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VillagerBehaviourComponent.FleeVariables>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
