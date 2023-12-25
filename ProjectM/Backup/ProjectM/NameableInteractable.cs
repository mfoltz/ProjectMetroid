// Decompiled with JetBrains decompiler
// Type: ProjectM.NameableInteractable
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Collections;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct NameableInteractable
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Name;
    private static readonly System.IntPtr NativeFieldInfoPtr_OnlyAllyRename;
    private static readonly System.IntPtr NativeFieldInfoPtr_OnlyAllySee;
    [FieldOffset(0)]
    public FixedString64 Name;
    [FieldOffset(64)]
    public bool OnlyAllyRename;
    [FieldOffset(65)]
    public bool OnlyAllySee;

    static NameableInteractable()
    {
      Il2CppClassPointerStore<NameableInteractable>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (NameableInteractable));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NameableInteractable>.NativeClassPtr);
      NameableInteractable.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameableInteractable>.NativeClassPtr, nameof (Name));
      NameableInteractable.NativeFieldInfoPtr_OnlyAllyRename = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameableInteractable>.NativeClassPtr, nameof (OnlyAllyRename));
      NameableInteractable.NativeFieldInfoPtr_OnlyAllySee = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameableInteractable>.NativeClassPtr, nameof (OnlyAllySee));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NameableInteractable>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
