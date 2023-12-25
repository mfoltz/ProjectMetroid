// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Script_Wounded_DataShared
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Runtime;
using ProjectM.Scripting;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Script_Wounded_DataShared
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_OnDamageTakenListener;
    private static readonly System.IntPtr NativeFieldInfoPtr_WoundedSequenceState;
    private static readonly System.IntPtr NativeFieldInfoPtr_KnockbackModification;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsWounded;
    [FieldOffset(0)]
    public ListenerId OnDamageTakenListener;
    [FieldOffset(8)]
    public SequenceState WoundedSequenceState;
    [FieldOffset(16)]
    public ModificationId KnockbackModification;
    [FieldOffset(20)]
    public bool IsWounded;

    static Script_Wounded_DataShared()
    {
      Il2CppClassPointerStore<Script_Wounded_DataShared>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (Script_Wounded_DataShared));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_Wounded_DataShared>.NativeClassPtr);
      Script_Wounded_DataShared.NativeFieldInfoPtr_OnDamageTakenListener = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Wounded_DataShared>.NativeClassPtr, nameof (OnDamageTakenListener));
      Script_Wounded_DataShared.NativeFieldInfoPtr_WoundedSequenceState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Wounded_DataShared>.NativeClassPtr, nameof (WoundedSequenceState));
      Script_Wounded_DataShared.NativeFieldInfoPtr_KnockbackModification = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Wounded_DataShared>.NativeClassPtr, nameof (KnockbackModification));
      Script_Wounded_DataShared.NativeFieldInfoPtr_IsWounded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Wounded_DataShared>.NativeClassPtr, nameof (IsWounded));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Script_Wounded_DataShared>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
