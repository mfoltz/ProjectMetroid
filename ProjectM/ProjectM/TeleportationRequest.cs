// Decompiled with JetBrains decompiler
// Type: ProjectM.TeleportationRequest
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct TeleportationRequest
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_PlayerEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_TeleportationType;
    private static readonly System.IntPtr NativeFieldInfoPtr_FromTarget;
    private static readonly System.IntPtr NativeFieldInfoPtr_ToTarget;
    private static readonly System.IntPtr NativeFieldInfoPtr_CustomTravelBuffPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_EnableCheatChecks;
    [FieldOffset(0)]
    public Entity PlayerEntity;
    [FieldOffset(8)]
    public TeleportationType TeleportationType;
    [FieldOffset(12)]
    public Entity FromTarget;
    [FieldOffset(20)]
    public Entity ToTarget;
    [FieldOffset(28)]
    public PrefabGUID CustomTravelBuffPrefab;
    [FieldOffset(32)]
    public bool EnableCheatChecks;

    static TeleportationRequest()
    {
      Il2CppClassPointerStore<TeleportationRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (TeleportationRequest));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TeleportationRequest>.NativeClassPtr);
      TeleportationRequest.NativeFieldInfoPtr_PlayerEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportationRequest>.NativeClassPtr, nameof (PlayerEntity));
      TeleportationRequest.NativeFieldInfoPtr_TeleportationType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportationRequest>.NativeClassPtr, nameof (TeleportationType));
      TeleportationRequest.NativeFieldInfoPtr_FromTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportationRequest>.NativeClassPtr, nameof (FromTarget));
      TeleportationRequest.NativeFieldInfoPtr_ToTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportationRequest>.NativeClassPtr, nameof (ToTarget));
      TeleportationRequest.NativeFieldInfoPtr_CustomTravelBuffPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportationRequest>.NativeClassPtr, nameof (CustomTravelBuffPrefab));
      TeleportationRequest.NativeFieldInfoPtr_EnableCheatChecks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportationRequest>.NativeClassPtr, nameof (EnableCheatChecks));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TeleportationRequest>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
