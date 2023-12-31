// Decompiled with JetBrains decompiler
// Type: ProjectM.DelayedAggroEvent
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
  public struct DelayedAggroEvent
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Source;
    private static readonly System.IntPtr NativeFieldInfoPtr_Target;
    private static readonly System.IntPtr NativeFieldInfoPtr_Reason;
    private static readonly System.IntPtr NativeFieldInfoPtr_RealizationTime;
    [FieldOffset(0)]
    public Entity Source;
    [FieldOffset(8)]
    public Entity Target;
    [FieldOffset(16)]
    public AggroReason Reason;
    [FieldOffset(24)]
    public double RealizationTime;

    static DelayedAggroEvent()
    {
      Il2CppClassPointerStore<DelayedAggroEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (DelayedAggroEvent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DelayedAggroEvent>.NativeClassPtr);
      DelayedAggroEvent.NativeFieldInfoPtr_Source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelayedAggroEvent>.NativeClassPtr, nameof (Source));
      DelayedAggroEvent.NativeFieldInfoPtr_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelayedAggroEvent>.NativeClassPtr, nameof (Target));
      DelayedAggroEvent.NativeFieldInfoPtr_Reason = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelayedAggroEvent>.NativeClassPtr, nameof (Reason));
      DelayedAggroEvent.NativeFieldInfoPtr_RealizationTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelayedAggroEvent>.NativeClassPtr, nameof (RealizationTime));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DelayedAggroEvent>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
