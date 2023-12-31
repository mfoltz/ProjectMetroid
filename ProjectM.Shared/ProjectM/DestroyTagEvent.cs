// Decompiled with JetBrains decompiler
// Type: ProjectM.DestroyTagEvent
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
  public struct DestroyTagEvent
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Entity;
    private static readonly System.IntPtr NativeFieldInfoPtr_DestroyReason;
    private static readonly System.IntPtr NativeFieldInfoPtr_DestroyDebugReason;
    [FieldOffset(0)]
    public Entity Entity;
    [FieldOffset(8)]
    public DestroyReason DestroyReason;
    [FieldOffset(9)]
    public DestroyDebugReason DestroyDebugReason;

    static DestroyTagEvent()
    {
      Il2CppClassPointerStore<DestroyTagEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (DestroyTagEvent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DestroyTagEvent>.NativeClassPtr);
      DestroyTagEvent.NativeFieldInfoPtr_Entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DestroyTagEvent>.NativeClassPtr, nameof (Entity));
      DestroyTagEvent.NativeFieldInfoPtr_DestroyReason = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DestroyTagEvent>.NativeClassPtr, nameof (DestroyReason));
      DestroyTagEvent.NativeFieldInfoPtr_DestroyDebugReason = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DestroyTagEvent>.NativeClassPtr, nameof (DestroyDebugReason));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DestroyTagEvent>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
