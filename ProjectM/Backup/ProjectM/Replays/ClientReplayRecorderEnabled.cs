// Decompiled with JetBrains decompiler
// Type: ProjectM.Replays.ClientReplayRecorderEnabled
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Collections;

#nullable disable
namespace ProjectM.Replays
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ClientReplayRecorderEnabled
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_FileName;
    private static readonly System.IntPtr NativeFieldInfoPtr_CurrentTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_CurrentSnapshot;
    [FieldOffset(0)]
    public FixedString512 FileName;
    [FieldOffset(512)]
    public double CurrentTime;
    [FieldOffset(520)]
    public int CurrentSnapshot;

    static ClientReplayRecorderEnabled()
    {
      Il2CppClassPointerStore<ClientReplayRecorderEnabled>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Replays", nameof (ClientReplayRecorderEnabled));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClientReplayRecorderEnabled>.NativeClassPtr);
      ClientReplayRecorderEnabled.NativeFieldInfoPtr_FileName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientReplayRecorderEnabled>.NativeClassPtr, nameof (FileName));
      ClientReplayRecorderEnabled.NativeFieldInfoPtr_CurrentTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientReplayRecorderEnabled>.NativeClassPtr, nameof (CurrentTime));
      ClientReplayRecorderEnabled.NativeFieldInfoPtr_CurrentSnapshot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientReplayRecorderEnabled>.NativeClassPtr, nameof (CurrentSnapshot));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ClientReplayRecorderEnabled>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
