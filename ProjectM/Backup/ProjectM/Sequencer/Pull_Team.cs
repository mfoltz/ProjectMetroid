// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.Pull_Team
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Sequencer
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Pull_Team
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_FromEntityRegister;
    private static readonly System.IntPtr NativeFieldInfoPtr_ToTeamRegister;
    [FieldOffset(0)]
    public int FromEntityRegister;
    [FieldOffset(4)]
    public int ToTeamRegister;

    static Pull_Team()
    {
      Il2CppClassPointerStore<Pull_Team>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (Pull_Team));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Pull_Team>.NativeClassPtr);
      Pull_Team.NativeFieldInfoPtr_FromEntityRegister = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pull_Team>.NativeClassPtr, nameof (FromEntityRegister));
      Pull_Team.NativeFieldInfoPtr_ToTeamRegister = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pull_Team>.NativeClassPtr, nameof (ToTeamRegister));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Pull_Team>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
