// Decompiled with JetBrains decompiler
// Type: ProjectM.ProgressionDependencyElement
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ProgressionDependencyElement
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_PrefabGuid;
    [FieldOffset(0)]
    public PrefabGUID PrefabGuid;

    static ProgressionDependencyElement()
    {
      Il2CppClassPointerStore<ProgressionDependencyElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (ProgressionDependencyElement));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProgressionDependencyElement>.NativeClassPtr);
      ProgressionDependencyElement.NativeFieldInfoPtr_PrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProgressionDependencyElement>.NativeClassPtr, nameof (PrefabGuid));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProgressionDependencyElement>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
