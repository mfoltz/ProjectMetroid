// Decompiled with JetBrains decompiler
// Type: ProjectM.ScriptMethodReference
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
  public struct ScriptMethodReference
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_MethodName;
    private static readonly System.IntPtr NativeFieldInfoPtr_TypeName;
    [FieldOffset(0)]
    public FixedString64 MethodName;
    [FieldOffset(64)]
    public FixedString64 TypeName;

    static ScriptMethodReference()
    {
      Il2CppClassPointerStore<ScriptMethodReference>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (ScriptMethodReference));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptMethodReference>.NativeClassPtr);
      ScriptMethodReference.NativeFieldInfoPtr_MethodName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptMethodReference>.NativeClassPtr, nameof (MethodName));
      ScriptMethodReference.NativeFieldInfoPtr_TypeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptMethodReference>.NativeClassPtr, nameof (TypeName));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ScriptMethodReference>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
