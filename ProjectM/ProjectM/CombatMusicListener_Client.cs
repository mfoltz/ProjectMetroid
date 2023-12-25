// Decompiled with JetBrains decompiler
// Type: ProjectM.CombatMusicListener_Client
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct CombatMusicListener_Client
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ActiveSequenceState;
    private static readonly System.IntPtr NativeFieldInfoPtr_PreviousSequenceGuid;
    [FieldOffset(0)]
    public SequenceState ActiveSequenceState;
    [FieldOffset(8)]
    public SequenceGUID PreviousSequenceGuid;

    static CombatMusicListener_Client()
    {
      Il2CppClassPointerStore<CombatMusicListener_Client>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (CombatMusicListener_Client));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CombatMusicListener_Client>.NativeClassPtr);
      CombatMusicListener_Client.NativeFieldInfoPtr_ActiveSequenceState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatMusicListener_Client>.NativeClassPtr, nameof (ActiveSequenceState));
      CombatMusicListener_Client.NativeFieldInfoPtr_PreviousSequenceGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatMusicListener_Client>.NativeClassPtr, nameof (PreviousSequenceGuid));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CombatMusicListener_Client>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
