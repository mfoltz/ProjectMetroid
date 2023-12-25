// Decompiled with JetBrains decompiler
// Type: ProjectM.GenericEnemyBehaviourComponent
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
  public class GenericEnemyBehaviourComponent : BehaviourTreeComponent
  {
    private static readonly IntPtr NativeFieldInfoPtr_RegenerateHealthPercentage;
    private static readonly IntPtr NativeFieldInfoPtr_RegenerateHealthFrequency;
    private static readonly IntPtr NativeFieldInfoPtr_MaxWanderDistanceFromHome;
    private static readonly IntPtr NativeFieldInfoPtr_IdleReturnDistance;
    private static readonly IntPtr NativeFieldInfoPtr_MinIdleChillTime;
    private static readonly IntPtr NativeFieldInfoPtr_MaxIdleChillTime;
    private static readonly IntPtr NativeFieldInfoPtr_LeaveCombatDelay_NoAggro;
    private static readonly IntPtr NativeFieldInfoPtr_AlertAllies;
    private static readonly IntPtr NativeFieldInfoPtr_Wallhack;
    private static readonly IntPtr NativeFieldInfoPtr_RelocationSettings;
    private static readonly IntPtr NativeFieldInfoPtr_CastOptionsPrefab;
    private static readonly IntPtr NativeMethodInfoPtr_BuildTree_Protected_Virtual_Final_BehaviourTreeNodeAuthoring_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr_Initialize_Private_BehaviourTreeNodeAuthoring_0;
    private static readonly IntPtr NativeMethodInfoPtr_Idle_Protected_Virtual_New_BehaviourTreeNodeAuthoring_0;
    private static readonly IntPtr NativeMethodInfoPtr_Combat_Private_BehaviourTreeNodeAuthoring_0;
    private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1327886, XrefRangeEnd = 1327924, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe BehaviourTreeNodeAuthoring BuildTree(
      GameObjectConversionSystem conversionSystem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conversionSystem);
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(GenericEnemyBehaviourComponent.NativeMethodInfoPtr_BuildTree_Protected_Virtual_Final_BehaviourTreeNodeAuthoring_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (BehaviourTreeNodeAuthoring) null : new BehaviourTreeNodeAuthoring(pointer);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1327948, RefRangeEnd = 1327949, XrefRangeStart = 1327924, XrefRangeEnd = 1327948, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BehaviourTreeNodeAuthoring Initialize()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(GenericEnemyBehaviourComponent.NativeMethodInfoPtr_Initialize_Private_BehaviourTreeNodeAuthoring_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (BehaviourTreeNodeAuthoring) null : new BehaviourTreeNodeAuthoring(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1327949, XrefRangeEnd = 1327950, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe BehaviourTreeNodeAuthoring Idle()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), GenericEnemyBehaviourComponent.NativeMethodInfoPtr_Idle_Protected_Virtual_New_BehaviourTreeNodeAuthoring_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (BehaviourTreeNodeAuthoring) null : new BehaviourTreeNodeAuthoring(pointer);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1327969, RefRangeEnd = 1327970, XrefRangeStart = 1327950, XrefRangeEnd = 1327969, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BehaviourTreeNodeAuthoring Combat()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(GenericEnemyBehaviourComponent.NativeMethodInfoPtr_Combat_Private_BehaviourTreeNodeAuthoring_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
      IL2CPP.il2cpp_runtime_invoke(GenericEnemyBehaviourComponent.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1327973, RefRangeEnd = 1327974, XrefRangeStart = 1327970, XrefRangeEnd = 1327973, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe GenericEnemyBehaviourComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenericEnemyBehaviourComponent>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GenericEnemyBehaviourComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static GenericEnemyBehaviourComponent()
    {
      Il2CppClassPointerStore<GenericEnemyBehaviourComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Behaviours.dll", "ProjectM", nameof (GenericEnemyBehaviourComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenericEnemyBehaviourComponent>.NativeClassPtr);
      GenericEnemyBehaviourComponent.NativeFieldInfoPtr_RegenerateHealthPercentage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericEnemyBehaviourComponent>.NativeClassPtr, nameof (RegenerateHealthPercentage));
      GenericEnemyBehaviourComponent.NativeFieldInfoPtr_RegenerateHealthFrequency = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericEnemyBehaviourComponent>.NativeClassPtr, nameof (RegenerateHealthFrequency));
      GenericEnemyBehaviourComponent.NativeFieldInfoPtr_MaxWanderDistanceFromHome = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericEnemyBehaviourComponent>.NativeClassPtr, nameof (MaxWanderDistanceFromHome));
      GenericEnemyBehaviourComponent.NativeFieldInfoPtr_IdleReturnDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericEnemyBehaviourComponent>.NativeClassPtr, nameof (IdleReturnDistance));
      GenericEnemyBehaviourComponent.NativeFieldInfoPtr_MinIdleChillTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericEnemyBehaviourComponent>.NativeClassPtr, nameof (MinIdleChillTime));
      GenericEnemyBehaviourComponent.NativeFieldInfoPtr_MaxIdleChillTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericEnemyBehaviourComponent>.NativeClassPtr, nameof (MaxIdleChillTime));
      GenericEnemyBehaviourComponent.NativeFieldInfoPtr_LeaveCombatDelay_NoAggro = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericEnemyBehaviourComponent>.NativeClassPtr, nameof (LeaveCombatDelay_NoAggro));
      GenericEnemyBehaviourComponent.NativeFieldInfoPtr_AlertAllies = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericEnemyBehaviourComponent>.NativeClassPtr, nameof (AlertAllies));
      GenericEnemyBehaviourComponent.NativeFieldInfoPtr_Wallhack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericEnemyBehaviourComponent>.NativeClassPtr, nameof (Wallhack));
      GenericEnemyBehaviourComponent.NativeFieldInfoPtr_RelocationSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericEnemyBehaviourComponent>.NativeClassPtr, nameof (RelocationSettings));
      GenericEnemyBehaviourComponent.NativeFieldInfoPtr_CastOptionsPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericEnemyBehaviourComponent>.NativeClassPtr, nameof (CastOptionsPrefab));
      GenericEnemyBehaviourComponent.NativeMethodInfoPtr_BuildTree_Protected_Virtual_Final_BehaviourTreeNodeAuthoring_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericEnemyBehaviourComponent>.NativeClassPtr, 100663721);
      GenericEnemyBehaviourComponent.NativeMethodInfoPtr_Initialize_Private_BehaviourTreeNodeAuthoring_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericEnemyBehaviourComponent>.NativeClassPtr, 100663722);
      GenericEnemyBehaviourComponent.NativeMethodInfoPtr_Idle_Protected_Virtual_New_BehaviourTreeNodeAuthoring_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericEnemyBehaviourComponent>.NativeClassPtr, 100663723);
      GenericEnemyBehaviourComponent.NativeMethodInfoPtr_Combat_Private_BehaviourTreeNodeAuthoring_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericEnemyBehaviourComponent>.NativeClassPtr, 100663724);
      GenericEnemyBehaviourComponent.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericEnemyBehaviourComponent>.NativeClassPtr, 100663725);
      GenericEnemyBehaviourComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericEnemyBehaviourComponent>.NativeClassPtr, 100663726);
    }

    public GenericEnemyBehaviourComponent(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe float RegenerateHealthPercentage
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GenericEnemyBehaviourComponent.NativeFieldInfoPtr_RegenerateHealthPercentage));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GenericEnemyBehaviourComponent.NativeFieldInfoPtr_RegenerateHealthPercentage)) = value;
      }
    }

    public unsafe float RegenerateHealthFrequency
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GenericEnemyBehaviourComponent.NativeFieldInfoPtr_RegenerateHealthFrequency));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GenericEnemyBehaviourComponent.NativeFieldInfoPtr_RegenerateHealthFrequency)) = value;
      }
    }

    public unsafe float MaxWanderDistanceFromHome
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GenericEnemyBehaviourComponent.NativeFieldInfoPtr_MaxWanderDistanceFromHome));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GenericEnemyBehaviourComponent.NativeFieldInfoPtr_MaxWanderDistanceFromHome)) = value;
      }
    }

    public unsafe float IdleReturnDistance
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GenericEnemyBehaviourComponent.NativeFieldInfoPtr_IdleReturnDistance));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GenericEnemyBehaviourComponent.NativeFieldInfoPtr_IdleReturnDistance)) = value;
      }
    }

    public unsafe float MinIdleChillTime
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GenericEnemyBehaviourComponent.NativeFieldInfoPtr_MinIdleChillTime));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GenericEnemyBehaviourComponent.NativeFieldInfoPtr_MinIdleChillTime)) = value;
      }
    }

    public unsafe float MaxIdleChillTime
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GenericEnemyBehaviourComponent.NativeFieldInfoPtr_MaxIdleChillTime));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GenericEnemyBehaviourComponent.NativeFieldInfoPtr_MaxIdleChillTime)) = value;
      }
    }

    public unsafe float LeaveCombatDelay_NoAggro
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GenericEnemyBehaviourComponent.NativeFieldInfoPtr_LeaveCombatDelay_NoAggro));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GenericEnemyBehaviourComponent.NativeFieldInfoPtr_LeaveCombatDelay_NoAggro)) = value;
      }
    }

    public unsafe bool AlertAllies
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GenericEnemyBehaviourComponent.NativeFieldInfoPtr_AlertAllies));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GenericEnemyBehaviourComponent.NativeFieldInfoPtr_AlertAllies)) = value;
      }
    }

    public unsafe bool Wallhack
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GenericEnemyBehaviourComponent.NativeFieldInfoPtr_Wallhack));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GenericEnemyBehaviourComponent.NativeFieldInfoPtr_Wallhack)) = value;
      }
    }

    public unsafe RelocationSettingsAsset RelocationSettings
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GenericEnemyBehaviourComponent.NativeFieldInfoPtr_RelocationSettings));
        return pointer == IntPtr.Zero ? (RelocationSettingsAsset) null : new RelocationSettingsAsset(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GenericEnemyBehaviourComponent.NativeFieldInfoPtr_RelocationSettings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe PrefabGuidComponent CastOptionsPrefab
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GenericEnemyBehaviourComponent.NativeFieldInfoPtr_CastOptionsPrefab));
        return pointer == IntPtr.Zero ? (PrefabGuidComponent) null : new PrefabGuidComponent(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GenericEnemyBehaviourComponent.NativeFieldInfoPtr_CastOptionsPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
