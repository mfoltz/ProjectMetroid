// Decompiled with JetBrains decompiler
// Type: ProjectM.Forge_Client
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Forge_Client
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

    static Forge_Client()
    {
      Il2CppClassPointerStore<Forge_Client>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (Forge_Client));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Forge_Client>.NativeClassPtr);
      Forge_Client.NativeFieldInfoPtr_ActiveSequenceGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Forge_Client>.NativeClassPtr, nameof (ActiveSequenceGuid));
      Forge_Client.NativeFieldInfoPtr_ActiveSequenceState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Forge_Client>.NativeClassPtr, nameof (ActiveSequenceState));
      Forge_Client.NativeFieldInfoPtr_InactiveSequenceGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Forge_Client>.NativeClassPtr, nameof (InactiveSequenceGuid));
      Forge_Client.NativeFieldInfoPtr_InactiveSequenceState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Forge_Client>.NativeClassPtr, nameof (InactiveSequenceState));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Forge_Client>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
