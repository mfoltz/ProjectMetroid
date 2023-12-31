// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.SetLocalUserIndexEvent
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Network
{
  [StructLayout(LayoutKind.Explicit)]
  public struct SetLocalUserIndexEvent
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_UserIndex;
    [FieldOffset(0)]
    public int UserIndex;

    static SetLocalUserIndexEvent()
    {
      Il2CppClassPointerStore<SetLocalUserIndexEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Network", nameof (SetLocalUserIndexEvent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetLocalUserIndexEvent>.NativeClassPtr);
      SetLocalUserIndexEvent.NativeFieldInfoPtr_UserIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetLocalUserIndexEvent>.NativeClassPtr, nameof (UserIndex));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SetLocalUserIndexEvent>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
