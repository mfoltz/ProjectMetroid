// Decompiled with JetBrains decompiler
// Type: ProjectM.Replays.ClientReplayPlayerEnabled
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
  public struct ClientReplayPlayerEnabled
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_FilePath;
    private static readonly System.IntPtr NativeFieldInfoPtr_CurrentTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_CurrentFraction;
    private static readonly System.IntPtr NativeFieldInfoPtr_CurrentSnapshot;
    [FieldOffset(0)]
    public FixedString512 FilePath;
    [FieldOffset(512)]
    public double CurrentTime;
    [FieldOffset(520)]
    public float CurrentFraction;
    [FieldOffset(524)]
    public int CurrentSnapshot;

    static ClientReplayPlayerEnabled()
    {
      Il2CppClassPointerStore<ClientReplayPlayerEnabled>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Replays", nameof (ClientReplayPlayerEnabled));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClientReplayPlayerEnabled>.NativeClassPtr);
      ClientReplayPlayerEnabled.NativeFieldInfoPtr_FilePath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientReplayPlayerEnabled>.NativeClassPtr, nameof (FilePath));
      ClientReplayPlayerEnabled.NativeFieldInfoPtr_CurrentTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientReplayPlayerEnabled>.NativeClassPtr, nameof (CurrentTime));
      ClientReplayPlayerEnabled.NativeFieldInfoPtr_CurrentFraction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientReplayPlayerEnabled>.NativeClassPtr, nameof (CurrentFraction));
      ClientReplayPlayerEnabled.NativeFieldInfoPtr_CurrentSnapshot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientReplayPlayerEnabled>.NativeClassPtr, nameof (CurrentSnapshot));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ClientReplayPlayerEnabled>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
