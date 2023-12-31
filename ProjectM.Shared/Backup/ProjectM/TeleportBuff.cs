// Decompiled with JetBrains decompiler
// Type: ProjectM.TeleportBuff
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Mathematics;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct TeleportBuff
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_EndPosition;
    private static readonly System.IntPtr NativeFieldInfoPtr_TimeSpawned;
    private static readonly System.IntPtr NativeFieldInfoPtr_EndCameraRotation;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameSpawned;
    private static readonly System.IntPtr NativeFieldInfoPtr_SetCameraRotationOnTeleport;
    [FieldOffset(0)]
    public float3 EndPosition;
    [FieldOffset(16)]
    public double TimeSpawned;
    [FieldOffset(24)]
    public float EndCameraRotation;
    [FieldOffset(28)]
    public int FrameSpawned;
    [FieldOffset(32)]
    public bool SetCameraRotationOnTeleport;

    static TeleportBuff()
    {
      Il2CppClassPointerStore<TeleportBuff>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (TeleportBuff));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TeleportBuff>.NativeClassPtr);
      TeleportBuff.NativeFieldInfoPtr_EndPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportBuff>.NativeClassPtr, nameof (EndPosition));
      TeleportBuff.NativeFieldInfoPtr_TimeSpawned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportBuff>.NativeClassPtr, nameof (TimeSpawned));
      TeleportBuff.NativeFieldInfoPtr_EndCameraRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportBuff>.NativeClassPtr, nameof (EndCameraRotation));
      TeleportBuff.NativeFieldInfoPtr_FrameSpawned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportBuff>.NativeClassPtr, nameof (FrameSpawned));
      TeleportBuff.NativeFieldInfoPtr_SetCameraRotationOnTeleport = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportBuff>.NativeClassPtr, nameof (SetCameraRotationOnTeleport));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TeleportBuff>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
