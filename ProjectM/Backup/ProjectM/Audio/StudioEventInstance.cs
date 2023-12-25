// Decompiled with JetBrains decompiler
// Type: ProjectM.Audio.StudioEventInstance
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using FMOD.Studio;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Audio
{
  [StructLayout(LayoutKind.Explicit)]
  public struct StudioEventInstance
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Instance;
    private static readonly System.IntPtr NativeFieldInfoPtr_StopMode;
    private static readonly System.IntPtr NativeFieldInfoPtr_SourcePrefabGuidPlayedFrom;
    private static readonly System.IntPtr NativeFieldInfoPtr_Pitch;
    private static readonly System.IntPtr NativeFieldInfoPtr_Volume;
    private static readonly System.IntPtr NativeFieldInfoPtr_MinDistance;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxDistance;
    [FieldOffset(0)]
    public EventInstance Instance;
    [FieldOffset(8)]
    public StudioEventStopModeEnum StopMode;
    [FieldOffset(12)]
    public PrefabGUID SourcePrefabGuidPlayedFrom;
    [FieldOffset(16)]
    public Nullable_Unboxed<float> Pitch;
    [FieldOffset(24)]
    public Nullable_Unboxed<float> Volume;
    [FieldOffset(32)]
    public Nullable_Unboxed<float> MinDistance;
    [FieldOffset(40)]
    public Nullable_Unboxed<float> MaxDistance;

    static StudioEventInstance()
    {
      Il2CppClassPointerStore<StudioEventInstance>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Audio", nameof (StudioEventInstance));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StudioEventInstance>.NativeClassPtr);
      StudioEventInstance.NativeFieldInfoPtr_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudioEventInstance>.NativeClassPtr, nameof (Instance));
      StudioEventInstance.NativeFieldInfoPtr_StopMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudioEventInstance>.NativeClassPtr, nameof (StopMode));
      StudioEventInstance.NativeFieldInfoPtr_SourcePrefabGuidPlayedFrom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudioEventInstance>.NativeClassPtr, nameof (SourcePrefabGuidPlayedFrom));
      StudioEventInstance.NativeFieldInfoPtr_Pitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudioEventInstance>.NativeClassPtr, nameof (Pitch));
      StudioEventInstance.NativeFieldInfoPtr_Volume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudioEventInstance>.NativeClassPtr, nameof (Volume));
      StudioEventInstance.NativeFieldInfoPtr_MinDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudioEventInstance>.NativeClassPtr, nameof (MinDistance));
      StudioEventInstance.NativeFieldInfoPtr_MaxDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudioEventInstance>.NativeClassPtr, nameof (MaxDistance));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StudioEventInstance>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
