// Decompiled with JetBrains decompiler
// Type: ProjectM.DefaultAction
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct DefaultAction
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ActionID;
    [FieldOffset(0)]
    public PrefabGUID ActionID;

    static DefaultAction()
    {
      Il2CppClassPointerStore<DefaultAction>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (DefaultAction));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DefaultAction>.NativeClassPtr);
      DefaultAction.NativeFieldInfoPtr_ActionID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultAction>.NativeClassPtr, nameof (ActionID));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DefaultAction>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
