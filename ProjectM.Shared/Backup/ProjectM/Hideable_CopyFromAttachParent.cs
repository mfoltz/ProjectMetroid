// Decompiled with JetBrains decompiler
// Type: ProjectM.Hideable_CopyFromAttachParent
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Hideable_CopyFromAttachParent
  {
    static Hideable_CopyFromAttachParent()
    {
      Il2CppClassPointerStore<Hideable_CopyFromAttachParent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (Hideable_CopyFromAttachParent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Hideable_CopyFromAttachParent>.NativeClassPtr);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Hideable_CopyFromAttachParent>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
