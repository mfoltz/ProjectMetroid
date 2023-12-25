// Decompiled with JetBrains decompiler
// Type: ProjectM.Audio.StudioEvent
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using Il2CppSystem;
using Stunlock.Fmod;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Audio
{
  [StructLayout(LayoutKind.Explicit)]
  public struct StudioEvent
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Event;
    private static readonly System.IntPtr NativeFieldInfoPtr_StopMode;
    private static readonly System.IntPtr NativeFieldInfoPtr_SourcePrefabGuidPlayedFrom;
    private static readonly System.IntPtr NativeFieldInfoPtr_Pitch;
    private static readonly System.IntPtr NativeFieldInfoPtr_Volume;
    private static readonly System.IntPtr NativeFieldInfoPtr_MinDistance;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxDistance;
    [FieldOffset(0)]
    public FmodEventGuid Event;
    [FieldOffset(16)]
    public StudioEventStopModeEnum StopMode;
    [FieldOffset(20)]
    public PrefabGUID SourcePrefabGuidPlayedFrom;
    [FieldOffset(24)]
    public Nullable_Unboxed<float> Pitch;
    [FieldOffset(32)]
    public Nullable_Unboxed<float> Volume;
    [FieldOffset(40)]
    public Nullable_Unboxed<float> MinDistance;
    [FieldOffset(48)]
    public Nullable_Unboxed<float> MaxDistance;

    static StudioEvent()
    {
      Il2CppClassPointerStore<StudioEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Audio", nameof (StudioEvent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StudioEvent>.NativeClassPtr);
      StudioEvent.NativeFieldInfoPtr_Event = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudioEvent>.NativeClassPtr, nameof (Event));
      StudioEvent.NativeFieldInfoPtr_StopMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudioEvent>.NativeClassPtr, nameof (StopMode));
      StudioEvent.NativeFieldInfoPtr_SourcePrefabGuidPlayedFrom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudioEvent>.NativeClassPtr, nameof (SourcePrefabGuidPlayedFrom));
      StudioEvent.NativeFieldInfoPtr_Pitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudioEvent>.NativeClassPtr, nameof (Pitch));
      StudioEvent.NativeFieldInfoPtr_Volume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudioEvent>.NativeClassPtr, nameof (Volume));
      StudioEvent.NativeFieldInfoPtr_MinDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudioEvent>.NativeClassPtr, nameof (MinDistance));
      StudioEvent.NativeFieldInfoPtr_MaxDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudioEvent>.NativeClassPtr, nameof (MaxDistance));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StudioEvent>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
