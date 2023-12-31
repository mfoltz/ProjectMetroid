// Decompiled with JetBrains decompiler
// Type: ProjectM.Audio.IdleAISoundBuffer
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using Stunlock.Fmod;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.Audio
{
  [StructLayout(LayoutKind.Explicit)]
  public struct IdleAISoundBuffer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_SoundEventEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_SoundGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_StopBehaviour;
    private static readonly System.IntPtr NativeFieldInfoPtr_StopMode;
    private static readonly System.IntPtr NativeFieldInfoPtr_VolumeRatio;
    private static readonly System.IntPtr NativeFieldInfoPtr_PitchRatio;
    private static readonly System.IntPtr NativeFieldInfoPtr_Active;
    private static readonly System.IntPtr NativeFieldInfoPtr_SetMovementParameter;
    [FieldOffset(0)]
    public Entity SoundEventEntity;
    [FieldOffset(8)]
    public FmodEventGuid SoundGuid;
    [FieldOffset(24)]
    public IdleSoundStopBehaviour StopBehaviour;
    [FieldOffset(28)]
    public IdleAIStudioEventStopModeEnum StopMode;
    [FieldOffset(32)]
    public float VolumeRatio;
    [FieldOffset(36)]
    public float PitchRatio;
    [FieldOffset(40)]
    public bool Active;
    [FieldOffset(41)]
    public bool SetMovementParameter;

    static IdleAISoundBuffer()
    {
      Il2CppClassPointerStore<IdleAISoundBuffer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Audio", nameof (IdleAISoundBuffer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IdleAISoundBuffer>.NativeClassPtr);
      IdleAISoundBuffer.NativeFieldInfoPtr_SoundEventEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdleAISoundBuffer>.NativeClassPtr, nameof (SoundEventEntity));
      IdleAISoundBuffer.NativeFieldInfoPtr_SoundGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdleAISoundBuffer>.NativeClassPtr, nameof (SoundGuid));
      IdleAISoundBuffer.NativeFieldInfoPtr_StopBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdleAISoundBuffer>.NativeClassPtr, nameof (StopBehaviour));
      IdleAISoundBuffer.NativeFieldInfoPtr_StopMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdleAISoundBuffer>.NativeClassPtr, nameof (StopMode));
      IdleAISoundBuffer.NativeFieldInfoPtr_VolumeRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdleAISoundBuffer>.NativeClassPtr, nameof (VolumeRatio));
      IdleAISoundBuffer.NativeFieldInfoPtr_PitchRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdleAISoundBuffer>.NativeClassPtr, nameof (PitchRatio));
      IdleAISoundBuffer.NativeFieldInfoPtr_Active = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdleAISoundBuffer>.NativeClassPtr, nameof (Active));
      IdleAISoundBuffer.NativeFieldInfoPtr_SetMovementParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdleAISoundBuffer>.NativeClassPtr, nameof (SetMovementParameter));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<IdleAISoundBuffer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
