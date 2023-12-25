// Decompiled with JetBrains decompiler
// Type: DismantleEvent
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
[StructLayout(LayoutKind.Explicit)]
public struct DismantleEvent
{
  private static readonly System.IntPtr NativeFieldInfoPtr_Character;
  private static readonly System.IntPtr NativeFieldInfoPtr_DismantleTarget;
  [FieldOffset(0)]
  public Entity Character;
  [FieldOffset(8)]
  public Entity DismantleTarget;

  static DismantleEvent()
  {
    Il2CppClassPointerStore<DismantleEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "", nameof (DismantleEvent));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DismantleEvent>.NativeClassPtr);
    DismantleEvent.NativeFieldInfoPtr_Character = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DismantleEvent>.NativeClassPtr, nameof (Character));
    DismantleEvent.NativeFieldInfoPtr_DismantleTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DismantleEvent>.NativeClassPtr, nameof (DismantleTarget));
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DismantleEvent>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
