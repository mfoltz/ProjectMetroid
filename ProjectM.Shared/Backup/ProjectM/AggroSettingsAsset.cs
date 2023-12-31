// Decompiled with JetBrains decompiler
// Type: ProjectM.AggroSettingsAsset
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class AggroSettingsAsset : ScriptableObject
  {
    private static readonly IntPtr NativeFieldInfoPtr_DamageHistoryStorageTime;
    private static readonly IntPtr NativeFieldInfoPtr_ProximityRadius;
    private static readonly IntPtr NativeFieldInfoPtr_ProximityWeight;
    private static readonly IntPtr NativeFieldInfoPtr_DamageWeight;
    private static readonly IntPtr NativeFieldInfoPtr_RemoveDelay;
    private static readonly IntPtr NativeFieldInfoPtr_TargetSwitchTreshold;
    private static readonly IntPtr NativeFieldInfoPtr_GainAggroByAlert;
    private static readonly IntPtr NativeFieldInfoPtr_GainAggroByAlertThreshold;
    private static readonly IntPtr NativeFieldInfoPtr_AlertDecayPerSecond;
    private static readonly IntPtr NativeFieldInfoPtr_MaxDistanceFromPreCombatPosition;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(11)]
    [CachedScanResults(RefRangeStart = 247159, RefRangeEnd = 247170, XrefRangeStart = 247159, XrefRangeEnd = 247170, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe AggroSettingsAsset()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AggroSettingsAsset>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AggroSettingsAsset.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static AggroSettingsAsset()
    {
      Il2CppClassPointerStore<AggroSettingsAsset>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (AggroSettingsAsset));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AggroSettingsAsset>.NativeClassPtr);
      AggroSettingsAsset.NativeFieldInfoPtr_DamageHistoryStorageTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroSettingsAsset>.NativeClassPtr, nameof (DamageHistoryStorageTime));
      AggroSettingsAsset.NativeFieldInfoPtr_ProximityRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroSettingsAsset>.NativeClassPtr, nameof (ProximityRadius));
      AggroSettingsAsset.NativeFieldInfoPtr_ProximityWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroSettingsAsset>.NativeClassPtr, nameof (ProximityWeight));
      AggroSettingsAsset.NativeFieldInfoPtr_DamageWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroSettingsAsset>.NativeClassPtr, nameof (DamageWeight));
      AggroSettingsAsset.NativeFieldInfoPtr_RemoveDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroSettingsAsset>.NativeClassPtr, nameof (RemoveDelay));
      AggroSettingsAsset.NativeFieldInfoPtr_TargetSwitchTreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroSettingsAsset>.NativeClassPtr, nameof (TargetSwitchTreshold));
      AggroSettingsAsset.NativeFieldInfoPtr_GainAggroByAlert = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroSettingsAsset>.NativeClassPtr, nameof (GainAggroByAlert));
      AggroSettingsAsset.NativeFieldInfoPtr_GainAggroByAlertThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroSettingsAsset>.NativeClassPtr, nameof (GainAggroByAlertThreshold));
      AggroSettingsAsset.NativeFieldInfoPtr_AlertDecayPerSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroSettingsAsset>.NativeClassPtr, nameof (AlertDecayPerSecond));
      AggroSettingsAsset.NativeFieldInfoPtr_MaxDistanceFromPreCombatPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroSettingsAsset>.NativeClassPtr, nameof (MaxDistanceFromPreCombatPosition));
      AggroSettingsAsset.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggroSettingsAsset>.NativeClassPtr, 100663881);
    }

    public AggroSettingsAsset(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe float DamageHistoryStorageTime
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AggroSettingsAsset.NativeFieldInfoPtr_DamageHistoryStorageTime));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AggroSettingsAsset.NativeFieldInfoPtr_DamageHistoryStorageTime)) = value;
      }
    }

    public unsafe float ProximityRadius
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AggroSettingsAsset.NativeFieldInfoPtr_ProximityRadius));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AggroSettingsAsset.NativeFieldInfoPtr_ProximityRadius)) = value;
      }
    }

    public unsafe float ProximityWeight
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AggroSettingsAsset.NativeFieldInfoPtr_ProximityWeight));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AggroSettingsAsset.NativeFieldInfoPtr_ProximityWeight)) = value;
      }
    }

    public unsafe float DamageWeight
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AggroSettingsAsset.NativeFieldInfoPtr_DamageWeight));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AggroSettingsAsset.NativeFieldInfoPtr_DamageWeight)) = value;
      }
    }

    public unsafe float RemoveDelay
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AggroSettingsAsset.NativeFieldInfoPtr_RemoveDelay));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AggroSettingsAsset.NativeFieldInfoPtr_RemoveDelay)) = value;
      }
    }

    public unsafe float TargetSwitchTreshold
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AggroSettingsAsset.NativeFieldInfoPtr_TargetSwitchTreshold));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AggroSettingsAsset.NativeFieldInfoPtr_TargetSwitchTreshold)) = value;
      }
    }

    public unsafe bool GainAggroByAlert
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AggroSettingsAsset.NativeFieldInfoPtr_GainAggroByAlert));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AggroSettingsAsset.NativeFieldInfoPtr_GainAggroByAlert)) = value;
      }
    }

    public unsafe float GainAggroByAlertThreshold
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AggroSettingsAsset.NativeFieldInfoPtr_GainAggroByAlertThreshold));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AggroSettingsAsset.NativeFieldInfoPtr_GainAggroByAlertThreshold)) = value;
      }
    }

    public unsafe float AlertDecayPerSecond
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AggroSettingsAsset.NativeFieldInfoPtr_AlertDecayPerSecond));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AggroSettingsAsset.NativeFieldInfoPtr_AlertDecayPerSecond)) = value;
      }
    }

    public unsafe float MaxDistanceFromPreCombatPosition
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AggroSettingsAsset.NativeFieldInfoPtr_MaxDistanceFromPreCombatPosition));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AggroSettingsAsset.NativeFieldInfoPtr_MaxDistanceFromPreCombatPosition)) = value;
      }
    }
  }
}
