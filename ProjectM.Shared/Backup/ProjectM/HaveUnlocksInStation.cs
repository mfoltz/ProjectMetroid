// Decompiled with JetBrains decompiler
// Type: ProjectM.HaveUnlocksInStation
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct HaveUnlocksInStation
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_CanUnlock;
    [FieldOffset(0)]
    public bool CanUnlock;

    static HaveUnlocksInStation()
    {
      Il2CppClassPointerStore<HaveUnlocksInStation>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (HaveUnlocksInStation));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HaveUnlocksInStation>.NativeClassPtr);
      HaveUnlocksInStation.NativeFieldInfoPtr_CanUnlock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HaveUnlocksInStation>.NativeClassPtr, nameof (CanUnlock));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HaveUnlocksInStation>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
