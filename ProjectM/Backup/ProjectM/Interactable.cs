// Decompiled with JetBrains decompiler
// Type: ProjectM.Interactable
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Interactable
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_CurrentTargetSequenceGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_IgnoreLineOfSight;
    private static readonly System.IntPtr NativeFieldInfoPtr_IgnoreBlockInteract;
    private static readonly System.IntPtr NativeFieldInfoPtr_UseInteractAbilityName;
    [FieldOffset(0)]
    public SequenceGUID CurrentTargetSequenceGuid;
    [FieldOffset(4)]
    public bool IgnoreLineOfSight;
    [FieldOffset(5)]
    public bool IgnoreBlockInteract;
    [FieldOffset(6)]
    public bool UseInteractAbilityName;

    static Interactable()
    {
      Il2CppClassPointerStore<Interactable>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (Interactable));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Interactable>.NativeClassPtr);
      Interactable.NativeFieldInfoPtr_CurrentTargetSequenceGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interactable>.NativeClassPtr, nameof (CurrentTargetSequenceGuid));
      Interactable.NativeFieldInfoPtr_IgnoreLineOfSight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interactable>.NativeClassPtr, nameof (IgnoreLineOfSight));
      Interactable.NativeFieldInfoPtr_IgnoreBlockInteract = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interactable>.NativeClassPtr, nameof (IgnoreBlockInteract));
      Interactable.NativeFieldInfoPtr_UseInteractAbilityName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interactable>.NativeClassPtr, nameof (UseInteractAbilityName));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Interactable>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
