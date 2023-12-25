// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Script_StormPolarityShift_DataServer
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Runtime;
using ProjectM.Scripting;
using ProjectM.Shared;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Script_StormPolarityShift_DataServer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_SelfTravelSpell;
    private static readonly System.IntPtr NativeFieldInfoPtr_EnemyTravelSpell;
    private static readonly System.IntPtr NativeFieldInfoPtr_AllyTravelSpell;
    private static readonly System.IntPtr NativeFieldInfoPtr_TargetHitFilter;
    private static readonly System.IntPtr NativeFieldInfoPtr_AllyHitFilter;
    private static readonly System.IntPtr NativeFieldInfoPtr_GeneralFilterCondition;
    private static readonly System.IntPtr NativeFieldInfoPtr_TargetFilterCondition;
    private static readonly System.IntPtr NativeFieldInfoPtr_AllyFilterCondition;
    private static readonly System.IntPtr NativeFieldInfoPtr_MinDuration;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxDuration;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxRange;
    private static readonly System.IntPtr NativeFieldInfoPtr_HasHit;
    [FieldOffset(0)]
    public PrefabGUID SelfTravelSpell;
    [FieldOffset(4)]
    public PrefabGUID EnemyTravelSpell;
    [FieldOffset(8)]
    public PrefabGUID AllyTravelSpell;
    [FieldOffset(12)]
    public HitFilter TargetHitFilter;
    [FieldOffset(13)]
    public HitFilter AllyHitFilter;
    [FieldOffset(16)]
    public BlobAssetReference<ConditionBlob> GeneralFilterCondition;
    [FieldOffset(24)]
    public BlobAssetReference<ConditionBlob> TargetFilterCondition;
    [FieldOffset(32)]
    public BlobAssetReference<ConditionBlob> AllyFilterCondition;
    [FieldOffset(40)]
    public float MinDuration;
    [FieldOffset(44)]
    public float MaxDuration;
    [FieldOffset(48)]
    public float MaxRange;
    [FieldOffset(52)]
    public bool HasHit;

    static Script_StormPolarityShift_DataServer()
    {
      Il2CppClassPointerStore<Script_StormPolarityShift_DataServer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (Script_StormPolarityShift_DataServer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_StormPolarityShift_DataServer>.NativeClassPtr);
      Script_StormPolarityShift_DataServer.NativeFieldInfoPtr_SelfTravelSpell = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_StormPolarityShift_DataServer>.NativeClassPtr, nameof (SelfTravelSpell));
      Script_StormPolarityShift_DataServer.NativeFieldInfoPtr_EnemyTravelSpell = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_StormPolarityShift_DataServer>.NativeClassPtr, nameof (EnemyTravelSpell));
      Script_StormPolarityShift_DataServer.NativeFieldInfoPtr_AllyTravelSpell = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_StormPolarityShift_DataServer>.NativeClassPtr, nameof (AllyTravelSpell));
      Script_StormPolarityShift_DataServer.NativeFieldInfoPtr_TargetHitFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_StormPolarityShift_DataServer>.NativeClassPtr, nameof (TargetHitFilter));
      Script_StormPolarityShift_DataServer.NativeFieldInfoPtr_AllyHitFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_StormPolarityShift_DataServer>.NativeClassPtr, nameof (AllyHitFilter));
      Script_StormPolarityShift_DataServer.NativeFieldInfoPtr_GeneralFilterCondition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_StormPolarityShift_DataServer>.NativeClassPtr, nameof (GeneralFilterCondition));
      Script_StormPolarityShift_DataServer.NativeFieldInfoPtr_TargetFilterCondition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_StormPolarityShift_DataServer>.NativeClassPtr, nameof (TargetFilterCondition));
      Script_StormPolarityShift_DataServer.NativeFieldInfoPtr_AllyFilterCondition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_StormPolarityShift_DataServer>.NativeClassPtr, nameof (AllyFilterCondition));
      Script_StormPolarityShift_DataServer.NativeFieldInfoPtr_MinDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_StormPolarityShift_DataServer>.NativeClassPtr, nameof (MinDuration));
      Script_StormPolarityShift_DataServer.NativeFieldInfoPtr_MaxDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_StormPolarityShift_DataServer>.NativeClassPtr, nameof (MaxDuration));
      Script_StormPolarityShift_DataServer.NativeFieldInfoPtr_MaxRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_StormPolarityShift_DataServer>.NativeClassPtr, nameof (MaxRange));
      Script_StormPolarityShift_DataServer.NativeFieldInfoPtr_HasHit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_StormPolarityShift_DataServer>.NativeClassPtr, nameof (HasHit));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Script_StormPolarityShift_DataServer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
