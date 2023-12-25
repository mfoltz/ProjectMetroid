// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Script_SCTChatOnAggro_Data
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Script_SCTChatOnAggro_Data
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_SCTPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_PreviousAggroTarget;
    private static readonly System.IntPtr NativeFieldInfoPtr_PreviousAlertTarget;
    private static readonly System.IntPtr NativeFieldInfoPtr_Cooldown;
    private static readonly System.IntPtr NativeFieldInfoPtr_NextAvailableAggroChatTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_NextAvailableAggroDroppedChatTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_NextAvailableAlertChatTime;
    [FieldOffset(0)]
    public PrefabGUID SCTPrefab;
    [FieldOffset(4)]
    public Entity PreviousAggroTarget;
    [FieldOffset(12)]
    public Entity PreviousAlertTarget;
    [FieldOffset(20)]
    public float Cooldown;
    [FieldOffset(24)]
    public double NextAvailableAggroChatTime;
    [FieldOffset(32)]
    public double NextAvailableAggroDroppedChatTime;
    [FieldOffset(40)]
    public double NextAvailableAlertChatTime;

    static Script_SCTChatOnAggro_Data()
    {
      Il2CppClassPointerStore<Script_SCTChatOnAggro_Data>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (Script_SCTChatOnAggro_Data));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_SCTChatOnAggro_Data>.NativeClassPtr);
      Script_SCTChatOnAggro_Data.NativeFieldInfoPtr_SCTPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_SCTChatOnAggro_Data>.NativeClassPtr, nameof (SCTPrefab));
      Script_SCTChatOnAggro_Data.NativeFieldInfoPtr_PreviousAggroTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_SCTChatOnAggro_Data>.NativeClassPtr, nameof (PreviousAggroTarget));
      Script_SCTChatOnAggro_Data.NativeFieldInfoPtr_PreviousAlertTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_SCTChatOnAggro_Data>.NativeClassPtr, nameof (PreviousAlertTarget));
      Script_SCTChatOnAggro_Data.NativeFieldInfoPtr_Cooldown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_SCTChatOnAggro_Data>.NativeClassPtr, nameof (Cooldown));
      Script_SCTChatOnAggro_Data.NativeFieldInfoPtr_NextAvailableAggroChatTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_SCTChatOnAggro_Data>.NativeClassPtr, nameof (NextAvailableAggroChatTime));
      Script_SCTChatOnAggro_Data.NativeFieldInfoPtr_NextAvailableAggroDroppedChatTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_SCTChatOnAggro_Data>.NativeClassPtr, nameof (NextAvailableAggroDroppedChatTime));
      Script_SCTChatOnAggro_Data.NativeFieldInfoPtr_NextAvailableAlertChatTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_SCTChatOnAggro_Data>.NativeClassPtr, nameof (NextAvailableAlertChatTime));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Script_SCTChatOnAggro_Data>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
