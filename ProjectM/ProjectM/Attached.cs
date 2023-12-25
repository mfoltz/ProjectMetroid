// Decompiled with JetBrains decompiler
// Type: ProjectM.Attached
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Attached
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Parent;
    private static readonly System.IntPtr NativeFieldInfoPtr_AttachParentIndex;
    [FieldOffset(0)]
    public Entity Parent;
    [FieldOffset(8)]
    public int AttachParentIndex;

    static Attached()
    {
      Il2CppClassPointerStore<Attached>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (Attached));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Attached>.NativeClassPtr);
      Attached.NativeFieldInfoPtr_Parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Attached>.NativeClassPtr, nameof (Parent));
      Attached.NativeFieldInfoPtr_AttachParentIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Attached>.NativeClassPtr, nameof (AttachParentIndex));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Attached>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
