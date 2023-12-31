// Decompiled with JetBrains decompiler
// Type: ProjectM.Destroy_Debug
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Collections;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Destroy_Debug
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_CallerLineNumber;
    private static readonly System.IntPtr NativeFieldInfoPtr_CallerFilePath;
    private static readonly System.IntPtr NativeFieldInfoPtr_CallerMethodName;
    [FieldOffset(0)]
    public int CallerLineNumber;
    [FieldOffset(4)]
    public FixedString512 CallerFilePath;
    [FieldOffset(516)]
    public FixedString512 CallerMethodName;

    static Destroy_Debug()
    {
      Il2CppClassPointerStore<Destroy_Debug>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (Destroy_Debug));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Destroy_Debug>.NativeClassPtr);
      Destroy_Debug.NativeFieldInfoPtr_CallerLineNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_Debug>.NativeClassPtr, nameof (CallerLineNumber));
      Destroy_Debug.NativeFieldInfoPtr_CallerFilePath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_Debug>.NativeClassPtr, nameof (CallerFilePath));
      Destroy_Debug.NativeFieldInfoPtr_CallerMethodName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_Debug>.NativeClassPtr, nameof (CallerMethodName));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Destroy_Debug>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
