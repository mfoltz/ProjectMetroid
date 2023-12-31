// Decompiled with JetBrains decompiler
// Type: ProjectM.Footstep
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using Stunlock.Fmod;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Footstep
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Guid;
    private static readonly System.IntPtr NativeFieldInfoPtr_PlayWhenNotMoving;
    [FieldOffset(0)]
    public FmodEventGuid Guid;
    [FieldOffset(16)]
    public bool PlayWhenNotMoving;

    static Footstep()
    {
      Il2CppClassPointerStore<Footstep>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (Footstep));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Footstep>.NativeClassPtr);
      Footstep.NativeFieldInfoPtr_Guid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Footstep>.NativeClassPtr, nameof (Guid));
      Footstep.NativeFieldInfoPtr_PlayWhenNotMoving = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Footstep>.NativeClassPtr, nameof (PlayWhenNotMoving));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Footstep>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
