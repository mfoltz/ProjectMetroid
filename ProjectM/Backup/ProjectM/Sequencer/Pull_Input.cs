// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.Pull_Input
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Sequencer
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Pull_Input
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_FromEntityRegister;
    private static readonly System.IntPtr NativeFieldInfoPtr_ToAimDirectionRegister;
    private static readonly System.IntPtr NativeFieldInfoPtr_ToMovementDirectionRegister;
    [FieldOffset(0)]
    public int FromEntityRegister;
    [FieldOffset(4)]
    public int ToAimDirectionRegister;
    [FieldOffset(8)]
    public int ToMovementDirectionRegister;

    static Pull_Input()
    {
      Il2CppClassPointerStore<Pull_Input>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (Pull_Input));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Pull_Input>.NativeClassPtr);
      Pull_Input.NativeFieldInfoPtr_FromEntityRegister = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pull_Input>.NativeClassPtr, nameof (FromEntityRegister));
      Pull_Input.NativeFieldInfoPtr_ToAimDirectionRegister = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pull_Input>.NativeClassPtr, nameof (ToAimDirectionRegister));
      Pull_Input.NativeFieldInfoPtr_ToMovementDirectionRegister = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pull_Input>.NativeClassPtr, nameof (ToMovementDirectionRegister));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Pull_Input>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
