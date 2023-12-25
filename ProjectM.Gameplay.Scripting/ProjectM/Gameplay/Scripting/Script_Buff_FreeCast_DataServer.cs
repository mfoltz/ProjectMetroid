// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Script_Buff_FreeCast_DataServer
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Script_Buff_FreeCast_DataServer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_SCT;
    private static readonly System.IntPtr NativeFieldInfoPtr_Chance;
    private static readonly System.IntPtr NativeFieldInfoPtr_ChancePerStack;
    private static readonly System.IntPtr NativeFieldInfoPtr_TriggerSequence;
    private static readonly System.IntPtr NativeFieldInfoPtr_DestroyOnTrigger;
    [FieldOffset(0)]
    public AssetGuid SCT;
    [FieldOffset(16)]
    public float Chance;
    [FieldOffset(20)]
    public float ChancePerStack;
    [FieldOffset(24)]
    public SequenceGUID TriggerSequence;
    [FieldOffset(28)]
    public bool DestroyOnTrigger;

    static Script_Buff_FreeCast_DataServer()
    {
      Il2CppClassPointerStore<Script_Buff_FreeCast_DataServer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (Script_Buff_FreeCast_DataServer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_Buff_FreeCast_DataServer>.NativeClassPtr);
      Script_Buff_FreeCast_DataServer.NativeFieldInfoPtr_SCT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Buff_FreeCast_DataServer>.NativeClassPtr, nameof (SCT));
      Script_Buff_FreeCast_DataServer.NativeFieldInfoPtr_Chance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Buff_FreeCast_DataServer>.NativeClassPtr, nameof (Chance));
      Script_Buff_FreeCast_DataServer.NativeFieldInfoPtr_ChancePerStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Buff_FreeCast_DataServer>.NativeClassPtr, nameof (ChancePerStack));
      Script_Buff_FreeCast_DataServer.NativeFieldInfoPtr_TriggerSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Buff_FreeCast_DataServer>.NativeClassPtr, nameof (TriggerSequence));
      Script_Buff_FreeCast_DataServer.NativeFieldInfoPtr_DestroyOnTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Buff_FreeCast_DataServer>.NativeClassPtr, nameof (DestroyOnTrigger));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Script_Buff_FreeCast_DataServer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
