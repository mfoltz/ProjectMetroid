// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Script_Knockback_Wall_Buff_DataServer
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Script_Knockback_Wall_Buff_DataServer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_LastPosition;
    private static readonly System.IntPtr NativeFieldInfoPtr_HitOffset;
    private static readonly System.IntPtr NativeFieldInfoPtr_BuffDuration;
    private static readonly System.IntPtr NativeFieldInfoPtr_HitRadius;
    private static readonly System.IntPtr NativeFieldInfoPtr_BuffType;
    private static readonly System.IntPtr NativeFieldInfoPtr_TriggerSequence;
    [FieldOffset(0)]
    public float3 LastPosition;
    [FieldOffset(12)]
    public float3 HitOffset;
    [FieldOffset(24)]
    public float BuffDuration;
    [FieldOffset(28)]
    public float HitRadius;
    [FieldOffset(32)]
    public PrefabGUID BuffType;
    [FieldOffset(36)]
    public SequenceGUID TriggerSequence;

    static Script_Knockback_Wall_Buff_DataServer()
    {
      Il2CppClassPointerStore<Script_Knockback_Wall_Buff_DataServer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (Script_Knockback_Wall_Buff_DataServer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_Knockback_Wall_Buff_DataServer>.NativeClassPtr);
      Script_Knockback_Wall_Buff_DataServer.NativeFieldInfoPtr_LastPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Knockback_Wall_Buff_DataServer>.NativeClassPtr, nameof (LastPosition));
      Script_Knockback_Wall_Buff_DataServer.NativeFieldInfoPtr_HitOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Knockback_Wall_Buff_DataServer>.NativeClassPtr, nameof (HitOffset));
      Script_Knockback_Wall_Buff_DataServer.NativeFieldInfoPtr_BuffDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Knockback_Wall_Buff_DataServer>.NativeClassPtr, nameof (BuffDuration));
      Script_Knockback_Wall_Buff_DataServer.NativeFieldInfoPtr_HitRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Knockback_Wall_Buff_DataServer>.NativeClassPtr, nameof (HitRadius));
      Script_Knockback_Wall_Buff_DataServer.NativeFieldInfoPtr_BuffType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Knockback_Wall_Buff_DataServer>.NativeClassPtr, nameof (BuffType));
      Script_Knockback_Wall_Buff_DataServer.NativeFieldInfoPtr_TriggerSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Knockback_Wall_Buff_DataServer>.NativeClassPtr, nameof (TriggerSequence));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Script_Knockback_Wall_Buff_DataServer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
