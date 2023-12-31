// Decompiled with JetBrains decompiler
// Type: ProjectM.Dead
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
  public struct Dead
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ServerTimeOfDeath;
    private static readonly System.IntPtr NativeFieldInfoPtr_DestroyAfterDuration;
    private static readonly System.IntPtr NativeFieldInfoPtr_HIDE_TIMEOUT;
    private static readonly System.IntPtr NativeFieldInfoPtr_Killer;
    private static readonly System.IntPtr NativeFieldInfoPtr_KillerSource;
    private static readonly System.IntPtr NativeFieldInfoPtr_DoNotDestroy;
    [FieldOffset(0)]
    public double ServerTimeOfDeath;
    [FieldOffset(8)]
    public float DestroyAfterDuration;
    [FieldOffset(12)]
    public Entity Killer;
    [FieldOffset(20)]
    public Entity KillerSource;
    [FieldOffset(28)]
    public bool DoNotDestroy;

    static Dead()
    {
      Il2CppClassPointerStore<Dead>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (Dead));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Dead>.NativeClassPtr);
      Dead.NativeFieldInfoPtr_ServerTimeOfDeath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dead>.NativeClassPtr, nameof (ServerTimeOfDeath));
      Dead.NativeFieldInfoPtr_DestroyAfterDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dead>.NativeClassPtr, nameof (DestroyAfterDuration));
      Dead.NativeFieldInfoPtr_HIDE_TIMEOUT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dead>.NativeClassPtr, nameof (HIDE_TIMEOUT));
      Dead.NativeFieldInfoPtr_Killer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dead>.NativeClassPtr, nameof (Killer));
      Dead.NativeFieldInfoPtr_KillerSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dead>.NativeClassPtr, nameof (KillerSource));
      Dead.NativeFieldInfoPtr_DoNotDestroy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dead>.NativeClassPtr, nameof (DoNotDestroy));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Dead>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public static unsafe float HIDE_TIMEOUT
    {
      get
      {
        float hideTimeout;
        IL2CPP.il2cpp_field_static_get_value(Dead.NativeFieldInfoPtr_HIDE_TIMEOUT, (void*) &hideTimeout);
        return hideTimeout;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Dead.NativeFieldInfoPtr_HIDE_TIMEOUT, (void*) &value);
      }
    }
  }
}
