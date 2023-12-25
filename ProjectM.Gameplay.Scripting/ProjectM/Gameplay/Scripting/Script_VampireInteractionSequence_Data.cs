// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Script_VampireInteractionSequence_Data
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Script_VampireInteractionSequence_Data
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_SequenceGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_SequenceState;
    [FieldOffset(0)]
    public SequenceGUID SequenceGuid;
    [FieldOffset(4)]
    public SequenceState SequenceState;

    static Script_VampireInteractionSequence_Data()
    {
      Il2CppClassPointerStore<Script_VampireInteractionSequence_Data>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (Script_VampireInteractionSequence_Data));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_VampireInteractionSequence_Data>.NativeClassPtr);
      Script_VampireInteractionSequence_Data.NativeFieldInfoPtr_SequenceGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_VampireInteractionSequence_Data>.NativeClassPtr, nameof (SequenceGuid));
      Script_VampireInteractionSequence_Data.NativeFieldInfoPtr_SequenceState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_VampireInteractionSequence_Data>.NativeClassPtr, nameof (SequenceState));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Script_VampireInteractionSequence_Data>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
