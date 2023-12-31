// Decompiled with JetBrains decompiler
// Type: ProjectM.Script_HomingSpell_DataShared
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using Il2CppSystem;
using System.Runtime.InteropServices;
using Unity.Mathematics;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Script_HomingSpell_DataShared
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_SyncPosition;
    private static readonly System.IntPtr NativeFieldInfoPtr_SyncRotation;
    private static readonly System.IntPtr NativeFieldInfoPtr_SyncAge;
    private static readonly System.IntPtr NativeFieldInfoPtr_DistanceBasedData;
    private static readonly System.IntPtr NativeFieldInfoPtr_PreHomingSpeedData;
    private static readonly System.IntPtr NativeFieldInfoPtr_PreHomingRangeData;
    private static readonly System.IntPtr NativeFieldInfoPtr_HomingData;
    private static readonly System.IntPtr NativeFieldInfoPtr_PreHomingMode;
    private static readonly System.IntPtr NativeFieldInfoPtr_Type;
    private static readonly System.IntPtr NativeFieldInfoPtr_Rotation;
    private static readonly System.IntPtr NativeFieldInfoPtr_PreHomingDuration;
    private static readonly System.IntPtr NativeFieldInfoPtr_PreHomingWait;
    private static readonly System.IntPtr NativeFieldInfoPtr_InitialHeight;
    private static readonly System.IntPtr NativeFieldInfoPtr_HomingInitiated;
    private static readonly System.IntPtr NativeFieldInfoPtr_ResetHitTriggersOnChangeHomingMode;
    private static readonly System.IntPtr NativeFieldInfoPtr_TriggerHitBeforeReturning;
    [FieldOffset(0)]
    public float3 SyncPosition;
    [FieldOffset(12)]
    public Quaternion SyncRotation;
    [FieldOffset(28)]
    public float SyncAge;
    [FieldOffset(32)]
    public Homing_DistanceBasedData DistanceBasedData;
    [FieldOffset(40)]
    public Homing_SpeedLerpData PreHomingSpeedData;
    [FieldOffset(56)]
    public Homing_RangeLerpData PreHomingRangeData;
    [FieldOffset(104)]
    public Homing_LerpData HomingData;
    [FieldOffset(140)]
    public Script_HomingSpell_DataShared.PreHomingModeType PreHomingMode;
    [FieldOffset(144)]
    public Script_HomingSpell_DataShared.HomingSpellType Type;
    [FieldOffset(148)]
    public Nullable_Unboxed<quaternion> Rotation;
    [FieldOffset(168)]
    public float PreHomingDuration;
    [FieldOffset(172)]
    public float PreHomingWait;
    [FieldOffset(176)]
    public float InitialHeight;
    [FieldOffset(180)]
    public bool HomingInitiated;
    [FieldOffset(181)]
    public bool ResetHitTriggersOnChangeHomingMode;
    [FieldOffset(182)]
    public bool TriggerHitBeforeReturning;

    static Script_HomingSpell_DataShared()
    {
      Il2CppClassPointerStore<Script_HomingSpell_DataShared>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (Script_HomingSpell_DataShared));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_HomingSpell_DataShared>.NativeClassPtr);
      Script_HomingSpell_DataShared.NativeFieldInfoPtr_SyncPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_HomingSpell_DataShared>.NativeClassPtr, nameof (SyncPosition));
      Script_HomingSpell_DataShared.NativeFieldInfoPtr_SyncRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_HomingSpell_DataShared>.NativeClassPtr, nameof (SyncRotation));
      Script_HomingSpell_DataShared.NativeFieldInfoPtr_SyncAge = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_HomingSpell_DataShared>.NativeClassPtr, nameof (SyncAge));
      Script_HomingSpell_DataShared.NativeFieldInfoPtr_DistanceBasedData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_HomingSpell_DataShared>.NativeClassPtr, nameof (DistanceBasedData));
      Script_HomingSpell_DataShared.NativeFieldInfoPtr_PreHomingSpeedData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_HomingSpell_DataShared>.NativeClassPtr, nameof (PreHomingSpeedData));
      Script_HomingSpell_DataShared.NativeFieldInfoPtr_PreHomingRangeData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_HomingSpell_DataShared>.NativeClassPtr, nameof (PreHomingRangeData));
      Script_HomingSpell_DataShared.NativeFieldInfoPtr_HomingData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_HomingSpell_DataShared>.NativeClassPtr, nameof (HomingData));
      Script_HomingSpell_DataShared.NativeFieldInfoPtr_PreHomingMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_HomingSpell_DataShared>.NativeClassPtr, nameof (PreHomingMode));
      Script_HomingSpell_DataShared.NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_HomingSpell_DataShared>.NativeClassPtr, nameof (Type));
      Script_HomingSpell_DataShared.NativeFieldInfoPtr_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_HomingSpell_DataShared>.NativeClassPtr, nameof (Rotation));
      Script_HomingSpell_DataShared.NativeFieldInfoPtr_PreHomingDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_HomingSpell_DataShared>.NativeClassPtr, nameof (PreHomingDuration));
      Script_HomingSpell_DataShared.NativeFieldInfoPtr_PreHomingWait = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_HomingSpell_DataShared>.NativeClassPtr, nameof (PreHomingWait));
      Script_HomingSpell_DataShared.NativeFieldInfoPtr_InitialHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_HomingSpell_DataShared>.NativeClassPtr, nameof (InitialHeight));
      Script_HomingSpell_DataShared.NativeFieldInfoPtr_HomingInitiated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_HomingSpell_DataShared>.NativeClassPtr, nameof (HomingInitiated));
      Script_HomingSpell_DataShared.NativeFieldInfoPtr_ResetHitTriggersOnChangeHomingMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_HomingSpell_DataShared>.NativeClassPtr, nameof (ResetHitTriggersOnChangeHomingMode));
      Script_HomingSpell_DataShared.NativeFieldInfoPtr_TriggerHitBeforeReturning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_HomingSpell_DataShared>.NativeClassPtr, nameof (TriggerHitBeforeReturning));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Script_HomingSpell_DataShared>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public enum PreHomingModeType
    {
      None,
      MoveConstantly,
      MoveToRange,
    }

    public enum HomingSpellType
    {
      LifeTimeBased,
      DistanceBased,
    }
  }
}
