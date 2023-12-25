// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Script_DamageZone_SingleTarget_HitConditions
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Runtime;
using ProjectM.Shared;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Script_DamageZone_SingleTarget_HitConditions
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Timer;
    private static readonly System.IntPtr NativeFieldInfoPtr_Elapsed;
    private static readonly System.IntPtr NativeFieldInfoPtr_Condition;
    private static readonly System.IntPtr NativeFieldInfoPtr_OnTargetHitEventId;
    [FieldOffset(0)]
    public float Timer;
    [FieldOffset(4)]
    public float Elapsed;
    [FieldOffset(8)]
    public BlobAssetReference<ConditionBlob> Condition;
    [FieldOffset(16)]
    public GameplayEventId OnTargetHitEventId;

    static Script_DamageZone_SingleTarget_HitConditions()
    {
      Il2CppClassPointerStore<Script_DamageZone_SingleTarget_HitConditions>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (Script_DamageZone_SingleTarget_HitConditions));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_DamageZone_SingleTarget_HitConditions>.NativeClassPtr);
      Script_DamageZone_SingleTarget_HitConditions.NativeFieldInfoPtr_Timer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_DamageZone_SingleTarget_HitConditions>.NativeClassPtr, nameof (Timer));
      Script_DamageZone_SingleTarget_HitConditions.NativeFieldInfoPtr_Elapsed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_DamageZone_SingleTarget_HitConditions>.NativeClassPtr, nameof (Elapsed));
      Script_DamageZone_SingleTarget_HitConditions.NativeFieldInfoPtr_Condition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_DamageZone_SingleTarget_HitConditions>.NativeClassPtr, nameof (Condition));
      Script_DamageZone_SingleTarget_HitConditions.NativeFieldInfoPtr_OnTargetHitEventId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_DamageZone_SingleTarget_HitConditions>.NativeClassPtr, nameof (OnTargetHitEventId));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Script_DamageZone_SingleTarget_HitConditions>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
