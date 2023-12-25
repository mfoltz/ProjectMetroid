// Decompiled with JetBrains decompiler
// Type: Unity.Physics.Extensions.MousePick
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace Unity.Physics.Extensions
{
  [StructLayout(LayoutKind.Explicit)]
  public struct MousePick
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_IgnoreTriggers;
    [FieldOffset(0)]
    public int IgnoreTriggers;

    static MousePick()
    {
      Il2CppClassPointerStore<MousePick>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Unity.Physics.Extensions", nameof (MousePick));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MousePick>.NativeClassPtr);
      MousePick.NativeFieldInfoPtr_IgnoreTriggers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MousePick>.NativeClassPtr, nameof (IgnoreTriggers));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MousePick>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
