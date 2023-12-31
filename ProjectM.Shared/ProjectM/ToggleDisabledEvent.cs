// Decompiled with JetBrains decompiler
// Type: ProjectM.ToggleDisabledEvent
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ToggleDisabledEvent
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Entity;
    private static readonly System.IntPtr NativeFieldInfoPtr_EntityTags;
    private static readonly System.IntPtr NativeFieldInfoPtr_Disable;
    private static readonly System.IntPtr NativeFieldInfoPtr_WasDisabled;
    [FieldOffset(0)]
    public Entity Entity;
    [FieldOffset(8)]
    public ToggleDisableEntityTags EntityTags;
    [FieldOffset(9)]
    public bool Disable;
    [FieldOffset(10)]
    public bool WasDisabled;

    static ToggleDisabledEvent()
    {
      Il2CppClassPointerStore<ToggleDisabledEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (ToggleDisabledEvent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ToggleDisabledEvent>.NativeClassPtr);
      ToggleDisabledEvent.NativeFieldInfoPtr_Entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToggleDisabledEvent>.NativeClassPtr, nameof (Entity));
      ToggleDisabledEvent.NativeFieldInfoPtr_EntityTags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToggleDisabledEvent>.NativeClassPtr, nameof (EntityTags));
      ToggleDisabledEvent.NativeFieldInfoPtr_Disable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToggleDisabledEvent>.NativeClassPtr, nameof (Disable));
      ToggleDisabledEvent.NativeFieldInfoPtr_WasDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToggleDisabledEvent>.NativeClassPtr, nameof (WasDisabled));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ToggleDisabledEvent>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
