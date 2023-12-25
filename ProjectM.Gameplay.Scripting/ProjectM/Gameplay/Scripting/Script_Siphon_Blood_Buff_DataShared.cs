// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Script_Siphon_Blood_Buff_DataShared
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Script_Siphon_Blood_Buff_DataShared
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ImmaterialDuration;
    private static readonly System.IntPtr NativeFieldInfoPtr_ImmaterialSequence;
    private static readonly System.IntPtr NativeFieldInfoPtr_ImmaterialSequenceState;
    private static readonly System.IntPtr NativeFieldInfoPtr_ImmaterialModificationId;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsRevive;
    private static readonly System.IntPtr NativeFieldInfoPtr_ShowAbortText;
    private static readonly System.IntPtr NativeFieldInfoPtr_ImmaterialActive;
    [FieldOffset(0)]
    public float ImmaterialDuration;
    [FieldOffset(4)]
    public SequenceGUID ImmaterialSequence;
    [FieldOffset(8)]
    public SequenceState ImmaterialSequenceState;
    [FieldOffset(16)]
    public ModificationId ImmaterialModificationId;
    [FieldOffset(20)]
    public bool IsRevive;
    [FieldOffset(21)]
    public bool ShowAbortText;
    [FieldOffset(22)]
    public bool ImmaterialActive;

    static Script_Siphon_Blood_Buff_DataShared()
    {
      Il2CppClassPointerStore<Script_Siphon_Blood_Buff_DataShared>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (Script_Siphon_Blood_Buff_DataShared));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_Siphon_Blood_Buff_DataShared>.NativeClassPtr);
      Script_Siphon_Blood_Buff_DataShared.NativeFieldInfoPtr_ImmaterialDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Siphon_Blood_Buff_DataShared>.NativeClassPtr, nameof (ImmaterialDuration));
      Script_Siphon_Blood_Buff_DataShared.NativeFieldInfoPtr_ImmaterialSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Siphon_Blood_Buff_DataShared>.NativeClassPtr, nameof (ImmaterialSequence));
      Script_Siphon_Blood_Buff_DataShared.NativeFieldInfoPtr_ImmaterialSequenceState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Siphon_Blood_Buff_DataShared>.NativeClassPtr, nameof (ImmaterialSequenceState));
      Script_Siphon_Blood_Buff_DataShared.NativeFieldInfoPtr_ImmaterialModificationId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Siphon_Blood_Buff_DataShared>.NativeClassPtr, nameof (ImmaterialModificationId));
      Script_Siphon_Blood_Buff_DataShared.NativeFieldInfoPtr_IsRevive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Siphon_Blood_Buff_DataShared>.NativeClassPtr, nameof (IsRevive));
      Script_Siphon_Blood_Buff_DataShared.NativeFieldInfoPtr_ShowAbortText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Siphon_Blood_Buff_DataShared>.NativeClassPtr, nameof (ShowAbortText));
      Script_Siphon_Blood_Buff_DataShared.NativeFieldInfoPtr_ImmaterialActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Siphon_Blood_Buff_DataShared>.NativeClassPtr, nameof (ImmaterialActive));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Script_Siphon_Blood_Buff_DataShared>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
