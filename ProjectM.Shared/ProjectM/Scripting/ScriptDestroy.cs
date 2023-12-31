// Decompiled with JetBrains decompiler
// Type: ProjectM.Scripting.ScriptDestroy
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Scripting
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ScriptDestroy
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Handled;
    [FieldOffset(0)]
    public bool Handled;

    static ScriptDestroy()
    {
      Il2CppClassPointerStore<ScriptDestroy>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Scripting", nameof (ScriptDestroy));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptDestroy>.NativeClassPtr);
      ScriptDestroy.NativeFieldInfoPtr_Handled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptDestroy>.NativeClassPtr, nameof (Handled));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ScriptDestroy>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
