// Decompiled with JetBrains decompiler
// Type: ProjectM.Workstation
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Workstation
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ActiveSequenceGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_ActiveSequenceState;
    private static readonly System.IntPtr NativeFieldInfoPtr_InactiveSequenceGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_InactiveSequenceState;
    [FieldOffset(0)]
    public SequenceGUID ActiveSequenceGuid;
    [FieldOffset(4)]
    public SequenceState ActiveSequenceState;
    [FieldOffset(12)]
    public SequenceGUID InactiveSequenceGuid;
    [FieldOffset(16)]
    public SequenceState InactiveSequenceState;

    static Workstation()
    {
      Il2CppClassPointerStore<Workstation>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (Workstation));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Workstation>.NativeClassPtr);
      Workstation.NativeFieldInfoPtr_ActiveSequenceGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Workstation>.NativeClassPtr, nameof (ActiveSequenceGuid));
      Workstation.NativeFieldInfoPtr_ActiveSequenceState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Workstation>.NativeClassPtr, nameof (ActiveSequenceState));
      Workstation.NativeFieldInfoPtr_InactiveSequenceGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Workstation>.NativeClassPtr, nameof (InactiveSequenceGuid));
      Workstation.NativeFieldInfoPtr_InactiveSequenceState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Workstation>.NativeClassPtr, nameof (InactiveSequenceState));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Workstation>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
