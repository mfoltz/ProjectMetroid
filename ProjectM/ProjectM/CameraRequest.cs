// Decompiled with JetBrains decompiler
// Type: ProjectM.CameraRequest
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using Il2CppSystem;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Transforms;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct CameraRequest
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_RequestedOrbitCameraTargetLocation;
    private static readonly System.IntPtr NativeFieldInfoPtr_RequestedOrbitCameraTargetEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_RequestedCameraType;
    [FieldOffset(0)]
    public Nullable_Unboxed<Translation> RequestedOrbitCameraTargetLocation;
    [FieldOffset(16)]
    public Nullable_Unboxed<Entity> RequestedOrbitCameraTargetEntity;
    [FieldOffset(28)]
    public CameraType RequestedCameraType;

    static CameraRequest()
    {
      Il2CppClassPointerStore<CameraRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (CameraRequest));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraRequest>.NativeClassPtr);
      CameraRequest.NativeFieldInfoPtr_RequestedOrbitCameraTargetLocation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraRequest>.NativeClassPtr, nameof (RequestedOrbitCameraTargetLocation));
      CameraRequest.NativeFieldInfoPtr_RequestedOrbitCameraTargetEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraRequest>.NativeClassPtr, nameof (RequestedOrbitCameraTargetEntity));
      CameraRequest.NativeFieldInfoPtr_RequestedCameraType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraRequest>.NativeClassPtr, nameof (RequestedCameraType));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CameraRequest>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
