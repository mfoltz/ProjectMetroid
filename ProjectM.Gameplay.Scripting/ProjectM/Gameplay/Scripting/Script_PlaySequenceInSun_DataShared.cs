// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Script_PlaySequenceInSun_DataShared
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Script_PlaySequenceInSun_DataShared
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_BuffSequenceState;
    private static readonly System.IntPtr NativeFieldInfoPtr_BuffSequence;
    [FieldOffset(0)]
    public SequenceState BuffSequenceState;
    [FieldOffset(8)]
    public SequenceGUID BuffSequence;

    static Script_PlaySequenceInSun_DataShared()
    {
      Il2CppClassPointerStore<Script_PlaySequenceInSun_DataShared>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (Script_PlaySequenceInSun_DataShared));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_PlaySequenceInSun_DataShared>.NativeClassPtr);
      Script_PlaySequenceInSun_DataShared.NativeFieldInfoPtr_BuffSequenceState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_PlaySequenceInSun_DataShared>.NativeClassPtr, nameof (BuffSequenceState));
      Script_PlaySequenceInSun_DataShared.NativeFieldInfoPtr_BuffSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_PlaySequenceInSun_DataShared>.NativeClassPtr, nameof (BuffSequence));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Script_PlaySequenceInSun_DataShared>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
