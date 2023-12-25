// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Script_Buff_Spellblock_DataServer
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Script_Buff_Spellblock_DataServer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_SpellblockBuffType;
    private static readonly System.IntPtr NativeFieldInfoPtr_TriggerBuffDuration;
    private static readonly System.IntPtr NativeFieldInfoPtr_IgnoreSpellBlockFlags;
    private static readonly System.IntPtr NativeFieldInfoPtr_TriggerSequence;
    [FieldOffset(0)]
    public PrefabGUID SpellblockBuffType;
    [FieldOffset(4)]
    public float TriggerBuffDuration;
    [FieldOffset(8)]
    public AbilityTypeFlag IgnoreSpellBlockFlags;
    [FieldOffset(12)]
    public SequenceGUID TriggerSequence;

    static Script_Buff_Spellblock_DataServer()
    {
      Il2CppClassPointerStore<Script_Buff_Spellblock_DataServer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (Script_Buff_Spellblock_DataServer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_Buff_Spellblock_DataServer>.NativeClassPtr);
      Script_Buff_Spellblock_DataServer.NativeFieldInfoPtr_SpellblockBuffType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Buff_Spellblock_DataServer>.NativeClassPtr, nameof (SpellblockBuffType));
      Script_Buff_Spellblock_DataServer.NativeFieldInfoPtr_TriggerBuffDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Buff_Spellblock_DataServer>.NativeClassPtr, nameof (TriggerBuffDuration));
      Script_Buff_Spellblock_DataServer.NativeFieldInfoPtr_IgnoreSpellBlockFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Buff_Spellblock_DataServer>.NativeClassPtr, nameof (IgnoreSpellBlockFlags));
      Script_Buff_Spellblock_DataServer.NativeFieldInfoPtr_TriggerSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Buff_Spellblock_DataServer>.NativeClassPtr, nameof (TriggerSequence));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Script_Buff_Spellblock_DataServer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
